<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FinancialCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinancialCalc))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHouseCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btbCalculate = New System.Windows.Forms.Button()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstTotals = New System.Windows.Forms.ListBox()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.lblPrincipal = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(700, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'txtInterest
        '
        Me.txtInterest.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterest.Location = New System.Drawing.Point(150, 46)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(74, 29)
        Me.txtInterest.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Interest Rate"
        '
        'txtHouseCost
        '
        Me.txtHouseCost.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseCost.Location = New System.Drawing.Point(150, 100)
        Me.txtHouseCost.Name = "txtHouseCost"
        Me.txtHouseCost.Size = New System.Drawing.Size(122, 29)
        Me.txtHouseCost.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cost of House"
        '
        'btbCalculate
        '
        Me.btbCalculate.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbCalculate.Location = New System.Drawing.Point(59, 259)
        Me.btbCalculate.Name = "btbCalculate"
        Me.btbCalculate.Size = New System.Drawing.Size(110, 68)
        Me.btbCalculate.TabIndex = 7
        Me.btbCalculate.Text = "Calculate"
        Me.btbCalculate.UseVisualStyleBackColor = True
        '
        'txtYears
        '
        Me.txtYears.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYears.Location = New System.Drawing.Point(183, 142)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(41, 29)
        Me.txtYears.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Number Of Years"
        '
        'lstTotals
        '
        Me.lstTotals.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTotals.FormattingEnabled = True
        Me.lstTotals.ItemHeight = 23
        Me.lstTotals.Location = New System.Drawing.Point(341, 26)
        Me.lstTotals.Name = "lstTotals"
        Me.lstTotals.Size = New System.Drawing.Size(223, 372)
        Me.lstTotals.TabIndex = 10
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipal.Location = New System.Drawing.Point(150, 177)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(122, 29)
        Me.txtPrincipal.TabIndex = 12
        '
        'lblPrincipal
        '
        Me.lblPrincipal.AutoSize = True
        Me.lblPrincipal.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrincipal.Location = New System.Drawing.Point(24, 180)
        Me.lblPrincipal.Name = "lblPrincipal"
        Me.lblPrincipal.Size = New System.Drawing.Size(88, 23)
        Me.lblPrincipal.TabIndex = 11
        Me.lblPrincipal.Text = "Principal"
        '
        'FinancialCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(700, 472)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.lblPrincipal)
        Me.Controls.Add(Me.lstTotals)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btbCalculate)
        Me.Controls.Add(Me.txtHouseCost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FinancialCalc"
        Me.Text = "Financial Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtHouseCost As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btbCalculate As Button
    Friend WithEvents txtYears As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstTotals As ListBox
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents lblPrincipal As Label
End Class
