<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Design
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
        Me.TLP = New System.Windows.Forms.TableLayoutPanel()
        Me.Tools = New System.Windows.Forms.ToolStrip()
        Me.Cancel = New System.Windows.Forms.ToolStripButton()
        Me.Save = New System.Windows.Forms.ToolStripButton()
        Me.Tools.SuspendLayout()
        Me.SuspendLayout()
        '
        'TLP
        '
        Me.TLP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TLP.AutoScroll = True
        Me.TLP.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TLP.ColumnCount = 1
        Me.TLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TLP.Location = New System.Drawing.Point(-1, 41)
        Me.TLP.Margin = New System.Windows.Forms.Padding(4)
        Me.TLP.Name = "TLP"
        Me.TLP.RowCount = 1
        Me.TLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TLP.Size = New System.Drawing.Size(724, 415)
        Me.TLP.TabIndex = 1
        '
        'Tools
        '
        Me.Tools.AutoSize = False
        Me.Tools.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cancel, Me.Save})
        Me.Tools.Location = New System.Drawing.Point(0, 0)
        Me.Tools.Name = "Tools"
        Me.Tools.Size = New System.Drawing.Size(723, 50)
        Me.Tools.TabIndex = 0
        Me.Tools.Text = "ToolStrip1"
        '
        'Cancel
        '
        Me.Cancel.AutoSize = False
        Me.Cancel.BackgroundImage = Global.WhoWinMillion.My.Resources.Resources.FontAwesome_f00d_0__512
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(47, 47)
        Me.Cancel.Text = "إلغاء"
        '
        'Save
        '
        Me.Save.AutoSize = False
        Me.Save.BackgroundImage = Global.WhoWinMillion.My.Resources.Resources.FontAwesome_f0c7_0__512
        Me.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(47, 47)
        Me.Save.Text = "حفظ"
        Me.Save.ToolTipText = "حفظ"
        '
        'Design
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(723, 454)
        Me.Controls.Add(Me.Tools)
        Me.Controls.Add(Me.TLP)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Design"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تصميم"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Tools.ResumeLayout(False)
        Me.Tools.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TLP As TableLayoutPanel
    Friend WithEvents Tools As ToolStrip
    Friend WithEvents Cancel As ToolStripButton
    Friend WithEvents Save As ToolStripButton
End Class
