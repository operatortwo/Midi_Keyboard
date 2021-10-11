<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Keyboard
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Keyboard))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsLblPos = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.tsLblOffset = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.tsLblNoteName = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.tsLblNoteNr = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.tsLblVelocity = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsDdBtnSettings = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCbFirstKey = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCbNrOfKeys = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCbScale = New System.Windows.Forms.ToolStripComboBox()
        Me.tsMiEnterSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnHold = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tsLblChannelNumber = New System.Windows.Forms.ToolStripLabel()
        Me.tsBtnChannelMinus = New System.Windows.Forms.ToolStripButton()
        Me.tsBtnChannelPlus = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.tsLblPos, Me.ToolStripLabel4, Me.tsLblOffset, Me.ToolStripLabel3, Me.tsLblNoteName, Me.ToolStripLabel5, Me.tsLblNoteNr, Me.ToolStripLabel6, Me.tsLblVelocity, Me.ToolStripSeparator1, Me.tsDdBtnSettings, Me.ToolStripSeparator2, Me.btnHold, Me.ToolStripSeparator3, Me.ToolStripLabel2, Me.tsLblChannelNumber, Me.tsBtnChannelMinus, Me.tsBtnChannelPlus})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(760, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(29, 22)
        Me.ToolStripLabel1.Text = "Pos:"
        '
        'tsLblPos
        '
        Me.tsLblPos.AutoSize = False
        Me.tsLblPos.Name = "tsLblPos"
        Me.tsLblPos.Size = New System.Drawing.Size(55, 22)
        Me.tsLblPos.Text = "123, 123"
        Me.tsLblPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(42, 22)
        Me.ToolStripLabel4.Text = "Offset:"
        Me.ToolStripLabel4.Visible = False
        '
        'tsLblOffset
        '
        Me.tsLblOffset.AutoSize = False
        Me.tsLblOffset.Name = "tsLblOffset"
        Me.tsLblOffset.Size = New System.Drawing.Size(55, 22)
        Me.tsLblOffset.Text = "123, 123"
        Me.tsLblOffset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tsLblOffset.Visible = False
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(36, 22)
        Me.ToolStripLabel3.Text = "Note:"
        '
        'tsLblNoteName
        '
        Me.tsLblNoteName.AutoSize = False
        Me.tsLblNoteName.Name = "tsLblNoteName"
        Me.tsLblNoteName.Size = New System.Drawing.Size(35, 22)
        Me.tsLblNoteName.Text = "C# 0"
        Me.tsLblNoteName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel5.Text = "NoteNum:"
        '
        'tsLblNoteNr
        '
        Me.tsLblNoteNr.AutoSize = False
        Me.tsLblNoteNr.Name = "tsLblNoteNr"
        Me.tsLblNoteNr.Size = New System.Drawing.Size(35, 22)
        Me.tsLblNoteNr.Text = "123"
        Me.tsLblNoteNr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel6.Text = "Veloc:"
        '
        'tsLblVelocity
        '
        Me.tsLblVelocity.AutoSize = False
        Me.tsLblVelocity.Name = "tsLblVelocity"
        Me.tsLblVelocity.Size = New System.Drawing.Size(35, 22)
        Me.tsLblVelocity.Text = "123"
        Me.tsLblVelocity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tsDdBtnSettings
        '
        Me.tsDdBtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsDdBtnSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.tsMiEnterSettings})
        Me.tsDdBtnSettings.Image = CType(resources.GetObject("tsDdBtnSettings.Image"), System.Drawing.Image)
        Me.tsDdBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDdBtnSettings.Name = "tsDdBtnSettings"
        Me.tsDdBtnSettings.Size = New System.Drawing.Size(62, 22)
        Me.tsDdBtnSettings.Text = "Settings"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCbFirstKey})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem1.Text = "First Key"
        '
        'tsCbFirstKey
        '
        Me.tsCbFirstKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsCbFirstKey.Items.AddRange(New Object() {"0", "12", "24", "36", "48", "60", "72"})
        Me.tsCbFirstKey.Name = "tsCbFirstKey"
        Me.tsCbFirstKey.Size = New System.Drawing.Size(75, 23)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCbNrOfKeys})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "Num of Keys"
        '
        'tsCbNrOfKeys
        '
        Me.tsCbNrOfKeys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsCbNrOfKeys.Items.AddRange(New Object() {"25", "29", "36", "49", "56", "66", "72", "88", "100", "128"})
        Me.tsCbNrOfKeys.Name = "tsCbNrOfKeys"
        Me.tsCbNrOfKeys.Size = New System.Drawing.Size(75, 23)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCbScale})
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem3.Text = "Scale"
        '
        'tsCbScale
        '
        Me.tsCbScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tsCbScale.Items.AddRange(New Object() {"1", "1.2", "1.5", "1.75", "2", "2.5", "3", "4", "5", "7", "10"})
        Me.tsCbScale.Name = "tsCbScale"
        Me.tsCbScale.Size = New System.Drawing.Size(75, 23)
        '
        'tsMiEnterSettings
        '
        Me.tsMiEnterSettings.Name = "tsMiEnterSettings"
        Me.tsMiEnterSettings.Size = New System.Drawing.Size(180, 22)
        Me.tsMiEnterSettings.Text = "Enter Settings"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnHold
        '
        Me.btnHold.BackColor = System.Drawing.SystemColors.Control
        Me.btnHold.CheckOnClick = True
        Me.btnHold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnHold.Image = CType(resources.GetObject("btnHold.Image"), System.Drawing.Image)
        Me.btnHold.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(37, 22)
        Me.btnHold.Text = "Hold"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel2.Text = "Channel:"
        '
        'tsLblChannelNumber
        '
        Me.tsLblChannelNumber.Name = "tsLblChannelNumber"
        Me.tsLblChannelNumber.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.tsLblChannelNumber.Size = New System.Drawing.Size(15, 22)
        Me.tsLblChannelNumber.Text = "0"
        '
        'tsBtnChannelMinus
        '
        Me.tsBtnChannelMinus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tsBtnChannelMinus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsBtnChannelMinus.Image = CType(resources.GetObject("tsBtnChannelMinus.Image"), System.Drawing.Image)
        Me.tsBtnChannelMinus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnChannelMinus.Margin = New System.Windows.Forms.Padding(2, 1, 0, 2)
        Me.tsBtnChannelMinus.Name = "tsBtnChannelMinus"
        Me.tsBtnChannelMinus.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnChannelMinus.Text = "-"
        '
        'tsBtnChannelPlus
        '
        Me.tsBtnChannelPlus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.tsBtnChannelPlus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsBtnChannelPlus.Image = CType(resources.GetObject("tsBtnChannelPlus.Image"), System.Drawing.Image)
        Me.tsBtnChannelPlus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsBtnChannelPlus.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.tsBtnChannelPlus.Name = "tsBtnChannelPlus"
        Me.tsBtnChannelPlus.Size = New System.Drawing.Size(23, 22)
        Me.tsBtnChannelPlus.Text = "+"
        '
        'Keyboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 67)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Keyboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Keyboard"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As Windows.Forms.ToolStripLabel
    Friend WithEvents tsLblPos As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As Windows.Forms.ToolStripLabel
    Friend WithEvents tsLblOffset As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As Windows.Forms.ToolStripLabel
    Friend WithEvents tsLblNoteName As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As Windows.Forms.ToolStripLabel
    Friend WithEvents tsLblNoteNr As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel6 As Windows.Forms.ToolStripLabel
    Friend WithEvents tsLblVelocity As Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents tsDdBtnSettings As Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsCbFirstKey As Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripMenuItem2 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsCbNrOfKeys As Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripMenuItem3 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsCbScale As Windows.Forms.ToolStripComboBox
    Friend WithEvents tsMiEnterSettings As Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnHold As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As Windows.Forms.ToolStripLabel
    Friend WithEvents tsLblChannelNumber As Windows.Forms.ToolStripLabel
    Friend WithEvents tsBtnChannelMinus As Windows.Forms.ToolStripButton
    Friend WithEvents tsBtnChannelPlus As Windows.Forms.ToolStripButton
End Class
