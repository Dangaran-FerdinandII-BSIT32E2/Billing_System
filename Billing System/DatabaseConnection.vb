﻿Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Module DatabaseConnection
    Public cn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public sql As String

    Public Sub connection()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.ConnectionString = "server=localhost;user=root;password=;database=dbbilling"
        MsgBox("succes!")
    End Sub
End Module
