<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechJobFair
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTechJobFair))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblInformation = New System.Windows.Forms.Label()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Green
        Me.lblTitle.Location = New System.Drawing.Point(19, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(209, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Tech Job Fair"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblSubTitle.Location = New System.Drawing.Point(36, 79)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(174, 18)
        Me.lblSubTitle.TabIndex = 0
        Me.lblSubTitle.Text = "All Students are Welcome"
        '
        'lblInformation
        '
        Me.lblInformation.AutoSize = True
        Me.lblInformation.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblInformation.Location = New System.Drawing.Point(46, 296)
        Me.lblInformation.Name = "lblInformation"
        Me.lblInformation.Size = New System.Drawing.Size(154, 54)
        Me.lblInformation.TabIndex = 0
        Me.lblInformation.Text = "May 2, 2016" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Located in Lochlan Hall" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Room 101" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblInformation.Visible = False
        '
        'btnDetails
        '
        Me.btnDetails.BackColor = System.Drawing.Color.Honeydew
        Me.btnDetails.Location = New System.Drawing.Point(44, 132)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(159, 42)
        Me.btnDetails.TabIndex = 1
        Me.btnDetails.Text = "View Job Fair Details"
        Me.btnDetails.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Honeydew
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(70, 479)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 42)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(249, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(333, 522)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmTechJobFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(594, 546)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.lblInformation)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmTechJobFair"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblInformation As Label
    Friend WithEvents btnDetails As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
