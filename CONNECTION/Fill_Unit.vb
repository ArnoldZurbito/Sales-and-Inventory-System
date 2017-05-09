Imports MySql.Data.MySqlClient
Module Fill_Unit
    Public Sub filtercmb()
        Add_Raw_Material.cmbUNIT.Items.Clear()

       
        Try
            objconn.Open()
            cmbQuery = "select * from unit_table ORDER BY Unit_Name ASC"
            objcmd = New MySqlCommand(cmbQuery, objconn)
            objdr = objcmd.ExecuteReader
            While objdr.Read
                Dim pNam = objdr.GetString("Unit_Name")
                Add_Raw_Material.cmbUNIT.Items.Add(pNam)
                ModifyRaw.putUnit.Items.Add(pNam)
            End While
            objconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
        End Try
    End Sub

    Public Sub fillcmbcategory()
        Modall.cmbcategory.Items.Clear()

        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If

        Try
            objconn.Open()
            cmbQuery = "select * from category order by Cat_Name ASC"
            objcmd = New MySqlCommand(cmbQuery, objconn)
            objdr = objcmd.ExecuteReader
            Dim comboSource As New Dictionary(Of String, String)()
            Modall.cmbcategory.Items.Insert("0", "-- View All --")
            Modall.cmbcategory.DisplayMember = "Value"
            Modall.cmbcategory.ValueMember = "Key"

            Modall.cmbcategory.SelectedIndex = 0

            While objdr.Read
                Dim catname As String = objdr.GetString("Cat_Name")
                Modall.cmbcategory.Items.Add(catname)
            End While
            objconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
        End Try


    End Sub

    Public Structure ColoredComboboxItem
        Dim Text As String
        Dim Color As Color
        Dim Bold As Boolean
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Structure
End Module
