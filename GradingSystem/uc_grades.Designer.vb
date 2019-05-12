<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc_grades
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_search = New System.Windows.Forms.TextBox()
        Me.dgv_datas = New System.Windows.Forms.DataGridView()
        Me.pnl_cover = New System.Windows.Forms.Panel()
        Me.lbl_load = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_datas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_cover.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(787, 50)
        Me.Panel3.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 24)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Grades"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(12, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(763, 67)
        Me.Panel1.TabIndex = 16
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.txt_search)
        Me.Panel2.Location = New System.Drawing.Point(12, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(738, 40)
        Me.Panel2.TabIndex = 2
        '
        'txt_search
        '
        Me.txt_search.BackColor = System.Drawing.SystemColors.Control
        Me.txt_search.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_search.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_search.Location = New System.Drawing.Point(11, 13)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Size = New System.Drawing.Size(710, 13)
        Me.txt_search.TabIndex = 0
        '
        'dgv_datas
        '
        Me.dgv_datas.AllowUserToAddRows = False
        Me.dgv_datas.AllowUserToDeleteRows = False
        Me.dgv_datas.AllowUserToResizeRows = False
        Me.dgv_datas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_datas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_datas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_datas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_datas.Location = New System.Drawing.Point(12, 140)
        Me.dgv_datas.Name = "dgv_datas"
        Me.dgv_datas.ReadOnly = True
        Me.dgv_datas.Size = New System.Drawing.Size(763, 370)
        Me.dgv_datas.TabIndex = 17
        '
        'pnl_cover
        '
        Me.pnl_cover.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pnl_cover.Controls.Add(Me.lbl_load)
        Me.pnl_cover.Location = New System.Drawing.Point(12, 62)
        Me.pnl_cover.Name = "pnl_cover"
        Me.pnl_cover.Size = New System.Drawing.Size(763, 448)
        Me.pnl_cover.TabIndex = 20
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
        'uc_grades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnl_cover)
        Me.Controls.Add(Me.dgv_datas)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "uc_grades"
        Me.Size = New System.Drawing.Size(787, 523)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgv_datas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_cover.ResumeLayout(False)
        Me.pnl_cover.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_search As System.Windows.Forms.TextBox
    Friend WithEvents dgv_datas As System.Windows.Forms.DataGridView
    Friend WithEvents pnl_cover As System.Windows.Forms.Panel
    Friend WithEvents lbl_load As System.Windows.Forms.Label

End Class
