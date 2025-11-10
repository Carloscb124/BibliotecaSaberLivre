<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLivros
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
        Me.components = New System.ComponentModel.Container()
        Dim Patrimono_livrosLabel As System.Windows.Forms.Label
        Dim IsbnLabel As System.Windows.Forms.Label
        Dim TituloLabel As System.Windows.Forms.Label
        Dim AutorLabel As System.Windows.Forms.Label
        Dim EditoraLabel As System.Windows.Forms.Label
        Dim Ano_publicacaoLabel As System.Windows.Forms.Label
        Dim Status_acervoLabel As System.Windows.Forms.Label
        Dim ObservacaoLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
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
        Me.LivrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LivrosTableAdapter = New Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.LivrosTableAdapter()
        Me.TableAdapterManager = New Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager()
        Me.Patrimono_livrosTextBox = New System.Windows.Forms.TextBox()
        Me.IsbnTextBox = New System.Windows.Forms.TextBox()
        Me.TituloTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.EditoraTextBox = New System.Windows.Forms.TextBox()
        Me.Ano_publicacaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Status_acervoComboBox = New System.Windows.Forms.ComboBox()
        Me.ObservacaoTextBox = New System.Windows.Forms.TextBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Patrimono_livrosLabel = New System.Windows.Forms.Label()
        IsbnLabel = New System.Windows.Forms.Label()
        TituloLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        EditoraLabel = New System.Windows.Forms.Label()
        Ano_publicacaoLabel = New System.Windows.Forms.Label()
        Status_acervoLabel = New System.Windows.Forms.Label()
        ObservacaoLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DbBibiotecaAtual1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LivrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Patrimono_livrosLabel
        '
        Patrimono_livrosLabel.AutoSize = True
        Patrimono_livrosLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patrimono_livrosLabel.ForeColor = System.Drawing.Color.White
        Patrimono_livrosLabel.Location = New System.Drawing.Point(103, 94)
        Patrimono_livrosLabel.Name = "Patrimono_livrosLabel"
        Patrimono_livrosLabel.Size = New System.Drawing.Size(166, 22)
        Patrimono_livrosLabel.TabIndex = 2
        Patrimono_livrosLabel.Text = "Patrimônio Livros:"
        '
        'IsbnLabel
        '
        IsbnLabel.AutoSize = True
        IsbnLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IsbnLabel.ForeColor = System.Drawing.Color.White
        IsbnLabel.Location = New System.Drawing.Point(337, 94)
        IsbnLabel.Name = "IsbnLabel"
        IsbnLabel.Size = New System.Drawing.Size(54, 22)
        IsbnLabel.TabIndex = 4
        IsbnLabel.Text = "ISBN:"
        '
        'TituloLabel
        '
        TituloLabel.AutoSize = True
        TituloLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TituloLabel.ForeColor = System.Drawing.Color.White
        TituloLabel.Location = New System.Drawing.Point(103, 160)
        TituloLabel.Name = "TituloLabel"
        TituloLabel.Size = New System.Drawing.Size(60, 22)
        TituloLabel.TabIndex = 6
        TituloLabel.Text = "Titulo:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AutorLabel.ForeColor = System.Drawing.Color.White
        AutorLabel.Location = New System.Drawing.Point(337, 160)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(67, 22)
        AutorLabel.TabIndex = 8
        AutorLabel.Text = "Autor:"
        '
        'EditoraLabel
        '
        EditoraLabel.AutoSize = True
        EditoraLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EditoraLabel.ForeColor = System.Drawing.Color.White
        EditoraLabel.Location = New System.Drawing.Point(103, 218)
        EditoraLabel.Name = "EditoraLabel"
        EditoraLabel.Size = New System.Drawing.Size(79, 22)
        EditoraLabel.TabIndex = 10
        EditoraLabel.Text = "Editora:"
        '
        'Ano_publicacaoLabel
        '
        Ano_publicacaoLabel.AutoSize = True
        Ano_publicacaoLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ano_publicacaoLabel.ForeColor = System.Drawing.Color.White
        Ano_publicacaoLabel.Location = New System.Drawing.Point(337, 218)
        Ano_publicacaoLabel.Name = "Ano_publicacaoLabel"
        Ano_publicacaoLabel.Size = New System.Drawing.Size(163, 22)
        Ano_publicacaoLabel.TabIndex = 12
        Ano_publicacaoLabel.Text = "Ano Publicação:"
        '
        'Status_acervoLabel
        '
        Status_acervoLabel.AutoSize = True
        Status_acervoLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Status_acervoLabel.ForeColor = System.Drawing.Color.White
        Status_acervoLabel.Location = New System.Drawing.Point(103, 286)
        Status_acervoLabel.Name = "Status_acervoLabel"
        Status_acervoLabel.Size = New System.Drawing.Size(145, 22)
        Status_acervoLabel.TabIndex = 14
        Status_acervoLabel.Text = "Status Acervo:"
        '
        'ObservacaoLabel
        '
        ObservacaoLabel.AutoSize = True
        ObservacaoLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObservacaoLabel.ForeColor = System.Drawing.Color.White
        ObservacaoLabel.Location = New System.Drawing.Point(337, 286)
        ObservacaoLabel.Name = "ObservacaoLabel"
        ObservacaoLabel.Size = New System.Drawing.Size(133, 22)
        ObservacaoLabel.TabIndex = 16
        ObservacaoLabel.Text = "Observação:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.ForeColor = System.Drawing.Color.White
        StatusLabel.Location = New System.Drawing.Point(589, 94)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(70, 22)
        StatusLabel.TabIndex = 18
        StatusLabel.Text = "Status:"
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(784, 53)
        Me.Guna2Panel1.TabIndex = 1
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
        Me.btnLast.Location = New System.Drawing.Point(581, 5)
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
        Me.btnClose.Location = New System.Drawing.Point(741, 5)
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
        Me.btnNext.Location = New System.Drawing.Point(535, 5)
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
        Me.btnBack.Location = New System.Drawing.Point(499, 5)
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
        Me.btnFirst.Location = New System.Drawing.Point(453, 5)
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
        'LivrosBindingSource
        '
        Me.LivrosBindingSource.DataMember = "Livros"
        Me.LivrosBindingSource.DataSource = Me.DbBibiotecaAtual1DataSet
        '
        'LivrosTableAdapter
        '
        Me.LivrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmprestimosTableAdapter = Nothing
        Me.TableAdapterManager.LeitoresTableAdapter = Nothing
        Me.TableAdapterManager.LivrosTableAdapter = Me.LivrosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'Patrimono_livrosTextBox
        '
        Me.Patrimono_livrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivrosBindingSource, "patrimono_livros", True))
        Me.Patrimono_livrosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patrimono_livrosTextBox.Location = New System.Drawing.Point(107, 119)
        Me.Patrimono_livrosTextBox.Name = "Patrimono_livrosTextBox"
        Me.Patrimono_livrosTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Patrimono_livrosTextBox.TabIndex = 3
        '
        'IsbnTextBox
        '
        Me.IsbnTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivrosBindingSource, "isbn", True))
        Me.IsbnTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsbnTextBox.Location = New System.Drawing.Point(341, 119)
        Me.IsbnTextBox.Name = "IsbnTextBox"
        Me.IsbnTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IsbnTextBox.TabIndex = 5
        '
        'TituloTextBox
        '
        Me.TituloTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivrosBindingSource, "titulo", True))
        Me.TituloTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloTextBox.Location = New System.Drawing.Point(107, 185)
        Me.TituloTextBox.Name = "TituloTextBox"
        Me.TituloTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TituloTextBox.TabIndex = 7
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivrosBindingSource, "autor", True))
        Me.AutorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AutorTextBox.Location = New System.Drawing.Point(341, 185)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(200, 22)
        Me.AutorTextBox.TabIndex = 9
        '
        'EditoraTextBox
        '
        Me.EditoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivrosBindingSource, "editora", True))
        Me.EditoraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditoraTextBox.Location = New System.Drawing.Point(107, 243)
        Me.EditoraTextBox.Name = "EditoraTextBox"
        Me.EditoraTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EditoraTextBox.TabIndex = 11
        '
        'Ano_publicacaoDateTimePicker
        '
        Me.Ano_publicacaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LivrosBindingSource, "ano_publicacao", True))
        Me.Ano_publicacaoDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ano_publicacaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Ano_publicacaoDateTimePicker.Location = New System.Drawing.Point(341, 243)
        Me.Ano_publicacaoDateTimePicker.Name = "Ano_publicacaoDateTimePicker"
        Me.Ano_publicacaoDateTimePicker.Size = New System.Drawing.Size(106, 22)
        Me.Ano_publicacaoDateTimePicker.TabIndex = 13
        '
        'Status_acervoComboBox
        '
        Me.Status_acervoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivrosBindingSource, "status_acervo", True))
        Me.Status_acervoComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_acervoComboBox.FormattingEnabled = True
        Me.Status_acervoComboBox.Location = New System.Drawing.Point(107, 311)
        Me.Status_acervoComboBox.Name = "Status_acervoComboBox"
        Me.Status_acervoComboBox.Size = New System.Drawing.Size(200, 24)
        Me.Status_acervoComboBox.TabIndex = 15
        '
        'ObservacaoTextBox
        '
        Me.ObservacaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivrosBindingSource, "observacao", True))
        Me.ObservacaoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservacaoTextBox.Location = New System.Drawing.Point(341, 312)
        Me.ObservacaoTextBox.Name = "ObservacaoTextBox"
        Me.ObservacaoTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ObservacaoTextBox.TabIndex = 17
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LivrosBindingSource, "status", True))
        Me.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Location = New System.Drawing.Point(593, 119)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(151, 24)
        Me.StatusComboBox.TabIndex = 19
        '
        'frmLivros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(808, 450)
        Me.Controls.Add(Patrimono_livrosLabel)
        Me.Controls.Add(Me.Patrimono_livrosTextBox)
        Me.Controls.Add(IsbnLabel)
        Me.Controls.Add(Me.IsbnTextBox)
        Me.Controls.Add(TituloLabel)
        Me.Controls.Add(Me.TituloTextBox)
        Me.Controls.Add(AutorLabel)
        Me.Controls.Add(Me.AutorTextBox)
        Me.Controls.Add(EditoraLabel)
        Me.Controls.Add(Me.EditoraTextBox)
        Me.Controls.Add(Ano_publicacaoLabel)
        Me.Controls.Add(Me.Ano_publicacaoDateTimePicker)
        Me.Controls.Add(Status_acervoLabel)
        Me.Controls.Add(Me.Status_acervoComboBox)
        Me.Controls.Add(ObservacaoLabel)
        Me.Controls.Add(Me.ObservacaoTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLivros"
        Me.Text = "frmLivros"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.DbBibiotecaAtual1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LivrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnNew As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnLast As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnNext As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnBack As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnFirst As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSearch As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents DbBibiotecaAtual1DataSet As dbBibiotecaAtual1DataSet
    Friend WithEvents LivrosBindingSource As BindingSource
    Friend WithEvents LivrosTableAdapter As dbBibiotecaAtual1DataSetTableAdapters.LivrosTableAdapter
    Friend WithEvents TableAdapterManager As dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Patrimono_livrosTextBox As TextBox
    Friend WithEvents IsbnTextBox As TextBox
    Friend WithEvents TituloTextBox As TextBox
    Friend WithEvents AutorTextBox As TextBox
    Friend WithEvents EditoraTextBox As TextBox
    Friend WithEvents Ano_publicacaoDateTimePicker As DateTimePicker
    Friend WithEvents Status_acervoComboBox As ComboBox
    Friend WithEvents ObservacaoTextBox As TextBox
    Friend WithEvents StatusComboBox As ComboBox
End Class
