<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJobTechFair
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJobTechFair))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSubTitle = New System.Windows.Forms.Label()
        Me.lblDetails = New System.Windows.Forms.Label()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picJobFair = New System.Windows.Forms.PictureBox()
        CType(Me.picJobFair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(12, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(209, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Tech Job Fair"
        '
        'lblSubTitle
        '
        Me.lblSubTitle.AutoSize = True
        Me.lblSubTitle.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblSubTitle.Location = New System.Drawing.Point(29, 52)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(174, 18)
        Me.lblSubTitle.TabIndex = 0
        Me.lblSubTitle.Text = "All Students are Welcome"
        '
        'lblDetails
        '
        Me.lblDetails.AutoSize = True
        Me.lblDetails.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.lblDetails.Location = New System.Drawing.Point(41, 250)
        Me.lblDetails.Name = "lblDetails"
        Me.lblDetails.Size = New System.Drawing.Size(154, 54)
        Me.lblDetails.TabIndex = 0
        Me.lblDetails.Text = "May 2, 2016" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Located in Lochlan Hall" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Room 101"
        Me.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDetails.Visible = False
        '
        'btnDetails
        '
        Me.btnDetails.BackColor = System.Drawing.Color.Honeydew
        Me.btnDetails.Location = New System.Drawing.Point(49, 89)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(135, 48)
        Me.btnDetails.TabIndex = 1
        Me.btnDetails.Text = "View Job Fair Details"
        Me.btnDetails.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Honeydew
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(56, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 38)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picJobFair
        '
        Me.picJobFair.Image = CType(resources.GetObject("picJobFair.Image"), System.Drawing.Image)
        Me.picJobFair.Location = New System.Drawing.Point(227, 17)
        Me.picJobFair.Name = "picJobFair"
        Me.picJobFair.Size = New System.Drawing.Size(271, 450)
        Me.picJobFair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJobFair.TabIndex = 2
        Me.picJobFair.TabStop = False
        '
        'frmJobTechFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(510, 479)
        Me.Controls.Add(Me.picJobFair)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDetails)
        Me.Controls.Add(Me.lblDetails)
        Me.Controls.Add(Me.lblSubTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmJobTechFair"
        CType(Me.picJobFair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSubTitle As Label
    Friend WithEvents lblDetails As Label
    Friend WithEvents btnDetails As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picJobFair As PictureBox
End Class
