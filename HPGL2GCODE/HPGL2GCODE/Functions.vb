Public Class Functions
    Shared Function TestFunc()
        Return "Success!"
    End Function

    Shared Function ProcessHPGL(ByVal input As String, ByRef result As String, ByRef errors As String)
        Dim ignoredCommands As String = "IN, IP, SC, SP"
        Dim hpglUnits As Double = 40.2 'Means 1mm = 40 hpgl units

        errors = ""
        Dim values(10) As String
        Dim unrecognized As Integer = 0
        Dim unrecCommands As New System.Text.StringBuilder
        Dim sb As New System.Text.StringBuilder
        Dim indexCount As Integer = 0 'The position inside HPGL for each semicolon (;)
        Dim container As String = input.Replace("; ", ";") '        CleanUp
        container = container.Replace(Environment.NewLine, "") 'A big ass container ;)
        Dim containerProc As String ' Just a small container ;)
        Dim penUp As Boolean = True

        Dim countSemicolons As Integer = 0
        For Each c As Char In container
            If (c = ";") Then
                countSemicolons += 1
            End If
        Next
        Main.ProgressBar1.Maximum = countSemicolons + 2

        sb.Append(My.Settings.StartCode & Environment.NewLine & "G0 Z" & My.Settings.PenUp & " F" & My.Settings.TravelSpeed * 60 & "; Initial raise of Z axis" & Environment.NewLine)
        Main.ProgressBar1.Value = 1

        While (container.Length > 0 And indexCount <> -1) 'Make sure you exit when you reach the end or you might end up in an infinite loop...
            indexCount = container.IndexOf(";")
            If (container.Substring(indexCount + 1).IndexOf("AA") = 0 And container.IndexOf("PA") = 0) Then
                containerProc = container.Remove(container.IndexOf(";", indexCount + 1))
                containerProc = containerProc.Replace(";AA ", ",")
                containerProc = containerProc.Replace("PA", "AA")
                indexCount = container.IndexOf(";", indexCount + 1)
            Else
                containerProc = container.Remove(indexCount)
            End If
            If (containerProc.IndexOf(" ") < 0) Then
                values(0) = 1
                values(1) = containerProc
            Else
                values(1) = containerProc.Remove(containerProc.IndexOf(" "))
                containerProc = containerProc.Substring(containerProc.IndexOf(" ") + 1)
                If (containerProc.IndexOf(",") < 0) Then
                    values(0) = 2
                    values(2) = containerProc
                Else
                    values(0) = 2
                    values(2) = containerProc.Remove(containerProc.IndexOf(","))
                    containerProc = containerProc.Substring(containerProc.IndexOf(",") + 1)
                    While True
                        values(0) += 1
                        If (containerProc.IndexOf(",") >= 0) Then
                            values(values(0)) = containerProc.Remove(containerProc.IndexOf(","))
                            containerProc = containerProc.Substring(containerProc.IndexOf(",") + 1)
                        Else
                            values(values(0)) = containerProc
                            Exit While
                        End If
                    End While
                End If
            End If

            If (values(1).Contains("PA")) Then
                Main.ProgressBar1.Value += 1
                If (penUp) Then
                    sb.Append("G0 X" & Math.Round(CDbl(values(2)) / hpglUnits, 2) & " Y" & Math.Round(values(3) / hpglUnits, 2) & " F" & My.Settings.TravelSpeed * 60 & "" & Environment.NewLine)
                    'sb.Append(values(1) & " " & values(2) & "," & values(3) & "" & Environment.NewLine)' Debug
                Else
                    sb.Append("G1 X" & Math.Round(CDbl(values(2)) / hpglUnits, 2) & " Y" & Math.Round(values(3) / hpglUnits, 2) & " F" & My.Settings.PlotSpeed * 60 & "" & Environment.NewLine)
                    'sb.Append(values(1) & " " & values(2) & "," & values(3) & "" & Environment.NewLine)' Debug
                End If
            ElseIf (values(1).Contains("PU")) Then
                Main.ProgressBar1.Value += 1
                penUp = True
                sb.Append("G0 Z" & My.Settings.PenUp & " F" & My.Settings.TravelSpeed * 60 & "; Raise Z Axis" & Environment.NewLine)
            ElseIf (values(1).Contains("PD")) Then
                Main.ProgressBar1.Value += 1
                penUp = False
                sb.Append("G0 Z0" & " F" & My.Settings.TravelSpeed * 60 & "; Lower Z Axis" & Environment.NewLine)
            ElseIf (values(1).Contains("AA") And values(0) = 6) Then
                sb.Append(values(1) & " X:" & values(2) & " Y:" & values(3) & " cX:" & values(4) & " cY:" & values(5) & " Deg:" & values(6) & Environment.NewLine)


            Else
                If (ignoredCommands.Contains(values(1)) = False) Then
                    unrecognized += 1
                    If (unrecCommands.ToString().Contains(values(1)) = False) Then
                        unrecCommands.Append(values(1) & ", ")
                    End If
                End If
            End If


            container = container.Substring(indexCount + 1)
        End While
        'sb.Append(container)

        sb.Append(My.Settings.EndCode)
        Main.ProgressBar1.Maximum = countSemicolons - unrecognized
        Main.ProgressBar1.Value = countSemicolons - unrecognized
        'MsgBox(Main.ProgressBar1.Maximum.ToString() & ", " & Main.ProgressBar1.Value.ToString()) 'Purely for debugging, really...
        result = sb.ToString()
        If unrecognized > 0 Then
            errors = "Some commands were unrecognised. Contact the developer for this problem." & Environment.NewLine & "Commands: " & Environment.NewLine & unrecCommands.ToString().Substring(0, unrecCommands.ToString().Length - 2) & Environment.NewLine & "Do you still want to convert the file without these commands?"
            Return False
        Else
            Return True
        End If
    End Function
End Class