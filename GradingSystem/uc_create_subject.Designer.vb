<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_create_subject
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_subject = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_subject_code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txt_semester = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Units = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_units = New System.Windows.Forms.TextBox()
        Me.mtxt_school_year = New System.Windows.Forms.MaskedTextBox()
        Me.cb_course = New System.Windows.Forms.ComboBox()
        Me.cb_year_level = New System.Windows.Forms.ComboBox()
        Me.cb_teacher = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_cancel.Location = New System.Drawing.Point(30, 312)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(337, 40)
        Me.btn_cancel.TabIndex = 17
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_save.Location = New System.Drawing.Point(398, 312)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(337, 40)
        Me.btn_save.TabIndex = 16
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(395, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Subject Title :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.txt_subject)
        Me.Panel1.Location = New System.Drawing.Point(398, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 40)
        Me.Panel1.TabIndex = 14
        '
        'txt_subject
        '
        Me.txt_subject.BackColor = System.Drawing.SystemColors.Control
        Me.txt_subject.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subject.Location = New System.Drawing.Point(12, 13)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(308, 14)
        Me.txt_subject.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(27, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Subject Code :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.txt_subject_code)
        Me.Panel2.Location = New System.Drawing.Point(30, 64)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(337, 40)
        Me.Panel2.TabIndex = 12
        '
        'txt_subject_code
        '
        Me.txt_subject_code.BackColor = System.Drawing.SystemColors.Control
        Me.txt_subject_code.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_subject_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subject_code.Location = New System.Drawing.Point(12, 13)
        Me.txt_subject_code.Name = "txt_subject_code"
        Me.txt_subject_code.Size = New System.Drawing.Size(310, 14)
        Me.txt_subject_code.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Create Subject"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(395, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "School Year :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.mtxt_school_year)
        Me.Panel4.Location = New System.Drawing.Point(398, 188)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(337, 40)
        Me.Panel4.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(28, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Teacher :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.cb_teacher)
        Me.Panel3.Location = New System.Drawing.Point(30, 250)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(704, 40)
        Me.Panel3.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(395, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Year Level :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Location = New System.Drawing.Point(398, 126)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(156, 40)
        Me.Panel5.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(27, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Course :"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Location = New System.Drawing.Point(30, 126)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(337, 40)
        Me.Panel6.TabIndex = 26
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Controls.Add(Me.txt_semester)
        Me.Panel7.Location = New System.Drawing.Point(579, 126)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(156, 40)
        Me.Panel7.TabIndex = 29
        '
        'txt_semester
        '
        Me.txt_semester.BackColor = System.Drawing.SystemColors.Control
        Me.txt_semester.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_semester.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_semester.Location = New System.Drawing.Point(14, 13)
        Me.txt_semester.Name = "txt_semester"
        Me.txt_semester.Size = New System.Drawing.Size(129, 14)
        Me.txt_semester.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(576, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Semester :"
        '
        'Units
        '
        Me.Units.AutoSize = True
        Me.Units.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Units.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Units.Location = New System.Drawing.Point(28, 169)
        Me.Units.Name = "Units"
        Me.Units.Size = New System.Drawing.Size(44, 16)
        Me.Units.TabIndex = 27
        Me.Units.Text = "Units :"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.Controls.Add(Me.txt_units)
        Me.Panel8.Location = New System.Drawing.Point(30, 188)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(337, 40)
        Me.Panel8.TabIndex = 26
        '
        'txt_units
        '
        Me.txt_units.BackColor = System.Drawing.SystemColors.Control
        Me.txt_units.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_units.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_units.Location = New System.Drawing.Point(12, 13)
        Me.txt_units.Name = "txt_units"
        Me.txt_units.Size = New System.Drawing.Size(310, 14)
        Me.txt_units.TabIndex = 1
        '
        'mtxt_school_year
        '
        Me.mtxt_school_year.BackColor = System.Drawing.SystemColors.Control
        Me.mtxt_school_year.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtxt_school_year.Location = New System.Drawing.Point(12, 14)
        Me.mtxt_school_year.Mask = "0000 - 0000"
        Me.mtxt_school_year.Name = "mtxt_school_year"
        Me.mtxt_school_year.Size = New System.Drawing.Size(308, 13)
        Me.mtxt_school_year.TabIndex = 2
        '
        'cb_course
        '
        Me.cb_course.BackColor = System.Drawing.SystemColors.Control
        Me.cb_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_course.FormattingEnabled = True
        Me.cb_course.Location = New System.Drawing.Point(42, 136)
        Me.cb_course.Name = "cb_course"
        Me.cb_course.Size = New System.Drawing.Size(310, 21)
        Me.cb_course.TabIndex = 25
        '
        'cb_year_level
        '
        Me.cb_year_level.BackColor = System.Drawing.SystemColors.Control
        Me.cb_year_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_year_level.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_year_level.FormattingEnabled = True
        Me.cb_year_level.Location = New System.Drawing.Point(412, 136)
        Me.cb_year_level.Name = "cb_year_level"
        Me.cb_year_level.Size = New System.Drawing.Size(128, 21)
        Me.cb_year_level.TabIndex = 31
        '
        'cb_teacher
        '
        Me.cb_teacher.BackColor = System.Drawing.SystemColors.Control
        Me.cb_teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_teacher.FormattingEnabled = True
        Me.cb_teacher.Location = New System.Drawing.Point(12, 10)
        Me.cb_teacher.Name = "cb_teacher"
        Me.cb_teacher.Size = New System.Drawing.Size(676, 21)
        Me.cb_teacher.TabIndex = 32
        '
        'uc_create_subject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.cb_year_level)
        Me.Controls.Add(Me.cb_course)
        Me.Controls.Add(Me.Units)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uc_create_subject"
        Me.Size = New System.Drawing.Size(763, 370)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_subject As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_subject_code As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txt_semester As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Units As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents txt_units As System.Windows.Forms.TextBox
    Friend WithEvents mtxt_school_year As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cb_course As System.Windows.Forms.ComboBox
    Friend WithEvents cb_year_level As System.Windows.Forms.ComboBox
    Friend WithEvents cb_teacher As System.Windows.Forms.ComboBox

End Class
