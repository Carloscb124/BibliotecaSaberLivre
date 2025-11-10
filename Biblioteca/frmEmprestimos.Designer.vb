<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmprestimos
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
        Dim Id_emprestimoLabel As System.Windows.Forms.Label
        Dim Id_alunoLabel As System.Windows.Forms.Label
        Dim Patrimonio_livroLabel As System.Windows.Forms.Label
        Dim Data_emprestimoLabel As System.Windows.Forms.Label
        Dim Data_prevista_devolucaoLabel As System.Windows.Forms.Label
        Dim Data_devolucao_realLabel As System.Windows.Forms.Label
        Dim Status_devolucaoLabel As System.Windows.Forms.Label
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
        Me.EmprestimosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmprestimosTableAdapter = New Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.EmprestimosTableAdapter()
        Me.TableAdapterManager = New Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager()
        Me.Id_emprestimoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_alunoTextBox = New System.Windows.Forms.TextBox()
        Me.Patrimonio_livroTextBox = New System.Windows.Forms.TextBox()
        Me.Data_emprestimoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Data_prevista_devolucaoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Data_devolucao_realDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Status_devolucaoComboBox = New System.Windows.Forms.ComboBox()
        Id_emprestimoLabel = New System.Windows.Forms.Label()
        Id_alunoLabel = New System.Windows.Forms.Label()
        Patrimonio_livroLabel = New System.Windows.Forms.Label()
        Data_emprestimoLabel = New System.Windows.Forms.Label()
        Data_prevista_devolucaoLabel = New System.Windows.Forms.Label()
        Data_devolucao_realLabel = New System.Windows.Forms.Label()
        Status_devolucaoLabel = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DbBibiotecaAtual1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmprestimosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Id_emprestimoLabel
        '
        Id_emprestimoLabel.AutoSize = True
        Id_emprestimoLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_emprestimoLabel.ForeColor = System.Drawing.Color.White
        Id_emprestimoLabel.Location = New System.Drawing.Point(118, 110)
        Id_emprestimoLabel.Name = "Id_emprestimoLabel"
        Id_emprestimoLabel.Size = New System.Drawing.Size(140, 22)
        Id_emprestimoLabel.TabIndex = 3
        Id_emprestimoLabel.Text = "id Emprestimo:"
        '
        'Id_alunoLabel
        '
        Id_alunoLabel.AutoSize = True
        Id_alunoLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_alunoLabel.ForeColor = System.Drawing.Color.White
        Id_alunoLabel.Location = New System.Drawing.Point(449, 110)
        Id_alunoLabel.Name = "Id_alunoLabel"
        Id_alunoLabel.Size = New System.Drawing.Size(90, 22)
        Id_alunoLabel.TabIndex = 5
        Id_alunoLabel.Text = "id Aluno:"
        '
        'Patrimonio_livroLabel
        '
        Patrimonio_livroLabel.AutoSize = True
        Patrimonio_livroLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patrimonio_livroLabel.ForeColor = System.Drawing.Color.White
        Patrimonio_livroLabel.Location = New System.Drawing.Point(118, 190)
        Patrimonio_livroLabel.Name = "Patrimonio_livroLabel"
        Patrimonio_livroLabel.Size = New System.Drawing.Size(159, 22)
        Patrimonio_livroLabel.TabIndex = 7
        Patrimonio_livroLabel.Text = "Patrimonio Livro:"
        '
        'Data_emprestimoLabel
        '
        Data_emprestimoLabel.AutoSize = True
        Data_emprestimoLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_emprestimoLabel.ForeColor = System.Drawing.Color.White
        Data_emprestimoLabel.Location = New System.Drawing.Point(449, 190)
        Data_emprestimoLabel.Name = "Data_emprestimoLabel"
        Data_emprestimoLabel.Size = New System.Drawing.Size(171, 22)
        Data_emprestimoLabel.TabIndex = 9
        Data_emprestimoLabel.Text = "Data Emprestimo:"
        '
        'Data_prevista_devolucaoLabel
        '
        Data_prevista_devolucaoLabel.AutoSize = True
        Data_prevista_devolucaoLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_prevista_devolucaoLabel.ForeColor = System.Drawing.Color.White
        Data_prevista_devolucaoLabel.Location = New System.Drawing.Point(120, 261)
        Data_prevista_devolucaoLabel.Name = "Data_prevista_devolucaoLabel"
        Data_prevista_devolucaoLabel.Size = New System.Drawing.Size(247, 22)
        Data_prevista_devolucaoLabel.TabIndex = 11
        Data_prevista_devolucaoLabel.Text = "Data Prevista Devolução:"
        '
        'Data_devolucao_realLabel
        '
        Data_devolucao_realLabel.AutoSize = True
        Data_devolucao_realLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Data_devolucao_realLabel.ForeColor = System.Drawing.Color.White
        Data_devolucao_realLabel.Location = New System.Drawing.Point(449, 261)
        Data_devolucao_realLabel.Name = "Data_devolucao_realLabel"
        Data_devolucao_realLabel.Size = New System.Drawing.Size(215, 22)
        Data_devolucao_realLabel.TabIndex = 13
        Data_devolucao_realLabel.Text = "Data Devolução Real:"
        '
        'Status_devolucaoLabel
        '
        Status_devolucaoLabel.AutoSize = True
        Status_devolucaoLabel.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Status_devolucaoLabel.ForeColor = System.Drawing.Color.White
        Status_devolucaoLabel.Location = New System.Drawing.Point(117, 350)
        Status_devolucaoLabel.Name = "Status_devolucaoLabel"
        Status_devolucaoLabel.Size = New System.Drawing.Size(177, 22)
        Status_devolucaoLabel.TabIndex = 15
        Status_devolucaoLabel.Text = "Status devolução:"
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
        'EmprestimosBindingSource
        '
        Me.EmprestimosBindingSource.DataMember = "Emprestimos"
        Me.EmprestimosBindingSource.DataSource = Me.DbBibiotecaAtual1DataSet
        '
        'EmprestimosTableAdapter
        '
        Me.EmprestimosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmprestimosTableAdapter = Me.EmprestimosTableAdapter
        Me.TableAdapterManager.LeitoresTableAdapter = Nothing
        Me.TableAdapterManager.LivrosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuarioTableAdapter = Nothing
        '
        'Id_emprestimoTextBox
        '
        Me.Id_emprestimoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmprestimosBindingSource, "id_emprestimo", True))
        Me.Id_emprestimoTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_emprestimoTextBox.Location = New System.Drawing.Point(121, 135)
        Me.Id_emprestimoTextBox.Name = "Id_emprestimoTextBox"
        Me.Id_emprestimoTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Id_emprestimoTextBox.TabIndex = 4
        '
        'Id_alunoTextBox
        '
        Me.Id_alunoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmprestimosBindingSource, "id_aluno", True))
        Me.Id_alunoTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Id_alunoTextBox.Location = New System.Drawing.Point(452, 135)
        Me.Id_alunoTextBox.Name = "Id_alunoTextBox"
        Me.Id_alunoTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Id_alunoTextBox.TabIndex = 6
        '
        'Patrimonio_livroTextBox
        '
        Me.Patrimonio_livroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmprestimosBindingSource, "patrimonio_livro", True))
        Me.Patrimonio_livroTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patrimonio_livroTextBox.Location = New System.Drawing.Point(121, 224)
        Me.Patrimonio_livroTextBox.Name = "Patrimonio_livroTextBox"
        Me.Patrimonio_livroTextBox.Size = New System.Drawing.Size(200, 23)
        Me.Patrimonio_livroTextBox.TabIndex = 8
        '
        'Data_emprestimoDateTimePicker
        '
        Me.Data_emprestimoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmprestimosBindingSource, "data_emprestimo", True))
        Me.Data_emprestimoDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_emprestimoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Data_emprestimoDateTimePicker.Location = New System.Drawing.Point(453, 224)
        Me.Data_emprestimoDateTimePicker.Name = "Data_emprestimoDateTimePicker"
        Me.Data_emprestimoDateTimePicker.Size = New System.Drawing.Size(112, 23)
        Me.Data_emprestimoDateTimePicker.TabIndex = 10
        '
        'Data_prevista_devolucaoDateTimePicker
        '
        Me.Data_prevista_devolucaoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmprestimosBindingSource, "data_prevista_devolucao", True))
        Me.Data_prevista_devolucaoDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_prevista_devolucaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Data_prevista_devolucaoDateTimePicker.Location = New System.Drawing.Point(121, 295)
        Me.Data_prevista_devolucaoDateTimePicker.Name = "Data_prevista_devolucaoDateTimePicker"
        Me.Data_prevista_devolucaoDateTimePicker.Size = New System.Drawing.Size(105, 23)
        Me.Data_prevista_devolucaoDateTimePicker.TabIndex = 12
        '
        'Data_devolucao_realDateTimePicker
        '
        Me.Data_devolucao_realDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmprestimosBindingSource, "data_devolucao_real", True))
        Me.Data_devolucao_realDateTimePicker.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_devolucao_realDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Data_devolucao_realDateTimePicker.Location = New System.Drawing.Point(452, 295)
        Me.Data_devolucao_realDateTimePicker.Name = "Data_devolucao_realDateTimePicker"
        Me.Data_devolucao_realDateTimePicker.Size = New System.Drawing.Size(105, 23)
        Me.Data_devolucao_realDateTimePicker.TabIndex = 14
        '
        'Status_devolucaoComboBox
        '
        Me.Status_devolucaoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmprestimosBindingSource, "status_devolucao", True))
        Me.Status_devolucaoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status_devolucaoComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Status_devolucaoComboBox.FormattingEnabled = True
        Me.Status_devolucaoComboBox.Location = New System.Drawing.Point(121, 375)
        Me.Status_devolucaoComboBox.Name = "Status_devolucaoComboBox"
        Me.Status_devolucaoComboBox.Size = New System.Drawing.Size(171, 25)
        Me.Status_devolucaoComboBox.TabIndex = 16
        '
        'frmEmprestimos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(808, 450)
        Me.Controls.Add(Id_emprestimoLabel)
        Me.Controls.Add(Me.Id_emprestimoTextBox)
        Me.Controls.Add(Id_alunoLabel)
        Me.Controls.Add(Me.Id_alunoTextBox)
        Me.Controls.Add(Patrimonio_livroLabel)
        Me.Controls.Add(Me.Patrimonio_livroTextBox)
        Me.Controls.Add(Data_emprestimoLabel)
        Me.Controls.Add(Me.Data_emprestimoDateTimePicker)
        Me.Controls.Add(Data_prevista_devolucaoLabel)
        Me.Controls.Add(Me.Data_prevista_devolucaoDateTimePicker)
        Me.Controls.Add(Data_devolucao_realLabel)
        Me.Controls.Add(Me.Data_devolucao_realDateTimePicker)
        Me.Controls.Add(Status_devolucaoLabel)
        Me.Controls.Add(Me.Status_devolucaoComboBox)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEmprestimos"
        Me.Text = "frmEmprestimos"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.DbBibiotecaAtual1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmprestimosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EmprestimosBindingSource As BindingSource
    Friend WithEvents EmprestimosTableAdapter As dbBibiotecaAtual1DataSetTableAdapters.EmprestimosTableAdapter
    Friend WithEvents TableAdapterManager As dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Id_emprestimoTextBox As TextBox
    Friend WithEvents Id_alunoTextBox As TextBox
    Friend WithEvents Patrimonio_livroTextBox As TextBox
    Friend WithEvents Data_emprestimoDateTimePicker As DateTimePicker
    Friend WithEvents Data_prevista_devolucaoDateTimePicker As DateTimePicker
    Friend WithEvents Data_devolucao_realDateTimePicker As DateTimePicker
    Friend WithEvents Status_devolucaoComboBox As ComboBox
End Class
