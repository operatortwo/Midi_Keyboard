Public Class Form1

    Public WithEvents mkbd As New Midi_Keyboard.Main

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        mkbd.show()
    End Sub

    Private Sub btnShowWithTitle_Click(sender As Object, e As EventArgs) Handles btnShowWithTitle.Click
        mkbd.show(tbTitle.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        mkbd.close()
        tbMidiMsg.Clear()
    End Sub

    Private Sub mkbd_kbEvent(status As Integer, channel As Integer, data1 As Integer, data2 As Integer) Handles mkbd.kbEvent

        Dim buffer As Byte()
        ReDim buffer(2)
        buffer(0) = CByte(status Or channel)
        buffer(1) = CByte(data1)
        buffer(2) = CByte(data2)

        Dim str As String
        str = BitConverter.ToString(buffer)
        str = str.Replace("-", " ")

        tbMidiMsg.Text = str
    End Sub

    Private Sub btnSendNoteOn_Click(sender As Object, e As EventArgs) Handles btnSendNoteOn.Click
        '--- compact ---
        'Dim data As Integer = &H7F3C90
        'mkbd.Midi_In(data)
        '--- separated ---
        mkbd.Midi_In(&H90, &H3C, &H7F)
    End Sub

    Private Sub btnSendNoteOff_Click(sender As Object, e As EventArgs) Handles btnSendNoteOff.Click
        '--- compact ---
        'Dim data As Integer = &H3C80
        'mkbd.Midi_In(data)
        '--- separated ---
        mkbd.Midi_In(&H80, &H3C, 0)
    End Sub
End Class
