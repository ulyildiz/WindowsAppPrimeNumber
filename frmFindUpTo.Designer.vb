<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindUpTo
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
        Me.btnListPrimeNumbers = New System.Windows.Forms.Button()
        Me.txtNmax = New System.Windows.Forms.TextBox()
        Me.lstPrimeNumbers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblErrorText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnListPrimeNumbers
        '
        Me.btnListPrimeNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListPrimeNumbers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnListPrimeNumbers.Location = New System.Drawing.Point(251, 87)
        Me.btnListPrimeNumbers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnListPrimeNumbers.Name = "btnListPrimeNumbers"
        Me.btnListPrimeNumbers.Size = New System.Drawing.Size(312, 66)
        Me.btnListPrimeNumbers.TabIndex = 6
        Me.btnListPrimeNumbers.Text = "List prime numbers up to"
        Me.btnListPrimeNumbers.UseVisualStyleBackColor = True
        '
        'txtNmax
        '
        Me.txtNmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmax.Location = New System.Drawing.Point(251, 182)
        Me.txtNmax.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNmax.Name = "txtNmax"
        Me.txtNmax.Size = New System.Drawing.Size(312, 31)
        Me.txtNmax.TabIndex = 7
        Me.txtNmax.Text = "100"
        '
        'lstPrimeNumbers
        '
        Me.lstPrimeNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstPrimeNumbers.FormattingEnabled = True
        Me.lstPrimeNumbers.ItemHeight = 25
        Me.lstPrimeNumbers.Location = New System.Drawing.Point(11, 87)
        Me.lstPrimeNumbers.Margin = New System.Windows.Forms.Padding(2)
        Me.lstPrimeNumbers.Name = "lstPrimeNumbers"
        Me.lstPrimeNumbers.ScrollAlwaysVisible = True
        Me.lstPrimeNumbers.Size = New System.Drawing.Size(221, 329)
        Me.lstPrimeNumbers.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 39)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Find Prime Numbers"
        '
        'lblErrorText
        '
        Me.lblErrorText.AutoSize = True
        Me.lblErrorText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblErrorText.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblErrorText.Location = New System.Drawing.Point(246, 232)
        Me.lblErrorText.Name = "lblErrorText"
        Me.lblErrorText.Size = New System.Drawing.Size(245, 20)
        Me.lblErrorText.TabIndex = 10
        Me.lblErrorText.Text = "Input should be positive number"
        Me.lblErrorText.Visible = False
        '
        'frmFindUpTo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(678, 450)
        Me.Controls.Add(Me.lblErrorText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstPrimeNumbers)
        Me.Controls.Add(Me.txtNmax)
        Me.Controls.Add(Me.btnListPrimeNumbers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmFindUpTo"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnListPrimeNumbers As Button
    Friend WithEvents txtNmax As TextBox
    Friend WithEvents lstPrimeNumbers As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblErrorText As Label
End Class
