Imports MySql.Data.MySqlClient

Public Class Form2

    Dim cmd As New MySqlCommand
    Dim result As Integer
    Dim fullname As String
    Dim username As String
    Dim password As String


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        fullname = txtFullname.Text
        username = txtUname.Text
        password = txtPassword.Text
        Try
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO employee(" & "fullName, uName, pwd)" & "VALUES" & "('" & fullname & "','" & username & "','" & password & "')"

                'execute insert query

                result = .ExecuteNonQuery
                If result > 0 Then
                    MsgBox("Record Inserted Successfully!")
                    txtFullname.Clear()
                    txtPassword.Clear()
                    txtUname.Clear()
                Else
                    MsgBox("Insertion Failed.")
                End If

            End With
        Catch naur As Exception
            MsgBox(naur.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide() 'hide form2
    End Sub
End Class