Partial Class DataSet1
    Partial Public Class dtAdminReportDataTable
        Private Sub dtAdminReportDataTable_dtAdminReportRowChanging(sender As Object, e As dtAdminReportRowChangeEvent) Handles Me.dtAdminReportRowChanging

        End Sub

    End Class

    Partial Public Class dtRentalReportDataTable
        Private Sub dtRentalReportDataTable_dtRentalReportRowChanging(sender As Object, e As dtRentalReportRowChangeEvent) Handles Me.dtRentalReportRowChanging

        End Sub

    End Class

    Partial Public Class dtOrderReportsDataTable
        Private Sub dtOrderReportsDataTable_dtOrderReportsRowChanging(sender As Object, e As dtOrderReportsRowChangeEvent) Handles Me.dtOrderReportsRowChanging

        End Sub

        Private Sub dtOrderReportsDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.QuantityColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Public Class dtProductOrderDataTable
    End Class

    Partial Public Class dtSupplierDataTable
        Private Sub dtSupplierDataTable_dtSupplierRowChanging(sender As Object, e As dtSupplierRowChangeEvent) Handles Me.dtSupplierRowChanging

        End Sub

    End Class

    Partial Public Class dtProductDataTable
        Private Sub dtProductDataTable_dtProductRowChanging(sender As Object, e As dtProductRowChangeEvent) Handles Me.dtProductRowChanging

        End Sub

    End Class

    Partial Public Class dtOrderDataTable
        Private Sub dtOrderDataTable_dtOrderRowChanging(sender As Object, e As dtOrderRowChangeEvent) Handles Me.dtOrderRowChanging

        End Sub

    End Class

    Partial Public Class dtOverviewDataTable
    End Class
End Class

Namespace DataSet1TableAdapters
    
    Partial Public Class dtOverviewTableAdapter
    End Class
End Namespace
