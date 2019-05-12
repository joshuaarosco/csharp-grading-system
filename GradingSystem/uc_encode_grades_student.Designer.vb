<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_encode_grades_student
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
        Me.lbl_section = New System.Windows.Forms.Label()
        Me.dgv_datas = New System.Windows.Forms.DataGridView()
        Me.pnl_load = New System.Windows.Forms.Panel()
        Me.lbl_load = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_datas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_load.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SlateGray
        Me.Panel3.Controls.Add(Me.lbl_section)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(762, 50)
        Me.Panel3.TabIndex = 13
        '
        'lbl_section
        '
        Me.lbl_section.AutoSize = True
        Me.lbl_section.BackColor = System.Drawing.Color.SlateGray
        Me.lbl_section.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_section.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_section.Location = New System.Drawing.Point(13, 13)
        Me.lbl_section.Name = "lbl_section"
        Me.lbl_section.Size = New System.Drawing.Size(73, 24)
        Me.lbl_section.TabIndex = 5
        Me.lbl_section.Text = "Section"
        '
        'dgv_datas
        '
        Me.dgv_datas.AllowUserToAddRows = False
        Me.dgv_datas.AllowUserToDeleteRows = False
        Me.dgv_datas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_datas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_datas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datas.Location = New System.Drawing.Point(0, 48)
        Me.dgv_datas.Name = "dgv_datas"
        Me.dgv_datas.Size = New System.Drawing.Size(762, 340)
        Me.dgv_datas.TabIndex = 14
        '
        'pnl_load
        '
        Me.pnl_load.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnl_load.Controls.Add(Me.lbl_load)
        Me.pnl_load.Location = New System.Drawing.Point(0, 48)
        Me.pnl_load.Name = "pnl_load"
        Me.pnl_load.Size = New System.Drawing.Size(762, 340)
        Me.pnl_load.TabIndex = 15
        '
        'lbl_load
        '
        Me.lbl_load.AutoSize = True
        Me.lbl_load.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_load.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_load.Location = New System.Drawing.Point(345, 157)
        Me.lbl_load.Name = "lbl_load"
        Me.lbl_load.Size = New System.Drawing.Size(84, 15)
        Me.lbl_load.TabIndex = 0
        Me.lbl_load.Text = "Load students"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Location = New System.Drawing.Point(0, 381)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(762, 67)
        Me.Panel1.TabIndex = 17
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btn_save.Location = New System.Drawing.Point(636, 13)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(115, 40)
        Me.btn_save.TabIndex = 3
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = False
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl_load)
        Me.Controls.Add(Me.dgv_datas)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "uc_encode_grades_student"
        Me.Size = New System.Drawing.Size(762, 448)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgv_datas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_load.ResumeLayout(False)
        Me.pnl_load.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_section As System.Windows.Forms.Label
    Friend WithEvents dgv_datas As System.Windows.Forms.DataGridView
    Friend WithEvents pnl_load As System.Windows.Forms.Panel
    Friend WithEvents lbl_load As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button

End Class
