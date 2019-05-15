Imports MySql.Data.MySqlClient

Public Class uc_courses
    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Dim CourseId As String
    Dim CourseCode As String
    Dim CourseName As String
    Dim YearLevels As String

    Private Sub btn_create_Click(sender As System.Object, e As System.EventArgs) Handles btn_create.Click
        uc_create_course.Visible = True
        uc_edit_course.Visible = False
        pnl_refresh.Visible = True
        pnl_action.Visible = False
        refresh_table()
    End Sub

    Private Sub uc_courses_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        uc_create_course.Visible = False
        uc_edit_course.Visible = False
        pnl_action.Visible = False
        pnl_refresh.Visible = False
    End Sub

    Private Function GetDataTable()
        dgv_datas.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        dgv_datas.MultiSelect = False

        Table.Columns.Add("Id", Type.GetType("System.String"))
        Table.Columns.Add("Code", Type.GetType("System.String"))
        Table.Columns.Add("Course", Type.GetType("System.String"))
        Table.Columns.Add("Levels", Type.GetType("System.String"))
        Table.Columns.Add("Last Update", Type.GetType("System.String"))
        Dim select_btn As New DataGridViewButtonColumn
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.courses where is_deleted = 'no' order by course_name "
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Table.Rows.Add(NewReader("id"), NewReader("course_code"), NewReader("course_name"), NewReader("year_levels"), NewReader("created_at"))
        End While
        MysqlConn.Close()

        select_btn.Text = "Select"
        select_btn.UseColumnTextForButtonValue = True
        select_btn.Width = 10
        dgv_datas.Columns(0).Visible = False
        dgv_datas.Columns.Add(select_btn)

        Return Table
    End Function

    Public Sub refresh_table()
        dgv_datas.DataSource.Clear()
        Dim select_btn As New DataGridViewButtonColumn
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.courses where is_deleted = 'no' order by course_name "
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Table.Rows.Add(NewReader("id"), NewReader("course_code"), NewReader("course_name"), NewReader("year_levels"), NewReader("created_at"))
        End While
        MysqlConn.Close()

        select_btn.Text = "Select"
        select_btn.UseColumnTextForButtonValue = True
        select_btn.Width = 10
        dgv_datas.Columns(0).Visible = False
    End Sub

    Private Sub lbl_load_Click(sender As System.Object, e As System.EventArgs) Handles lbl_load.Click
        dgv_datas.DataSource = GetDataTable()
        pnl_cover.Visible = False
    End Sub

    Private Sub txt_search_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_search.TextChanged
        search()
    End Sub

    Sub search()
        Dim data_view As New DataView(table)
        data_view.RowFilter = String.Format("Code Like '%{0}%'", txt_search.Text) + " OR " + String.Format("Course Like '%{0}%'", txt_search.Text) + " OR " + String.Format("Levels Like '%{0}%'", txt_search.Text)
        Console.WriteLine(data_view.RowFilter)
        dgv_datas.DataSource = data_view
    End Sub


    Private Sub dgv_datas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_datas.CellContentClick
        If (e.RowIndex > -1) Then
            'Console.WriteLine(e.RowIndex)
            Dim course_id As Object = dgv_datas.Rows(e.RowIndex).Cells(0).Value
            Dim course_code As Object = dgv_datas.Rows(e.RowIndex).Cells(1).Value
            Dim course_name As Object = dgv_datas.Rows(e.RowIndex).Cells(2).Value
            Dim year_levels As Object = dgv_datas.Rows(e.RowIndex).Cells(3).Value

            Console.WriteLine("Im the value : " + course_id)
            If IsDBNull(course_id) Then
                pnl_action.Visible = False
            Else
                CourseId = course_id
                CourseCode = course_code
                CourseName = course_name
                YearLevels = year_levels
                pnl_action.Visible = True
            End If
        End If
    End Sub

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        pnl_action.Visible = False
    End Sub

    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click
        Dim result As Integer = MessageBox.Show("You are about to delete a record, are you sure you want to proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            delete_record()
            refresh_table()
            MessageBox.Show("Record successfully moved to Archive!")
        End If
    End Sub

    Private Sub delete_record()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update grading_system.courses set is_deleted = 'yes' where id = '" & CourseId & "' "
            MyCommand = New MySqlCommand(Query, MysqlConn)
            Reader = MyCommand.ExecuteReader
            MysqlConn.Close()

            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString =
                "server=localhost;userid=root;password=dev123;database=grading_system"
            Dim ArchiveReader As MySqlDataReader
            Try
                MysqlConn.Open()
                Dim ArchiveQuery As String
                ArchiveQuery = "insert into grading_system.archives (reference_id,reference_keyname,reference,deleted_at) values ('" & CourseId & "','" & CourseName & "','courses', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
                MyCommand = New MySqlCommand(ArchiveQuery, MysqlConn)
                ArchiveReader = MyCommand.ExecuteReader
                MysqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub btn_edit_Click(sender As System.Object, e As System.EventArgs) Handles btn_edit.Click
        uc_edit_course.Visible = True
        uc_create_course.Visible = False
        uc_edit_course.CourseId = CourseId
        uc_edit_course.txt_course_code.Text = CourseCode
        uc_edit_course.txt_course.Text = CourseName
        uc_edit_course.txt_year_level.Text = YearLevels

        pnl_refresh.Visible = True
        pnl_action.Visible = False
    End Sub

    Private Sub lbl_refresh_Click(sender As System.Object, e As System.EventArgs) Handles lbl_refresh.Click
        pnl_refresh.Visible = False
        refresh_table()
    End Sub
End Class
