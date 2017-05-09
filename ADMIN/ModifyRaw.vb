Imports MySql.Data.MySqlClient
Public Class ModifyRaw
    Public selectunitquery As String
    Public resDatePick As String
    Public restxtQuant As Integer = 0
    Dim Updatess As String
    Public QuantityRaw As String

    Public resQuantt As String
    Public cmbunitt As String
    Public resDate As String
    Public Sub loadchkRaws()
        objconn.Open()
        objdt = New DataTable
        With objcmd
            .Connection = objconn
            .CommandText = "SELECT  * FROM raw_material_table where Raw_ID = " & CInt(txtputID.Text) & ""
        End With
        objda.SelectCommand = objcmd
        objda.Fill(objdt)
        objdr = objcmd.ExecuteReader
        If objdr.HasRows Then
            While objdr.Read
                txtputRaw.Text = objdr.GetString("Raw_Name")
            End While
        End If
        objconn.Close()

        chklistboxModify.Items.Clear()
        CheckedListBox1.Items.Clear()
        chklistboxModify.BackColor = Color.White
        txtQuantitys.Text = ""
        cmbModifyUnit.Text = ""
        DateTimePicker1.CustomFormat = " "
        txtQuantitys.Enabled = False
        cmbModifyUnit.Enabled = False
        DateTimePicker1.Enabled = False
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select Raw_Name,DATE_FORMAT(`Raw_Expiration_Date`,'%m/%d/%Y'),Concat(CASE WHEN Trim(`Raw_Quantity` * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END) + 0 >= 1000000 THEN  CONCAT (Trim(`Raw_Quantity` * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END) / 1000000, ' kG/s')     WHEN Trim(`Raw_Quantity` * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END) + 0 >= 1000 THEN   CONCAT (Trim(`Raw_Quantity` * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END) / 1000, ' gram/s')     WHEN Trim(`Raw_Quantity` * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END) + 0 >= 1 THEN   CONCAT (Trim(`Raw_Quantity` * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END) / 1, ' mG/s') " _
                            & " WHEN TRIM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END) + 0  >= 1000 THEN CASE WHEN (TRIM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END) / 1000) >= 3.785 THEN CONCAT(TRIM(TRIM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END / 1000)  / 3.785 ) + 0 , ' gallon/s') WHEN (TRIM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END) / 1000) < 3.785 THEN CONCAT((TRIM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END) / 1000), ' liter/s') " _
                            & " end " _
                            & " WHEN TRIM((Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1  THEN  CONCAT(TRIM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END) + 0 / 1 , ' mL/s') " _
                            & " WHEN TRIM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12  END)  >= 12 " _
                            & " THEN  CONCAT(TRIM(TRUNCATE(TRIM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) / 12 ,3)) + 0  , ' dozen/s') WHEN TRIM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) < 12  THEN  CONCAT(TRIM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) / 1 , ' piece/s') " _
                            & "  END " _
                            & " ,' - ',DATE_FORMAT(`Raw_Expiration_Date`,'%m/%d/%Y')) as 'QUANTITY_UNIT_EXPIRATION' from raw_expiration_date inner join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID inner join raw_material_table ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where Raw_Material_Table.Raw_Name ='" & CStr(txtputRaw.Text) & "' ORDER BY DATE_FORMAT(`Raw_Expiration_Date`,'%m/%d/%Y') ASC "
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    Dim papatay As String = objdr.GetString("QUANTITY_UNIT_EXPIRATION")
                    chklistboxModify.Items.Add(papatay)
                    Dim papatayin As String = objdr.GetString("DATE_FORMAT(`Raw_Expiration_Date`,'%m/%d/%Y')")
                    CheckedListBox1.Items.Add(papatayin)
                    ' TextBox1.Text = objdr.GetString("Raw_Name")
                    'TextBox2.Text = objdr.GetInt32("Trim(Raw_Quantity) + 0") 'For not edited Raw Quantity
                End While
            End If
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub loadcmbUnitt()
        objconn = New MySqlConnection
        objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
        Try
            objconn.Open()
            selectunitquery = "select * from unit_table"
            objcmd = New MySqlCommand(selectunitquery, objconn)
            objdr = objcmd.ExecuteReader
            While objdr.Read
                Dim pasak = objdr.GetString("unit_name")
                cmbModifyUnit.Items.Add(pasak)
                'putUnit.Items.Add(pasak)
            End While
            objconn.Close()
        Catch ex As Exception
        Finally

        End Try
    End Sub
    Public Sub false_field()
        txtQuantitys.Enabled = False
        cmbModifyUnit.Enabled = False
        btnSaveModify.Enabled = False
        DateTimePicker1.Enabled = False
        btnDeleteRawMat.Enabled = False
        DateTimePicker1.CustomFormat = " "  'An empty SPACE
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker3.CustomFormat = " "  'An empty SPACE
        DateTimePicker3.Format = DateTimePickerFormat.Custom
    End Sub

    Private Sub ModifyRaw_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CheckedListBox1.Items.Clear()
        DateTimePicker1.CustomFormat = " "
        txtQuantitys.Text = ""
        cmbModifyUnit.Text = ""
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        Me.Hide()
        'Modall.Show()
    End Sub
    Public Sub conunit()
        putUnit.Items.Clear()
        Try
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "SELECT unit_table.Unit_Name FROM unit_table inner join raw_expiration_date on raw_expiration_date.unit_ID =unit_table.Unit_ID inner join raw_material_table on raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where raw_material_table.Raw_Name = '" & txtRawNamed.Text & "'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                '    Dim pas As String
                While objdr.Read
                    'Dim ser As String = objdr.GetString("Unit_Name")
                    'putUnit.Items.Add(ser)
                    If (objdr.GetString("Unit_Name") = "mG/s" Or objdr.GetString("Unit_Name") = "gram/s" Or objdr.GetString("Unit_Name") = "kG/s") Then
                        putUnit.Items.Clear()
                        cmbModifyUnit.Items.Clear()
                        putUnit.Items.Add("mG/s")
                        cmbModifyUnit.Items.Add("mG/s")
                        putUnit.Items.Add("gram/s")
                        cmbModifyUnit.Items.Add("gram/s")
                        putUnit.Items.Add("kG/s")
                        cmbModifyUnit.Items.Add("kG/s")
                    ElseIf (objdr.GetString("Unit_Name") = "piece/s" Or objdr.GetString("Unit_Name") = "dozen/s") Then
                        putUnit.Items.Clear()
                        cmbModifyUnit.Items.Clear()
                        putUnit.Items.Add("piece/s")
                        cmbModifyUnit.Items.Add("piece/s")
                        putUnit.Items.Add("dozen/s")
                        cmbModifyUnit.Items.Add("dozen/s")
                    ElseIf (objdr.GetString("Unit_Name") = "mL/s" Or objdr.GetString("Unit_Name") = "liter/s" Or objdr.GetString("Unit_Name") = "gallon/s") Then
                        putUnit.Items.Clear()
                        cmbModifyUnit.Items.Clear()
                        putUnit.Items.Add("mL/s")
                        cmbModifyUnit.Items.Add("mL/s")
                        putUnit.Items.Add("liter/s")
                        cmbModifyUnit.Items.Add("liter/s")
                        putUnit.Items.Add("gallon/s")
                        cmbModifyUnit.Items.Add("gallon/s")
                    End If
                End While

            End If
            objconn.Close()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub ModifyRaw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        If Modall.lblAccountType.Text = "CREW" Then
            btnDeleteRawMat.Hide()
        ElseIf Modall.lblAccountType.Text = "ADMIN" Then
            btnDeleteRawMat.Show()
        End If
        conunit()
        ' filtercmb()
        ' loadcmbUnitt()
        false_field()
    End Sub

    Private Sub chklistboxModify_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles chklistboxModify.ItemCheck
        If e.NewValue = CheckState.Checked Then
            txtQuantitys.Enabled = True
            cmbModifyUnit.Enabled = True
            btnSaveModify.Enabled = True
            btnDeleteRawMat.Enabled = True
            DateTimePicker1.Enabled = True
            For Each i As Integer In chklistboxModify.CheckedIndices
                chklistboxModify.SetItemChecked(i, False)
            Next
            For Each im As Integer In chklistboxModify.SelectedIndices
                CheckedListBox1.SetItemChecked(im, True)
                CheckedListBox1.SetSelected(im, True)
            Next
        End If
    End Sub
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        txtExpiration.Text = CheckedListBox1.SelectedItem
        txtQuantitys.Text = ""
        With objcmd
            .Connection = objconn
            ' .CommandText = "select (CASE WHEN Raw_Quantity  < 1 Then Raw_Quantity * 1000 " _
            '         & " WHEN Raw_Quantity  < 1 Then Raw_Quantity * 1000 ELSE Raw_Quantity END) AS 'Name', " _
            '   & "(CASE WHEN Unit_Name = 'kG/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'gram/s' WHEN  ELSE Unit_Name  END) As 'Unitsop', " _
            '  & "DATE_FORMAT(`Raw_Expiration_Date`,'%c/%d/%Y') as 'expireraw' from raw_expiration_date inner join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID inner join raw_material_table ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where Raw_Material_Table.Raw_Name ='" & txtRawNamed.Text & "' AND DATE_FORMAT(`Raw_Expiration_Date`,'%c/%d/%Y') = '" & CStr(txtExpiration.Text) & "'"
            .CommandText = "select Trim(Raw_Quantity) + 0,Unit_Name,DATE_FORMAT(`Raw_Expiration_Date`,'%m/%d/%Y') as 'expireraw' from raw_expiration_date inner join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID inner join raw_material_table ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where Raw_Material_Table.Raw_Name ='" & txtputRaw.Text & "' AND DATE_FORMAT(`Raw_Expiration_Date`,'%m/%d/%Y') = '" & CStr(txtExpiration.Text) & "' "
        End With
        objconn.Open()
        objdr = objcmd.ExecuteReader
        If objdr.HasRows Then
            While objdr.Read
                txtQuantitys.Text = objdr.GetDouble("Trim(Raw_Quantity) + 0")
                cmbModifyUnit.Text = objdr.GetString("Unit_Name")
                txtQuantSame.Text = objdr.GetDouble("Trim(Raw_Quantity) + 0")
                cmbUnitSame.Text = objdr.GetString("Unit_Name")
                DateTimePicker1.Format = DateTimePickerFormat.Custom
                DateTimePicker1.CustomFormat = objdr.GetString("expireraw")
            End While
        End If
        objconn.Close()
        For Each id As Integer In CheckedListBox1.CheckedIndices
            CheckedListBox1.SetItemChecked(id, False)
        Next
    End Sub
    Private Sub chklistboxModify_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chklistboxModify.SelectedIndexChanged
        If chklistboxModify.CheckedItems.Count - 1 Then
            txtQuantitys.Enabled = False
            cmbModifyUnit.Enabled = False
            btnSaveModify.Enabled = False
            btnDeleteRawMat.Enabled = False
            DateTimePicker1.Enabled = False
            txtQuantitys.Text = ""
            cmbModifyUnit.Text = ""
            DateTimePicker1.CustomFormat = " "  'An empty SPACE
            DateTimePicker1.Format = DateTimePickerFormat.Custom
        End If
    End Sub


    Private Sub btnAddRawMat_Click(sender As Object, e As EventArgs)
        If txtQuant.Text = "" Then
            MessageBox.Show("Please Enter Quantity  of a Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuant.BackColor = Color.PapayaWhip
            txtQuant.Focus()
        Else
            restxtQuant = CInt(txtQuant.Text)
            resDatePick = Format(DateTimePicker3.Value, "MM/dd/yyyy")
            Dim hunga As MsgBoxResult
            hunga = MsgBox("Your Adding '" & restxtQuant & " " & CStr(putUnit.Text) & "' to " & CStr(txtRawNamed.Text) & ", Do You Want To Add ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If hunga = MsgBoxResult.Yes Then
                objconn = New MySqlConnection
                objconn.ConnectionString = "server=localhost;username=root; password=; database=red_cheese_pizza_database"
                Try
                    objconn.Open()
                    Updatess = "Insert into raw_expiration_date (Exp_Date_ID,Raw_Quantity,Unit_ID,Raw_Expiration_Date,Raw_ID) values" & _
                                                                 "(NULL, " & restxtQuant & ",(SELECT Unit_ID FROM unit_table where unit_name = '" & CStr(putUnit.Text) & "')," & _
                                                                  "'" & resDatePick & "', (SELECT Raw_ID from raw_material_table where raw_name = '" & CStr(txtRawNamed.Text) & "' )) "
                    objcmd = New MySqlCommand(Updatess, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()
                    FillRawMats()
                    txtQuant.Text = ""
                    putUnit.Text = ""
                    MessageBox.Show("Record has been Added, To An Existing Raw Material.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            ElseIf hunga = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdSubmitModifyy_Click(sender As Object, e As EventArgs) Handles cmdSubmitModifyy.Click

        If txtQuant.Text = "" Then
            MessageBox.Show("Please Enter Quantity  of a Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuant.BackColor = Color.PapayaWhip
            txtQuant.Focus()

        ElseIf putUnit.Text = "" Then
            MessageBox.Show("Select unit of a Raw Material you want to add.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            putUnit.BackColor = Color.PapayaWhip
            putUnit.Focus()
        ElseIf DateTimePicker3.CustomFormat = " " Then
            MessageBox.Show("Select Expiration Date of a Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker3.BackColor = Color.PapayaWhip
            DateTimePicker3.Focus()
        ElseIf Format(DateTimePicker3.Value, "yyyy-MM-dd") < DateTime.Now Then
            MessageBox.Show("Expired Raw Material were Detected, Make sure that an expiration of our raw materials were greater than Todays Date.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker3.BackColor = Color.PapayaWhip
            DateTimePicker3.Focus()
        Else
            two = CInt(txtQuant.Text)
            ulit = CStr(two)
            hayop = CDec(txtQuant.Text)
            ulitulit = CStr(hayop)
            Dim hehe As String = CStr(txtQuant.Text).ToString()
            'Grms.
            If hayop > 999 Then '0.01
                MessageBox.Show("Sorry, you can input 1 up to 999 number/s or point only or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.9 And CStr(putUnit.Text) = "mG/s" Then '0.01
                MessageBox.Show("Our system cannot accept below '1mG'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.99 And CStr(putUnit.Text) = "mG/s" Then '0.01
                MessageBox.Show("Our system cannot accept below '1mG'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.999 And CStr(putUnit.Text) = "mG/s" Then '0.001
                MessageBox.Show("Our system cannot accept below '1mG'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "0" & two Or hehe = "0.0" Or hehe = ".0" Or hehe = "0." Or hehe = "0" Or hehe = "0.00" Or hehe = "0.000" Or hehe = "000.0" Or hehe = "00.00" Or hehe = "00000" Or hehe = "0000" Or hehe = "000" Or hehe = "0.0000" Or hehe = "0000." Or hehe = "000." Or hehe = "00." And CStr(putUnit.Text) = "gram/s" Then '0.01
                MessageBox.Show("Sorry, our system cannot accept thats kind of Quantity. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "." And CStr(putUnit.Text) = "gram/s" Then '0.01
                MessageBox.Show("Sorry, Your input is not Valid. You can enter number/s or single dot(.) only. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "0" & two Or hehe = "0.0" Or hehe = ".0" Or hehe = "0." Or hehe = "0" Or hehe = "0.00" Or hehe = "0.000" Or hehe = "000.0" Or hehe = "00.00" Or hehe = "00000" Or hehe = "0000" Or hehe = "000" Or hehe = "0.0000" Or hehe = "0000." Or hehe = "000." Or hehe = "00." And CStr(putUnit.Text) = "kG/s" Then '0.01
                MessageBox.Show("Sorry, our system cannot accept thats kind of Quantity. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "." And CStr(putUnit.Text) = "kG/s" Then '0.01
                MessageBox.Show("Sorry, Your input is not Valid. You can enter number/s or single dot(.) only. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.9 And CStr(putUnit.Text) = "mL/s" Then '0.01
                MessageBox.Show("Our system cannot accept below '1mL'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.99 And CStr(putUnit.Text) = "mL/s" Then '0.01
                MessageBox.Show("Our system cannot accept below '1mL'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hayop <= 0.999 And CStr(putUnit.Text) = "mL/s" Then '0.001
                MessageBox.Show("Our system cannot accept below '1mL'. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "0" & two Or hehe = "0.0" Or hehe = ".0" Or hehe = "0." Or hehe = "0" Or hehe = "0.00" Or hehe = "0.000" Or hehe = "000.0" Or hehe = "00.00" Or hehe = "00000" Or hehe = "0000" Or hehe = "000" Or hehe = "0.0000" Or hehe = "0000." Or hehe = "000." Or hehe = "00." And CStr(putUnit.Text) = "liter/s" Then '0.01
                MessageBox.Show("Sorry, our system cannot accept thats kind of Quantity. You can enter up to 1-999 or choose another units. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf hehe = "." And CStr(putUnit.Text) = "liter/s" Then '0.01
                MessageBox.Show("Sorry, Your input is not Valid. You can enter number/s or single dot(.) only. Thank You", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                If two <= 9 And CStr(putUnit.Text) = "mG/s" Then
                    zerofirst = "0.00" & two
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "gram/s"
                ElseIf two <= 99 And CStr(putUnit.Text) = "mG/s" Then
                    zerofirst = "0.0" & two
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "gram/s"
                ElseIf two <= 999 And CStr(putUnit.Text) = "mG/s" Then
                    zerofirst = "0." & two
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "gram/s"
                    'kG/s
                ElseIf hayop <= 0.9 And CStr(putUnit.Text) = "gram/s" Then '0.01
                    zerofirst = hayop & "00"
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "kG/s"
                ElseIf hayop <= 0.99 And CStr(putUnit.Text) = "gram/s" Then '0.01
                    zerofirst = hayop & "0"
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "kG/s"
                ElseIf hayop <= 0.999 And CStr(putUnit.Text) = "gram/s" Then '0.001
                    zerofirst = hayop & ""
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "kG/s"
                ElseIf two <= 9 And CStr(putUnit.Text) = "gram/s" Then
                    zerofirst = "0.00" & two
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "kG/s"
                ElseIf two <= 99 And CStr(putUnit.Text) = "gram/s" Then
                    zerofirst = "0.0" & two
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "kG/s"
                ElseIf two <= 999 And CStr(putUnit.Text) = "gram/s" Then
                    zerofirst = "0." & two
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "kG/s"
                    'kG
                ElseIf hayop <= 0.9 And CStr(putUnit.Text) = "kG/s" Then '0.01
                    zerofirst = hayop & "00"
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "gram/s"
                ElseIf hayop <= 0.99 And CStr(putUnit.Text) = "kG/s" Then '0.01
                    zerofirst = hayop & "0"
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "gram/s"
                ElseIf hayop <= 0.999 And CStr(putUnit.Text) = "kG/s" Then '0.001
                    zerofirst = hayop & ""
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "gram/s"
                ElseIf two <= 999 And CStr(putUnit.Text) = "kG/s" Then
                    zerofirst = two & ".000"
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "kG/s"
                    'mL
                ElseIf two <= 9 And CStr(putUnit.Text) = "mL/s" Then
                    zerofirst = "0.00" & two
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "liter/s"
                ElseIf two <= 99 And CStr(putUnit.Text) = "mL/s" Then
                    zerofirst = "0.0" & two
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "liter/s"
                ElseIf two <= 999 And CStr(putUnit.Text) = "mL/s" Then
                    zerofirst = "0." & two
                    TextBox2.Text = zerofirst
                    txtputRaw.Text = "liter/s"
                    'gallon
                ElseIf hayop < 3.785 And CStr(putUnit.Text) = "liter/s" Then
                    times = hayop
                    TextBox2.Text = times
                    txtputRaw.Text = "liter/s"
                ElseIf hayop >= 3.785 And CStr(putUnit.Text) = "liter/s" Then
                    times = hayop / 3.785
                    TextBox2.Text = times
                    txtputRaw.Text = "gallon/s"
                ElseIf hayop < 12 And CStr(putUnit.Text) = "piece/s" Then
                    times = hayop
                    TextBox2.Text = times
                    txtputRaw.Text = "piece/s"
                ElseIf hayop >= 12 And CStr(putUnit.Text) = "piece/s" Then
                    times = hayop / 12
                    TextBox2.Text = times
                    txtputRaw.Text = "dozen/s"
                ElseIf CStr(putUnit.Text) = "gallon/s" Then
                    times = hayop
                    TextBox2.Text = times
                    txtputRaw.Text = "gallon/s"
                ElseIf CStr(putUnit.Text) = "dozen/s" Then
                    times = hayop
                    TextBox2.Text = times
                    txtputRaw.Text = "dozen/s"
                    'ElseIf hayop  <= 0.99 And CStr(cmbUNIT.Text) = "mG/s" Then
                    '    Dim modified As String = CStr(ulitulit.Insert(2, "0"))
                    '    TextBox2.Text = modified
                    '    TextBox3.Text = cmbUNIT.Text
                    '    
                End If
                restxtQuant = CDbl(txtQuant.Text)
                resDatePick = Format(DateTimePicker3.Value, "yyyy-MM-dd")
                ' Dim resDatePicker As String = Format(DateTimePicker2.Value, "")
                TextBox1.Text = Format(DateTimePicker3.Value, "MM/dd/yyyy")
                objconn = New MySqlConnection
                objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                Try
                    objconn.Open()
                    objcmd.Connection = objconn
                    objcmd.CommandType = CommandType.Text
                    objcmd.CommandText = "SELECT * FROM `raw_expiration_date` where  DATE_FORMAT(raw_expiration_date.Raw_Expiration_Date,'%m/%d/%Y') = '" & TextBox1.Text & "'"
                    objdr = objcmd.ExecuteReader
                    If objdr.HasRows Then
                        question = MsgBox("Your Adding '" & restxtQuant & " " & CStr(putUnit.Text) & "' to " & CStr(txtRawNamed.Text) & ", Do You Want To Add ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If question = MsgBoxResult.Yes Then

                            objconn = New MySqlConnection
                            objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                            objconn.Open()
                            ModifyQuerys = "UPDATE raw_expiration_date set raw_expiration_date.Raw_Quantity = raw_expiration_date.Raw_Quantity + " & restxtQuant & " where DATE_FORMAT(raw_expiration_date.Raw_Expiration_Date,'%m/%d/%Y') = '" & TextBox1.Text & "'"
                            objcmd = New MySqlCommand(ModifyQuerys, objconn)
                            objdr = objcmd.ExecuteReader
                            objconn.Close()

                            objconn = New MySqlConnection
                            objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                            objconn.Open()
                            With objcmd
                                .Connection = objconn
                                .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " were add " & restxtQuant & " " & CStr(putUnit.Text) & " at " & CStr(txtRawNamed.Text) & " on ' ,CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "')) "
                                .ExecuteNonQuery()
                            End With
                            objconn.Close()

                            chklistboxModify.Items.Clear()

                            FillRawMats()
                            loadchkRaws()
                            txtQuant.Text = ""
                            putUnit.Text = ""
                            DateTimePicker3.CustomFormat = " "  'An empty SPACE
                            DateTimePicker3.Format = DateTimePickerFormat.Custom

                            'putUnit.Text = ""
                            'DateTimePicker3.CustomFormat = " "  'An empty SPACE
                            'DateTimePicker3.Format = DateTimePickerFormat.Custom
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
                            MessageBox.Show("Record has been Added, To An Existing Raw Material.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'objconn.Close()        
                        ElseIf question = MsgBoxResult.No Then
                            Exit Sub
                        End If
                    Else
                        Dim hunga As MsgBoxResult
                        hunga = MsgBox("Your Adding '" & restxtQuant & " " & CStr(putUnit.Text) & "' to " & CStr(txtRawNamed.Text) & ", Do You Want To Add ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
                        If hunga = MsgBoxResult.Yes Then
                            objconn = New MySqlConnection
                            objconn.ConnectionString = "server=localhost;username=root; password=; database=red_cheese_pizza_database"
                            Try
                                objconn.Open()
                                Updatess = "Insert into raw_expiration_date (Exp_Date_ID,Raw_Quantity,Unit_ID,Raw_Expiration_Date,Raw_ID) values" & _
                                                                             "(NULL, '" & CStr(TextBox2.Text) & "',(SELECT Unit_ID FROM unit_table where unit_name = '" & CStr(txtputRaw.Text) & "')," & _
                                                                              "'" & resDatePick & "', (SELECT Raw_ID from raw_material_table where raw_name = '" & CStr(txtRawNamed.Text) & "' )) "
                                objcmd = New MySqlCommand(Updatess, objconn)
                                objdr = objcmd.ExecuteReader
                                objconn.Close()

                                objconn = New MySqlConnection
                                objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                                objconn.Open()
                                With objcmd
                                    .Connection = objconn
                                    .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " were add " & restxtQuant & " " & CStr(putUnit.Text) & " of " & CStr(txtRawNamed.Text) & " on ' ,CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "')) "
                                    .ExecuteNonQuery()
                                End With
                                objconn.Close()
                                chklistboxModify.Items.Clear()
                                FillRawMats()
                                loadchkRaws()
                                txtQuant.Text = ""
                                putUnit.Text = ""
                                ' putUnit.Text = ""
                                DateTimePicker3.CustomFormat = " "  'An empty SPACE
                                DateTimePicker3.Format = DateTimePickerFormat.Custom
                                MessageBox.Show("Record has been Added, To An Existing Raw Material.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Catch ex As Exception
                                MessageBox.Show(ex.Message)
                            End Try
                        ElseIf hunga = MsgBoxResult.No Then
                            Exit Sub
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
                Finally
                    objconn.Close()
                End Try
            End If

        End If
    End Sub


    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        DateTimePicker3.CustomFormat = "MM/dd/yyyy"
        DateTimePicker3.BackColor = Color.White
        DateTimePicker3.MinDate = DateTime.Now
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        DateTimePicker1.BackColor = Color.White
        DateTimePicker1.MinDate = DateTime.Now
    End Sub

    Private Sub btnSaveModify_Click(sender As Object, e As EventArgs) Handles btnSaveModify.Click



        resQuantt = CDbl(txtQuantitys.Text)
        resDatePick = Format(DateTimePicker3.Value, "yyyy-MM-dd")
        resDate = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        TextBox1.Text = Format(DateTimePicker3.Value, "MM/dd/yyyy")
        cmbunitt = CStr(cmbModifyUnit.Text)

        If txtQuantitys.Text = "" Then
            MessageBox.Show("Please Enter Quantity  of a Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuantitys.BackColor = Color.PapayaWhip
            txtQuantitys.Focus()
        ElseIf txtRawNamed.Text = "" Then
            MessageBox.Show("Please Enter Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtRawNamed.BackColor = Color.PapayaWhip
            txtRawNamed.Focus()
        ElseIf IsNothing(cmbModifyUnit.SelectedItem) Then
            MessageBox.Show("Select Unit  of a Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbModifyUnit.BackColor = Color.PapayaWhip
            cmbModifyUnit.Focus()
        ElseIf DateTimePicker1.CustomFormat = " " Then
            MessageBox.Show("Select Expiration Date of a Raw Material", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker1.BackColor = Color.PapayaWhip
            DateTimePicker1.Focus()
        ElseIf txtRawNamed.Text = txtputRaw.Text And txtQuantitys.Text = txtQuantSame.Text And cmbModifyUnit.Text = cmbUnitSame.Text And DateTimePicker1.Text = txtExpiration.Text Then
            MessageBox.Show("No Changes were made.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuantitys.BackColor = Color.PapayaWhip
            txtQuantitys.Focus()
        ElseIf txtRawNamed.Text <> txtputRaw.Text And txtQuantitys.Text = txtQuantSame.Text And cmbModifyUnit.Text = cmbUnitSame.Text And DateTimePicker1.Text = txtExpiration.Text Then
            txtcmbAdds()
            'raw
        ElseIf txtRawNamed.Text <> txtputRaw.Text And txtQuantitys.Text = txtQuantSame.Text And cmbModifyUnit.Text <> cmbUnitSame.Text And DateTimePicker1.Text <> txtExpiration.Text Then
            txtcmbAdds()
            'raw cmb date
        ElseIf txtRawNamed.Text <> txtputRaw.Text And txtQuantitys.Text <> txtQuantSame.Text And cmbModifyUnit.Text = cmbUnitSame.Text And DateTimePicker1.Text = txtExpiration.Text Then
            txtcmbAdds()
            'raw quant
        ElseIf txtRawNamed.Text = txtputRaw.Text And txtQuantitys.Text = txtQuantSame.Text And cmbModifyUnit.Text <> cmbUnitSame.Text And DateTimePicker1.Text <> txtExpiration.Text Then
            txtcmbAdds()
            'cmb date
        ElseIf txtRawNamed.Text = txtputRaw.Text And txtQuantitys.Text <> txtQuantSame.Text And cmbModifyUnit.Text = cmbUnitSame.Text And DateTimePicker1.Text = txtExpiration.Text Then
            txtcmbAdds()
            'quant 
        ElseIf txtRawNamed.Text = txtputRaw.Text And txtQuantitys.Text <> txtQuantSame.Text And cmbModifyUnit.Text = cmbUnitSame.Text And DateTimePicker1.Text <> txtExpiration.Text Then
            txtcmbAdds()
            'quant date    
        ElseIf txtRawNamed.Text = txtputRaw.Text And txtQuantitys.Text = txtQuantSame.Text And cmbModifyUnit.Text <> cmbUnitSame.Text And DateTimePicker1.Text = txtExpiration.Text Then
            txtcmbAdds()
            'cmb
        ElseIf txtRawNamed.Text = txtputRaw.Text And txtQuantitys.Text = txtQuantSame.Text And cmbModifyUnit.Text = cmbUnitSame.Text And DateTimePicker1.Text <> txtExpiration.Text Then
            txtcmbAdds()
            'date
        ElseIf txtRawNamed.Text = txtputRaw.Text And txtQuantitys.Text <> txtQuantSame.Text And cmbModifyUnit.Text <> cmbUnitSame.Text And DateTimePicker1.Text <> txtExpiration.Text Then
            txtcmbAdds()
            'cmb quant date
        ElseIf txtRawNamed.Text <> txtputRaw.Text And txtQuantitys.Text = txtQuantSame.Text And cmbModifyUnit.Text = cmbUnitSame.Text And DateTimePicker1.Text <> txtExpiration.Text Then
            txtcmbAdds()
            'raw date
        ElseIf txtRawNamed.Text <> txtputRaw.Text And cmbModifyUnit.Text <> cmbUnitSame.Text And txtQuantitys.Text <> txtQuantSame.Text And DateTimePicker1.Text <> txtExpiration.Text Then
            txtcmbAdds()
            'all
        End If
    End Sub

    Private Sub putUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles putUnit.SelectedIndexChanged
        putUnit.BackColor = Color.White
        If putUnit.Text = "mG/s" Then
            Label7.Text = "1000 mG/s = 1 gram"
        ElseIf putUnit.Text = "gram/s" Then
            Label7.Text = "1000 grams = 1 kG"
        ElseIf putUnit.Text = "kG/s" Then
            Label7.Text = "1000 grams = 1 kG"
        ElseIf putUnit.Text = "mL/s" Then
            Label7.Text = "1000 mL/s = 1 Liter"
        ElseIf putUnit.Text = "liter/s" Then
            Label7.Text = "3.785 liters = 1 gallon"
        ElseIf putUnit.Text = "gallon/s" Then
            Label7.Text = "3.785 liters = 1 gallon"
        ElseIf putUnit.Text = "piece/s" Then
            Label7.Text = "12 piece/s = 1 dozen"
        ElseIf putUnit.Text = "dozen/s" Then
            Label7.Text = "12 piece/s = 1 dozen"
        Else
            Label7.Text = ""
        End If
    End Sub

    Private Sub putUnit_TextChanged(sender As Object, e As EventArgs) Handles putUnit.TextChanged
        If putUnit.Text = "" Then
            Label7.Text = ""
        End If
    End Sub

    Private Sub txtQuant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuant.KeyPress
        Dim allowedChars As String = "0987654321."
        If (txtQuant.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedChars.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If

    End Sub

    Private Sub txtQuant_TextChanged(sender As Object, e As EventArgs) Handles txtQuant.TextChanged
        txtQuant.BackColor = Color.White
        If Val(txtQuant.Text) > 999 Then
            Label8.Text = "Input 1-999 numbers only"
        ElseIf Val(txtQuant.Text) < 999 Then
            Label8.Text = ""
        End If
    End Sub

    Private Sub btnDeleteRawMat_Click(sender As Object, e As EventArgs) Handles btnDeleteRawMat.Click
        objconn = New MySqlConnection
        objconn.ConnectionString = "server=localhost;username=root; password=; database=red_cheese_pizza_database"

        question = MsgBox("Are you sure  you want to remove " & txtQuantSame.Text & " " & cmbUnitSame.Text & " of " & txtRawNamed.Text & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
            Try
                objconn.Open()
                DeleteQuery = "Delete  from raw_expiration_date where   DATE_FORMAT(raw_expiration_date.Raw_Expiration_Date,'%m/%d/%Y') = '" & txtExpiration.Text & "'"
                objcmd = New MySqlCommand(DeleteQuery, objconn)
                objdr = objcmd.ExecuteReader
                objconn.Close()

                objconn = New MySqlConnection
                objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                objconn.Open()
                With objcmd
                    .Connection = objconn
                    .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " remove " & txtQuantSame.Text & " " & cmbUnitSame.Text & " of " & txtRawNamed.Text & " on ',CURRENT_TIMESTAMP, " _
                                & " (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "'))"
                    .ExecuteNonQuery()
                End With
                objconn.Close()
            Catch ex As Exception
                MsgBox(Err.Description)
            End Try
            chklistboxModify.Items.Clear()
            CheckedListBox1.Items.Clear()
            txtQuantitys.Text = ""
            cmbModifyUnit.Text = ""
            DateTimePicker1.CustomFormat = " "
            txtQuantitys.Enabled = False
            cmbModifyUnit.Enabled = False
            DateTimePicker1.Enabled = False
            btnDeleteRawMat.Enabled = False
            btnSaveModify.Enabled = False
            loadchkRaws()
            FillRawMats()
            MsgBox(txtQuantSame.Text & " " & cmbUnitSame.Text & " of " & txtRawNamed.Text & " were Successfully Removed !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "REMOVE")
        ElseIf question = MsgBoxResult.No Then
            Me.Show()
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckedListBox1.Items.Clear()
        DateTimePicker1.CustomFormat = " "
        txtQuantitys.Text = ""
        cmbModifyUnit.Text = ""
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        Me.Dispose()
        ' Modall.Show()
        Modall.Enabled = True
    End Sub

    Private Sub txtQuantitys_TextChanged(sender As Object, e As EventArgs) Handles txtQuantitys.TextChanged
        txtQuantitys.BackColor = Color.White
    End Sub

    Private Sub cmbModifyUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModifyUnit.SelectedIndexChanged
        cmbModifyUnit.BackColor = Color.White
    End Sub

End Class