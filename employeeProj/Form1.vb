Imports MySql.Data.MySqlClient

Public Class Form1
    Dim sqlQuery As String
    Dim da As MySqlDataAdapter ' bridge to mysqlserver
    Dim dt As DataTable 'temporary reposi
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Try
            sqlQuery = "SELECT * FROM employee"
            da = New MySqlDataAdapter(sqlQuery, conn)
            dt = New DataTable
            'fill the data from mysql table
            da.Fill(dt)
            'set the source to data grid view
            dataRecord.DataSource = dt
            dataRecord.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            conn.Close()
        Catch manye As Exception
            MsgBox(manye.Message)
        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
