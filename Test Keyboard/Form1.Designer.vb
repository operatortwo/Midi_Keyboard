<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnShow = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSendNoteOn = New System.Windows.Forms.Button()
        Me.btnSendNoteOff = New System.Windows.Forms.Button()
        Me.btnShowWithTitle = New System.Windows.Forms.Button()
        Me.tbTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMidiMsg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(31, 85)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(91, 23)
        Me.btnShow.TabIndex = 0
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(31, 125)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 23)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSendNoteOn
        '
        Me.btnSendNoteOn.Location = New System.Drawing.Point(267, 107)
        Me.btnSendNoteOn.Name = "btnSendNoteOn"
        Me.btnSendNoteOn.Size = New System.Drawing.Size(104, 23)
        Me.btnSendNoteOn.TabIndex = 2
        Me.btnSendNoteOn.Text = "send NoteOn"
        Me.btnSendNoteOn.UseVisualStyleBackColor = True
        '
        'btnSendNoteOff
        '
        Me.btnSendNoteOff.Location = New System.Drawing.Point(267, 150)
        Me.btnSendNoteOff.Name = "btnSendNoteOff"
        Me.btnSendNoteOff.Size = New System.Drawing.Size(104, 23)
        Me.btnSendNoteOff.TabIndex = 3
        Me.btnSendNoteOff.Text = "send NoteOff"
        Me.btnSendNoteOff.UseVisualStyleBackColor = True
        '
        'btnShowWithTitle
        '
        Me.btnShowWithTitle.Location = New System.Drawing.Point(31, 39)
        Me.btnShowWithTitle.Name = "btnShowWithTitle"
        Me.btnShowWithTitle.Size = New System.Drawing.Size(91, 23)
        Me.btnShowWithTitle.TabIndex = 4
        Me.btnShowWithTitle.Text = "Show with Title"
        Me.btnShowWithTitle.UseVisualStyleBackColor = True
        '
        'tbTitle
        '
        Me.tbTitle.Location = New System.Drawing.Point(155, 41)
        Me.tbTitle.MaxLength = 32
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(152, 20)
        Me.tbTitle.TabIndex = 5
        Me.tbTitle.Text = "Test"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(155, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "custom title for keyboard"
        '
        'tbMidiMsg
        '
        Me.tbMidiMsg.BackColor = System.Drawing.Color.Azure
        Me.tbMidiMsg.Location = New System.Drawing.Point(31, 186)
        Me.tbMidiMsg.Name = "tbMidiMsg"
        Me.tbMidiMsg.ReadOnly = True
        Me.tbMidiMsg.Size = New System.Drawing.Size(91, 20)
        Me.tbMidiMsg.TabIndex = 7
        Me.tbMidiMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(267, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "from Application to keyboard"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "received from keyboard [ hex ]"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 231)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbMidiMsg)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.btnShowWithTitle)
        Me.Controls.Add(Me.btnSendNoteOff)
        Me.Controls.Add(Me.btnSendNoteOn)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnShow)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Test Keyboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShow As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSendNoteOn As Button
    Friend WithEvents btnSendNoteOff As Button
    Friend WithEvents btnShowWithTitle As Button
    Friend WithEvents tbTitle As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMidiMsg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
