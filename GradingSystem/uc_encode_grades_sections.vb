Imports MySql.Data.MySqlClient

Public Class uc_encode_grades_sections
    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String
    Dim SectionCourse As String
    Dim SectionYearLevel As String
    Dim SectionId As String
    Dim SectionName As String

    Public Property UserType As String
    Public Property SubjectId As String
    Public Property SubjectCode As String
    Public Property SubjectName As String
    Public Property Course As String
    Public Property YearLevel As String
    Public Property SchoolYear As String

    Private Sub lbl_load_Click(sender As System.Object, e As System.EventArgs) Handles lbl_load.Click
        dgv_datas.DataSource = GetDataTable()
        pnl_load.Visible = False
    End Sub

    Private Function GetDataTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.sections where course = '" & Course & "' and year_level = '" & YearLevel & "' and school_year = '" & SchoolYear & "' order by course"
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Table.Rows.Add(NewReader("id"), NewReader("course"), NewReader("year_level"), NewReader("section_name"), NewReader("school_year"))
        End While
        MysqlConn.Close()

        Return Table
    End Function

    Private Sub table_setting()
        dgv_datas.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        dgv_datas.MultiSelect = False

        Table.Columns.Add("Id", Type.GetType("System.String"))
        Table.Columns.Add("Course", Type.GetType("System.String"))
        Table.Columns.Add("Year Level", Type.GetType("System.String"))
        Table.Columns.Add("Section", Type.GetType("System.String"))
        Table.Columns.Add("School Year", Type.GetType("System.String"))
        dgv_datas.DataSource = Table

        Dim select_btn As New DataGridViewButtonColumn

        select_btn.Text = "Select"
        select_btn.UseColumnTextForButtonValue = True
        select_btn.Width = 10
        dgv_datas.Columns(0).Visible = False
        dgv_datas.Columns.Add(select_btn)
    End Sub

    Private Sub btn_back_Click(sender As System.Object, e As System.EventArgs) Handles btn_back.Click
        Me.Visible = False
        pnl_load.Visible = True
        dgv_datas.DataSource.Clear()
    End Sub

    Private Sub dgv_datas_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_datas.CellContentClick
        If (e.RowIndex > -1) Then
            Dim section_id As Object = dgv_datas.Rows(e.RowIndex).Cells(1).Value
            Dim course As Object = dgv_datas.Rows(e.RowIndex).Cells(2).Value
            Dim year_level As Object = dgv_datas.Rows(e.RowIndex).Cells(3).Value
            Dim section_name As Object = dgv_datas.Rows(e.RowIndex).Cells(4).Value
            Console.WriteLine("Im the value : " + section_id)
            If IsDBNull(section_id) Then
                btn_encode.Visible = False
            Else
                SectionCourse = course
                SectionYearLevel = year_level
                SectionId = section_id
                SectionName = section_name
                btn_encode.Visible = True
            End If
        End If
    End Sub

    Private Sub uc_encode_grades_sections_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        table_setting()
        btn_encode.Visible = False
        uc_encode_grades_student.Visible = False
    End Sub

    Private Sub btn_encode_Click(sender As System.Object, e As System.EventArgs) Handles btn_encode.Click
        uc_encode_grades_student.lbl_section.Text = SectionCourse + " " + SectionYearLevel + " - " + SectionName
        uc_encode_grades_student.SectionId = SectionId
        uc_encode_grades_student.SubjectId = SubjectId
        uc_encode_grades_student.UserType = UserType
        uc_encode_grades_student.Visible = True
    End Sub
End Class
