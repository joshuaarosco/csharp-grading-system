Imports MySql.Data.MySqlClient

Public Class uc_edit_subject

    Dim MysqlConn As MySqlConnection
    Dim MyCommand As MySqlCommand
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Public Property SubjectId As String

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.Hide()
    End Sub

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        If txt_subject_code.Text = "" Or txt_subject.Text = "" Or cb_course.Text = "" Or cb_year_level.Text = "" Or txt_semester.Text = "" Or txt_units.Text = "" Or mtxt_school_year.Text = "" Or cb_teacher.Text = "" Then
            MessageBox.Show("All field is required!")
        Else
            update_data()
            Me.Visible = False
        End If
    End Sub

    Private Sub load_courses()
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("none", "Choose course")
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.courses order by course_name "
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            comboSource.Add(NewReader("course_code"), NewReader("course_name"))
        End While
        MysqlConn.Close()

        cb_course.DataSource = New BindingSource(comboSource, Nothing)
        cb_course.DisplayMember = "Value"
        cb_course.ValueMember = "Key"
    End Sub

    Private Sub load_teachers()
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("none", "Choose teacher")
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"

        MysqlConn.Open()
        MyQuery = "select * from grading_system.user where user_type = 'teacher' order by fname"
        MyCommand = New MySqlCommand(MyQuery, MysqlConn)
        NewReader = MyCommand.ExecuteReader
        While NewReader.Read
            comboSource.Add(NewReader("id"), NewReader("fname") + " " + NewReader("lname"))
        End While
        MysqlConn.Close()

        cb_teacher.DataSource = New BindingSource(comboSource, Nothing)
        cb_teacher.DisplayMember = "Value"
        cb_teacher.ValueMember = "Key"
    End Sub

    Private Sub load_year_levels()
        'cb_year_level.Enabled = False
        Dim default_course As String
        default_course = cb_course.Text

        Console.WriteLine(default_course)
        If default_course = "Choose course" Then
            Console.WriteLine("Success")
        Else
            MysqlConn.Open()
            MyQuery = "select * from grading_system.courses where course_code = '" & cb_course.SelectedValue & "' limit 1"
            MyCommand = New MySqlCommand(MyQuery, MysqlConn)
            NewReader = MyCommand.ExecuteReader
            While NewReader.Read
                Dim count As Integer
                count = NewReader("year_levels")

                Dim comboSource2 As New Dictionary(Of String, String)()
                For counter = 1 To count
                    comboSource2.Add(counter, counter)
                Next
                cb_year_level.DataSource = New BindingSource(comboSource2, Nothing)
                cb_year_level.DisplayMember = "Value"
                cb_year_level.ValueMember = "Key"
                Console.WriteLine(NewReader("year_levels"))
                'cb_year_level.Enabled = True
            End While
            MysqlConn.Close()
        End If
    End Sub

    Private Sub uc_edit_subject_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_courses()
        load_teachers()
    End Sub

    Private Sub cb_year_level_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cb_year_level.MouseClick
        load_year_levels()
    End Sub

    Private Sub update_data()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update grading_system.subjects set subject_code = '" & txt_subject_code.Text & "', subject_name = '" & txt_subject.Text & "', course = '" & cb_course.SelectedValue & "', year_level = '" & cb_year_level.SelectedValue & "', semester = '" & txt_semester.Text & "',units = '" & txt_units.Text & "', school_year = '" & mtxt_school_year.Text & "',teacher_id = '" & cb_teacher.SelectedValue & "', teacher_name = '" & cb_teacher.Text & "' , created_at = '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "' where id = '" & SubjectId & "'"
            MyCommand = New MySqlCommand(Query, MysqlConn)
            Reader = MyCommand.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class
