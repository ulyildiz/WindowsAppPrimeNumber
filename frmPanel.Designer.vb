<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPanel
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlButton = New System.Windows.Forms.Panel()
        Me.btnFindUpTo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrimefact = New System.Windows.Forms.Button()
        Me.btnPrimeControl = New System.Windows.Forms.Button()
        Me.pnlDisplay = New System.Windows.Forms.Panel()
        Me.pnlButton.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButton
        '
        Me.pnlButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlButton.Controls.Add(Me.btnFindUpTo)
        Me.pnlButton.Controls.Add(Me.btnExit)
        Me.pnlButton.Controls.Add(Me.btnPrimefact)
        Me.pnlButton.Controls.Add(Me.btnPrimeControl)
        Me.pnlButton.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlButton.Location = New System.Drawing.Point(0, 0)
        Me.pnlButton.Name = "pnlButton"
        Me.pnlButton.Size = New System.Drawing.Size(122, 450)
        Me.pnlButton.TabIndex = 0
        '
        'btnFindUpTo
        '
        Me.btnFindUpTo.Location = New System.Drawing.Point(3, 211)
        Me.btnFindUpTo.Name = "btnFindUpTo"
        Me.btnFindUpTo.Size = New System.Drawing.Size(116, 55)
        Me.btnFindUpTo.TabIndex = 3
        Me.btnFindUpTo.Text = "Find Prime Numbers Up To"
        Me.btnFindUpTo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(0, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 55)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnPrimefact
        '
        Me.btnPrimefact.Location = New System.Drawing.Point(3, 150)
        Me.btnPrimefact.Name = "btnPrimefact"
        Me.btnPrimefact.Size = New System.Drawing.Size(116, 55)
        Me.btnPrimefact.TabIndex = 1
        Me.btnPrimefact.Text = "Prime Factorisation"
        Me.btnPrimefact.UseVisualStyleBackColor = True
        '
        'btnPrimeControl
        '
        Me.btnPrimeControl.Location = New System.Drawing.Point(3, 89)
        Me.btnPrimeControl.Name = "btnPrimeControl"
        Me.btnPrimeControl.Size = New System.Drawing.Size(116, 55)
        Me.btnPrimeControl.TabIndex = 0
        Me.btnPrimeControl.Text = "Prime Control"
        Me.btnPrimeControl.UseVisualStyleBackColor = True
        '
        'pnlDisplay
        '
        Me.pnlDisplay.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDisplay.Location = New System.Drawing.Point(122, 0)
        Me.pnlDisplay.Name = "pnlDisplay"
        Me.pnlDisplay.Size = New System.Drawing.Size(678, 450)
        Me.pnlDisplay.TabIndex = 1
        '
        'frmPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlDisplay)
        Me.Controls.Add(Me.pnlButton)
        Me.Name = "frmPanel"
        Me.Text = "PrimeApp"
        Me.pnlButton.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlButton As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrimefact As Button
    Friend WithEvents btnPrimeControl As Button
    Friend WithEvents pnlDisplay As Panel
    Friend WithEvents btnFindUpTo As Button
End Class
