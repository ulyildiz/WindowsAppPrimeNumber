<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class isPrime
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtNmax = New System.Windows.Forms.TextBox()
        Me.btnListPrimeNumbers = New System.Windows.Forms.Button()
        Me.lstPrimeNumbers = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(198, 44)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(253, 43)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Is it a prime number?"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtUserInput
        '
        Me.txtUserInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserInput.Location = New System.Drawing.Point(32, 53)
        Me.txtUserInput.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(139, 31)
        Me.txtUserInput.TabIndex = 1
        Me.txtUserInput.Text = "79"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(487, 53)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(107, 29)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "waiting..."
        '
        'txtNmax
        '
        Me.txtNmax.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNmax.Location = New System.Drawing.Point(305, 119)
        Me.txtNmax.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNmax.Name = "txtNmax"
        Me.txtNmax.Size = New System.Drawing.Size(139, 31)
        Me.txtNmax.TabIndex = 3
        Me.txtNmax.Text = "100"
        '
        'btnListPrimeNumbers
        '
        Me.btnListPrimeNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListPrimeNumbers.Location = New System.Drawing.Point(40, 110)
        Me.btnListPrimeNumbers.Margin = New System.Windows.Forms.Padding(2)
        Me.btnListPrimeNumbers.Name = "btnListPrimeNumbers"
        Me.btnListPrimeNumbers.Size = New System.Drawing.Size(253, 43)
        Me.btnListPrimeNumbers.TabIndex = 5
        Me.btnListPrimeNumbers.Text = "List prime numbers up to"
        Me.btnListPrimeNumbers.UseVisualStyleBackColor = True
        '
        'lstPrimeNumbers
        '
        Me.lstPrimeNumbers.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrimeNumbers.FormattingEnabled = True
        Me.lstPrimeNumbers.ItemHeight = 29
        Me.lstPrimeNumbers.Location = New System.Drawing.Point(483, 110)
        Me.lstPrimeNumbers.Margin = New System.Windows.Forms.Padding(2)
        Me.lstPrimeNumbers.Name = "lstPrimeNumbers"
        Me.lstPrimeNumbers.ScrollAlwaysVisible = True
        Me.lstPrimeNumbers.Size = New System.Drawing.Size(131, 178)
        Me.lstPrimeNumbers.TabIndex = 6
        '
        'isPrime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 424)
        Me.Controls.Add(Me.lstPrimeNumbers)
        Me.Controls.Add(Me.btnListPrimeNumbers)
        Me.Controls.Add(Me.txtNmax)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "isPrime"
        Me.Text = "Prime Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents txtNmax As TextBox
    Friend WithEvents btnListPrimeNumbers As Button
    Friend WithEvents lstPrimeNumbers As ListBox
End Class
