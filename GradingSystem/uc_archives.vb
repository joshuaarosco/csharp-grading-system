Imports MySql.Data.MySqlClient

Public Class uc_archives
    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Dim ArchiveId As String

    Private Sub lbl_load_Click(sender As System.Object, e As System.EventArgs) Handles lbl_load.Click
        dgv_datas.DataSource = GetDataTable()
        pnl_cover.Visible = False
        pb_refresh.Visible = True
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
        MyQuery = "select * from grading_system.archives where is_restored = 'no' order by deleted_at desc "
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

    Private Sub txt_search_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_search.TextChanged

    End Sub

    Private Sub dgv_datas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_datas.CellContentClick
        If (e.RowIndex > -1) Then
            ArchiveId = dgv_datas.Rows(e.RowIndex).Cells(0).Value
            Console.WriteLine("Im the value : " + ArchiveId)
            If IsDBNull(ArchiveId) Then
                pnl_action.Visible = False
            Else
                pnl_action.Visible = True
            End If
        End If
    End Sub

    Private Sub uc_archives_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pnl_action.Visible = False
        pb_refresh.Visible = False
    End Sub

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        pnl_action.Visible = False
    End Sub

    Private Sub btn_restore_Click(sender As System.Object, e As System.EventArgs) Handles btn_restore.Click

        Dim result As Integer = MessageBox.Show("You are about to restore a record, are you sure you want to proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            restore_data()
            MessageBox.Show("Record successfully Restore!")
        End If
    End Sub

    Private Sub refresh_table()
        dgv_datas.DataSource.Clear()
        Dim select_btn As New DataGridViewButtonColumn
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.archives where is_restored = 'no' order by deleted_at desc "
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
    End Sub

    Private Sub restore_data()
        Dim reference As Char
        Dim reference_id As Char

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.archives where id = '" & ArchiveId & "' order by deleted_at desc "
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            reference_id = NewReader("reference_id")
            reference = NewReader("reference")
        End While
        MysqlConn.Close()
        restored(reference_id, reference)
        refresh_table()
    End Sub

    Private Sub restored(ByVal reference_id, ByVal reference)
        Try
            Select Case reference
                Case "courses"
                    MysqlConn.Open()
                    MyQuery = "update grading_system.courses set is_deleted = 'no' where id = '" & reference_id & "' "
                    MyCommand = New MySqlCommand(MyQuery, MysqlConn)
                    NewReader = MyCommand.ExecuteReader
                    MysqlConn.Close()
                Case "sections"
                    MysqlConn.Open()
                    MyQuery = "update grading_system.sections set is_deleted = 'no' where id = '" & reference_id & "' "
                    MyCommand = New MySqlCommand(MyQuery, MysqlConn)
                    NewReader = MyCommand.ExecuteReader
                    MysqlConn.Close()
                Case "subjects"
                    MysqlConn.Open()
                    MyQuery = "update grading_system.subjects set is_deleted = 'no' where id = '" & reference_id & "' "
                    MyCommand = New MySqlCommand(MyQuery, MysqlConn)
                    NewReader = MyCommand.ExecuteReader
                    MysqlConn.Close()
                Case Else
                    MysqlConn.Open()
                    MyQuery = "update grading_system.user set is_deleted = 'no' where id = '" & reference_id & "' "
                    MyCommand = New MySqlCommand(MyQuery, MysqlConn)
                    NewReader = MyCommand.ExecuteReader
                    MysqlConn.Close()
            End Select
            MysqlConn.Open()
            MyQuery = "update grading_system.archives set is_restored = 'yes' where id = '" & ArchiveId & "' "
            MyCommand = New MySqlCommand(MyQuery, MysqlConn)
            NewReader = MyCommand.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub pb_refresh_Click(sender As System.Object, e As System.EventArgs) Handles pb_refresh.Click
        refresh_table()
    End Sub
End Class
