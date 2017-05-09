Imports MySql.Data.MySqlClient
Public Class Add_Raw_Material
        Public Prok As String

    Private Sub cmdSubmitAdd_Click(sender As Object, e As EventArgs) Handles cmdSubmitAdd.Click
        If IsNothing(cmbUNIT.SelectedItem) Then
            MessageBox.Show("Select Unit of Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUNIT.BackColor = Color.PapayaWhip
            cmbUNIT.Focus()
        ElseIf txtCQ1.Text = "" Then
            MessageBox.Show("Enter Product Quantity", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCQ1.BackColor = Color.PapayaWhip
            txtCQ1.Focus()
        ElseIf txtRaw_Name.Text = "" Then
            MessageBox.Show("Enter Name of Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRaw_Name.BackColor = Color.PapayaWhip
            txtRaw_Name.Focus()
        ElseIf cmbUNIT.Text = "" Then
            MessageBox.Show("Select Unit of Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUNIT.BackColor = Color.PapayaWhip
            cmbUNIT.Focus()
        ElseIf DateTimePicker1.CustomFormat = " " Then
            MessageBox.Show("Select Expiration Date of a Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker1.BackColor = Color.PapayaWhip
            DateTimePicker1.Focus()
        ElseIf Format(DateTimePicker1.Value, "yyyy-MM-dd") < DateTime.Now Then
            MessageBox.Show("Expired Raw Material were Detected, Make sure that an expiration of our raw materials were greater than Todays Date.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker1.BackColor = Color.PapayaWhip
            DateTimePicker1.Focus()
            'DateTimePicker3.CustomFormat = " "  'An empty SPACE
            'DateTimePicker3.Format = DateTimePickerFormat.Custom
        Else
            two = CInt(txtCQ1.Text)
            ulit = CStr(two)
            hayop = CDec(txtCQ1.Text)
            ulitulit = CStr(hayop)
            Dim hehe As String = CStr(txtCQ1.Text).ToString()
            'Grms.
            If hayop > 999 Then '0.01
                MessageBox.Show("Sorry, you can input 1 up to 999 number/s or point only or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.9 And CStr(cmbUNIT.Text) = "mG/s" Then '0.01
                MessageBox.Show("Our system cannot accept below '1mG'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.99 And CStr(cmbUNIT.Text) = "mG/s" Then '0.01
                MessageBox.Show("Our system cannot accept below '1mG'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.999 And CStr(cmbUNIT.Text) = "mG/s" Then '0.001
                MessageBox.Show("Our system cannot accept below '1mG'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "0" & two Or hehe = "0.0" Or hehe = ".0" Or hehe = "0." Or hehe = "0" Or hehe = "0.00" Or hehe = "0.000" Or hehe = "000.0" Or hehe = "00.00" Or hehe = "00000" Or hehe = "0000" Or hehe = "000" Or hehe = "0.0000" Or hehe = "0000." Or hehe = "000." Or hehe = "00." And CStr(cmbUNIT.Text) = "gram/s" Then '0.01
                MessageBox.Show("Sorry, our system cannot accept thats kind of Quantity. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "." And CStr(cmbUNIT.Text) = "gram/s" Then '0.01
                MessageBox.Show("Sorry, Your input is not Valid. You can enter number/s or single dot(.) only. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "0" & two Or hehe = "0.0" Or hehe = ".0" Or hehe = "0." Or hehe = "0" Or hehe = "0.00" Or hehe = "0.000" Or hehe = "000.0" Or hehe = "00.00" Or hehe = "00000" Or hehe = "0000" Or hehe = "000" Or hehe = "0.0000" Or hehe = "0000." Or hehe = "000." Or hehe = "00." And CStr(cmbUNIT.Text) = "kG/s" Then '0.01
                MessageBox.Show("Sorry, our system cannot accept thats kind of Quantity. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "." And CStr(cmbUNIT.Text) = "kG/s" Then '0.01
                MessageBox.Show("Sorry, Your input is not Valid. You can enter number/s or single dot(.) only. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.9 And CStr(cmbUNIT.Text) = "mL/s" Then '0.01
                MessageBox.Show("Our system cannot accept below '1mL'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.99 And CStr(cmbUNIT.Text) = "mL/s" Then '0.01
                MessageBox.Show("Our system cannot accept below '1mL'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.999 And CStr(cmbUNIT.Text) = "mL/s" Then '0.001
                MessageBox.Show("Our system cannot accept below '1mL'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "0" & two Or hehe = "0.0" Or hehe = ".0" Or hehe = "0." Or hehe = "0" Or hehe = "0.00" Or hehe = "0.000" Or hehe = "000.0" Or hehe = "00.00" Or hehe = "00000" Or hehe = "0000" Or hehe = "000" Or hehe = "0.0000" Or hehe = "0000." Or hehe = "000." Or hehe = "00." And CStr(cmbUNIT.Text) = "liter/s" Then '0.01
                MessageBox.Show("Sorry, our system cannot accept thats kind of Quantity. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "." And CStr(cmbUNIT.Text) = "liter/s" Then '0.01
                MessageBox.Show("Sorry, Your input is not Valid. You can enter number/s or single dot(.) only. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If two <= 9 And CStr(cmbUNIT.Text) = "mG/s" Then
                    zerofirst = "0.00" & two
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "gram/s"
                ElseIf two <= 99 And CStr(cmbUNIT.Text) = "mG/s" Then
                    zerofirst = "0.0" & two
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "gram/s"
                ElseIf two <= 999 And CStr(cmbUNIT.Text) = "mG/s" Then
                    zerofirst = "0." & two
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "gram/s"
                    'kG/s
                ElseIf hayop <= 0.9 And CStr(cmbUNIT.Text) = "gram/s" Then '0.01
                    zerofirst = hayop & "00"
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "kG/s"
                ElseIf hayop <= 0.99 And CStr(cmbUNIT.Text) = "gram/s" Then '0.01
                    zerofirst = hayop & "0"
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "kG/s"
                ElseIf hayop <= 0.999 And CStr(cmbUNIT.Text) = "gram/s" Then '0.001
                    zerofirst = hayop & ""
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "kG/s"
                ElseIf two <= 9 And CStr(cmbUNIT.Text) = "gram/s" Then
                    zerofirst = "0.00" & two
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "kG/s"
                ElseIf two <= 99 And CStr(cmbUNIT.Text) = "gram/s" Then
                    zerofirst = "0.0" & two
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "kG/s"
                ElseIf two <= 999 And CStr(cmbUNIT.Text) = "gram/s" Then
                    zerofirst = "0." & two
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "kG/s"
                    'kG
                ElseIf hayop <= 0.9 And CStr(cmbUNIT.Text) = "kG/s" Then '0.01
                    zerofirst = hayop & "00"
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "gram/s"
                ElseIf hayop <= 0.99 And CStr(cmbUNIT.Text) = "kG/s" Then '0.01
                    zerofirst = hayop & "0"
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "gram/s"
                ElseIf hayop <= 0.999 And CStr(cmbUNIT.Text) = "kG/s" Then '0.001
                    zerofirst = hayop & ""
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "gram/s"
                ElseIf two <= 999 And CStr(cmbUNIT.Text) = "kG/s" Then
                    zerofirst = two & ".000"
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "kG/s"
                    'mL
                ElseIf two <= 9 And CStr(cmbUNIT.Text) = "mL/s" Then
                    zerofirst = "0.00" & two
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "liter/s"
                ElseIf two <= 99 And CStr(cmbUNIT.Text) = "mL/s" Then
                    zerofirst = "0.0" & two
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "liter/s"
                ElseIf two <= 999 And CStr(cmbUNIT.Text) = "mL/s" Then
                    zerofirst = "0." & two
                    TextBox2.Text = zerofirst
                    TextBox3.Text = "liter/s"
                    'gallon
                ElseIf hayop < 3.785 And CStr(cmbUNIT.Text) = "liter/s" Then
                    times = hayop
                    TextBox2.Text = times
                    TextBox3.Text = "liter/s"
                ElseIf hayop >= 3.785 And CStr(cmbUNIT.Text) = "liter/s" Then
                    times = hayop / 3.785
                    TextBox2.Text = times
                    TextBox3.Text = "gallon/s"
                ElseIf hayop < 12 And CStr(cmbUNIT.Text) = "piece/s" Then
                    times = hayop
                    TextBox2.Text = times
                    TextBox3.Text = "piece/s"
                ElseIf hayop >= 12 And CStr(cmbUNIT.Text) = "piece/s" Then
                    times = hayop / 12
                    TextBox2.Text = times
                    TextBox3.Text = "dozen/s"
                ElseIf CStr(cmbUNIT.Text) = "gallon/s" Then
                    times = hayop
                    TextBox2.Text = times
                    TextBox3.Text = "gallon/s"
                ElseIf CStr(cmbUNIT.Text) = "dozen/s" Then
                    times = hayop
                    TextBox2.Text = times
                    TextBox3.Text = "dozen/s"
                    'ElseIf hayop  <= 0.99 And CStr(cmbUNIT.Text) = "mG/s" Then
                    '    Dim modified As String = CStr(ulitulit.Insert(2, "0"))
                    '    TextBox2.Text = modified
                    '    TextBox3.Text = cmbUNIT.Text
                    '    
                End If
                one = txtRaw_Name.Text
                two = txtCQ1.Text
                three = cmbUNIT.Text
                four = Format(DateTimePicker1.Value, "yyyy-MM-dd")
                Try
                    objconn.Open()
                    objcmd.Connection = objconn
                    objcmd.CommandType = CommandType.Text
                    objcmd.CommandText = "select * from raw_material_table where raw_name ='" & txtRaw_Name.Text & "'"
                    objdr = objcmd.ExecuteReader
                    If objdr.HasRows Then
                        MessageBox.Show("Raw Material Already Exists ")
                    Else
                        question = MsgBox("Do You Want To Add '" & one & "' to our System?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If question = MsgBoxResult.Yes Then
                            objconn = New MySqlConnection
                            objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                            objconn.Open()
                            With objcmd
                                .Connection = objconn
                                .CommandText = "Insert Into raw_material_table(RAW_ID,RAW_NAME)  values (NULL,'" & one & _
                                                                                 "') ; INSERT INTO raw_expiration_date(Exp_Date_ID,RAW_QUANTITY,Unit_ID,RAW_EXPIRATION_DATE,Raw_ID) values " _
                                                                                 & "(NULL, '" & CStr(TextBox2.Text) & "', (select Unit_ID from unit_table where Unit_Name = '" & CStr(TextBox3.Text) & _
                                                                                "'),'" & four & "', LAST_INSERT_ID())"
                                .ExecuteNonQuery()
                            End With

                            With objcmd
                                .Connection = objconn
                                .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " add raw materials which is  " & one & ", Quantity = " & two & " " & three & ", Expiration Date = " & four & " at ',CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "')) "
                                .ExecuteNonQuery()
                            End With
                            objconn.Close()
                            FillRawMats()
                            txtRaw_Name.Text = ""
                            txtCQ1.Text = ""
                            cmbUNIT.Text = ""
                            TextBox2.Text = ""
                            TextBox3.Text = ""
                            DateTimePicker1.CustomFormat = " "  'An empty SPACE
                            DateTimePicker1.Format = DateTimePickerFormat.Custom
                            txtRaw_Name.Focus()
                            MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                        ElseIf question = MsgBoxResult.No Then
                            objconn.Close()
                            If objconn.State = ConnectionState.Open Then
                                objconn.Close()
                            End If
                        End If
                    End If
                    objconn.Close()
                Catch ex As Exception
                    MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
                End Try
            End If
        End If
    End Sub

    Private Sub txtCQ1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCQ1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbUNIT.Focus()
            cmbUNIT.DroppedDown = True
        End If
    End Sub
    Private Sub txtCQ1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCQ1.KeyPress
        Dim allowedChars As String = "0987654321."
        If (txtCQ1.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedChars.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub
  
    Private Sub txtCQ1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCQ1.TextChanged
        txtCQ1.BackColor = Color.White
        If Val(txtCQ1.Text) > 999 Then
            Label1.Text = "Input 1-999 numbers only"
        ElseIf Val(txtCQ1.Text) < 999 Then
            Label1.Text = ""
        End If
    End Sub

    Private Sub cmbUNIT_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbUNIT.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePicker1.Focus()
        End If
    End Sub
    Private Sub cmbUNIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUNIT.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub cmbUNIT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUNIT.SelectedIndexChanged
        cmbUNIT.BackColor = Color.White
        If cmbUNIT.Text = "mG/s" Then
            Label2.Text = "1000 mG/s = 1 gram"
        ElseIf cmbUNIT.Text = "gram/s" Then
            Label2.Text = "1000 grams = 1 kG"
        ElseIf cmbUNIT.Text = "kG/s" Then
            Label2.Text = "1000 grams = 1 kG"
        ElseIf cmbUNIT.Text = "mL/s" Then
            Label2.Text = "1000 mL/s = 1 Liter"
        ElseIf cmbUNIT.Text = "liter/s" Then
            Label2.Text = "3.785 liters = 1 gallon"
        ElseIf cmbUNIT.Text = "gallon/s" Then
            Label2.Text = "3.785 liters = 1 gallon"
        ElseIf cmbUNIT.Text = "piece/s" Then
            Label2.Text = "12 piece/s = 1 dozen"
        ElseIf cmbUNIT.Text = "dozen/s" Then
            Label2.Text = "12 piece/s = 1 dozen"
        Else
            Label2.Text = ""
        End If
    End Sub

    Private Sub txtRaw_Name_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRaw_Name.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCQ1.Focus()
        End If
    End Sub
    Private Sub txtRaw_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRaw_Name.TextChanged
        txtRaw_Name.BackColor = Color.White
    End Sub
    Private Sub Add_Raw_Material_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        cleartxtfield()
        Me.Hide()
    End Sub
    Public Sub filtercb()
        cmbUNIT.Items.Clear()
        Try
            objconn.Open()
            cmbQuery = "select * from unit_table ASC"
            objcmd = New MySqlCommand(cmbQuery, objconn)
            objdr = objcmd.ExecuteReader
            While objdr.Read
                Dim pNam = objdr.GetString("Unit_Name")
                cmbUNIT.Items.Add(pNam)
            End While
            objconn.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Add_Raw_Material_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cvert As String = DateTimePicker1.Value.ToString()
        cvert = ""
        DateTimePicker1.CustomFormat = " "  'An empty SPACE
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        Me.TopMost = True
    End Sub
    Public Sub cleartxtfield()
        txtRaw_Name.Text = ""
        txtCQ1.Text = ""
        DateTimePicker1.CustomFormat = " "
        cmbUNIT.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub cmdCancelMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelMaintenance.Click
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        cleartxtfield()
        Me.Hide()

        Modall.Enabled = True
        ' Modall.Show()
    End Sub
    Private Sub cmbUNIT_TextChanged(sender As Object, e As EventArgs) Handles cmbUNIT.TextChanged
        If cmbUNIT.Text = "" Then
            Label2.Text = ""
        End If
    End Sub
    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSubmitAdd.PerformClick()
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        DateTimePicker1.BackColor = Color.White
        DateTimePicker1.MinDate = DateTime.Now 
    End Sub
End Class