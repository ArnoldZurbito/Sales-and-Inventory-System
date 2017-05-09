Imports MySql.Data.MySqlClient

Module Addquery
    Public txtsol, cmbsol As String
    Public txtreg, cmbreg As String
    Public txtfam, cmbfam As String
    Public txtthin, cmbthin As String
    Public txtdeep, cmbdeep As String
    Public txtglass, cmbglass As String
    Public txtnone, cmbnone As String
    Public Sub clearfield()
        Add_Prod.txtConSolo.Text = ""
        Add_Prod.txtConReg.Text = ""
        Add_Prod.txtConFam.Text = ""
        Add_Prod.txtConThin.Text = ""
        Add_Prod.txtConDeep.Text = ""
        Add_Prod.txtconNone.Text = ""
        Add_Prod.txtconGlass.Text = ""
        Add_Prod.cmbUnitSolo.Text = ""
        Add_Prod.cmbUnitReg.Text = ""
        Add_Prod.cmbUnitFam.Text = ""
        Add_Prod.cmbUnitThin.Text = ""
        Add_Prod.cmbUnitDeep.Text = ""
        Add_Prod.cmbunitNone.Text = ""
        Add_Prod.cmbunitGlass.Text = ""
        Add_Prod.TextBox1.Text = ""
    End Sub
    Public Sub Onlysolo()
        'backtoback = True
        Add_Prod.txtSolos.Text = "Solo"
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL) " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo')"
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo Size but You Can add Raw Material at " & Environment.NewLine & " Regular,Family,Superthin or Chicago Deep Dish Size if it is considered as a Raw Materials of our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & " Consume every material " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    objconn = New MySqlConnection
                    objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                    objconn.Open()
                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table " _
                                        & "WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CInt(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'), " _
                                        & "(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); "
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()
                    clearfield()
                    disabletxt()
                    'grpnotedisableme()
                    fillProdukto()
                    MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()
                    Exit Sub
                End If
                objconn.Close()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
        End Try
        'backtoback = False
    End Sub
    Public Sub OnlyRegular()

        'backtobacko = True
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                 & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                 & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL) " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Regular') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Regular Size but You Can add Raw Material at " & Environment.NewLine & " Solo, Family,Superthin or Chicago Deep Dish Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & " Consume every materials " & Environment.NewLine & "" & txtreg & " " & cmbreg & " at Regular size, " & Environment.NewLine & "" _
                                 & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then

                    objconn = New MySqlConnection
                    objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                    objconn.Open()
                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values " _
                                    & " ((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ", " _
                                    & " (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where " _
                                    & " Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); "
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()
                    clearfield()
                    disabletxt()
                    fillProdukto()
                    MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub

                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
        End Try
        'backtobacko = False
    End Sub
    Public Sub OnlyFam()

        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                 & " AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL) " _
                                 & " AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Family') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Family Size but You Can add Raw Material at " & Environment.NewLine & " Solo,Regular,Superthin or Chicago Deep Size, if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitFam.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitFam.Focus()
                Add_Prod.txtConFam.BackColor = Color.PapayaWhip
                Add_Prod.txtConFam.Focus()
                Add_Prod.lblcon3.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials" & Environment.NewLine & "" & txtfam & " " & cmbfam & " at Family size, " & Environment.NewLine & "" _
                                 & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then


                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) " _
                                        & "values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ", " _
                                        & "(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'), " _
                                        & "(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'), " _
                                        & "(Select Size_ID from product_size where Size_Name = 'Family')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        fillProdukto()
                        clearfield()
                        disabletxt()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub

                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
        End Try
    End Sub
    Public Sub OnlyThin()

        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                 & " AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL) " _
                                 & " AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Superthin') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Superthin Size but You Can add Raw Material at Solo, Regular,Family or " & Environment.NewLine & " Chicago Deep Dish Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials" & Environment.NewLine & "" & txtthin & " " & cmbthin & " at Superthin size, " & Environment.NewLine & "" _
                                 & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) " _
                                        & "values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ", " _
                                        & "(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'), " _
                                        & "(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'), " _
                                        & "(Select Size_ID from product_size where Size_Name = 'Superthin')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        fillProdukto()
                        clearfield()
                        disabletxt()
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
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
        End Try
    End Sub
    Public Sub OnlyDeep()

        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                 & " AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL) " _
                                 & " AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Chicago Deep Dish Size but You Can add Raw Material at Solo, Regular,Family or " & Environment.NewLine & " Superthin Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitDeep.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitDeep.Focus()
                Add_Prod.txtConDeep.BackColor = Color.PapayaWhip
                Add_Prod.txtConDeep.Focus()
                Add_Prod.lblcon5.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials" & Environment.NewLine & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size, " & Environment.NewLine & "" _
                                 & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) " _
                                        & "values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ", " _
                                        & "(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'), " _
                                        & "(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'), " _
                                        & "(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        fillProdukto()
                        clearfield()
                        disabletxt()
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
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
        End Try
    End Sub
    Public Sub SoloReg()
        'sOLO AND REG LAMAN

        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                 & " AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') AND Unit_ID IN (Select Unit_ID from unit_table " _
                                 & " where unit_table.Unit_Name IS NOT NULL) AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo'  OR Size_Name = 'Regular')"
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo or Regular Size but You Can add Raw Material at Family Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red

                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                   & "" & txtreg & " " & cmbreg & " at Regular size," & Environment.NewLine & "" _
                                   & " Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values " _
                                & "((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "'), " _
                                & " " & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'), " _
                                & "(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'), " _
                                & "(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values " _
                                & "((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "'), " _
                                & " " & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'), " _
                                & "(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'), " _
                                & "(Select Size_ID from product_size where Size_Name = 'Regular')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
        End Try
    End Sub
    Public Sub SoloFam()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Family') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo or Family Size but You Can add Raw Material at Regular Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtfam & " " & cmbfam & " at Family size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
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
            MsgBox(Err.Description, MsgBoxStyle.Critical, "SoloFam(Issue).Contact your Programmer About this Error. Thank You.")
        End Try
    End Sub
    Public Sub SoloThin()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Superthin') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo or Superthin Size but You Can add Raw Material at Regular,Family or Chicago Deep Dish Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
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
            MsgBox(Err.Description, MsgBoxStyle.Critical, "SoloThin(Issue).Contact your Programmer About this Error. Thank You.")
        End Try
    End Sub
    Public Sub RegFam()
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Regular' Or Size_Name ='Family') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Regular or Family Size but You Can add Raw Material at Solo Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtreg & " " & cmbreg & " at Regular size, " & Environment.NewLine & "" _
                                 & "" & txtfam & " " & cmbfam & " at Family size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "RegFam(Issue).Contact your Programmer About this Error. Thank You.")
        End Try
    End Sub
    Public Sub RegThin()
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Regular' Or Size_Name ='Superthin') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Regular or Superthin Size but You Can add Raw Material at " & Environment.NewLine & " Solo,Family or Chicken Deep Dish Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtreg & " " & cmbreg & " at Regular size, " & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "RegThin(Issue).Contact your Programmer About this Error. Thank You.")
        End Try

    End Sub
    Public Sub RegDeep()
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Regular' Or Size_Name ='Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Regular or Chicago Deep Dish Size but You Can add Raw Material at " & Environment.NewLine & " Solo,Family or Superthin Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtreg & " " & cmbreg & " at Regular size, " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub FamThin()
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Family' Or Size_Name ='Superthin') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Family or Superthin Size but You Can add Raw Material at " & Environment.NewLine & " Solo,Regular or Chicago Deep Dish Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitFam.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitFam.Focus()
                Add_Prod.txtConFam.BackColor = Color.PapayaWhip
                Add_Prod.txtConFam.Focus()
                Add_Prod.lblcon3.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtfam & " " & cmbfam & " at Family size, " & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub FamDeep()
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbthin = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Family' Or Size_Name ='Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Family or Chicago Deep Dish Size but You Can add Raw Material at " & Environment.NewLine & " Solo,Regular or Superthin Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitFam.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitFam.Focus()
                Add_Prod.txtConFam.BackColor = Color.PapayaWhip
                Add_Prod.txtConFam.Focus()
                Add_Prod.lblcon3.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtfam & " " & cmbfam & " at Family size, " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SoloDeep()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo or Chicago Deep Dish Size but You Can add Raw Material at Regular,Family or Superthin Size, if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SoloRegFam()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Regular' Or Size_Name ='Family') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo or Regular or Family Size but You Can add Raw Material at Dont Know Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red

                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red

                Add_Prod.cmbUnitFam.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitFam.Focus()
                Add_Prod.txtConFam.BackColor = Color.PapayaWhip
                Add_Prod.txtConFam.Focus()
                Add_Prod.lblcon3.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtreg & " " & cmbreg & " at Regular size," & Environment.NewLine & "" _
                                 & "" & txtfam & " " & cmbfam & " at Family size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SoloRegThin()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Regular' Or Size_Name ='Superthin') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo or Regular or Superthin Size but You Can add Raw Material at Family or Chicago Deep Dish Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red

                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red

                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtreg & " " & cmbreg & " at Regular size," & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SoloRegDeep()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Regular' Or Size_Name ='Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo or Regular or Chicago Deep Dish Size but You Can add Raw Material at Family or Suprthin Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red

                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red

                Add_Prod.cmbUnitDeep.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitDeep.Focus()
                Add_Prod.txtConDeep.BackColor = Color.PapayaWhip
                Add_Prod.txtConDeep.Focus()
                Add_Prod.lblcon5.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtreg & " " & cmbreg & " at Regular size," & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish')); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SoloRegFamThinDeep()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Regular' Or Size_Name ='Family' Or Size_Name = 'Superthin' Or Size_Name = 'Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo/Regular/Family/Superthin/Chicago Deep Dish Size but You Can add Raw Material at Dont Know Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red

                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red

                Add_Prod.cmbUnitFam.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitFam.Focus()
                Add_Prod.txtConFam.BackColor = Color.PapayaWhip
                Add_Prod.txtConFam.Focus()
                Add_Prod.lblcon3.ForeColor = Color.Red

                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red

                Add_Prod.cmbUnitDeep.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitDeep.Focus()
                Add_Prod.txtConDeep.BackColor = Color.PapayaWhip
                Add_Prod.txtConDeep.Focus()
                Add_Prod.lblcon5.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtreg & " " & cmbreg & " at Regular size," & Environment.NewLine & "" _
                                 & "" & txtfam & " " & cmbfam & " at Family size. " & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & "" _
                                 & " , Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish')); "

                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub RegFamThin()
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Regular' Or Size_Name ='Family' Or Size_Name ='Superthin') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo/Regular/Superthin Size but You Can add Raw Material at Solo or Chicago Deep Dish Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)


                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red

                Add_Prod.cmbUnitFam.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitFam.Focus()
                Add_Prod.txtConFam.BackColor = Color.PapayaWhip
                Add_Prod.txtConFam.Focus()
                Add_Prod.lblcon3.ForeColor = Color.Red

                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red

            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtreg & " " & cmbreg & " at Regular size, " & Environment.NewLine & "" _
                                 & "" & txtfam & " " & cmbfam & " at Family size. " & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & "" _
                                 & " , Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin'));"

                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SolThinDeep()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Superthin' Or Size_Name ='Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo/Superthin/Chicago Deep Dish Size but You Can add Raw Material at Regular or Family Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red

                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red

                Add_Prod.cmbUnitDeep.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitDeep.Focus()
                Add_Prod.txtConDeep.BackColor = Color.PapayaWhip
                Add_Prod.txtConDeep.Focus()
                Add_Prod.lblcon5.ForeColor = Color.Red

            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & "" _
                                 & " , Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish'));"

                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub RegThinDeep()
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Regular' Or Size_Name ='Superthin' Or Size_Name ='Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Regular/Superthin/Chicago Deep Dish Size but You Can add Raw Material at Solo or Family Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red

                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red

                Add_Prod.cmbUnitDeep.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitDeep.Focus()
                Add_Prod.txtConDeep.BackColor = Color.PapayaWhip
                Add_Prod.txtConDeep.Focus()
                Add_Prod.lblcon5.ForeColor = Color.Red

            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtreg & " " & cmbreg & " at Regular size, " & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & "" _
                                 & " , Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish'));"

                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub FamThinDeep()
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Family' Or Size_Name ='Superthin' Or Size_Name ='Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Family/Superthin/Chicago Deep Dish Size but You Can add Raw Material at Solo or Regular Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Add_Prod.cmbUnitFam.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitFam.Focus()
                Add_Prod.txtConFam.BackColor = Color.PapayaWhip
                Add_Prod.txtConFam.Focus()
                Add_Prod.lblcon3.ForeColor = Color.Red

                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red

                Add_Prod.cmbUnitDeep.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitDeep.Focus()
                Add_Prod.txtConDeep.BackColor = Color.PapayaWhip
                Add_Prod.txtConDeep.Focus()
                Add_Prod.lblcon5.ForeColor = Color.Red

            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtfam & " " & cmbfam & " at Family size, " & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & "" _
                                 & " , Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish'));"

                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SolRegThinDeep()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Regular' Or Size_Name = 'Superthin' Or Size_Name = 'Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo/Regular/Family/Superthin/Chicago Deep Dish Size but You Can add Raw Material at Dont Know Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red

                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red

                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red

                Add_Prod.cmbUnitDeep.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitDeep.Focus()
                Add_Prod.txtConDeep.BackColor = Color.PapayaWhip
                Add_Prod.txtConDeep.Focus()
                Add_Prod.lblcon5.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtreg & " " & cmbreg & " at Regular size," & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & "" _
                                 & " , Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish')); "

                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SolRegFamDeep()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Regular' Or Size_Name ='Family' Or Size_Name = 'Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo/Regular/Family/Chicago Deep Dish Size but You Can add Raw Material at Superthin Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red

                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red

                Add_Prod.cmbUnitFam.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitFam.Focus()
                Add_Prod.txtConFam.BackColor = Color.PapayaWhip
                Add_Prod.txtConFam.Focus()
                Add_Prod.lblcon3.ForeColor = Color.Red

                Add_Prod.cmbUnitDeep.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitDeep.Focus()
                Add_Prod.txtConDeep.BackColor = Color.PapayaWhip
                Add_Prod.txtConDeep.Focus()
                Add_Prod.lblcon5.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtreg & " " & cmbreg & " at Regular size," & Environment.NewLine & "" _
                                 & "" & txtfam & " " & cmbfam & " at Family size. " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & "" _
                                 & " , Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish')); "

                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub SolFamThinDeep()
        txtsol = CDec(Add_Prod.txtConSolo.Text)
        cmbsol = CStr(Add_Prod.cmbUnitSolo.Text)
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Solo' Or Size_Name ='Family' Or Size_Name = 'Superthin' Or Size_Name = 'Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Solo/Family/Superthin/Chicago Deep Dish Size but You Can add Raw Material at Regular Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbUnitSolo.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitSolo.Focus()
                Add_Prod.txtConSolo.BackColor = Color.PapayaWhip
                Add_Prod.txtConSolo.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red

                Add_Prod.cmbUnitFam.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitFam.Focus()
                Add_Prod.txtConFam.BackColor = Color.PapayaWhip
                Add_Prod.txtConFam.Focus()
                Add_Prod.lblcon3.ForeColor = Color.Red

                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red

                Add_Prod.cmbUnitDeep.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitDeep.Focus()
                Add_Prod.txtConDeep.BackColor = Color.PapayaWhip
                Add_Prod.txtConDeep.Focus()
                Add_Prod.lblcon5.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtsol & " " & cmbsol & " at Solo size, " & Environment.NewLine & "" _
                                 & "" & txtfam & " " & cmbfam & " at Family size. " & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & "" _
                                 & " , Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtsol) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbsol) & "'),(Select Size_ID from product_size where Size_Name = 'Solo')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish')); "

                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub RegFamThinDeep()
        txtreg = CDec(Add_Prod.txtConReg.Text)
        cmbreg = CStr(Add_Prod.cmbUnitReg.Text)
        txtfam = CDec(Add_Prod.txtConFam.Text)
        cmbfam = CStr(Add_Prod.cmbUnitFam.Text)
        txtthin = CDec(Add_Prod.txtConThin.Text)
        cmbthin = CStr(Add_Prod.cmbUnitThin.Text)
        txtdeep = CDec(Add_Prod.txtConDeep.Text)
        cmbdeep = CStr(Add_Prod.cmbUnitDeep.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL)  " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Regular' Or Size_Name ='Family' Or Size_Name = 'Superthin' Or Size_Name = 'Chicago Deep Dish') "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists at Regular/Family/Superthin/Chicago Deep Dish Size but You Can add Raw Material at Solo Size if it is considered as a Raw Materials in our Product .", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Add_Prod.cmbUnitReg.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitReg.Focus()
                Add_Prod.txtConReg.BackColor = Color.PapayaWhip
                Add_Prod.txtConReg.Focus()
                Add_Prod.lblcon2.ForeColor = Color.Red

                Add_Prod.cmbUnitFam.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitFam.Focus()
                Add_Prod.txtConFam.BackColor = Color.PapayaWhip
                Add_Prod.txtConFam.Focus()
                Add_Prod.lblcon3.ForeColor = Color.Red

                Add_Prod.cmbUnitThin.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitThin.Focus()
                Add_Prod.txtConThin.BackColor = Color.PapayaWhip
                Add_Prod.txtConThin.Focus()
                Add_Prod.lblcon4.ForeColor = Color.Red

                Add_Prod.cmbUnitDeep.BackColor = Color.PapayaWhip
                Add_Prod.cmbUnitDeep.Focus()
                Add_Prod.txtConDeep.BackColor = Color.PapayaWhip
                Add_Prod.txtConDeep.Focus()
                Add_Prod.lblcon5.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding an " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & "  Consume every materials " & Environment.NewLine & "" & txtreg & " " & cmbreg & " at Regular size, " & Environment.NewLine & "" _
                                 & "" & txtfam & " " & cmbfam & " at Family size. " & Environment.NewLine & "" _
                                 & "" & txtthin & " " & cmbthin & " at Superthin size. " & Environment.NewLine & "" _
                                 & "" & txtdeep & " " & cmbdeep & " at Chicago Deep Dish size. " & Environment.NewLine & "" _
                                 & " , Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then
                    Try
                        objconn = New MySqlConnection
                        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtreg) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbreg) & "'),(Select Size_ID from product_size where Size_Name = 'Regular')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtfam) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbfam) & "'),(Select Size_ID from product_size where Size_Name = 'Family')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtthin) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbthin) & "'),(Select Size_ID from product_size where Size_Name = 'Superthin')); " _
                                            & "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtdeep) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'),(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbdeep) & "'),(Select Size_ID from product_size where Size_Name = 'Chicago Deep Dish')); "

                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        clearfield()
                        disabletxt()
                        fillProdukto()
                        MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                    End Try
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub txtcmbAdds()
        question = MsgBox("Are you sure you want to update raw material ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE raw_material_table set raw_material_table.Raw_Name =  '" & CStr(ModifyRaw.txtRawNamed.Text) & "' where raw_material_table.Raw_Name = '" & CStr(ModifyRaw.txtputRaw.Text) & "'; " _
                            & " UPDATE raw_expiration_date set raw_expiration_date.Raw_Quantity =  " & ModifyRaw.resQuantt & ", raw_expiration_date.Unit_ID =(Select Unit_ID from unit_table  where unit_table.Unit_Name = '" & CStr(ModifyRaw.cmbunitt) & "'), raw_expiration_date.Raw_Expiration_Date = '" & ModifyRaw.resDate & "' where DATE_FORMAT(raw_expiration_date.Raw_Expiration_Date,'%m/%d/%Y') = '" & CStr(ModifyRaw.txtExpiration.Text) & "'"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                objconn.Close()
                FillRawMats()
                ModifyRaw.cmbModifyUnit.Text = ""
                ModifyRaw.txtQuantitys.Text = ""

                ModifyRaw.txtQuantitys.Enabled = False
                ModifyRaw.cmbModifyUnit.Enabled = False
                ModifyRaw.DateTimePicker1.Enabled = False
                ModifyRaw.btnDeleteRawMat.Enabled = False
                ModifyRaw.btnSaveModify.Enabled = False
                ModifyRaw.DateTimePicker1.CustomFormat = " "  'An empty SPACE
                ModifyRaw.DateTimePicker1.Format = DateTimePickerFormat.Custom
                ModifyRaw.CheckedListBox1.Items.Clear()
                ModifyRaw.loadchkRaws()
                ModifyRaw.false_field()
                MsgBox("Successfully Updated !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
            Finally
                objconn.Close()
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub Add_Update_raw()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "Update product_table set Product_Name = '" & CStr(CellClickableQuant.txtfillProd.Text) & "'  WHERE Product_Name = '" & CStr(CellClickableQuant.txtP.Text) & "'; " _
                    & " UPDATE product_quantity set product_quantity.Quantity = " & CInt(CellClickableQuant.txQuantd.Text) & ", product_quantity.Price = " & CDbl(CellClickableQuant.txtUpdatePrice.Text) & " where Product_ID IN (Select Product_ID from product_table where product_table.Product_Name = '" & CStr(CellClickableQuant.txtfillProd.Text) & "') " _
                    & " And Size_ID IN (select Size_ID from product_size where product_size.Size_Name= '" & CStr(CellClickableQuant.txtS.Text) & "')"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                objconn.Close()
                fillProductQuantity()
                CellClickableQuant.txtProd.Text = ""
                CellClickableQuant.cmbselectSizes.Text = ""
                '
                'objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                'objconn.Open() 
                'With objcmd
                '    .Connection = objconn
                '    .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " add " & nameprod & " box/es of " & prog & " size: " & cmbSize & " at ',CURRENT_TIMESTAMP, " _
                '                & "(select user_company_id from user_account where Username = Sha1('" & Loginfrm.UsernameTextBox.Text & "') And Account_Type = (SELECT Account_Type from user_account where Username = Sha1('" & Loginfrm.UsernameTextBox.Text & "'))))"
                '    .ExecuteNonQuery()
                'End With
                'objconn.Close()
                MsgBox("Successfully Updated !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
                'Finally
                '    objconn.Close()
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub OnlyGlass()
        'backtoback = True
        Add_Prod.txtSolos.Text = "Solo"
        txtglass = CDec(Add_Prod.txtconGlass.Text)
        cmbglass = CStr(Add_Prod.cmbunitGlass.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL) " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='Glass')"
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists.", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbunitGlass.BackColor = Color.PapayaWhip
                Add_Prod.cmbunitGlass.Focus()
                Add_Prod.txtconGlass.BackColor = Color.PapayaWhip
                Add_Prod.txtconGlass.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & " Consume every material " & Environment.NewLine & "" & txtglass & " " & cmbglass & " at per Glass, " & Environment.NewLine & "" _
                                 & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then

                    objconn = New MySqlConnection
                    objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                    objconn.Open()
                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table " _
                                        & "WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtglass) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'), " _
                                        & "(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbglass) & "'),(Select Size_ID from product_size where Size_Name = 'Glass')); "
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()
                    clearfield()
                    disabletxt()
                    'grpnotedisableme()
                    fillProdukto()
                    MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
                objconn.Close()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
        End Try
        'backtoback = False
    End Sub
    Public Sub OnlyNone()
        'backtoback = True
        Add_Prod.txtSolos.Text = "Solo"
        txtnone = CDec(Add_Prod.txtconNone.Text)
        cmbnone = CStr(Add_Prod.cmbunitNone.Text)
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select * from material_every_product where Product_ID IN (Select Product_ID from product_table where Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "') " _
                                & "AND Raw_ID IN (Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "') " _
                                & "AND Unit_ID IN (Select Unit_ID from unit_table where unit_table.Unit_Name IS NOT NULL) " _
                                & "AND Size_ID IN (Select Size_ID from product_size where Size_Name ='None')"
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                MessageBox.Show("Raw Material Already Exists.", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Add_Prod.cmbunitNone.BackColor = Color.PapayaWhip
                Add_Prod.cmbunitNone.Focus()
                Add_Prod.txtconNone.BackColor = Color.PapayaWhip
                Add_Prod.txtconNone.Focus()
                Add_Prod.lblcon1.ForeColor = Color.Red
            Else
                question = MsgBox("Your Adding " & CStr(Add_Prod.TextBox1.Text) & " to " & CStr(Add_Prod.txtProd.Text) & " Consume every material " & Environment.NewLine & "" & txtnone & " " & cmbnone & " at per pieces " & Environment.NewLine & "" _
                                 & ", Do You Want To Continue ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                If question = MsgBoxResult.Yes Then

                    objconn = New MySqlConnection
                    objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"

                    objconn.Open()
                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert into material_every_product (Product_ID,Minus_Material_Every_Product,Raw_ID,unit_ID,Size_ID) values((SELECT Product_ID FROM product_table " _
                                        & "WHERE Product_Name ='" & CStr(Add_Prod.txtProd.Text) & "')," & CDbl(txtnone) & ",(Select Raw_ID from raw_material_table where Raw_Name ='" & CStr(Add_Prod.TextBox1.Text) & "'), " _
                                        & "(Select Unit_ID from unit_table where Unit_Name = '" & CStr(cmbnone) & "'),(Select Size_ID from product_size where Size_Name = 'None')); "
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()
                    clearfield()
                    disabletxt()
                    'grpnotedisableme()
                    fillProdukto()
                    MsgBox("Data Added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
                ElseIf question = MsgBoxResult.No Then
                    objconn.Close()

                    Exit Sub
                End If
                objconn.Close()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
        End Try
        'backtoback = False
    End Sub

End Module
