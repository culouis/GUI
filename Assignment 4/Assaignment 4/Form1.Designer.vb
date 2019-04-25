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
        Me.lstGames = New System.Windows.Forms.ListBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDownloads = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalDownloads = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstGames
        '
        Me.lstGames.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGames.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lstGames.FormattingEnabled = True
        Me.lstGames.ItemHeight = 19
        Me.lstGames.Location = New System.Drawing.Point(115, 68)
        Me.lstGames.Name = "lstGames"
        Me.lstGames.Size = New System.Drawing.Size(235, 137)
        Me.lstGames.TabIndex = 0
        '
        'btn
        '
        Me.btn.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btn.Location = New System.Drawing.Point(463, 131)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(196, 42)
        Me.btn.TabIndex = 1
        Me.btn.Text = "View Downloads"
        Me.btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(391, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select A Game to Displaty More Info"
        '
        'lblDownloads
        '
        Me.lblDownloads.AutoSize = True
        Me.lblDownloads.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDownloads.Location = New System.Drawing.Point(128, 306)
        Me.lblDownloads.Name = "lblDownloads"
        Me.lblDownloads.Size = New System.Drawing.Size(240, 25)
        Me.lblDownloads.TabIndex = 3
        Me.lblDownloads.Text = "XXXXXXXXXXXXXXXXXXX"
        Me.lblDownloads.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(110, 365)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total Amount of Downloads: "
        Me.Label2.Visible = False
        '
        'lblTotalDownloads
        '
        Me.lblTotalDownloads.AutoSize = True
        Me.lblTotalDownloads.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDownloads.Location = New System.Drawing.Point(401, 365)
        Me.lblTotalDownloads.Name = "lblTotalDownloads"
        Me.lblTotalDownloads.Size = New System.Drawing.Size(240, 25)
        Me.lblTotalDownloads.TabIndex = 6
        Me.lblTotalDownloads.Text = "XXXXXXXXXXXXXXXXXXX"
        Me.lblTotalDownloads.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblTotalDownloads)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDownloads)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.lstGames)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstGames As ListBox
    Friend WithEvents btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDownloads As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalDownloads As Label
End Class
