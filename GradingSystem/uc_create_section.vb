Imports MySql.Data.MySqlClient

Public Class uc_create_section
    Dim MysqlConn As MySqlConnection
    Dim MyCommand As MySqlCommand
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.Visible = False
    End Sub

    Private Sub uc_create_section_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        load_courses()
        load_teachers()
    End Sub

    Private Sub btn_save_Click(sender As System.Object, e As System.EventArgs) Handles btn_save.Click
        If cb_course.Text = "" Or cb_year_level.Text = "" Or txt_section.Text = "" Or mtxt_school_year.Text = "" Then
            MessageBox.Show("All field is required!")
        Else
            create()
            Me.Visible = False
            clear()
        End If
    End Sub

    Private Sub cb_year_level_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cb_year_level.MouseClick
        load_year_levels()
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

    Private Sub create()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into grading_system.sections (course,year_level,section_name,adviser_id,adviser_name,school_year,created_at) values ('" & cb_course.SelectedValue & "','" & cb_year_level.SelectedValue & "','" & txt_section.Text & "','" & cb_teacher.SelectedValue & "','" & cb_teacher.Text & "','" & mtxt_school_year.Text & "', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
            MyCommand = New MySqlCommand(Query, MysqlConn)
            Reader = MyCommand.ExecuteReader
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub clear()
        txt_section.Text = ""
        mtxt_school_year.Text = ""
    End Sub

End Class
