Imports GradingSystem.GlobalClass
Imports System.Linq

Public Class frm_dashboard
    Public Property UserId As String
    Public Property UserType As String
    Public Property UserCourse As String
    Public Property UserFullName As String
    Public Property UserYearLevel As String
    Public Property UserSchoolYear As String

    Sub inactive_btns()
        btn_dashboard.BackColor = Color.SlateGray
        btn_courses.BackColor = Color.SlateGray
        btn_year_section.BackColor = Color.SlateGray
        btn_subjects.BackColor = Color.SlateGray
        btn_teacher.BackColor = Color.SlateGray
        btn_students.BackColor = Color.SlateGray
        btn_grades.BackColor = Color.SlateGray
        btn_archives.BackColor = Color.SlateGray
    End Sub

    Sub hide_user_controls()
        uc_dashboard.Visible = False
        uc_courses.Visible = False
        uc_year_section.Visible = False
        uc_subjects.Visible = False
        uc_teachers.Visible = False
        uc_students.Visible = False
        uc_grades.Visible = False
        uc_archives.Visible = False
    End Sub

    Private Sub frm_dashboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UserTypeCondition()
        txt_name.Text = GlobalClass.get_greetings() + " " + UserFullName
        hide_user_controls()
        uc_dashboard.Visible = True
        Me.Text = "  Dashboard"
    End Sub


    Private Sub btn_dashboard_Click(sender As System.Object, e As System.EventArgs) Handles btn_dashboard.Click
        inactive_btns()
        hide_user_controls()
        btn_dashboard.BackColor = Color.LightSlateGray
        uc_dashboard.Visible = True
        Me.Text = "  Dashboard"
    End Sub

    Private Sub btn_courses_Click(sender As System.Object, e As System.EventArgs) Handles btn_courses.Click
        inactive_btns()
        hide_user_controls()
        btn_courses.BackColor = Color.LightSlateGray
        uc_courses.Visible = True
        Me.Text = "  Courses"
    End Sub

    Private Sub btn_year_section_Click(sender As System.Object, e As System.EventArgs) Handles btn_year_section.Click
        inactive_btns()
        hide_user_controls()
        btn_year_section.BackColor = Color.LightSlateGray
        Me.Text = "  Year & Section"
        uc_year_section.Visible = True
    End Sub

    Private Sub btn_subjects_Click(sender As System.Object, e As System.EventArgs) Handles btn_subjects.Click
        inactive_btns()
        hide_user_controls()
        btn_subjects.BackColor = Color.LightSlateGray
        Me.Text = "  Subjects"
        uc_subjects.Visible = True
        uc_subjects.UserType = UserType
        PassUserData()
    End Sub

    Private Sub btn_teacher_Click(sender As System.Object, e As System.EventArgs) Handles btn_teacher.Click
        inactive_btns()
        hide_user_controls()
        btn_teacher.BackColor = Color.LightSlateGray
        Me.Text = "  Teachers"
        uc_teachers.Visible = True
    End Sub

    Private Sub btn_students_Click(sender As System.Object, e As System.EventArgs) Handles btn_students.Click
        inactive_btns()
        hide_user_controls()
        btn_students.BackColor = Color.LightSlateGray
        Me.Text = "  Students"
        uc_students.Visible = True
    End Sub

    Private Sub btn_grades_Click(sender As System.Object, e As System.EventArgs) Handles btn_grades.Click
        inactive_btns()
        hide_user_controls()
        btn_grades.BackColor = Color.LightSlateGray
        Me.Text = "  Grades"
        uc_grades.Visible = True
        uc_grades.Course = UserCourse
        uc_grades.YearLevel = UserYearLevel
        uc_grades.SchoolYear = UserSchoolYear
        uc_grades.UserId = UserId
    End Sub

    Private Sub btn_archives_Click(sender As System.Object, e As System.EventArgs) Handles btn_archives.Click
        inactive_btns()
        UserTypeCondition()
        hide_user_controls()
        btn_archives.BackColor = Color.LightSlateGray
        uc_archives.Visible = True
        Me.Text = "  Archives"
    End Sub

    Private Sub UserTypeCondition()
        If UserType = "teacher" Then
            btn_courses.Visible = False
            btn_teacher.Visible = False
            btn_grades.Visible = False
            btn_students.Visible = False
            btn_year_section.Visible = False
            btn_archives.Visible = False
            btn_subjects.Location = New Point(0, 91)
        ElseIf UserType = "student" Then
            btn_courses.Visible = False
            btn_teacher.Visible = False
            btn_year_section.Visible = False
            btn_students.Visible = False
            btn_subjects.Visible = False
            btn_archives.Visible = False
            btn_grades.Location = New Point(0, 91)
        Else
            btn_grades.Visible = False
            btn_archives.Location = New Point(0, 292)
        End If
    End Sub

    Private Sub PassUserData()
        uc_subjects.UserId = UserId
        uc_subjects.UserType = UserType
        uc_subjects.UserFullName = UserFullName

        uc_year_section.UserId = UserId
        uc_year_section.UserType = UserType
        uc_year_section.UserFullName = UserFullName
    End Sub

    Private Sub btn_logout_Click(sender As System.Object, e As System.EventArgs) Handles btn_logout.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Dim frm = New frm_login()
            frm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_password_setting_Click(sender As System.Object, e As System.EventArgs) Handles btn_password_setting.Click
        If Application.OpenForms().OfType(Of frm_password_setting).Any Then
            MessageBox.Show("Password Setting window is already open")
        Else
            Dim frm = New frm_password_setting()
            frm.UserId = UserId
            frm.Show()
        End If
    End Sub
End Class