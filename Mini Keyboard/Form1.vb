Imports System.IO
Public Class Mini_Keyboard
    Dim Bool_First_Visit As Boolean = True
    Dim Number As Integer = -1
    Dim Int_Interval_Required As Integer = 500
    Private currentFile As String = ""
    Dim Str_KeyStrokes As String
    Dim Bool_IsButtonPressed(18) As Boolean
    Dim Lst_Global_Listbox As New ListBox
    Dim Int_My_List_Index As Integer = 0

    Private Sub Mini_Keyboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'When the page loads the within timer interval equals the interval set.
        Within_Timer.Interval = Int_Interval_Required
    End Sub

    Private Sub Btn_Mode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Mode.Click
        'If the program is on prediction mode switch it to multi-press and vise versa.  
        If lbl_mode.Text = "Prediction" Then
            lbl_mode.Text = "Multi-Press"
        ElseIf lbl_mode.Text = "Multi-Press" Then
            lbl_mode.Text = "Prediction"
        End If
    End Sub

    Private Sub Btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_1.Click
        'If first click then set boolean for the button number to true, clear the gloabl list box and apprend variable to 1 (Str_KeySrokes).
        If Bool_First_Visit = True Then
            Bool_IsButtonPressed(1) = True
            Lst_Global_Listbox.Items.Clear()
            Str_KeyStrokes = "1"
            'Append Keystrokes to display the variable Str_KeyStrokes
            Txt_KeyStrokes.AppendText(Str_KeyStrokes)
            For Index As Integer = 0 To List_1.Items.Count - 1
                Lst_Global_Listbox.Items.Add(List_1.Items(Index))
            Next
            'If not first click then enable timer and proceed. 
            Bool_First_Visit = False
            Within_Timer.Enabled = True
            Number = Number + 1
            Txt_WordBuilder.AppendText(List_1.Items(Number))
        Else
            'If not first click and is the same click again then. 
            Within_Timer.Enabled = False
            Number = Number + 1
            Txt_WordBuilder.Text = Txt_WordBuilder.Text.Remove(Txt_WordBuilder.TextLength - 1, 1)
            If Number = List_1.Items.Count Then
                Number = 0
            End If
            Txt_WordBuilder.AppendText(List_1.Items(Number))
            Within_Timer.Enabled = True
        End If
    End Sub

    Private Sub Btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_2.Click
        If Bool_First_Visit = True Then
            Bool_IsButtonPressed(2) = True
            Lst_Global_Listbox.Items.Clear()
            Str_KeyStrokes = "2"
            Txt_KeyStrokes.AppendText(Str_KeyStrokes)
            For Index As Integer = 0 To List_2.Items.Count - 1
                Lst_Global_Listbox.Items.Add(List_2.Items(Index))
            Next 
            Bool_First_Visit = False
            Within_Timer.Enabled = True
            Number = Number + 1
            Txt_WordBuilder.AppendText(List_2.Items(Number))
        Else
            Within_Timer.Enabled = False
            Number = Number + 1
            Txt_WordBuilder.Text = Txt_WordBuilder.Text.Remove(Txt_WordBuilder.TextLength - 1, 1)
            If Number = List_2.Items.Count Then
                Number = 0
            End If
            Txt_WordBuilder.AppendText(List_2.Items(Number))
            Within_Timer.Enabled = True
        End If
    End Sub
    Private Sub Btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_3.Click
        If Bool_First_Visit = True Then
            Bool_IsButtonPressed(3) = True
            Lst_Global_Listbox.Items.Clear()
            Str_KeyStrokes = "3"
            Txt_KeyStrokes.AppendText(Str_KeyStrokes)
            For Index As Integer = 0 To List_3.Items.Count - 1
                Lst_Global_Listbox.Items.Add(List_3.Items(Index))
            Next
            Bool_First_Visit = False
            Within_Timer.Enabled = True
            Number = Number + 1
            Txt_WordBuilder.AppendText(List_3.Items(Number))
        Else
            Within_Timer.Enabled = False
            Number = Number + 1
            Txt_WordBuilder.Text = Txt_WordBuilder.Text.Remove(Txt_WordBuilder.TextLength - 1, 1)
            If Number = List_3.Items.Count Then
                Number = 0
            End If
            Txt_WordBuilder.AppendText(List_3.Items(Number))
            Within_Timer.Enabled = True
        End If
    End Sub
    Private Sub Btn_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_4.Click
        If Bool_First_Visit = True Then
            Bool_IsButtonPressed(4) = True
            Lst_Global_Listbox.Items.Clear()
            Str_KeyStrokes = "4"
            Txt_KeyStrokes.AppendText(Str_KeyStrokes)
            For Index As Integer = 0 To List_4.Items.Count - 1
                Lst_Global_Listbox.Items.Add(List_4.Items(Index))
            Next
            Bool_First_Visit = False
            Within_Timer.Enabled = True
            Number = Number + 1
            Txt_WordBuilder.AppendText(List_4.Items(Number))
        Else
            Within_Timer.Enabled = False
            Number = Number + 1
            Txt_WordBuilder.Text = Txt_WordBuilder.Text.Remove(Txt_WordBuilder.TextLength - 1, 1)
            If Number = List_4.Items.Count Then
                Number = 0
            End If
            Txt_WordBuilder.AppendText(List_4.Items(Number))
            Within_Timer.Enabled = True
        End If
    End Sub
    Private Sub Btn_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_5.Click
        If Bool_First_Visit = True Then
            Bool_IsButtonPressed(5) = True
            Lst_Global_Listbox.Items.Clear()
            Str_KeyStrokes = "5"
            Txt_KeyStrokes.AppendText(Str_KeyStrokes)
            For Index As Integer = 0 To List_5.Items.Count - 1
                Lst_Global_Listbox.Items.Add(List_5.Items(Index))
            Next
            Bool_First_Visit = False
            Within_Timer.Enabled = True
            Number = Number + 1
            Txt_WordBuilder.AppendText(List_5.Items(Number))
        Else
            Within_Timer.Enabled = False
            Number = Number + 1
            Txt_WordBuilder.Text = Txt_WordBuilder.Text.Remove(Txt_WordBuilder.TextLength - 1, 1)
            If Number = List_5.Items.Count Then
                Number = 0
            End If
            Txt_WordBuilder.AppendText(List_5.Items(Number))
            Within_Timer.Enabled = True
        End If
    End Sub
    Private Sub Btn_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_6.Click
        If Bool_First_Visit = True Then
            Bool_IsButtonPressed(6) = True
            Lst_Global_Listbox.Items.Clear()
            Str_KeyStrokes = "6"
            Txt_KeyStrokes.AppendText(Str_KeyStrokes)
            For Index As Integer = 0 To List_6.Items.Count - 1
                Lst_Global_Listbox.Items.Add(List_6.Items(Index))
            Next
            Bool_First_Visit = False
            Within_Timer.Enabled = True
            Number = Number + 1
            Txt_WordBuilder.AppendText(List_6.Items(Number))
        Else
            Within_Timer.Enabled = False
            Number = Number + 1
            Txt_WordBuilder.Text = Txt_WordBuilder.Text.Remove(Txt_WordBuilder.TextLength - 1, 1)
            If Number = List_6.Items.Count Then
                Number = 0
            End If
            Txt_WordBuilder.AppendText(List_6.Items(Number))
            Within_Timer.Enabled = True
        End If
    End Sub
    Private Sub Btn_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_7.Click
        If Bool_First_Visit = True Then
            Bool_IsButtonPressed(7) = True
            Lst_Global_Listbox.Items.Clear()
            Str_KeyStrokes = "7"
            Txt_KeyStrokes.AppendText(Str_KeyStrokes)
            For Index As Integer = 0 To List_7.Items.Count - 1
                Lst_Global_Listbox.Items.Add(List_7.Items(Index))
            Next
            Bool_First_Visit = False
            Within_Timer.Enabled = True
            Number = Number + 1
            Txt_WordBuilder.AppendText(List_7.Items(Number))
        Else
            Within_Timer.Enabled = False
            Number = Number + 1
            Txt_WordBuilder.Text = Txt_WordBuilder.Text.Remove(Txt_WordBuilder.TextLength - 1, 1)
            If Number = List_7.Items.Count Then
                Number = 0
            End If
            Txt_WordBuilder.AppendText(List_7.Items(Number))
            Within_Timer.Enabled = True
        End If
    End Sub
    Private Sub Btn_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_8.Click
        If Bool_First_Visit = True Then
            Bool_IsButtonPressed(8) = True
            Lst_Global_Listbox.Items.Clear()
            Str_KeyStrokes = "8"
            Txt_KeyStrokes.AppendText(Str_KeyStrokes)
            For Index As Integer = 0 To List_8.Items.Count - 1
                Lst_Global_Listbox.Items.Add(List_8.Items(Index))
            Next
            Bool_First_Visit = False
            Within_Timer.Enabled = True
            Number = Number + 1
            Txt_WordBuilder.AppendText(List_8.Items(Number))
        Else
            Within_Timer.Enabled = False
            Number = Number + 1
            Txt_WordBuilder.Text = Txt_WordBuilder.Text.Remove(Txt_WordBuilder.TextLength - 1, 1)
            If Number = List_8.Items.Count Then
                Number = 0
            End If
            Txt_WordBuilder.AppendText(List_8.Items(Number))
            Within_Timer.Enabled = True
        End If
    End Sub
    Private Sub Btn_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_9.Click
        If Bool_First_Visit = True Then
            Bool_IsButtonPressed(9) = True
            Lst_Global_Listbox.Items.Clear()
            Str_KeyStrokes = "9"
            Txt_KeyStrokes.AppendText(Str_KeyStrokes)
            For Index As Integer = 0 To List_9.Items.Count - 1
                Lst_Global_Listbox.Items.Add(List_9.Items(Index))
            Next
            Bool_First_Visit = False
            Within_Timer.Enabled = True
            Number = Number + 1
            Txt_WordBuilder.AppendText(List_9.Items(Number))
        Else
            Within_Timer.Enabled = False
            Number = Number + 1
            Txt_WordBuilder.Text = Txt_WordBuilder.Text.Remove(Txt_WordBuilder.TextLength - 1, 1)
            If Number = List_9.Items.Count Then
                Number = 0
            End If
            Txt_WordBuilder.AppendText(List_9.Items(Number))
            Within_Timer.Enabled = True
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        'Code for having the 'Open' dialog box open, i have set to c:\ drive
        Dim inputStream As StreamReader
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.InitialDirectory = "c:\"
        If OpenFileDialog1.ShowDialog() = _
        DialogResult.OK Then
            currentFile = OpenFileDialog1.FileName
            inputStream = File.OpenText(currentFile)
            Txt_Main.Text = inputStream.ReadToEnd()
            inputStream.Close()
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        'Code for having the 'SaveAs' dialog box open, i have also set to c:\ drive
        Dim outputStream As StreamWriter
        Dim SaveFileDialog1 As New SaveFileDialog()
        SaveFileDialog1.InitialDirectory = "c:\"
        If SaveFileDialog1.ShowDialog() = _
            DialogResult.OK Then
            currentFile = SaveFileDialog1.FileName
            outputStream = File.CreateText(currentFile)
            outputStream.Write(Txt_Main.Text)
            outputStream.Close()
        End If
    End Sub
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        'Code for the 'Save' option, i have set it to save the text in the main window
        If currentFile <> "" Then
            Dim outputStream As StreamWriter = _
            File.CreateText(currentFile)
            outputStream.Write(Txt_Main.Text)
            outputStream.Close()
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Ends program
        End
    End Sub

    Private Sub Btn_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_0.Click
        'Puts the text in the worldbuilder into the main text box which a space, also clears variable Str_KeyStrokes
        Txt_Main.AppendText(Txt_WordBuilder.Text & " ")
        Str_KeyStrokes = ""
        Txt_KeyStrokes.Clear()
        Txt_WordBuilder.Clear()
    End Sub

    Private Sub Btn_Enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Enter.Click
        'Starts new line in the main textbox
        Txt_Main.AppendText(vbCrLf)
    End Sub

    Private Sub Within_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Within_Timer.Tick
        'Tick options for timer, so that the wordbuilder textbox can function correctly
        Txt_WordBuilder.Text = Txt_WordBuilder.Text.Remove(Txt_WordBuilder.TextLength - 1, 1)
        Within_Timer.Enabled = False
        Bool_First_Visit = True
        Txt_WordBuilder.AppendText(Lst_Global_Listbox.Items(Number))
        Number = -1
        For Int_Which_Button As Integer = 0 To 18
            Bool_IsButtonPressed(Int_Which_Button) = False
        Next
    End Sub

    Private Sub ConfigureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigureToolStripMenuItem.Click
        'Allows to user to set the interval
        Within_Timer.Interval = CInt(InputBox("Please enter the 'Delay Value' which is for every 1000 is equal to 1 second"))
    End Sub
End Class
