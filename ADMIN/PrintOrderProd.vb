Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class PrintOrderProd
    Dim rptDoc As CrystalDecisions.CrystalReports.Engine.ReportDocument

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        rptDoc = New CusOrderProduct
        rptDoc.SetDataSource(Modall.dtgOrder.DataSource)
        CrystalReportViewer1.ReportSource = rptDoc
        'Try
        '    Dim Display As New CusOrderProduct
        '    CrystalReportViewer1.ReportSource = Display
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub PrintOrderProd_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    End Sub

    Private Sub PrintOrderProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class