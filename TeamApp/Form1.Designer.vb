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
        Me.Mixed1 = New System.Windows.Forms.Button()
        Me.Clear_Btn = New System.Windows.Forms.Button()
        Me.Mixed2 = New System.Windows.Forms.Button()
        Me.MixedVis_Btn = New System.Windows.Forms.Button()
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
        Me.Add1.Margin = New System.Windows.Forms.Padding(2)
        Me.Add1.Name = "Add1"
        Me.Add1.Size = New System.Drawing.Size(88, 23)
        Me.Add1.TabIndex = 1
        Me.Add1.Text = "Add 1"
        Me.Add1.UseVisualStyleBackColor = True
        '
        'Minus1
        '
        Me.Minus1.Location = New System.Drawing.Point(9, 54)
        Me.Minus1.Margin = New System.Windows.Forms.Padding(2)
        Me.Minus1.Name = "Minus1"
        Me.Minus1.Size = New System.Drawing.Size(88, 23)
        Me.Minus1.TabIndex = 2
        Me.Minus1.Text = "Minus 1"
        Me.Minus1.UseVisualStyleBackColor = True
        '
        'Multiply2
        '
        Me.Multiply2.Location = New System.Drawing.Point(9, 82)
        Me.Multiply2.Margin = New System.Windows.Forms.Padding(2)
        Me.Multiply2.Name = "Multiply2"
        Me.Multiply2.Size = New System.Drawing.Size(88, 23)
        Me.Multiply2.TabIndex = 3
        Me.Multiply2.Text = "Multiply 2"
        Me.Multiply2.UseVisualStyleBackColor = True
        '
        'Divide2
        '
        Me.Divide2.Location = New System.Drawing.Point(9, 110)
        Me.Divide2.Margin = New System.Windows.Forms.Padding(2)
        Me.Divide2.Name = "Divide2"
        Me.Divide2.Size = New System.Drawing.Size(88, 23)
        Me.Divide2.TabIndex = 4
        Me.Divide2.Text = "Divide 2"
        Me.Divide2.UseVisualStyleBackColor = True
        '
        'Mixed1
        '
        Me.Mixed1.Location = New System.Drawing.Point(9, 137)
        Me.Mixed1.Margin = New System.Windows.Forms.Padding(2)
        Me.Mixed1.Name = "Mixed1"
        Me.Mixed1.Size = New System.Drawing.Size(88, 34)
        Me.Mixed1.TabIndex = 5
        Me.Mixed1.Text = "Multiply 2 Minus 3"
        Me.Mixed1.UseVisualStyleBackColor = True
        Me.Mixed1.Visible = False
        '
        'Clear_Btn
        '
        Me.Clear_Btn.Location = New System.Drawing.Point(621, 307)
        Me.Clear_Btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Clear_Btn.Name = "Clear_Btn"
        Me.Clear_Btn.Size = New System.Drawing.Size(88, 34)
        Me.Clear_Btn.TabIndex = 7
        Me.Clear_Btn.Text = "Clear"
        Me.Clear_Btn.UseVisualStyleBackColor = True
        '
        'Mixed2
        '
        Me.Mixed2.Location = New System.Drawing.Point(9, 176)
        Me.Mixed2.Name = "Mixed2"
        Me.Mixed2.Size = New System.Drawing.Size(88, 34)
        Me.Mixed2.TabIndex = 8
        Me.Mixed2.Text = "Add 2 Multiply 2 Minus 3"
        Me.Mixed2.UseVisualStyleBackColor = True
        Me.Mixed2.Visible = False
        '
        'MixedVis_Btn
        '
        Me.MixedVis_Btn.Location = New System.Drawing.Point(528, 307)
        Me.MixedVis_Btn.Margin = New System.Windows.Forms.Padding(2)
        Me.MixedVis_Btn.Name = "MixedVis_Btn"
        Me.MixedVis_Btn.Size = New System.Drawing.Size(88, 34)
        Me.MixedVis_Btn.TabIndex = 9
        Me.MixedVis_Btn.Text = "Mixed Numbers"
        Me.MixedVis_Btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 343)
        Me.Controls.Add(Me.MixedVis_Btn)
        Me.Controls.Add(Me.Mixed2)
        Me.Controls.Add(Me.Clear_Btn)
        Me.Controls.Add(Me.Mixed1)
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
    Friend WithEvents Mixed1 As Button
    Friend WithEvents Clear_Btn As Button
    Friend WithEvents Mixed2 As Button
    Friend WithEvents MixedVis_Btn As Button
End Class
