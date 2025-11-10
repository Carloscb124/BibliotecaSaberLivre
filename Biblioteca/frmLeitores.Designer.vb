<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLeitores
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
        Dim Id_alunoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CpfLabel As System.Windows.Forms.Label
        Dim NascimentoLabel As System.Windows.Forms.Label
        Dim Status_sistemaLabel As System.Windows.Forms.Label
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
        Me.LeitoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LeitoresTableAdapter = New Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.LeitoresTableAdapter()
        Me.TableAdapterManager = New Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager()
        Me.Id_alunoTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.CpfTextBox = New System.Windows.Forms.TextBox()
        Me.NascimentoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Status_sistemaComboBox = New System.Windows.Forms.ComboBox()
        Id_alunoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CpfLabel = New System.Windows.Forms.Label()
        NascimentoLabel = New System.Windows.Forms.Label()
        Status_sistemaLabel = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DbBibiotecaAtual1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeitoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_alunoLabel
        '
        Id_alunoLabel.AutoSize = True
        Id_alunoLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_alunoLabel.ForeColor = System.Drawing.Color.White
        Id_alunoLabel.Location = New System.Drawing.Point(100, 104)
        Id_alunoLabel.Name = "Id_alunoLabel"
        Id_alunoLabel.Size = New System.Drawing.Size(90, 22)
        Id_alunoLabel.TabIndex = 3
        Id_alunoLabel.Text = "id Aluno:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.ForeColor = System.Drawing.Color.White
        NomeLabel.Location = New System.Drawing.Point(368, 104)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(70, 22)
        NomeLabel.TabIndex = 5
        NomeLabel.Text = "Nome:"
        '
        'CpfLabel
        '
        CpfLabel.AutoSize = True
        CpfLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CpfLabel.ForeColor = System.Drawing.Color.White
        CpfLabel.Location = New System.Drawing.Point(100, 190)
        CpfLabel.Name = "CpfLabel"
        CpfLabel.Size = New System.Drawing.Size(50, 22)
        CpfLabel.TabIndex = 7
        CpfLabel.Text = "CPF:"
        '
        'NascimentoLabel
        '
        NascimentoLabel.AutoSize = True
        NascimentoLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NascimentoLabel.ForeColor = System.Drawing.Color.White
        NascimentoLabel.Location = New System.Drawing.Point(368, 190)
        NascimentoLabel.Name = "NascimentoLabel"
        NascimentoLabel.Size = New System.Drawing.Size(124, 22)
        NascimentoLabel.TabIndex = 9
        NascimentoLabel.Text = "Nascimento:"
        '
        'Status_sistemaLabel
        '
        Status_sistemaLabel.AutoSize = True
        Status_sistemaLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Status_sistemaLabel.ForeColor = System.Drawing.Color.White
        Status_sistemaLabel.Location = New System.Drawing.Point(100, 299)
        Status_sistemaLabel.Name = "Status_sistemaLabel"
        Status_sistemaLabel.Size = New System.Drawing.Size(143, 22)
        Status_sistemaLabel.TabIndex = 11
        Status_sistemaLabel.Text = "Status Sistema:"
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
        Me.Guna2Panel1.Size = New System.Drawing.Size(800, 53)
        Me.Guna2Panel1.TabIndex = 2
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
        Me.btnLast.Location = New System.Drawing.Point(589, 5)
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
        Me.btnClose.Location = New System.Drawing.Point(757, 5)
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
        Me.btnNext.Location = New System.Drawing.Point(543, 5)
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
        Me.btnBack.Location = New System.Drawing.Point(507, 5)
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
        Me.btnFirst.Location = New System.Drawing.Point(461, 5)
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
        'LeitoresBindingSource
        '
        Me.LeitoresBindingSource.DataMember = "Leitores"
        Me.LeitoresBindingSource.DataSource = Me.DbBibiotecaAtual1DataSet
        '
        'LeitoresTableAdapter
        '
        Me.LeitoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmprestimosTableAdapter = Nothing
        Me.TableAdapterManager.LeitoresTableAdapter = Me.LeitoresTableAdapter
        Me.TableAdapterManager.LivrosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'Id_alunoTextBox
        '
        Me.Id_alunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LeitoresBindingSource, "id_aluno", True))
        Me.Id_alunoTextBox.Enabled = False
        Me.Id_alunoTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_alunoTextBox.Location = New System.Drawing.Point(103, 131)
        Me.Id_alunoTextBox.Name = "Id_alunoTextBox"
        Me.Id_alunoTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Id_alunoTextBox.TabIndex = 4
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LeitoresBindingSource, "nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(371, 131)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(200, 23)
        Me.NomeTextBox.TabIndex = 6
        '
        'CpfTextBox
        '
        Me.CpfTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LeitoresBindingSource, "cpf", True))
        Me.CpfTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpfTextBox.Location = New System.Drawing.Point(103, 220)
        Me.CpfTextBox.Name = "CpfTextBox"
        Me.CpfTextBox.Size = New System.Drawing.Size(200, 23)
        Me.CpfTextBox.TabIndex = 8
        '
        'NascimentoDateTimePicker
        '
        Me.NascimentoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.LeitoresBindingSource, "nascimento", True))
        Me.NascimentoDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.NascimentoDateTimePicker.Location = New System.Drawing.Point(371, 220)
        Me.NascimentoDateTimePicker.Name = "NascimentoDateTimePicker"
        Me.NascimentoDateTimePicker.Size = New System.Drawing.Size(121, 23)
        Me.NascimentoDateTimePicker.TabIndex = 10
        '
        'Status_sistemaComboBox
        '
        Me.Status_sistemaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LeitoresBindingSource, "status_sistema", True))
        Me.Status_sistemaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status_sistemaComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_sistemaComboBox.FormattingEnabled = True
        Me.Status_sistemaComboBox.Location = New System.Drawing.Point(104, 324)
        Me.Status_sistemaComboBox.Name = "Status_sistemaComboBox"
        Me.Status_sistemaComboBox.Size = New System.Drawing.Size(121, 25)
        Me.Status_sistemaComboBox.TabIndex = 15
        '
        'frmLeitores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 450)
        Me.Controls.Add(Me.Status_sistemaComboBox)
        Me.Controls.Add(Id_alunoLabel)
        Me.Controls.Add(Me.Id_alunoTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CpfLabel)
        Me.Controls.Add(Me.CpfTextBox)
        Me.Controls.Add(NascimentoLabel)
        Me.Controls.Add(Me.NascimentoDateTimePicker)
        Me.Controls.Add(Status_sistemaLabel)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmLeitores"
        Me.Text = "frmLeitores"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.DbBibiotecaAtual1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeitoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LeitoresBindingSource As BindingSource
    Friend WithEvents LeitoresTableAdapter As dbBibiotecaAtual1DataSetTableAdapters.LeitoresTableAdapter
    Friend WithEvents TableAdapterManager As dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_alunoTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents CpfTextBox As TextBox
    Friend WithEvents NascimentoDateTimePicker As DateTimePicker
    Friend WithEvents Status_sistemaComboBox As ComboBox
End Class
