<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_encode_grades_sections
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_subject = New System.Windows.Forms.Label()
        Me.pnl_load = New System.Windows.Forms.Panel()
        Me.lbl_load = New System.Windows.Forms.Label()
        Me.dgv_datas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_encode = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.uc_encode_grades_student = New GradingSystem.uc_encode_grades_student()
        Me.Panel3.SuspendLayout()
        Me.pnl_load.SuspendLayout()
        CType(Me.dgv_datas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.lbl_subject)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(787, 50)
        Me.Panel3.TabIndex = 13
        '
        'lbl_subject
        '
        Me.lbl_subject.AutoSize = True
        Me.lbl_subject.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_subject.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subject.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbl_subject.Location = New System.Drawing.Point(8, 13)
        Me.lbl_subject.Name = "lbl_subject"
        Me.lbl_subject.Size = New System.Drawing.Size(73, 24)
        Me.lbl_subject.TabIndex = 17
        Me.lbl_subject.Text = "Subject"
        '
        'pnl_load
        '
        Me.pnl_load.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnl_load.Controls.Add(Me.lbl_load)
        Me.pnl_load.Location = New System.Drawing.Point(12, 63)
        Me.pnl_load.Name = "pnl_load"
        Me.pnl_load.Size = New System.Drawing.Size(762, 388)
        Me.pnl_load.TabIndex = 14
        '
        'lbl_load
        '
        Me.lbl_load.AutoSize = True
        Me.lbl_load.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_load.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_load.Location = New System.Drawing.Point(334, 171)
        Me.lbl_load.Name = "lbl_load"
        Me.lbl_load.Size = New System.Drawing.Size(83, 15)
        Me.lbl_load.TabIndex = 0
        Me.lbl_load.Text = "Load sections"
        '
        'dgv_datas
        '
        Me.dgv_datas.AllowUserToAddRows = False
        Me.dgv_datas.AllowUserToDeleteRows = False
        Me.dgv_datas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_datas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_datas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datas.Location = New System.Drawing.Point(12, 63)
        Me.dgv_datas.Name = "dgv_datas"
        Me.dgv_datas.ReadOnly = True
        Me.dgv_datas.Size = New System.Drawing.Size(762, 388)
        Me.dgv_datas.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.btn_encode)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Location = New System.Drawing.Point(12, 444)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(762, 67)
        Me.Panel1.TabIndex = 16
        '
        'btn_encode
        '
        Me.btn_encode.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_encode.FlatAppearance.BorderSize = 0
        Me.btn_encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_encode.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_encode.Location = New System.Drawing.Point(636, 13)
        Me.btn_encode.Name = "btn_encode"
        Me.btn_encode.Size = New System.Drawing.Size(115, 40)
        Me.btn_encode.TabIndex = 3
        Me.btn_encode.Text = "Encode"
        Me.btn_encode.UseVisualStyleBackColor = False
        '
        'btn_back
        '
        Me.btn_back.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_back.Location = New System.Drawing.Point(14, 13)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(115, 40)
        Me.btn_back.TabIndex = 2
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'uc_encode_grades_student
        '
        Me.uc_encode_grades_student.Location = New System.Drawing.Point(12, 63)
        Me.uc_encode_grades_student.Name = "uc_encode_grades_student"
        Me.uc_encode_grades_student.SectionId = Nothing
        Me.uc_encode_grades_student.Size = New System.Drawing.Size(762, 448)
        Me.uc_encode_grades_student.TabIndex = 17
        '
        'uc_encode_grades_sections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.uc_encode_grades_student)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_load)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgv_datas)
        Me.Name = "uc_encode_grades_sections"
        Me.Size = New System.Drawing.Size(787, 523)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnl_load.ResumeLayout(False)
        Me.pnl_load.PerformLayout()
        CType(Me.dgv_datas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_subject As System.Windows.Forms.Label
    Friend WithEvents pnl_load As System.Windows.Forms.Panel
    Friend WithEvents lbl_load As System.Windows.Forms.Label
    Friend WithEvents dgv_datas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_encode As System.Windows.Forms.Button
    Friend WithEvents uc_encode_grades_student As GradingSystem.uc_encode_grades_student

End Class
