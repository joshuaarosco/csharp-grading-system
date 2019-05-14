Imports MySql.Data.MySqlClient

Public Class uc_edit_teacher

    Dim MysqlConn As MySqlConnection
    Dim MyCommand As MySqlCommand
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Public Property TeacherId As String

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.Visible = False
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        update_data()
        Me.Visible = False
    End Sub

    Private Sub update_data()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update grading_system.user set id_number = '" & txt_id_number.Text & "' , fname = '" & txt_fname.Text & "' , lname = '" & txt_lname.Text & "' , username = '" & txt_username.Text & "' , password = '" & txt_password.Text & "' , created_at = '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "' where id = '" & TeacherId & "'"
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
