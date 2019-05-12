Imports MySql.Data.MySqlClient

Public Class uc_create_teacher
    Dim MysqlConn As MySqlConnection
    Dim MyCommand As MySqlCommand
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.Visible = False
    End Sub

    Private Sub btn_save_Click(sender As System.Object, e As System.EventArgs) Handles btn_save.Click
        create()
        Me.Visible = False
        clear()
    End Sub

    Private Sub create()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into grading_system.user (id_number,fname,lname,username,password,user_type,created_at) values ('" & txt_id_number.Text & "','" & txt_fname.Text & "','" & txt_lname.Text & "','" & txt_username.Text & "','" & txt_password.Text & "','teacher', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
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
        txt_id_number.Text() = ""
        txt_fname.Text() = ""
        txt_lname.Text() = ""
        txt_username.Text() = ""
        txt_password.Text() = ""
    End Sub
End Class
