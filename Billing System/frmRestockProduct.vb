Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmRestockProduct
    Public productid As String
    Private Sub frmRestockProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call loadInformation
    End Sub
    Private Sub loadInformation()
        Try
            If cn.State <> ConnectionState.Open Then
                cn.Open()
            End If

            sql = "SELECT Availability, Status, Amount FROM qryproducts WHERE ProductID = '" & productid & "'"
            cmd = New MySqlCommand(sql, cn)

            If Not dr.IsClosed Then
                dr.Close()
            End If

            dr = cmd.ExecuteReader

            If dr.Read = True Then
                cboAvailable.Text = dr("Availability").ToString
                cboStatus.Text = dr("Status").ToString
                txtAmt.Text = dr("Amount").ToString
            End If

        Catch ex As Exception
            MsgBox("An Error occurred frmRestockProduct(loadInformation): " & ex.Message)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If cboStatus.Text = "Item on Hold" AndAlso Not IsNothing(txtAmt.Text) AndAlso txtAmt.Text <> "0" Then
            If MsgBox("Do you want to update the order?", vbQuestion + vbYesNo) = vbYes Then
                Try
                    If cn.State <> ConnectionState.Open Then
                        cn.Open()
                    End If

                    sql = "UPDATE tblproduct SET Availability=@Availability, Status=@Status, Amount=@Amount WHERE ProductID = '" & productid & "'"
                    cmd = New MySqlCommand(sql, cn)

                    With cmd

                        .Parameters.AddWithValue("@Availability", False)
                        .Parameters.AddWithValue("@Status", False)

                        If cboAvailable.Text = "Available" Then
                            .Parameters("@Availability").Value = True
                        End If

                        If (cboStatus.Text = "Item on Hold") Then
                            .Parameters("@Status").Value = True
                        End If

                        .Parameters.AddWithValue("@Amount", txtAmt.Text)

                        .ExecuteNonQuery()

                    End With

                    Call frmManageSupplierProduct.loadProducts()
                Catch ex As Exception
                    MsgBox("An Error occurred frmRestockProduct(btnSave_Click): " & ex.Message)
                Finally
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                End Try
            End If
        Else
            MsgBox("Please input an amount to replenish stock if the item is on hold!", MsgBoxStyle.Critical, "Replenish Error")
        End If
    End Sub
End Class