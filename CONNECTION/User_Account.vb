Imports MySql.Data.MySqlClient
Public Class User_Account
    Public input1 As String
    Public input2 As String
    Public input3 As String
    Public input4 As String
    Public input5 As String
    Public input6 As String
    Public input7 As String
    Public user_act As String

    Public Cell1 As String
    Public Cell2 As String
    Public Cell3 As String
    Public Cell4 As String
    Public Cell5 As String

    Public Alis As String


    Public Sub fillUser()
        Dim StrConnection As String = "server=localhost;user id=root;  database=red_cheese_pizza_database"
        Dim connectdbase As New MySqlConnection
        Try
            With connectdbase
                .ConnectionString = StrConnection
                .Open()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Dim dtabler As New DataTable
        Dim dadapterer As New MySqlDataAdapter("SELECT user_table.user_company_ID,Firstname,Middlename,Lastname,Concat(`Firstname`,' ',`Middlename`,' ',`Lastname`) As 'Fullname',Contact_Num, " & _
                                               "user_account.Username,Password,Account_Type from User_Account INNER JOIN user_table ON " & _
                                                "user_account.User_Company_ID=user_table.User_Company_ID order by Firstname ASC", connectdbase)
        dadapterer.Fill(dtabler)
        DataGridView2.DataSource = dtabler
        dadapterer.Dispose()
        dadapterer = Nothing
        dtabler.Dispose()
        dtabler = Nothing
        connectdbase.Dispose()
        connectdbase = Nothing
    End Sub

    Private Sub User_Account_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Modall.Show()
    End Sub

    Private Sub User_Account_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
    End Sub
    Private Sub User_Account_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillUser()
        False_Enabled_User_Account_Function()
        btnCHANGE.Enabled = False
        btnCLEAR.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Enabled = False
        btnCANCEL.Hide()
        btnUpdate.Hide()
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Hide()
        'Modall.Show()
        Modall.Enabled = True
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        If btnFname.Text = "" Then
            MessageBox.Show("Enter Firstname", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnFname.BackColor = Color.PapayaWhip
            btnFname.Focus()
        ElseIf btnLname.Text = "" Then
            MessageBox.Show("Enter Lastname", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnLname.BackColor = Color.PapayaWhip
            btnLname.Focus()
        ElseIf btnNum.Text = "" Then
            MessageBox.Show("Enter Contact Phone Number", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnNum.BackColor = Color.PapayaWhip
            btnNum.Focus()
        ElseIf btnUser.Text = "" Then
            MessageBox.Show("Enter Username", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnUser.BackColor = Color.PapayaWhip
            btnUser.Focus()
        ElseIf btnPass.Text = "" Then
            MessageBox.Show("Enter Password", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnPass.BackColor = Color.PapayaWhip
            btnPass.Focus()
        ElseIf IsNothing(cmbAccType.SelectedItem) Then
            MessageBox.Show("Select Account Type of a User you want to add.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbAccType.BackColor = Color.PapayaWhip
            cmbAccType.Focus()
        Else
            If btnNum.Text < 11 Then
                MsgBox("Contact Number Must be 11 Digits Maximum Length.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
            Else
                input1 = btnFname.Text.Trim
                input2 = btnLname.Text.Trim
                input3 = btnMname.Text.Trim
                input4 = btnNum.Text.Trim
                input5 = btnUser.Text.Trim
                input6 = btnPass.Text.Trim
                input7 = cmbAccType.Text.Trim
                Try
                    objconn.Open()
                    objcmd.Connection = objconn
                    objcmd.CommandType = CommandType.Text
                    objcmd.CommandText = "select * from user_account where username = SHA1('" & input5 & "')"
                    objdr = objcmd.ExecuteReader

                    'With objcmd
                    '    objdr.objcmd("Select * from user_account where username = Sha1('" & input5 & "') and password = Sha1('" & input4 & "')")
                    'End With
                    'If objdr.GetHashCode Then
                    '    Do While 
                    '        If 

                    '    End While

                    '        End If
                    If objdr.HasRows Then
                        MessageBox.Show("Username Already Exists, choose Another Account.", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        Dim asked As MsgBoxResult
                        asked = MsgBox("Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If asked = MsgBoxResult.Yes Then


                            Try
                                objconn = New MySqlConnection
                                objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                                objconn.Open()
                                With objcmd
                                    .Connection = objconn
                                    .CommandText = "Insert into user_table(User_Company_ID,Firstname,Middlename,Lastname,Contact_Num) values " & _
                                        " (NULL,'" & CStr(input1) & "','" & CStr(input3) & "','" & CStr(input2) & "'," & CStr(input4) & ");" & _
                                          "insert into user_account(User_ID,username,password,Account_Type,User_company_ID) values" & _
                                          "(NULL,SHA1('" & input5 & "'),SHA1('" & input6 & "'),'" & input7 & "',LAST_INSERT_ID());"
                                    .ExecuteNonQuery()
                                End With

                                With objcmd
                                    .Connection = objconn
                                    .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,' Admin add new account to " & input1 & " " & input2 & ". " & input3 & " at ' ,CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "'))"
                                    .ExecuteNonQuery()
                                End With


                                ' Records.ListBox1.Items.Add(" " & user_act  & " were added new account raw material which is " & ProdName & " to " & ProdFrom & " on -" & Format(DateTime.Now) & " " & Environment.NewLine)
                                objconn.Close()


                                fillUser()
                                btnADD.Enabled = True
                                btnCANCEL.Hide()
                                btnCLEAR.Enabled = False
                                btnDELETE.Enabled = False
                                btnSAVE.Enabled = False
                                btnUpdate.Hide()
                                btnCHANGE.Enabled = False
                                User_Account_clear_function()
                                False_Enabled_User_Account_Function()
                                MsgBox("New Account were Added !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                            Catch ex As Exception
                                MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                            End Try
                        ElseIf asked = MsgBoxResult.No Then
                            Exit Sub
                        End If
                    End If
                    'objconn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    objconn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        True_Enabled_User_Account_Function()
        btnADD.Enabled = False
        btnSAVE.Enabled = True
        ' btnCLEAR.Enabled = True
        btnCANCEL.Show()
        User_Account_clear_function()
        btnUpdate.Hide()
    End Sub

    Private Sub btnCLEAR_Click(sender As Object, e As EventArgs) Handles btnCLEAR.Click
        User_Account_clear_function()
        btnCHANGE.Enabled = False
        btnDELETE.Enabled = False
    End Sub

    Private Sub btnNum_KeyDown(sender As Object, e As KeyEventArgs) Handles btnNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUser.Focus()
        End If
    End Sub

    Private Sub btnNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnNum.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Then e.Handled = False
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        If e.RowIndex >= 0 Then
            DataGridView2.Rows(e.RowIndex).ToString()
            TextBox2.Text = DataGridView2(0, DataGridView2.CurrentRow.Index).Value.ToString()
            btnFname.Text = DataGridView2(1, DataGridView2.CurrentRow.Index).Value.ToString()
            btnMname.Text = DataGridView2(2, DataGridView2.CurrentRow.Index).Value.ToString()
            btnLname.Text = DataGridView2(3, DataGridView2.CurrentRow.Index).Value.ToString()
            btnNum.Text = DataGridView2(5, DataGridView2.CurrentRow.Index).Value.ToString()
            btnUser.Text = DataGridView2(6, DataGridView2.CurrentRow.Index).Value.ToString()
            txtUName.Text = DataGridView2(6, DataGridView2.CurrentRow.Index).Value.ToString()
            btnPass.Text = DataGridView2(7, DataGridView2.CurrentRow.Index).Value.ToString()
            txtUpass.Text = DataGridView2(7, DataGridView2.CurrentRow.Index).Value.ToString()
            cmbAccType.Text = DataGridView2(8, DataGridView2.CurrentRow.Index).Value.ToString()
            btnCHANGE.Enabled = True
            btnDELETE.Enabled = True
        End If
        Try
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "SELECT  User_Company_ID FROM user_account where Password = '" & btnPass.Text & "'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    TextBox3.Text = objdr.GetString("User_Company_ID")
                End While
            End If
            objconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
        End Try
    End Sub

    Private Sub btnMname_KeyDown(sender As Object, e As KeyEventArgs) Handles btnMname.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLname.Focus()
        End If
    End Sub
    Private Sub btnMname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnMname.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub btnCANCEL_Click(sender As Object, e As EventArgs) Handles btnCANCEL.Click
        False_Enabled_User_Account_Function()
        btnCHANGE.Enabled = False
        btnCLEAR.Enabled = False
        btnDELETE.Enabled = False
        btnSAVE.Show()
        btnUpdate.Hide()
        btnSAVE.Enabled = False
        btnCANCEL.Hide()
        btnADD.Enabled = True
        User_Account_clear_function()
    End Sub

    Private Sub btnFname_KeyDown(sender As Object, e As KeyEventArgs) Handles btnFname.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnMname.Focus()
        End If
    End Sub

    Private Sub btnFname_TextChanged(sender As Object, e As EventArgs) Handles btnFname.TextChanged
        If btnFname.Text = "" Then
            btnCLEAR.Enabled = False
        Else
            btnCLEAR.Enabled = True
        End If
    End Sub

    Private Sub btnLname_KeyDown(sender As Object, e As KeyEventArgs) Handles btnLname.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnNum.Focus()
        End If
    End Sub

    Private Sub btnLname_TextChanged(sender As Object, e As EventArgs) Handles btnLname.TextChanged

    End Sub

    Private Sub cmbAccType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbAccType.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmbAccType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAccType.SelectedIndexChanged

    End Sub

    Private Sub btnCHANGE_Click(sender As Object, e As EventArgs) Handles btnCHANGE.Click
        True_Enabled_User_Account_Function()
        btnADD.Enabled = False
        btnSAVE.Hide()
        btnUpdate.Show()
        btnCHANGE.Enabled = False
        btnDELETE.Enabled = False
        btnCANCEL.Enabled = True
        btnCANCEL.Show()
    End Sub
    Private Sub btnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        Dim asking As MsgBoxResult
        asking = MsgBox("Are you sure  you want to remove permission of this account to access in our system ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If asking = MsgBoxResult.Yes Then
            input1 = btnFname.Text.Trim
            input2 = btnMname.Text.Trim
            input3 = btnLname.Text.Trim
            Try
                objconn.Open()
                Alis = "Delete from user_table where user_company_Id = " & TextBox2.Text & ""
                objcmd = New MySqlCommand(Alis, objconn)
                objdr = objcmd.ExecuteReader
                'Records.ListBox1.Items.Add(" " & TextBox2.Text & " remove the Raw Material name " & CStr(CheckedListBox1.CheckedItems(category).ToString()) & " on -" & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()

                objconn.Open()
                With objcmd
                    .Connection = objconn
                    .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,' Admin remove an account of " & input1 & " " & input2 & " " & input3 & " at ' ,CURRENT_TIMESTAMP,  (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "'))"
                    .ExecuteNonQuery()
                End With
                objconn.Close()

                fillUser()
                User_Account_clear_function()
                False_Enabled_User_Account_Function()
                btnCHANGE.Enabled = False
                btnDELETE.Enabled = False
                MsgBox("Successfully Deleted  !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "REMOVE")
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
            End Try

        ElseIf asking = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If cmbAccType.Text = "ADMIN" Then
            question = MsgBox("Are you sure  you want to update your own account?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If question = MsgBoxResult.Yes Then
                If txtUName.Text = btnUser.Text And txtUpass.Text = btnPass.Text Then
                    objconn.Open()
                    ModifyQuerys = "UPDATE user_table set user_table.Firstname = '" & btnFname.Text & "',Middlename='" & btnMname.Text & "',Lastname='" & btnLname.Text & "',Contact_Num=" & btnNum.Text & " where User_Company_ID = " & CInt(TextBox3.Text) & " ;" _
                         & " update user_account set user_account.Account_Type='" & CStr(cmbAccType.Text) & "' where User_Company_ID = " & CInt(TextBox3.Text) & ";"
                    objcmd = New MySqlCommand(ModifyQuerys, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()
                    fillUser()
                    btnADD.Enabled = True
                    btnCANCEL.Hide()
                    btnCLEAR.Enabled = False
                    btnDELETE.Enabled = False
                    btnSAVE.Show()
                    btnUpdate.Hide()
                    btnCHANGE.Enabled = False
                    User_Account_clear_function()
                    False_Enabled_User_Account_Function()
                    MsgBox("Sucessfully Updated.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
                ElseIf txtUName.Text <> btnUser.Text And txtUpass.Text <> btnPass.Text Then
                    objconn.Open()
                    ModifyQuerys = "UPDATE user_table set user_table.Firstname = '" & btnFname.Text & "',Middlename='" & btnMname.Text & "',Lastname='" & btnLname.Text & "',Contact_Num=" & btnNum.Text & " where User_Company_ID = " & CInt(TextBox3.Text) & " ;" _
                                & " update user_account set user_account.Username = Sha1('" & btnUser.Text & "'),user_account.Password=Sha1('" & btnPass.Text & "'),user_account.Account_Type='" & CStr(cmbAccType.Text) & "' where User_Company_ID = " & CInt(TextBox3.Text) & ";"
                    objcmd = New MySqlCommand(ModifyQuerys, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()
                    fillUser()
                    btnADD.Enabled = True
                    btnCANCEL.Hide()
                    btnCLEAR.Enabled = False
                    btnDELETE.Enabled = False
                    btnSAVE.Show()
                    btnUpdate.Hide()
                    btnCHANGE.Enabled = False
                    User_Account_clear_function()
                    False_Enabled_User_Account_Function()
                    MsgBox("Use this new account next time you sign in.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESSFULLY UPDATED")
                ElseIf txtUName.Text <> btnUser.Text And txtUpass.Text = btnPass.Text Then
                    objconn.Open()
                    ModifyQuerys = "UPDATE user_table set user_table.Firstname = '" & btnFname.Text & "',Middlename='" & btnMname.Text & "',Lastname='" & btnLname.Text & "',Contact_Num=" & btnNum.Text & " where User_Company_ID = " & CInt(TextBox3.Text) & " ;" _
                                & " update user_account set user_account.Username = Sha1('" & btnUser.Text & "'),user_account.Account_Type='" & CStr(cmbAccType.Text) & "' where User_Company_ID = " & CInt(TextBox3.Text) & ";"
                    objcmd = New MySqlCommand(ModifyQuerys, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()
                    fillUser()
                    btnADD.Enabled = True
                    btnCANCEL.Hide()
                    btnCLEAR.Enabled = False
                    btnDELETE.Enabled = False
                    btnSAVE.Show()
                    btnUpdate.Hide()
                    btnCHANGE.Enabled = False
                    User_Account_clear_function()
                    False_Enabled_User_Account_Function()
                    MsgBox("Use this new account next time you sign in.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESSFULLY UPDATED")

                ElseIf txtUName.Text = btnUser.Text And txtUpass.Text <> btnPass.Text Then
                    objconn.Open()
                    ModifyQuerys = "UPDATE user_table set user_table.Firstname = '" & btnFname.Text & "',Middlename='" & btnMname.Text & "',Lastname='" & btnLname.Text & "',Contact_Num=" & btnNum.Text & " where User_Company_ID = " & CInt(TextBox3.Text) & " ;" _
                                & " update user_account set user_account.Password = Sha1('" & btnPass.Text & "'),user_account.Account_Type='" & CStr(cmbAccType.Text) & "' where User_Company_ID = " & CInt(TextBox3.Text) & ";"
                    objcmd = New MySqlCommand(ModifyQuerys, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()
                    fillUser()
                    btnADD.Enabled = True
                    btnCANCEL.Hide()
                    btnCLEAR.Enabled = False
                    btnDELETE.Enabled = False
                    btnSAVE.Show()
                    btnUpdate.Hide()
                    btnCHANGE.Enabled = False
                    User_Account_clear_function()
                    False_Enabled_User_Account_Function()
                    MsgBox("Use this new account next time you sign in.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESSFULLY UPDATED")
                End If
            ElseIf question = MsgBoxResult.No Then
                Exit Sub
            End If
        ElseIf cmbAccType.Text = "CREW" Then
            question = MsgBox("Are you sure  you want to update with an account name of'" & btnFname.Text & "  " & btnLname.Text & "' ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If question = MsgBoxResult.Yes Then
                If txtUName.Text = btnUser.Text And txtUpass.Text = btnPass.Text Then
                    objconn.Open()
                    ModifyQuerys = "UPDATE user_table set user_table.Firstname = '" & btnFname.Text & "',Middlename='" & btnMname.Text & "',Lastname='" & btnLname.Text & "',Contact_Num=" & btnNum.Text & " where User_Company_ID = " & CInt(TextBox3.Text) & " ;" _
                         & " update user_account set user_account.Account_Type='" & CStr(cmbAccType.Text) & "' where User_Company_ID = " & CInt(TextBox3.Text) & ";"
                    objcmd = New MySqlCommand(ModifyQuerys, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()
                    fillUser()
                    btnADD.Enabled = True
                    btnCANCEL.Hide()
                    btnCLEAR.Enabled = False
                    btnDELETE.Enabled = False
                    btnSAVE.Show()
                    btnUpdate.Hide()
                    btnCHANGE.Enabled = False
                    User_Account_clear_function()
                    False_Enabled_User_Account_Function()
                    MsgBox("Sucessfully Updated.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
                ElseIf txtUName.Text <> btnUser.Text And txtUpass.Text <> btnPass.Text Then
                    objconn.Open()
                    ModifyQuerys = "UPDATE user_table set user_table.Firstname = '" & btnFname.Text & "',Middlename='" & btnMname.Text & "',Lastname='" & btnLname.Text & "',Contact_Num=" & btnNum.Text & " where User_Company_ID = " & CInt(TextBox3.Text) & " ;" _
                                & " update user_account set user_account.Username = Sha1('" & btnUser.Text & "'),user_account.Password=Sha1('" & btnPass.Text & "'),user_account.Account_Type='" & CStr(cmbAccType.Text) & "' where User_Company_ID = " & CInt(TextBox3.Text) & ";"
                    objcmd = New MySqlCommand(ModifyQuerys, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()
                    fillUser()
                    btnADD.Enabled = True
                    btnCANCEL.Hide()
                    btnCLEAR.Enabled = False
                    btnDELETE.Enabled = False
                    btnSAVE.Show()
                    btnUpdate.Hide()
                    btnCHANGE.Enabled = False
                    User_Account_clear_function()
                    False_Enabled_User_Account_Function()
                    MsgBox("Kindly contact those Crew, and give their new username and password. Thank you.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESSFULLY UPDATED")
                ElseIf txtUName.Text <> btnUser.Text And txtUpass.Text = btnPass.Text Then
                    objconn.Open()
                    ModifyQuerys = "UPDATE user_table set user_table.Firstname = '" & btnFname.Text & "',Middlename='" & btnMname.Text & "',Lastname='" & btnLname.Text & "',Contact_Num=" & btnNum.Text & " where User_Company_ID = " & CInt(TextBox3.Text) & " ;" _
                                & " update user_account set user_account.Username = Sha1('" & btnUser.Text & "'),user_account.Account_Type='" & CStr(cmbAccType.Text) & "' where User_Company_ID = " & CInt(TextBox3.Text) & ";"
                    objcmd = New MySqlCommand(ModifyQuerys, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()
                    fillUser()
                    btnADD.Enabled = True
                    btnCANCEL.Hide()
                    btnCLEAR.Enabled = False
                    btnDELETE.Enabled = False
                    btnSAVE.Show()
                    btnUpdate.Hide()
                    btnCHANGE.Enabled = False
                    User_Account_clear_function()
                    False_Enabled_User_Account_Function()
                    MsgBox("Kindly contact those Crew, and give their new username. Thank you.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESSFULLY UPDATED")
                ElseIf txtUName.Text = btnUser.Text And txtUpass.Text <> btnPass.Text Then
                    objconn.Open()
                    ModifyQuerys = "UPDATE user_table set user_table.Firstname = '" & btnFname.Text & "',Middlename='" & btnMname.Text & "',Lastname='" & btnLname.Text & "',Contact_Num=" & btnNum.Text & " where User_Company_ID = " & CInt(TextBox3.Text) & " ;" _
                                & " update user_account set user_account.Password = Sha1('" & btnPass.Text & "'),user_account.Account_Type='" & CStr(cmbAccType.Text) & "' where User_Company_ID = " & CInt(TextBox3.Text) & ";"
                    objcmd = New MySqlCommand(ModifyQuerys, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()
                    fillUser()
                    btnADD.Enabled = True
                    btnCANCEL.Hide()
                    btnCLEAR.Enabled = False
                    btnDELETE.Enabled = False
                    btnSAVE.Show()
                    btnUpdate.Hide()
                    btnCHANGE.Enabled = False
                    User_Account_clear_function()
                    False_Enabled_User_Account_Function()
                    MsgBox("Kindly contact those Crew, and give their new password. Thank you.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESSFULLY UPDATED")
                End If
            ElseIf question = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

    End Sub

    Private Sub btnNum_TextChanged(sender As Object, e As EventArgs) Handles btnNum.TextChanged
        If btnNum.Text < -1 Then
            MsgBox("Contact Number Must begin with (0).")
        End If
    End Sub

    Private Sub btnMname_TextChanged(sender As Object, e As EventArgs) Handles btnMname.TextChanged

    End Sub

    Private Sub btnUser_KeyDown(sender As Object, e As KeyEventArgs) Handles btnUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnPass.Focus()
        End If
    End Sub

    Private Sub btnUser_TextChanged(sender As Object, e As EventArgs) Handles btnUser.TextChanged

    End Sub

    Private Sub btnPass_KeyDown(sender As Object, e As KeyEventArgs) Handles btnPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbAccType.Focus()
            cmbAccType.DroppedDown = True
        End If
    End Sub

    Private Sub btnPass_TextChanged(sender As Object, e As EventArgs) Handles btnPass.TextChanged

    End Sub
End Class