Imports System.Runtime.InteropServices
Public Class Form1

    Dim nivel As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario, senha As String

        usuario = Nome_usuarioTextBox.Text
        senha = Senha_usuarioTextBox.Text
        nivel = Nivel_usuarioComboBox.Text

        ' Validação no banco
        If Me.UsuarioTableAdapter.ScalarQueryLogin(usuario, senha, nivel) Then

            ' Cria o formulário principal e envia as informações
            Dim main As New frmMain()
            main.NomeUsuario = usuario
            main.NivelUsuario = nivel

            ' Exibe o form principal
            main.Show()

            ' Limpa o login e oculta
            Nome_usuarioTextBox.Clear()
            Senha_usuarioTextBox.Clear()
            Me.Hide()

        Else
            MessageBox.Show("Usuário, senha ou nível incorretos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Nome_usuarioTextBox.Clear()
            Senha_usuarioTextBox.Clear()
            Nome_usuarioTextBox.Focus()
        End If
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBibiotecaAtual1DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DbBibiotecaAtual1DataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
        Me.UsuarioTableAdapter.Fill(Me.DbBibiotecaAtual1DataSet.Usuario)

    End Sub
End Class
