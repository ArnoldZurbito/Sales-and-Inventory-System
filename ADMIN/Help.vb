Public Class Help

    Public Help As String

    Private Sub Help_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Modall.Show()
        Me.Hide()
    End Sub
    Public Sub AdminNum()
        Try
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "select user_table.Contact_Num from user_table inner join user_account on user_table.User_Company_ID = user_account.User_Company_ID " _
                               & " where user_account.Account_Type = 'ADMIN'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    Label5.Text = objdr.GetString("Contact_Num")
                End While
            End If
            objconn.Dispose()
            objconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TopMost = True
        AdminNum()
        Label4.Text = Help

        RichTextBox1.Visible = True
        RichTextBox1.ReadOnly = True
        RichTextBox2.Visible = False
        RichTextBox2.ReadOnly = True
        RichTextBox3.Visible = False
        RichTextBox3.ReadOnly = True
        RichTextBox4.Visible = False
        RichTextBox4.ReadOnly = True
        RichTextBox5.Visible = False
        RichTextBox5.ReadOnly = True
        ListBox1.Visible = True

        With ListBox1.Items
            .Add(" I am a registerd personnel but i can't sign in")
            .Add("How to modify the raw materials or products?")
            .Add("How to add new raw materials or products?")
            .Add("How to remove existing raw materials or products?")
            .Add("Where can I find the list of the records?")
        End With

    End Sub
    Private Sub cmbhelpSerch_Click(sender As System.Object, e As System.EventArgs) Handles cmbhelpSerch.Click

        Dim count As Integer = (ListBox1.Items.Count - 1)
        Dim words As String
        If txthelpSearch.Text = "" Then
            MessageBox.Show("Provide some problem you have been encounter on this system .", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txthelpSearch.BackColor = Color.Wheat
            txthelpSearch.Focus()
        Else

            For a = 0 To count
                words = ListBox1.Items.Item(a)
                If InStr(words.ToLower, txthelpSearch.Text.ToLower) Then
                    ListBox1.SelectedItem = words
                End If
            Next

            If ListBox1.SelectedIndex = 0 Then
                RichTextBox1.Visible = True
                RichTextBox2.Visible = False
                RichTextBox3.Visible = False
                RichTextBox4.Visible = False
                RichTextBox5.Visible = False
            ElseIf ListBox1.SelectedIndex = 1 Then
                RichTextBox1.Visible = False
                RichTextBox2.Visible = True
                RichTextBox3.Visible = False
                RichTextBox4.Visible = False
                RichTextBox5.Visible = False
            ElseIf ListBox1.SelectedIndex = 2 Then
                RichTextBox1.Visible = False
                RichTextBox2.Visible = False
                RichTextBox3.Visible = True
                RichTextBox4.Visible = False
                RichTextBox5.Visible = False
            ElseIf ListBox1.SelectedIndex = 3 Then
                RichTextBox1.Visible = False
                RichTextBox2.Visible = False
                RichTextBox3.Visible = False
                RichTextBox4.Visible = False
                RichTextBox5.Visible = True
            ElseIf ListBox1.SelectedIndex = 4 Then
                RichTextBox1.Visible = False
                RichTextBox2.Visible = False
                RichTextBox3.Visible = False
                RichTextBox4.Visible = True
                RichTextBox5.Visible = False

            End If

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        Me.Hide()
        Modall.Enabled = True
        'If Label4.Text = "admin" Then
        '    Manager_Interface.Show()
        '    Me.Hide()
        'Else
        '    Crew_Interface.Show()
        '    Me.Hide()
        'End If
    End Sub
    Private Sub Help_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'If Label4.Text = "admin" Then
        '    Manager_Interface.Show()
        '    Me.Hide()
        'Else
        '    Crew_Interface.Show()
        '    Me.Hide()
        'End If
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        Me.Hide()
        Modall.Show()
    End Sub

    Private Sub txthelpSearch_TextChanged(sender As Object, e As EventArgs) Handles txthelpSearch.TextChanged
        txthelpSearch.BackColor = Color.White
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class