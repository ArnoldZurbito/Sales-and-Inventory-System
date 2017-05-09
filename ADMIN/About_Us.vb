Public Class About_Us

    Public About As String

    Private Sub About_Us_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '  Modall.Show()
        Me.Hide()
    End Sub

    Private Sub About_Us_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label3.Text = About
        Me.TopMost = True
    End Sub

    Private Sub About_Us_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If Label3.Text = "admin" Then
        Modall.Show()
        Me.Hide()
        'Else
        '    Crew_Interface.Show()
        '    Me.Hide()
        'End If
    End Sub


End Class