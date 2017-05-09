Imports MySql.Data.MySqlClient
Public Class Add_Prod
    Public ProdN As String = ""
    Public Produv As String
    Public query123 As String
    Public feelin As String
    Public feeling As String
    Public FillingList As Boolean

    Private Sub txtProd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtProd.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbSubmit1.Focus()
        End If
    End Sub
    Private Sub txtProd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProd.TextChanged
        txtProd.BackColor = Color.White
    End Sub
    
    Private Sub cmbSubmit1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubmit1.Click

        If txtConSolo.Text <> "" And cmbUnitSolo.Text = "" Then
            MessageBox.Show("Select consumed unit at Solo size.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitSolo.BackColor = Color.PapayaWhip
            cmbUnitSolo.Focus()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConSolo.BackColor = Color.PapayaWhip
            txtConSolo.Focus()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            Onlysolo()
        ElseIf txtConReg.Text <> "" And cmbUnitReg.Text = "" Then
            MessageBox.Show("Select consumed unit at Regular size", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitReg.BackColor = Color.PapayaWhip
            cmbUnitReg.Focus()
            txtConReg.BackColor = Color.White
        ElseIf txtConReg.Text = "" And cmbUnitReg.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConReg.BackColor = Color.PapayaWhip
            txtConReg.Focus()
            cmbUnitReg.BackColor = Color.White
        ElseIf txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
              And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
              And txtConFam.Text = "" And cmbUnitFam.Text = "" _
              And txtConThin.Text = "" And cmbUnitThin.Text = "" _
              And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            OnlyRegular()
        ElseIf txtConFam.Text <> "" And cmbUnitFam.Text = "" Then
            MessageBox.Show("Select consumed unit at Family size", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitFam.BackColor = Color.PapayaWhip
            cmbUnitFam.Focus()
            txtConFam.BackColor = Color.White
        ElseIf txtConFam.Text = "" And cmbUnitFam.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConFam.BackColor = Color.PapayaWhip
            txtConFam.Focus()
            cmbUnitFam.BackColor = Color.White
        ElseIf txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            OnlyFam()
        ElseIf txtConThin.Text <> "" And cmbUnitThin.Text = "" Then
            MessageBox.Show("Select consumed unit at SuperThin size", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitThin.BackColor = Color.PapayaWhip
            cmbUnitThin.Focus()
            txtConThin.BackColor = Color.White
        ElseIf txtConThin.Text = "" And cmbUnitThin.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConThin.BackColor = Color.PapayaWhip
            txtConThin.Focus()
            cmbUnitThin.BackColor = Color.White
        ElseIf txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            OnlyThin()
        ElseIf txtConDeep.Text <> "" And cmbUnitDeep.Text = "" Then
            MessageBox.Show("Select consumed unit at Chicago Deep Dish size", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitDeep.BackColor = Color.PapayaWhip
            cmbUnitDeep.Focus()
            txtConDeep.BackColor = Color.White
        ElseIf txtConDeep.Text = "" And cmbUnitDeep.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConDeep.BackColor = Color.PapayaWhip
            txtConDeep.Focus()
            cmbUnitDeep.BackColor = Color.White
        ElseIf txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" Then
            OnlyDeep()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            SoloReg()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            SoloFam()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            SoloThin()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            SoloDeep()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            RegFam()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            RegThin()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            RegDeep()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            FamThin()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            FamDeep()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            SoloRegFam()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            SoloRegThin()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            SoloRegDeep()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then

            RegFamThin()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            SolThinDeep()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            RegThinDeep()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            FamThinDeep()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            SolRegThinDeep()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            SolRegFamDeep()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            SolFamThinDeep()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            RegFamThinDeep()
        ElseIf txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then

            SoloRegFamThinDeep()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            MessageBox.Show("Please Input at least 1.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitSolo.BackColor = Color.PapayaWhip
            txtConSolo.BackColor = Color.PapayaWhip
            cmbUnitReg.BackColor = Color.PapayaWhip
            txtConReg.BackColor = Color.PapayaWhip
            cmbUnitFam.BackColor = Color.PapayaWhip
            txtConFam.BackColor = Color.PapayaWhip
            cmbUnitThin.BackColor = Color.PapayaWhip
            txtConThin.BackColor = Color.PapayaWhip
            cmbUnitDeep.BackColor = Color.PapayaWhip
            txtConDeep.BackColor = Color.PapayaWhip
        End If
    End Sub
    Private Sub cmdCancelMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelMaintenance.Click
        Me.Close()
        'Modall.Show()
        Modall.Enabled = True
    End Sub
    Private Sub Add_Prod_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        Modall.Show()
    End Sub
    Private Sub Add_Prod_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        'Modall.Show()
    End Sub
    Public Sub cmbLoadProduct()


        Dim OleDBC As New MySqlCommand
        Dim OleDBDR As MySqlDataReader
        With OleDBC
            .Connection = objconn
            .CommandText = "select * from product_table ORDER by Product_Name ASC"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        Do While OleDBDR.Read
            If OleDBDR.HasRows Then
                feelin = OleDBDR.GetString("Product_Name")
                CheckedListBox2.Items.Add(feelin)

            End If
        Loop
        objconn.Close()

        With OleDBC
            .Connection = objconn
            .CommandText = "SELECT product_table.product_name from product_table INNER join category on product_table.Cat_ID = category.Cat_ID where category.Cat_ID = 8  or category.Cat_ID = 9"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        Do While OleDBDR.Read
            If OleDBDR.HasRows Then
                feeling = OleDBDR.GetString("product_name").ToString
                If feeling.Equals(feeling) Then
                    CheckedListBox2.Items.Remove(feeling)
                End If
            End If
        Loop
        objconn.Close()
    End Sub
    Public Sub cmbLoadProdu()
        FillingList = True

        Dim OleDBC As New MySqlCommand
        Dim OleDBDR As MySqlDataReader
        With OleDBC
            .Connection = objconn
            .CommandText = "select * from raw_material_table ORDER by Raw_Name ASC"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        Do While OleDBDR.Read
            If OleDBDR.HasRows Then
                feelin = OleDBDR.GetString("Raw_Name")
                CheckedListBox1.Items.Add(feelin)

            End If
        Loop
        objconn.Close()
        With OleDBC
            .Connection = objconn
            .CommandText = "SELECT  DISTINCT raw_material_table.raw_name as 'raw' " _
                            & " FROM material_every_product RIGHT join raw_material_table on raw_material_table.Raw_ID = material_every_product.Raw_ID " _
                            & " RIGHT join unit_table on unit_table.Unit_ID = material_every_product.Unit_ID WHERE material_every_product.raw_ID " _
                            & " IN(SELECT raw_material_table.raw_id FROM raw_material_table WHERE material_every_product.Product_ID = (SELECT Product_ID from product_table where product_name = '" & CStr(txtProd.Text) & "' ) " _
                            & ") ORDER BY Raw_Name ASC"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        Do While OleDBDR.Read
            If OleDBDR.HasRows Then
                Dim checkvalue As String = feelin
                Dim checkstates As Boolean = feelin = checkvalue
                feeling = OleDBDR.GetString("raw").ToString
                CheckedListBox1.Items.Add(feeling, checkstates)
                If feeling.Equals(feeling) Then
                    CheckedListBox1.Items.Remove(feeling)
                End If
            End If
        Loop
        objconn.Close()
        CheckedListBox1.Sorted = True

        'Rest of method here.

        FillingList = False
    End Sub
    Public Sub fillCombo123()
        Try
            objconn.Open()
            query123 = "select * from unit_table"
            objcmd = New MySqlCommand(query123, objconn)
            objdr = objcmd.ExecuteReader
            While objdr.Read
                Dim rawname = objdr.GetString("Unit_name")
                cmbUnitSolo.Items.Add(rawname)
                cmbUnitReg.Items.Add(rawname)
                cmbUnitFam.Items.Add(rawname)
            End While
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub conditioncattxtfilling()
        If txcatIDs.Text = "1" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("piece/s")

            lblcon1.Text = "per piece :"
            lblcon2.Text = ""
            lblcon3.Text = ""
            lblcon4.Text = ""
            lblcon5.Text = ""

            txtconNone.Show()
            cmbunitNone.Show()
            txtconGlass.Hide()
            cmbunitGlass.Hide()
            txtConSolo.Hide()
            cmbUnitSolo.Hide()
            txtConReg.Hide()
            cmbUnitReg.Hide()
            txtConFam.Hide()
            cmbUnitFam.Hide()
            txtConThin.Hide()
            cmbUnitThin.Hide()
            txtConDeep.Hide()
            cmbUnitDeep.Hide()


            cmbSubmit1.Hide()
            btnUpdate.Hide()

            btnAddNone.Show()
            btnUpdateNone.Show()

            btnAddGlass.Hide()
            btnUpdateGlass.Hide()

        ElseIf txcatIDs.Text = "2" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("piece/s")

            lblcon1.Text = "per piece :"
            lblcon2.Text = ""
            lblcon3.Text = ""
            lblcon4.Text = ""
            lblcon5.Text = ""


            txtconNone.Show()
            cmbunitNone.Show()
            txtconGlass.Hide()
            cmbunitGlass.Hide()
            txtConSolo.Hide()
            cmbUnitSolo.Hide()
            txtConReg.Hide()
            cmbUnitReg.Hide()
            txtConFam.Hide()
            cmbUnitFam.Hide()
            txtConThin.Hide()
            cmbUnitThin.Hide()
            txtConDeep.Hide()
            cmbUnitDeep.Hide()

            cmbSubmit1.Hide()
            btnUpdate.Hide()

            btnAddNone.Show()
            btnUpdateNone.Show()

            btnAddGlass.Hide()
            btnUpdateGlass.Hide()
        ElseIf txcatIDs.Text = "3" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("piece/s")

            lblcon1.Text = "per piece :"
            lblcon2.Text = ""
            lblcon3.Text = ""
            lblcon4.Text = ""
            lblcon5.Text = ""


            txtconNone.Show()
            cmbunitNone.Show()
            txtconGlass.Hide()
            cmbunitGlass.Hide()
            txtConSolo.Hide()
            cmbUnitSolo.Hide()
            txtConReg.Hide()
            cmbUnitReg.Hide()
            txtConFam.Hide()
            cmbUnitFam.Hide()
            txtConThin.Hide()
            cmbUnitThin.Hide()
            txtConDeep.Hide()
            cmbUnitDeep.Hide()

            cmbSubmit1.Hide()
            btnUpdate.Hide()

            btnAddNone.Show()
            btnUpdateNone.Show()

            btnAddGlass.Hide()
            btnUpdateGlass.Hide()

        ElseIf txcatIDs.Text = "4" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("Solo")
            ComboBox1.Items.Add("Superthin")
            ComboBox1.Items.Add("Regular")
            ComboBox1.Items.Add("Family")
            ComboBox1.Items.Add("Chicago Deep Dish")

            lblcon1.Text = "Solo :"
            lblcon2.Text = "Regular :"
            lblcon3.Text = "Family :"
            lblcon4.Text = "Superthin :"
            lblcon5.Text = "Chicago Deep Dish :"


            txtconNone.Hide()
            cmbunitNone.Hide()
            txtconGlass.Hide()
            cmbunitGlass.Hide()
            txtConSolo.Show()
            cmbUnitSolo.Show()
            txtConReg.Show()
            cmbUnitReg.Show()
            txtConFam.Show()
            cmbUnitFam.Show()
            txtConThin.Show()
            cmbUnitThin.Show()
            txtConDeep.Show()
            cmbUnitDeep.Show()

            cmbSubmit1.Show()
            btnUpdate.Show()

            btnAddNone.Hide()
            btnUpdateNone.Hide()

            btnAddGlass.Hide()
            btnUpdateGlass.Hide()
        ElseIf txcatIDs.Text = "5" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("piece/s")

            lblcon1.Text = "per piece :"
            lblcon2.Text = ""
            lblcon3.Text = ""
            lblcon4.Text = ""
            lblcon5.Text = ""


            txtconNone.Show()
            cmbunitNone.Show()
            txtconGlass.Hide()
            cmbunitGlass.Hide()
            txtConSolo.Hide()
            cmbUnitSolo.Hide()
            txtConReg.Hide()
            cmbUnitReg.Hide()
            txtConFam.Hide()
            cmbUnitFam.Hide()
            txtConThin.Hide()
            cmbUnitThin.Hide()
            txtConDeep.Hide()
            cmbUnitDeep.Hide()

            cmbSubmit1.Hide()
            btnUpdate.Hide()

            btnAddNone.Show()
            btnUpdateNone.Show()

            btnAddGlass.Hide()
            btnUpdateGlass.Hide()

        ElseIf txcatIDs.Text = "6" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("Solo")

            lblcon1.Text = "Solo :"
            lblcon2.Text = ""
            lblcon3.Text = ""
            lblcon4.Text = ""
            lblcon5.Text = ""


            txtconNone.Hide()
            cmbunitNone.Hide()
            txtconGlass.Hide()
            cmbunitGlass.Hide()
            txtConSolo.Show()
            cmbUnitSolo.Show()
            txtConReg.Hide()
            cmbUnitReg.Hide()
            txtConFam.Hide()
            cmbUnitFam.Hide()
            txtConThin.Hide()
            cmbUnitThin.Hide()
            txtConDeep.Hide()
            cmbUnitDeep.Hide()

            cmbSubmit1.Show()
            btnUpdate.Show()

            btnAddNone.Hide()
            btnUpdateNone.Hide()

            btnAddGlass.Hide()
            btnUpdateGlass.Hide()
        ElseIf txcatIDs.Text = "7" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("Solo")
            ComboBox1.Items.Add("Superthin")
            ComboBox1.Items.Add("Regular")
            ComboBox1.Items.Add("Family")
            ComboBox1.Items.Add("Chicago Deep Dish")

            lblcon1.Text = "Solo :"
            lblcon2.Text = "Regular :"
            lblcon3.Text = "Family :"
            lblcon4.Text = "Superthin :"
            lblcon5.Text = "Chicago Deep Dish :"

            txtconNone.Hide()
            cmbunitNone.Hide()
            txtconGlass.Hide()
            cmbunitGlass.Hide()
            txtConSolo.Show()
            cmbUnitSolo.Show()
            txtConReg.Show()
            cmbUnitReg.Show()
            txtConFam.Show()
            cmbUnitFam.Show()
            txtConThin.Show()
            cmbUnitThin.Show()
            txtConDeep.Show()
            cmbUnitDeep.Show()

            cmbSubmit1.Show()
            btnUpdate.Show()

            btnAddNone.Hide()
            btnUpdateNone.Hide()

            btnAddGlass.Hide()
            btnUpdateGlass.Hide()
        ElseIf txcatIDs.Text = "8" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("piece/s")

            lblcon1.Text = "per piece :"
            lblcon2.Text = ""
            lblcon3.Text = ""
            lblcon4.Text = ""
            lblcon5.Text = ""
            txtconNone.Show()
            cmbunitNone.Show()
            txtconGlass.Hide()
            cmbunitGlass.Hide()
            txtConSolo.Hide()
            cmbUnitSolo.Hide()
            txtConReg.Hide()
            cmbUnitReg.Hide()
            txtConFam.Hide()
            cmbUnitFam.Hide()
            txtConThin.Hide()
            cmbUnitThin.Hide()
            txtConDeep.Hide()
            cmbUnitDeep.Hide()

            cmbSubmit1.Hide()
            btnUpdate.Hide()

            btnAddNone.Show()
            btnUpdateNone.Show()

            btnAddGlass.Hide()
            btnUpdateGlass.Hide()
        ElseIf txcatIDs.Text = "9" Then

        ElseIf txcatIDs.Text = "10" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("piece/s")

            lblcon1.Text = "per piece :"
            lblcon2.Text = ""
            lblcon3.Text = ""
            lblcon4.Text = ""
            lblcon5.Text = ""
            txtconNone.Show()
            cmbunitNone.Show()
            txtconGlass.Hide()
            cmbunitGlass.Hide()
            txtConSolo.Hide()
            cmbUnitSolo.Hide()
            txtConReg.Hide()
            cmbUnitReg.Hide()
            txtConFam.Hide()
            cmbUnitFam.Hide()
            txtConThin.Hide()
            cmbUnitThin.Hide()
            txtConDeep.Hide()
            cmbUnitDeep.Hide()

            cmbSubmit1.Hide()
            btnUpdate.Hide()

            btnAddNone.Show()
            btnUpdateNone.Show()

            btnAddGlass.Hide()
            btnUpdateGlass.Hide()
        ElseIf txcatIDs.Text = "11" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("Glass/es")

            lblcon1.Text = "per Glass :"
            lblcon2.Text = ""
            lblcon3.Text = ""
            lblcon4.Text = ""
            lblcon5.Text = ""

            txtconNone.Hide()
            cmbunitNone.Hide()
            txtconGlass.Show()
            cmbunitGlass.Show()
            txtConSolo.Hide()
            cmbUnitSolo.Hide()
            txtConReg.Hide()
            cmbUnitReg.Hide()
            txtConFam.Hide()
            cmbUnitFam.Hide()
            txtConThin.Hide()
            cmbUnitThin.Hide()
            txtConDeep.Hide()
            cmbUnitDeep.Hide()

            cmbSubmit1.Hide()
            btnUpdate.Hide()

            btnAddNone.Hide()
            btnUpdateNone.Hide()

            btnAddGlass.Show()
            btnUpdateGlass.Show()
        ElseIf txcatIDs.Text = "12" Then
            ComboBox1.Items.Clear()
            ComboBox1.Text = ""
            ComboBox1.Items.Add("1.5 Liters")
            ComboBox1.Items.Add("8 oz.")
            ComboBox1.Items.Add("12 oz.")
            ComboBox1.Items.Add("Can")
            ComboBox1.Items.Add("Cup")
            ComboBox1.Items.Add("Glass")
            ComboBox1.Items.Add("Pitcher")
            ComboBox1.Items.Add("Small")
            ComboBox1.Items.Add("Medium")
            ComboBox1.Items.Add("Large")

            lblcon1.Text = "blank"
            lblcon2.Text = ""
            lblcon3.Text = ""
            lblcon4.Text = ""
            lblcon5.Text = ""
        End If
    End Sub
    Private Sub Add_Prod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        'CheckedListBox2.Visible = False
        'CheckedListBox1.Visible = False
        If txcatIDs.Text = "8" Or txcatIDs.Text = "9" Then
            CheckedListBox1.Visible = False
            grpnote.Visible = False
            grpprodukto.Show()
            CheckedListBox2.Visible = True
            btnAddcon.Enabled = False
            btnUpdatecon.Enabled = False
            btnUpdatecon.Show()
            cmbSubmit1.Hide()
            btnUpdate.Hide()

            btnAddNone.Hide()
            btnUpdateNone.Hide()

            btnAddGlass.Hide()
            btnUpdateGlass.Hide()
            txtConThin.Hide()
        Else
            conditioncattxtfilling()
            grpnote.Visible = True
            grpprodukto.Hide()
            CheckedListBox2.Visible = False
            btnAddcon.Hide()
            btnUpdatecon.Hide()
            CheckedListBox1.Visible = True
            cmbSubmit1.Enabled = False
            btnUpdate.Enabled = False

            btnAddNone.Enabled = False
            btnUpdateNone.Enabled = False

            btnAddGlass.Enabled = False
            btnUpdateGlass.Enabled = False
        End If
        cmbLoadProdu()
        cmbLoadProduct()
        '  fillCombo123()
        disabletxt()
        'grpnotedisableme()
        txtProd.SelectionStart = 0


        txtconproddisable()
        Label5.Text = CheckedListBox1.CheckedItems.Count()
        'txtSolos.Text = "Solo"
        'txtRegulars.Text = "Regular"
        'txtFamilys.Text = "Family"

    End Sub
    Private Sub CheckedListBox1_ItemCheck(sender As Object, ew As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        Dim yack As Boolean = True
        If FillingList = True Then
            Return
        End If
        If ew.NewValue = CheckState.Unchecked Then
            question = MsgBox("Area you sure you want to remove " & CStr(TextBox1.Text) & " to its Product, consider with its consumed at every product ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Red Cheese Pizza Message")
            If question = MsgBoxResult.Yes Then
             
                Try
                    objconn.Open()
                    DeleteQuery = "Delete  from material_every_product where raw_id IN( select raw_id from raw_material_table where raw_name  = '" & CStr(TextBox1.Text) & "')"
                    objcmd = New MySqlCommand(DeleteQuery, objconn)
                    objdr = objcmd.ExecuteReader
                    objconn.Close()
                    ew.NewValue = CheckState.Unchecked
                    fillProdukto()
                    clearfield()
                    MsgBox("Successfully Deleted !", MsgBoxStyle.Information + MessageBoxButtons.OK, "SUCCESS")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            ElseIf question = MsgBoxResult.No Then
                ew.NewValue = CheckState.Checked
            End If
        ElseIf ew.NewValue = CheckState.Checked Then
            CheckedListBox1.Items(ew.Index).ToString()
            question = MsgBox("Area you sure you want to add '" & CStr(TextBox1.Text) & "' to '" & CStr(txtProd.Text) & "', If Yes kindly type those required field and press Add Button ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Red Cheese Pizza Message")
            If question = MsgBoxResult.Yes Then
                conditioncmbUnit()
                ew.NewValue = CheckState.Checked
                cmbSubmit1.Enabled = True
                btnAddNone.Enabled = True
                btnAddGlass.Enabled = True
                Label6.Text = Label5.Text + 1
                txtConSolo.Enabled = True
                txtConReg.Enabled = True
                txtConFam.Enabled = True
                cmbUnitSolo.Enabled = True
                cmbUnitReg.Enabled = True
                cmbUnitFam.Enabled = True
                txtConThin.Enabled = True
                cmbUnitThin.Enabled = True
                txtConDeep.Enabled = True
                cmbUnitDeep.Enabled = True
                txtconNone.Enabled = True
                cmbunitNone.Enabled = True
                txtconGlass.Enabled = True
                cmbunitGlass.Enabled = True

                txtConSolo.Focus()
                txtconNone.Focus()

                txtConSolo.BackColor = Color.White
                txtConReg.BackColor = Color.White
                txtConFam.BackColor = Color.White
                cmbUnitSolo.BackColor = Color.White
                cmbUnitReg.BackColor = Color.White
                cmbUnitFam.BackColor = Color.White
                txtConThin.BackColor = Color.White
                txtConDeep.BackColor = Color.White
                cmbUnitThin.BackColor = Color.White
                cmbUnitDeep.BackColor = Color.White
                txtconNone.BackColor = Color.White
                cmbunitNone.BackColor = Color.White
                txtconGlass.BackColor = Color.White
                cmbunitGlass.BackColor = Color.White
            ElseIf question = MsgBoxResult.No Then
                ew.NewValue = CheckState.Unchecked
                txtConSolo.BackColor = Color.White
                txtConReg.BackColor = Color.White
                txtConFam.BackColor = Color.White
                cmbUnitSolo.BackColor = Color.White
                cmbUnitReg.BackColor = Color.White
                cmbUnitFam.BackColor = Color.White
                txtConThin.BackColor = Color.White
                txtConDeep.BackColor = Color.White
                cmbUnitThin.BackColor = Color.White
                cmbUnitDeep.BackColor = Color.White
                txtconNone.BackColor = Color.White
                cmbunitNone.BackColor = Color.White
                txtconGlass.BackColor = Color.White
                cmbunitGlass.BackColor = Color.White
                'grpnotedisableme()
                Exit Sub
            End If
        End If
    End Sub
    Public Sub conditioncmbUnit()

        cmbunitNone.Items.Clear()
        cmbunitGlass.Items.Clear()
        cmbUnitSolo.Items.Clear()
        cmbUnitReg.Items.Clear()
        cmbUnitFam.Items.Clear()
        cmbUnitDeep.Items.Clear()
        cmbUnitThin.Items.Clear()

        objconn.Open()
        objdt = New DataTable
        With objcmd
            .Connection = objconn
            .CommandText = "SELECT DISTINCT unit_table.Unit_Name FROM unit_table inner join raw_expiration_date on raw_expiration_date.unit_ID =unit_table.Unit_ID inner join raw_material_table on raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where raw_material_table.Raw_Name = '" & TextBox1.Text & "'"
        End With
        objda.SelectCommand = objcmd
        objda.Fill(objdt)
        objdr = objcmd.ExecuteReader
        If objdr.HasRows Then

            While objdr.Read

                If (objdr.GetString("Unit_Name") = "mG/s" Or objdr.GetString("Unit_Name") = "gram/s" Or objdr.GetString("Unit_Name") = "kG/s") Then

                    cmbunitNone.Items.Clear()
                    cmbunitGlass.Items.Clear()
                    cmbUnitSolo.Items.Clear()
                    cmbUnitReg.Items.Clear()
                    cmbUnitFam.Items.Clear()
                    cmbUnitDeep.Items.Clear()
                    cmbUnitThin.Items.Clear()

                    cmbunitNone.Items.Add("mG/s")
                    cmbunitNone.Items.Add("gram/s")
                    cmbunitGlass.Items.Add("mG/s")
                    cmbunitGlass.Items.Add("gram/s")
                    cmbUnitSolo.Items.Add("mG/s")
                    cmbUnitSolo.Items.Add("gram/s")
                    cmbUnitReg.Items.Add("mG/s")
                    cmbUnitReg.Items.Add("gram/s")
                    cmbUnitFam.Items.Add("mG/s")
                    cmbUnitFam.Items.Add("gram/s")
                    cmbUnitDeep.Items.Add("mG/s")
                    cmbUnitDeep.Items.Add("gram/s")
                    cmbUnitThin.Items.Add("mG/s")
                    cmbUnitThin.Items.Add("gram/s")
                ElseIf (objdr.GetString("Unit_Name") = "piece/s" Or objdr.GetString("Unit_Name") = "dozen/s") Then
                    cmbunitNone.Items.Clear()
                    cmbunitGlass.Items.Clear()
                    cmbUnitSolo.Items.Clear()
                    cmbUnitReg.Items.Clear()
                    cmbUnitFam.Items.Clear()
                    cmbUnitDeep.Items.Clear()
                    cmbUnitThin.Items.Clear()
                    cmbunitNone.Items.Add("piece/s")
                    cmbunitGlass.Items.Add("piece/s")
                    cmbUnitSolo.Items.Add("piece/s")
                    cmbUnitReg.Items.Add("piece/s")
                    cmbUnitFam.Items.Add("piece/s")
                    cmbUnitDeep.Items.Add("piece/s")
                    cmbUnitThin.Items.Add("piece/s")
                ElseIf (objdr.GetString("Unit_Name") = "mL/s" Or objdr.GetString("Unit_Name") = "liter/s" Or objdr.GetString("Unit_Name") = "gallon/s") Then
                    cmbunitNone.Items.Clear()
                    cmbunitGlass.Items.Clear()
                    cmbUnitSolo.Items.Clear()
                    cmbUnitReg.Items.Clear()
                    cmbUnitFam.Items.Clear()
                    cmbUnitDeep.Items.Clear()
                    cmbUnitThin.Items.Clear()
                    cmbunitNone.Items.Add("mL/s")
                    cmbunitGlass.Items.Add("mL/s")
                    cmbUnitSolo.Items.Add("mL/s")
                    cmbUnitReg.Items.Add("mL/s")
                    cmbUnitFam.Items.Add("mL/s")
                    cmbUnitDeep.Items.Add("mL/s")
                    cmbUnitThin.Items.Add("mL/s")
                End If
            End While

        End If
        objconn.Close()

    End Sub
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        'AddHandler CheckedListBox1.SelectedIndexChanged, AddressOf CheckedListBox1_ItemCheck

        TextBox1.Text = CheckedListBox1.SelectedItem

        txtConSolo.Text = ""
        txtConReg.Text = ""
        txtConFam.Text = ""
        txtConThin.Text = ""
        txtConDeep.Text = ""
        txtconNone.Text = ""
        txtconGlass.Text = ""
        cmbUnitSolo.Text = ""
        cmbUnitReg.Text = ""
        cmbUnitFam.Text = ""
        cmbUnitThin.Text = ""
        cmbUnitDeep.Text = ""
        cmbunitNone.Text = ""
        cmbunitGlass.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        txtconNones.Text = ""
        cmbconNones.Text = ""
        cmbconGlasses.Text = ""
        Dim OleDBC As New MySqlCommand
        Dim OleDBDR As MySqlDataReader
        With OleDBC
            .Connection = objconn
            .CommandText = "SELECT product_table.Product_Name,raw_material_table.Raw_Name,Size_Name,`material_every_product`.`Minus_Material_Every_Product`, " _
                    & "Unit_Name from material_every_product INNER join product_size on material_every_product.Size_ID = product_size.Size_ID " _
                    & "inner join unit_table on unit_table.Unit_ID = material_every_product.Unit_ID  " _
                    & "INNER join product_table on material_every_product.Product_ID = product_table.Product_ID " _
                    & "inner join raw_material_table on material_every_product.Raw_ID = raw_material_table.Raw_ID " _
                    & "where product_table.Product_Name = '" & CStr(txtProd.Text) & "' AND raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "' AND product_size.Size_Name = 'Solo'"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                txtConSolo.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                cmbUnitSolo.Text = OleDBDR.GetString("Unit_Name")
                TextBox2.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                TextBox3.Text = OleDBDR.GetString("Unit_Name")
            End While
        End If
        objconn.Close()
        With OleDBC
            .Connection = objconn
            .CommandText = "SELECT product_table.Product_Name,raw_material_table.Raw_Name,Size_Name,`material_every_product`.`Minus_Material_Every_Product`, " _
                    & "Unit_Name from material_every_product INNER join product_size on material_every_product.Size_ID = product_size.Size_ID " _
                    & "inner join unit_table on unit_table.Unit_ID = material_every_product.Unit_ID  " _
                    & "INNER join product_table on material_every_product.Product_ID = product_table.Product_ID " _
                    & "inner join raw_material_table on material_every_product.Raw_ID = raw_material_table.Raw_ID " _
                    & "where product_table.Product_Name = '" & CStr(txtProd.Text) & "' AND raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "' AND product_size.Size_Name = 'Regular'"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                txtConReg.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                cmbUnitReg.Text = OleDBDR.GetString("Unit_Name")
                TextBox4.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                TextBox5.Text = OleDBDR.GetString("Unit_Name")
            End While
        End If
        objconn.Close()

        With OleDBC
            .Connection = objconn
            .CommandText = "SELECT product_table.Product_Name,raw_material_table.Raw_Name,Size_Name,`material_every_product`.`Minus_Material_Every_Product`, " _
                    & "Unit_Name from material_every_product INNER join product_size on material_every_product.Size_ID = product_size.Size_ID " _
                    & "inner join unit_table on unit_table.Unit_ID = material_every_product.Unit_ID  " _
                    & "INNER join product_table on material_every_product.Product_ID = product_table.Product_ID " _
                    & "inner join raw_material_table on material_every_product.Raw_ID = raw_material_table.Raw_ID " _
                    & "where product_table.Product_Name = '" & CStr(txtProd.Text) & "' AND raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "' AND product_size.Size_Name = 'Family'"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                txtConFam.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                cmbUnitFam.Text = OleDBDR.GetString("Unit_Name")
                TextBox6.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                TextBox7.Text = OleDBDR.GetString("Unit_Name")
            End While
        End If
        objconn.Close()

        With OleDBC
            .Connection = objconn
            .CommandText = "SELECT product_table.Product_Name,raw_material_table.Raw_Name,Size_Name,`material_every_product`.`Minus_Material_Every_Product`, " _
                    & "Unit_Name from material_every_product INNER join product_size on material_every_product.Size_ID = product_size.Size_ID " _
                    & "inner join unit_table on unit_table.Unit_ID = material_every_product.Unit_ID  " _
                    & "INNER join product_table on material_every_product.Product_ID = product_table.Product_ID " _
                    & "inner join raw_material_table on material_every_product.Raw_ID = raw_material_table.Raw_ID " _
                    & "where product_table.Product_Name = '" & CStr(txtProd.Text) & "' AND raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "' AND product_size.Size_Name = 'Superthin'"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                txtConThin.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                cmbUnitThin.Text = OleDBDR.GetString("Unit_Name")
                TextBox9.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                TextBox10.Text = OleDBDR.GetString("Unit_Name")
            End While
        End If
        objconn.Close()

        With OleDBC
            .Connection = objconn
            .CommandText = "SELECT product_table.Product_Name,raw_material_table.Raw_Name,Size_Name,`material_every_product`.`Minus_Material_Every_Product`, " _
                    & "Unit_Name from material_every_product INNER join product_size on material_every_product.Size_ID = product_size.Size_ID " _
                    & "inner join unit_table on unit_table.Unit_ID = material_every_product.Unit_ID  " _
                    & "INNER join product_table on material_every_product.Product_ID = product_table.Product_ID " _
                    & "inner join raw_material_table on material_every_product.Raw_ID = raw_material_table.Raw_ID " _
                    & "where product_table.Product_Name = '" & CStr(txtProd.Text) & "' AND raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "' AND product_size.Size_Name = 'Chicago Deep Dish'"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                txtConDeep.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                cmbUnitDeep.Text = OleDBDR.GetString("Unit_Name")
                TextBox11.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                TextBox12.Text = OleDBDR.GetString("Unit_Name")
            End While
        End If
        objconn.Close()
        With OleDBC
            .Connection = objconn
            .CommandText = "SELECT product_table.Product_Name,raw_material_table.Raw_Name,Size_Name,`material_every_product`.`Minus_Material_Every_Product`, " _
                    & "Unit_Name from material_every_product INNER join product_size on material_every_product.Size_ID = product_size.Size_ID " _
                    & "inner join unit_table on unit_table.Unit_ID = material_every_product.Unit_ID  " _
                    & "INNER join product_table on material_every_product.Product_ID = product_table.Product_ID " _
                    & "inner join raw_material_table on material_every_product.Raw_ID = raw_material_table.Raw_ID " _
                    & "where product_table.Product_Name = '" & CStr(txtProd.Text) & "' AND raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "' AND product_size.Size_Name = 'None'"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                txtconNone.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                cmbunitNone.Text = OleDBDR.GetString("Unit_Name")
                txtconNones.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                cmbconNones.Text = OleDBDR.GetString("Unit_Name")
            End While
        End If
        objconn.Close()

        With OleDBC
            .Connection = objconn
            .CommandText = "SELECT product_table.Product_Name,raw_material_table.Raw_Name,Size_Name,`material_every_product`.`Minus_Material_Every_Product`, " _
                    & "Unit_Name from material_every_product INNER join product_size on material_every_product.Size_ID = product_size.Size_ID " _
                    & "inner join unit_table on unit_table.Unit_ID = material_every_product.Unit_ID  " _
                    & "INNER join product_table on material_every_product.Product_ID = product_table.Product_ID " _
                    & "inner join raw_material_table on material_every_product.Raw_ID = raw_material_table.Raw_ID " _
                    & "where product_table.Product_Name = '" & CStr(txtProd.Text) & "' AND raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "' AND product_size.Size_Name = 'Glass'"
        End With
        objconn.Open()
        OleDBDR = OleDBC.ExecuteReader
        If OleDBDR.HasRows Then
            While OleDBDR.Read
                txtconGlass.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                cmbunitGlass.Text = OleDBDR.GetString("Unit_Name")
                txtconGlasses.Text = OleDBDR.GetInt32("Minus_Material_Every_Product")
                cmbconGlasses.Text = OleDBDR.GetString("Unit_Name")
            End While
        End If
        objconn.Close()

        If TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'solo
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'reg
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'fam
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'thin
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            'deep
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtconGlass.Text <> "" And cmbunitGlass.Text <> "" Then
            'glass
            txtconGlass.Enabled = True
            cmbunitGlass.Enabled = True
            btnUpdateGlass.Enabled = True
        ElseIf TextBox1.Text <> "" And txtconNone.Text <> "" And cmbunitNone.Text <> "" Then
            'none
            txtconNone.Enabled = True
            cmbunitNone.Enabled = True
            btnUpdateNone.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And txtConReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'solo and reg
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'solo and fam
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'solo and thin
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            'solo and deep
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'reg and fam
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'reg and thin
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            'reg and deep
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And cmbUnitReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'fam and thin
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And cmbUnitReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            'fam and deep
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'solo reg fam
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            'solo reg thin
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            'solo reg deep
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            ' reg fam thin
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            ' sol thin deep
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            ' reg thin deep
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And cmbUnitReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            ' fam thin deep
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            ' sol reg thin deep
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            ' sol reg fam deep
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            ' sol  fam thin deep
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            'reg  fam thin deep
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text <> "" And cmbUnitSolo.Text <> "" _
            And cmbUnitReg.Text <> "" And cmbUnitReg.Text <> "" _
            And txtConFam.Text <> "" And cmbUnitFam.Text <> "" _
            And txtConThin.Text <> "" And cmbUnitThin.Text <> "" _
            And txtConDeep.Text <> "" And cmbUnitDeep.Text <> "" Then
            'sol reg  fam thin deep
            txtConSolo.Enabled = True
            cmbUnitSolo.Enabled = True
            txtConReg.Enabled = True
            cmbUnitReg.Enabled = True
            txtConFam.Enabled = True
            cmbUnitFam.Enabled = True
            txtConThin.Enabled = True
            cmbUnitThin.Enabled = True
            txtConDeep.Enabled = True
            cmbUnitDeep.Enabled = True
            btnUpdate.Enabled = True
        ElseIf TextBox1.Text <> "" And txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And cmbUnitReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" _
            And txtconGlass.Text = "" And cmbunitGlass.Text = "" _
            And txtconNone.Text = "" And cmbunitNone.Text = "" Then
            'sol reg and fam thin deep
            txtConSolo.Enabled = False
            cmbUnitSolo.Enabled = False
            txtConReg.Enabled = False
            cmbUnitReg.Enabled = False
            txtConFam.Enabled = False
            cmbUnitFam.Enabled = False
            txtConThin.Enabled = False
            cmbUnitThin.Enabled = False
            txtConDeep.Enabled = False
            cmbUnitDeep.Enabled = False
            txtconGlass.Enabled = False
            cmbunitGlass.Enabled = False
            txtconNone.Enabled = False
            cmbunitNone.Enabled = False
            btnUpdate.Enabled = False
            btnUpdateGlass.Enabled = False
            btnUpdateNone.Enabled = False
        End If


        'If Label6.Text > Label5.Text Then
        '    MsgBox("Please enter consume of a raw material at every product before you leave.", MsgBoxStyle.Information + MessageBoxButtons.OK, "Red Cheese Pizza Message")
        'End If
    End Sub

    
    Private Sub cmbUnitSolo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbUnitSolo.SelectedValueChanged
        'If cmbUnitSolo.Text > "" And txtConSolo.Text > "" Then
        '    cmbSubmit1.Enabled = True
        'End If
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtConSolo.Text <> "" And cmbUnitSolo.Text = "" Then
            MessageBox.Show("Select consumed unit at Solo size", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitSolo.BackColor = Color.PapayaWhip
            cmbUnitSolo.Focus()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConSolo.BackColor = Color.PapayaWhip
            txtConSolo.Focus()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
            And TextBox4.Text = "" And TextBox5.Text = "" _
            And TextBox6.Text = "" And TextBox7.Text = "" _
            And TextBox9.Text = "" And TextBox10.Text = "" _
            And TextBox11.Text = "" And TextBox12.Text = "" Then
            solo()
        ElseIf txtConReg.Text <> "" And cmbUnitReg.Text = "" Then
            MessageBox.Show("Select consumed unit at Regular size", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitReg.BackColor = Color.PapayaWhip
            cmbUnitReg.Focus()
            txtConReg.BackColor = Color.White
        ElseIf txtConReg.Text = "" And cmbUnitReg.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConReg.BackColor = Color.PapayaWhip
            txtConReg.Focus()
            cmbUnitReg.BackColor = Color.White
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
            And TextBox4.Text <> "" And TextBox5.Text <> "" _
            And TextBox6.Text = "" And TextBox7.Text = "" _
            And TextBox9.Text = "" And TextBox10.Text = "" _
            And TextBox11.Text = "" And TextBox12.Text = "" Then
            reg()
        ElseIf txtConFam.Text <> "" And cmbUnitFam.Text = "" Then
            MessageBox.Show("Select consumed unit at Family size", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitFam.BackColor = Color.PapayaWhip
            cmbUnitFam.Focus()
            txtConFam.BackColor = Color.White
        ElseIf txtConFam.Text = "" And cmbUnitFam.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConFam.BackColor = Color.PapayaWhip
            txtConFam.Focus()
            cmbUnitFam.BackColor = Color.White
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
            And TextBox4.Text = "" And TextBox5.Text = "" _
            And TextBox6.Text <> "" And TextBox7.Text <> "" _
            And TextBox9.Text = "" And TextBox10.Text = "" _
            And TextBox11.Text = "" And TextBox12.Text = "" Then
            fam()
        ElseIf txtConThin.Text <> "" And cmbUnitThin.Text = "" Then
            MessageBox.Show("Select consumed unit at Superthin size", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitThin.BackColor = Color.PapayaWhip
            cmbUnitThin.Focus()
            txtConThin.BackColor = Color.White
        ElseIf txtConThin.Text = "" And cmbUnitThin.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConThin.BackColor = Color.PapayaWhip
            txtConThin.Focus()
            cmbUnitThin.BackColor = Color.White
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
            And TextBox4.Text = "" And TextBox5.Text = "" _
            And TextBox6.Text = "" And TextBox7.Text = "" _
            And TextBox9.Text <> "" And TextBox10.Text <> "" _
            And TextBox11.Text = "" And TextBox12.Text = "" Then
            thin()
        ElseIf txtConDeep.Text <> "" And cmbUnitDeep.Text = "" Then
            MessageBox.Show("Select consumed unit at Chicago Deep Dish size", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitDeep.BackColor = Color.PapayaWhip
            cmbUnitDeep.Focus()
            txtConDeep.BackColor = Color.White
        ElseIf txtConDeep.Text = "" And cmbUnitDeep.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConDeep.BackColor = Color.PapayaWhip
            txtConDeep.Focus()
            cmbUnitDeep.BackColor = Color.White
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
            And TextBox4.Text = "" And TextBox5.Text = "" _
            And TextBox6.Text = "" And TextBox7.Text = "" _
            And TextBox9.Text = "" And TextBox10.Text = "" _
            And TextBox11.Text <> "" And TextBox12.Text <> "" Then
            deep()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
              And TextBox4.Text <> "" And TextBox5.Text <> "" _
              And TextBox6.Text = "" And TextBox7.Text = "" _
              And TextBox9.Text = "" And TextBox10.Text = "" _
              And TextBox11.Text = "" And TextBox12.Text = "" Then

            solreg()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
                  And TextBox4.Text = "" And TextBox5.Text = "" _
                  And TextBox6.Text <> "" And TextBox7.Text <> "" _
                  And TextBox9.Text = "" And TextBox10.Text = "" _
                  And TextBox11.Text = "" And TextBox12.Text = "" Then

            solfam()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
                      And TextBox4.Text = "" And TextBox5.Text = "" _
                      And TextBox6.Text = "" And TextBox7.Text = "" _
                      And TextBox9.Text <> "" And TextBox10.Text <> "" _
                      And TextBox11.Text = "" And TextBox12.Text = "" Then

            solthin()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
                             And TextBox4.Text = "" And TextBox5.Text = "" _
                             And TextBox6.Text = "" And TextBox7.Text = "" _
                             And TextBox9.Text = "" And TextBox10.Text = "" _
                             And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            soldeep()
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
                 And TextBox4.Text <> "" And TextBox5.Text <> "" _
                 And TextBox6.Text <> "" And TextBox7.Text <> "" _
                 And TextBox9.Text = "" And TextBox10.Text = "" _
                 And TextBox11.Text = "" And TextBox12.Text = "" Then

            regfami()
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
                      And TextBox4.Text <> "" And TextBox5.Text <> "" _
                      And TextBox6.Text = "" And TextBox7.Text = "" _
                      And TextBox9.Text <> "" And TextBox10.Text <> "" _
                      And TextBox11.Text = "" And TextBox12.Text = "" Then

            regthini()
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
                         And TextBox4.Text <> "" And TextBox5.Text <> "" _
                         And TextBox6.Text = "" And TextBox7.Text = "" _
                         And TextBox9.Text = "" And TextBox10.Text = "" _
                         And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            regdeepi()
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
                             And TextBox4.Text = "" And TextBox5.Text = "" _
                             And TextBox6.Text <> "" And TextBox7.Text <> "" _
                             And TextBox9.Text <> "" And TextBox10.Text <> "" _
                             And TextBox11.Text = "" And TextBox12.Text = "" Then

            famthini()
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
                                   And TextBox4.Text = "" And TextBox5.Text = "" _
                                   And TextBox6.Text <> "" And TextBox7.Text <> "" _
                                   And TextBox9.Text = "" And TextBox10.Text = "" _
                                   And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            famdeepi()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
            And TextBox4.Text <> "" And TextBox5.Text <> "" _
            And TextBox6.Text <> "" And TextBox7.Text <> "" _
            And TextBox9.Text = "" And TextBox10.Text = "" _
            And TextBox11.Text = "" And TextBox12.Text = "" Then

            solregfam()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
                  And TextBox4.Text <> "" And TextBox5.Text <> "" _
                  And TextBox6.Text = "" And TextBox7.Text = "" _
                  And TextBox9.Text <> "" And TextBox10.Text <> "" _
                  And TextBox11.Text = "" And TextBox12.Text = "" Then

            solregthin()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
                      And TextBox4.Text <> "" And TextBox5.Text <> "" _
                      And TextBox6.Text = "" And TextBox7.Text = "" _
                      And TextBox9.Text = "" And TextBox10.Text = "" _
                      And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            solregdeep()
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
                         And TextBox4.Text <> "" And TextBox5.Text <> "" _
                         And TextBox6.Text <> "" And TextBox7.Text <> "" _
                         And TextBox9.Text = "" And TextBox10.Text = "" _
                         And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            regfamthini()

        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
             And TextBox4.Text = "" And TextBox5.Text = "" _
             And TextBox6.Text = "" And TextBox7.Text = "" _
             And TextBox9.Text <> "" And TextBox10.Text <> "" _
             And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            solthindeepi()
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
               And TextBox4.Text <> "" And TextBox5.Text <> "" _
               And TextBox6.Text = "" And TextBox7.Text = "" _
               And TextBox9.Text <> "" And TextBox10.Text <> "" _
               And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            regthindeepi()
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
                  And TextBox4.Text = "" And TextBox5.Text = "" _
                  And TextBox6.Text <> "" And TextBox7.Text <> "" _
                  And TextBox9.Text <> "" And TextBox10.Text <> "" _
                  And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            famthindeepi()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
                         And TextBox4.Text <> "" And TextBox5.Text <> "" _
                         And TextBox6.Text = "" And TextBox7.Text = "" _
                         And TextBox9.Text <> "" And TextBox10.Text <> "" _
                         And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            solregthindeepi()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
                              And TextBox4.Text <> "" And TextBox5.Text <> "" _
                              And TextBox6.Text <> "" And TextBox7.Text <> "" _
                              And TextBox9.Text = "" And TextBox10.Text = "" _
                              And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            solregfamdeepi()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
                                   And TextBox4.Text = "" And TextBox5.Text = "" _
                                   And TextBox6.Text <> "" And TextBox7.Text <> "" _
                                   And TextBox9.Text <> "" And TextBox10.Text <> "" _
                                   And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            solfamthindeepi()
        ElseIf TextBox2.Text = "" And TextBox3.Text = "" _
                                         And TextBox4.Text <> "" And TextBox5.Text <> "" _
                                         And TextBox6.Text <> "" And TextBox7.Text <> "" _
                                         And TextBox9.Text <> "" And TextBox10.Text <> "" _
                                         And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            regfamthindeepi()
        ElseIf TextBox2.Text <> "" And TextBox3.Text <> "" _
                                                 And TextBox4.Text <> "" And TextBox5.Text <> "" _
                                                 And TextBox6.Text <> "" And TextBox7.Text <> "" _
                                                 And TextBox9.Text <> "" And TextBox10.Text <> "" _
                                                 And TextBox11.Text <> "" And TextBox12.Text <> "" Then

            solregfamthindeepi()
        ElseIf txtConSolo.Text = "" And cmbUnitSolo.Text = "" _
            And txtConReg.Text = "" And cmbUnitReg.Text = "" _
            And txtConFam.Text = "" And cmbUnitFam.Text = "" _
            And txtConThin.Text = "" And cmbUnitThin.Text = "" _
            And txtConDeep.Text = "" And cmbUnitDeep.Text = "" Then
            MessageBox.Show("Please Input at least 1 Item", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitSolo.BackColor = Color.PapayaWhip
            txtConSolo.BackColor = Color.PapayaWhip
            cmbUnitReg.BackColor = Color.PapayaWhip
            txtConReg.BackColor = Color.PapayaWhip
            cmbUnitFam.BackColor = Color.PapayaWhip
            txtConFam.BackColor = Color.PapayaWhip
            cmbUnitThin.BackColor = Color.PapayaWhip
            txtConThin.BackColor = Color.PapayaWhip
            cmbUnitDeep.BackColor = Color.PapayaWhip
            txtConDeep.BackColor = Color.PapayaWhip
        ElseIf txtProd.Text <> "" = TextBox8.Text <> "" Then
            MessageBox.Show("No Changes were made", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Public Sub solo()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then

            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "')"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            objconn.Close()

            Exit Sub
        End If
    End Sub
    Public Sub glass()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
       
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtconGlass.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbunitGlass.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Glass') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "')"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            objconn.Close()

            Exit Sub
        End If
    End Sub
    Public Sub None()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtconNone.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbunitNone.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'None') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "')"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            objconn.Close()

            Exit Sub
        End If
    End Sub
    Public Sub reg()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "')"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub fam()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
 
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitFam.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "')"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub thin()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
 
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "')"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub deep()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then

            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "')"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solregfam()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
  
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitFam.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solregthin()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then

            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solregdeep()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
    
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub regfamthini()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then

            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitFam.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solthindeepi()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
 
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub regthindeepi()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then

            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub famthindeepi()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then

            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitFam.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solregthindeepi()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
   
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solregfamdeepi()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitFam.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solfamthindeepi()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitFam.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub regfamthindeepi()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitFam.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                   & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solregfamthindeepi()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                            & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                            & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitFam.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                            & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solreg()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub

    Public Sub regfami()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitFam.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub regthini()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub regdeepi()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConReg.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitReg.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Regular') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub famthini()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub famdeepi()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solfam()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then


            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConFam.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitFam.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Family') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub solthin()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConThin.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitThin.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Superthin') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub soldeep()
        question = MsgBox("Are you sure you want to update?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
            Try
                objconn.Open()
                ModifyQuerys = "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConSolo.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitSolo.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Solo') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');" _
                              & "UPDATE  `material_every_product` set Minus_Material_Every_Product = " & CInt(txtConDeep.Text) & ",Unit_ID = (SELECT Unit_ID FROM unit_table WHERE unit_table.Unit_Name = '" & CStr(cmbUnitDeep.Text) & "') where Size_ID = (Select Size_ID from product_size WHERE product_size.Size_Name = 'Chicago Deep Dish') AND Raw_ID IN(Select Raw_ID from raw_material_table where raw_material_table.Raw_Name = '" & CStr(TextBox1.Text) & "');"
                objcmd = New MySqlCommand(ModifyQuerys, objconn)
                objdr = objcmd.ExecuteReader
                '    Records.ListBox1.Items.Add(" " & UserLog & " modify the raw material which is  " & TextBox1.Text & " - " & TextBox2.Text & " " & TextBox3.Text & " - " & TextBox4.Text & "' " & Environment.NewLine & "to '" & txtQuant.Text & " " & cmbselectUnit.Text & "-" & DateTimePicker2.Text & " on - " & Format(DateTime.Now) & " " & Environment.NewLine)
                objconn.Close()
                fillProdukto()
                MsgBox("Record Updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "SUCCESS")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Size = New System.Drawing.Size(New System.Drawing.Point(230, 230))
    End Sub
    Private Sub txtConSolo_TextChanged(sender As Object, e As EventArgs) Handles txtConSolo.TextChanged
        lblcon1.ForeColor = Color.Black
        txtConSolo.BackColor = Color.White
        If Val(txtConSolo.Text) > 999 Then
            MsgBox("You can input 1-999 numbers only.", MsgBoxStyle.Information + MessageBoxButtons.OK, "Red Cheese Pizza Message")
        ElseIf Val(txtConSolo.Text) < 999 Then
            Label1.Text = ""
        End If
    End Sub
    Private Sub txtConReg_TextChanged(sender As Object, e As EventArgs) Handles txtConReg.TextChanged
        lblcon2.ForeColor = Color.Black
        txtConReg.BackColor = Color.White
        If Val(txtConReg.Text) > 999 Then
            MsgBox("You can input 1-999 numbers only.", MsgBoxStyle.Information + MessageBoxButtons.OK, "Red Cheese Pizza Message")
        ElseIf Val(txtConReg.Text) < 999 Then
        End If
    End Sub
    Private Sub txtConFam_TextChanged(sender As Object, e As EventArgs) Handles txtConFam.TextChanged
        lblcon3.ForeColor = Color.Black
        txtConFam.BackColor = Color.White
        If Val(txtConFam.Text) > 999 Then
            MsgBox("You can input 1-999 numbers only.", MsgBoxStyle.Information + MessageBoxButtons.OK, "Red Cheese Pizza Message")
        ElseIf Val(txtConFam.Text) < 999 Then
        End If
    End Sub
    Private Sub txtConThin_TextChanged(sender As Object, e As EventArgs) Handles txtConThin.TextChanged
        lblcon4.ForeColor = Color.Black
        txtConThin.BackColor = Color.White
        If Val(txtConThin.Text) > 999 Then
            MsgBox("You can input 1-999 numbers only.", MsgBoxStyle.Information + MessageBoxButtons.OK, "Red Cheese Pizza Message")
        ElseIf Val(txtConThin.Text) < 999 Then
        End If
    End Sub
    Private Sub txtConDeep_TextChanged(sender As Object, e As EventArgs) Handles txtConDeep.TextChanged
        lblcon5.ForeColor = Color.Black
        txtConDeep.BackColor = Color.White
        If Val(txtConDeep.Text) > 999 Then
            MsgBox("You can input 1-999 numbers only.", MsgBoxStyle.Information + MessageBoxButtons.OK, "Red Cheese Pizza Message")
        ElseIf Val(txtConDeep.Text) < 999 Then
        End If
    End Sub
    Private Sub cmbUnitReg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnitReg.SelectedIndexChanged
        cmbUnitReg.BackColor = Color.White
    End Sub
    Private Sub cmbUnitSolo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnitSolo.SelectedIndexChanged
        cmbUnitSolo.BackColor = Color.White
    End Sub
    Private Sub cmbUnitFam_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnitFam.SelectedIndexChanged
        cmbUnitFam.BackColor = Color.White
    End Sub
    Private Sub cmbUnitThin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnitThin.SelectedIndexChanged
        cmbUnitThin.BackColor = Color.White
    End Sub
    Private Sub cmbUnitDeep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnitDeep.SelectedIndexChanged
        cmbUnitDeep.BackColor = Color.White
    End Sub

    Private Sub cmbUnitSolo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUnitSolo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub cmbUnitReg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUnitReg.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub cmbUnitFam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUnitFam.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub cmbUnitThin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUnitThin.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub cmbUnitDeep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbUnitDeep.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtConSolo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConSolo.KeyPress
        lblcon1.ForeColor = Color.Black
        If (txtConSolo.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub

    Private Sub txtConReg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConReg.KeyPress
        lblcon2.ForeColor = Color.Black
        If (txtConSolo.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub
    Private Sub txtConFam_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConFam.KeyPress
        lblcon3.ForeColor = Color.Black
        If (txtConFam.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub
    Private Sub txtConThin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConThin.KeyPress
        lblcon4.ForeColor = Color.Black
        If (txtConThin.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub
    Private Sub txtConDeep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConDeep.KeyPress
        lblcon5.ForeColor = Color.Black
        If (txtConDeep.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub

    Private Sub btnAddGlass_Click(sender As Object, e As EventArgs) Handles btnAddGlass.Click
        If txtconGlass.Text <> "" And cmbunitGlass.Text = "" Then
            MessageBox.Show("Select unit.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbUnitSolo.BackColor = Color.PapayaWhip
            cmbUnitSolo.Focus()
        ElseIf txtconGlass.Text = "" And cmbunitGlass.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConSolo.BackColor = Color.PapayaWhip
            txtConSolo.Focus()
        ElseIf txtconGlass.Text <> "" And cmbunitGlass.Text <> "" Then
            OnlyGlass()
        End If
    End Sub
    Private Sub btnUpdateGlass_Click(sender As Object, e As EventArgs) Handles btnUpdateGlass.Click
        If txtconGlass.Text <> "" And cmbunitGlass.Text = "" Then
            MessageBox.Show("Select unit.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbunitGlass.BackColor = Color.PapayaWhip
            cmbunitGlass.Focus()
        ElseIf txtconGlass.Text = "" And cmbunitGlass.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtconGlass.BackColor = Color.PapayaWhip
            txtconGlass.Focus()
        ElseIf txtconGlasses.Text <> "" And cmbconGlasses.Text <> "" Then
            glass()
        End If
    End Sub
    Private Sub btnUpdateNone_Click(sender As Object, e As EventArgs) Handles btnUpdateNone.Click
        If txtconNone.Text <> "" And cmbunitNone.Text = "" Then
            MessageBox.Show("Select unit.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbunitNone.BackColor = Color.PapayaWhip
            cmbunitNone.Focus()
        ElseIf txtconNone.Text = "" And cmbunitNone.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtconNone.BackColor = Color.PapayaWhip
            txtconNone.Focus()
        ElseIf txtconNone.Text <> "" And cmbunitNone.Text <> "" Then
            None()
        End If
    End Sub
    Private Sub btnAddNone_Click(sender As Object, e As EventArgs) Handles btnAddNone.Click
        If txtconNone.Text <> "" And cmbunitNone.Text = "" Then
            MessageBox.Show("Select unit.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbunitNone.BackColor = Color.PapayaWhip
            cmbunitNone.Focus()
        ElseIf txtconNone.Text = "" And cmbunitNone.Text <> "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox1.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtconNone.BackColor = Color.PapayaWhip
            txtconNone.Focus()
        ElseIf txtconNone.Text <> "" And cmbunitNone.Text <> "" Then
            OnlyNone()
        End If
    End Sub
    Private Sub CheckedListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox2.SelectedIndexChanged
        TextBox13.Text = CheckedListBox2.SelectedItem
    End Sub
    Private Sub CheckedListBox2_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox2.ItemCheck
        If e.NewValue = CheckState.Checked Then
            CheckedListBox2.Items(e.Index).ToString()
            question = MsgBox("Area you sure you want to add '" & CStr(TextBox13.Text) & "' to '" & CStr(txtProd.Text) & "', If Yes kindly type those required field and press Add Button ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Red Cheese Pizza Message")
            If question = MsgBoxResult.Yes Then
                e.NewValue = CheckState.Checked
                btnAddcon.Enabled = True
                btnUpdatecon.Enabled = False
                
                txtconprod.Enabled = True
                txtconprod.BackColor = Color.White
            ElseIf question = MsgBoxResult.No Then
                e.NewValue = CheckState.Unchecked
                txtconprod.BackColor = Color.White

                Exit Sub
            End If
        End If
    End Sub


    Private Sub btnAddcon_Click(sender As Object, e As EventArgs) Handles btnAddcon.Click
        If txtconprod.Text = "" Then
            MessageBox.Show("Enter amount that we consume '" & CStr(TextBox13.Text) & "' at '" & CStr(txtProd.Text) & "' ", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtconprod.BackColor = Color.PapayaWhip
            txtconprod.Focus()
        Else

            '  perpieces()
            'dito add using product itself
        End If
    End Sub

    Private Sub txtconprod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtconprod.KeyPress
        lblcon1.ForeColor = Color.Black
        If (txtconprod.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub

    Private Sub cmbunitGlass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbunitGlass.SelectedIndexChanged

    End Sub

    Private Sub cmbunitGlass_TextChanged(sender As Object, e As EventArgs) Handles cmbunitGlass.TextChanged

    End Sub
End Class