Imports MySql.Data.MySqlClient

Public Class uc_archives
    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Private Sub lbl_load_Click(sender As System.Object, e As System.EventArgs) Handles lbl_load.Click
        dgv_datas.DataSource = GetDataTable()
        pnl_cover.Visible = False
    End Sub

    Private Function GetDataTable()
        dgv_datas.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        dgv_datas.MultiSelect = False

        Table.Columns.Add("Id", Type.GetType("System.String"))
        Table.Columns.Add("ReferenceKeyName", Type.GetType("System.String"))
        Table.Columns.Add("Reference", Type.GetType("System.String"))
        Table.Columns.Add("Deleted at", Type.GetType("System.String"))
        Dim select_btn As New DataGridViewButtonColumn
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.archives order by deleted_at desc "
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Table.Rows.Add(NewReader("id"), NewReader("reference_keyname"), NewReader("reference"), NewReader("deleted_at"))
        End While
        MysqlConn.Close()

        select_btn.Text = "Select"
        select_btn.UseColumnTextForButtonValue = True
        select_btn.Width = 10
        dgv_datas.Columns(0).Visible = False
        dgv_datas.Columns.Add(select_btn)

        Return Table
    End Function
End Class
