<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_edit_section
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cb_course = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cb_teacher = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.mtxt_school_year = New System.Windows.Forms.MaskedTextBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_section = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cb_year_level = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(27, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Course :"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.cb_course)
        Me.Panel5.Location = New System.Drawing.Point(30, 64)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(704, 40)
        Me.Panel5.TabIndex = 35
        '
        'cb_course
        '
        Me.cb_course.BackColor = System.Drawing.SystemColors.Control
        Me.cb_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_course.FormattingEnabled = True
        Me.cb_course.Location = New System.Drawing.Point(12, 10)
        Me.cb_course.Name = "cb_course"
        Me.cb_course.Size = New System.Drawing.Size(678, 21)
        Me.cb_course.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(27, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Adviser :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.cb_teacher)
        Me.Panel4.Location = New System.Drawing.Point(30, 188)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(704, 40)
        Me.Panel4.TabIndex = 33
        '
        'cb_teacher
        '
        Me.cb_teacher.BackColor = System.Drawing.SystemColors.Control
        Me.cb_teacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_teacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_teacher.FormattingEnabled = True
        Me.cb_teacher.Location = New System.Drawing.Point(12, 10)
        Me.cb_teacher.Name = "cb_teacher"
        Me.cb_teacher.Size = New System.Drawing.Size(678, 21)
        Me.cb_teacher.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(27, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "School Year :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.mtxt_school_year)
        Me.Panel3.Location = New System.Drawing.Point(30, 250)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(704, 40)
        Me.Panel3.TabIndex = 31
        '
        'mtxt_school_year
        '
        Me.mtxt_school_year.BackColor = System.Drawing.SystemColors.Control
        Me.mtxt_school_year.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtxt_school_year.Location = New System.Drawing.Point(12, 14)
        Me.mtxt_school_year.Mask = "0000 - 0000"
        Me.mtxt_school_year.Name = "mtxt_school_year"
        Me.mtxt_school_year.Size = New System.Drawing.Size(678, 13)
        Me.mtxt_school_year.TabIndex = 5
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
        Me.btn_cancel.TabIndex = 24
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_update.FlatAppearance.BorderSize = 0
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_update.Location = New System.Drawing.Point(397, 312)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(337, 40)
        Me.btn_update.TabIndex = 25
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(394, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Section Title:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.txt_section)
        Me.Panel1.Location = New System.Drawing.Point(397, 126)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 40)
        Me.Panel1.TabIndex = 29
        '
        'txt_section
        '
        Me.txt_section.BackColor = System.Drawing.SystemColors.Control
        Me.txt_section.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_section.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_section.Location = New System.Drawing.Point(12, 13)
        Me.txt_section.Name = "txt_section"
        Me.txt_section.Size = New System.Drawing.Size(311, 14)
        Me.txt_section.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(27, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Year Level :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.cb_year_level)
        Me.Panel2.Location = New System.Drawing.Point(30, 126)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(337, 40)
        Me.Panel2.TabIndex = 27
        '
        'cb_year_level
        '
        Me.cb_year_level.BackColor = System.Drawing.SystemColors.Control
        Me.cb_year_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_year_level.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cb_year_level.FormattingEnabled = True
        Me.cb_year_level.Location = New System.Drawing.Point(12, 10)
        Me.cb_year_level.Name = "cb_year_level"
        Me.cb_year_level.Size = New System.Drawing.Size(312, 21)
        Me.cb_year_level.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 24)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Edit Section"
        '
        'uc_edit_section
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uc_edit_section"
        Me.Size = New System.Drawing.Size(763, 370)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents cb_course As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents cb_teacher As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents mtxt_school_year As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_section As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cb_year_level As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
