<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUser
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
        Me.components = New System.ComponentModel.Container()
        Dim Id_usuarioLabel As System.Windows.Forms.Label
        Dim Nome_usuarioLabel As System.Windows.Forms.Label
        Dim Senha_usuarioLabel As System.Windows.Forms.Label
        Dim Status_usuarioLabel As System.Windows.Forms.Label
        Dim Nivel_usuarioLabel As System.Windows.Forms.Label
        Dim Login_usuarioLabel As System.Windows.Forms.Label
        Dim Cpf_usuarioLabel As System.Windows.Forms.Label
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnNew = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnLast = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnClose = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnNext = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnBack = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnFirst = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSearch = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.btnSave = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.DbBibiotecaAtual1DataSet = New Biblioteca.dbBibiotecaAtual1DataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager()
        Me.Id_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Senha_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Nivel_usuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.Login_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Cpf_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Status_usuarioComboBox = New System.Windows.Forms.ComboBox()
        Id_usuarioLabel = New System.Windows.Forms.Label()
        Nome_usuarioLabel = New System.Windows.Forms.Label()
        Senha_usuarioLabel = New System.Windows.Forms.Label()
        Status_usuarioLabel = New System.Windows.Forms.Label()
        Nivel_usuarioLabel = New System.Windows.Forms.Label()
        Login_usuarioLabel = New System.Windows.Forms.Label()
        Cpf_usuarioLabel = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DbBibiotecaAtual1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_usuarioLabel
        '
        Id_usuarioLabel.AutoSize = True
        Id_usuarioLabel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_usuarioLabel.ForeColor = System.Drawing.Color.White
        Id_usuarioLabel.Location = New System.Drawing.Point(79, 121)
        Id_usuarioLabel.Name = "Id_usuarioLabel"
        Id_usuarioLabel.Size = New System.Drawing.Size(109, 24)
        Id_usuarioLabel.TabIndex = 2
        Id_usuarioLabel.Text = "id Usuário:"
        '
        'Nome_usuarioLabel
        '
        Nome_usuarioLabel.AutoSize = True
        Nome_usuarioLabel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_usuarioLabel.ForeColor = System.Drawing.Color.White
        Nome_usuarioLabel.Location = New System.Drawing.Point(318, 120)
        Nome_usuarioLabel.Name = "Nome_usuarioLabel"
        Nome_usuarioLabel.Size = New System.Drawing.Size(157, 24)
        Nome_usuarioLabel.TabIndex = 4
        Nome_usuarioLabel.Text = "Nome Usuário:"
        '
        'Senha_usuarioLabel
        '
        Senha_usuarioLabel.AutoSize = True
        Senha_usuarioLabel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Senha_usuarioLabel.ForeColor = System.Drawing.Color.White
        Senha_usuarioLabel.Location = New System.Drawing.Point(562, 120)
        Senha_usuarioLabel.Name = "Senha_usuarioLabel"
        Senha_usuarioLabel.Size = New System.Drawing.Size(156, 24)
        Senha_usuarioLabel.TabIndex = 6
        Senha_usuarioLabel.Text = "Senha Usuário:"
        '
        'Status_usuarioLabel
        '
        Status_usuarioLabel.AutoSize = True
        Status_usuarioLabel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Status_usuarioLabel.ForeColor = System.Drawing.Color.White
        Status_usuarioLabel.Location = New System.Drawing.Point(79, 243)
        Status_usuarioLabel.Name = "Status_usuarioLabel"
        Status_usuarioLabel.Size = New System.Drawing.Size(151, 24)
        Status_usuarioLabel.TabIndex = 8
        Status_usuarioLabel.Text = "Status Usuário:"
        '
        'Nivel_usuarioLabel
        '
        Nivel_usuarioLabel.AutoSize = True
        Nivel_usuarioLabel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nivel_usuarioLabel.ForeColor = System.Drawing.Color.White
        Nivel_usuarioLabel.Location = New System.Drawing.Point(318, 243)
        Nivel_usuarioLabel.Name = "Nivel_usuarioLabel"
        Nivel_usuarioLabel.Size = New System.Drawing.Size(143, 24)
        Nivel_usuarioLabel.TabIndex = 10
        Nivel_usuarioLabel.Text = "Nivel Usuário:"
        '
        'Login_usuarioLabel
        '
        Login_usuarioLabel.AutoSize = True
        Login_usuarioLabel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Login_usuarioLabel.ForeColor = System.Drawing.Color.White
        Login_usuarioLabel.Location = New System.Drawing.Point(562, 243)
        Login_usuarioLabel.Name = "Login_usuarioLabel"
        Login_usuarioLabel.Size = New System.Drawing.Size(146, 24)
        Login_usuarioLabel.TabIndex = 12
        Login_usuarioLabel.Text = "Login Usuário:"
        '
        'Cpf_usuarioLabel
        '
        Cpf_usuarioLabel.AutoSize = True
        Cpf_usuarioLabel.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cpf_usuarioLabel.ForeColor = System.Drawing.Color.White
        Cpf_usuarioLabel.Location = New System.Drawing.Point(79, 342)
        Cpf_usuarioLabel.Name = "Cpf_usuarioLabel"
        Cpf_usuarioLabel.Size = New System.Drawing.Size(131, 24)
        Cpf_usuarioLabel.TabIndex = 14
        Cpf_usuarioLabel.Text = "CPF Usuário:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 20
        Me.Guna2Panel1.Controls.Add(Me.btnNew)
        Me.Guna2Panel1.Controls.Add(Me.btnLast)
        Me.Guna2Panel1.Controls.Add(Me.btnClose)
        Me.Guna2Panel1.Controls.Add(Me.btnNext)
        Me.Guna2Panel1.Controls.Add(Me.btnBack)
        Me.Guna2Panel1.Controls.Add(Me.btnFirst)
        Me.Guna2Panel1.Controls.Add(Me.btnSearch)
        Me.Guna2Panel1.Controls.Add(Me.btnSave)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(792, 53)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.BorderRadius = 10
        Me.btnNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNew.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNew.FillColor = System.Drawing.Color.Transparent
        Me.btnNew.FillColor2 = System.Drawing.Color.Transparent
        Me.btnNew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNew.ForeColor = System.Drawing.Color.White
        Me.btnNew.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnNew.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNew.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnNew.Image = Global.Biblioteca.My.Resources.Resources.add_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnNew.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnNew.Location = New System.Drawing.Point(235, 5)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(120, 45)
        Me.btnNew.TabIndex = 8
        Me.btnNew.Text = "Adicionar"
        '
        'btnLast
        '
        Me.btnLast.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnLast.BackColor = System.Drawing.Color.Transparent
        Me.btnLast.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLast.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLast.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLast.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLast.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLast.FillColor = System.Drawing.Color.Transparent
        Me.btnLast.FillColor2 = System.Drawing.Color.Transparent
        Me.btnLast.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLast.ForeColor = System.Drawing.Color.White
        Me.btnLast.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnLast.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnLast.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnLast.Image = Global.Biblioteca.My.Resources.Resources.keyboard_double_arrow_right_29dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnLast.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLast.Location = New System.Drawing.Point(585, 5)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(40, 40)
        Me.btnLast.TabIndex = 6
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnClose.FillColor = System.Drawing.Color.Transparent
        Me.btnClose.FillColor2 = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClose.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnClose.Image = Global.Biblioteca.My.Resources.Resources.reply_29dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnClose.Location = New System.Drawing.Point(749, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 40)
        Me.btnClose.TabIndex = 7
        '
        'btnNext
        '
        Me.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNext.FillColor = System.Drawing.Color.Transparent
        Me.btnNext.FillColor2 = System.Drawing.Color.Transparent
        Me.btnNext.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnNext.ForeColor = System.Drawing.Color.White
        Me.btnNext.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnNext.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnNext.Image = Global.Biblioteca.My.Resources.Resources.keyboard_arrow_right_29dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnNext.Location = New System.Drawing.Point(539, 5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(40, 40)
        Me.btnNext.TabIndex = 3
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBack.FillColor = System.Drawing.Color.Transparent
        Me.btnBack.FillColor2 = System.Drawing.Color.Transparent
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnBack.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnBack.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnBack.Image = Global.Biblioteca.My.Resources.Resources.keyboard_arrow_left_29dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBack.Location = New System.Drawing.Point(503, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(40, 40)
        Me.btnBack.TabIndex = 4
        '
        'btnFirst
        '
        Me.btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnFirst.BackColor = System.Drawing.Color.Transparent
        Me.btnFirst.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFirst.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFirst.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFirst.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFirst.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFirst.FillColor = System.Drawing.Color.Transparent
        Me.btnFirst.FillColor2 = System.Drawing.Color.Transparent
        Me.btnFirst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnFirst.ForeColor = System.Drawing.Color.White
        Me.btnFirst.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnFirst.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnFirst.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnFirst.Image = Global.Biblioteca.My.Resources.Resources.keyboard_double_arrow_left_29dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnFirst.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnFirst.Location = New System.Drawing.Point(457, 5)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(40, 40)
        Me.btnFirst.TabIndex = 2
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BorderRadius = 10
        Me.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSearch.FillColor = System.Drawing.Color.Transparent
        Me.btnSearch.FillColor2 = System.Drawing.Color.Transparent
        Me.btnSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSearch.ForeColor = System.Drawing.Color.White
        Me.btnSearch.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSearch.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSearch.Image = Global.Biblioteca.My.Resources.Resources.search_29dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSearch.Location = New System.Drawing.Point(109, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(120, 45)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Pesquisar"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderRadius = 10
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.Transparent
        Me.btnSave.FillColor2 = System.Drawing.Color.Transparent
        Me.btnSave.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSave.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnSave.Image = Global.Biblioteca.My.Resources.Resources.save_29dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSave.Location = New System.Drawing.Point(3, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 45)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Salvar"
        '
        'DbBibiotecaAtual1DataSet
        '
        Me.DbBibiotecaAtual1DataSet.DataSetName = "dbBibiotecaAtual1DataSet"
        Me.DbBibiotecaAtual1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuarioBindingSource
        '
        Me.UsuarioBindingSource.DataMember = "Usuario"
        Me.UsuarioBindingSource.DataSource = Me.DbBibiotecaAtual1DataSet
        '
        'UsuarioTableAdapter
        '
        Me.UsuarioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmprestimosTableAdapter = Nothing
        Me.TableAdapterManager.LeitoresTableAdapter = Nothing
        Me.TableAdapterManager.LivrosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Me.UsuarioTableAdapter
        '
        'Id_usuarioTextBox
        '
        Me.Id_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "id_usuario", True))
        Me.Id_usuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_usuarioTextBox.Location = New System.Drawing.Point(96, 156)
        Me.Id_usuarioTextBox.Name = "Id_usuarioTextBox"
        Me.Id_usuarioTextBox.ReadOnly = True
        Me.Id_usuarioTextBox.Size = New System.Drawing.Size(129, 22)
        Me.Id_usuarioTextBox.TabIndex = 3
        '
        'Nome_usuarioTextBox
        '
        Me.Nome_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Nome_usuario", True))
        Me.Nome_usuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_usuarioTextBox.Location = New System.Drawing.Point(324, 156)
        Me.Nome_usuarioTextBox.Name = "Nome_usuarioTextBox"
        Me.Nome_usuarioTextBox.Size = New System.Drawing.Size(207, 22)
        Me.Nome_usuarioTextBox.TabIndex = 5
        '
        'Senha_usuarioTextBox
        '
        Me.Senha_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Senha_usuario", True))
        Me.Senha_usuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Senha_usuarioTextBox.Location = New System.Drawing.Point(568, 156)
        Me.Senha_usuarioTextBox.Name = "Senha_usuarioTextBox"
        Me.Senha_usuarioTextBox.Size = New System.Drawing.Size(185, 22)
        Me.Senha_usuarioTextBox.TabIndex = 7
        Me.Senha_usuarioTextBox.UseSystemPasswordChar = True
        '
        'Nivel_usuarioComboBox
        '
        Me.Nivel_usuarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Nivel_usuario", True))
        Me.Nivel_usuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nivel_usuarioComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nivel_usuarioComboBox.FormattingEnabled = True
        Me.Nivel_usuarioComboBox.Items.AddRange(New Object() {"Administrador", "Bibliotecario"})
        Me.Nivel_usuarioComboBox.Location = New System.Drawing.Point(323, 281)
        Me.Nivel_usuarioComboBox.Name = "Nivel_usuarioComboBox"
        Me.Nivel_usuarioComboBox.Size = New System.Drawing.Size(182, 24)
        Me.Nivel_usuarioComboBox.TabIndex = 11
        '
        'Login_usuarioTextBox
        '
        Me.Login_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Login_usuario", True))
        Me.Login_usuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_usuarioTextBox.Location = New System.Drawing.Point(568, 281)
        Me.Login_usuarioTextBox.Name = "Login_usuarioTextBox"
        Me.Login_usuarioTextBox.Size = New System.Drawing.Size(185, 22)
        Me.Login_usuarioTextBox.TabIndex = 13
        '
        'Cpf_usuarioTextBox
        '
        Me.Cpf_usuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Cpf_usuario", True))
        Me.Cpf_usuarioTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cpf_usuarioTextBox.Location = New System.Drawing.Point(96, 378)
        Me.Cpf_usuarioTextBox.Name = "Cpf_usuarioTextBox"
        Me.Cpf_usuarioTextBox.Size = New System.Drawing.Size(181, 23)
        Me.Cpf_usuarioTextBox.TabIndex = 15
        '
        'Status_usuarioComboBox
        '
        Me.Status_usuarioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuarioBindingSource, "Status_usuario", True))
        Me.Status_usuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status_usuarioComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_usuarioComboBox.FormattingEnabled = True
        Me.Status_usuarioComboBox.Items.AddRange(New Object() {"Ativo", "Desativado"})
        Me.Status_usuarioComboBox.Location = New System.Drawing.Point(96, 281)
        Me.Status_usuarioComboBox.Name = "Status_usuarioComboBox"
        Me.Status_usuarioComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Status_usuarioComboBox.TabIndex = 16
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(816, 450)
        Me.Controls.Add(Me.Status_usuarioComboBox)
        Me.Controls.Add(Id_usuarioLabel)
        Me.Controls.Add(Me.Id_usuarioTextBox)
        Me.Controls.Add(Nome_usuarioLabel)
        Me.Controls.Add(Me.Nome_usuarioTextBox)
        Me.Controls.Add(Senha_usuarioLabel)
        Me.Controls.Add(Me.Senha_usuarioTextBox)
        Me.Controls.Add(Status_usuarioLabel)
        Me.Controls.Add(Nivel_usuarioLabel)
        Me.Controls.Add(Me.Nivel_usuarioComboBox)
        Me.Controls.Add(Login_usuarioLabel)
        Me.Controls.Add(Me.Login_usuarioTextBox)
        Me.Controls.Add(Cpf_usuarioLabel)
        Me.Controls.Add(Me.Cpf_usuarioTextBox)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUser"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.DbBibiotecaAtual1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFirst As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnLast As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnNew As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DbBibiotecaAtual1DataSet As dbBibiotecaAtual1DataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As dbBibiotecaAtual1DataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_usuarioTextBox As TextBox
    Friend WithEvents Nome_usuarioTextBox As TextBox
    Friend WithEvents Senha_usuarioTextBox As TextBox
    Friend WithEvents Nivel_usuarioComboBox As ComboBox
    Friend WithEvents Login_usuarioTextBox As TextBox
    Friend WithEvents Cpf_usuarioTextBox As TextBox
    Friend WithEvents Status_usuarioComboBox As ComboBox
End Class
