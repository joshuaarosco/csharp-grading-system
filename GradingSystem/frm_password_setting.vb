Imports MySql.Data.MySqlClient

Public Class frm_password_setting

    Public Property UserId As String

    Dim MysqlConn As MySqlConnection
    Dim Command As MySqlCommand
    Dim Query As String
    Dim Reader As MySqlDataReader

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        If txt_current_password.Text = "" Or txt_new_password.Text = "" Or txt_confirm_password.Text = "" Then
            MessageBox.Show("All field is required")
        Else
            If txt_current_password.Text = get_current_password() Then
                If txt_new_password.Text = txt_confirm_password.Text Then
                    update_password()
                    MessageBox.Show("Password successfully updated")
                    Me.Close()
                Else
                    MessageBox.Show("Please confirm your password")
                End If
            Else
                MessageBox.Show("Please enter your current password")
            End If
        End If
    End Sub

    Private Function get_current_password()
        Dim current_password As String

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        Try
            MysqlConn.Open()
            Query = "select * from grading_system.user where id = '" & UserId & "'"
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            Dim count As Integer
            count = 0

            While Reader.Read
                count = count + 1
            End While

            If count = 1 Then
                current_password = Reader("password")
            Else
                MessageBox.Show("User not found.")
            End If

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Return current_password

    End Function

    Private Sub update_password()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        Try
            Query = "update grading_system.user set password = '" & txt_new_password.Text & "' WHERE id ='" & UserId & "' "
            Command = New MySqlCommand(Query, MysqlConn)
            Reader = Command.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub lbl_close_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub
End Class