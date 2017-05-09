Imports MySql.Data.MySqlClient
Imports System.Media
Public Class Loginfrm

    Public path = System.Windows.Forms.Application.StartupPath
    Public LogOnsound As String
    Public MyPlayer As New SoundPlayer()
    Private Sub Loginfrm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim response As MsgBoxResult
        response = MsgBox("Do You Want To Close Entire System?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If response = MsgBoxResult.Yes Then
            Me.Hide()
        ElseIf response = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub
    Private Sub Loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearTextBoxLoad()
        Me.Hide()
        LogOnsound = "/LogOn.wav"
        Label1.Hide()
        lblcountAttempt.Hide()
    End Sub
    Private Sub UsernameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PasswordTextBox.Focus()
        End If
    End Sub
    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdLogin.PerformClick()
        End If
    End Sub
    Private Sub UsernameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz0987654321"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PasswordTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz0987654321._"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        If PasswordTextBox.Text = "" And UsernameTextBox.Text = "" Then
            lblPrompt.Text = "  Please Enter Username and Password"
            UsernameTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(UsernameTextBox.Text)) = 0 Then
            lblPrompt.Text = "          Please Enter Username"
            UsernameTextBox.Focus()
            Exit Sub
        ElseIf Len(Trim(PasswordTextBox.Text)) = 0 Then
            lblPrompt.Text = "          Please Enter Password"
            PasswordTextBox.Focus()
            Exit Sub
        Else
            LOGIN(UsernameTextBox.Text.ToString.ToLower, PasswordTextBox.Text)
        End If
    End Sub


End Class

