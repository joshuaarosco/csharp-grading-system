Imports MySql.Data.MySqlClient

Public Class uc_create_student
    Dim MysqlConn As MySqlConnection
    Dim MyCommand As MySqlCommand
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.Visible = False
    End Sub

    Private Sub uc_create_student_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim comboSource As New Dictionary(Of String, String)()
        comboSource.Add("Male", "Male")
        comboSource.Add("Female", "Female")
        cb_gender.DataSource = New BindingSource(comboSource, Nothing)
        cb_gender.DisplayMember = "Value"
        cb_gender.ValueMember = "Key"

        load_courses()
    End Sub

    Private Sub cb_year_level_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cb_year_level.MouseClick
        load_year_levels()
    End Sub

    Private Sub cb_section_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles cb_section.MouseClick
        load_sections()
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

    Private Sub load_sections()
        Dim default_course As String
        default_course = cb_course.Text

        Console.WriteLine(default_course)
        If default_course = "Choose course" Then
            Console.WriteLine("Success")
        Else
            MysqlConn.Open()
            MyQuery = "select * from grading_system.sections where course = '" & cb_course.SelectedValue & "' and year_level = '" & cb_year_level.SelectedValue & "' order by section_name"
            MyCommand = New MySqlCommand(MyQuery, MysqlConn)
            NewReader = MyCommand.ExecuteReader

            Dim comboSource2 As New Dictionary(Of String, String)()
            While NewReader.Read
                comboSource2.Add(NewReader("id"), NewReader("section_name"))
            End While
            MysqlConn.Close()
            cb_section.DataSource = New BindingSource(comboSource2, Nothing)
            cb_section.DisplayMember = "Value"
            cb_section.ValueMember = "Key"
        End If
    End Sub

    Private Sub btn_save_Click(sender As System.Object, e As System.EventArgs) Handles btn_save.Click
        If txt_fname.Text = "" Or txt_lname.Text = "" Or txt_id_number.Text = "" Or mtxt_birthdate.Text = "" Or txt_username.Text = "" Or txt_password.Text = "" Then
            MessageBox.Show("All field is required!")
        Else
            create()
            Me.Visible = False
            clear()
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
            Query = "insert into grading_system.user (id_number,fname,mname,lname,extname,course,year_level,section_id,section,birthdate,gender,school_year,user_type,username,password,created_at) values ('" & txt_id_number.Text & "','" & txt_fname.Text & "','" & txt_mname.Text & "','" & txt_lname.Text & "','" & txt_ext_name.Text & "','" & cb_course.SelectedValue & "','" & cb_year_level.SelectedValue & "','" & cb_section.SelectedValue & "','" & cb_section.Text & "','" & mtxt_birthdate.Text & "','" & cb_gender.SelectedValue & "','" & txt_school_year.Text & "','student','" & txt_username.Text & "','" & txt_password.Text & "', '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "')"
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

    End Sub
End Class
