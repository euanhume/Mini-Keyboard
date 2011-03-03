<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mini_Keyboard
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
        Me.components = New System.ComponentModel.Container
        Me.Txt_Main = New System.Windows.Forms.TextBox
        Me.Txt_WordBuilder = New System.Windows.Forms.TextBox
        Me.lbl_mode = New System.Windows.Forms.Label
        Me.Btn_Mode = New System.Windows.Forms.Button
        Me.Btn_Next = New System.Windows.Forms.Button
        Me.Btn_Previous = New System.Windows.Forms.Button
        Me.Btn_Send = New System.Windows.Forms.Button
        Me.Btn_7 = New System.Windows.Forms.Button
        Me.Btn_8 = New System.Windows.Forms.Button
        Me.Btn_9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Btn_4 = New System.Windows.Forms.Button
        Me.Btn_5 = New System.Windows.Forms.Button
        Me.Btn_6 = New System.Windows.Forms.Button
        Me.Btn_1 = New System.Windows.Forms.Button
        Me.Btn_0 = New System.Windows.Forms.Button
        Me.Btn_3 = New System.Windows.Forms.Button
        Me.Btn_Enter = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button16 = New System.Windows.Forms.Button
        Me.Btn_11 = New System.Windows.Forms.Button
        Me.Btn_10 = New System.Windows.Forms.Button
        Me.Btn_2 = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfigureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.List_8 = New System.Windows.Forms.ListBox
        Me.List_7 = New System.Windows.Forms.ListBox
        Me.List_9 = New System.Windows.Forms.ListBox
        Me.List_4 = New System.Windows.Forms.ListBox
        Me.List_5 = New System.Windows.Forms.ListBox
        Me.List_6 = New System.Windows.Forms.ListBox
        Me.List_1 = New System.Windows.Forms.ListBox
        Me.List_2 = New System.Windows.Forms.ListBox
        Me.List_10 = New System.Windows.Forms.ListBox
        Me.List_3 = New System.Windows.Forms.ListBox
        Me.List_11 = New System.Windows.Forms.ListBox
        Me.Txt_KeyStrokes = New System.Windows.Forms.TextBox
        Me.Within_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Main
        '
        Me.Txt_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Main.Location = New System.Drawing.Point(12, 30)
        Me.Txt_Main.Multiline = True
        Me.Txt_Main.Name = "Txt_Main"
        Me.Txt_Main.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Main.Size = New System.Drawing.Size(785, 247)
        Me.Txt_Main.TabIndex = 0
        '
        'Txt_WordBuilder
        '
        Me.Txt_WordBuilder.Location = New System.Drawing.Point(6, 7)
        Me.Txt_WordBuilder.Name = "Txt_WordBuilder"
        Me.Txt_WordBuilder.Size = New System.Drawing.Size(223, 20)
        Me.Txt_WordBuilder.TabIndex = 2
        '
        'lbl_mode
        '
        Me.lbl_mode.AutoSize = True
        Me.lbl_mode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_mode.Location = New System.Drawing.Point(235, 10)
        Me.lbl_mode.Name = "lbl_mode"
        Me.lbl_mode.Size = New System.Drawing.Size(60, 15)
        Me.lbl_mode.TabIndex = 3
        Me.lbl_mode.Text = "Multi-Press"
        '
        'Btn_Mode
        '
        Me.Btn_Mode.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Mode.Location = New System.Drawing.Point(12, 3)
        Me.Btn_Mode.Name = "Btn_Mode"
        Me.Btn_Mode.Size = New System.Drawing.Size(70, 60)
        Me.Btn_Mode.TabIndex = 4
        Me.Btn_Mode.Text = "Mode"
        Me.Btn_Mode.UseVisualStyleBackColor = False
        '
        'Btn_Next
        '
        Me.Btn_Next.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Next.Location = New System.Drawing.Point(88, 3)
        Me.Btn_Next.Name = "Btn_Next"
        Me.Btn_Next.Size = New System.Drawing.Size(68, 60)
        Me.Btn_Next.TabIndex = 5
        Me.Btn_Next.Text = "Next"
        Me.Btn_Next.UseVisualStyleBackColor = False
        '
        'Btn_Previous
        '
        Me.Btn_Previous.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Btn_Previous.Location = New System.Drawing.Point(164, 3)
        Me.Btn_Previous.Name = "Btn_Previous"
        Me.Btn_Previous.Size = New System.Drawing.Size(65, 60)
        Me.Btn_Previous.TabIndex = 6
        Me.Btn_Previous.Text = "Previous"
        Me.Btn_Previous.UseVisualStyleBackColor = False
        '
        'Btn_Send
        '
        Me.Btn_Send.BackColor = System.Drawing.Color.Yellow
        Me.Btn_Send.Location = New System.Drawing.Point(235, 3)
        Me.Btn_Send.Name = "Btn_Send"
        Me.Btn_Send.Size = New System.Drawing.Size(69, 60)
        Me.Btn_Send.TabIndex = 7
        Me.Btn_Send.Text = "Send " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Predicted"
        Me.Btn_Send.UseVisualStyleBackColor = False
        '
        'Btn_7
        '
        Me.Btn_7.BackColor = System.Drawing.Color.Red
        Me.Btn_7.Location = New System.Drawing.Point(12, 70)
        Me.Btn_7.Name = "Btn_7"
        Me.Btn_7.Size = New System.Drawing.Size(70, 59)
        Me.Btn_7.TabIndex = 8
        Me.Btn_7.Text = "7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " . , """
        Me.Btn_7.UseVisualStyleBackColor = False
        '
        'Btn_8
        '
        Me.Btn_8.BackColor = System.Drawing.Color.Red
        Me.Btn_8.Location = New System.Drawing.Point(88, 69)
        Me.Btn_8.Name = "Btn_8"
        Me.Btn_8.Size = New System.Drawing.Size(68, 60)
        Me.Btn_8.TabIndex = 9
        Me.Btn_8.Text = "8 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A B C"
        Me.Btn_8.UseVisualStyleBackColor = False
        '
        'Btn_9
        '
        Me.Btn_9.BackColor = System.Drawing.Color.Red
        Me.Btn_9.Location = New System.Drawing.Point(164, 69)
        Me.Btn_9.Name = "Btn_9"
        Me.Btn_9.Size = New System.Drawing.Size(65, 60)
        Me.Btn_9.TabIndex = 10
        Me.Btn_9.Text = "9 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D E F"
        Me.Btn_9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Yellow
        Me.Button8.Location = New System.Drawing.Point(235, 70)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 59)
        Me.Button8.TabIndex = 11
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Btn_4
        '
        Me.Btn_4.BackColor = System.Drawing.Color.Red
        Me.Btn_4.Location = New System.Drawing.Point(12, 135)
        Me.Btn_4.Name = "Btn_4"
        Me.Btn_4.Size = New System.Drawing.Size(71, 65)
        Me.Btn_4.TabIndex = 12
        Me.Btn_4.Text = "4 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G H I"
        Me.Btn_4.UseVisualStyleBackColor = False
        '
        'Btn_5
        '
        Me.Btn_5.BackColor = System.Drawing.Color.Red
        Me.Btn_5.Location = New System.Drawing.Point(88, 135)
        Me.Btn_5.Name = "Btn_5"
        Me.Btn_5.Size = New System.Drawing.Size(68, 65)
        Me.Btn_5.TabIndex = 13
        Me.Btn_5.Text = "5 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "J K L "
        Me.Btn_5.UseVisualStyleBackColor = False
        '
        'Btn_6
        '
        Me.Btn_6.BackColor = System.Drawing.Color.Red
        Me.Btn_6.Location = New System.Drawing.Point(164, 135)
        Me.Btn_6.Name = "Btn_6"
        Me.Btn_6.Size = New System.Drawing.Size(65, 65)
        Me.Btn_6.TabIndex = 14
        Me.Btn_6.Text = "6 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M N O "
        Me.Btn_6.UseVisualStyleBackColor = False
        '
        'Btn_1
        '
        Me.Btn_1.BackColor = System.Drawing.Color.Red
        Me.Btn_1.Location = New System.Drawing.Point(12, 206)
        Me.Btn_1.Name = "Btn_1"
        Me.Btn_1.Size = New System.Drawing.Size(71, 63)
        Me.Btn_1.TabIndex = 15
        Me.Btn_1.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P Q R S"
        Me.Btn_1.UseVisualStyleBackColor = False
        '
        'Btn_0
        '
        Me.Btn_0.BackColor = System.Drawing.Color.Lime
        Me.Btn_0.Location = New System.Drawing.Point(88, 275)
        Me.Btn_0.Name = "Btn_0"
        Me.Btn_0.Size = New System.Drawing.Size(68, 59)
        Me.Btn_0.TabIndex = 16
        Me.Btn_0.Text = "000" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[ _ ]"
        Me.Btn_0.UseVisualStyleBackColor = False
        '
        'Btn_3
        '
        Me.Btn_3.BackColor = System.Drawing.Color.Red
        Me.Btn_3.Location = New System.Drawing.Point(162, 206)
        Me.Btn_3.Name = "Btn_3"
        Me.Btn_3.Size = New System.Drawing.Size(65, 63)
        Me.Btn_3.TabIndex = 17
        Me.Btn_3.Text = "3 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "W X Y Z"
        Me.Btn_3.UseVisualStyleBackColor = False
        '
        'Btn_Enter
        '
        Me.Btn_Enter.BackColor = System.Drawing.Color.Yellow
        Me.Btn_Enter.Location = New System.Drawing.Point(235, 206)
        Me.Btn_Enter.Name = "Btn_Enter"
        Me.Btn_Enter.Size = New System.Drawing.Size(69, 131)
        Me.Btn_Enter.TabIndex = 18
        Me.Btn_Enter.Text = "Enter"
        Me.Btn_Enter.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lbl_mode)
        Me.Panel1.Controls.Add(Me.Txt_WordBuilder)
        Me.Panel1.Location = New System.Drawing.Point(237, 283)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 37)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button16)
        Me.Panel2.Controls.Add(Me.Btn_11)
        Me.Panel2.Controls.Add(Me.Btn_10)
        Me.Panel2.Controls.Add(Me.Btn_2)
        Me.Panel2.Controls.Add(Me.Btn_Enter)
        Me.Panel2.Controls.Add(Me.Btn_3)
        Me.Panel2.Controls.Add(Me.Btn_0)
        Me.Panel2.Controls.Add(Me.Btn_1)
        Me.Panel2.Controls.Add(Me.Btn_6)
        Me.Panel2.Controls.Add(Me.Btn_5)
        Me.Panel2.Controls.Add(Me.Btn_4)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Btn_9)
        Me.Panel2.Controls.Add(Me.Btn_8)
        Me.Panel2.Controls.Add(Me.Btn_7)
        Me.Panel2.Controls.Add(Me.Btn_Send)
        Me.Panel2.Controls.Add(Me.Btn_Previous)
        Me.Panel2.Controls.Add(Me.Btn_Next)
        Me.Panel2.Controls.Add(Me.Btn_Mode)
        Me.Panel2.Location = New System.Drawing.Point(237, 326)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(322, 341)
        Me.Panel2.TabIndex = 20
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Yellow
        Me.Button16.Location = New System.Drawing.Point(235, 135)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(69, 66)
        Me.Button16.TabIndex = 22
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Btn_11
        '
        Me.Btn_11.BackColor = System.Drawing.Color.Red
        Me.Btn_11.Location = New System.Drawing.Point(162, 275)
        Me.Btn_11.Name = "Btn_11"
        Me.Btn_11.Size = New System.Drawing.Size(65, 59)
        Me.Btn_11.TabIndex = 21
        Me.Btn_11.Text = "# " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "000"
        Me.Btn_11.UseVisualStyleBackColor = False
        '
        'Btn_10
        '
        Me.Btn_10.BackColor = System.Drawing.Color.Red
        Me.Btn_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_10.Location = New System.Drawing.Point(12, 275)
        Me.Btn_10.Name = "Btn_10"
        Me.Btn_10.Size = New System.Drawing.Size(71, 59)
        Me.Btn_10.TabIndex = 20
        Me.Btn_10.Text = "* - _"
        Me.Btn_10.UseVisualStyleBackColor = False
        '
        'Btn_2
        '
        Me.Btn_2.BackColor = System.Drawing.Color.Red
        Me.Btn_2.Location = New System.Drawing.Point(88, 206)
        Me.Btn_2.Name = "Btn_2"
        Me.Btn_2.Size = New System.Drawing.Size(68, 63)
        Me.Btn_2.TabIndex = 19
        Me.Btn_2.Text = "2 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T U V"
        Me.Btn_2.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ConfigureToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(809, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(114, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ConfigureToolStripMenuItem
        '
        Me.ConfigureToolStripMenuItem.Name = "ConfigureToolStripMenuItem"
        Me.ConfigureToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.ConfigureToolStripMenuItem.Text = "Configure"
        '
        'List_8
        '
        Me.List_8.FormattingEnabled = True
        Me.List_8.Items.AddRange(New Object() {"a", "b", "c", "8", "A", "B", "C"})
        Me.List_8.Location = New System.Drawing.Point(651, 331)
        Me.List_8.Name = "List_8"
        Me.List_8.Size = New System.Drawing.Size(49, 69)
        Me.List_8.TabIndex = 22
        Me.List_8.Visible = False
        '
        'List_7
        '
        Me.List_7.FormattingEnabled = True
        Me.List_7.Items.AddRange(New Object() {".", ",", """", "7", "'", ":", ";"})
        Me.List_7.Location = New System.Drawing.Point(579, 331)
        Me.List_7.Name = "List_7"
        Me.List_7.Size = New System.Drawing.Size(49, 69)
        Me.List_7.TabIndex = 23
        Me.List_7.Visible = False
        '
        'List_9
        '
        Me.List_9.FormattingEnabled = True
        Me.List_9.Items.AddRange(New Object() {"d", "e", "f", "9", "D", "E", "F"})
        Me.List_9.Location = New System.Drawing.Point(724, 331)
        Me.List_9.Name = "List_9"
        Me.List_9.Size = New System.Drawing.Size(49, 69)
        Me.List_9.TabIndex = 24
        Me.List_9.Visible = False
        '
        'List_4
        '
        Me.List_4.FormattingEnabled = True
        Me.List_4.Items.AddRange(New Object() {"g", "h", "i", "4", "G", "H", "I"})
        Me.List_4.Location = New System.Drawing.Point(579, 419)
        Me.List_4.Name = "List_4"
        Me.List_4.Size = New System.Drawing.Size(49, 69)
        Me.List_4.TabIndex = 25
        Me.List_4.Visible = False
        '
        'List_5
        '
        Me.List_5.FormattingEnabled = True
        Me.List_5.Items.AddRange(New Object() {"j", "k", "l", "5", "J", "K", "L"})
        Me.List_5.Location = New System.Drawing.Point(651, 419)
        Me.List_5.Name = "List_5"
        Me.List_5.Size = New System.Drawing.Size(49, 69)
        Me.List_5.TabIndex = 26
        Me.List_5.Visible = False
        '
        'List_6
        '
        Me.List_6.FormattingEnabled = True
        Me.List_6.Items.AddRange(New Object() {"m", "n", "o", "6", "M", "N", "O"})
        Me.List_6.Location = New System.Drawing.Point(724, 419)
        Me.List_6.Name = "List_6"
        Me.List_6.Size = New System.Drawing.Size(49, 69)
        Me.List_6.TabIndex = 27
        Me.List_6.Visible = False
        '
        'List_1
        '
        Me.List_1.FormattingEnabled = True
        Me.List_1.Items.AddRange(New Object() {"p", "q", "r", "s", "1", "P", "Q", "R", "S"})
        Me.List_1.Location = New System.Drawing.Point(579, 505)
        Me.List_1.Name = "List_1"
        Me.List_1.Size = New System.Drawing.Size(49, 69)
        Me.List_1.TabIndex = 28
        Me.List_1.Visible = False
        '
        'List_2
        '
        Me.List_2.FormattingEnabled = True
        Me.List_2.Items.AddRange(New Object() {"t", "u", "v", "2", "T", "U", "V"})
        Me.List_2.Location = New System.Drawing.Point(651, 505)
        Me.List_2.Name = "List_2"
        Me.List_2.Size = New System.Drawing.Size(49, 69)
        Me.List_2.TabIndex = 29
        Me.List_2.Visible = False
        '
        'List_10
        '
        Me.List_10.FormattingEnabled = True
        Me.List_10.Items.AddRange(New Object() {"*", "-", "_"})
        Me.List_10.Location = New System.Drawing.Point(579, 593)
        Me.List_10.Name = "List_10"
        Me.List_10.Size = New System.Drawing.Size(49, 69)
        Me.List_10.TabIndex = 30
        Me.List_10.Visible = False
        '
        'List_3
        '
        Me.List_3.FormattingEnabled = True
        Me.List_3.Items.AddRange(New Object() {"w", "x", "y", "z", "3", "W", "X", "Y", "Z"})
        Me.List_3.Location = New System.Drawing.Point(724, 505)
        Me.List_3.Name = "List_3"
        Me.List_3.Size = New System.Drawing.Size(49, 69)
        Me.List_3.TabIndex = 31
        Me.List_3.Visible = False
        '
        'List_11
        '
        Me.List_11.FormattingEnabled = True
        Me.List_11.Items.AddRange(New Object() {"#", "-", "_"})
        Me.List_11.Location = New System.Drawing.Point(724, 593)
        Me.List_11.Name = "List_11"
        Me.List_11.Size = New System.Drawing.Size(49, 69)
        Me.List_11.TabIndex = 33
        Me.List_11.Visible = False
        '
        'Txt_KeyStrokes
        '
        Me.Txt_KeyStrokes.Location = New System.Drawing.Point(578, 290)
        Me.Txt_KeyStrokes.Name = "Txt_KeyStrokes"
        Me.Txt_KeyStrokes.Size = New System.Drawing.Size(195, 20)
        Me.Txt_KeyStrokes.TabIndex = 34
        Me.Txt_KeyStrokes.Visible = False
        '
        'Within_Timer
        '
        Me.Within_Timer.Interval = 500
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Mini_Keyboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 679)
        Me.Controls.Add(Me.Txt_KeyStrokes)
        Me.Controls.Add(Me.List_11)
        Me.Controls.Add(Me.List_3)
        Me.Controls.Add(Me.List_10)
        Me.Controls.Add(Me.List_2)
        Me.Controls.Add(Me.List_1)
        Me.Controls.Add(Me.List_6)
        Me.Controls.Add(Me.List_5)
        Me.Controls.Add(Me.List_4)
        Me.Controls.Add(Me.List_9)
        Me.Controls.Add(Me.List_7)
        Me.Controls.Add(Me.List_8)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Txt_Main)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Mini_Keyboard"
        Me.Text = "Mini Keyboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Main As System.Windows.Forms.TextBox
    Friend WithEvents Txt_WordBuilder As System.Windows.Forms.TextBox
    Friend WithEvents lbl_mode As System.Windows.Forms.Label
    Friend WithEvents Btn_Mode As System.Windows.Forms.Button
    Friend WithEvents Btn_Next As System.Windows.Forms.Button
    Friend WithEvents Btn_Previous As System.Windows.Forms.Button
    Friend WithEvents Btn_Send As System.Windows.Forms.Button
    Friend WithEvents Btn_7 As System.Windows.Forms.Button
    Friend WithEvents Btn_8 As System.Windows.Forms.Button
    Friend WithEvents Btn_9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Btn_4 As System.Windows.Forms.Button
    Friend WithEvents Btn_5 As System.Windows.Forms.Button
    Friend WithEvents Btn_6 As System.Windows.Forms.Button
    Friend WithEvents Btn_1 As System.Windows.Forms.Button
    Friend WithEvents Btn_0 As System.Windows.Forms.Button
    Friend WithEvents Btn_3 As System.Windows.Forms.Button
    Friend WithEvents Btn_Enter As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Btn_11 As System.Windows.Forms.Button
    Friend WithEvents Btn_10 As System.Windows.Forms.Button
    Friend WithEvents Btn_2 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents List_8 As System.Windows.Forms.ListBox
    Friend WithEvents List_7 As System.Windows.Forms.ListBox
    Friend WithEvents List_9 As System.Windows.Forms.ListBox
    Friend WithEvents List_4 As System.Windows.Forms.ListBox
    Friend WithEvents List_5 As System.Windows.Forms.ListBox
    Friend WithEvents List_6 As System.Windows.Forms.ListBox
    Friend WithEvents List_1 As System.Windows.Forms.ListBox
    Friend WithEvents List_2 As System.Windows.Forms.ListBox
    Friend WithEvents List_10 As System.Windows.Forms.ListBox
    Friend WithEvents List_3 As System.Windows.Forms.ListBox
    Friend WithEvents List_11 As System.Windows.Forms.ListBox
    Friend WithEvents Txt_KeyStrokes As System.Windows.Forms.TextBox
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Within_Timer As System.Windows.Forms.Timer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
