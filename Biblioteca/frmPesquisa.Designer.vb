<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPesquisa
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPesquisa))
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnBack = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEnd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnLimpar = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.lblTitle)
        Me.Guna2Panel2.Controls.Add(Me.btnBack)
        Me.Guna2Panel2.Controls.Add(Me.btnEnd)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(828, 35)
        Me.Guna2Panel2.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(0, 20)
        Me.lblTitle.TabIndex = 7
        '
        'btnBack
        '
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.Transparent
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnBack.Image = Global.Biblioteca.My.Resources.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnBack.Location = New System.Drawing.Point(788, 3)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(37, 29)
        Me.btnBack.TabIndex = 4
        '
        'btnEnd
        '
        Me.btnEnd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEnd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEnd.FillColor = System.Drawing.Color.Transparent
        Me.btnEnd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEnd.ForeColor = System.Drawing.Color.White
        Me.btnEnd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnEnd.Image = Global.Biblioteca.My.Resources.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnEnd.Location = New System.Drawing.Point(1067, 3)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(37, 29)
        Me.btnEnd.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.BorderRadius = 10
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.Location = New System.Drawing.Point(404, 66)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 36)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Buscar"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BorderRadius = 10
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(50, 66)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(330, 36)
        Me.Guna2TextBox1.TabIndex = 5
        '
        'btnLimpar
        '
        Me.btnLimpar.BorderRadius = 10
        Me.btnLimpar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLimpar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLimpar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLimpar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLimpar.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.White
        Me.btnLimpar.Location = New System.Drawing.Point(498, 66)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(88, 36)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "Limpar"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(727, 295)
        Me.DataGridView1.TabIndex = 7
        '
        'frmPesquisa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(828, 467)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPesquisa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPesquisa"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnEnd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLimpar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
