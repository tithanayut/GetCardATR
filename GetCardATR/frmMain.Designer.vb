<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cbbReaderList = New System.Windows.Forms.ComboBox()
        Me.lblCardReader = New System.Windows.Forms.Label()
        Me.btnRefreshList = New System.Windows.Forms.Button()
        Me.lblCardATR = New System.Windows.Forms.Label()
        Me.txtCardATR = New System.Windows.Forms.TextBox()
        Me.btnReadATR = New System.Windows.Forms.Button()
        Me.lblRetrieveOn = New System.Windows.Forms.Label()
        Me.lblRetrievedDateTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbbReaderList
        '
        Me.cbbReaderList.FormattingEnabled = True
        Me.cbbReaderList.Location = New System.Drawing.Point(149, 39)
        Me.cbbReaderList.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbReaderList.Name = "cbbReaderList"
        Me.cbbReaderList.Size = New System.Drawing.Size(270, 26)
        Me.cbbReaderList.TabIndex = 0
        '
        'lblCardReader
        '
        Me.lblCardReader.AutoSize = True
        Me.lblCardReader.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCardReader.Location = New System.Drawing.Point(36, 42)
        Me.lblCardReader.Name = "lblCardReader"
        Me.lblCardReader.Size = New System.Drawing.Size(106, 18)
        Me.lblCardReader.TabIndex = 1
        Me.lblCardReader.Text = "Card Reader:"
        '
        'btnRefreshList
        '
        Me.btnRefreshList.Location = New System.Drawing.Point(426, 39)
        Me.btnRefreshList.Name = "btnRefreshList"
        Me.btnRefreshList.Size = New System.Drawing.Size(107, 26)
        Me.btnRefreshList.TabIndex = 2
        Me.btnRefreshList.Text = "Refresh List"
        Me.btnRefreshList.UseVisualStyleBackColor = True
        '
        'lblCardATR
        '
        Me.lblCardATR.AutoSize = True
        Me.lblCardATR.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCardATR.Location = New System.Drawing.Point(60, 151)
        Me.lblCardATR.Name = "lblCardATR"
        Me.lblCardATR.Size = New System.Drawing.Size(82, 18)
        Me.lblCardATR.TabIndex = 3
        Me.lblCardATR.Text = "Card ATR:"
        '
        'txtCardATR
        '
        Me.txtCardATR.Location = New System.Drawing.Point(149, 148)
        Me.txtCardATR.Name = "txtCardATR"
        Me.txtCardATR.ReadOnly = True
        Me.txtCardATR.Size = New System.Drawing.Size(270, 26)
        Me.txtCardATR.TabIndex = 4
        '
        'btnReadATR
        '
        Me.btnReadATR.Location = New System.Drawing.Point(228, 93)
        Me.btnReadATR.Name = "btnReadATR"
        Me.btnReadATR.Size = New System.Drawing.Size(115, 32)
        Me.btnReadATR.TabIndex = 5
        Me.btnReadATR.Text = "Read Card"
        Me.btnReadATR.UseVisualStyleBackColor = True
        '
        'lblRetrieveOn
        '
        Me.lblRetrieveOn.AutoSize = True
        Me.lblRetrieveOn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblRetrieveOn.Location = New System.Drawing.Point(42, 187)
        Me.lblRetrieveOn.Name = "lblRetrieveOn"
        Me.lblRetrieveOn.Size = New System.Drawing.Size(100, 18)
        Me.lblRetrieveOn.TabIndex = 6
        Me.lblRetrieveOn.Text = "Retrieve on:"
        '
        'lblRetrievedDateTime
        '
        Me.lblRetrievedDateTime.AutoSize = True
        Me.lblRetrievedDateTime.Location = New System.Drawing.Point(148, 187)
        Me.lblRetrievedDateTime.Name = "lblRetrievedDateTime"
        Me.lblRetrievedDateTime.Size = New System.Drawing.Size(0, 18)
        Me.lblRetrievedDateTime.TabIndex = 7
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 234)
        Me.Controls.Add(Me.lblRetrievedDateTime)
        Me.Controls.Add(Me.lblRetrieveOn)
        Me.Controls.Add(Me.btnReadATR)
        Me.Controls.Add(Me.txtCardATR)
        Me.Controls.Add(Me.lblCardATR)
        Me.Controls.Add(Me.btnRefreshList)
        Me.Controls.Add(Me.lblCardReader)
        Me.Controls.Add(Me.cbbReaderList)
        Me.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "GetCardATR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbbReaderList As ComboBox
    Friend WithEvents lblCardReader As Label
    Friend WithEvents btnRefreshList As Button
    Friend WithEvents lblCardATR As Label
    Friend WithEvents txtCardATR As TextBox
    Friend WithEvents btnReadATR As Button
    Friend WithEvents lblRetrieveOn As Label
    Friend WithEvents lblRetrievedDateTime As Label
End Class
