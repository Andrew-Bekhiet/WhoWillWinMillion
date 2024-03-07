<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Qs
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
        Me.SoundPlayer = New System.ComponentModel.BackgroundWorker()
        Me.TLP1 = New System.Windows.Forms.TableLayoutPanel()
        Me._Friend = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.HW = New System.Windows.Forms.PictureBox()
        Me.D2 = New System.Windows.Forms.PictureBox()
        Me.HF = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Q = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.A2 = New System.Windows.Forms.Label()
        Me.A3 = New System.Windows.Forms.Label()
        Me.A1 = New System.Windows.Forms.Label()
        Me.A4 = New System.Windows.Forms.Label()
        Me.TLP1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.HW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SoundPlayer
        '
        Me.SoundPlayer.WorkerSupportsCancellation = True
        '
        'TLP1
        '
        Me.TLP1.BackColor = System.Drawing.Color.Lavender
        Me.TLP1.ColumnCount = 1
        Me.TLP1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP1.Controls.Add(Me._Friend, 0, 1)
        Me.TLP1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TLP1.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.TLP1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TLP1.Location = New System.Drawing.Point(0, 0)
        Me.TLP1.Name = "TLP1"
        Me.TLP1.RowCount = 3
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TLP1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TLP1.Size = New System.Drawing.Size(981, 634)
        Me.TLP1.TabIndex = 0
        '
        '_Friend
        '
        Me._Friend.BackColor = System.Drawing.Color.Transparent
        Me._Friend.Dock = System.Windows.Forms.DockStyle.Fill
        Me._Friend.Font = New System.Drawing.Font("MCS ALMAALIM", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me._Friend.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Friend.Location = New System.Drawing.Point(3, 158)
        Me._Friend.Name = "_Friend"
        Me._Friend.Size = New System.Drawing.Size(975, 126)
        Me._Friend.TabIndex = 1
        Me._Friend.Text = "اتصال بصديقك: (اسم)"
        Me._Friend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._Friend.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 7
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.66111!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33222!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33556!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00333!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.66111!))
        Me.TableLayoutPanel3.Controls.Add(Me.HW, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.D2, 5, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.HF, 3, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(975, 152)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'HW
        '
        Me.HW.BackgroundImage = Global.WhoWinMillion.My.Resources.Resources.Asset_4
        Me.HW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HW.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HW.Location = New System.Drawing.Point(719, 3)
        Me.HW.Name = "HW"
        Me.HW.Size = New System.Drawing.Size(189, 146)
        Me.HW.TabIndex = 0
        Me.HW.TabStop = False
        '
        'D2
        '
        Me.D2.BackgroundImage = Global.WhoWinMillion.My.Resources.Resources.Asset_2
        Me.D2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.D2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.D2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.D2.Location = New System.Drawing.Point(70, 3)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(189, 146)
        Me.D2.TabIndex = 2
        Me.D2.TabStop = False
        '
        'HF
        '
        Me.HF.BackgroundImage = Global.WhoWinMillion.My.Resources.Resources.Asset_3
        Me.HF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HF.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HF.Location = New System.Drawing.Point(395, 3)
        Me.HF.Name = "HF"
        Me.HF.Size = New System.Drawing.Size(189, 146)
        Me.HF.TabIndex = 1
        Me.HF.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackgroundImage = Global.WhoWinMillion.My.Resources.Resources.Asset_11
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Q, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 287)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.25683!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.74317!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(975, 344)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Q
        '
        Me.Q.BackColor = System.Drawing.Color.Transparent
        Me.Q.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Q.Font = New System.Drawing.Font("Al Moharib Classic Othman1", 20.0!)
        Me.Q.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Q.Location = New System.Drawing.Point(3, 0)
        Me.Q.Name = "Q"
        Me.Q.Size = New System.Drawing.Size(969, 141)
        Me.Q.TabIndex = 0
        Me.Q.Text = "السؤال"
        Me.Q.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.28956!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.42088!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.28956!))
        Me.TableLayoutPanel2.Controls.Add(Me.A2, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.A3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.A1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.A4, 2, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 144)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(969, 197)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'A2
        '
        Me.A2.BackColor = System.Drawing.Color.Transparent
        Me.A2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.A2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A2.Enabled = False
        Me.A2.Font = New System.Drawing.Font("Al Moharib Classic Othman1", 20.0!)
        Me.A2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.A2.Location = New System.Drawing.Point(3, 0)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(414, 108)
        Me.A2.TabIndex = 2
        Me.A2.Tag = "2"
        Me.A2.Text = "ب: إجابة"
        Me.A2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A3
        '
        Me.A3.BackColor = System.Drawing.Color.Transparent
        Me.A3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.A3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A3.Enabled = False
        Me.A3.Font = New System.Drawing.Font("Al Moharib Classic Othman1", 20.0!)
        Me.A3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.A3.Location = New System.Drawing.Point(553, 108)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(413, 89)
        Me.A3.TabIndex = 3
        Me.A3.Tag = "3"
        Me.A3.Text = "ج: إجابة"
        Me.A3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A1
        '
        Me.A1.BackColor = System.Drawing.Color.Transparent
        Me.A1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.A1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A1.Enabled = False
        Me.A1.Font = New System.Drawing.Font("Al Moharib Classic Othman1", 20.0!)
        Me.A1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.A1.Location = New System.Drawing.Point(553, 0)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(413, 108)
        Me.A1.TabIndex = 1
        Me.A1.Tag = "1"
        Me.A1.Text = "أ: إجابة"
        Me.A1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A4
        '
        Me.A4.BackColor = System.Drawing.Color.Transparent
        Me.A4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.A4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.A4.Enabled = False
        Me.A4.Font = New System.Drawing.Font("Al Moharib Classic Othman1", 20.0!)
        Me.A4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.A4.Location = New System.Drawing.Point(3, 108)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(414, 89)
        Me.A4.TabIndex = 4
        Me.A4.Tag = "4"
        Me.A4.Text = "د: إجابة"
        Me.A4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Qs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 634)
        Me.Controls.Add(Me.TLP1)
        Me.Name = "Qs"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الأسئلة"
        Me.TLP1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.HW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SoundPlayer As System.ComponentModel.BackgroundWorker
    Friend WithEvents TLP1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents HW As PictureBox
    Friend WithEvents D2 As PictureBox
    Friend WithEvents HF As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Q As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents A2 As Label
    Friend WithEvents A3 As Label
    Friend WithEvents A1 As Label
    Friend WithEvents A4 As Label
    Friend WithEvents _Friend As Label
End Class
