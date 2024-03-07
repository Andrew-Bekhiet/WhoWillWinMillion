<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MAinTLP = New System.Windows.Forms.TableLayoutPanel()
        Me.Quit = New System.Windows.Forms.Button()
        Me.About = New System.Windows.Forms.Button()
        Me.Start = New System.Windows.Forms.Button()
        Me.SounPlayer = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MAinTLP.SuspendLayout()
        Me.SuspendLayout()
        '
        'MAinTLP
        '
        Me.MAinTLP.ColumnCount = 1
        Me.MAinTLP.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.MAinTLP.Controls.Add(Me.Button1, 0, 1)
        Me.MAinTLP.Controls.Add(Me.Start, 0, 0)
        Me.MAinTLP.Controls.Add(Me.Quit, 0, 3)
        Me.MAinTLP.Controls.Add(Me.About, 0, 2)
        Me.MAinTLP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MAinTLP.Location = New System.Drawing.Point(0, 0)
        Me.MAinTLP.Name = "MAinTLP"
        Me.MAinTLP.RowCount = 4
        Me.MAinTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAinTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAinTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAinTLP.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.MAinTLP.Size = New System.Drawing.Size(364, 556)
        Me.MAinTLP.TabIndex = 0
        '
        'Quit
        '
        Me.Quit.BackColor = System.Drawing.Color.Salmon
        Me.Quit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Quit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Quit.FlatAppearance.BorderSize = 0
        Me.Quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Quit.Font = New System.Drawing.Font("Andalus", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Quit.Location = New System.Drawing.Point(3, 420)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(358, 133)
        Me.Quit.TabIndex = 3
        Me.Quit.Text = "خروج"
        Me.Quit.UseVisualStyleBackColor = False
        '
        'About
        '
        Me.About.BackColor = System.Drawing.Color.Gold
        Me.About.Dock = System.Windows.Forms.DockStyle.Fill
        Me.About.FlatAppearance.BorderSize = 0
        Me.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.About.Font = New System.Drawing.Font("Andalus", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.About.Location = New System.Drawing.Point(3, 281)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(358, 133)
        Me.About.TabIndex = 2
        Me.About.Text = "حول"
        Me.About.UseVisualStyleBackColor = False
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.Chartreuse
        Me.Start.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Start.FlatAppearance.BorderSize = 0
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start.Font = New System.Drawing.Font("Andalus", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Start.Location = New System.Drawing.Point(3, 3)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(358, 133)
        Me.Start.TabIndex = 0
        Me.Start.Text = "ابدأ"
        Me.Start.UseVisualStyleBackColor = False
        '
        'SounPlayer
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aquamarine
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Andalus", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(3, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(358, 133)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "تصميم جديد"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AcceptButton = Me.Start
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Quit
        Me.ClientSize = New System.Drawing.Size(364, 556)
        Me.Controls.Add(Me.MAinTLP)
        Me.Name = "Main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "القائمة الرئيسية"
        Me.MAinTLP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MAinTLP As TableLayoutPanel
    Friend WithEvents Quit As Button
    Friend WithEvents About As Button
    Friend WithEvents Start As Button
    Friend WithEvents SounPlayer As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
End Class
