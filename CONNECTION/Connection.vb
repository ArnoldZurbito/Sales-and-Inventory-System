Imports MySql.Data.MySqlClient

Module Connection
    Public objconn As MySqlConnection = New MySqlConnection("server=localhost; username=root; password=; database=red_cheese_pizza_database")

    'Public objcmd As New MySqlCommand
    'Public strsql, strreportname As String
    'Public acsds As New DataSet
    'Public objD:\I.T WORKS\3rd Year\1st Semester\SADNESS\COMPUTERIZED INVENTORY SYSTEM OF RED CHEESE PIZZA\CONNECTION\Connection.vbda As New MySqlDataAdapter
    'Public objdr As MySqlDataReader
    'Public objdt As New DataTable

    'Public Function MySQLCon() As MySqlConnection
    '    Return New MySqlConnection("server=localhost; username=root; password=; database=red_cheese_pizza_database; Convert Zero Datetime=True")
    'End Function

    'Public objconn As MySqlConnection = MySQLCon()




    Public Function MySQLCon() As MySqlConnection
        Return New MySqlConnection("server=localhost; username=root; password=; database=red_cheese_pizza_database")
    End Function

    Public Function MySQLCon2() As MySqlConnection
        Return New MySqlConnection("server = localhost; username = root; password = ; database = robel; Convert Zero Datetime=True")
    End Function

    Public CONNECTION As MySqlConnection = MySQLCon()
    Public CONNECTION2 As MySqlConnection = MySQLCon2()




End Module
