Imports MySql.Data.MySqlClient

Module User
 
    Dim tries As Integer = 0
    Public Sub LOGIN(ByVal username As Object, ByVal password As Object)

        Try
            Login_query("SELECT * from user_table inner join user_account on user_table.User_Company_ID = user_account.User_Company_ID WHERE username = sha1('" & username & "') and password = sha1('" & password & "') ")
            If objdt.Rows.Count = 0 Then
                tries += 1
                Loginfrm.Label1.Show()
                Loginfrm.lblcountAttempt.Show()
                Loginfrm.lblcountAttempt.Text = "" & tries & " of 5"
                Loginfrm.lblPrompt.Text = "          Account does'nt exist ..."
                Loginfrm.UsernameTextBox.Focus()
                If tries = 4 Then
                    MessageBox.Show("Wrong combination, 1 chance left to make it right. Make sure you have an access in our system, If not then the program will close automatically.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    If tries = 5 Then
                        Loginfrm.Dispose()
                    End If
                End If
                objconn.Close()
            ElseIf objdt.Rows.Count > 0 Then
                If objdt.Rows(0).Item("Account_Type") = "ADMIN" Then
                    'MessageBox.Show("Welcome " & objdt.Rows(0).Item("Account_Type") & ": " & objdt.Rows(0).Item("Username"), prog_message_caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Loginfrm.MyPlayer.SoundLocation = Loginfrm.path & Loginfrm.LogOnsound
                    'Loginfrm.MyPlayer.Play()
                    tries = 0
                    User_Account.user_act = Loginfrm.UsernameTextBox.Text
                    Add_Prod.Produv = Loginfrm.UsernameTextBox.Text
                    'Add_Raw.Produva = Loginfrm.UsernameTextBox.Text
                    ' Remove_Prod.Produve = Loginfrm.UsernameTextBox.Text
                    '  Remove_Raw.Produvd = Loginfrm.UsernameTextBox.Text
                    Add_Raw_Material.Prok = Loginfrm.UsernameTextBox.Text
                    'Modify_Raw_Quantity.UserLog = Loginfrm.UsernameTextBox.Text
                    About_Us.About = Loginfrm.UsernameTextBox.Text
                    Help.Help = Loginfrm.UsernameTextBox.Text
                    ' Expired_Raw_Material.Critical = Loginfrm.UsernameTextBox.Text
                    Import_and_Export.Import = Loginfrm.UsernameTextBox.Text
                    Modall.Named = objdt.Rows(0).Item("Firstname")
                    'objconn.Open()
                    'objdt = New DataTable
                    'With objcmd
                    '    .Connection = objconn
                    '    .CommandText = "SELECT * from user_table inner join user_account on user_table.User_Company_ID = user_account.User_Company_ID WHERE username = sha1('" & username & "') and password = sha1('" & password & "') "
                    'End With
                    'objda.SelectCommand = objcmd
                    'objda.Fill(objdt)
                    'objdr = objcmd.ExecuteReader
                    'If objdr.HasRows Then
                    '    While objdr.Read
                    '        Modall.Named = objdr.GetString("Firstname")
                    '    End While
                    'End If
                    'objconn.Close()
                    Modall.UserNamed = "ADMIN"

                    'Modall.Label24.Text = Date.Now.ToString("MM/dd/yyyy")
                    'Modall.Hidelabel()
                    'Modall.grpOrderProd.Hide()
                    'Modall.TabControl1.Hide()
                    'Modall.grpCritical.Hide()
                    'Modall.grpExpired.Hide()
                    'Modall.grpBgRawProducts.Hide()
                    'Modall.grpBgRawMats.Hide()
                    'Modall.grpBgProducts.Hide()
                    'Modall.Expired_Raw_Mats()
                    'Modall.Critical_Raw_Mats()
                    'Modall.txtOrderName.Text = ""
                    'Modall.lblUser.Text = Modall.Named
                    Modall.Show()
                    Modall.grpNav.Show()
                    Modall.grpNav_0.Hide()
                    Show_Manager_Function()


                    objconn.Open()
                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " trying to log in at ' ,CURRENT_TIMESTAMP, (select " _
                                         & " user_company_id from user_account where Username = Sha1('" & Loginfrm.UsernameTextBox.Text & "') And Account_Type = 'ADMIN'))"
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()
                    Loginfrm.Hide()
                ElseIf objdt.Rows(0).Item("Account_Type") = "CREW" Then
                    tries = 0
                    'MessageBox.Show("Welcome " & objdt.Rows(0).Item("Account_Type") & ": " & objdt.Rows(0).Item("Username"), prog_message_caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Loginfrm.MyPlayer.SoundLocation = Loginfrm.path & Loginfrm.LogOnsound
                    'Loginfrm.MyPlayer.Play()
                    User_Account.user_act = Loginfrm.UsernameTextBox.Text
                    Add_Prod.Produv = Loginfrm.UsernameTextBox.Text
                    'Add_Raw.Produva = Loginfrm.UsernameTextBox.Text
                    'Remove_Prod.Produve = Loginfrm.UsernameTextBox.Text
                    'Remove_Raw.Produvd = Loginfrm.UsernameTextBox.Text
                    Add_Raw_Material.Prok = Loginfrm.UsernameTextBox.Text
                    About_Us.About = Loginfrm.UsernameTextBox.Text
                    Help.Help = Loginfrm.UsernameTextBox.Text
                    ' Expired_Raw_Material.Critical = Loginfrm.UsernameTextBox.Text

                    Import_and_Export.Import = Loginfrm.UsernameTextBox.Text
                    ' Modall.Named = Loginfrm.UsernameTextBox.Text.ToString.ToLower
                    Modall.Named = objdt.Rows(0).Item("Firstname")
                    Modall.UserNamed = "CREW"
                    'Modall.Label24.Text = Date.Now.ToString("MM/dd/yyyy")
                    'Modall.Hidelabel()
                    'Modall.grpOrderProd.Hide()
                    'Modall.TabControl1.Hide()
                    'Modall.grpCritical.Hide()
                    'Modall.grpExpired.Hide()
                    'Modall.grpBgRawProducts.Hide()
                    'Modall.grpBgRawMats.Hide()
                    'Modall.grpBgProducts.Hide()
                    'Modall.Expired_Raw_Mats()
                    'Modall.Critical_Raw_Mats()
                    'Modall.txtOrderName.Text = ""
                    'Modall.lblUser.Text = Modall.Named
                    Modall.Show()
                    Modall.grpNav.Hide()
                    Modall.grpNav_0.Show()


                    objconn.Open()
                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " trying to log in at ',CURRENT_TIMESTAMP, (select " _
                                         & "user_company_id from user_account where Username = Sha1('" & Loginfrm.UsernameTextBox.Text & "') And Account_Type = 'CREW'))"
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()
                    Loginfrm.Hide()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        objconn.Close()
        objda.Dispose()
        objconn.Dispose()
    End Sub
End Module


