<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_subjects
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_search = New System.Windows.Forms.Panel()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.btn_create = New System.Windows.Forms.Button()
        Me.dgv_datas = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnl_cover = New System.Windows.Forms.Panel()
        Me.lbl_load = New System.Windows.Forms.Label()
        Me.pnl_action = New System.Windows.Forms.Panel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_encode = New System.Windows.Forms.Button()
        Me.pnl_refresh = New System.Windows.Forms.Panel()
        Me.lbl_refresh = New System.Windows.Forms.Label()
        Me.uc_edit_subject = New GradingSystem.uc_edit_subject()
        Me.uc_encode_grades_sections = New GradingSystem.uc_encode_grades_sections()
        Me.uc_create_subject = New GradingSystem.uc_create_subject()
        Me.Panel1.SuspendLayout()
        Me.pnl_search.SuspendLayout()
        CType(Me.dgv_datas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_cover.SuspendLayout()
        Me.pnl_action.SuspendLayout()
        Me.pnl_refresh.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(8, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Subjects"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.pnl_search)
        Me.Panel1.Controls.Add(Me.btn_create)
        Me.Panel1.Location = New System.Drawing.Point(12, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 67)
        Me.Panel1.TabIndex = 10
        '
        'pnl_search
        '
        Me.pnl_search.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_search.Controls.Add(Me.txt_search)
        Me.pnl_search.Location = New System.Drawing.Point(13, 13)
        Me.pnl_search.Name = "pnl_search"
        Me.pnl_search.Size = New System.Drawing.Size(607, 40)
        Me.pnl_search.TabIndex = 2
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.SystemColors.Control
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_search.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_search.Location = New System.Drawing.Point(15, 14)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(578, 13)
        Me.txt_search.TabIndex = 0
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_create.FlatAppearance.BorderSize = 0
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_create.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_create.Location = New System.Drawing.Point(635, 13)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(115, 40)
        Me.btn_create.TabIndex = 1
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'dgv_datas
        '
        Me.dgv_datas.AllowUserToAddRows = False
        Me.dgv_datas.AllowUserToDeleteRows = False
        Me.dgv_datas.AllowUserToResizeRows = False
        Me.dgv_datas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgv_datas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_datas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datas.Location = New System.Drawing.Point(12, 140)
        Me.dgv_datas.Name = "dgv_datas"
        Me.dgv_datas.ReadOnly = True
        Me.dgv_datas.Size = New System.Drawing.Size(763, 370)
        Me.dgv_datas.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(787, 50)
        Me.Panel3.TabIndex = 12
        '
        'pnl_cover
        '
        Me.pnl_cover.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnl_cover.Controls.Add(Me.lbl_load)
        Me.pnl_cover.Location = New System.Drawing.Point(12, 62)
        Me.pnl_cover.Name = "pnl_cover"
        Me.pnl_cover.Size = New System.Drawing.Size(763, 448)
        Me.pnl_cover.TabIndex = 14
        '
        'lbl_load
        '
        Me.lbl_load.AutoSize = True
        Me.lbl_load.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_load.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_load.Location = New System.Drawing.Point(334, 199)
        Me.lbl_load.Name = "lbl_load"
        Me.lbl_load.Size = New System.Drawing.Size(103, 15)
        Me.lbl_load.TabIndex = 0
        Me.lbl_load.Text = "Click to load table"
        '
        'pnl_action
        '
        Me.pnl_action.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pnl_action.Controls.Add(Me.btn_delete)
        Me.pnl_action.Controls.Add(Me.btn_edit)
        Me.pnl_action.Controls.Add(Me.btn_close)
        Me.pnl_action.Controls.Add(Me.btn_encode)
        Me.pnl_action.Location = New System.Drawing.Point(12, 443)
        Me.pnl_action.Name = "pnl_action"
        Me.pnl_action.Size = New System.Drawing.Size(763, 67)
        Me.pnl_action.TabIndex = 1
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_delete.Location = New System.Drawing.Point(375, 14)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(115, 40)
        Me.btn_delete.TabIndex = 5
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit.Location = New System.Drawing.Point(505, 14)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(115, 40)
        Me.btn_edit.TabIndex = 4
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_close.Location = New System.Drawing.Point(244, 14)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(115, 40)
        Me.btn_close.TabIndex = 3
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_encode
        '
        Me.btn_encode.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_encode.FlatAppearance.BorderSize = 0
        Me.btn_encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_encode.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_encode.Location = New System.Drawing.Point(635, 14)
        Me.btn_encode.Name = "btn_encode"
        Me.btn_encode.Size = New System.Drawing.Size(115, 40)
        Me.btn_encode.TabIndex = 2
        Me.btn_encode.Text = "View"
        Me.btn_encode.UseVisualStyleBackColor = False
        '
        'pnl_refresh
        '
        Me.pnl_refresh.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_refresh.Controls.Add(Me.lbl_refresh)
        Me.pnl_refresh.Location = New System.Drawing.Point(291, 264)
        Me.pnl_refresh.Name = "pnl_refresh"
        Me.pnl_refresh.Size = New System.Drawing.Size(200, 69)
        Me.pnl_refresh.TabIndex = 18
        '
        'lbl_refresh
        '
        Me.lbl_refresh.AutoSize = True
        Me.lbl_refresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_refresh.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_refresh.Location = New System.Drawing.Point(76, 29)
        Me.lbl_refresh.Name = "lbl_refresh"
        Me.lbl_refresh.Size = New System.Drawing.Size(56, 13)
        Me.lbl_refresh.TabIndex = 0
        Me.lbl_refresh.Text = "Refresh ..."
        '
        'uc_edit_subject
        '
        Me.uc_edit_subject.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.uc_edit_subject.Location = New System.Drawing.Point(12, 140)
        Me.uc_edit_subject.Name = "uc_edit_subject"
        Me.uc_edit_subject.Size = New System.Drawing.Size(763, 370)
        Me.uc_edit_subject.TabIndex = 1
        '
        'uc_encode_grades_sections
        '
        Me.uc_encode_grades_sections.Course = Nothing
        Me.uc_encode_grades_sections.Location = New System.Drawing.Point(1, 0)
        Me.uc_encode_grades_sections.Name = "uc_encode_grades_sections"
        Me.uc_encode_grades_sections.SchoolYear = Nothing
        Me.uc_encode_grades_sections.Size = New System.Drawing.Size(787, 523)
        Me.uc_encode_grades_sections.SubjectCode = Nothing
        Me.uc_encode_grades_sections.SubjectId = Nothing
        Me.uc_encode_grades_sections.SubjectName = Nothing
        Me.uc_encode_grades_sections.TabIndex = 1
        Me.uc_encode_grades_sections.UserType = Nothing
        Me.uc_encode_grades_sections.YearLevel = Nothing
        '
        'uc_create_subject
        '
        Me.uc_create_subject.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.uc_create_subject.Location = New System.Drawing.Point(12, 140)
        Me.uc_create_subject.Name = "uc_create_subject"
        Me.uc_create_subject.Size = New System.Drawing.Size(763, 370)
        Me.uc_create_subject.TabIndex = 13
        '
        'uc_subjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Controls.Add(Me.uc_edit_subject)
        Me.Controls.Add(Me.uc_encode_grades_sections)
        Me.Controls.Add(Me.pnl_cover)
        Me.Controls.Add(Me.uc_create_subject)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pnl_refresh)
        Me.Controls.Add(Me.pnl_action)
        Me.Controls.Add(Me.dgv_datas)
        Me.Name = "uc_subjects"
        Me.Size = New System.Drawing.Size(787, 523)
        Me.Panel1.ResumeLayout(False)
        Me.pnl_search.ResumeLayout(False)
        Me.pnl_search.PerformLayout()
        CType(Me.dgv_datas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_cover.ResumeLayout(False)
        Me.pnl_cover.PerformLayout()
        Me.pnl_action.ResumeLayout(False)
        Me.pnl_refresh.ResumeLayout(False)
        Me.pnl_refresh.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pnl_search As System.Windows.Forms.Panel
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_create As System.Windows.Forms.Button
    Friend WithEvents dgv_datas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents uc_create_subject As GradingSystem.uc_create_subject
    Friend WithEvents pnl_cover As System.Windows.Forms.Panel
    Friend WithEvents lbl_load As System.Windows.Forms.Label
    Friend WithEvents pnl_action As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_encode As System.Windows.Forms.Button
    Friend WithEvents uc_encode_grades_sections As GradingSystem.uc_encode_grades_sections
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents pnl_refresh As System.Windows.Forms.Panel
    Friend WithEvents lbl_refresh As System.Windows.Forms.Label
    Friend WithEvents uc_edit_subject As GradingSystem.uc_edit_subject

End Class
