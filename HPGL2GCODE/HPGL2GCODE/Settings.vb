Public Class Settings
    Dim sb As New System.Text.StringBuilder

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim errors As Boolean = False
        If (IsNumeric(txt_penUp.Text)) Then
            My.Settings.PenUp = CInt(txt_penUp.Text)
        Else
            errors = True
            sb.Append("Pen Up Height must me a number." & Environment.NewLine)
        End If
        If (IsNumeric(txt_travel_speed.Text)) Then
            My.Settings.TravelSpeed = CInt(txt_travel_speed.Text)
        Else
            errors = True
            sb.Append("Travel Speed must me a number." & Environment.NewLine)
        End If
        If (IsNumeric(txt_plot_speed.Text)) Then
            My.Settings.PlotSpeed = CInt(txt_plot_speed.Text)
        Else
            errors = True
            sb.Append("Plot Speed must me a number." & Environment.NewLine)
        End If
        My.Settings.StartCode = txt_startcode.Text
        My.Settings.EndCode = txt_endgcode.Text


        If (errors) Then
            Dim choice = MsgBox(sb.ToString(), MsgBoxStyle.RetryCancel, "Error")
            If (choice = MsgBoxResult.Retry) Then
                e.Cancel = True
                sb.Clear()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Abort
            End If
        Else
            My.Settings.Save()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl1.Width = Me.Width
        TabControl1.Height = Me.Height
        txt_penUp.Text = My.Settings.PenUp
        txt_travel_speed.Text = My.Settings.TravelSpeed
        txt_plot_speed.Text = My.Settings.PlotSpeed
        txt_startcode.Text = My.Settings.StartCode
        txt_endgcode.Text = My.Settings.EndCode
    End Sub

    Private Sub Settings_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        TabControl1.Width = Me.Width
        TabControl1.Height = Me.Height
        txt_startcode.Width = Me.Width - 25
        txt_startcode.Height = Me.Height - 65
        txt_endgcode.Width = Me.Width - 25
        txt_endgcode.Height = Me.Height - 65
    End Sub
End Class