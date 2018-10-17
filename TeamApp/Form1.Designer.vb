<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Add1 = New System.Windows.Forms.Button()
        Me.Minus1 = New System.Windows.Forms.Button()
        Me.Multiply2 = New System.Windows.Forms.Button()
        Me.Divide2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(108, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(508, 266)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Add1
        '
        Me.Add1.Location = New System.Drawing.Point(9, 27)
        Me.Add1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Add1.Name = "Add1"
        Me.Add1.Size = New System.Drawing.Size(88, 23)
        Me.Add1.TabIndex = 1
        Me.Add1.Text = "Add 1"
        Me.Add1.UseVisualStyleBackColor = True
        '
        'Minus1
        '
        Me.Minus1.Location = New System.Drawing.Point(9, 54)
        Me.Minus1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Minus1.Name = "Minus1"
        Me.Minus1.Size = New System.Drawing.Size(88, 23)
        Me.Minus1.TabIndex = 2
        Me.Minus1.Text = "Minus 1"
        Me.Minus1.UseVisualStyleBackColor = True
        '
        'Multiply2
        '
        Me.Multiply2.Location = New System.Drawing.Point(9, 82)
        Me.Multiply2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Multiply2.Name = "Multiply2"
        Me.Multiply2.Size = New System.Drawing.Size(88, 23)
        Me.Multiply2.TabIndex = 3
        Me.Multiply2.Text = "Multiply 2"
        Me.Multiply2.UseVisualStyleBackColor = True
        '
        'Divide2
        '
        Me.Divide2.Location = New System.Drawing.Point(9, 110)
        Me.Divide2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Divide2.Name = "Divide2"
        Me.Divide2.Size = New System.Drawing.Size(88, 23)
        Me.Divide2.TabIndex = 4
        Me.Divide2.Text = "Divide 2"
        Me.Divide2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Divide2)
        Me.Controls.Add(Me.Multiply2)
        Me.Controls.Add(Me.Minus1)
        Me.Controls.Add(Me.Add1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Add1 As Button
    Friend WithEvents Minus1 As Button
    Friend WithEvents Multiply2 As Button
    Friend WithEvents Divide2 As Button
End Class
