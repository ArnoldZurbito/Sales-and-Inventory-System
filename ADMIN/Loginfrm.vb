Imports MySql.Data.MySqlClient
Imports System.Media

Public Class Loginfrm
    Dim con As New MySqlConnection("host=localhost; username=root; password=; database=red_cheese_pizza_dbase;")
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Dim path = System.Windows.Forms.Application.StartupPath
    Dim LogOnsound As String
    Dim MyPlayer As New SoundPlayer()

    Private Sub Loginfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        LogOnsound = "\LogOn.wav"

    End Sub
    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click

        If Len(Trim(UsernameTextBox.Text)) = 0 Then
            lblPrompt.Text = "Please Enter Username"
            UsernameTextBox.Focus()
            Exit Sub
        End If

        If Len(Trim(PasswordTextBox.Text)) = 0 Then
            lblPrompt.Text = "Please Enter Password"
            PasswordTextBox.Focus()
            Exit Sub
        End If


        Try

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM useraccount WHERE Username = sha1('" & UsernameTextBox.Text & "') and Password =sha1('" & PasswordTextBox.Text & "')"

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()




            dr = cmd.ExecuteReader

            If dr.HasRows = 0 Then
                lblPrompt.Text = "Account does'nt exist"
                con.Close()
            Else
                If UsernameTextBox.Text.Equals("admin", StringComparison.CurrentCultureIgnoreCase) Then
                    MyPlayer.SoundLocation = path & LogOnsound
                    MyPlayer.Play()
                    Me.Hide()
                    Manager_Interface.Show()
                Else
                    Me.Hide()
                    Crew_Interface.Show()
                End If
                lblPrompt.Text = "You Successfully Logged Out"
                con.Close()

            End If
            con.Close()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub UsernameTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles UsernameTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            PasswordTextBox.Focus()
        End If
    End Sub
    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        Manager_Interface.Label1.Text = "Hello," + " " + UsernameTextBox.Text + Environment.NewLine + " Welcome to Red Cheese Pizza"
        Crew_Interface.Label1.Text = "Hello," + " " + UsernameTextBox.Text + Environment.NewLine + "Welcome to Red Cheese Pizza"

    End Sub
    Private Sub UsernameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        Dim NotAllowed As String = "~`%^&+={[}]()!:,;'><?/|\-#+"

        'Allowed letters numbers and ( _ $ @ . *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PasswordTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PasswordTextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdLogin.Focus()
        End If
    End Sub
    Private Sub PasswordTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PasswordTextBox.KeyPress
        Dim NotAllowed As String = "~`%^&+={[}]()!:,;'><?/|\-#+"

        'Allowed letters numbers and ( _ $ @ * .)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

End Class
