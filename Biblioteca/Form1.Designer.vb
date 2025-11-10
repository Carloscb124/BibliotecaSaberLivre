<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim Nome_usuarioLabel As System.Windows.Forms.Label
        Dim Senha_usuarioLabel As System.Windows.Forms.Label
        Dim Nivel_usuarioLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnEnd = New Guna.UI2.WinForms.Guna2Button()
        Me.Nome_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Senha_usuarioTextBox = New System.Windows.Forms.TextBox()
        Me.Nivel_usuarioComboBox = New System.Windows.Forms.ComboBox()
        Me.DbBibiotecaAtual1DataSet = New Biblioteca.dbBibiotecaAtual1DataSet()
        Me.UsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuarioTableAdapter = New Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.UsuarioTableAdapter()
        Me.TableAdapterManager = New Biblioteca.dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager()
        Nome_usuarioLabel = New System.Windows.Forms.Label()
        Senha_usuarioLabel = New System.Windows.Forms.Label()
        Nivel_usuarioLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.DbBibiotecaAtual1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(345, 402)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Biblioteca.My.Resources.Resources.Library_rafiki
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 416)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(351, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 36)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Bem-Vindo"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BorderRadius = 10
        Me.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogin.Location = New System.Drawing.Point(477, 345)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(102, 32)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Entrar"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnEnd)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(345, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(334, 32)
        Me.Guna2Panel1.TabIndex = 6
        '
        'btnEnd
        '
        Me.btnEnd.BorderColor = System.Drawing.Color.Transparent
        Me.btnEnd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEnd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEnd.FillColor = System.Drawing.Color.Transparent
        Me.btnEnd.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEnd.ForeColor = System.Drawing.Color.White
        Me.btnEnd.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnEnd.Image = Global.Biblioteca.My.Resources.Resources.close_24dp_E3E3E3_FILL0_wght400_GRAD0_opsz24
        Me.btnEnd.Location = New System.Drawing.Point(298, 3)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(32, 22)
        Me.btnEnd.TabIndex = 7
        '
        'Nome_usuarioLabel
        '
        Nome_usuarioLabel.AutoSize = True
        Nome_usuarioLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nome_usuarioLabel.ForeColor = System.Drawing.Color.White
        Nome_usuarioLabel.Location = New System.Drawing.Point(385, 124)
        Nome_usuarioLabel.Name = "Nome_usuarioLabel"
        Nome_usuarioLabel.Size = New System.Drawing.Size(62, 19)
        Nome_usuarioLabel.TabIndex = 7
        Nome_usuarioLabel.Text = "Nome:"
        '
        'Nome_usuarioTextBox
        '
        Me.Nome_usuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nome_usuarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_usuarioTextBox.Location = New System.Drawing.Point(412, 146)
        Me.Nome_usuarioTextBox.Name = "Nome_usuarioTextBox"
        Me.Nome_usuarioTextBox.Size = New System.Drawing.Size(185, 26)
        Me.Nome_usuarioTextBox.TabIndex = 8
        '
        'Senha_usuarioLabel
        '
        Senha_usuarioLabel.AutoSize = True
        Senha_usuarioLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Senha_usuarioLabel.ForeColor = System.Drawing.Color.White
        Senha_usuarioLabel.Location = New System.Drawing.Point(385, 188)
        Senha_usuarioLabel.Name = "Senha_usuarioLabel"
        Senha_usuarioLabel.Size = New System.Drawing.Size(63, 19)
        Senha_usuarioLabel.TabIndex = 8
        Senha_usuarioLabel.Text = "Senha:"
        '
        'Senha_usuarioTextBox
        '
        Me.Senha_usuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Senha_usuarioTextBox.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Senha_usuarioTextBox.Location = New System.Drawing.Point(412, 210)
        Me.Senha_usuarioTextBox.Name = "Senha_usuarioTextBox"
        Me.Senha_usuarioTextBox.Size = New System.Drawing.Size(185, 27)
        Me.Senha_usuarioTextBox.TabIndex = 9
        Me.Senha_usuarioTextBox.UseSystemPasswordChar = True
        '
        'Nivel_usuarioLabel
        '
        Nivel_usuarioLabel.AutoSize = True
        Nivel_usuarioLabel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nivel_usuarioLabel.ForeColor = System.Drawing.Color.White
        Nivel_usuarioLabel.Location = New System.Drawing.Point(385, 254)
        Nivel_usuarioLabel.Name = "Nivel_usuarioLabel"
        Nivel_usuarioLabel.Size = New System.Drawing.Size(53, 19)
        Nivel_usuarioLabel.TabIndex = 9
        Nivel_usuarioLabel.Text = "Nivel:"
        '
        'Nivel_usuarioComboBox
        '
        Me.Nivel_usuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Nivel_usuarioComboBox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nivel_usuarioComboBox.FormattingEnabled = True
        Me.Nivel_usuarioComboBox.Items.AddRange(New Object() {"Bibliotecario", "Administrador", ""})
        Me.Nivel_usuarioComboBox.Location = New System.Drawing.Point(412, 276)
        Me.Nivel_usuarioComboBox.Name = "Nivel_usuarioComboBox"
        Me.Nivel_usuarioComboBox.Size = New System.Drawing.Size(153, 25)
        Me.Nivel_usuarioComboBox.TabIndex = 10
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(679, 402)
        Me.Controls.Add(Nivel_usuarioLabel)
        Me.Controls.Add(Me.Nivel_usuarioComboBox)
        Me.Controls.Add(Senha_usuarioLabel)
        Me.Controls.Add(Me.Senha_usuarioTextBox)
        Me.Controls.Add(Nome_usuarioLabel)
        Me.Controls.Add(Me.Nome_usuarioTextBox)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.DbBibiotecaAtual1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnEnd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DbBibiotecaAtual1DataSet As dbBibiotecaAtual1DataSet
    Friend WithEvents UsuarioBindingSource As BindingSource
    Friend WithEvents UsuarioTableAdapter As dbBibiotecaAtual1DataSetTableAdapters.UsuarioTableAdapter
    Friend WithEvents TableAdapterManager As dbBibiotecaAtual1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Nome_usuarioTextBox As TextBox
    Friend WithEvents Senha_usuarioTextBox As TextBox
    Friend WithEvents Nivel_usuarioComboBox As ComboBox
End Class
