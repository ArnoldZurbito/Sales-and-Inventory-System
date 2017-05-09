Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.OleDb
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Sales
    'Private Sub filter_dates()
    '    Dim objcr As New Sales_Report
    '    Dim da As New MySqlDataAdapter("SELECT product_table.Product_Name, CONCAT(Order_Quantity , CASE   WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 16) or product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 6) or product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 7) or  product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 8) THEN ' piece/s' WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 9)  THEN ' Glass/es'  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 10)  THEN ' Pitcher/s'  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 11)  THEN ' Cup/s'  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 1) or   product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 2) or  product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 3) or  product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 4) or product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 5) THEN ' box/es'   WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 12) or  product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 13) or  product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 14) THEN ' bottle/s'   WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 15) THEN ' can/s'  END, ' (',(Case when product_size.Size_Name = 'None' Then 'piece/s'  Else   Concat(product_size.Size_Name, ' size') End ) , ') ') AS 'QUANTITY',Concat('P ',Price) As 'Price', DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As Order_Date FROM order_table inner join product_table on order_table.Product_ID = product_table.Product_ID  inner JOIN product_size on order_table.Size_ID = product_size.Size_ID  where   order_table.Order_Date >='" & Format(Modall.DateTimePicker2.Value, "yyyy-MM-dd hh:mm:ss") & "' and  order_table.Order_Date <='" & Format(Modall.DateTimePicker2.Value, "yyyy-MM-dd hh:mm:ss") & "'  Order by DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p')  DESC", objconn)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    objcr.SetDataSource(dt)
    '    Dim CRPath As String = System.IO.Path.GetDirectoryName(Application.StartupPath) & "\..\..\ADMIN\"
    '    objcr.Load(CRPath & "Sales_Report.rpt")
    '    CrystalReportViewer1.ReportSource = objcr
    '    CrystalReportViewer1.RefreshReport()
    'End Sub
    'Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    'filter_dates()
    '    Dim ParamCollection As New CrystalDecisions.Shared.ParameterValues
    '    mReport = New Sales_Report
    '    'mReport.Load(Application.StartupPath & "Sales_Report.rpt")
    '    ' Call MySQLCon()

    '    'Dim reportPath As String = "Sales_Report.rpt"
    '    'mReport.Load(reportPath)
    '    'Dim reportPath As String = System.IO.Path.GetDirectoryName(Application.StartupPath) & "\..\..\ADMIN\Sales_Report.rpt"
    '    'mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
    '    'mReport.Load(reportPath)
    '    Dim reportPath As String = System.IO.Path.GetDirectoryName(Application.StartupPath) & "\..\..\ADMIN\"
    '    mReport.Load(reportPath & "Sales_Report.rpt")
    '    mReport.SetDataSource(ExecuteSQLQuery(Rpt_SqlStr))
    '    ParamCollection.Add(ParamDVFrom)
    '    mReport.DataDefinition.ParameterFields("datefroms").ApplyCurrentValues(ParamCollection)

    '    ParamCollection.Add(ParamDVTo)
    '    mReport.DataDefinition.ParameterFields("datetos").ApplyCurrentValues(ParamCollection)

    '    'ParamCollection.Add(_USER)
    '    'mReport.DataDefinition.ParameterFields("users").ApplyCurrentValues(ParamCollection)

    '    CrystalReportViewer1.ReportSource = mReport
    '    CrystalReportViewer1.Refresh()
    '    'CrystalReportViewer1.ParameterFieldInfo.Item("txttest").DefaultValues = tempValues
    '    'Me.MdiParent = MDIMain
    'End Sub
    Public FirstDate As Date
    Public SecondDate As Date
    Public Sub GetReport()
        Dim rpt As New Sales_Report
        ' rpt.Load(Application.StartupPath & "C:\Users\asus\Desktop\COMPUTERIZED INVENTORY SYSTEM OF RED CHEESE PIZZA\ADMIN\Sales_Report.rpt")
        Dim CRPath As String = System.IO.Path.GetDirectoryName(Application.StartupPath) & "\..\..\ADMIN\"
        rpt.Load(CRPath & "Sales_Report.rpt")
        Dim pfields As New ParameterFields
        'if (order_table.Order_Date) >= (?txtfrom) and (order_table.Order_Date) <= (?txtto) then true
        ' DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As 'Order_Date' 
        Dim pfield As New ParameterField
        Dim pdiscrete As New ParameterDiscreteValue

        Dim pfield1 As New ParameterField
        Dim pdiscrete1 As New ParameterDiscreteValue

        pfield.Name = "datefroms"
        pdiscrete.Value = FirstDate
        pfield.CurrentValues.Add(pdiscrete)
        pfields.Add(pfield)

        pfield1.Name = "datetos"
        pdiscrete1.Value = SecondDate
        pfield1.CurrentValues.Add(pdiscrete1)
        pfields.Add(pfield1)


        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pfields
    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetReport()

    End Sub
End Class