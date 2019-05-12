Imports MySql.Data.MySqlClient

Public Class uc_grades
    Public Property UserId As String
    Public Property Course As String
    Public Property YearLevel As String
    Public Property SchoolYear As String

    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim GradeCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim GradesqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim GradeReader As MySqlDataReader
    Dim MyQuery As String
    Dim GradeQuery As String

    Private Sub lbl_load_Click(sender As System.Object, e As System.EventArgs) Handles lbl_load.Click
        dgv_datas.DataSource = GetDataTable()
        pnl_cover.Visible = False
    End Sub

    Private Function GetDataTable()
        dgv_datas.SelectionMode =
        DataGridViewSelectionMode.FullRowSelect
        dgv_datas.MultiSelect = False

        Table.Columns.Add("Subject Code", Type.GetType("System.String"))
        Table.Columns.Add("Subject", Type.GetType("System.String"))
        Table.Columns.Add("Teacher", Type.GetType("System.String"))
        Table.Columns.Add("Grade", Type.GetType("System.String"))
        Table.Columns.Add("Status", Type.GetType("System.String"))
        dgv_datas.DataSource = Table

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.subjects where course = '" & Course & "' and year_level ='" & YearLevel & "' and school_year = '" & SchoolYear & "' order by school_year desc, subject_name asc"
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Dim grade As String = check_grade(UserId, NewReader("id"), "grade")
            Dim status As String = check_grade(UserId, NewReader("id"), "status")
            Table.Rows.Add(NewReader("subject_code"), NewReader("subject_name"), NewReader("teacher_name"), grade, status)
        End While
        MysqlConn.Close()
        Return Table
    End Function

    Private Function check_grade(ByVal student_id, ByVal subject_id, ByVal type)
        GradesqlConn = New MySqlConnection
        GradesqlConn.ConnectionString =
        "server=localhost;userid=root;password=dev123;database=grading_system"

        GradesqlConn.Open()
        GradeQuery = "select * from grading_system.grades where subject_id = '" & subject_id & "' and student_id = '" & student_id & "'"
        GradeCommand = New MySqlCommand(GradeQuery, GradesqlConn)
        GradeReader = GradeCommand.ExecuteReader
        Dim count As Integer
        count = 0

        Dim grade As Decimal
        Dim grade_status As String

        While GradeReader.Read
            count = count + 1
            grade = GradeReader("grade")
            grade_status = GradeReader("status")
        End While

        If count = 0 Then
            create_grade(student_id, 0, subject_id)
        End If
        GradesqlConn.Close()

        If type = "grade" Then
            Return grade.ToString
        Else
            Return grade_status
        End If

    End Function

    Private Sub create_grade(ByVal student_id, ByVal grade, ByVal subject_id)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            Dim status As String = grade_status(grade)

            MysqlConn.Open()
            Dim Query As String
            Query = "insert into grading_system.grades (subject_id,student_id,grade,status,created_at) values ('" & subject_id & "','" & student_id & "','" & grade & "','" & status & "', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
            MyCommand = New MySqlCommand(Query, MysqlConn)
            Reader = MyCommand.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Function grade_status(ByVal grade)
        Dim status As String

        If grade = 0 Then
            status = "n/a"
        ElseIf grade >= 1 And grade <= 3 Then
            status = "pass"
        ElseIf grade > 3 And grade <= 4 Then
            status = "inc/conditional"
        Else
            status = "fail"
        End If
        Return status
    End Function

End Class
