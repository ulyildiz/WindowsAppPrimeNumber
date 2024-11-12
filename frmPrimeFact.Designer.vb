<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrimeFact
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnFindPrimeFact = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstFactors = New System.Windows.Forms.ListBox()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblErrorInput = New System.Windows.Forms.Label()
        Me.lblFactorCount = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFindPrimeFact
        '
        Me.btnFindPrimeFact.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnFindPrimeFact.Location = New System.Drawing.Point(260, 163)
        Me.btnFindPrimeFact.Name = "btnFindPrimeFact"
        Me.btnFindPrimeFact.Size = New System.Drawing.Size(175, 59)
        Me.btnFindPrimeFact.TabIndex = 0
        Me.btnFindPrimeFact.Text = "Find Prime Factors"
        Me.btnFindPrimeFact.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(180, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Prime Factorization"
        '
        'lstFactors
        '
        Me.lstFactors.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lstFactors.FormattingEnabled = True
        Me.lstFactors.ItemHeight = 25
        Me.lstFactors.Location = New System.Drawing.Point(35, 77)
        Me.lstFactors.Name = "lstFactors"
        Me.lstFactors.Size = New System.Drawing.Size(214, 329)
        Me.lstFactors.TabIndex = 2
        '
        'txtUserInput
        '
        Me.txtUserInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInput.Location = New System.Drawing.Point(260, 93)
        Me.txtUserInput.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(175, 31)
        Me.txtUserInput.TabIndex = 3
        '
        'lblErrorInput
        '
        Me.lblErrorInput.AutoSize = True
        Me.lblErrorInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblErrorInput.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblErrorInput.Location = New System.Drawing.Point(255, 260)
        Me.lblErrorInput.Name = "lblErrorInput"
        Me.lblErrorInput.Size = New System.Drawing.Size(317, 25)
        Me.lblErrorInput.TabIndex = 4
        Me.lblErrorInput.Text = "Input should be positive number"
        Me.lblErrorInput.Visible = False
        '
        'lblFactorCount
        '
        Me.lblFactorCount.AutoSize = True
        Me.lblFactorCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblFactorCount.Location = New System.Drawing.Point(473, 100)
        Me.lblFactorCount.Name = "lblFactorCount"
        Me.lblFactorCount.Size = New System.Drawing.Size(25, 24)
        Me.lblFactorCount.TabIndex = 6
        Me.lblFactorCount.Text = "..."
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnClear.Location = New System.Drawing.Point(477, 163)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 59)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmPrimeFact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(678, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblFactorCount)
        Me.Controls.Add(Me.lblErrorInput)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.lstFactors)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFindPrimeFact)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPrimeFact"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFindPrimeFact As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lstFactors As ListBox
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblErrorInput As Label
    Friend WithEvents lblFactorCount As Label
    Friend WithEvents btnClear As Button
End Class
