Imports MySql.Data.MySqlClient
Public Class AddProduct
    Public Prok As String
    Public txtNameprod As String
    Private Sub cmdSubmitAdd_Click(sender As Object, e As EventArgs) Handles cmdSubmitAdd.Click
        If txtProdukto.Text = "" Then
            MessageBox.Show("Please Enter Name of Product ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProdukto.BackColor = Color.PapayaWhip
            txtProdukto.Focus()
        Else
            txtNameprod = CStr(txtProdukto.Text)
            Try
                objconn.Open()
                objcmd.Connection = objconn
                objcmd.CommandType = CommandType.Text
                objcmd.CommandText = "select * from product_table where product_name ='" & CStr(txtProdukto.Text) & "'"
                objdr = objcmd.ExecuteReader
                If objdr.HasRows Then
                    MessageBox.Show("Product Already Exists", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    question = MsgBox("Do You Want To Add ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                    If question = MsgBoxResult.Yes Then
                        Try
                            objconn = New MySqlConnection
                            objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                            objconn.Open()
                            With objcmd
                                .Connection = objconn
                                .CommandText = "Insert Into product_table (product_name,Cat_ID) values ('" & txtNameprod & "',(Select Cat_ID from category where Cat_Name = '" & CStr(cmbfillCat.Text) & "'))"
                                .ExecuteNonQuery()
                            End With
                            With objcmd
                                .Connection = objconn
                                .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " were adding a new product which is " & txtNameprod & " on ' ,CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "')) "
                                .ExecuteNonQuery()
                            End With
                            objconn.Close()
                            fillProductQuantity()
                            txtProdukto.Text = ""
                            MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                        Catch ex As Exception
                            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                        End Try
                    ElseIf question = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
                objconn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
            End Try
        End If
    End Sub

    Private Sub txtProdukto_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProdukto.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSubmitAdd.PerformClick()
        End If
    End Sub
  
    Private Sub txtRaw_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdukto.TextChanged
        txtProdukto.BackColor = Color.White
    End Sub

    Private Sub Add_Raw_Material_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub
    Private Sub Add_Raw_Material_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        Me.Hide()
    End Sub
    Public Sub fillcombobox()
    
        Try
            objconn.Open()
            cmbQuery = "select Cat_Name from category order by Cat_Name ASC"
            objcmd = New MySqlCommand(cmbQuery, objconn)
            objdr = objcmd.ExecuteReader
            While objdr.Read
                Dim pNam = objdr.GetString("Cat_Name")
                cmbfillCat.Items.Add(pNam)
            End While
            objconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
        End Try
    End Sub
    Public Sub disabletxt()
        txtProdukto.Enabled = False
        '  txtpresyo.Enabled = False
        cmdSubmitAdd.Enabled = False
        ' txtPira.Enabled = False
        ' cmbunitcat.Enabled = False
    End Sub
    Public Sub enabletxt()
        txtProdukto.Enabled = True
        '   txtpresyo.Enabled = True
        cmdSubmitAdd.Enabled = True
        '  txtPira.Enabled = True
        'cmbunitcat.Enabled = True
    End Sub
    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Easy code to make a form shake
        'Dim a As Integer 'Declaring integer "a"
        'While a < 10 'Starting a "while loop"
        '    'Setting our form's X position to 20 'pixels to right from it's current position.            
        '    Me.Location = New Point(Me.Location.X + 20, Me.Location.Y)
        '    'Telling a program to sleep for 50 miliseconds before 'continuing
        '    System.Threading.Thread.Sleep(50)
        '    'Setting our form's X position to 20 'pixels to left from it's current position.
        '    Me.Location = New Point(Me.Location.X - 20, Me.Location.Y)
        '    'Telling a program to sleep for 50 miliseconds before continuing            
        '    System.Threading.Thread.Sleep(50)
        '    a += 1 'Increasing integer "a" by 1 after each loop
        'End While
        Me.TopMost = True
        fillcombobox()
        disabletxt()
    End Sub
    Private Sub cmdCancelMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelMaintenance.Click
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        Me.Hide()
        'Modall.Show()
        Modall.Enabled = True
    End Sub

    Private Sub cmbfillCat_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbfillCat.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtProdukto.Focus()
        End If
    End Sub

    Private Sub cmbfillCat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbfillCat.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub cmbfillCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbfillCat.SelectedIndexChanged
        If cmbfillCat.Text <> "" Then
            enabletxt()
        End If
        'If cmbfillCat.SelectedIndex = 0 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("1.5 Liters")
        '    cmbunitcat.Items.Add("8 oz.")
        '    cmbunitcat.Items.Add("12 oz.")
        '    cmbunitcat.Items.Add("Can")
        '    cmbunitcat.Items.Add("Cup")
        '    cmbunitcat.Items.Add("Glass")
        '    cmbunitcat.Items.Add("Pitcher")
        '    cmbunitcat.Items.Add("Small")
        '    cmbunitcat.Items.Add("Medium")
        '    cmbunitcat.Items.Add("Large")
        'ElseIf cmbfillCat.SelectedIndex = 1 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("piece/s")
        'ElseIf cmbfillCat.SelectedIndex = 2 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("piece/s")
        'ElseIf cmbfillCat.SelectedIndex = 3 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("piece/s")
        'ElseIf cmbfillCat.SelectedIndex = 4 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("piece/s")
        'ElseIf cmbfillCat.SelectedIndex = 5 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("Solo")
        '    cmbunitcat.Items.Add("Superthin")
        '    cmbunitcat.Items.Add("Regular")
        '    cmbunitcat.Items.Add("Family")
        '    cmbunitcat.Items.Add("Chicago Deep Dish")
        'ElseIf cmbfillCat.SelectedIndex = 6 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("piece/s")
        'ElseIf cmbfillCat.SelectedIndex = 7 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("Solo")
        'ElseIf cmbfillCat.SelectedIndex = 8 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("Solo")
        '    cmbunitcat.Items.Add("Superthin")
        '    cmbunitcat.Items.Add("Regular")
        '    cmbunitcat.Items.Add("Family")
        '    cmbunitcat.Items.Add("Chicago Deep Dish")
        'ElseIf cmbfillCat.SelectedIndex = 9 Then

        'ElseIf cmbfillCat.SelectedIndex = 10 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("Glass/es")
        'ElseIf cmbfillCat.SelectedIndex = 11 Then
        '    cmbunitcat.Items.Clear()
        '    cmbunitcat.Text = ""
        '    cmbunitcat.Items.Add("piece/s")
        'End If

    End Sub
End Class