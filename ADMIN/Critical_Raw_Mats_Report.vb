Public Class Critical_Raw_Mats_Report

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Try
            Dim Display As New Critical_Raw_Materials
            CrystalReportViewer1.ReportSource = Display
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Critical_Raw_Mats_Report_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    End Sub

    Private Sub Critical_Raw_Mats_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class