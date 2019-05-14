Imports MySql.Data.MySqlClient

Public Class uc_edit_student

    Public Property StudentId As String

    Dim MysqlConn As MySqlConnection
    Dim MyCommand As MySqlCommand
    Dim NewReader As MySqlDataReader
    Dim MyQuery As String

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Me.Visible = False
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

    Private Sub uc_edit_student_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btn_update_Click(sender As System.Object, e As System.EventArgs) Handles btn_update.Click
        If txt_fname.Text = "" Or txt_lname.Text = "" Or txt_id_number.Text = "" Or cb_course.Text = "" Or cb_year_level.Text = "" Or cb_section.Text = "" Or mtxt_birthdate.Text = "" Or txt_school_year.Text = "" Or txt_username.Text = "" Or txt_password.Text = "" Then
            MessageBox.Show("All field is required!")
        Else
            update_data()
            Me.Visible = False
        End If
    End Sub

    Private Sub update_data()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
            "server=localhost;userid=root;password=dev123;database=grading_system"
        Dim Reader As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update grading_system.user set id_number = '" & txt_id_number.Text & "', fname = '" & txt_fname.Text & "', mname = '" & txt_mname.Text & "', lname = '" & txt_lname.Text & "', extname = '" & txt_ext_name.Text & "', course = '" & cb_course.SelectedValue & "', year_level = '" & cb_year_level.SelectedValue & "', section_id = '" & cb_section.SelectedValue & "', section = '" & cb_section.Text & "', birthdate = '" & mtxt_birthdate.Text & "', gender = '" & cb_gender.SelectedValue & "',school_year = '" & txt_school_year.Text & "', username = '" & txt_username.Text & "', password = '" & txt_password.Text & "', created_at = '" & DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & "' where id = '" & StudentId & "'"
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
