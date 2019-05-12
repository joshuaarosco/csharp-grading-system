Imports MySql.Data.MySqlClient

Public Class uc_edit_course

    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Public Property CourseId As String

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.Visible = False
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        If txt_course.Text = "" Or txt_course_code.Text = "" Or txt_year_level.Text = "" Then
            MessageBox.Show(CourseId)
        Else
            update_data()
            Me.Visible = False
        End If
    End Sub

    Private Sub update_data()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update grading_system.courses set course_code = '" & txt_course_code.Text & "' , course_name = '" & txt_course.Text & "' , year_levels = '" & txt_year_level.Text & "' , created_at = '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "' where id = '" & CourseId & "' "
            MyCommand = New MySqlCommand(Query, MysqlConn)
            Reader = MyCommand.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class
