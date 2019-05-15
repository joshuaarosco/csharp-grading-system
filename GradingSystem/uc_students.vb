Imports MySql.Data.MySqlClient

Public Class uc_students
    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Dim StudentId As String
    Dim StudentName As String

    Private Sub uc_students_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        uc_create_student.Visible = False
        uc_edit_student.Visible = False
        pnl_action.Visible = False
        pnl_refresh.Visible = False
    End Sub

    Private Sub btn_create_Click(sender As System.Object, e As System.EventArgs) Handles btn_create.Click
        uc_create_student.Visible = True
    End Sub

    Private Function GetDataTable()
        dgv_datas.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        dgv_datas.MultiSelect = False

        Dim select_btn As New DataGridViewButtonColumn
        Table.Columns.Add("Id", Type.GetType("System.String"))
        Table.Columns.Add("IdNumber", Type.GetType("System.String"))
        Table.Columns.Add("Name", Type.GetType("System.String"))
        Table.Columns.Add("Course", Type.GetType("System.String"))
        Table.Columns.Add("Year", Type.GetType("System.String"))
        Table.Columns.Add("Section", Type.GetType("System.String"))
        Table.Columns.Add("Birthdate", Type.GetType("System.String"))
        Table.Columns.Add("Gender", Type.GetType("System.String"))
        Table.Columns.Add("Created At", Type.GetType("System.String"))
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.user where is_deleted = 'no' and user_type = 'student' order by lname "
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Table.Rows.Add(NewReader("id"), NewReader("id_number"), NewReader("lname") + ", " + NewReader("fname") + " " + NewReader("mname") + " " + NewReader("extname"), NewReader("course"), NewReader("year_level"), NewReader("section"), NewReader("birthdate"), NewReader("gender"), NewReader("created_at"))
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
        data_view.RowFilter = String.Format("IdNumber Like '%{0}%'", txt_search.Text) + " OR " + String.Format("Name Like '%{0}%'", txt_search.Text) + " OR " + String.Format("Course Like '%{0}%'", txt_search.Text) + " OR " + String.Format("Year Like '%{0}%'", txt_search.Text) + " OR " + String.Format("Section Like '%{0}%'", txt_search.Text)
        Console.WriteLine(data_view.RowFilter)
        dgv_datas.DataSource = data_view
    End Sub

    Private Sub refresh_table()
        dgv_datas.DataSource.Clear()
        Dim select_btn As New DataGridViewButtonColumn
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.user where is_deleted = 'no' and user_type = 'student' order by lname "
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Table.Rows.Add(NewReader("id"), NewReader("id_number"), NewReader("lname") + ", " + NewReader("fname") + " " + NewReader("mname") + " " + NewReader("extname"), NewReader("course"), NewReader("year_level"), NewReader("section"), NewReader("birthdate"), NewReader("gender"), NewReader("created_at"))
        End While
        MysqlConn.Close()

        select_btn.Text = "Select"
        select_btn.UseColumnTextForButtonValue = True
        select_btn.Width = 10
        dgv_datas.Columns(0).Visible = False
    End Sub

    Private Sub lbl_refresh_Click(sender As System.Object, e As System.EventArgs) Handles lbl_refresh.Click
        pnl_refresh.Visible = False
        refresh_table()
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

    Private Sub btn_edit_Click(sender As System.Object, e As System.EventArgs) Handles btn_edit.Click
        uc_edit_student.Visible = True
        uc_create_student.Visible = False

        pnl_refresh.Visible = True
        pnl_action.Visible = False
    End Sub

    Private Sub dgv_datas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_datas.CellContentClick
        If (e.RowIndex > -1) Then
            'Console.WriteLine(e.RowIndex)
            Dim student_id As Object = dgv_datas.Rows(e.RowIndex).Cells(0).Value

            Console.WriteLine("Im the value : " + student_id)
            If IsDBNull(student_id) Then
                pnl_action.Visible = False
            Else
                select_student(student_id)
                pnl_action.Visible = True
            End If
        End If
    End Sub

    Private Sub select_student(ByVal student_id)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.user where user_type = 'student' and id = '" & student_id & "'"
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            uc_edit_student.StudentId = NewReader("id")
            uc_edit_student.txt_id_number.Text = NewReader("id_number")
            uc_edit_student.txt_fname.Text = NewReader("fname")
            uc_edit_student.txt_mname.Text = NewReader("mname")
            uc_edit_student.txt_lname.Text = NewReader("lname")
            uc_edit_student.txt_ext_name.Text = NewReader("extname")
            uc_edit_student.cb_course.SelectedValue = NewReader("course")
            uc_edit_student.cb_year_level.Text = NewReader("year_level")
            uc_edit_student.cb_section.SelectedValue = NewReader("section_id")
            uc_edit_student.mtxt_birthdate.Text = NewReader("birthdate")
            uc_edit_student.cb_gender.Text = NewReader("gender")
            uc_edit_student.txt_school_year.Text = NewReader("school_year")
            uc_edit_student.txt_username.Text = NewReader("username")
            uc_edit_student.txt_password.Text = NewReader("password")

            StudentId = NewReader("id")
            StudentName = NewReader("lname") + ", " + NewReader("fname") + " " + NewReader("mname") + " " + NewReader("extname")
        End While
        MysqlConn.Close()
    End Sub

    Private Sub delete_record()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update grading_system.user set is_deleted = 'yes' where id = '" & StudentId & "' "
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
                ArchiveQuery = "insert into grading_system.archives (reference_id,reference_keyname,reference,deleted_at) values ('" & StudentId & "','" & StudentName & "','students', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
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
End Class
