Imports MySql.Data.MySqlClient

Public Class uc_encode_grades_student
    Dim Table As New DataTable()
    Dim MyCommand As MySqlCommand
    Dim GradeCommand As MySqlCommand
    Dim MysqlConn As MySqlConnection
    Dim GradesqlConn As MySqlConnection
    Dim NewReader As MySqlDataReader
    Dim GradeReader As MySqlDataReader
    Dim MyQuery As String
    Dim GradeQuery As String

    Public Property UserType As String
    Public Property SectionId As String
    Public Property SubjectId As String

    Private Sub lbl_load_Click(sender As System.Object, e As System.EventArgs) Handles lbl_load.Click
        pnl_load.Visible = False
        dgv_datas.DataSource = GetDataTable()
    End Sub

    Private Sub table_setting()

        'dgv_datas.SelectionMode =
        'DataGridViewSelectionMode.FullRowSelect()
        'dgv_datas.MultiSelect = False

        Table.Columns.Add("Id", Type.GetType("System.String"))
        Table.Columns.Add("ID Number", Type.GetType("System.String"))
        Table.Columns.Add("Name", Type.GetType("System.String"))
        Table.Columns.Add("Grade", Type.GetType("System.String"))
        Table.Columns.Add("Status", Type.GetType("System.String"))

        'dgv_datas.Columns("Grade").ReadOnly = False

        dgv_datas.DataSource = Table
        Dim select_btn As New DataGridViewButtonColumn

        select_btn.Text = "Select"
        select_btn.UseColumnTextForButtonValue = True
        select_btn.Width = 10
        dgv_datas.Columns(0).Visible = False
        'dgv_datas.Columns.Add(select_btn)
    End Sub

    Private Function GetDataTable()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.user where section_id = '" & SectionId & "' and user_type = 'student' order by lname "
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            Dim grade As String = check_grade(NewReader("id"), SubjectId, "grade")
            Dim status As String = check_grade(NewReader("id"), SubjectId, "status")
            Console.WriteLine(grade)
            Table.Rows.Add(NewReader("id"), NewReader("id_number"), NewReader("lname") + ", " + NewReader("fname") + " " + NewReader("mname") + " " + NewReader("extname"), grade, status)

        End While
        MysqlConn.Close()

        Return Table
    End Function

    Private Function check_grade(ByVal student_id, ByVal subject_id, ByVal type)
        GradesqlConn = New MySqlConnection
        GradesqlConn.ConnectionString =
        "server=localhost;userid=root;password=dev123;database=grading_system"

        GradesqlConn.Open()
        GradeQuery = "select * from grading_system.grades where subject_id = '" & SubjectId & "' and student_id = '" & student_id & "'"
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
            create_grade(student_id, 0)
        End If
        GradesqlConn.Close()

        If type = "grade" Then
            Return grade.ToString
        Else
            Return grade_status
        End If

    End Function

    Private Sub btn_back_Click(sender As System.Object, e As System.EventArgs) Handles btn_back.Click
        Me.Visible = False
        pnl_load.Visible = True
        dgv_datas.DataSource.Clear()
    End Sub

    Private Sub uc_encode_grades_student_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btn_save.Visible = False
        table_setting()
        dgv_datas.Columns("Id").ReadOnly = True
        dgv_datas.Columns("ID Number").ReadOnly = True
        dgv_datas.Columns("Name").ReadOnly = True
        dgv_datas.Columns("Status").ReadOnly = True
    End Sub

    Private Sub dgv_datas_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_datas.CellValueChanged
        btn_save.Visible = True
    End Sub

    Private Sub btn_save_Click(sender As System.Object, e As System.EventArgs) Handles btn_save.Click
        save_grade()
    End Sub

    Private Sub save_grade()
        Dim student_id As Integer
        Dim grade As Decimal

        For x As Integer = 0 To dgv_datas.Rows.Count - 1
            

            If IsNumeric(dgv_datas.Rows(x).Cells(3).Value()) And grade <= 5 Then
                student_id = dgv_datas.Rows(x).Cells(0).Value()
                grade = dgv_datas.Rows(x).Cells(3).Value()

                Console.WriteLine("Student Id : " + student_id.ToString)
                Console.WriteLine("Student Grade : " + grade.ToString)
                Console.WriteLine(SubjectId)

                MysqlConn = New MySqlConnection
                MysqlConn.ConnectionString =
                "server=localhost;userid=root;password=dev123;database=grading_system"

                MysqlConn.Open()
                MyQuery = "select * from grading_system.grades where subject_id = '" & SubjectId & "' and student_id = '" & student_id & "'"
                MyCommand = New MySqlCommand(MyQuery, MysqlConn)
                NewReader = MyCommand.ExecuteReader
                Dim count As Integer
                count = 0

                While NewReader.Read
                    count = count + 1
                End While

                If count > 0 Then
                    update_grade(student_id, grade)
                Else
                    create_grade(student_id, grade)
                End If
                MessageBox.Show("Successfully saved!")
                MysqlConn.Close()
            Else
                MessageBox.Show("Grade should be numeric and between 1 - 5")
            End If
        Next
    End Sub

    Private Sub create_grade(ByVal student_id, ByVal grade)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            Dim status As String = grade_status(grade)

            MysqlConn.Open()
            Dim Query As String
            Query = "insert into grading_system.grades (subject_id,student_id,grade,status,created_at) values ('" & SubjectId & "','" & student_id & "','" & grade & "','" & status & "', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
            MyCommand = New MySqlCommand(Query, MysqlConn)
            Reader = MyCommand.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub update_grade(ByVal student_id, ByVal grade)
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        Try
            Dim status As String = grade_status(grade)

            MyQuery = "update grading_system.grades set grade = '" & grade & "', status = '" & status & "' WHERE student_id ='" & student_id & "' and subject_id = '" & SubjectId & "' "
            MyCommand = New MySqlCommand(MyQuery, MysqlConn)
            NewReader = MyCommand.ExecuteReader
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

    Private Sub dgv_datas_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv_datas.CellClick
        If UserType = "admin" Then
            dgv_datas.Columns("Grade").ReadOnly = True
        End If
    End Sub
End Class
