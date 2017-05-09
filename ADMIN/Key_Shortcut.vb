Public Class Key_Shortcut

    Private Sub Key_Shortcut_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
    End Sub

    Private Sub Key_Shortcut_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.B AndAlso e.Control Then
            Import_and_Export.cmbImport.PerformClick()
        ElseIf e.KeyCode = Keys.R AndAlso e.Control Then
            Import_and_Export.cmbExport.PerformClick()
        End If
    End Sub

    Private Sub Key_Shortcut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
End Class