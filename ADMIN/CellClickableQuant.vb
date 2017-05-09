Imports MySql.Data.MySqlClient
Public Class CellClickableQuant
    Public putqueryhere As String
    Public Valid As Boolean

    Public Sub Conditiontxt()
        If Val(TextBox1.Text) > 0 Then
            cmbSized.Enabled = True
            txQuantd.Enabled = True
            btnUpdateProd.Enabled = True
            btnDeleteProd.Enabled = True
            cmbSized.Text = ""
            txQuantd.Text = ""
        ElseIf Val(TextBox1.Text) = 0 Then
            cmbSized.Enabled = False
            txQuantd.Enabled = False
            btnUpdateProd.Enabled = False
            btnDeleteProd.Enabled = False
            txQuantd.Text = "Not Available"
            cmbSized.Text = ""
        End If
    End Sub
    Public Sub conditioncattxtfill()
        If txtCatID.Text = "1" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("piece/s")
            cmbselectSizes.SelectedIndex = 0
        ElseIf txtCatID.Text = "2" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("Platter")
            cmbselectSizes.SelectedIndex = 0
        ElseIf txtCatID.Text = "3" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("piece/s")
            cmbselectSizes.SelectedIndex = 0
        ElseIf txtCatID.Text = "4" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("Solo")
            cmbselectSizes.Items.Add("Superthin")
            cmbselectSizes.Items.Add("Regular")
            cmbselectSizes.Items.Add("Family")
            cmbselectSizes.Items.Add("Chicago Deep Dish")
        ElseIf txtCatID.Text = "5" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("piece/s")
            cmbselectSizes.SelectedIndex = 0
        ElseIf txtCatID.Text = "6" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("Solo")
            cmbselectSizes.SelectedIndex = 0
        ElseIf txtCatID.Text = "7" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("Solo")
            cmbselectSizes.Items.Add("Superthin")
            cmbselectSizes.Items.Add("Regular")
            cmbselectSizes.Items.Add("Family")
            cmbselectSizes.Items.Add("Chicago Deep Dish")
        ElseIf txtCatID.Text = "8" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("per serving")
            cmbselectSizes.SelectedIndex = 0
        ElseIf txtCatID.Text = "9" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("per serving")
            cmbselectSizes.SelectedIndex = 0
        ElseIf txtCatID.Text = "10" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("piece/s")
            cmbselectSizes.SelectedIndex = 0
        ElseIf txtCatID.Text = "11" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("Glass/es")
            cmbselectSizes.SelectedIndex = 0
        ElseIf txtCatID.Text = "12" Then
            cmbselectSizes.Items.Clear()
            cmbselectSizes.Text = ""
            cmbselectSizes.Items.Add("1.5 Liters")
            cmbselectSizes.Items.Add("8 oz.")
            cmbselectSizes.Items.Add("12 oz.")
            cmbselectSizes.Items.Add("Can")
            cmbselectSizes.Items.Add("Cup")
            cmbselectSizes.Items.Add("Glass")
            cmbselectSizes.Items.Add("Pitcher")
            cmbselectSizes.Items.Add("Small")
            cmbselectSizes.Items.Add("Medium")
            cmbselectSizes.Items.Add("Large")
        End If
    End Sub

    Private Sub CellClickableQuant_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        clearfilled()
    End Sub

    Private Sub CellClickableQuant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        If Modall.lblAccountType.Text = "CREW" Then
            btnDeleteProd.Hide()
        ElseIf Modall.lblAccountType.Text = "ADMIN" Then
            btnDeleteProd.Show()
        End If
        conditioncattxtfill()
        Conditiontxt()
    End Sub
    Public Sub clearfilled()
        txtfillProd.Text = ""
        txtProd.Text = ""
        cmbselectSizes.Text = ""
        txtAddPrice.Text = ""
        txtID.Text = ""
        TextBox1.Text = ""
        txtUpdateput.Text = ""
        txtP.Text = ""
        txtQuants.Text = ""
        txtCatID.Text = ""
        txtS.Text = ""
        txtQ.Text = ""
        cmbSized.Text = ""
        txQuantd.Text = ""
        txtUpdatePrice.Text = ""
    End Sub
    Private Sub cmdCancelMaintenance_Click(sender As Object, e As EventArgs) Handles cmdCancelMaintenance.Click
        clearfilled()
        Me.Close()
        Modall.Show()
    End Sub
    Public Sub pieceorserving()
        objconn.Open()
        objdt = New DataTable
        With objcmd
            .Connection = objconn
            .CommandText = "Select  Quantity,Trim(Price) + 0 from product_quantity inner join product_table  on product_quantity.Product_ID = product_table.Product_ID " _
                & "inner join product_size on product_quantity.Size_ID = product_size.Size_ID where product_Name = '" & CStr(txtfillProd.Text) & "' And product_size.Size_Name ='None' "
        End With
        objda.SelectCommand = objcmd
        objda.Fill(objdt)
        objdr = objcmd.ExecuteReader
        If objdr.HasRows Then
            While objdr.Read
                txtQuants.Text = objdr.GetInt32("Quantity")
                txtAddPrice.Text = objdr.GetDouble("Trim(Price) + 0")
            End While
        End If
        If txtQuants.Text <> "" Then
            txtAddPrice.Enabled = False
        ElseIf txtQuants.Text = "" Then
            txtAddPrice.Enabled = True
            txtAddPrice.Text = ""
        End If

        objconn.Close()
    End Sub

    Public Sub allsizes()
        objconn.Open()
        objdt = New DataTable
        With objcmd
            .Connection = objconn
            .CommandText = "Select  Quantity,Trim(Price) + 0 from product_quantity inner join product_table  on product_quantity.Product_ID = product_table.Product_ID " _
                & "inner join product_size on product_quantity.Size_ID = product_size.Size_ID where product_Name = '" & CStr(txtfillProd.Text) & "' And product_size.Size_Name ='" & CStr(cmbselectSizes.Text) & "' "
        End With
        objda.SelectCommand = objcmd
        objda.Fill(objdt)
        objdr = objcmd.ExecuteReader
        If objdr.HasRows Then
            While objdr.Read
                txtQuants.Text = objdr.GetInt32("Quantity")
                txtAddPrice.Text = objdr.GetDouble("Trim(Price) + 0")
            End While
        End If
        If txtQuants.Text <> "" Then
            txtAddPrice.Enabled = False
        ElseIf txtQuants.Text = "" Then
            txtAddPrice.Enabled = True
            txtAddPrice.Text = ""
        End If

        objconn.Close()
    End Sub

    Private Sub cmbselectSizes_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbselectSizes.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAddPrice.Focus()
        End If
    End Sub
    Private Sub cmbselectSizes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbselectSizes.SelectedIndexChanged
        cmbselectSizes.BackColor = Color.White
        txtQuants.Text = ""
        If cmbselectSizes.Text = "piece/s" Or cmbselectSizes.Text = "per serving" Then
            pieceorserving()
        Else
            allsizes()
        End If
    End Sub
    Public Sub loadcmbSize()
        cmbSized.Items.Clear()
        Try
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "SELECT product_table.Product_ID,product_table.Cat_ID,product_table.Product_Name,product_size.Size_Name As 'true_sizes',(Case when product_size.Size_Name " _
                                 & " = 'None' Then 'pieces' when product_size.Size_Name IS NULL Then '' Else product_size.Size_Name  End) As 'Sized' from product_quantity RIGHT join product_table on product_quantity.Product_ID = product_table.Product_ID LEFT join product_size on product_quantity.Size_ID = product_size.size_ID INNER join category  on product_table.CAT_ID = category.Cat_ID WHERE product_table.Product_Name= '" & txtfillProd.Text & "'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    Dim fillsizeprods As String = objdr.GetString("Sized")
                    cmbSized.Items.Add(fillsizeprods)
                End While
            End If
            objconn.Close()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub abc()

        Dim prog As String = txtfillProd.Text
        Dim nameprod As String = txtProd.Text
        Dim txtAddPricing As String = txtAddPrice.Text
        Try
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = "Insert into product_quantity(Quantity_ID,Quantity,Price,Product_ID,Size_ID) values(NULL," & nameprod & ", " & CDbl(txtAddPricing) & ", " _
                                & "(SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(prog) & "'),(Select Size_ID from " _
                                & "product_size where Size_Name ='None'));"
                .ExecuteNonQuery()
            End With
            objconn.Close()

            objconn = New MySqlConnection
            objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " were add " & nameprod & " " & CStr(cmbselectSizes.Text) & " of " & CStr(prog) & " on ', " _
                            & "CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "'))"
                .ExecuteNonQuery()
            End With
            objconn.Close()
            fillProductQuantity()
            txtProd.Text = ""
            cmbselectSizes.Text = ""
            txtAddPrice.Text = ""
            loadcmbSize()
            MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
            'Finally
            '    objconn.Close()
        End Try
    End Sub
    Public Sub def()
        Dim prog As String = txtfillProd.Text
        Dim nameprod As String = txtProd.Text
        Dim cmbSize As String = cmbselectSizes.Text
        Dim txtAddPricing As String = txtAddPrice.Text
        Try
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = "Insert into product_quantity(Quantity_ID,Quantity,Price,Product_ID,Size_ID) values(NULL," & nameprod & ", " & CDbl(txtAddPricing) & ", " _
                                & "(SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(prog) & "'),(Select Size_ID from " _
                                & "product_size where Size_Name ='" & CStr(cmbSize) & "'));"
                .ExecuteNonQuery()
            End With
            objconn.Close()

            objconn = New MySqlConnection
            objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " were add " & nameprod & " " & CStr(cmbselectSizes.Text) & " of " & CStr(prog) & " on ',CURRENT_TIMESTAMP, " _
                            & " (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "'))"
                .ExecuteNonQuery()
            End With
            objconn.Close()

            fillProductQuantity()
            txtProd.Text = ""
            cmbselectSizes.Text = ""
            txtAddPrice.Text = ""
            loadcmbSize()
            'objconn = New MySqlConnection
            'objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
            'objconn.Open()
            'With objcmd
            '    .Connection = objconn
            '    .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " add " & nameprod & " box/es of " & prog & " size: " & cmbSize & " at ',CURRENT_TIMESTAMP, " _
            '                & "(select user_company_id from user_account where Username = Sha1('" & Loginfrm.UsernameTextBox.Text & "') And Account_Type = (SELECT Account_Type from user_account where Username = Sha1('" & Loginfrm.UsernameTextBox.Text & "'))))"
            '    .ExecuteNonQuery()
            'End With
            'objconn.Close()
            MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
            'Finally
            '    objconn.Close()
        End Try
    End Sub
    Public Sub ghi()
        Dim prog As String = txtfillProd.Text
        Dim nameprod As String = txtProd.Text
        Dim txtAddPricing As String = txtAddPrice.Text
        Try
            objconn.Open()
            ModifyQuerys = "UPDATE product_quantity set product_quantity.Quantity = product_quantity.Quantity + " & nameprod & " , product_quantity.Price = " & CDbl(txtAddPricing) & " where Product_ID IN (Select Product_ID from product_table where product_table.Product_Name = '" & prog & "') " _
                & "And Size_ID IN (select Size_ID from product_size where product_size.Size_Name= 'None')"
            objcmd = New MySqlCommand(ModifyQuerys, objconn)
            objdr = objcmd.ExecuteReader
            objconn.Close()

            objconn = New MySqlConnection
            objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " were add " & nameprod & " " & CStr(cmbselectSizes.Text) & " of " & CStr(prog) & " on ',CURRENT_TIMESTAMP, " _
                            & " (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "'))"
                .ExecuteNonQuery()
            End With
            objconn.Close()

            fillProductQuantity()
            txtProd.Text = ""
            cmbselectSizes.Text = ""
            txtAddPrice.Text = ""
            loadcmbSize()
            'objconn = New MySqlConnection
            'objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
            'objconn.Open()
            'With objcmd
            '    .Connection = objconn
            '    .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " modify " & nameprod & " box/es of " & prog & " size: " & cmbSize & " at ',CURRENT_TIMESTAMP, " _
            '                & "(select user_company_id from user_account where Username = Sha1('" & Loginfrm.UsernameTextBox.Text & "') And Account_Type = (SELECT Account_Type from user_account where Username = Sha1('" & Loginfrm.UsernameTextBox.Text & "'))))"
            '    .ExecuteNonQuery()
            'End With
            'objconn.Close()
            MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
            'Finally
            '    objconn.Close()
        End Try
    End Sub

    Public Sub jkl()
        Dim prog As String = txtfillProd.Text
        Dim nameprod As String = txtProd.Text
        Dim cmbSize As String = cmbselectSizes.Text
        Dim txtAddPricing As String = txtAddPrice.Text
        Try
            objconn.Open()
            ModifyQuerys = "UPDATE product_quantity set product_quantity.Quantity = product_quantity.Quantity + " & nameprod & " , product_quantity.Price = " & CDbl(txtAddPricing) & " where Product_ID IN (Select Product_ID from product_table where product_table.Product_Name = '" & prog & "') " _
                & "And Size_ID IN (select Size_ID from product_size where product_size.Size_Name= '" & CStr(cmbSize) & "')"
            objcmd = New MySqlCommand(ModifyQuerys, objconn)
            objdr = objcmd.ExecuteReader
            objconn.Close()

            objconn = New MySqlConnection
            objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " were add " & nameprod & " " & CStr(cmbselectSizes.Text) & " of " & CStr(prog) & " on ',CURRENT_TIMESTAMP, " _
                            & " (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "'))"
                .ExecuteNonQuery()
            End With
            objconn.Close()
            fillProductQuantity()
            txtProd.Text = ""
            cmbselectSizes.Text = ""
            txtAddPrice.Text = ""
            loadcmbSize()

            MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
            'Finally
            '    objconn.Close()
        End Try
    End Sub
    Private Sub cmdSubmitAdd_Click(sender As Object, e As EventArgs) Handles cmdSubmitAdd.Click
        If txtProd.Text = "" Then
            MessageBox.Show("Enter Quantity of a Product", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtProd.BackColor = Color.PapayaWhip
            txtProd.Focus()
        ElseIf IsNothing(cmbselectSizes.SelectedItem) Then
            MessageBox.Show("Select Sizes of a Product you want to add.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbselectSizes.BackColor = Color.PapayaWhip
            cmbselectSizes.Focus()
        ElseIf txtQuants.Text = "" And txtAddPrice.Text = "" Then
            MessageBox.Show("Price is required", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddPrice.BackColor = Color.PapayaWhip
            txtAddPrice.Focus()
        ElseIf txtQuants.Text = "" Then
            question = MsgBox("Do You Want To Add ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If question = MsgBoxResult.Yes Then
                If cmbselectSizes.Text = "piece/s" Or cmbselectSizes.Text = "per serving" Then
                    abc()
                Else
                    def()
                End If
            ElseIf question = MsgBoxResult.No Then
                Exit Sub
            End If
        Else
            Dim prog As String = txtfillProd.Text
            Dim nameprod As String = txtProd.Text
            Dim cmbSize As String = cmbselectSizes.Text
            Dim txtAddPricing As String = txtAddPrice.Text

            question = MsgBox("Do You Want To Add to an Existing Product ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If question = MsgBoxResult.Yes Then
                If cmbselectSizes.Text = "piece/s" Or cmbselectSizes.Text = "per serving" Then
                    ghi()
                Else
                    jkl()
                End If
            ElseIf question = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmbselectSizes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbselectSizes.KeyPress
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

    Private Sub txtProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbselectSizes.Focus()
            cmbselectSizes.DroppedDown = True
        End If
    End Sub
    Private Sub txtProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProd.KeyPress
        Dim allowedChars As String = "0987654321."
        If (txtProd.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedChars.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub

    Private Sub cmbSized_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbSized.KeyDown
        If e.KeyCode = Keys.Enter Then
            txQuantd.Focus()
        End If
    End Sub

    Private Sub cmbSized_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbSized.KeyPress
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

    Private Sub cmbSized_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSized.SelectedIndexChanged
        txtS.Text = ""
        If cmbSized.SelectedItem = "pieces" Then
            txtS.Text = "None"
        ElseIf cmbSized.SelectedItem = "Solo" Then
            txtS.Text = "Solo"
        ElseIf cmbSized.SelectedItem = "Regular" Then
            txtS.Text = "Regular"
        ElseIf cmbSized.SelectedItem = "Family" Then
            txtS.Text = "Family"
        ElseIf cmbSized.SelectedItem = "Superthin" Then
            txtS.Text = "Superthin"
        ElseIf cmbSized.SelectedItem = "Chicago Deep Dish" Then
            txtS.Text = "Chicago Deep Dish"
        ElseIf cmbSized.SelectedItem = "Small" Then
            txtS.Text = "Small"
        ElseIf cmbSized.SelectedItem = "Medium" Then
            txtS.Text = "Medium"
        ElseIf cmbSized.SelectedItem = "Large" Then
            txtS.Text = "Large"
        ElseIf cmbSized.SelectedItem = "Glass" Then
            txtS.Text = "Glass"
        ElseIf cmbSized.SelectedItem = "Platter" Then
            txtS.Text = "Platter"
        ElseIf cmbSized.SelectedItem = "Pitcher" Then
            txtS.Text = "Pitcher"
        ElseIf cmbSized.SelectedItem = "Cup" Then
            txtS.Text = "Cup"
        ElseIf cmbSized.SelectedItem = "8 oz." Then
            txtS.Text = "8 oz."
        ElseIf cmbSized.SelectedItem = "12 oz." Then
            txtS.Text = "12 oz."
        ElseIf cmbSized.SelectedItem = "1.5 Liters" Then
            txtS.Text = "1.5 Liters"
        End If
        cmbSized.BackColor = Color.White
        txQuantd.Text = ""
        txtUpdatePrice.Text = ""
        txtUpdateput.Text = ""
        txtQ.Text = ""

        If cmbSized.SelectedItem = "pieces" Then
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "Select  Quantity,Trim(Price) + 0 from product_quantity inner join product_table  on product_quantity.Product_ID = product_table.Product_ID " _
                    & "inner join product_size on product_quantity.Size_ID = product_size.Size_ID where product_Name = '" & CStr(txtP.Text) & "' And product_size.Size_Name='None'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    txQuantd.Text = objdr.GetInt32("Quantity")
                    txtQ.Text = objdr.GetInt32("Quantity")
                    txtUpdatePrice.Text = objdr.GetDouble("Trim(Price) + 0")
                    txtUpdateput.Text = objdr.GetDouble("Trim(Price) + 0")
                End While
            End If
            objconn.Close()

            If txQuantd.Text = "" Then
                txQuantd.Enabled = False
                txtUpdatePrice.Enabled = False
            Else
                txQuantd.Enabled = True
                txtUpdatePrice.Enabled = True
            End If
        Else

            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "Select  Quantity,Trim(Price) + 0 from product_quantity inner join product_table  on product_quantity.Product_ID = product_table.Product_ID " _
                    & "inner join product_size on product_quantity.Size_ID = product_size.Size_ID where product_Name = '" & CStr(txtP.Text) & "' And  product_size.Size_Name='" & CStr(cmbSized.Text) & "' "
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    txQuantd.Text = objdr.GetInt32("Quantity")
                    txtQ.Text = objdr.GetInt32("Quantity")
                    txtUpdatePrice.Text = objdr.GetDouble("Trim(Price) + 0")
                    txtUpdateput.Text = objdr.GetDouble("Trim(Price) + 0")
                End While
            End If
            objconn.Close()

            If txQuantd.Text = "" Then
                txQuantd.Enabled = False
                txtUpdatePrice.Enabled = False
            Else
                txQuantd.Enabled = True
                txtUpdatePrice.Enabled = True
            End If
        End If
    End Sub

    Private Sub txQuantd_KeyDown(sender As Object, e As KeyEventArgs) Handles txQuantd.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtUpdatePrice.Focus()
        End If
    End Sub

    Private Sub txQuantd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txQuantd.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Then e.Handled = False
    End Sub

    Private Sub btnUpdateProd_Click(sender As Object, e As EventArgs) Handles btnUpdateProd.Click
        'Dim prod As String = txtP.Text
        'Dim quanty As String = txQuantd.Text
        'Dim comboSize As String = txtS.Text

        '  Valid = (txQuantd.Text <> txtQ.Text) And (txtfillProd.Text <> txtP.Text)
        If txtfillProd.Text = txtP.Text And cmbSized.Text = "" Then
            MessageBox.Show("Select Size of a Product", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbSized.BackColor = Color.PapayaWhip
            cmbSized.Focus()
        ElseIf txtfillProd.Text <> txtP.Text And txtQ.Text = "" Then
            question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If question = MsgBoxResult.Yes Then
                objconn = New MySqlConnection
                objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                Try
                    objconn.Open()
                    ModifyQuerys = "Update product_table set Product_Name = '" & CStr(txtfillProd.Text) & "'  WHERE Product_Name = '" & CStr(txtP.Text) & "'"
                    objcmd = New MySqlCommand(ModifyQuerys, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()

                    objconn = New MySqlConnection
                    objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                    objconn.Open()
                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " modify our product name : " & CStr(txtP.Text) & " to  " & CStr(txtfillProd.Text) & " on ' ,CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "')) "
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()
                    fillProductQuantity()
                    txtProd.Text = ""
                    cmbselectSizes.Text = ""
                    cmbSized.Text = ""
                    txQuantd.Text = ""
                    txtUpdatePrice.Text = ""
                    MsgBox("Successfully Updated !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    'Finally
                    '    objconn.Close()
                End Try
            ElseIf question = MsgBoxResult.No Then
                Exit Sub
            End If
        ElseIf txtfillProd.Text <> txtP.Text Or txtfillProd.Text = txtP.Text And txQuantd.Text <> txtQ.Text Or txQuantd.Text = txtQ.Text And txtAddPrice.Text <> txtUpdateput.Text Or txtAddPrice.Text = txtUpdateput.Text Then
            Add_Update_raw()
        ElseIf txtfillProd.Text = txtP.Text And cmbSized.Text <> "" And txtQ.Text = "" Then
            MsgBox("No changes were made?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        End If


        objconn.Open()
        objdt = New DataTable
        With objcmd
            .Connection = objconn
            .CommandText = "SELECT  * FROM product_table where product_ID =" & CInt(txtID.Text) & ""
        End With
        objda.SelectCommand = objcmd
        objda.Fill(objdt)
        objdr = objcmd.ExecuteReader
        If objdr.HasRows Then
            While objdr.Read
                txtP.Text = objdr.GetString("product_name")

                '  CellClickableQuant.txtQuants.Text = objdr.GetInt32("Quantity")
            End While
        End If
        objconn.Close()


        objconn.Open()
        objdt = New DataTable
        With objcmd
            .Connection = objconn
            .CommandText = "Select  Quantity from product_quantity inner join product_table  on product_quantity.Product_ID = product_table.Product_ID " _
            & "inner join product_size on product_quantity.Size_ID = product_size.Size_ID where product_Name = '" & CStr(txtP.Text) & "' And product_size.Size_Name='" & CStr(cmbSized.Text) & "'"

        End With
        objda.SelectCommand = objcmd
        objda.Fill(objdt)
        objdr = objcmd.ExecuteReader
        If objdr.HasRows Then
            While objdr.Read
                txtQ.Text = objdr.GetInt32("Quantity")

                '  CellClickableQuant.txtQuants.Text = objdr.GetInt32("Quantity")
            End While
        End If
        objconn.Close()

    End Sub

    Private Sub txtProd_TextChanged(sender As Object, e As EventArgs) Handles txtProd.TextChanged
        txtProd.BackColor = Color.White
    End Sub

    Private Sub txQuantd_TextChanged(sender As Object, e As EventArgs) Handles txQuantd.TextChanged
        txQuantd.BackColor = Color.White
    End Sub

    Private Sub btnDeleteProd_Click(sender As Object, e As EventArgs) Handles btnDeleteProd.Click
        If IsNothing(cmbSized.SelectedItem) Then
            MessageBox.Show("Select Size of a Product", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbSized.BackColor = Color.PapayaWhip
            cmbSized.Focus()
        Else
            Dim produ As String = txtfillProd.Text
            Dim quantiy As String = txQuantd.Text
            Dim comboBoxSize As String = cmbSized.Text
            question = MsgBox("Are you sure you want to Remove all " & comboBoxSize & " Size at " & produ & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If question = MsgBoxResult.Yes Then
                objconn = New MySqlConnection
                objconn.ConnectionString = "server=localhost;username=root; password=; database=red_cheese_pizza_database"
                Try
                    objconn.Open()
                    DeleteQuery = "Delete  from product_quantity where product_ID IN (Select Product_ID from product_table where Product_Name =  '" & produ & "') And " _
                        & "Size_ID IN (Select Size_ID from product_size where Size_Name = '" & CStr(txtS.Text) & "') "
                    objcmd = New MySqlCommand(DeleteQuery, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()

                    objconn = New MySqlConnection
                    objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                    objconn.Open()
                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " remove our Product which is  " & CStr(produ) & " on ',CURRENT_TIMESTAMP, " _
                                    & " (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "'))"
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()

                    txQuantd.Text = ""
                    txQuantd.Enabled = False
                    txtUpdatePrice.Text = ""
                    txtUpdatePrice.Enabled = False
                    fillProductQuantity()
                    MsgBox("Sucessfully Removed !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "REMOVE")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            ElseIf question = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtAddPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAddPrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdSubmitAdd.PerformClick()
        End If
    End Sub
    Private Sub txtAddPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddPrice.KeyPress
        Dim allowedChars As String = "0987654321."
        If (txtAddPrice.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedChars.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub
    Private Sub txtAddPrice_TextChanged(sender As Object, e As EventArgs) Handles txtAddPrice.TextChanged
        txtAddPrice.BackColor = Color.White
    End Sub

    Private Sub txtUpdatePrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUpdatePrice.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnUpdateProd.PerformClick()
        End If
    End Sub
    Private Sub txtUpdatePrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUpdatePrice.KeyPress
        Dim allowedChars As String = "0987654321."
        If (txtUpdatePrice.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedChars.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub

    Private Sub txtUpdatePrice_TextChanged(sender As Object, e As EventArgs) Handles txtUpdatePrice.TextChanged

    End Sub
End Class