Imports HPGL2GCODE.Functions
Public Class Main

    Dim file_hpgl As System.IO.StreamReader
    Dim file_gcode As System.IO.StreamWriter
    Dim string_hpgl As String
    Dim string_gcode As String
    Dim buff As Byte
    Dim file_opened As Boolean = False
    Dim processed As Boolean = False

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            file_hpgl = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
            string_hpgl = file_hpgl.ReadToEnd()
            file_opened = True
            processed = False
            ProgressBar1.Value = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MsgBox(TestFunc, MsgBoxStyle.OkOnly, "Test")
        Dim test As String = "test" & Environment.NewLine
        MsgBox(test.Length)
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (file_opened And Not processed) Then
            If (MsgBox("Are you sure you want to exit?" & Environment.NewLine & "You did not process the file.", MsgBoxStyle.YesNo, "Closing...") = MsgBoxResult.No) Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Nothing special here yet...
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim dr As Integer = Settings.ShowDialog() '1 Is OK, 3 is Abort, 2 is Cancel (or Window Closed)
        If (dr = DialogResult.OK Or dr = DialogResult.Abort) Then
            Settings.Close()
        End If
    End Sub

    Private Sub btn_convert_Click(sender As Object, e As EventArgs) Handles btn_convert.Click
        Dim errors_log As String = ""
        If (file_opened) Then
            SaveFileDialog1.FileName = OpenFileDialog1.SafeFileName.Remove(OpenFileDialog1.SafeFileName.LastIndexOf(".")) 'Removing the extension here...
            SaveFileDialog1.InitialDirectory = OpenFileDialog1.InitialDirectory 'Save the file in the same folder to the original
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                processed = ProcessHPGL(string_hpgl, string_gcode, errors_log) 'The function that does everything!
                If (processed) Then
                    file_gcode = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)
                    file_gcode.Write(string_gcode) 'Write the result to the file
                    file_gcode.Close()
                Else
                    If (MsgBox("Errors:" & Environment.NewLine & errors_log, MsgBoxStyle.YesNo, "Error Converting...") = MsgBoxResult.Yes) Then
                        file_gcode = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)
                        file_gcode.Write(string_gcode) 'Write the result to the file
                        file_gcode.Close()
                        processed = True
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim pen As New Pen(Color.FromArgb(255, 0, 0, 0))
        pen.Width = 1
        e.Graphics.DrawLine(pen, CInt(Panel1.Width * 1 / 400), CInt(Panel1.Height * 1 / 300), CInt(Panel1.Width * 1 / 400 + 150), CInt(Panel1.Height * 1 / 300 + 150))
    End Sub

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'ProgressBar1.Location = New Point(0, Me.Height - 48)
        'ProgressBar1.Width = Me.Width
        'Panel1.Width = Me.Width
        'Panel1.Height = Me.Height - 100
        Panel1.Invalidate()
    End Sub
End Class
