<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.general_tab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_plot_speed = New System.Windows.Forms.TextBox()
        Me.txt_travel_speed = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_penUp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.start_code_tab = New System.Windows.Forms.TabPage()
        Me.end_code_tab = New System.Windows.Forms.TabPage()
        Me.txt_startcode = New System.Windows.Forms.RichTextBox()
        Me.txt_endgcode = New System.Windows.Forms.RichTextBox()
        Me.TabControl1.SuspendLayout()
        Me.general_tab.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.start_code_tab.SuspendLayout()
        Me.end_code_tab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.general_tab)
        Me.TabControl1.Controls.Add(Me.start_code_tab)
        Me.TabControl1.Controls.Add(Me.end_code_tab)
        Me.TabControl1.ItemSize = New System.Drawing.Size(62, 18)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(443, 309)
        Me.TabControl1.TabIndex = 3
        '
        'general_tab
        '
        Me.general_tab.Controls.Add(Me.TableLayoutPanel1)
        Me.general_tab.Location = New System.Drawing.Point(4, 22)
        Me.general_tab.Name = "general_tab"
        Me.general_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.general_tab.Size = New System.Drawing.Size(435, 283)
        Me.general_tab.TabIndex = 0
        Me.general_tab.Text = "General"
        Me.general_tab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 257.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_plot_speed, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_travel_speed, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_penUp, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(7, 7)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(422, 270)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pen Up Height (mm):"
        '
        'txt_plot_speed
        '
        Me.txt_plot_speed.Location = New System.Drawing.Point(168, 53)
        Me.txt_plot_speed.Name = "txt_plot_speed"
        Me.txt_plot_speed.Size = New System.Drawing.Size(100, 20)
        Me.txt_plot_speed.TabIndex = 6
        '
        'txt_travel_speed
        '
        Me.txt_travel_speed.Location = New System.Drawing.Point(168, 28)
        Me.txt_travel_speed.Name = "txt_travel_speed"
        Me.txt_travel_speed.Size = New System.Drawing.Size(100, 20)
        Me.txt_travel_speed.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Travel Speed (mm/s):"
        '
        'txt_penUp
        '
        Me.txt_penUp.Location = New System.Drawing.Point(168, 3)
        Me.txt_penUp.Name = "txt_penUp"
        Me.txt_penUp.Size = New System.Drawing.Size(100, 20)
        Me.txt_penUp.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Plot Speed (mm/s):"
        '
        'start_code_tab
        '
        Me.start_code_tab.Controls.Add(Me.txt_startcode)
        Me.start_code_tab.Location = New System.Drawing.Point(4, 22)
        Me.start_code_tab.Name = "start_code_tab"
        Me.start_code_tab.Padding = New System.Windows.Forms.Padding(3)
        Me.start_code_tab.Size = New System.Drawing.Size(435, 283)
        Me.start_code_tab.TabIndex = 1
        Me.start_code_tab.Text = "Start Gcode"
        Me.start_code_tab.UseVisualStyleBackColor = True
        '
        'end_code_tab
        '
        Me.end_code_tab.Controls.Add(Me.txt_endgcode)
        Me.end_code_tab.Location = New System.Drawing.Point(4, 22)
        Me.end_code_tab.Name = "end_code_tab"
        Me.end_code_tab.Size = New System.Drawing.Size(435, 283)
        Me.end_code_tab.TabIndex = 2
        Me.end_code_tab.Text = "End Gcode"
        Me.end_code_tab.UseVisualStyleBackColor = True
        '
        'txt_startcode
        '
        Me.txt_startcode.Location = New System.Drawing.Point(0, 0)
        Me.txt_startcode.Name = "txt_startcode"
        Me.txt_startcode.Size = New System.Drawing.Size(422, 270)
        Me.txt_startcode.TabIndex = 0
        Me.txt_startcode.Text = ""
        '
        'txt_endgcode
        '
        Me.txt_endgcode.Location = New System.Drawing.Point(0, 0)
        Me.txt_endgcode.Name = "txt_endgcode"
        Me.txt_endgcode.Size = New System.Drawing.Size(420, 268)
        Me.txt_endgcode.TabIndex = 0
        Me.txt_endgcode.Text = ""
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 321)
        Me.Controls.Add(Me.TabControl1)
        Me.MinimumSize = New System.Drawing.Size(400, 300)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.TabControl1.ResumeLayout(False)
        Me.general_tab.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.start_code_tab.ResumeLayout(False)
        Me.end_code_tab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents general_tab As System.Windows.Forms.TabPage
    Friend WithEvents start_code_tab As System.Windows.Forms.TabPage
    Friend WithEvents end_code_tab As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_plot_speed As System.Windows.Forms.TextBox
    Friend WithEvents txt_travel_speed As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_penUp As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_startcode As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_endgcode As System.Windows.Forms.RichTextBox
End Class
