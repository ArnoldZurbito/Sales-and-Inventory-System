Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Available_Prod_Report



    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            Dim Displa As New Available_Product
            CrystalReportViewer1.ReportSource = Displa
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Available_Prod_Report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    End Sub

    Private Sub Available_Prod_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class