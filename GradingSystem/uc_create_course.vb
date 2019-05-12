Imports MySql.Data.MySqlClient

Public Class uc_create_course
    Dim MysqlConn As MySqlConnection
    Dim MyCommand As MySqlCommand

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.Visible = False
    End Sub

    Private Sub btn_save_Click(sender As System.Object, e As System.EventArgs) Handles btn_save.Click
        If txt_course.Text = "" Or txt_course_code.Text = "" Or txt_year_level.Text = "" Then
            MessageBox.Show("All field is required!")
        Else
            create()
            Me.Visible = False
            clear()
        End If
    End Sub

    Private Sub create()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into grading_system.courses (course_code,course_name,year_levels,created_at) values ('" & txt_course_code.Text & "','" & txt_course.Text & "','" & txt_year_level.Text & "', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
            MyCommand = New MySqlCommand(Query, MysqlConn)
            Reader = MyCommand.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clear()
        txt_course.Text = ""
        txt_course_code.Text = ""
        txt_year_level.Text = ""
    End Sub

End Class
