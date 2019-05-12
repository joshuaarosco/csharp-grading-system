Imports MySql.Data.MySqlClient

Public Class frm_login

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim ID As String

    Private Sub btn_login_Click(sender As System.Object, e As System.EventArgs) Handles btn_login.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from grading_system.user where username = '" & txt_username.Text & "' and password = '" & txt_password.Text & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            Dim count As Integer
            count = 0

            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                Dim frm = New frm_dashboard()
                frm.UserId = Reader("id")
                frm.UserType = Reader("user_type")
                frm.UserFullName = Reader("fname") + " " + Reader("lname")

                If Reader("user_type") = "student" Then
                    frm.UserCourse = Reader("course")
                    frm.UserYearLevel = Reader("year_level")
                    frm.UserSchoolYear = Reader("school_year")
                End If

                frm.UserType = Reader("user_type")
                frm.Show()

                Me.Hide()
            Else
                MessageBox.Show("Wrong username or password.")
            End If

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

End Class
