<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpWatchers
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpWatchers))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.A4L = New System.Windows.Forms.Label()
        Me.A3L = New System.Windows.Forms.Label()
        Me.A2L = New System.Windows.Forms.Label()
        Me.A4 = New System.Windows.Forms.PictureBox()
        Me.A3 = New System.Windows.Forms.PictureBox()
        Me.A2 = New System.Windows.Forms.PictureBox()
        Me.A1 = New System.Windows.Forms.PictureBox()
        Me.A1L = New System.Windows.Forms.Label()
        Me.A1P = New System.Windows.Forms.Label()
        Me.A2P = New System.Windows.Forms.Label()
        Me.A3P = New System.Windows.Forms.Label()
        Me.A4P = New System.Windows.Forms.Label()
        Me.Up = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.A4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.A4L, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A3L, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A2L, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A4, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.A1L, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.A1P, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.A2P, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.A3P, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.A4P, 3, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(408, 634)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'A4L
        '
        Me.A4L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.A4L.AutoSize = True
        Me.A4L.Font = New System.Drawing.Font("Alawi Arafat", 17.0!)
        Me.A4L.Location = New System.Drawing.Point(4, 588)
        Me.A4L.Name = "A4L"
        Me.A4L.Size = New System.Drawing.Size(97, 45)
        Me.A4L.TabIndex = 7
        Me.A4L.Text = "الإجابة د"
        Me.A4L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A3L
        '
        Me.A3L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.A3L.AutoSize = True
        Me.A3L.Font = New System.Drawing.Font("Alawi Arafat", 17.0!)
        Me.A3L.Location = New System.Drawing.Point(108, 588)
        Me.A3L.Name = "A3L"
        Me.A3L.Size = New System.Drawing.Size(94, 45)
        Me.A3L.TabIndex = 6
        Me.A3L.Text = "الإجابة ج"
        Me.A3L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A2L
        '
        Me.A2L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.A2L.AutoSize = True
        Me.A2L.Font = New System.Drawing.Font("Alawi Arafat", 15.0!)
        Me.A2L.Location = New System.Drawing.Point(209, 588)
        Me.A2L.Name = "A2L"
        Me.A2L.Size = New System.Drawing.Size(94, 45)
        Me.A2L.TabIndex = 5
        Me.A2L.Text = "الإجابة ب"
        '
        'A4
        '
        Me.A4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.A4.BackgroundImage = CType(resources.GetObject("A4.BackgroundImage"), System.Drawing.Image)
        Me.A4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.A4.Location = New System.Drawing.Point(29, 584)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(48, 0)
        Me.A4.TabIndex = 3
        Me.A4.TabStop = False
        '
        'A3
        '
        Me.A3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.A3.BackgroundImage = CType(resources.GetObject("A3.BackgroundImage"), System.Drawing.Image)
        Me.A3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.A3.Location = New System.Drawing.Point(131, 584)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(48, 0)
        Me.A3.TabIndex = 2
        Me.A3.TabStop = False
        '
        'A2
        '
        Me.A2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.A2.BackgroundImage = CType(resources.GetObject("A2.BackgroundImage"), System.Drawing.Image)
        Me.A2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.A2.Location = New System.Drawing.Point(232, 584)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(48, 0)
        Me.A2.TabIndex = 1
        Me.A2.TabStop = False
        '
        'A1
        '
        Me.A1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.A1.BackgroundImage = Global.WhoWinMillion.My.Resources.Resources.WP
        Me.A1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.A1.Location = New System.Drawing.Point(333, 584)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(48, 0)
        Me.A1.TabIndex = 0
        Me.A1.TabStop = False
        '
        'A1L
        '
        Me.A1L.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.A1L.AutoSize = True
        Me.A1L.Font = New System.Drawing.Font("Alawi Arafat", 17.0!)
        Me.A1L.Location = New System.Drawing.Point(310, 588)
        Me.A1L.Name = "A1L"
        Me.A1L.Size = New System.Drawing.Size(94, 45)
        Me.A1L.TabIndex = 4
        Me.A1L.Text = "الإجابة أ"
        Me.A1L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A1P
        '
        Me.A1P.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.A1P.AutoSize = True
        Me.A1P.Font = New System.Drawing.Font("Alawi Arafat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.A1P.Location = New System.Drawing.Point(310, 1)
        Me.A1P.Name = "A1P"
        Me.A1P.Size = New System.Drawing.Size(94, 44)
        Me.A1P.TabIndex = 4
        Me.A1P.Text = "0%"
        Me.A1P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A2P
        '
        Me.A2P.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.A2P.AutoSize = True
        Me.A2P.Font = New System.Drawing.Font("Alawi Arafat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.A2P.Location = New System.Drawing.Point(209, 1)
        Me.A2P.Name = "A2P"
        Me.A2P.Size = New System.Drawing.Size(94, 44)
        Me.A2P.TabIndex = 5
        Me.A2P.Text = "0%"
        Me.A2P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A3P
        '
        Me.A3P.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.A3P.AutoSize = True
        Me.A3P.Font = New System.Drawing.Font("Alawi Arafat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.A3P.Location = New System.Drawing.Point(108, 1)
        Me.A3P.Name = "A3P"
        Me.A3P.Size = New System.Drawing.Size(94, 44)
        Me.A3P.TabIndex = 6
        Me.A3P.Text = "0%"
        Me.A3P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A4P
        '
        Me.A4P.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.A4P.AutoSize = True
        Me.A4P.Font = New System.Drawing.Font("Alawi Arafat", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.A4P.Location = New System.Drawing.Point(4, 1)
        Me.A4P.Name = "A4P"
        Me.A4P.Size = New System.Drawing.Size(97, 44)
        Me.A4P.TabIndex = 7
        Me.A4P.Text = "0%"
        Me.A4P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Up
        '
        Me.Up.Enabled = True
        Me.Up.Interval = 10
        '
        'HelpWatchers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 634)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HelpWatchers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "مساعدة الجمهور"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.A4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents A4 As PictureBox
    Friend WithEvents A3 As PictureBox
    Friend WithEvents A2 As PictureBox
    Friend WithEvents A1 As PictureBox
    Friend WithEvents A1L As Label
    Friend WithEvents A4L As Label
    Friend WithEvents A3L As Label
    Friend WithEvents A2L As Label
    Friend WithEvents A1P As Label
    Friend WithEvents A2P As Label
    Friend WithEvents A3P As Label
    Friend WithEvents A4P As Label
    Friend WithEvents Up As Timer
End Class
