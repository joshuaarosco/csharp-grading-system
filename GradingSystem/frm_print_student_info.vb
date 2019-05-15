Public Class frm_print_student_info

    Public Property StudentId

    Private Sub frm_print_student_info_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_print_Click(sender As System.Object, e As System.EventArgs) Handles btn_print.Click
        btn_print.Visible = False
        btn_close.Visible = False
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print()
        btn_print.Visible = True
        btn_close.Visible = True
    End Sub

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class