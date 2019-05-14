Imports MySql.Data.MySqlClient

Public Class uc_teachers
    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Private Sub btn_create_Click(sender As System.Object, e As System.EventArgs) Handles btn_create.Click
        uc_create_teacher.Visible = True
        uc_edit_teacher.Visible = False
        pnl_refresh.Visible = True
        pnl_action.Visible = False
        refresh_table()
    End Sub

    Private Sub uc_teachers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        uc_create_teacher.Visible = False
        uc_edit_teacher.Visible = False
        pnl_action.Visible = False
        pnl_refresh.Visible = False
    End Sub

    Private Function GetDataTable()
        dgv_datas.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        dgv_datas.MultiSelect = False

        Dim select_btn As New DataGridViewButtonColumn
        Table.Columns.Add("Id", Type.GetType("System.String"))
        Table.Columns.Add("IdNumber", Type.GetType("System.String"))
        Table.Columns.Add("Name", Type.GetType("System.String"))
        Table.Columns.Add("Last Update", Type.GetType("System.String"))
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.user where user_type = 'teacher' order by lname "
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Table.Rows.Add(NewReader("id"), NewReader("id_number"), NewReader("lname") + ", " + NewReader("fname"), NewReader("created_at"))
        End While
        MysqlConn.Close()

        select_btn.Text = "Select"
        select_btn.UseColumnTextForButtonValue = True
        select_btn.Width = 10
        dgv_datas.Columns(0).Visible = False
        dgv_datas.Columns.Add(select_btn)

        Return Table
    End Function

    Private Sub lbl_load_Click(sender As System.Object, e As System.EventArgs) Handles lbl_load.Click
        dgv_datas.DataSource = GetDataTable()
        pnl_cover.Visible = False
    End Sub

    Private Sub txt_search_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_search.TextChanged
        search()
    End Sub

    Sub search()
        Dim data_view As New DataView(table)
        data_view.RowFilter = String.Format("IdNumber Like '%{0}%'", txt_search.Text) + " OR " + String.Format("Name Like '%{0}%'", txt_search.Text)
        Console.WriteLine(data_view.RowFilter)
        dgv_datas.DataSource = data_view
    End Sub

    Private Sub lbl_refresh_Click(sender As System.Object, e As System.EventArgs) Handles lbl_refresh.Click
        pnl_refresh.Visible = False
        refresh_table()
    End Sub

    Private Sub refresh_table()
        dgv_datas.DataSource.Clear()
        Dim select_btn As New DataGridViewButtonColumn
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.user where user_type = 'teacher' order by lname "
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Table.Rows.Add(NewReader("id"), NewReader("id_number"), NewReader("lname") + ", " + NewReader("fname"), NewReader("created_at"))
        End While
        MysqlConn.Close()

        select_btn.Text = "Select"
        select_btn.UseColumnTextForButtonValue = True
        select_btn.Width = 10
        dgv_datas.Columns(0).Visible = False
    End Sub

    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click

    End Sub

    Private Sub btn_edit_Click(sender As System.Object, e As System.EventArgs) Handles btn_edit.Click
        uc_edit_teacher.Visible = True
        uc_create_teacher.Visible = False

        pnl_refresh.Visible = True
        pnl_action.Visible = False
    End Sub

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        pnl_action.Visible = False
    End Sub

    Private Sub dgv_datas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_datas.CellContentClick
        If (e.RowIndex > -1) Then
            'Console.WriteLine(e.RowIndex)
            Dim teacher_id As Object = dgv_datas.Rows(e.RowIndex).Cells(0).Value

            Console.WriteLine("Im the value : " + teacher_id)
            If IsDBNull(teacher_id) Then
                pnl_action.Visible = False
            Else
                select_teacher(teacher_id)
                pnl_action.Visible = True
            End If
        End If
    End Sub

    Private Sub select_teacher(ByVal teacher_id)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.user where user_type = 'teacher' and id = '" & teacher_id & "'"
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            uc_edit_teacher.TeacherId = NewReader("id")
            uc_edit_teacher.txt_id_number.Text = NewReader("id_number")
            uc_edit_teacher.txt_fname.Text = NewReader("fname")
            uc_edit_teacher.txt_lname.Text = NewReader("lname")
            uc_edit_teacher.txt_username.Text = NewReader("username")
            uc_edit_teacher.txt_password.Text = NewReader("password")
        End While
        MysqlConn.Close()
    End Sub
End Class
