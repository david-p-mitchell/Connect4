<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
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
        Me.btncolumn1 = New System.Windows.Forms.Button()
        Me.btncolumn2 = New System.Windows.Forms.Button()
        Me.btncolumn3 = New System.Windows.Forms.Button()
        Me.btncolumn4 = New System.Windows.Forms.Button()
        Me.btncolumn5 = New System.Windows.Forms.Button()
        Me.btncolumn6 = New System.Windows.Forms.Button()
        Me.btncolumn7 = New System.Windows.Forms.Button()
        Me.dgvconnect = New System.Windows.Forms.DataGridView()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.dgvconnect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncolumn1
        '
        Me.btncolumn1.Location = New System.Drawing.Point(109, 12)
        Me.btncolumn1.Name = "btncolumn1"
        Me.btncolumn1.Size = New System.Drawing.Size(50, 37)
        Me.btncolumn1.TabIndex = 1
        Me.btncolumn1.Text = "This Column"
        Me.btncolumn1.UseVisualStyleBackColor = True
        '
        'btncolumn2
        '
        Me.btncolumn2.Location = New System.Drawing.Point(182, 12)
        Me.btncolumn2.Name = "btncolumn2"
        Me.btncolumn2.Size = New System.Drawing.Size(50, 37)
        Me.btncolumn2.TabIndex = 1
        Me.btncolumn2.Text = "This Column"
        Me.btncolumn2.UseVisualStyleBackColor = True
        '
        'btncolumn3
        '
        Me.btncolumn3.Location = New System.Drawing.Point(248, 12)
        Me.btncolumn3.Name = "btncolumn3"
        Me.btncolumn3.Size = New System.Drawing.Size(50, 37)
        Me.btncolumn3.TabIndex = 1
        Me.btncolumn3.Text = "This Column"
        Me.btncolumn3.UseVisualStyleBackColor = True
        '
        'btncolumn4
        '
        Me.btncolumn4.Location = New System.Drawing.Point(313, 12)
        Me.btncolumn4.Name = "btncolumn4"
        Me.btncolumn4.Size = New System.Drawing.Size(50, 37)
        Me.btncolumn4.TabIndex = 1
        Me.btncolumn4.Text = "This Column"
        Me.btncolumn4.UseVisualStyleBackColor = True
        '
        'btncolumn5
        '
        Me.btncolumn5.Location = New System.Drawing.Point(381, 12)
        Me.btncolumn5.Name = "btncolumn5"
        Me.btncolumn5.Size = New System.Drawing.Size(50, 37)
        Me.btncolumn5.TabIndex = 1
        Me.btncolumn5.Text = "This Column"
        Me.btncolumn5.UseVisualStyleBackColor = True
        '
        'btncolumn6
        '
        Me.btncolumn6.Location = New System.Drawing.Point(446, 12)
        Me.btncolumn6.Name = "btncolumn6"
        Me.btncolumn6.Size = New System.Drawing.Size(50, 37)
        Me.btncolumn6.TabIndex = 1
        Me.btncolumn6.Text = "This Column"
        Me.btncolumn6.UseVisualStyleBackColor = True
        '
        'btncolumn7
        '
        Me.btncolumn7.Location = New System.Drawing.Point(517, 12)
        Me.btncolumn7.Name = "btncolumn7"
        Me.btncolumn7.Size = New System.Drawing.Size(50, 37)
        Me.btncolumn7.TabIndex = 1
        Me.btncolumn7.Text = "This Column"
        Me.btncolumn7.UseVisualStyleBackColor = True
        '
        'dgvconnect
        '
        Me.dgvconnect.AllowUserToAddRows = False
        Me.dgvconnect.AllowUserToDeleteRows = False
        Me.dgvconnect.AllowUserToResizeColumns = False
        Me.dgvconnect.AllowUserToResizeRows = False
        Me.dgvconnect.BackgroundColor = System.Drawing.Color.White
        Me.dgvconnect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvconnect.ColumnHeadersVisible = False
        Me.dgvconnect.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvconnect.EnableHeadersVisualStyles = False
        Me.dgvconnect.Location = New System.Drawing.Point(109, 55)
        Me.dgvconnect.MultiSelect = False
        Me.dgvconnect.Name = "dgvconnect"
        Me.dgvconnect.ReadOnly = True
        Me.dgvconnect.RowHeadersVisible = False
        Me.dgvconnect.RowHeadersWidth = 18
        Me.dgvconnect.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvconnect.RowTemplate.Height = 50
        Me.dgvconnect.RowTemplate.ReadOnly = True
        Me.dgvconnect.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvconnect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgvconnect.ShowEditingIcon = False
        Me.dgvconnect.ShowRowErrors = False
        Me.dgvconnect.Size = New System.Drawing.Size(458, 355)
        Me.dgvconnect.TabIndex = 2
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Red
        Me.btnclose.Location = New System.Drawing.Point(640, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(46, 49)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 461)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.dgvconnect)
        Me.Controls.Add(Me.btncolumn7)
        Me.Controls.Add(Me.btncolumn6)
        Me.Controls.Add(Me.btncolumn4)
        Me.Controls.Add(Me.btncolumn2)
        Me.Controls.Add(Me.btncolumn5)
        Me.Controls.Add(Me.btncolumn3)
        Me.Controls.Add(Me.btncolumn1)
        Me.Name = "frmmain"
        Me.ShowInTaskbar = False
        Me.Text = "Connect 4"
        CType(Me.dgvconnect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btncolumn1 As System.Windows.Forms.Button
    Friend WithEvents btncolumn2 As System.Windows.Forms.Button
    Friend WithEvents btncolumn3 As System.Windows.Forms.Button
    Friend WithEvents btncolumn4 As System.Windows.Forms.Button
    Friend WithEvents btncolumn5 As System.Windows.Forms.Button
    Friend WithEvents btncolumn6 As System.Windows.Forms.Button
    Friend WithEvents btncolumn7 As System.Windows.Forms.Button
    Friend WithEvents dgvconnect As System.Windows.Forms.DataGridView
    Friend WithEvents btnclose As System.Windows.Forms.Button

End Class
