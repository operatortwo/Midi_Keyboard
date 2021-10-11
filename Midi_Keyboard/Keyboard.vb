Imports System.Windows.Forms
Imports System.Drawing

Friend Class Keyboard

    '--- when a key was pressed or released
    Friend Event keyEvent(status As Integer, channel As Integer, data1 As Integer, data2 As Integer)

    '--- when the keyboard size was changed by the user
    Friend Event size_changed(nr_of_keys As Integer, nr_of_first_key As Integer, key_size_muliplier As Single)

    'Private Const keyboard_offset_y = 30

    Private Const min_num_of_keys = 25
    Private Const max_num_of_keys = 128

    Private num_of_keys As Integer = 128                ' (128) 25 - 127 keyboard-keys    (61, 76, 88, ...)
    Private num_of_first_key As Integer = 0             ' num of first displayed key

    Private num_of_white_keys As Integer                 ' calced, for sizing client

    Private Const keyboard_y_start_space = 5            ' space between toolStrip1 and keyboard

    Private keyboard_offset_y As Integer = 0            '  = keyboard_y_start, calced

    Private Const white_key_width_base = 11             ' width
    Private Const white_key_height_base = 39             ' height

    Private Const black_key_width_base = 7              ' width
    Private Const black_key_height_base = 24             ' height

    Private Const velocity_min = 70                     ' velocity response for mouse_down (offset_y)
    Private Const velocity_max = 127                    ' max. 127
    Private Const velocity_diff = velocity_max - velocity_min

    Private Const min_key_size_multiplier = 1.0
    Private Const max_key_size_multiplier = 10.0

    Private key_size_multiplier As Single = 1.0         ' (1.0)

    Private white_key_width As Integer = 0              ' calculated, base * multiplier     (width)
    Private white_key_height As Integer = 0             ' calculated, base * multiplier     (height)

    Private black_key_width As Integer = 0              ' calculated, base * multiplier     (width)
    Private black_key_height As Integer = 0             ' calculated, base * multiplier     (height)

    '---

    Private current_note As Integer = 128               ' for note-off (0-127)

    Private hold_mode As Boolean = False                ' on = hold current note

    Private ChannelNumberOut As Byte = 0                ' output channel


    Public Sub New(keys As Integer, first_key As Integer, scale As Single)

        ' needed for the designer
        InitializeComponent()

        ' Add initializations after the InitializeComponent() call.

        num_of_keys = keys                       ' copy the desired values to the internal variables
        num_of_first_key = first_key
        key_size_multiplier = scale

        set_client_size()                       ' (and check the input values)

    End Sub


    Public Sub set_client_size()

        '--- check scale
        If key_size_multiplier < min_key_size_multiplier Then
            key_size_multiplier = min_key_size_multiplier

        ElseIf key_size_multiplier > max_key_size_multiplier Then
            key_size_multiplier = max_key_size_multiplier
        End If

        '--- check num_of_keys
        If num_of_keys < min_num_of_keys Then num_of_keys = min_num_of_keys         'check nr_of_keys
        If num_of_keys > max_num_of_keys Then num_of_keys = max_num_of_keys         'check nr_of_keys

        '--- always begin with first key of octave ('C'), a white key (graphic)
        Dim i As Integer
        i = num_of_first_key Mod 12
        If num_of_first_key Mod 12 <> 0 Then
            num_of_first_key = num_of_first_key - i       ' first_key must be 0 or multiple of 12 ('C')
        End If

        If num_of_first_key + num_of_keys > max_num_of_keys Then
            num_of_keys = max_num_of_keys - num_of_first_key                       ' adjust num_of_keys
        End If

        '--- calc num_of_white_keys, for sizing client

        num_of_white_keys = (num_of_keys \ 12) * 7

        For i = 1 To num_of_keys Mod 12              ' remaining keys at the end
            If octave_keys(i - 1).white = True Then
                num_of_white_keys += 1
            End If
        Next

        keyboard_offset_y = ToolStrip1.Height + keyboard_y_start_space

        '---
        ' width means width, height means height

        white_key_width = CInt(white_key_width_base * key_size_multiplier)
        white_key_height = CInt(white_key_height_base * key_size_multiplier)
        black_key_width = CInt(black_key_width_base * key_size_multiplier)
        black_key_height = CInt(black_key_height_base * key_size_multiplier)

        ClientSize = New Size(num_of_white_keys * white_key_width, white_key_height + keyboard_offset_y)

    End Sub

    Private Class C_octave_key
        Public Property offset As Integer
        Public Property name As String          ' key name
        Public Property white As Boolean        ' is it a white key
        Public Property shape As Integer        ' shape-type (for painting)
        Public Property xbase As Integer        ' pos-x base for painting (num of white keys from octave-start)
    End Class

    Private octave_keys As New List(Of C_octave_key) From
        {
        New C_octave_key With {.offset = 0, .name = "C", .white = True, .shape = shp_w_r, .xbase = 0},
        New C_octave_key With {.offset = 1, .name = "C#", .white = False, .shape = shp_blk, .xbase = 1},
        New C_octave_key With {.offset = 2, .name = "D", .white = True, .shape = shp_w_lr, .xbase = 1},
        New C_octave_key With {.offset = 3, .name = "D#", .white = False, .shape = shp_blk, .xbase = 2},
        New C_octave_key With {.offset = 4, .name = "E", .white = True, .shape = shp_w_l, .xbase = 2},
        New C_octave_key With {.offset = 5, .name = "F", .white = True, .shape = shp_w_r, .xbase = 3},
        New C_octave_key With {.offset = 6, .name = "F#", .white = False, .shape = shp_blk, .xbase = 4},
        New C_octave_key With {.offset = 7, .name = "G", .white = True, .shape = shp_w_lr, .xbase = 4},
        New C_octave_key With {.offset = 8, .name = "G#", .white = False, .shape = shp_blk, .xbase = 5},
        New C_octave_key With {.offset = 9, .name = "A", .white = True, .shape = shp_w_lr, .xbase = 5},
        New C_octave_key With {.offset = 10, .name = "A#", .white = False, .shape = shp_blk, .xbase = 6},
        New C_octave_key With {.offset = 11, .name = "B", .white = True, .shape = shp_w_l, .xbase = 6}
        }


    'possible key-shapes
    Private Const shp_blk = 0           ' black key                                 5*
    Private Const shp_w_lr = 1          ' white key, black on left and right        3*
    Private Const shp_w_l = 2           ' white key, black on left                  2*
    Private Const shp_w_r = 3           ' white key, black on right                 2*


    Private Sub mdlKeyboard2_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        Dim key_number As Integer                   ' number of key to draw

        Dim key_offset As Integer                   ' offset from beginning of octave
        Dim key_pos_x As Integer                    ' x-start position for painting
        Dim key_pos_y As Integer                    ' y-start position for painting
        Dim key_shape As Integer                    ' shape-type of key

        Dim x As Integer

        '--- rectangle for all white keys ---

        key_pos_y = keyboard_offset_y           ' top-position of keyboard

        e.Graphics.FillRectangle(Brushes.WhiteSmoke, 0, key_pos_y, num_of_white_keys * white_key_width, white_key_height)

        '--- draw white keys ---

        For i = 0 To num_of_white_keys - 1
            e.Graphics.DrawRectangle(Pens.DarkGray, key_pos_x, key_pos_y, white_key_width, white_key_height)
            key_pos_x += white_key_width
        Next i

        '--- draw black keys ---

        For i = num_of_first_key To num_of_first_key + num_of_keys - 1
            key_number = i

            key_offset = key_number Mod 12

            'key base-positions

            x = ((key_number - num_of_first_key) \ 12) * 7                 'nr of octaves from left border
            key_pos_x = x * white_key_width      'octave pixels
            x = octave_keys(key_offset).xbase                       'get nr of white keys
            key_pos_x = key_pos_x + (x * white_key_width)           'add key-pixels

            key_pos_y = keyboard_offset_y           ' top-position of keyboard

            'key shape
            key_shape = octave_keys(key_offset).shape

            'paint

            Select Case key_shape

                Case shp_blk
                    x = black_key_width >> 1         ' /2                    
                    key_pos_x -= x                  ' key_pos_x - x

                    e.Graphics.FillRectangle(Brushes.Black, key_pos_x, key_pos_y, black_key_width, black_key_height)
                Case shp_w_lr
                                                    'already painted
                Case shp_w_l
                                                    'already painted
                Case shp_w_r
                    'already painted
            End Select

        Next i

    End Sub

    Public Sub paint_all_keys_off()
        ' visuell hängende Noten ausschalten
        For i = 1 To num_of_keys
            paint_key_off(num_of_first_key + i - 1)
        Next
    End Sub

    Private Sub paint_key_on(noteNum As Integer)
        paint_key(noteNum, True)
    End Sub

    Private Sub paint_key_off(noteNum As Integer)
        paint_key(noteNum, False)
    End Sub

    Private Sub paint_key(noteNum As Integer, key_on As Boolean)

        Dim key_offset As Integer                   ' offset from beginning of octave
        Dim key_pos_x As Integer                    ' x-start position for painting
        Dim key_pos_y As Integer                    ' y-start position for painting
        Dim key_shape As Integer                    ' shape-type of key

        Dim x As Integer

        Dim kBrush As Brush

        key_offset = noteNum Mod 12

        x = ((noteNum - num_of_first_key) \ 12) * 7                 'nr of octaves from left border
        key_pos_x = x * white_key_width      'octave pixels
        x = octave_keys(key_offset).xbase                       'get nr of white keys
        key_pos_x = key_pos_x + (x * white_key_width)           'add key-pixels

        key_pos_y = keyboard_offset_y           ' top-position of keyboard

        'brush

        If octave_keys(key_offset).white = True Then
            If key_on = True Then
                kBrush = Brushes.Red
            Else
                kBrush = Brushes.WhiteSmoke
            End If
        Else
            If key_on = True Then
                kBrush = Brushes.Red
            Else
                kBrush = Brushes.Black
            End If
        End If

        'key shape
        key_shape = octave_keys(key_offset).shape

        'paint

        Dim px As Integer, py As Integer, lx As Integer, ly As Integer

        Dim g As Graphics
        g = Me.CreateGraphics

        Select Case key_shape

            Case shp_blk
                px = key_pos_x - (black_key_width >> 1)
                g.FillRectangle(kBrush, px, key_pos_y, black_key_width, black_key_height)

            Case shp_w_lr
                py = key_pos_y + black_key_height
                ly = white_key_height - (white_key_height - black_key_height)

                g.FillRectangle(kBrush, key_pos_x + 1, py, white_key_width - 1, ly)

                px = key_pos_x + (black_key_width >> 1) - 1
                lx = white_key_width - black_key_width + 1

                g.FillRectangle(kBrush, px + 1, key_pos_y, lx, black_key_height)

            Case shp_w_l
                py = key_pos_y + black_key_height
                ly = white_key_height - (white_key_height - black_key_height)

                g.FillRectangle(kBrush, key_pos_x + 1, py, white_key_width - 1, ly)

                px = key_pos_x + (black_key_width >> 1)
                lx = white_key_width - (black_key_width >> 1)

                g.FillRectangle(kBrush, px, key_pos_y, lx, black_key_height)

            Case shp_w_r
                py = key_pos_y + black_key_height
                ly = white_key_height - (white_key_height - black_key_height)

                g.FillRectangle(kBrush, key_pos_x + 1, py, white_key_width - 1, ly)

                lx = white_key_width - (black_key_width >> 1)

                g.FillRectangle(kBrush, key_pos_x + 1, key_pos_y, lx, black_key_height)

        End Select

    End Sub

    Private Sub mdlKeyboard2_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Dim px As Integer = e.X       ' Mouse position x
        Dim py As Integer = e.Y       ' Mouse position y

        If hold_mode = True Then
            note_off(current_note)
            current_note = 128                      ' invalid note-nr
        End If

        Dim note_nr As Integer
        Dim velocity As Integer

        If pos_to_note(px, py, note_nr, velocity) = True Then
            current_note = note_nr
            note_on(note_nr, velocity)
        End If

    End Sub

    Private Sub mdlKeyboard2_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        If hold_mode = True Then Exit Sub       ' no note-off in hold_mode

        note_off(current_note)
        current_note = 128                      ' invalid note-nr

    End Sub

    Private Sub mdlKeyboard2_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        Dim px As Integer = e.X       ' Mouse position x
        Dim py As Integer = e.Y       ' Mouse position y

        Dim noteNr As Integer
        Dim velocity As Integer

        tsLblPos.Text = px & ", " & py
        tsLblOffset.Text = px Mod white_key_width & ", " & py - keyboard_offset_y    ' offset on (white) key

        If pos_to_note(px, py, noteNr, velocity) = True Then
            tsLblNoteNr.Text = CStr(noteNr)
            tsLblNoteName.Text = noteNum_to_NoteName(noteNr)

            tsLblVelocity.Text = CStr(velocity)

            If e.Button = MouseButtons.Left Then
                If noteNr <> current_note Then
                    note_off(current_note)
                    note_on(noteNr, velocity)
                    current_note = noteNr
                End If
            End If

        Else
            tsLblNoteNr.Text = CStr(noteNr)
        End If

    End Sub

    Private Sub note_on(noteNum As Integer, velocity As Integer)

        If noteNum > 127 Then Exit Sub
        If velocity > 127 Then velocity = 127

        Dim status As Integer = &H90          'note on
        Dim channel As Integer = ChannelNumberOut          'channel 1
        Dim data1 As Integer = &H40         'note
        Dim data2 As Integer = &H7F         'velocity

        data1 = noteNum                 ' Notennummr
        data2 = velocity

        RaiseEvent keyEvent(status, channel, data1, data2)

        paint_key_on(noteNum)

    End Sub

    Private Sub note_off(note_num As Integer)

        If note_num > 127 Then Exit Sub

        Dim status As Integer = &H80                    'note off
        Dim channel As Integer = ChannelNumberOut       'channel 1
        Dim data1 As Integer                            'note
        Dim data2 As Integer = &H0                      'velocity

        data1 = note_num

        RaiseEvent keyEvent(status, channel, data1, data2)

        paint_key_off(note_num)

        ' for a better readability, Note Off with &H8x is used.
        ' Note Off with &H9x and velocity value 0 is also valid.
    End Sub
    Private Sub mdlKeyboard2_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave

        tsLblPos.Text = ""
        tsLblNoteName.Text = ""
        tsLblOffset.Text = ""
        tsLblNoteNr.Text = ""
        tsLblVelocity.Text = ""

    End Sub
    ''' <summary>
    ''' Mouse position x/y to ret_NoteNr and ret_Velocity.
    ''' Returns FALSE if invalid position.
    ''' </summary>
    ''' <param name="pos_x"></param>
    ''' <param name="pos_y"></param>
    ''' <param name="ret_NoteNr"></param>
    ''' <returns></returns>
    Private Function pos_to_note(pos_x As Integer, pos_y As Integer, ByRef ret_NoteNr As Integer, ByRef ret_Velocity As Integer) As Boolean

        Dim kOffs As Integer
        Dim oct As Integer
        Dim note_nr As Integer

        ' nr_of_first_key

        If pos_x < 0 Or pos_y < keyboard_offset_y Or pos_y > keyboard_offset_y + white_key_height _
                    Or pos_x >= num_of_white_keys * white_key_width Then
            ret_NoteNr = 128        'invalid note-nr
            Return False
        End If

        oct = pos_x \ (7 * white_key_width)                 ' "\" Rückgabe einer ganzen Zahl, ohne Rest
        kOffs = get_key_offset(pos_x, pos_y)
        note_nr = oct * 12 + kOffs + num_of_first_key

        Dim yOffs As Integer
        Dim key_height As Integer
        Dim velocity As Integer

        yOffs = pos_y - keyboard_offset_y

        If octave_keys(kOffs).white = True Then
            key_height = white_key_height
        Else
            key_height = black_key_height
        End If

        velocity = CInt((velocity_diff / key_height) * yOffs) + velocity_min

        ret_NoteNr = note_nr
        ret_Velocity = velocity

        Return True
    End Function

    Public Function get_key_offset(px As Integer, py As Integer) As Integer
        'returns the pressed keyboard-key as offset in octave-list
        'px, py = mouse position

        Dim wkey As Integer         ' key offset (white), (nr of white key)
        Dim pos_x_on_key As Integer ' position x on the current key
        Dim offs As Integer

        Dim offsets() As Integer = {0, 2, 4, 5, 7, 9, 11}   'offsets of white keys in octave-list
        Dim check_left() As Boolean = {False, True, True, False, True, True, True}
        Dim check_right() As Boolean = {True, True, False, True, True, True, False}


        '--- get base key
        wkey = (px Mod (7 * white_key_width)) \ white_key_width

        pos_x_on_key = px Mod white_key_width

        '--- check left
        If check_left(wkey) = True Then
            If (py - keyboard_offset_y) < black_key_height Then
                If pos_x_on_key < black_key_width / 2 Then
                    offs = offsets(wkey) - 1
                    Return offs
                End If
            End If
        End If
        '--- check right
        If check_right(wkey) = True Then
            If (py - keyboard_offset_y) < black_key_height Then
                If pos_x_on_key > white_key_width - black_key_width / 2 Then
                    offs = offsets(wkey) + 1
                    Return offs
                End If
            End If
        End If

        '--- it is a white key
        offs = offsets(wkey)
        Return offs

    End Function
    ''' <summary>
    ''' Note-number to Note Name (f.e. 60 to 'C 4')
    ''' </summary>
    ''' <param name="noteNr"></param>
    ''' <returns></returns>
    Private Function noteNum_to_NoteName(noteNr As Integer) As String

        If noteNr > 127 Then
            Return ""                   ' return empty String if noteNr is invalid
        End If

        Return octave_keys(noteNr Mod 12).name & " " & (noteNr \ 12) - 1

        ' A4 = 440Hz = NoteNr: 69 (Def: Mitteleres C = C4 = NoteNr: 60)
    End Function

    Private Sub tsDdBtnSettings_Click(sender As Object, e As EventArgs) Handles tsDdBtnSettings.Click

        tsCbFirstKey.SelectedIndex = 0
        tsCbNrOfKeys.SelectedIndex = 0
        tsCbScale.SelectedIndex = 0

        '--- try to select current setting

        tsCbFirstKey.SelectedItem = CStr(num_of_first_key)
        tsCbNrOfKeys.SelectedItem = CStr(num_of_keys)
        tsCbScale.SelectedItem = CStr(key_size_multiplier)

    End Sub

    Private Sub tsMiEnterSettings_Click(sender As Object, e As EventArgs) Handles tsMiEnterSettings.Click
        note_off(current_note)

        num_of_first_key = CInt(tsCbFirstKey.SelectedItem)
        num_of_keys = CInt(tsCbNrOfKeys.SelectedItem)
        key_size_multiplier = CSng(tsCbScale.SelectedItem)

        set_client_size()
        Me.Invalidate()

        RaiseEvent size_changed(num_of_keys, num_of_first_key, key_size_multiplier)   ' inform about the new size

    End Sub

    Public Sub midi_to_keyboard(dwParam1 As Integer)
        Dim status As Byte
        Dim data1 As Byte
        Dim data2 As Byte

        status = CByte(dwParam1 And &HFF)                      'status and channel
        data1 = CByte(dwParam1 >> 8 And &HFF)                  'data1 (note-nr)
        data2 = CByte(dwParam1 >> 16 And &HFF)                 'data2 (velocity)

        status = CByte(status And &HF0)                        ' set channel -> 0

        If status = &H80 Or (status = &H90 And data2 = 0) Then
            paint_key_off(data1)
        ElseIf status = &H90 Then
            paint_key_on(data1)
        End If

    End Sub

    Public Sub midi_to_keyboard(status As Byte, data1 As Byte, data2 As Byte)
        Dim stat As Byte

        stat = CByte(status And &HF0)                        ' set channel -> 0

        If stat = &H80 Or (stat = &H90 And data2 = 0) Then
            paint_key_off(data1)
        ElseIf stat = &H90 Then
            paint_key_on(data1)
        End If

    End Sub

    Private Sub btnHold_CheckedChanged(sender As Object, e As EventArgs) Handles btnHold.CheckedChanged

        If btnHold.Checked = True Then
            hold_mode = True
        Else
            hold_mode = False

            If current_note < 128 Then
                note_off(current_note)
                current_note = 128                      ' invalid note-nr
            End If

        End If

    End Sub

    Private Sub Keyboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If hold_mode = True Then
            note_off(current_note)                  ' turn off note
            current_note = 128                      ' invalid note-nr
        End If
    End Sub

    Private Sub tsBtnChannelMinus_Click(sender As Object, e As EventArgs) Handles tsBtnChannelMinus.Click
        If ChannelNumberOut > 0 Then
            ChannelNumberOut = CByte(ChannelNumberOut - 1)
            ShowChannelNumberOut()
        End If
    End Sub

    Private Sub tsBtnChannelPlus_Click(sender As Object, e As EventArgs) Handles tsBtnChannelPlus.Click
        If ChannelNumberOut < 15 Then
            ChannelNumberOut = CByte(ChannelNumberOut + 1)
            ShowChannelNumberOut()
        End If
    End Sub

    Private Sub ShowChannelNumberOut()
        tsLblChannelNumber.Text = ChannelNumberOut.ToString
    End Sub

End Class