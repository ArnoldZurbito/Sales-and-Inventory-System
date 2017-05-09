Public Class Print_Raw_Material
    'Raw
    Private Sub Print_Raw_Material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Display As New Print_Raw_Mats
            CrystalReportViewer1.ReportSource = Display
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class