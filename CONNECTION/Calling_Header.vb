Imports MySql.Data.MySqlClient
Module Calling_Header
    Public Sub cmdDeletebtnProd_Call()
        question = MsgBox("Once you remove product/s it should already remove their own raw material/s so be careful. " & Environment.NewLine & " Are you sure you want to remove " & Modall.Label14.Text & " product/s, consider with its raw material/s ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "WARNING           Backup Database: Recommended")
        If question = MsgBoxResult.Yes Then
            For i As Integer = Modall.DataGridView4.Rows.Count() - 1 To 0 Step -1
                Dim deletert As Boolean
                deletert = Modall.DataGridView4.Rows(i).Cells(1).Value
                If deletert = True Then
                    Try
                        objconn.Open()
                        DeleteQuery = "Delete  from product_table where Product_Name = '" & CStr(Modall.DataGridView4.Rows(i).Cells(2).Value.ToString) & "' "
                        objcmd = New MySqlCommand(DeleteQuery, objconn)
                        objdr = objcmd.ExecuteReader
                        objconn.Close()
                    Catch ex As Exception
                        MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
                    End Try

                    objconn = New MySqlConnection
                    objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                    Try

                        objconn.Open()

                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " deleting product name which is " & CStr(Modall.DataGridView4.Rows(i).Cells(2).Value.ToString) & " together with its raw materials on ' ,CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "')) "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                    Catch ex As Exception
                        MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
                    End Try
                End If
                Dim rowert As DataGridViewRow
                rowert = Modall.DataGridView4.Rows(i)
                Modall.DataGridView4.Rows.Remove(rowert)
            Next
            fillProductQuantity()
            Modall.cmdDeletebtnProd.Hide()
            Modall.cmdDeletebtnProdHide.Show()
            Modall.Label14.Text = ""
            MsgBox("Successfully Removed Product/s at our system .", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub btnAvailableProd_Call()
        question = MsgBox("Area you sure you want to remove selected " & Modall.Label29.Text & " Product/s ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Red Cheese Pizza Message")
        If question = MsgBoxResult.Yes Then
            For i As Integer = Modall.DataGridView8.Rows.Count() - 1 To 0 Step -1
                Dim deleten As Boolean
                deleten = Modall.DataGridView8.Rows(i).Cells(1).Value
                If deleten = True Then
                    Try
                        objconn.Open()
                        DeleteQuery = "Delete  from product_table where Product_Name = '" & CStr(Modall.DataGridView8.Rows(i).Cells(2).Value.ToString) & "' "
                        objcmd = New MySqlCommand(DeleteQuery, objconn)
                        objdr = objcmd.ExecuteReader
                        objconn.Close()
                    Catch ex As Exception
                        MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
                    End Try

                    objconn = New MySqlConnection
                    objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                    objconn.Open()

                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " deleting product name which is " & CStr(Modall.DataGridView8.Rows(i).Cells(2).Value.ToString) & " on ' ,CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "')) "
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()
                End If
                Dim rown As DataGridViewRow
                rown = Modall.DataGridView8.Rows(i)
                Modall.DataGridView8.Rows.Remove(rown)
            Next
            fillAvailableProd()
            Modall.btnAvailableProd.Hide()
            Modall.btnAvailableProdHide.Show()
            Modall.Label29.Text = ""
            MsgBox("Successfully Removed Product/s at our system .", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Public Sub btnExpired_Call()
        question = MsgBox("Area you sure you want to remove selected " & Modall.Label28.Text & " expired raw material/s ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Red Cheese Pizza Message")
        If question = MsgBoxResult.Yes Then
            'yes of course
            For i As Integer = Modall.DataGridView6.Rows.Count() - 1 To 0 Step -1
                Dim deleter As Boolean
                deleter = Modall.DataGridView6.Rows(i).Cells(1).Value
                If deleter = True Then
                    Try
                        objconn.Open()
                        DeleteQuery = "Delete  from raw_expiration_date where Raw_ID IN (select Raw_ID from raw_material_table  where Raw_Name  = '" & CStr(Modall.DataGridView6.Rows(i).Cells(2).Value.ToString) & "' " _
                            & " AND DATE_FORMAT(raw_expiration_date.Raw_Expiration_Date,'%m/%d/%Y') = '" & CStr(Modall.DataGridView6.Rows(i).Cells(4).Value.ToString) & "')"
                        objcmd = New MySqlCommand(DeleteQuery, objconn)
                        objdr = objcmd.ExecuteReader
                        objconn.Close()
                    Catch ex As Exception
                        MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
                    End Try

                    objconn = New MySqlConnection
                    objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                    objconn.Open()

                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " removing expired raw material which is " & CStr(Modall.DataGridView6.Rows(i).Cells(2).Value.ToString) & " on ' ,CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & Modall.lblUser.Text & "')) "
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()
                End If
                Dim rower As DataGridViewRow
                rower = Modall.DataGridView6.Rows(i)
                Modall.DataGridView6.Rows.Remove(rower)
            Next
            fillExpired()
            Modall.btnExpired.Hide()
            Modall.btnExpiredHide.Show()
            Modall.Label28.Text = ""
            MsgBox("Successfully Removed Expired Raw Material/s at our system .", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
End Module
