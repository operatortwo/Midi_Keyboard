Imports System.Windows.Forms
Public Class Main

    Public Event kbEvent(status As Integer, channel As Integer, data1 As Integer, data2 As Integer)

    Private WithEvents kbd As Keyboard

    Private keys As Integer = 72                ' (72) default / desired /current param (cache memory)
    Private first_key As Integer = 24           ' (24)
    Private scale As Single = 1.5               ' (1.5)

    ''' <summary>
    ''' Create keyboard, using default size. Method Show() to display the Keyboard on the screen.
    ''' </summary>
    Public Sub New()
        ' no parameters needed, using default values
    End Sub

    ''' <summary>
    ''' Create keyboard and set the desired size. Method Show() to display the Keyboard on the screen.
    ''' </summary>
    ''' <param name="num_of_keys"></param>
    ''' <param name="num_of_first_key"></param>
    ''' <param name="key_size_multiplier"></param>
    Public Sub New(num_of_keys As Integer, num_of_first_key As Integer, key_size_multiplier As Single)

        keys = num_of_keys                       ' copy input to cache
        first_key = num_of_first_key
        scale = key_size_multiplier

    End Sub

    ''' <summary>
    ''' Shows the keyboard on the screen.
    ''' </summary>
    Public Sub show()

        If kbd Is Nothing Then                              ' showing the first time
            kbd = New Keyboard(keys, first_key, scale)
            kbd.Show()
        ElseIf kbd.IsDisposed = True Then                   ' when previously closed
            kbd = New Keyboard(keys, first_key, scale)
            kbd.Show()
        Else
            kbd.WindowState = FormWindowState.Normal        ' when minimized
            kbd.Activate()
        End If

    End Sub

    ''' <summary>
    ''' Shows the keyboard on the screen and sets the window title.
    ''' </summary>
    ''' <param name="Title"></param>
    Public Sub show(Title As String)
        show()
        kbd.Text = Title
    End Sub

    ''' <summary>
    ''' Returns the current settings for the keyboard size. (for saving to .ini, ...)
    ''' </summary>
    ''' <param name="num_of_keys"></param>
    ''' <param name="num_of_first_key"></param>
    ''' <param name="key_size_multiplier"></param>
    Public Sub get_keyboard_parameters(ByRef num_of_keys As Integer, ByRef num_of_first_key As Integer, ByRef key_size_multiplier As Single)
        num_of_keys = keys
        num_of_first_key = first_key
        key_size_multiplier = scale
    End Sub
    ''' <summary>
    ''' Closes the Keyboard-Form
    ''' </summary>
    Public Sub close()
        If kbd IsNot Nothing Then
            kbd.Close()                                 ' manually close (user wants to close the window)
        End If
    End Sub

    ''' <summary>
    ''' Visualize incoming Midi-Data on the Keyboard. 1 DWORD short Midi-Message.
    ''' </summary>
    ''' <param name="dwParam1">vv nn ss (hex) where vv is velocity, nn is note number, ss is status</param>
    Public Sub Midi_In(dwParam1 As Integer)

        If kbd IsNot Nothing Then
            If kbd.IsDisposed = False Then
                kbd.midi_to_keyboard(dwParam1)         ' send to keyboard
            End If
        End If

    End Sub
    ''' <summary>
    ''' Visualize incoming Midi-Data on the Keyboard. short Midi-Message with separated bytes.
    ''' </summary>
    ''' <param name="status">status, channel will be ignored</param>
    ''' <param name="data1">Note number</param>
    ''' <param name="data2">Velocity</param>
    Public Sub Midi_In(status As Byte, data1 As Byte, data2 As Byte)
        If kbd IsNot Nothing Then
            If kbd.IsDisposed = False Then
                kbd.midi_to_keyboard(status, data1, data2)         ' send to keyboard
            End If
        End If
    End Sub

    ''' <summary>
    ''' Visualizer: Set all notes to OFF-state.
    ''' </summary>
    Public Sub Set_All_Notes_OFF()

        If kbd IsNot Nothing Then
            If kbd.IsDisposed = False Then
                kbd.paint_all_keys_off()
            End If
        End If

    End Sub

    Private Sub kbd_keyEvent(status As Integer, channel As Integer, data1 As Integer, data2 As Integer) Handles kbd.keyEvent
        RaiseEvent kbEvent(status, channel, data1, data2)       ' send Data to the user
    End Sub

    Private Sub kbd_size_changed(num_of_keys As Integer, num_of_first_key As Integer, key_size_muliplier As Single) Handles kbd.size_changed

        keys = num_of_keys                           ' copy the new parameters to the private fields
        first_key = num_of_first_key
        scale = key_size_muliplier

    End Sub
End Class
