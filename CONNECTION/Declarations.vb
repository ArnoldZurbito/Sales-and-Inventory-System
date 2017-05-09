Imports MySql.Data.MySqlClient

Module Declarations

    Public CnString As String
    Public mReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    Public ParamDVFrom As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public ParamDVTo As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public ParamCompanyName As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public ParamCompanyLoc As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public ParamCompanyContact As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public ParamCompanyTIN As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public _USER As New CrystalDecisions.Shared.ParameterDiscreteValue
    Public sqlDT As New DataTable
    Public sqlDTx As New DataTable

    Public Rpt_SqlStr As String

    Public openedFileStream As System.IO.Stream

    Public objcmd As New MySqlCommand
    Public objcmd1 As New MySqlCommand
    Public objdt As New DataTable
    Public strsql, strreportname As String
    Public objds As New DataSet
    Public objda As New MySqlDataAdapter
    Public objdr As MySqlDataReader
    Public objdr1 As MySqlDataReader

    Public backtoback As Boolean
    Public backtobacko As Boolean


    Public objbs As New BindingSource
    Public ASK As DialogResult
    Public mouse_move As System.Drawing.Point
    Public prog_name As String = "RCP: Sales and Inventory System"
    Public prog_message_caption As String = prog_name.ToString & " Message"

    Public question As MsgBoxResult
    Public DeleteQuery As String
    Public ModifyQuerys As String
    Public allowedCharacters As String = "0987654321."



    Public one As String 'raw name
    Public two As Integer = 0 'quantity
    Public three As String ' unit
    Public four As String 'expiration_date
    Public cmbQuery As String
    Public hayop As Decimal

    Public ulit As String
    Public ulitulit As String

    Public zerofirst As Decimal

    Public times As Decimal

    Public sqlQuerying As String
    Public timePicker As DateTimePicker

    Public Function ExecuteSQLQuery(ByVal SQLQuery As String) As DataTable
        Try
            Dim sqlCon As New MySqlConnection("server=localhost; username=root; password=; database=red_cheese_pizza_database")
            Dim sqlDA As New MySqlDataAdapter(SQLQuery, sqlCon)
            Dim sqlCB As New MySqlCommandBuilder(sqlDA)
            sqlDT.Reset() ' refresh 
            sqlDA.Fill(sqlDT)
        Catch ex As Exception
            'MsgBox("Error: " & ex.ToString)
            ' If Err.Number = 5 Then
            ' MsgBox("Invalid Database, Configure TCP/IP", MsgBoxStyle.Exclamation, "Sales and Inventory")
            ' Else
            MsgBox("Error : " & ex.Message)
            ' End If
            'MsgBox("Error No. " & Err.Number & " Invalid database or no database found !! Adjust settings first", MsgBoxStyle.Critical, "Sales And Inventory")
            'MsgBox(SQLQuery)
        End Try
        Return sqlDT
    End Function

    Public Function ExecuteSQLQueru(ByVal strsql As String)
        Try
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = strsql
            End With
            objdt = New DataTable
            objda = New MySqlDataAdapter(strsql, objconn)
            objda.Fill(objdt)
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "RELOADTEXT", prog_message_caption, MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try
        Return objdt
    End Function

    Public Sub Login_query(ByVal strsql As String)
        Try
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = strsql
            End With
            objdt = New DataTable
            objda = New MySqlDataAdapter(strsql, objconn)
            objda.Fill(objdt)
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message & "RELOADTEXT", prog_message_caption, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            objconn.Dispose()
        End Try
    End Sub
    Public Sub ClearTextBoxLoad()
        Loginfrm.UsernameTextBox.Text = ""
        Loginfrm.PasswordTextBox.Text = ""
    End Sub
    Public Sub Hide_Manager_Function()
        'manager_interface

    End Sub
    Public Sub Hide_Crew_Function()
        'crew-interface

    End Sub
    Public Sub Show_Manager_Function()
        'manager_interface
        'Manager_Interface.pictMaintenance.Show()
        'Manager_Interface.pictBackup.Show()
        'Manager_Interface.pictRecord.Show()
        'Manager_Interface.pictAccount.Show()
    End Sub
    Public Sub False_Enabled_Modify_Raw_Quantity_Function()
        'Modify_Raw_Quantity.txtQuant.Text = ""
        'Modify_Raw_Quantity.DateTimePicker2.Text = ""
        'Modify_Raw_Quantity.cmbselectUnit.Text = ""
        'Modify_Raw_Quantity.txtQuant.Enabled = False
        'Modify_Raw_Quantity.cmbselectUnit.Enabled = False
        'Modify_Raw_Quantity.DateTimePicker2.Enabled = False
    End Sub
    Public Sub True_Enabled_Modify_Raw_Quantity_Function()
        'Modify_Raw_Quantity.txtQuant.Enabled = True
        'Modify_Raw_Quantity.cmbselectUnit.Enabled = True
        'Modify_Raw_Quantity.DateTimePicker2.Enabled = True
    End Sub
    Public Sub True_Enabled_User_Account_Function()
        User_Account.btnFname.Enabled = True
        User_Account.btnMname.Enabled = True
        User_Account.btnLname.Enabled = True
        User_Account.btnNum.Enabled = True
        User_Account.btnUser.Enabled = True
        User_Account.btnPass.Enabled = True
        User_Account.cmbAccType.Enabled = True
    End Sub
    Public Sub False_Enabled_User_Account_Function()
        User_Account.btnFname.Enabled = False
        User_Account.btnMname.Enabled = False
        User_Account.btnLname.Enabled = False
        User_Account.btnNum.Enabled = False
        User_Account.btnUser.Enabled = False
        User_Account.btnPass.Enabled = False
        User_Account.cmbAccType.Enabled = False
    End Sub
    Public Sub User_Account_clear_function()
        User_Account.btnFname.Text = ""
        User_Account.btnMname.Text = ""
        User_Account.btnLname.Text = ""
        User_Account.btnNum.Text = ""
        User_Account.btnUser.Text = ""
        User_Account.btnPass.Text = ""
        User_Account.cmbAccType.Text = ""
    End Sub
    Public Sub grpnotedisableme()
        'Add_Prod.cmbSubmit1.Enabled = False
        Add_Prod.txtConSolo.Enabled = False
        Add_Prod.txtConReg.Enabled = False
        Add_Prod.txtConFam.Enabled = False
        Add_Prod.cmbUnitSolo.Enabled = False
        Add_Prod.cmbUnitReg.Enabled = False
        Add_Prod.cmbUnitFam.Enabled = False
        Add_Prod.txtConThin.Enabled = False
        Add_Prod.cmbUnitThin.Enabled = False
        Add_Prod.txtConDeep.Enabled = False
        Add_Prod.cmbUnitDeep.Enabled = False
    End Sub
    Public Sub grpnoteenabledme()
        '   Add_Prod.cmbSubmit1.Enabled = True
        Add_Prod.txtConSolo.Enabled = True
        Add_Prod.txtConReg.Enabled = True
        Add_Prod.txtConFam.Enabled = True
        Add_Prod.cmbUnitSolo.Enabled = True
        Add_Prod.cmbUnitReg.Enabled = True
        Add_Prod.cmbUnitFam.Enabled = True
        Add_Prod.txtConThin.Enabled = True
        Add_Prod.cmbUnitThin.Enabled = True
        Add_Prod.txtConDeep.Enabled = True
        Add_Prod.cmbUnitDeep.Enabled = True
        Add_Prod.txtconNone.Enabled = True
        Add_Prod.cmbunitNone.Enabled = True
        Add_Prod.txtconGlass.Enabled = True
        Add_Prod.cmbunitGlass.Enabled = True
    End Sub
    Public Sub disabletxt()
        Add_Prod.txtConSolo.Enabled = False
        Add_Prod.cmbUnitSolo.Enabled = False
        Add_Prod.txtConReg.Enabled = False
        Add_Prod.cmbUnitReg.Enabled = False
        Add_Prod.txtConFam.Enabled = False
        Add_Prod.cmbUnitFam.Enabled = False
        Add_Prod.txtConThin.Enabled = False
        Add_Prod.cmbUnitThin.Enabled = False
        Add_Prod.txtConDeep.Enabled = False
        Add_Prod.cmbUnitDeep.Enabled = False
        Add_Prod.txtconNone.Enabled = False
        Add_Prod.cmbunitNone.Enabled = False
        Add_Prod.txtconGlass.Enabled = False
        Add_Prod.cmbunitGlass.Enabled = False
    End Sub
    Public Sub txtconproddisable()
        Add_Prod.txtconprod.Enabled = False
    End Sub

End Module
