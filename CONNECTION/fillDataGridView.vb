Imports MySql.Data.MySqlClient
Module fillDataGridView
    Public pesos As String = "\u20B1"

    Public Sub fillProdukto()
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
                                           & " on product_size.Size_ID = material_every_product.Size_ID where (product_table.Cat_ID != 12) != 0 GROUP by product_table.Product_Name ASC", cn)

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
    Public Sub fillExpired()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("select  Raw_Name,CONCAT(TRIM(`Raw_Quantity`) + 0, ' ',`Unit_Name`) As 'QUANTITY',DATE_FORMAT(Raw_Expiration_Date,'%m/%d/%Y') AS 'EXPIRED_PROD' from raw_expiration_date inner join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID inner join raw_material_table ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where raw_expiration_date.Raw_Expiration_Date <= DATE_ADD(DATE(now()), INTERVAL 3 day) ORDER by raw_material_table.Raw_Name ASC", cn)
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
    Public Sub fillCritical()
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
                                           & "AND unit_table.Unit_Name = 'kilo/s'  OR raw_quantity < 1 AND unit_table.Unit_Name = 'liter/s' GROUP BY raw_material_table.Raw_Name ASC", cn)
            '     SELECT `Raw_Name` AS 'RAW_MATERIAL/S', CONCAT(TRIM(SUM(`Raw_Quantity`)) + 0, ' ',`Unit_Name`) AS 'QUANTITY_LEFT' FROM raw_expiration_date INNER Join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID INNER Join raw_material_table ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID WHERE (SELECT SUM(raw_quantity) < 3 where unit_table.Unit_Name = 'kG/s' OR unit_table.Unit_Name = 'mG/s' OR unit_table.Unit_Name = 'gram/s') GROUP BY raw_material_table.Raw_Name ASC
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

    Public Sub FillRawMats()

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
                             & " ON unit_table.Unit_ID = raw_expiration_date.Unit_ID  GROUP BY Raw_Material_Table.Raw_ID order by Raw_Name ASC ", cn)
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
    Public Sub fillProductQuantity()
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
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 8 OR category.Cat_ID = 9 Then CONCAT(product_quantity.Quantity, ' per serving') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 2 And product_size.Size_Name = 'Platter' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Platters' Else ' Platter' END) ) " _
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
                                            & " group by product_table.Product_Name ASC", cn)
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
    Public Sub fillAvailableProds()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1  or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                          & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12 oz.)' Else ' bottle (12 oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', product_quantity.Price SEPARATOR '\n') As 'Price' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID " _
                                            & " inner JOIN category on product_table.Cat_ID =category.Cat_ID where category.Cat_Name = '" & Modall.cmbcategory.Text & "' group by product_table.Product_Name ASC", cn)
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

    Public Sub fillAvailableProd()

        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT product_table.Product_Name,(CASE WHEN SUM(product_quantity.Quantity) > 0 THEN " _
                                           & " SUM(product_quantity.Quantity) ELSE NULL End) AS 'QUANTITY',COALESCE(GROUP_CONCAT( " _
                                           & " (CASE WHEN category.Cat_ID = 1 OR category.Cat_ID = 3 OR category.Cat_ID = 5 OR " _
                                           & " category.Cat_ID = 10 THEN CONCAT(product_quantity.Quantity,' pieces') WHEN " _
                                           & " category.Cat_ID = 6 THEN CONCAT(product_quantity.Quantity,' Solo') WHEN " _
                                           & " category.Cat_ID = 8 OR category.Cat_ID = 9 THEN CONCAT(product_quantity.Quantity, " _
                                           & " ' per serving') WHEN category.Cat_ID = 11 AND product_size.Size_Name = 'Glass' " _
                                           & " THEN CONCAT(product_quantity.Quantity,(CASE WHEN product_quantity.Quantity > 1 " _
                                           & " THEN ' Glasses' ELSE ' Glass' End)) WHEN category.Cat_ID = 2 AND product_size.Size_Name " _
                                           & " = 'Platter' THEN CONCAT(product_quantity.Quantity,(CASE WHEN product_quantity.Quantity > 1 " _
                                           & " THEN ' Platters' ELSE ' Platter' End)) WHEN category.Cat_ID = 12 AND " _
                                           & " product_size.Size_Name = 'Can' THEN CONCAT(product_quantity.Quantity, " _
                                           & " (CASE WHEN product_quantity.Quantity > 1 THEN ' bottles (Cans)' ELSE ' bottle (Can)' " _
                                           & " End )) WHEN category.Cat_ID = 12 AND product_size.Size_Name = '12 oz.' THEN CONCAT( " _
                                           & " product_quantity.Quantity,(CASE WHEN product_quantity.Quantity > 1 THEN ' bottles (12.oz.)' " _
                                           & " ELSE ' bottle (12.oz.)' End)) WHEN category.Cat_ID = 12 AND product_size.Size_Name " _
                                           & " = '1.5 Liters' THEN CONCAT(product_quantity.Quantity, " _
                                           & " (CASE WHEN product_quantity.Quantity > 1 THEN ' bottles (1.5 liters)' " _
                                           & " ELSE ' bottle (1.5 liters)' End )) WHEN category.Cat_ID = 12 AND " _
                                           & " product_size.Size_Name = 'Glass' THEN CONCAT(product_quantity.Quantity, ( " _
                                           & " CASE WHEN product_quantity.Quantity > 1 THEN ' Glasses' ELSE ' Glass' End)) " _
                                           & " WHEN category.Cat_ID = 12 AND product_size.Size_Name = 'Pitcher' THEN CONCAT( " _
                                           & " product_quantity.Quantity, (CASE WHEN product_quantity.Quantity > 1 THEN " _
                                           & " ' Pitchers' ELSE ' Pitcher' End)) WHEN category.Cat_ID = 12 AND product_size.Size_Name = 'Cup' " _
                                           & " THEN CONCAT(product_quantity.Quantity,(CASE WHEN product_quantity.Quantity > 1 THEN ' Cups' " _
                                           & " ELSE ' Cup' End)) WHEN category.Cat_ID = 12 AND product_size.Size_Name = 'Small' THEN CONCAT( " _
                                           & " product_quantity.Quantity,(CASE WHEN product_quantity.Quantity > 1 THEN ' pieces Small Size' " _
                                           & " ELSE ' piece Small size' End)) WHEN category.Cat_ID = 12 AND product_size.Size_Name = 'Medium' " _
                                           & " THEN CONCAT(product_quantity.Quantity,(CASE WHEN product_quantity.Quantity > 1 THEN " _
                                           & " ' pieces Medium Size' ELSE ' piece Medium size' End)) ELSE(CASE " _
                                           & " WHEN product_quantity.Quantity > 0 THEN CONCAT(product_quantity.Quantity,' box/es ', " _
                                           & " product_size.Size_Name,' size') ELSE CONCAT('Not Available (',product_size.Size_Name, " _
                                           & " ' size)') End) End) SEPARATOR '\n'),' Not Available') AS 'SIZE',GROUP_CONCAT( " _
                                           & " 'P ',TRIM(product_quantity.Price) + 0 SEPARATOR '\n' ) AS 'Price' FROM product_quantity " _
                                           & " Right Join product_table ON product_quantity.Product_ID = product_table.Product_ID " _
                                           & " Left Join product_size ON product_quantity.Size_ID = product_size.size_ID  " _
                                           & " INNER Join category ON product_table.Cat_ID = category.Cat_ID GROUP BY product_table.Product_Name Asc", cn)
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
    Public Sub fillOrderProd()
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
                                & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 15) THEN ' can/s'  END, ' (',(Case when product_size.Size_Name = 'None' Then 'piece/s'  Else   Concat(product_size.Size_Name, ' size') End ) , ') ') AS 'QUANTITY',Concat('P ',Price) As 'Price', DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As 'Order_Date' FROM order_table inner join product_table on order_table.Product_ID = product_table.Product_ID  inner JOIN product_size on order_table.Size_ID = product_size.Size_ID  Order by DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') DESC", cn)

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

    Public Sub fillLogRec()
        Dim StrCon As String = "server=localhost;user id=root; database=red_cheese_pizza_database"
        Dim cn As New MySqlConnection
        Try
            With cn
                .ConnectionString = StrCon
                .Open()
            End With
            Dim dt As New DataTable
            Dim da As New MySqlDataAdapter("SELECT DATE_FORMAT(Log_Date,'%m/%d/%Y') As 'Log_Dates', GROUP_CONCAT(logs.Log_View, ' ', DATE_FORMAT(logs.Log_Date,'%h:%i %p') SEPARATOR '\n') As 'Log_User' " _
                                           & " from logs INNER JOIN user_account on logs.User_Company_ID = user_account.User_Company_ID GROUP BY  DATE_FORMAT(logs.Log_Date,'%m/%d/%Y') ORDER BY DATE_FORMAT(logs.Log_Date,'%m/%d/%Y')  DESC", cn)
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
    Public Sub searchcmb()
        objdt = New DataTable
        objda = New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3 or category.Cat_ID = 4 or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12 oz.)' Else ' bottle (12 oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Price' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID inner JOIN category on product_table.Cat_ID = (Select Cat_ID from " _
                                            & " category where Cat_Name = '" & Modall.cmbcategory.Text & "') AND category.Cat_ID = (Select Cat_ID from category where Cat_Name = '" & Modall.cmbcategory.Text & "')  where    product_table.Product_Name like '%" & Modall.txtAvailableProdSearch.Text & "%' OR product_size.Size_Name like '%" & Modall.txtAvailableProdSearch.Text & "%' OR product_quantity.Quantity like '%" & Modall.txtAvailableProdSearch.Text & "%'    " _
                                            & " group by product_table.Product_Name ASC", objconn)
        objda.Fill(objdt)
        Modall.DataGridView8.DataSource = objdt
    End Sub
    Public Sub searchcmb1()
        objdt = New DataTable
        objda = New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                            & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3 or category.Cat_ID = 4 or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                            & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                            & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12 oz.)' Else ' bottle (12 oz.)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                            & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                            & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                            & " Group_Concat('P ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Price' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID inner JOIN category on product_table.Cat_ID =category.Cat_ID where  Product_Name like '%" & Modall.txtAvailableProdSearch.Text & "%' OR Size_Name like '%" & Modall.txtAvailableProdSearch.Text & "%' OR Quantity like '%" & Modall.txtAvailableProdSearch.Text & "%'  " _
                                            & "  group by product_table.Product_Name ASC", objconn)
        objda.Fill(objdt)
        Modall.DataGridView8.DataSource = objdt
    End Sub
End Module
