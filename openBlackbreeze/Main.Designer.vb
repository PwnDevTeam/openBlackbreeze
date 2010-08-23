<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblInfo = New System.Windows.Forms.Label
        Me.dlgBlackra1n = New System.Windows.Forms.OpenFileDialog
        Me.dlgSaveBlackra1n = New System.Windows.Forms.SaveFileDialog
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(427, 64)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Fix my ra1n!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.White
        Me.lblInfo.Location = New System.Drawing.Point(-1, 82)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(453, 39)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Clicking the button above will solve issues for iTunes 9.1+" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and making blackra1n" & _
            " fully working for 3.1.2."
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dlgBlackra1n
        '
        Me.dlgBlackra1n.Filter = "EXE files|*.exe"
        Me.dlgBlackra1n.Title = "Select your blackra1n.exe"
        '
        'dlgSaveBlackra1n
        '
        Me.dlgSaveBlackra1n.FileName = "blackra1n_fixed.exe"
        Me.dlgSaveBlackra1n.Filter = "EXE Files|*.exe"
        Me.dlgSaveBlackra1n.Title = "Select where to save your fixed blackra1n.exe"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(451, 122)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.ShowIcon = False
        Me.Text = "openBlackbreeze -- Makes blackra1n breeze.. ;-) By: Fallensn0w"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents dlgBlackra1n As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dlgSaveBlackra1n As System.Windows.Forms.SaveFileDialog

End Class
