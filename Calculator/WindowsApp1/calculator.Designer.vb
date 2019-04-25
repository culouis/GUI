<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calculator
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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.BackColor = System.Drawing.Color.White
        Me.lblDisplay.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(18, 47)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(37, 39)
        Me.lblDisplay.TabIndex = 1
        Me.lblDisplay.Text = "0"
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btn1.Location = New System.Drawing.Point(12, 110)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(77, 70)
        Me.btn1.TabIndex = 2
        Me.btn1.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btn2.Location = New System.Drawing.Point(95, 110)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(77, 70)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btn3.Location = New System.Drawing.Point(178, 110)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(77, 70)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btn4.Location = New System.Drawing.Point(12, 186)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(77, 70)
        Me.btn4.TabIndex = 5
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn5
        '
        Me.btn5.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btn5.Location = New System.Drawing.Point(95, 186)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(77, 70)
        Me.btn5.TabIndex = 6
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = True
        '
        'btn6
        '
        Me.btn6.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btn6.Location = New System.Drawing.Point(178, 186)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(77, 70)
        Me.btn6.TabIndex = 7
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = True
        '
        'btn7
        '
        Me.btn7.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btn7.Location = New System.Drawing.Point(12, 262)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(77, 70)
        Me.btn7.TabIndex = 8
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = True
        '
        'btn8
        '
        Me.btn8.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btn8.Location = New System.Drawing.Point(95, 262)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(77, 70)
        Me.btn8.TabIndex = 9
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = True
        '
        'btn9
        '
        Me.btn9.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btn9.Location = New System.Drawing.Point(178, 262)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(77, 70)
        Me.btn9.TabIndex = 10
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = True
        '
        'btn0
        '
        Me.btn0.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btn0.Location = New System.Drawing.Point(95, 338)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(77, 70)
        Me.btn0.TabIndex = 11
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btnDivision.Location = New System.Drawing.Point(261, 110)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(77, 70)
        Me.btnDivision.TabIndex = 12
        Me.btnDivision.Text = "/" & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btnMultiplication.Location = New System.Drawing.Point(261, 186)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(77, 70)
        Me.btnMultiplication.TabIndex = 13
        Me.btnMultiplication.Text = "X"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btnAddition
        '
        Me.btnAddition.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddition.Location = New System.Drawing.Point(261, 338)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(77, 70)
        Me.btnAddition.TabIndex = 14
        Me.btnAddition.Text = "+"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(12, 338)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 70)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "CE"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btnEquals.Location = New System.Drawing.Point(178, 338)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(77, 70)
        Me.btnEquals.TabIndex = 16
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnSubtraction
        '
        Me.btnSubtraction.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.btnSubtraction.Location = New System.Drawing.Point(261, 262)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(77, 70)
        Me.btnSubtraction.TabIndex = 17
        Me.btnSubtraction.Text = "-"
        Me.btnSubtraction.UseVisualStyleBackColor = True
        '
        'calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(353, 428)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblDisplay)
        Me.Name = "calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents btnAddition As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnSubtraction As Button
End Class
