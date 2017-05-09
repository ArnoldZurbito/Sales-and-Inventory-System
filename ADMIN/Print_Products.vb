Public Class Print_Products
    'Prod
    Private Sub Print_Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Display As New Prod_Print_Report
            CrystalReportViewer1.ReportSource = Display
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class