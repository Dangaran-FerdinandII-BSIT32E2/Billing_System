Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class frmPaymentInformation

    Public billingid As String
    Public customerid As String
    Dim d As OpenFileDialog = New OpenFileDialog

    Dim totalPaid As Double = 0.0

    Private collectionid As String

    Private Sub frmPaymentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

        pbxDepositSlip.Image = Nothing

        Call loadPayment()
        Call loadOrder()
    End Sub
    Private Sub loadPayment()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            totalPaid = 0.0

            sql = "SELECT * FROM tblcollection WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Dim updateDB As New MySqlCommand
            updateDB.Connection = cn

            Do While dr.Read = True
                x = New ListViewItem(dr("AmtPaid").ToString)
                x.SubItems.Add(dr("DatePaid").ToString)

                If dr("newInsert") = True Then
                    updateDB.CommandText = "UPDATE tblcollection SET newInsert = 0 WHERE BillingID = '" & billingid & "'"

                    dr.Close()
                    updateDB.ExecuteNonQuery()

                    cmd = New MySqlCommand(sql, cn)
                    dr = cmd.ExecuteReader
                    Continue Do
                End If

                If Convert.ToDateTime(dr("DatePaid")).Date = DateTime.Today AndAlso dr("Status") = False Then
                    x.ForeColor = Color.Red
                End If

                x.SubItems.Add(If(dr("Type") = 1, "Post-Dated Cheque", "Deposit Slip"))

                ListView1.Items.Add(x)

                If dr("Status") = 2 Then
                    totalPaid += Convert.ToDouble(dr("AmtPaid"))
                End If
            Loop

            dr.Close()

            Call loadInformation()
            Call updateRemark()
        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(loadPayment): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub loadInformation()
        Using cn As New MySqlConnection("server=localhost;user=root;password=;database=dbbilling")
            cn.Open()
            sql = "SELECT CompanyName, FinalPrice, DATE_FORMAT(DueDate, '%M %d, %Y') AS DueDate FROM tblbilling WHERE BillingID = '" & billingid & "'"
            Using cmd As New MySqlCommand(sql, cn)
                Using dr = cmd.ExecuteReader
                    If dr.Read = True Then
                        lblCompanyName.Text = dr("CompanyName").ToString()
                        lblOutstandingBalance.Text = (dr("FinalPrice") - totalPaid).ToString
                        lblTotalAmountDue.Text = dr("FinalPrice").ToString
                        lblTotalPayment.Text = totalPaid
                        ' txtDueDate.Text = dr("DueDate").ToString
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub loadOrder()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT LPAD(c.CollectionID, 4, '0') AS CollectionID, DATE_FORMAT(b.DatePrinted, '%m%d') AS DatePrinted, o.OrderID FROM tblcollection c INNER JOIN tblbilling b ON c.BillingID = b.BillingID INNER JOIN tblorder o ON c.CustomerID = o.CustomerID WHERE b.BillingID = '" & billingid & "' GROUP BY c.CollectionID"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                lblBillNo.Text = "Billing #" & billingid
                lblPONo.Text = billingid
                lblInvoiceNo.Text = dr("DatePrinted").ToString & "-" & dr("CollectionID").ToString
                lblOrderNo.Text = dr("OrderID").ToString
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(loadOrder): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub updateRemark()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblbilling SET Remarks=@Remarks WHERE BillingID = '" & billingid & "'"
            cmd = New MySqlCommand(sql, cn)
            If Convert.ToDouble(lblOutstandingBalance.Text) <= totalPaid Then
                cmd.Parameters.AddWithValue("@Remarks", "1")
            Else
                cmd.Parameters.AddWithValue("@Remarks", "0")
            End If
            cmd.ExecuteNonQuery()

            Dim startDate As String = frmManageCollectionV3.DateFilter1.Text

            Dim endDate As String = frmManageCollectionV3.DateFilter2.Text

            Call frmManageCollectionV3.loadCollections(startDate, endDate)
        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(updateRemark): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Dim uploaded As Boolean? = False
    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            d.Filter = "JPEG(*.jpg; *.jpeg)|*.jpg|PNG(*.png)|*.png"

            If d.ShowDialog() = Windows.Forms.DialogResult.OK Then
                pbxDepositSlip.Image = Image.FromFile(d.FileName)

                btnReject.Enabled = True
                uploaded = True

                btnAccept.Enabled = True
                btnReject.Enabled = True
            End If
        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(btnUpload_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If MsgBox("Do you want to approve?", vbYesNo + vbQuestion) = vbYes Then
            If uploaded Then
                Call insertPostDatedCheck()
            Else
                Call updateDepositSlip()
            End If
        End If

    End Sub

    Public amount As Double = 0
    Private Sub insertPostDatedCheck()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            frmEnterQuantity.ShowDialog()

            If pbxDepositSlip.Image IsNot Nothing Then
                Dim mstream As New System.IO.MemoryStream()
                pbxDepositSlip.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = mstream.GetBuffer
                mstream.Close()

                sql = "INSERT INTO tblcollection(BillingID, CustomerID, AmtPaid, DatePaid, imgPayment, Status, newInsert, Type) " &
                    "VALUES(@BillingID, @CustomerID, @AmtPaid, @DatePaid, @imgPayment, @Status, @newInsert, @Type)"
                cmd = New MySqlCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@BillingID", billingid)
                    .Parameters.AddWithValue("@CustomerID", customerid)
                    .Parameters.AddWithValue("@AmtPaid", amount)
                    .Parameters.AddWithValue("@DatePaid", DateTime.Now)
                    .Parameters.AddWithValue("@imgPayment", arrImage)
                    .Parameters.AddWithValue("@Status", 2)
                    .Parameters.AddWithValue("@newInsert", 1)
                    .Parameters.AddWithValue("@Type", 1)
                    .ExecuteNonQuery()
                End With

                btnAccept.Enabled = False
                btnReject.Enabled = False

                pbxDepositSlip.Image = Nothing

                Call loadPayment()

            End If

        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(btnSave_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub updateDepositSlip()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "UPDATE tblcollection SET Status = 2 WHERE CollectionID = '" & collectionid & "'"
            cmd = New MySqlCommand(sql, cn)
            cmd.ExecuteNonQuery()

            btnAccept.Enabled = False
            btnReject.Enabled = False

            pbxDepositSlip.Image = Nothing

            Call loadPayment()
        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(btnSave_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs)
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            If MsgBox("Do you want to reject?", vbYesNo + vbQuestion) = vbYes Then
                sql = "UPDATE tblcollection SET Status = 1 WHERE CollectionID = '" & collectionid & "'"
                cmd = New MySqlCommand(sql, cn)
                cmd.ExecuteNonQuery()

                btnAccept.Enabled = False
                btnReject.Enabled = False

                pbxDepositSlip.Image = Nothing

                Call loadPayment()
            End If

        Catch ex As Exception
            MsgBox("An error occurred frmPaymentInformation(btnSave_Click): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            Try
                If cn.State <> ConnectionState.Open Then
                    cn.Open()
                End If

                sql = "SELECT imgPayment, CollectionID FROM tblcollection WHERE BillingID = '" & billingid & "'"
                cmd = New MySqlCommand(sql, cn)

                If Not dr.IsClosed Then
                    dr.Close()
                End If

                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    Dim pic As Byte() = DirectCast(dr("imgPayment"), Byte())
                    If pic.Length > 0 Then
                        Using ms As New MemoryStream(pic)
                            pbxDepositSlip.Image = Image.FromStream(ms)
                        End Using

                        collectionid = dr("CollectionID").ToString

                        btnAccept.Enabled = True
                        btnReject.Enabled = True
                    End If
                End If
            Catch ex As Exception
                MsgBox("An error occurred frmPaymentInformation(ListView1_SelectedIndexChanged): " & ex.Message)
            Finally
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub frmPaymentInformation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            pbxDepositSlip.Image = Nothing

            Call frmManageCollectionV3.loadCollections(frmManageCollectionV3.DateFilter1.Text, frmManageCollectionV3.DateFilter2.Text)
        End If
    End Sub
    Private Sub loadActivity()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "INSERT INTO tblactivity(UserID, Username, DateTime, Action) VALUES(@UserID, @Username, @DateTime, @Action)"
            cmd = New MySqlCommand(sql, cn)
            With cmd
                .Parameters.AddWithValue("@UserID", frmLoginV2.userid)
                .Parameters.AddWithValue("@Username", frmLoginV2.username)
                .Parameters.AddWithValue("@DateTime", DateTime.Now)
                .Parameters.AddWithValue("@Action", "Saved Payment for")
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MsgBox("An error occurred frmAdminSettings(loadActivity): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnUpload_Click_1(sender As Object, e As EventArgs) Handles btnUpload.Click
        frmUploadCheque.ShowDialog()
    End Sub
End Class