Imports MySql.Data.MySqlClient

Public Class uc_teachers
    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Private Sub btn_create_Click(sender As System.Object, e As System.EventArgs) Handles btn_create.Click
        uc_create_teacher.Visible = True
    End Sub

    Private Sub uc_teachers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        uc_create_teacher.Visible = False
    End Sub

    Private Function GetDataTable()
        dgv_datas.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        dgv_datas.MultiSelect = False

        Dim select_btn As New DataGridViewButtonColumn
        Table.Columns.Add("Id", Type.GetType("System.String"))
        Table.Columns.Add("IdNumber", Type.GetType("System.String"))
        Table.Columns.Add("Name", Type.GetType("System.String"))
        Table.Columns.Add("Created At", Type.GetType("System.String"))
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
End Class
