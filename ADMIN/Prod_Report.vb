Imports MySql.Data.MySqlClient
Public Class Prod_Report
    'Prod and Raw
    Private Sub Prod_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Display As New Print_Product_Report
            CrystalReportViewer1.ReportSource = Display
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class