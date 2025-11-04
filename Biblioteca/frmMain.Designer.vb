<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnUser = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnLogOut = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnLoan = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnLeitores = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnBook = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMenu = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaximize = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEnd = New Guna.UI2.WinForms.Guna2Button()
        Me.titleLabel = New System.Windows.Forms.Label()
        Me.PanelContainer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.Controls.Add(Me.btnUser)
        Me.Guna2Panel1.Controls.Add(Me.btnLogOut)
        Me.Guna2Panel1.Controls.Add(Me.btnLoan)
        Me.Guna2Panel1.Controls.Add(Me.btnLeitores)
        Me.Guna2Panel1.Controls.Add(Me.btnBook)
        Me.Guna2Panel1.Controls.Add(Me.PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.btnMenu)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(207, 714)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnUser
        '
        Me.btnUser.BackColor = System.Drawing.Color.Transparent
        Me.btnUser.BorderRadius = 10
        Me.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUser.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUser.FillColor = System.Drawing.Color.Transparent
        Me.btnUser.FillColor2 = System.Drawing.Color.Transparent
        Me.btnUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnUser.Image = Global.Biblioteca.My.Resources.Resources.account_box_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnUser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUser.Location = New System.Drawing.Point(17, 152)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(180, 36)
        Me.btnUser.TabIndex = 9
        Me.btnUser.Text = "Usuários"
        '
        'btnLogOut
        '
        Me.btnLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogOut.BackColor = System.Drawing.Color.Transparent
        Me.btnLogOut.BorderRadius = 10
        Me.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogOut.FillColor = System.Drawing.Color.Transparent
        Me.btnLogOut.FillColor2 = System.Drawing.Color.Transparent
        Me.btnLogOut.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnLogOut.Image = Global.Biblioteca.My.Resources.Resources.logout_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogOut.Location = New System.Drawing.Point(20, 663)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(180, 36)
        Me.btnLogOut.TabIndex = 8
        Me.btnLogOut.Text = "LogOut"
        '
        'btnLoan
        '
        Me.btnLoan.BackColor = System.Drawing.Color.Transparent
        Me.btnLoan.BorderRadius = 10
        Me.btnLoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLoan.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLoan.FillColor = System.Drawing.Color.Transparent
        Me.btnLoan.FillColor2 = System.Drawing.Color.Transparent
        Me.btnLoan.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.ForeColor = System.Drawing.Color.White
        Me.btnLoan.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnLoan.Image = Global.Biblioteca.My.Resources.Resources.bookmark_manager_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnLoan.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLoan.Location = New System.Drawing.Point(20, 350)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(180, 36)
        Me.btnLoan.TabIndex = 7
        Me.btnLoan.Text = "Emprestimos"
        '
        'btnLeitores
        '
        Me.btnLeitores.BackColor = System.Drawing.Color.Transparent
        Me.btnLeitores.BorderRadius = 10
        Me.btnLeitores.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLeitores.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLeitores.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLeitores.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLeitores.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLeitores.FillColor = System.Drawing.Color.Transparent
        Me.btnLeitores.FillColor2 = System.Drawing.Color.Transparent
        Me.btnLeitores.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeitores.ForeColor = System.Drawing.Color.White
        Me.btnLeitores.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnLeitores.Image = Global.Biblioteca.My.Resources.Resources.local_library_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnLeitores.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLeitores.Location = New System.Drawing.Point(20, 292)
        Me.btnLeitores.Name = "btnLeitores"
        Me.btnLeitores.Size = New System.Drawing.Size(180, 36)
        Me.btnLeitores.TabIndex = 4
        Me.btnLeitores.Text = "Leitores"
        '
        'btnBook
        '
        Me.btnBook.BackColor = System.Drawing.Color.Transparent
        Me.btnBook.BorderRadius = 10
        Me.btnBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBook.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBook.FillColor = System.Drawing.Color.Transparent
        Me.btnBook.FillColor2 = System.Drawing.Color.Transparent
        Me.btnBook.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBook.ForeColor = System.Drawing.Color.White
        Me.btnBook.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnBook.Image = Global.Biblioteca.My.Resources.Resources.book_5_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnBook.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBook.Location = New System.Drawing.Point(20, 227)
        Me.btnBook.Name = "btnBook"
        Me.btnBook.Size = New System.Drawing.Size(180, 36)
        Me.btnBook.TabIndex = 3
        Me.btnBook.Text = "Livros"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Biblioteca.My.Resources.Resources.open_book__1_
        Me.PictureBox1.Location = New System.Drawing.Point(20, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(74, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Saber Livre"
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.BorderRadius = 10
        Me.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMenu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMenu.FillColor = System.Drawing.Color.Transparent
        Me.btnMenu.FillColor2 = System.Drawing.Color.Transparent
        Me.btnMenu.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenu.ForeColor = System.Drawing.Color.White
        Me.btnMenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnMenu.Image = Global.Biblioteca.My.Resources.Resources.menu_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnMenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnMenu.Location = New System.Drawing.Point(20, 88)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(180, 36)
        Me.btnMenu.TabIndex = 10
        Me.btnMenu.Text = "Menu"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.Controls.Add(Me.btnMinimize)
        Me.Guna2Panel2.Controls.Add(Me.btnMaximize)
        Me.Guna2Panel2.Controls.Add(Me.btnEnd)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1107, 35)
        Me.Guna2Panel2.TabIndex = 2
        '
        'btnMinimize
        '
        Me.btnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMinimize.FillColor = System.Drawing.Color.Transparent
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMinimize.Image = Global.Biblioteca.My.Resources.Resources.remove_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnMinimize.Location = New System.Drawing.Point(982, 3)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(37, 29)
        Me.btnMinimize.TabIndex = 3
        '
        'btnMaximize
        '
        Me.btnMaximize.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMaximize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMaximize.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMaximize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMaximize.FillColor = System.Drawing.Color.Transparent
        Me.btnMaximize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMaximize.ForeColor = System.Drawing.Color.White
        Me.btnMaximize.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnMaximize.Image = Global.Biblioteca.My.Resources.Resources.maximize
        Me.btnMaximize.Location = New System.Drawing.Point(1025, 3)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(37, 29)
        Me.btnMaximize.TabIndex = 2
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
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.titleLabel.Location = New System.Drawing.Point(246, 44)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(0, 19)
        Me.titleLabel.TabIndex = 3
        '
        'PanelContainer
        '
        Me.PanelContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelContainer.BackColor = System.Drawing.Color.Transparent
        Me.PanelContainer.BorderRadius = 10
        Me.PanelContainer.Location = New System.Drawing.Point(250, 73)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(812, 638)
        Me.PanelContainer.TabIndex = 4
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.BackgroundImage = Global.Biblioteca.My.Resources.Resources.Studying_bro
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1107, 738)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.titleLabel)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLeitores As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBook As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnLoan As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnLogOut As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnEnd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents titleLabel As Label
    Friend WithEvents PanelContainer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnUser As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnMenu As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaximize As Guna.UI2.WinForms.Guna2Button
End Class
