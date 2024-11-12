<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIsPrime
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblInputError = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblIsPrime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.85714!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(5, 180)
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
        Me.txtUserInput.Location = New System.Drawing.Point(5, 115)
        Me.txtUserInput.Margin = New System.Windows.Forms.Padding(2)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(253, 31)
        Me.txtUserInput.TabIndex = 1
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(263, 186)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(31, 29)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "..."
        '
        'lblInputError
        '
        Me.lblInputError.AutoSize = True
        Me.lblInputError.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblInputError.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblInputError.Location = New System.Drawing.Point(263, 118)
        Me.lblInputError.Name = "lblInputError"
        Me.lblInputError.Size = New System.Drawing.Size(403, 25)
        Me.lblInputError.TabIndex = 3
        Me.lblInputError.Text = "Your input should only consist of number"
        Me.lblInputError.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnClear.Location = New System.Drawing.Point(135, 255)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(123, 43)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblIsPrime
        '
        Me.lblIsPrime.AutoSize = True
        Me.lblIsPrime.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblIsPrime.Location = New System.Drawing.Point(261, 26)
        Me.lblIsPrime.Name = "lblIsPrime"
        Me.lblIsPrime.Size = New System.Drawing.Size(164, 39)
        Me.lblIsPrime.TabIndex = 5
        Me.lblIsPrime.Text = "Is Prime?"
        '
        'frmIsPrime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(678, 450)
        Me.Controls.Add(Me.lblIsPrime)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblInputError)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.btnCalculate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmIsPrime"
        Me.Text = "Prime Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblInputError As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblIsPrime As Label
End Class
