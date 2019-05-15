Imports MySql.Data.MySqlClient

Public Class uc_subjects
    Public Property UserId As String
    Public Property UserType As String
    Public Property UserFullName As String

    Dim SubjectId As String
    Dim SubjectCode As String
    Dim SubjectName As String
    Dim SubjectCourse As String
    Dim YearLevel As String
    Dim SubjectSemester As String
    Dim SubjectUnits As String
    Dim SchoolYear As String
    Dim SubjectTeacher As String

    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Private Sub btn_create_Click(sender As System.Object, e As System.EventArgs) Handles btn_create.Click
        uc_create_subject.Visible = True
        uc_edit_subject.Visible = False
        pnl_cover.Visible = False
        pnl_action.Visible = False
        pnl_refresh.Visible = True
    End Sub

    Private Sub uc_subjects_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        uc_create_subject.Visible = False
        uc_edit_subject.Visible = False
        uc_encode_grades_sections.Visible = False
        If UserType = "teacher" Then
            btn_delete.Visible = False
            btn_edit.Visible = False
            btn_close.Location = New Point(505, 14)
        End If
        pnl_action.Visible = False
        pnl_refresh.Visible = False
        pb_refresh.Visible = False
    End Sub

    Private Function GetDataTable()
        dgv_datas.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        dgv_datas.MultiSelect = False

        Dim select_btn As New DataGridViewButtonColumn
        Table.Columns.Add("Id", Type.GetType("System.String"))
        Table.Columns.Add("Code", Type.GetType("System.String"))
        Table.Columns.Add("Subject", Type.GetType("System.String"))
        Table.Columns.Add("Course", Type.GetType("System.String"))
        Table.Columns.Add("YearLevel", Type.GetType("System.String"))
        Table.Columns.Add("Semester", Type.GetType("System.String"))
        Table.Columns.Add("Units", Type.GetType("System.String"))
        Table.Columns.Add("SchoolYear", Type.GetType("System.String"))
        Table.Columns.Add("Teacher", Type.GetType("System.String"))
        Table.Columns.Add("Last Update", Type.GetType("System.String"))
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        If UserType = "teacher" Then
            MyQuery = "select * from grading_system.subjects where is_deleted = 'no' and teacher_id = '" & UserId & "' order by course "
        Else
            MyQuery = "select * from grading_system.subjects where is_deleted = 'no' order by course "
        End If
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Table.Rows.Add(NewReader("id"), NewReader("subject_code"), NewReader("subject_name"), NewReader("course"), NewReader("year_level"), NewReader("semester"), NewReader("units"), NewReader("school_year"), NewReader("teacher_name"), NewReader("created_at"))
        End While
        MysqlConn.Close()

        select_btn.Text = "Select"
        select_btn.UseColumnTextForButtonValue = True
        select_btn.Width = 10
        dgv_datas.Columns(0).Visible = False
        If UserType = "teacher" Then
            dgv_datas.Columns(8).Visible = False
            btn_edit.Visible = False
            btn_delete.Visible = False
            btn_close.Location = New Point(505, 14)
        End If
        dgv_datas.Columns.Add(select_btn)

        Return Table
    End Function

    Private Sub lbl_load_Click(sender As System.Object, e As System.EventArgs) Handles lbl_load.Click
        dgv_datas.DataSource = GetDataTable()
        pnl_cover.Visible = False
        If UserType = "teacher" Then
            btn_create.Visible = False
            pnl_search.Width = 737
            txt_search.Width = 708
        Else
            btn_create.Visible = True
        End If
        pb_refresh.Visible = True
    End Sub

    Private Sub dgv_datas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_datas.CellContentClick
        If (e.RowIndex > -1) Then
            'Console.WriteLine(e.RowIndex)
            Dim subject_id As Object = dgv_datas.Rows(e.RowIndex).Cells(0).Value
            Dim subject_code As Object = dgv_datas.Rows(e.RowIndex).Cells(1).Value
            Dim subject_name As Object = dgv_datas.Rows(e.RowIndex).Cells(2).Value
            Dim course As Object = dgv_datas.Rows(e.RowIndex).Cells(3).Value
            Dim year_level As Object = dgv_datas.Rows(e.RowIndex).Cells(4).Value
            Dim semester As Object = dgv_datas.Rows(e.RowIndex).Cells(5).Value
            Dim units As Object = dgv_datas.Rows(e.RowIndex).Cells(6).Value
            Dim school_year As Object = dgv_datas.Rows(e.RowIndex).Cells(7).Value
            Dim teacher As Object = dgv_datas.Rows(e.RowIndex).Cells(8).Value

            Console.WriteLine("Im the value : " + subject_id)
            If IsDBNull(subject_id) Then
                pnl_action.Visible = False
            Else
                pnl_action.Visible = True
                SubjectId = subject_id
                SubjectCode = subject_code
                SubjectName = subject_name
                SubjectCourse = course
                YearLevel = year_level
                SubjectSemester = semester
                SubjectUnits = units
                SchoolYear = school_year
                SubjectTeacher = teacher
            End If
        End If
    End Sub

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        pnl_action.Visible = False
    End Sub

    Private Sub btn_encode_Click(sender As System.Object, e As System.EventArgs) Handles btn_encode.Click
        uc_encode_grades_sections.Visible = True
        uc_encode_grades_sections.SubjectId = SubjectId
        uc_encode_grades_sections.SubjectCode = SubjectCode
        uc_encode_grades_sections.SubjectName = SubjectName
        uc_encode_grades_sections.Course = SubjectCourse
        uc_encode_grades_sections.YearLevel = YearLevel
        uc_encode_grades_sections.SchoolYear = SchoolYear
        uc_encode_grades_sections.lbl_subject.Text = SubjectCode + " : " + SubjectName
        uc_encode_grades_sections.UserType = UserType

        pnl_action.Visible = False
    End Sub

    Private Sub txt_search_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_search.TextChanged
        search()
    End Sub

    Sub search()
        Dim data_view As New DataView(table)
        data_view.RowFilter = String.Format("Code Like '%{0}%'", txt_search.Text) + " OR " + String.Format("Subject Like '%{0}%'", txt_search.Text) + " OR " + String.Format("Course Like '%{0}%'", txt_search.Text) + " OR " + String.Format("YearLevel Like '%{0}%'", txt_search.Text) + " OR " + String.Format("Teacher Like '%{0}%'", txt_search.Text) + " OR " + String.Format("SchoolYear Like '%{0}%'", txt_search.Text)
        Console.WriteLine(data_view.RowFilter)
        dgv_datas.DataSource = data_view
    End Sub

    Private Sub lbl_refresh_Click(sender As System.Object, e As System.EventArgs) Handles lbl_refresh.Click
        pnl_refresh.Visible = False
        refresh_table()
    End Sub

    Public Sub refresh_table()
        dgv_datas.DataSource.Clear()
        Dim select_btn As New DataGridViewButtonColumn
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        If UserType = "teacher" Then
            MyQuery = "select * from grading_system.subjects where is_deleted = 'no' and teacher_id = '" & UserId & "' order by course "
        Else
            MyQuery = "select * from grading_system.subjects where is_deleted = 'no' order by course "
        End If
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Table.Rows.Add(NewReader("id"), NewReader("subject_code"), NewReader("subject_name"), NewReader("course"), NewReader("year_level"), NewReader("semester"), NewReader("units"), NewReader("school_year"), NewReader("teacher_name"), NewReader("created_at"))
        End While
        MysqlConn.Close()

        select_btn.Text = "Select"
        select_btn.UseColumnTextForButtonValue = True
        select_btn.Width = 10
        dgv_datas.Columns(0).Visible = False
    End Sub

    Private Sub btn_edit_Click(sender As System.Object, e As System.EventArgs) Handles btn_edit.Click
        uc_edit_subject.Visible = True
        uc_create_subject.Visible = False
        uc_edit_subject.txt_subject_code.Text = SubjectCode
        uc_edit_subject.txt_subject.Text = SubjectName
        uc_edit_subject.cb_course.SelectedValue = SubjectCourse
        uc_edit_subject.cb_year_level.SelectedValue = YearLevel
        uc_edit_subject.txt_semester.Text = SubjectSemester
        uc_edit_subject.txt_units.Text = SubjectUnits
        uc_edit_subject.mtxt_school_year.Text = SchoolYear
        uc_edit_subject.cb_teacher.Text = SubjectTeacher
        uc_edit_subject.SubjectId = SubjectId

        pnl_refresh.Visible = True
        pnl_action.Visible = False
    End Sub

    Private Sub delete_record()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update grading_system.subjects set is_deleted = 'yes' where id = '" & SubjectId & "' "
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
                ArchiveQuery = "insert into grading_system.archives (reference_id,reference_keyname,reference,deleted_at) values ('" & SubjectId & "','" & SubjectName & "','subjects', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
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

    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click
        Dim result As Integer = MessageBox.Show("You are about to delete a record, are you sure you want to proceed?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            delete_record()
            refresh_table()
            MessageBox.Show("Record successfully moved to Archive!")
        End If
    End Sub

    Private Sub pb_refresh_Click(sender As System.Object, e As System.EventArgs) Handles pb_refresh.Click
        refresh_table()
    End Sub
End Class
