<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_password_setting = New System.Windows.Forms.Button()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_grades = New System.Windows.Forms.Button()
        Me.btn_students = New System.Windows.Forms.Button()
        Me.btn_teacher = New System.Windows.Forms.Button()
        Me.btn_subjects = New System.Windows.Forms.Button()
        Me.btn_year_section = New System.Windows.Forms.Button()
        Me.btn_courses = New System.Windows.Forms.Button()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnl_control = New System.Windows.Forms.Panel()
        Me.btn_archives = New System.Windows.Forms.Button()
        Me.uc_grades = New GradingSystem.uc_grades()
        Me.uc_subjects = New GradingSystem.uc_subjects()
        Me.uc_dashboard = New GradingSystem.uc_dashboard()
        Me.uc_year_section = New GradingSystem.uc_year_section()
        Me.uc_courses = New GradingSystem.uc_courses()
        Me.uc_students = New GradingSystem.uc_students()
        Me.uc_teachers = New GradingSystem.uc_teachers()
        Me.uc_archives = New GradingSystem.uc_archives()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnl_control.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btn_password_setting)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.txt_name)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(967, 40)
        Me.Panel1.TabIndex = 0
        '
        'btn_password_setting
        '
        Me.btn_password_setting.FlatAppearance.BorderSize = 0
        Me.btn_password_setting.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_password_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_password_setting.Location = New System.Drawing.Point(711, 0)
        Me.btn_password_setting.Name = "btn_password_setting"
        Me.btn_password_setting.Size = New System.Drawing.Size(148, 40)
        Me.btn_password_setting.TabIndex = 7
        Me.btn_password_setting.Text = "Password Setting"
        Me.btn_password_setting.UseVisualStyleBackColor = True
        '
        'btn_logout
        '
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Location = New System.Drawing.Point(862, 0)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(105, 40)
        Me.btn_logout.TabIndex = 6
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'txt_name
        '
        Me.txt_name.BackColor = System.Drawing.SystemColors.Control
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_name.Enabled = False
        Me.txt_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_name.Location = New System.Drawing.Point(18, 11)
        Me.txt_name.Multiline = True
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(672, 20)
        Me.txt_name.TabIndex = 4
        Me.txt_name.Text = "Greetings"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SlateGray
        Me.Panel2.Controls.Add(Me.btn_archives)
        Me.Panel2.Controls.Add(Me.btn_grades)
        Me.Panel2.Controls.Add(Me.btn_students)
        Me.Panel2.Controls.Add(Me.btn_teacher)
        Me.Panel2.Controls.Add(Me.btn_subjects)
        Me.Panel2.Controls.Add(Me.btn_year_section)
        Me.Panel2.Controls.Add(Me.btn_courses)
        Me.Panel2.Controls.Add(Me.btn_dashboard)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(-1, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(180, 533)
        Me.Panel2.TabIndex = 1
        '
        'btn_grades
        '
        Me.btn_grades.BackColor = System.Drawing.Color.SlateGray
        Me.btn_grades.FlatAppearance.BorderSize = 0
        Me.btn_grades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_grades.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_grades.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_grades.Location = New System.Drawing.Point(0, 292)
        Me.btn_grades.Name = "btn_grades"
        Me.btn_grades.Size = New System.Drawing.Size(180, 40)
        Me.btn_grades.TabIndex = 27
        Me.btn_grades.Text = "     Grades"
        Me.btn_grades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_grades.UseVisualStyleBackColor = False
        '
        'btn_students
        '
        Me.btn_students.BackColor = System.Drawing.Color.SlateGray
        Me.btn_students.FlatAppearance.BorderSize = 0
        Me.btn_students.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_students.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_students.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_students.Location = New System.Drawing.Point(0, 252)
        Me.btn_students.Name = "btn_students"
        Me.btn_students.Size = New System.Drawing.Size(180, 40)
        Me.btn_students.TabIndex = 26
        Me.btn_students.Text = "     Students"
        Me.btn_students.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_students.UseVisualStyleBackColor = False
        '
        'btn_teacher
        '
        Me.btn_teacher.BackColor = System.Drawing.Color.SlateGray
        Me.btn_teacher.FlatAppearance.BorderSize = 0
        Me.btn_teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_teacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_teacher.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_teacher.Location = New System.Drawing.Point(0, 212)
        Me.btn_teacher.Name = "btn_teacher"
        Me.btn_teacher.Size = New System.Drawing.Size(180, 40)
        Me.btn_teacher.TabIndex = 25
        Me.btn_teacher.Text = "     Teachers"
        Me.btn_teacher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_teacher.UseVisualStyleBackColor = False
        '
        'btn_subjects
        '
        Me.btn_subjects.BackColor = System.Drawing.Color.SlateGray
        Me.btn_subjects.FlatAppearance.BorderSize = 0
        Me.btn_subjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_subjects.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_subjects.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_subjects.Location = New System.Drawing.Point(0, 172)
        Me.btn_subjects.Name = "btn_subjects"
        Me.btn_subjects.Size = New System.Drawing.Size(180, 40)
        Me.btn_subjects.TabIndex = 24
        Me.btn_subjects.Text = "     Subjects"
        Me.btn_subjects.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_subjects.UseVisualStyleBackColor = False
        '
        'btn_year_section
        '
        Me.btn_year_section.BackColor = System.Drawing.Color.SlateGray
        Me.btn_year_section.FlatAppearance.BorderSize = 0
        Me.btn_year_section.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_year_section.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_year_section.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_year_section.Location = New System.Drawing.Point(0, 132)
        Me.btn_year_section.Name = "btn_year_section"
        Me.btn_year_section.Size = New System.Drawing.Size(180, 40)
        Me.btn_year_section.TabIndex = 23
        Me.btn_year_section.Text = "     Sections"
        Me.btn_year_section.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_year_section.UseVisualStyleBackColor = False
        '
        'btn_courses
        '
        Me.btn_courses.BackColor = System.Drawing.Color.SlateGray
        Me.btn_courses.FlatAppearance.BorderSize = 0
        Me.btn_courses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_courses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_courses.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_courses.Location = New System.Drawing.Point(0, 91)
        Me.btn_courses.Name = "btn_courses"
        Me.btn_courses.Size = New System.Drawing.Size(180, 40)
        Me.btn_courses.TabIndex = 22
        Me.btn_courses.Text = "     Courses"
        Me.btn_courses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_courses.UseVisualStyleBackColor = False
        '
        'btn_dashboard
        '
        Me.btn_dashboard.BackColor = System.Drawing.Color.LightSlateGray
        Me.btn_dashboard.FlatAppearance.BorderSize = 0
        Me.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_dashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_dashboard.Location = New System.Drawing.Point(0, 51)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(180, 40)
        Me.btn_dashboard.TabIndex = 21
        Me.btn_dashboard.Text = "     Dashboard"
        Me.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_dashboard.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(0, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(180, 51)
        Me.Panel3.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(13, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(158, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PSU - Grading System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'pnl_control
        '
        Me.pnl_control.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnl_control.Controls.Add(Me.uc_archives)
        Me.pnl_control.Controls.Add(Me.uc_grades)
        Me.pnl_control.Controls.Add(Me.uc_subjects)
        Me.pnl_control.Controls.Add(Me.uc_dashboard)
        Me.pnl_control.Controls.Add(Me.uc_year_section)
        Me.pnl_control.Controls.Add(Me.uc_courses)
        Me.pnl_control.Controls.Add(Me.uc_students)
        Me.pnl_control.Controls.Add(Me.uc_teachers)
        Me.pnl_control.Location = New System.Drawing.Point(179, 40)
        Me.pnl_control.Name = "pnl_control"
        Me.pnl_control.Size = New System.Drawing.Size(787, 523)
        Me.pnl_control.TabIndex = 2
        '
        'btn_archives
        '
        Me.btn_archives.BackColor = System.Drawing.Color.SlateGray
        Me.btn_archives.FlatAppearance.BorderSize = 0
        Me.btn_archives.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_archives.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_archives.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_archives.Location = New System.Drawing.Point(0, 332)
        Me.btn_archives.Name = "btn_archives"
        Me.btn_archives.Size = New System.Drawing.Size(180, 40)
        Me.btn_archives.TabIndex = 28
        Me.btn_archives.Text = "     Archives"
        Me.btn_archives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_archives.UseVisualStyleBackColor = False
        '
        'uc_grades
        '
        Me.uc_grades.BackColor = System.Drawing.SystemColors.Control
        Me.uc_grades.Course = Nothing
        Me.uc_grades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uc_grades.Location = New System.Drawing.Point(0, 0)
        Me.uc_grades.Name = "uc_grades"
        Me.uc_grades.SchoolYear = Nothing
        Me.uc_grades.Size = New System.Drawing.Size(787, 523)
        Me.uc_grades.TabIndex = 6
        Me.uc_grades.UserId = Nothing
        Me.uc_grades.YearLevel = Nothing
        '
        'uc_subjects
        '
        Me.uc_subjects.BackColor = System.Drawing.SystemColors.Control
        Me.uc_subjects.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uc_subjects.Location = New System.Drawing.Point(0, 0)
        Me.uc_subjects.Name = "uc_subjects"
        Me.uc_subjects.Size = New System.Drawing.Size(787, 523)
        Me.uc_subjects.TabIndex = 3
        Me.uc_subjects.UserFullName = Nothing
        Me.uc_subjects.UserId = Nothing
        Me.uc_subjects.UserType = Nothing
        '
        'uc_dashboard
        '
        Me.uc_dashboard.BackColor = System.Drawing.SystemColors.Control
        Me.uc_dashboard.Location = New System.Drawing.Point(0, 0)
        Me.uc_dashboard.Name = "uc_dashboard"
        Me.uc_dashboard.Size = New System.Drawing.Size(787, 523)
        Me.uc_dashboard.TabIndex = 0
        '
        'uc_year_section
        '
        Me.uc_year_section.BackColor = System.Drawing.SystemColors.Control
        Me.uc_year_section.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uc_year_section.Location = New System.Drawing.Point(0, 0)
        Me.uc_year_section.Name = "uc_year_section"
        Me.uc_year_section.Size = New System.Drawing.Size(787, 523)
        Me.uc_year_section.TabIndex = 2
        Me.uc_year_section.UserFullName = Nothing
        Me.uc_year_section.UserId = Nothing
        Me.uc_year_section.UserType = Nothing
        '
        'uc_courses
        '
        Me.uc_courses.BackColor = System.Drawing.SystemColors.Control
        Me.uc_courses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uc_courses.Location = New System.Drawing.Point(0, 0)
        Me.uc_courses.Name = "uc_courses"
        Me.uc_courses.Size = New System.Drawing.Size(787, 523)
        Me.uc_courses.TabIndex = 1
        '
        'uc_students
        '
        Me.uc_students.BackColor = System.Drawing.SystemColors.Control
        Me.uc_students.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uc_students.Location = New System.Drawing.Point(0, 0)
        Me.uc_students.Name = "uc_students"
        Me.uc_students.Size = New System.Drawing.Size(787, 523)
        Me.uc_students.TabIndex = 5
        '
        'uc_teachers
        '
        Me.uc_teachers.BackColor = System.Drawing.SystemColors.Control
        Me.uc_teachers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uc_teachers.Location = New System.Drawing.Point(0, 0)
        Me.uc_teachers.Name = "uc_teachers"
        Me.uc_teachers.Size = New System.Drawing.Size(787, 523)
        Me.uc_teachers.TabIndex = 4
        '
        'uc_archives
        '
        Me.uc_archives.BackColor = System.Drawing.SystemColors.Control
        Me.uc_archives.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uc_archives.Location = New System.Drawing.Point(0, 0)
        Me.uc_archives.Name = "uc_archives"
        Me.uc_archives.Size = New System.Drawing.Size(787, 523)
        Me.uc_archives.TabIndex = 7
        '
        'frm_dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(965, 562)
        Me.Controls.Add(Me.pnl_control)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnl_control.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_dashboard As System.Windows.Forms.Button
    Friend WithEvents btn_year_section As System.Windows.Forms.Button
    Friend WithEvents btn_courses As System.Windows.Forms.Button
    Friend WithEvents btn_grades As System.Windows.Forms.Button
    Friend WithEvents btn_students As System.Windows.Forms.Button
    Friend WithEvents btn_teacher As System.Windows.Forms.Button
    Friend WithEvents btn_subjects As System.Windows.Forms.Button
    Friend WithEvents pnl_control As System.Windows.Forms.Panel
    Friend WithEvents uc_dashboard As GradingSystem.uc_dashboard
    Friend WithEvents uc_courses As GradingSystem.uc_courses
    Friend WithEvents uc_year_section As GradingSystem.uc_year_section
    Friend WithEvents uc_subjects As GradingSystem.uc_subjects
    Friend WithEvents uc_teachers As GradingSystem.uc_teachers
    Friend WithEvents uc_students As GradingSystem.uc_students
    Friend WithEvents uc_grades As GradingSystem.uc_grades
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_password_setting As System.Windows.Forms.Button
    Friend WithEvents btn_archives As System.Windows.Forms.Button
    Friend WithEvents uc_archives As GradingSystem.uc_archives
End Class
