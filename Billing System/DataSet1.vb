Partial Class DataSet1
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
