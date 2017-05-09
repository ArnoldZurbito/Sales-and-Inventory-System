Imports MySql.Data.MySqlClient
Module Filtering

    Public resdatefromsalesr As String = Format(Modall.dtpDateFomSales.Value, "yyyy-MM-dd hh:mm:ss")
    Public resdatetosalesr As String = Format(Modall.dtpDateToSales.Value, "yyyy-MM-dd hh:mm:ss")
    Public Sub SalesFiltering()
        '  Modall.DataGridView9.Rows.Clear()

        objdt = New DataTable
        objda = New MySqlDataAdapter("SELECT product_table.Product_Name, CONCAT(Order_Quantity , CASE " _
                                               & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 16) or " _
                                               & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 6) or " _
                                                & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 7) or " _
                                    & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 8) THEN ' piece/s' " _
                                 & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 9)  THEN ' Glass/es' " _
                                                                & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 10)  THEN ' Pitcher/s' " _
                                                                                               & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 11)  THEN ' Cup/s' " _
                                               & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 1) or " _
                                               & "  product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 2) or " _
                                               & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 3) or " _
                                               & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 4) or " _
                                        & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 5) THEN ' box/es' " _
                                               & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 12) or " _
                                               & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 13) or " _
                               & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 14) THEN ' bottle/s' " _
                                  & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 15) THEN ' can/s'  END, ' (',(Case when product_size.Size_Name = 'None' Then 'piece/s'  Else   Concat(product_size.Size_Name, ' size') End ) , ') ') AS 'QUANTITY',Price, DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As 'Order_Date' FROM order_table inner join product_table on order_table.Product_ID = product_table.Product_ID  inner JOIN product_size on order_table.Size_ID = product_size.Size_ID where order_table.Order_Date BETWEEN '" & resdatefromsalesr & "' And '" & resdatetosalesr & "'  Order by DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') DESC", objconn)

        objda.Fill(objdt)
        Modall.DataGridView9.DataSource = objdt

        Modall.lblTotalSales.Text = ""
        '        With objcmd
        '            .Connection = objconn
        '            ' .CommandText = "select (CASE WHEN Raw_Quantity  < 1 Then Raw_Quantity * 1000 " _
        '            '         & " WHEN Raw_Quantity  < 1 Then Raw_Quantity * 1000 ELSE Raw_Quantity END) AS 'Name', " _
        '            '   & "(CASE WHEN Unit_Name = 'kG/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'gram/s' WHEN  ELSE Unit_Name  END) As 'Unitsop', " _
        '            '  & "DATE_FORMAT(`Raw_Expiration_Date`,'%c/%d/%Y') as 'expireraw' from raw_expiration_date inner join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID inner join raw_material_table ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where Raw_Material_Table.Raw_Name ='" & txtRawNamed.Text & "' AND DATE_FORMAT(`Raw_Expiration_Date`,'%c/%d/%Y') = '" & CStr(txtExpiration.Text) & "'"
        '            .CommandText = "SELECT SUM(price) FROM order_table INNER JOIN product_table ON " _
        '& " order_table.Product_ID = product_table.Product_ID INNER JOIN product_size ON order_table.Size_ID = product_size.Size_ID " _
        '& " WHERE order_table.Order_Date BETWEEN '" & resdatefromsalesr & "' AND '" & resdatetosalesr & "' ORDER BY DATE_FORMAT(order_table.Order_Date, " _
        '           & " '%m/%d/%Y %h:%i %p') DESC"
        '        End With
        '        objconn.Open()
        '        objdr = objcmd.ExecuteReader
        '        If objdr.HasRows Then
        '            While objdr.Read
        '                Modall.lblTotalSales.Text = "P " & objdr.GetDecimal("SUM(price)")
        '            End While
        '        End If
        '        objconn.Close()

        'For iv As Integer = 0 To Modall.DataGridView9.RowCount - 1

        '    Dim a As Decimal = Modall.DataGridView9.Rows(iv).Cells(2).Value
        '    '  a = dtgOrder.Rows(iv).Cells(3).Value * Convert.ToDecimal(dtgOrder.Rows(iv).Cells(5).Value)
        '    Modall.lblTotalSales.Text = Modall.DataGridView9.RowCount
        'Next
        '  End If
        strsql = "SELECT SUM(price) FROM order_table INNER JOIN product_table ON " _
& " order_table.Product_ID = product_table.Product_ID INNER JOIN product_size ON order_table.Size_ID = product_size.Size_ID " _
& " WHERE order_table.Order_Date BETWEEN '" & resdatefromsalesr & "' AND '" & resdatetosalesr & "' ORDER BY DATE_FORMAT(order_table.Order_Date, " _
           & " '%m/%d/%Y %h:%i %p') DESC"
        fillSpecifictxt(strsql)
        Try
            If objdt.Rows.Count > 0 Then
                Dim sera As Decimal

                sera = objdt.Rows(0).Item("SUM(Price)")
                Modall.lblTotalSales.Text = sera
            End If
        Catch ex As Exception
            MessageBox.Show("' " & ex.Message & " '" & " Contact Programmer About this Error. Thank You", "Error Message at fillSpecifictxt()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub fillSpecifictxt(ByVal strsql As String)
        Try
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = strsql
            End With
            objda = New MySqlDataAdapter(strsql, objconn)
            objdt = New DataTable
            objda.Fill(objdt)
            objda.Dispose()
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show("' " & ex.Message & " '" & " Contact Programmer About this Error. Thank You", "Error Message at fillSpecifictxt()", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub SearchLogsUser()
        ' Modall.DataGridView10.Rows.Clear()
        Dim resDatPick As String = Format(Modall.dtpDateFrom.Value, "yyyy-MM-dd hh:mm:ss")
        Dim resDatPic As String = Format(Modall.dtpDateTo.Value, "yyyy-MM-dd hh:mm:ss")
        objdt = New DataTable
        objda = New MySqlDataAdapter("SELECT DATE_FORMAT(Log_Date,'%m/%d/%Y') As 'Log_Dates', GROUP_CONCAT(logs.Log_View, ' ', DATE_FORMAT(logs.Log_Date,'%h:%i %p') SEPARATOR '\n') As 'Log_User' from logs " _
                & " INNER JOIN user_account on logs.User_Company_ID = user_account.User_Company_ID  where Log_Date  BETWEEN '" & resDatPick & "' And '" & resDatPic & "'  GROUP BY  DATE_FORMAT(logs.Log_Date,'%m/%d/%Y') ORDER BY DATE_FORMAT(logs.Log_Date,'%m/%d/%Y')  ASC ", objconn)
        objda.Fill(objdt)
        Modall.DataGridView10.DataSource = objdt
    End Sub

    Public Sub filterAvailableProd10()

        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 8 or category.Cat_ID = 9 Then CONCAT(product_quantity.Quantity, '    [-----] ') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12.oz.)' Else ' bottle (12.oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Price' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID " _
                                            & " inner JOIN category on product_table.Cat_ID = category.Cat_ID " _
                                            & " group by product_table.Product_Name ASC LIMIT 10", cn)
            'product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size'
            da.Fill(dt)
            Modall.DataGridView8.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Close()
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
        Modall.txtOrderName.Text = ""
        Modall.txtOrderName.Enabled = False
        Modall.txtOrderQuant.Text = ""
        Modall.txtOrderQuant.Enabled = False
        Modall.cmbOrderSize.Text = ""
        Modall.cmbOrderSize.Enabled = False
    End Sub

    Public Sub filterAvailableProd25()

        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 8 or category.Cat_ID = 9 Then CONCAT(product_quantity.Quantity, '    [-----] ') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12.oz.)' Else ' bottle (12.oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Price' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID " _
                                            & " inner JOIN category on product_table.Cat_ID = category.Cat_ID " _
                                            & " group by product_table.Product_Name ASC LIMIT 25", cn)
            'product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size'
            da.Fill(dt)
            Modall.DataGridView8.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Close()
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
        Modall.txtOrderName.Text = ""
        Modall.txtOrderName.Enabled = False
        Modall.txtOrderQuant.Text = ""
        Modall.txtOrderQuant.Enabled = False
        Modall.cmbOrderSize.Text = ""
        Modall.cmbOrderSize.Enabled = False
    End Sub
    Public Sub filterAvailableProd50()

        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 8 or category.Cat_ID = 9 Then CONCAT(product_quantity.Quantity, '    [-----] ') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12.oz.)' Else ' bottle (12.oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Price' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID " _
                                            & " inner JOIN category on product_table.Cat_ID = category.Cat_ID " _
                                            & " group by product_table.Product_Name ASC LIMIT 50", cn)
            'product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size'
            da.Fill(dt)
            Modall.DataGridView8.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Close()
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
        Modall.txtOrderName.Text = ""
        Modall.txtOrderName.Enabled = False
        Modall.txtOrderQuant.Text = ""
        Modall.txtOrderQuant.Enabled = False
        Modall.cmbOrderSize.Text = ""
        Modall.cmbOrderSize.Enabled = False
    End Sub

    Public Sub filterAvailableProd100()

        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 8 or category.Cat_ID = 9 Then CONCAT(product_quantity.Quantity, '    [-----] ') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12.oz.)' Else ' bottle (12.oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Price' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID " _
                                            & " inner JOIN category on product_table.Cat_ID = category.Cat_ID " _
                                            & " group by product_table.Product_Name ASC LIMIT 100", cn)
            'product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size'
            da.Fill(dt)
            Modall.DataGridView8.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Close()
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
        Modall.txtOrderName.Text = ""
        Modall.txtOrderName.Enabled = False
        Modall.txtOrderQuant.Text = ""
        Modall.txtOrderQuant.Enabled = False
        Modall.cmbOrderSize.Text = ""
        Modall.cmbOrderSize.Enabled = False
    End Sub

    Public Sub filterOrderProd10()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT product_table.Product_Name, CONCAT(Order_Quantity , CASE " _
                                                       & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 16) or " _
                                                       & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 6) or " _
                                                        & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 7) or " _
                                            & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 8) THEN ' piece/s' " _
                                         & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 9)  THEN ' Glass/es' " _
                                                                        & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 10)  THEN ' Pitcher/s' " _
                                                                                                       & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 11)  THEN ' Cup/s' " _
                                                       & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 1) or " _
                                                       & "  product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 2) or " _
                                                       & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 3) or " _
                                                       & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 4) or " _
                                                & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 5) THEN ' box/es' " _
                                                       & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 12) or " _
                                                       & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 13) or " _
                                       & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 14) THEN ' bottle/s' " _
                                          & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 15) THEN ' can/s'  END, ' (',(Case when product_size.Size_Name = 'None' Then 'piece/s'  Else   Concat(product_size.Size_Name, ' size') End ) , ') ') AS 'QUANTITY',Concat('P ',Price) As 'Price', DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As 'Order_Date' FROM order_table inner join product_table on order_table.Product_ID = product_table.Product_ID  inner JOIN product_size on order_table.Size_ID = product_size.Size_ID  Order by DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') DESC LIMIT 10", cn)

            da.Fill(dt)
            Modall.DataGridView9.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterOrderProd25()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT product_table.Product_Name, CONCAT(Order_Quantity , CASE " _
                                               & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 16) or " _
                                               & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 6) or " _
                                                & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 7) or " _
                                    & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 8) THEN ' piece/s' " _
                                 & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 9)  THEN ' Glass/es' " _
                                                                & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 10)  THEN ' Pitcher/s' " _
                                                                                               & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 11)  THEN ' Cup/s' " _
                                               & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 1) or " _
                                               & "  product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 2) or " _
                                               & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 3) or " _
                                               & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 4) or " _
                                        & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 5) THEN ' box/es' " _
                                               & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 12) or " _
                                               & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 13) or " _
                               & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 14) THEN ' bottle/s' " _
                                  & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 15) THEN ' can/s'  END, ' (',(Case when product_size.Size_Name = 'None' Then 'piece/s'  Else   Concat(product_size.Size_Name, ' size') End ) , ') ') AS 'QUANTITY',Concat('P ',Price) As 'Price', DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As 'Order_Date' FROM order_table inner join product_table on order_table.Product_ID = product_table.Product_ID  inner JOIN product_size on order_table.Size_ID = product_size.Size_ID  Order by DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') DESC LIMIT 25", cn)
            da.Fill(dt)
            Modall.DataGridView9.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub

    Public Sub filterOrderProd50()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT product_table.Product_Name, CONCAT(Order_Quantity , CASE " _
                                               & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 16) or " _
                                               & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 6) or " _
                                                & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 7) or " _
                                    & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 8) THEN ' piece/s' " _
                                 & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 9)  THEN ' Glass/es' " _
                                                                & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 10)  THEN ' Pitcher/s' " _
                                                                                               & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 11)  THEN ' Cup/s' " _
                                               & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 1) or " _
                                               & "  product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 2) or " _
                                               & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 3) or " _
                                               & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 4) or " _
                                        & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 5) THEN ' box/es' " _
                                               & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 12) or " _
                                               & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 13) or " _
                               & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 14) THEN ' bottle/s' " _
                                  & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 15) THEN ' can/s'  END, ' (',(Case when product_size.Size_Name = 'None' Then 'piece/s'  Else   Concat(product_size.Size_Name, ' size') End ) , ') ') AS 'QUANTITY',Concat('P ',Price) As 'Price', DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As 'Order_Date' FROM order_table inner join product_table on order_table.Product_ID = product_table.Product_ID  inner JOIN product_size on order_table.Size_ID = product_size.Size_ID  Order by DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') DESC LIMIT 50", cn)
            da.Fill(dt)
            Modall.DataGridView9.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterOrderProd100()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT product_table.Product_Name, CONCAT(Order_Quantity , CASE " _
                                              & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 16) or " _
                                              & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 6) or " _
                                               & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 7) or " _
                                   & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 8) THEN ' piece/s' " _
                                & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 9)  THEN ' Glass/es' " _
                                                               & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 10)  THEN ' Pitcher/s' " _
                                                                                              & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 11)  THEN ' Cup/s' " _
                                              & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 1) or " _
                                              & "  product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 2) or " _
                                              & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 3) or " _
                                              & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 4) or " _
                                       & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 5) THEN ' box/es' " _
                                              & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 12) or " _
                                              & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 13) or " _
                              & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 14) THEN ' bottle/s' " _
                                 & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 15) THEN ' can/s'  END, ' (',(Case when product_size.Size_Name = 'None' Then 'piece/s'  Else   Concat(product_size.Size_Name, ' size') End ) , ') ') AS 'QUANTITY',Concat('P ',Price) As 'Price', DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As 'Order_Date' FROM order_table inner join product_table on order_table.Product_ID = product_table.Product_ID  inner JOIN product_size on order_table.Size_ID = product_size.Size_ID  Order by DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') DESC LIMIT 100", cn)
            da.Fill(dt)
            Modall.DataGridView9.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub

    Public Sub filterExpired10()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("select  Raw_Name,CONCAT(TRIM(`Raw_Quantity`) + 0, ' ',`Unit_Name`) As 'QUANTITY',DATE_FORMAT(Raw_Expiration_Date,'%m/%d/%Y') AS 'EXPIRED_PROD' from raw_expiration_date inner join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID inner join raw_material_table ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where raw_expiration_date.Raw_Expiration_Date <= DATE_ADD(DATE(now()), INTERVAL 3 day) ORDER by raw_material_table.Raw_Name ASC LIMIT 10", cn)
            da.Fill(dt)
            Modall.DataGridView6.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub
    Public Sub filterExpired25()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("select  Raw_Name,CONCAT(TRIM(`Raw_Quantity`) + 0, ' ',`Unit_Name`) As 'QUANTITY',DATE_FORMAT(Raw_Expiration_Date,'%m/%d/%Y') AS 'EXPIRED_PROD' from raw_expiration_date inner join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID inner join raw_material_table ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where raw_expiration_date.Raw_Expiration_Date <= DATE_ADD(DATE(now()), INTERVAL 3 day) ORDER by raw_material_table.Raw_Name ASC LIMIT 25", cn)
            da.Fill(dt)
            Modall.DataGridView6.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub
    Public Sub filterExpired50()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("select  Raw_Name,CONCAT(TRIM(`Raw_Quantity`) + 0, ' ',`Unit_Name`) As 'QUANTITY',DATE_FORMAT(Raw_Expiration_Date,'%m/%d/%Y') AS 'EXPIRED_PROD' from raw_expiration_date inner join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID inner join raw_material_table ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where raw_expiration_date.Raw_Expiration_Date <= DATE_ADD(DATE(now()), INTERVAL 3 day) ORDER by raw_material_table.Raw_Name ASC LIMIT 50", cn)
            da.Fill(dt)
            Modall.DataGridView6.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub
    Public Sub filterExpired100()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("select  Raw_Name,CONCAT(TRIM(`Raw_Quantity`) + 0, ' ',`Unit_Name`) As 'QUANTITY',DATE_FORMAT(Raw_Expiration_Date,'%m/%d/%Y') AS 'EXPIRED_PROD' from raw_expiration_date inner join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID inner join raw_material_table ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where raw_expiration_date.Raw_Expiration_Date <= DATE_ADD(DATE(now()), INTERVAL 3 day) ORDER by raw_material_table.Raw_Name ASC LIMIT 100", cn)
            da.Fill(dt)
            Modall.DataGridView6.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub

    Public Sub filterRecord10()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT DATE_FORMAT(Log_Date,'%m/%d/%Y') As 'Log_Dates', GROUP_CONCAT(logs.Log_View, ' ', DATE_FORMAT(logs.Log_Date,'%h:%i %p') SEPARATOR '\n') As 'Log_User' " _
                                           & " from logs INNER JOIN user_account on logs.User_Company_ID = user_account.User_Company_ID GROUP BY  DATE_FORMAT(logs.Log_Date,'%m/%d/%Y') ORDER BY DATE_FORMAT(logs.Log_Date,'%m/%d/%Y')  DESC LIMIT 10", cn)
            da.Fill(dt)
            Modall.DataGridView10.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterRecord25()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT DATE_FORMAT(Log_Date,'%m/%d/%Y') As 'Log_Dates', GROUP_CONCAT(logs.Log_View, ' ', DATE_FORMAT(logs.Log_Date,'%h:%i %p') SEPARATOR '\n') As 'Log_User' " _
                                           & " from logs INNER JOIN user_account on logs.User_Company_ID = user_account.User_Company_ID GROUP BY  DATE_FORMAT(logs.Log_Date,'%m/%d/%Y') ORDER BY DATE_FORMAT(logs.Log_Date,'%m/%d/%Y')  DESC LIMIT 25", cn)
            da.Fill(dt)
            Modall.DataGridView10.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterRecord50()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT DATE_FORMAT(Log_Date,'%m/%d/%Y') As 'Log_Dates', GROUP_CONCAT(logs.Log_View, ' ', DATE_FORMAT(logs.Log_Date,'%h:%i %p') SEPARATOR '\n') As 'Log_User' " _
                                           & " from logs INNER JOIN user_account on logs.User_Company_ID = user_account.User_Company_ID GROUP BY  DATE_FORMAT(logs.Log_Date,'%m/%d/%Y') ORDER BY DATE_FORMAT(logs.Log_Date,'%m/%d/%Y')  DESC LIMIT 50", cn)
            da.Fill(dt)
            Modall.DataGridView10.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterRecord100()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT DATE_FORMAT(Log_Date,'%m/%d/%Y') As 'Log_Dates', GROUP_CONCAT(logs.Log_View, ' ', DATE_FORMAT(logs.Log_Date,'%h:%i %p') SEPARATOR '\n') As 'Log_User' " _
                                           & " from logs INNER JOIN user_account on logs.User_Company_ID = user_account.User_Company_ID GROUP BY  DATE_FORMAT(logs.Log_Date,'%m/%d/%Y') ORDER BY DATE_FORMAT(logs.Log_Date,'%m/%d/%Y')  DESC LIMIT 100", cn)
            da.Fill(dt)
            Modall.DataGridView10.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterCritical10()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT `Raw_Name` AS 'RAW_MATERIAL/S', CONCAT(TRIM(SUM(`Raw_Quantity`)) + 0, '  ',`Unit_Name`) AS 'QUANTITY_LEFT' " _
                                           & "FROM raw_expiration_date INNER Join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID INNER Join raw_material_table " _
                                           & "ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID WHERE raw_quantity < 2  AND unit_table.Unit_Name = 'dozen/s' OR raw_quantity < 3 " _
                                           & "AND unit_table.Unit_Name = 'kilo/s'  OR raw_quantity < 1 AND unit_table.Unit_Name = 'liter/s' GROUP BY raw_material_table.Raw_Name ASC LIMIT 10", cn)

            da.Fill(dt)
            Modall.DataGridView7.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub
    Public Sub filterCritical25()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT `Raw_Name` AS 'RAW_MATERIAL/S', CONCAT(TRIM(SUM(`Raw_Quantity`)) + 0, '  ',`Unit_Name`) AS 'QUANTITY_LEFT' " _
                                           & "FROM raw_expiration_date INNER Join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID INNER Join raw_material_table " _
                                           & "ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID WHERE raw_quantity < 2  AND unit_table.Unit_Name = 'dozen/s' OR raw_quantity < 3 " _
                                           & "AND unit_table.Unit_Name = 'kilo/s'  OR raw_quantity < 1 AND unit_table.Unit_Name = 'liter/s' GROUP BY raw_material_table.Raw_Name ASC LIMIT 25", cn)

            da.Fill(dt)
            Modall.DataGridView7.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub
    Public Sub filterCritical50()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT `Raw_Name` AS 'RAW_MATERIAL/S', CONCAT(TRIM(SUM(`Raw_Quantity`)) + 0, '  ',`Unit_Name`) AS 'QUANTITY_LEFT' " _
                                           & "FROM raw_expiration_date INNER Join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID INNER Join raw_material_table " _
                                           & "ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID WHERE raw_quantity < 2  AND unit_table.Unit_Name = 'dozen/s' OR raw_quantity < 3 " _
                                           & "AND unit_table.Unit_Name = 'kilo/s'  OR raw_quantity < 1 AND unit_table.Unit_Name = 'liter/s' GROUP BY raw_material_table.Raw_Name ASC LIMIT 50", cn)

            da.Fill(dt)
            Modall.DataGridView7.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub
    Public Sub filterCritical100()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT `Raw_Name` AS 'RAW_MATERIAL/S', CONCAT(TRIM(SUM(`Raw_Quantity`)) + 0, '  ',`Unit_Name`) AS 'QUANTITY_LEFT' " _
                                           & "FROM raw_expiration_date INNER Join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID INNER Join raw_material_table " _
                                           & "ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID WHERE raw_quantity < 2  AND unit_table.Unit_Name = 'dozen/s' OR raw_quantity < 3 " _
                                           & "AND unit_table.Unit_Name = 'kilo/s'  OR raw_quantity < 1 AND unit_table.Unit_Name = 'liter/s' GROUP BY raw_material_table.Raw_Name ASC LIMIT 100", cn)

            da.Fill(dt)
            Modall.DataGridView7.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub

    Public Sub filterProduct10()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            '    Dim ast As String = FormatCurrency("\u20B1", 0).ToString()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 8 OR category.Cat_ID = 9 Then CONCAT(product_quantity.Quantity, ' per serving') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12.oz.)' Else ' bottle (12.oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Prices' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID " _
                                            & " inner JOIN category on product_table.Cat_ID = category.Cat_ID " _
                                            & " group by product_table.Product_Name ASC LIMIT 10", cn)
            da.Fill(dt)
            Modall.DataGridView4.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterProduct25()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            '    Dim ast As String = FormatCurrency("\u20B1", 0).ToString()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 8 OR category.Cat_ID = 9 Then CONCAT(product_quantity.Quantity, ' per serving') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12.oz.)' Else ' bottle (12.oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Prices' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID " _
                                            & " inner JOIN category on product_table.Cat_ID = category.Cat_ID " _
                                            & " group by product_table.Product_Name ASC LIMIT 25", cn)
            da.Fill(dt)
            Modall.DataGridView4.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterProduct50()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            '    Dim ast As String = FormatCurrency("\u20B1", 0).ToString()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 8 OR category.Cat_ID = 9 Then CONCAT(product_quantity.Quantity, ' per serving') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12.oz.)' Else ' bottle (12.oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Prices' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID " _
                                            & " inner JOIN category on product_table.Cat_ID = category.Cat_ID " _
                                            & " group by product_table.Product_Name ASC LIMIT 50", cn)
            da.Fill(dt)
            Modall.DataGridView4.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterProduct100()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            '    Dim ast As String = FormatCurrency("\u20B1", 0).ToString()
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 8 OR category.Cat_ID = 9 Then CONCAT(product_quantity.Quantity, ' per serving') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12.oz.)' Else ' bottle (12.oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Prices' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID " _
                                            & " inner JOIN category on product_table.Cat_ID = category.Cat_ID " _
                                            & " group by product_table.Product_Name ASC LIMIT 100", cn)
            da.Fill(dt)
            Modall.DataGridView4.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub

    Public Sub filterRawMats10()

        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT CONCAT(UCASE(LEFT(Raw_Material_Table.Raw_Name,1)),LCASE(SUBSTRING(Raw_Material_Table.Raw_Name,2))) As Raw_Name, " _
                               & " CONCAT(CASE WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1000000 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mg/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1000000 , ' kG/s') " _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1000 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mg/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1000 , ' gram/s')" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1 , ' mG/s')" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1000 " _
                               & " THEN CASE WHEN (TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) >= 3.785 THEN" _
                               & " CONCAT((TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) / 3.785 , ' gallon/s') " _
                               & "  WHEN (TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) < 3.785 THEN" _
                               & " CONCAT((TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000), ' liter/s') END" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1 , ' mL/s')" _
                               & " WHEN SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12  END)  >= 12 " _
                               & " THEN  CONCAT(TRUNCATE(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) / 12 ,3) , ' dozen/s')" _
                               & " WHEN SUM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) < 12 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END)) / 1 , ' piece/s')" _
                               & " END " _
                               & ") AS 'QUANTITY',  " _
                               & " GROUP_CONCAT(TRIM(CASE WHEN Raw_Quantity < 1 AND Unit_Name = 'gram/s' THEN Raw_Quantity *  1000  WHEN Raw_Quantity < 1 AND Unit_Name = 'kG/s' THEN " _
                               & " Raw_Quantity *  1000 WHEN Raw_Quantity < 1 AND Unit_Name = 'liter/s' THEN Raw_Quantity *  1000 WHEN Raw_Quantity > 3.785 AND Unit_Name = 'liter/s' " _
                               & " THEN Raw_Quantity /  3.785   WHEN Raw_Quantity < 1 AND Unit_Name = 'gallon/s' THEN " _
                               & " Raw_Quantity *  3.785  WHEN Raw_Quantity < 1 AND Unit_Name = 'dozen/s' THEN Raw_Quantity * 12 WHEN Raw_Quantity >= 12 AND Unit_Name = 'piece/s' " _
                               & " THEN Raw_Quantity / 12 ELSE Raw_Quantity END) + 0,' ',CASE WHEN Unit_Name = 'gram/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'mG/s'  WHEN Unit_Name = 'kG/s' " _
                               & " AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'gram/s' WHEN Unit_Name = 'liter/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'mL/s' " _
                               & " WHEN Unit_Name = 'gallon/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'liter/s' WHEN Unit_Name = 'liter/s' AND " _
                               & " Raw_Expiration_Date.Raw_Quantity > 3.785 THEN 'gallon/s' WHEN Unit_Name = 'piece/s' AND  Raw_Expiration_Date.Raw_Quantity > 12   THEN 'dozen/s' " _
                               & " WHEN Unit_Name = 'dozen/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'piece/s' ELSE Unit_Name END,' = ',DATE_FORMAT(Raw_Expiration_Date,'%c/%d/%Y\n'" _
                               & " ) SEPARATOR '')  AS 'Raw_Expiration_Date'" _
                             & " from Raw_Expiration_Date  inner join Raw_Material_Table ON Raw_Expiration_Date.Raw_ID=Raw_Material_Table.Raw_ID inner join unit_table  " _
                             & " ON unit_table.Unit_ID = raw_expiration_date.Unit_ID  GROUP BY Raw_Material_Table.Raw_ID order by Raw_Name ASC LIMIT 10", cn)
            da.Fill(dt)
            Modall.DataGridView3.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub
    Public Sub filterRawMats25()

        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT CONCAT(UCASE(LEFT(Raw_Material_Table.Raw_Name,1)),LCASE(SUBSTRING(Raw_Material_Table.Raw_Name,2))) As Raw_Name, " _
                               & " CONCAT(CASE WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1000000 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mg/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1000000 , ' kG/s') " _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1000 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mg/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1000 , ' gram/s')" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1 , ' mG/s')" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1000 " _
                               & " THEN CASE WHEN (TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) >= 3.785 THEN" _
                               & " CONCAT((TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) / 3.785 , ' gallon/s') " _
                               & "  WHEN (TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) < 3.785 THEN" _
                               & " CONCAT((TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000), ' liter/s') END" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1 , ' mL/s')" _
                               & " WHEN SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12  END)  >= 12 " _
                               & " THEN  CONCAT(TRUNCATE(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) / 12 ,3) , ' dozen/s')" _
                               & " WHEN SUM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) < 12 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END)) / 1 , ' piece/s')" _
                               & " END " _
                               & ") AS 'QUANTITY',  " _
                               & " GROUP_CONCAT(TRIM(CASE WHEN Raw_Quantity < 1 AND Unit_Name = 'gram/s' THEN Raw_Quantity *  1000  WHEN Raw_Quantity < 1 AND Unit_Name = 'kG/s' THEN " _
                               & " Raw_Quantity *  1000 WHEN Raw_Quantity < 1 AND Unit_Name = 'liter/s' THEN Raw_Quantity *  1000 WHEN Raw_Quantity > 3.785 AND Unit_Name = 'liter/s' " _
                               & " THEN Raw_Quantity /  3.785   WHEN Raw_Quantity < 1 AND Unit_Name = 'gallon/s' THEN " _
                               & " Raw_Quantity *  3.785  WHEN Raw_Quantity < 1 AND Unit_Name = 'dozen/s' THEN Raw_Quantity * 12 WHEN Raw_Quantity >= 12 AND Unit_Name = 'piece/s' " _
                               & " THEN Raw_Quantity / 12 ELSE Raw_Quantity END) + 0,' ',CASE WHEN Unit_Name = 'gram/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'mG/s'  WHEN Unit_Name = 'kG/s' " _
                               & " AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'gram/s' WHEN Unit_Name = 'liter/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'mL/s' " _
                               & " WHEN Unit_Name = 'gallon/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'liter/s' WHEN Unit_Name = 'liter/s' AND " _
                               & " Raw_Expiration_Date.Raw_Quantity > 3.785 THEN 'gallon/s' WHEN Unit_Name = 'piece/s' AND  Raw_Expiration_Date.Raw_Quantity > 12   THEN 'dozen/s' " _
                               & " WHEN Unit_Name = 'dozen/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'piece/s' ELSE Unit_Name END,' = ',DATE_FORMAT(Raw_Expiration_Date,'%c/%d/%Y\n'" _
                               & " ) SEPARATOR '')  AS 'Raw_Expiration_Date'" _
                             & " from Raw_Expiration_Date  inner join Raw_Material_Table ON Raw_Expiration_Date.Raw_ID=Raw_Material_Table.Raw_ID inner join unit_table  " _
                             & " ON unit_table.Unit_ID = raw_expiration_date.Unit_ID  GROUP BY Raw_Material_Table.Raw_ID order by Raw_Name ASC LIMIT 25", cn)
            da.Fill(dt)
            Modall.DataGridView3.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub

    Public Sub filterRawMats50()

        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT CONCAT(UCASE(LEFT(Raw_Material_Table.Raw_Name,1)),LCASE(SUBSTRING(Raw_Material_Table.Raw_Name,2))) As Raw_Name, " _
                               & " CONCAT(CASE WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1000000 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mg/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1000000 , ' kG/s') " _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1000 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mg/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1000 , ' gram/s')" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1 , ' mG/s')" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1000 " _
                               & " THEN CASE WHEN (TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) >= 3.785 THEN" _
                               & " CONCAT((TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) / 3.785 , ' gallon/s') " _
                               & "  WHEN (TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) < 3.785 THEN" _
                               & " CONCAT((TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000), ' liter/s') END" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1 , ' mL/s')" _
                               & " WHEN SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12  END)  >= 12 " _
                               & " THEN  CONCAT(TRUNCATE(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) / 12 ,3) , ' dozen/s')" _
                               & " WHEN SUM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) < 12 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END)) / 1 , ' piece/s')" _
                               & " END " _
                               & ") AS 'QUANTITY',  " _
                               & " GROUP_CONCAT(TRIM(CASE WHEN Raw_Quantity < 1 AND Unit_Name = 'gram/s' THEN Raw_Quantity *  1000  WHEN Raw_Quantity < 1 AND Unit_Name = 'kG/s' THEN " _
                               & " Raw_Quantity *  1000 WHEN Raw_Quantity < 1 AND Unit_Name = 'liter/s' THEN Raw_Quantity *  1000 WHEN Raw_Quantity > 3.785 AND Unit_Name = 'liter/s' " _
                               & " THEN Raw_Quantity /  3.785   WHEN Raw_Quantity < 1 AND Unit_Name = 'gallon/s' THEN " _
                               & " Raw_Quantity *  3.785  WHEN Raw_Quantity < 1 AND Unit_Name = 'dozen/s' THEN Raw_Quantity * 12 WHEN Raw_Quantity >= 12 AND Unit_Name = 'piece/s' " _
                               & " THEN Raw_Quantity / 12 ELSE Raw_Quantity END) + 0,' ',CASE WHEN Unit_Name = 'gram/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'mG/s'  WHEN Unit_Name = 'kG/s' " _
                               & " AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'gram/s' WHEN Unit_Name = 'liter/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'mL/s' " _
                               & " WHEN Unit_Name = 'gallon/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'liter/s' WHEN Unit_Name = 'liter/s' AND " _
                               & " Raw_Expiration_Date.Raw_Quantity > 3.785 THEN 'gallon/s' WHEN Unit_Name = 'piece/s' AND  Raw_Expiration_Date.Raw_Quantity > 12   THEN 'dozen/s' " _
                               & " WHEN Unit_Name = 'dozen/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'piece/s' ELSE Unit_Name END,' = ',DATE_FORMAT(Raw_Expiration_Date,'%c/%d/%Y\n'" _
                               & " ) SEPARATOR '')  AS 'Raw_Expiration_Date'" _
                             & " from Raw_Expiration_Date  inner join Raw_Material_Table ON Raw_Expiration_Date.Raw_ID=Raw_Material_Table.Raw_ID inner join unit_table  " _
                             & " ON unit_table.Unit_ID = raw_expiration_date.Unit_ID  GROUP BY Raw_Material_Table.Raw_ID order by Raw_Name ASC LIMIT 50", cn)
            da.Fill(dt)
            Modall.DataGridView3.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub
    Public Sub filterRawMats100()

        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT CONCAT(UCASE(LEFT(Raw_Material_Table.Raw_Name,1)),LCASE(SUBSTRING(Raw_Material_Table.Raw_Name,2))) As Raw_Name, " _
                               & " CONCAT(CASE WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1000000 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mg/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1000000 , ' kG/s') " _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1000 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mg/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1000 , ' gram/s')" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1 , ' mG/s')" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1000 " _
                               & " THEN CASE WHEN (TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) >= 3.785 THEN" _
                               & " CONCAT((TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) / 3.785 , ' gallon/s') " _
                               & "  WHEN (TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) < 3.785 THEN" _
                               & " CONCAT((TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000), ' liter/s') END" _
                               & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1 , ' mL/s')" _
                               & " WHEN SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12  END)  >= 12 " _
                               & " THEN  CONCAT(TRUNCATE(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) / 12 ,3) , ' dozen/s')" _
                               & " WHEN SUM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) < 12 " _
                               & " THEN  CONCAT(TRIM(SUM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END)) / 1 , ' piece/s')" _
                               & " END " _
                               & ") AS 'QUANTITY',  " _
                               & " GROUP_CONCAT(TRIM(CASE WHEN Raw_Quantity < 1 AND Unit_Name = 'gram/s' THEN Raw_Quantity *  1000  WHEN Raw_Quantity < 1 AND Unit_Name = 'kG/s' THEN " _
                               & " Raw_Quantity *  1000 WHEN Raw_Quantity < 1 AND Unit_Name = 'liter/s' THEN Raw_Quantity *  1000 WHEN Raw_Quantity > 3.785 AND Unit_Name = 'liter/s' " _
                               & " THEN Raw_Quantity /  3.785   WHEN Raw_Quantity < 1 AND Unit_Name = 'gallon/s' THEN " _
                               & " Raw_Quantity *  3.785  WHEN Raw_Quantity < 1 AND Unit_Name = 'dozen/s' THEN Raw_Quantity * 12 WHEN Raw_Quantity >= 12 AND Unit_Name = 'piece/s' " _
                               & " THEN Raw_Quantity / 12 ELSE Raw_Quantity END) + 0,' ',CASE WHEN Unit_Name = 'gram/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'mG/s'  WHEN Unit_Name = 'kG/s' " _
                               & " AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'gram/s' WHEN Unit_Name = 'liter/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'mL/s' " _
                               & " WHEN Unit_Name = 'gallon/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'liter/s' WHEN Unit_Name = 'liter/s' AND " _
                               & " Raw_Expiration_Date.Raw_Quantity > 3.785 THEN 'gallon/s' WHEN Unit_Name = 'piece/s' AND  Raw_Expiration_Date.Raw_Quantity > 12   THEN 'dozen/s' " _
                               & " WHEN Unit_Name = 'dozen/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'piece/s' ELSE Unit_Name END,' = ',DATE_FORMAT(Raw_Expiration_Date,'%c/%d/%Y\n'" _
                               & " ) SEPARATOR '')  AS 'Raw_Expiration_Date'" _
                             & " from Raw_Expiration_Date  inner join Raw_Material_Table ON Raw_Expiration_Date.Raw_ID=Raw_Material_Table.Raw_ID inner join unit_table  " _
                             & " ON unit_table.Unit_ID = raw_expiration_date.Unit_ID  GROUP BY Raw_Material_Table.Raw_ID order by Raw_Name ASC LIMIT 100", cn)
            da.Fill(dt)
            Modall.DataGridView3.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contact Programmer About this Error, Thank You.")
        End Try
    End Sub

    Public Sub filterProdRawMats10()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT product_table.Product_Name,COALESCE(GROUP_CONCAT(TRIM(`Minus_Material_Every_Product`) + 0,' ',`Unit_Name`, ' of ',`Raw_Name`, ' at ',(CASE WHEN product_size.Size_Name = 'None' Then ' per pieces' When  product_size.Size_Name = 'Glass' Then ' per Glass' Else Concat(product_size.Size_Name, ' size ') END) ORDER BY product_size.Size_Name ASC SEPARATOR '\n'), '----')  AS 'CONSUME' " _
                                           & "from product_table  left join  `material_every_product` on product_table.Product_ID= material_every_product.Product_ID " _
                                           & "left join raw_material_table on raw_material_table.Raw_ID = material_every_product.Raw_ID left join unit_table " _
                                            & "on unit_table.Unit_ID = material_every_product.Unit_ID left join product_size " _
                                           & " on product_size.Size_ID = material_every_product.Size_ID where (product_table.Cat_ID != 12) != 0 GROUP by product_table.Product_Name ASC LIMIT 10", cn)

            da.Fill(dt)
            Modall.DataGridView2.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterProdRawMats25()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT product_table.Product_Name,COALESCE(GROUP_CONCAT(TRIM(`Minus_Material_Every_Product`) + 0,' ',`Unit_Name`, ' of ',`Raw_Name`, ' at ',(CASE WHEN product_size.Size_Name = 'None' Then ' per pieces' When  product_size.Size_Name = 'Glass' Then ' per Glass' Else Concat(product_size.Size_Name, ' size ') END) ORDER BY product_size.Size_Name ASC SEPARATOR '\n'), '----')  AS 'CONSUME' " _
                                           & "from product_table  left join  `material_every_product` on product_table.Product_ID= material_every_product.Product_ID " _
                                           & "left join raw_material_table on raw_material_table.Raw_ID = material_every_product.Raw_ID left join unit_table " _
                                            & "on unit_table.Unit_ID = material_every_product.Unit_ID left join product_size " _
                                           & " on product_size.Size_ID = material_every_product.Size_ID where (product_table.Cat_ID != 12) != 0 GROUP by product_table.Product_Name ASC LIMIT 25", cn)

            da.Fill(dt)
            Modall.DataGridView2.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterProdRawMats50()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT product_table.Product_Name,COALESCE(GROUP_CONCAT(TRIM(`Minus_Material_Every_Product`) + 0,' ',`Unit_Name`, ' of ',`Raw_Name`, ' at ',(CASE WHEN product_size.Size_Name = 'None' Then ' per pieces' When  product_size.Size_Name = 'Glass' Then ' per Glass' Else Concat(product_size.Size_Name, ' size ') END) ORDER BY product_size.Size_Name ASC SEPARATOR '\n'), '----')  AS 'CONSUME' " _
                                           & "from product_table  left join  `material_every_product` on product_table.Product_ID= material_every_product.Product_ID " _
                                           & "left join raw_material_table on raw_material_table.Raw_ID = material_every_product.Raw_ID left join unit_table " _
                                            & "on unit_table.Unit_ID = material_every_product.Unit_ID left join product_size " _
                                           & " on product_size.Size_ID = material_every_product.Size_ID where (product_table.Cat_ID != 12) != 0 GROUP by product_table.Product_Name ASC LIMIT 50", cn)

            da.Fill(dt)
            Modall.DataGridView2.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub
    Public Sub filterProdRawMats100()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT product_table.Product_Name,COALESCE(GROUP_CONCAT(TRIM(`Minus_Material_Every_Product`) + 0,' ',`Unit_Name`, ' of ',`Raw_Name`, ' at ',(CASE WHEN product_size.Size_Name = 'None' Then ' per pieces' When  product_size.Size_Name = 'Glass' Then ' per Glass' Else Concat(product_size.Size_Name, ' size ') END) ORDER BY product_size.Size_Name ASC SEPARATOR '\n'), '----')  AS 'CONSUME' " _
                                           & "from product_table  left join  `material_every_product` on product_table.Product_ID= material_every_product.Product_ID " _
                                           & "left join raw_material_table on raw_material_table.Raw_ID = material_every_product.Raw_ID left join unit_table " _
                                            & "on unit_table.Unit_ID = material_every_product.Unit_ID left join product_size " _
                                           & " on product_size.Size_ID = material_every_product.Size_ID where (product_table.Cat_ID != 12) != 0 GROUP by product_table.Product_Name ASC LIMIT 100", cn)

            da.Fill(dt)
            Modall.DataGridView2.DataSource = dt
            da.Dispose()
            da = Nothing
            dt.Dispose()
            dt = Nothing
            cn.Dispose()
            cn = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this Error. Thank You.")
        End Try
    End Sub



End Module
