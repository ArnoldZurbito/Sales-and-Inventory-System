Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Import_and_Export
    Public Import As String
    Public prog_name As String = "RCP: Sales and Inventory System"
    Public prog_message_caption As String = prog_name.ToString & " Message"
    Dim file As String

    Private Sub Import_and_Export_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If Label4.Text = "admin" Then
        Modall.Show()
        Me.Hide()
        'Else
        '    Crew_Interface.Show()
        '    Me.Hide()
        'End If
    End Sub

    Private Sub Import_and_Export_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        Me.Hide()
    End Sub

    Private Sub Import_and_Export_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.B AndAlso e.Control Then
            cmbImport.PerformClick()
        ElseIf e.KeyCode = Keys.R AndAlso e.Control Then
            cmbExport.PerformClick()
        End If
    End Sub

    Private Sub Import_and_Export_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label4.Text = Import
        Label3.Hide()
        ProgressBar1.Hide()
        Me.TopMost = True
    End Sub


    Private Sub cmbExport_Click(sender As Object, e As EventArgs) Handles cmbExport.Click
        If ofd.ShowDialog = DialogResult.OK Then
            ProgressBar1.Show()
            Label3.Show()
            ProgressBar1.Value = ProgressBar1.Value + 100
            Label3.Text = "Status : Finish !"
            file = ofd.FileName
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\wamp64\bin\mysql\mysql5.7.11\bin"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim myStreamReader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql -uroot  red_cheese_pizza_database < """ + file + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            question = MessageBox.Show("Database restoration has been successfully executed!", prog_message_caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' MessageBox.Show("Backup created successfully!", prog_message_caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
            If question = MsgBoxResult.Ok Then
                ProgressBar1.Value = 0
                ProgressBar1.Hide()
                Label3.Hide()
            End If
        End If
    End Sub
    Private Sub ofd_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles ofd.FileOk
        Try
            Dim sqlurl As String = ofd.FileName
            If sqlurl = "" Then
                Exit Sub
            End If
            'TextBox2.Text = sqlurl
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbImport_Click(sender As Object, e As EventArgs) Handles cmbImport.Click
        sfd.Filter = "SQL Dump File (*.sql)|*.sql|All Files (*.*)|(*.*)"
        sfd.FileName = DateTime.Now.ToString("mm-dd-yyyy hh-mm-ss") + " Database RCPCorp." + ".sql"
        If sfd.ShowDialog = DialogResult.OK Then
            ProgressBar1.Show()
            Label3.Show()
            ProgressBar1.Value = ProgressBar1.Value + 100
            Label3.Text = "Status : Finish !"
            file = sfd.FileName
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\wamp64\bin\mysql\mysql5.7.11\bin"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim myStreamReader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysqldump -uroot red_cheese_pizza_database > """ + file + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            question = MessageBox.Show("Backup created successfully!", prog_message_caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

            If question = MsgBoxResult.Ok Then
                ProgressBar1.Value = 0
                ProgressBar1.Hide()
                Label3.Hide()
            End If
        End If
       
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            ProgressBar1.Hide()

        End If
    End Sub


End Class