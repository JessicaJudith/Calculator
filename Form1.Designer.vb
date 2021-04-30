<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Add_Btn = New System.Windows.Forms.Button()
        Me.Sub_Btn = New System.Windows.Forms.Button()
        Me.X_Value = New System.Windows.Forms.TextBox()
        Me.Y_Value = New System.Windows.Forms.TextBox()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Multipy_Btn = New System.Windows.Forms.Button()
        Me.Div_Btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Mod_Btn = New System.Windows.Forms.Button()
        Me.Square_Btn = New System.Windows.Forms.Button()
        Me.Cube_Btn = New System.Windows.Forms.Button()
        Me.Fact_Btn = New System.Windows.Forms.Button()
        Me.Inverse_Btn = New System.Windows.Forms.Button()
        Me.Exponential_Btn = New System.Windows.Forms.Button()
        Me.SquarRoot_Btn = New System.Windows.Forms.Button()
        Me.Log_Btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Add_Btn
        '
        Me.Add_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Btn.Location = New System.Drawing.Point(20, 70)
        Me.Add_Btn.Name = "Add_Btn"
        Me.Add_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Add_Btn.TabIndex = 0
        Me.Add_Btn.Text = "+"
        Me.Add_Btn.UseVisualStyleBackColor = True
        '
        'Sub_Btn
        '
        Me.Sub_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sub_Btn.Location = New System.Drawing.Point(72, 69)
        Me.Sub_Btn.Name = "Sub_Btn"
        Me.Sub_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Sub_Btn.TabIndex = 1
        Me.Sub_Btn.Text = "-"
        Me.Sub_Btn.UseVisualStyleBackColor = True
        '
        'X_Value
        '
        Me.X_Value.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.X_Value.Location = New System.Drawing.Point(91, 17)
        Me.X_Value.Name = "X_Value"
        Me.X_Value.Size = New System.Drawing.Size(122, 23)
        Me.X_Value.TabIndex = 2
        '
        'Y_Value
        '
        Me.Y_Value.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Y_Value.Location = New System.Drawing.Point(91, 43)
        Me.Y_Value.Name = "Y_Value"
        Me.Y_Value.Size = New System.Drawing.Size(122, 23)
        Me.Y_Value.TabIndex = 3
        '
        'Result
        '
        Me.Result.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Result.Location = New System.Drawing.Point(91, 205)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(123, 23)
        Me.Result.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Value 1 :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Value 2 :"
        '
        'Multipy_Btn
        '
        Me.Multipy_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multipy_Btn.Location = New System.Drawing.Point(124, 69)
        Me.Multipy_Btn.Name = "Multipy_Btn"
        Me.Multipy_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Multipy_Btn.TabIndex = 7
        Me.Multipy_Btn.Text = "*"
        Me.Multipy_Btn.UseVisualStyleBackColor = True
        '
        'Div_Btn
        '
        Me.Div_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Div_Btn.Location = New System.Drawing.Point(176, 69)
        Me.Div_Btn.Name = "Div_Btn"
        Me.Div_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Div_Btn.TabIndex = 8
        Me.Div_Btn.Text = "/"
        Me.Div_Btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Result :"
        '
        'Mod_Btn
        '
        Me.Mod_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mod_Btn.Location = New System.Drawing.Point(20, 147)
        Me.Mod_Btn.Name = "Mod_Btn"
        Me.Mod_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Mod_Btn.TabIndex = 10
        Me.Mod_Btn.Text = "%"
        Me.Mod_Btn.UseVisualStyleBackColor = True
        '
        'Square_Btn
        '
        Me.Square_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Square_Btn.Location = New System.Drawing.Point(72, 108)
        Me.Square_Btn.Name = "Square_Btn"
        Me.Square_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Square_Btn.TabIndex = 11
        Me.Square_Btn.Text = "^2"
        Me.Square_Btn.UseVisualStyleBackColor = True
        '
        'Cube_Btn
        '
        Me.Cube_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cube_Btn.Location = New System.Drawing.Point(124, 110)
        Me.Cube_Btn.Name = "Cube_Btn"
        Me.Cube_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Cube_Btn.TabIndex = 12
        Me.Cube_Btn.Text = "^3"
        Me.Cube_Btn.UseVisualStyleBackColor = True
        '
        'Fact_Btn
        '
        Me.Fact_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fact_Btn.Location = New System.Drawing.Point(72, 147)
        Me.Fact_Btn.Name = "Fact_Btn"
        Me.Fact_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Fact_Btn.TabIndex = 13
        Me.Fact_Btn.Text = "!"
        Me.Fact_Btn.UseVisualStyleBackColor = True
        '
        'Inverse_Btn
        '
        Me.Inverse_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inverse_Btn.Location = New System.Drawing.Point(176, 110)
        Me.Inverse_Btn.Name = "Inverse_Btn"
        Me.Inverse_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Inverse_Btn.TabIndex = 14
        Me.Inverse_Btn.Text = "^-1"
        Me.Inverse_Btn.UseVisualStyleBackColor = True
        '
        'Exponential_Btn
        '
        Me.Exponential_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exponential_Btn.Location = New System.Drawing.Point(20, 110)
        Me.Exponential_Btn.Name = "Exponential_Btn"
        Me.Exponential_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Exponential_Btn.TabIndex = 15
        Me.Exponential_Btn.Text = "^"
        Me.Exponential_Btn.UseVisualStyleBackColor = True
        '
        'SquarRoot_Btn
        '
        Me.SquarRoot_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SquarRoot_Btn.Location = New System.Drawing.Point(124, 148)
        Me.SquarRoot_Btn.Name = "SquarRoot_Btn"
        Me.SquarRoot_Btn.Size = New System.Drawing.Size(46, 33)
        Me.SquarRoot_Btn.TabIndex = 16
        Me.SquarRoot_Btn.Text = "Sq.Rt"
        Me.SquarRoot_Btn.UseVisualStyleBackColor = True
        '
        'Log_Btn
        '
        Me.Log_Btn.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Log_Btn.Location = New System.Drawing.Point(176, 148)
        Me.Log_Btn.Name = "Log_Btn"
        Me.Log_Btn.Size = New System.Drawing.Size(46, 33)
        Me.Log_Btn.TabIndex = 17
        Me.Log_Btn.Text = "log"
        Me.Log_Btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 245)
        Me.Controls.Add(Me.Log_Btn)
        Me.Controls.Add(Me.SquarRoot_Btn)
        Me.Controls.Add(Me.Exponential_Btn)
        Me.Controls.Add(Me.Inverse_Btn)
        Me.Controls.Add(Me.Fact_Btn)
        Me.Controls.Add(Me.Cube_Btn)
        Me.Controls.Add(Me.Square_Btn)
        Me.Controls.Add(Me.Mod_Btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Div_Btn)
        Me.Controls.Add(Me.Multipy_Btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Y_Value)
        Me.Controls.Add(Me.X_Value)
        Me.Controls.Add(Me.Sub_Btn)
        Me.Controls.Add(Me.Add_Btn)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Add_Btn As Button
    Friend WithEvents Sub_Btn As Button
    Friend WithEvents X_Value As TextBox
    Friend WithEvents Y_Value As TextBox
    Friend WithEvents Result As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Multipy_Btn As Button
    Friend WithEvents Div_Btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Mod_Btn As Button
    Friend WithEvents Square_Btn As Button
    Friend WithEvents Cube_Btn As Button
    Friend WithEvents Fact_Btn As Button
    Friend WithEvents Inverse_Btn As Button
    Friend WithEvents Exponential_Btn As Button
    Friend WithEvents SquarRoot_Btn As Button
    Friend WithEvents Log_Btn As Button
End Class
