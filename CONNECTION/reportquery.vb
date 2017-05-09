Imports MySql.Data.MySqlClient

Module reportquery
    'Public objconn As MySqlConnection = New MySqlConnection("server=localhost;user id=root; database=red_cheese_pizza_database")
    'Public SQL As String
    'Public objcmd As New MySqlCommand
    'Public strsql, strreportname As String
    'Public objds As New DataSet
    'Public objda As New MySqlDataAdapter
    'Public objdr As MySqlDataReader


    Public Sub reports(ByVal SQL As String, ByVal RPTNAME As String, ByVal CrystalRpt As Object)
        Dim rpt As New Sales_Report
        Try
            objconn.Open()

            Dim reportname As String
            With objcmd
                .Connection = objconn
                .CommandText = SQL

            End With

            objds = New DataSet
            objda = New MySqlDataAdapter(SQL, objconn)
            objda.Fill(objds)

            reportname = RPTNAME

            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            'Dim strReportPath As String
            'strReportPath = Application.StartupPath & "\reports\" & reportname & ".rpt"

            '  strReportPath = System.IO.Path.GetDirectoryName(Application.StartupPath) & "\..\..\ADMIN\" & reportname & ".rpt"
            ' rpt.Load(CRPath & "Sales_Report.rpt")
            Dim CRPath As String = System.IO.Path.GetDirectoryName(Application.StartupPath) & "\..\..\ADMIN\"
            rpt.Load(CRPath & "Sales_Report.rpt")

            Sales.CrystalReportViewer1.ReportSource = rpt
            'With reportdoc
            '    .Load(strReportPath)
            '    .SetDataSource(objds.Tables(0))

            'End With

            'With CrystalRpt
            '    .showRefreshButton = False
            '    .showCloseButton = False
            '    .reportSource = reportdoc

            'End With

        Catch ex As Exception
            MessageBox.Show(ex.Message & " reports module")

        End Try
        objconn.Close()
        objda.Dispose()

    End Sub

End Module
