Imports System.Runtime.InteropServices
Public Class frmMain

    Public Property NomeUsuario As String
    Public Property NivelUsuario As String


    Private Sub btnMenu_Click_1(sender As Object, e As EventArgs) Handles btnMenu.Click
        ButtonOff()
        btnMenu.FillColor = Color.FromArgb(111, 93, 235)
        btnMenu.FillColor2 = Color.FromArgb(111, 93, 235)
        titleLabel.Text = btnMenu.Text

        If activeForm IsNot Nothing Then
            activeForm.Close()
            activeForm = Nothing
        End If
        PanelContainer.Controls.Clear()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        ButtonOff()
        btnUser.FillColor = Color.FromArgb(111, 93, 235)
        btnUser.FillColor2 = Color.FromArgb(111, 93, 235)
        titleLabel.Text = btnUser.Text
        OpenFormInPanel(New frmUser())
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        ButtonOff()
        btnBook.FillColor = Color.FromArgb(111, 93, 235)
        btnBook.FillColor2 = Color.FromArgb(111, 93, 235)
        titleLabel.Text = btnBook.Text
        OpenFormInPanel(New frmLivros())

    End Sub

    Private Sub btnLeitores_Click(sender As Object, e As EventArgs) Handles btnLeitores.Click
        ButtonOff()
        btnLeitores.FillColor = Color.FromArgb(111, 93, 235)
        btnLeitores.FillColor2 = Color.FromArgb(111, 93, 235)
        titleLabel.Text = btnLeitores.Text
        OpenFormInPanel(New frmLeitores())
    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        ButtonOff()
        btnLoan.FillColor = Color.FromArgb(111, 93, 235)
        btnLoan.FillColor2 = Color.FromArgb(111, 93, 235)
        titleLabel.Text = btnLoan.Text
        OpenFormInPanel(New frmEmprestimos())
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        ButtonOff()
        btnLogOut.FillColor = Color.FromArgb(111, 93, 235)
        btnLogOut.FillColor2 = Color.FromArgb(111, 93, 235)
        Close()
        Form1.Show()
    End Sub

    Private Sub ButtonOff()
        btnMenu.FillColor = Color.Transparent
        btnMenu.FillColor2 = Color.Transparent

        btnUser.FillColor = Color.Transparent
        btnUser.FillColor2 = Color.Transparent

        btnBook.FillColor = Color.Transparent
        btnBook.FillColor2 = Color.Transparent

        btnLeitores.FillColor = Color.Transparent
        btnLeitores.FillColor2 = Color.Transparent

        btnLoan.FillColor = Color.Transparent
        btnLoan.FillColor2 = Color.Transparent

        btnLogOut.FillColor = Color.Transparent
        btnLogOut.FillColor2 = Color.Transparent

        btnMenu.FillColor = Color.Transparent
        btnMenu.FillColor2 = Color.Transparent
    End Sub



    Private activeForm As Form = Nothing

    Private Sub OpenFormInPanel(childForm As Form)
        ' Se já existe um form aberto, fecha ele antes de abrir o novo
        If activeForm IsNot Nothing Then
            activeForm.Close()
        End If

        activeForm = childForm

        PanelContainer.Controls.Clear()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(childForm)
        PanelContainer.Tag = childForm
        childForm.Show()
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        End
    End Sub


    ' Flag para controlar o "maximizado custom"
    Private isCustomMaximized As Boolean = False
    Private prevBounds As Rectangle
    Private prevWindowState As FormWindowState

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click

        ' Fade rápido
        FadeTransition(0.0, 0.08) ' fade out curto

        If Not isCustomMaximized Then
            ' salva estado atual para restaurar depois
            prevBounds = Me.Bounds
            prevWindowState = Me.WindowState

            ' maximiza respeitando a taskbar (sem usar WindowState = Maximized)
            MaximizarFormulario()
            isCustomMaximized = True
            btnMaximize.Image = My.Resources.restore
        Else
            ' restaura estado salvo
            RestaurarFormulario()
            isCustomMaximized = False
            btnMaximize.Image = My.Resources.maximize
        End If

        Application.DoEvents()

        ' Fade in rápido
        FadeTransition(1.0, 0.08)

        ' Mantém os botões sempre visíveis
        btnMaximize.BringToFront()
        btnMinimize.BringToFront()
    End Sub

    Private Sub MaximizarFormulario()
        Dim screen As Screen = Screen.FromControl(Me)
        Dim areaTrabalho As Rectangle = screen.WorkingArea
        Dim telaCompleta As Rectangle = screen.Bounds

        ' Detecta se a taskbar está oculta automaticamente (quando área útil = total)
        Dim taskbarOculta As Boolean = (areaTrabalho.Height = telaCompleta.Height AndAlso areaTrabalho.Width = telaCompleta.Width)

        ' Se estiver oculta, ocupa a tela inteira
        If taskbarOculta Then
            Me.Bounds = telaCompleta
        Else
            Me.Bounds = areaTrabalho
        End If
    End Sub

    Private Sub RestaurarFormulario()
        ' Restaura para o estado e tamanho anterior
        Me.FormBorderStyle = FormBorderStyle.None ' ou o que você usava antes
        Me.Bounds = prevBounds
        Me.WindowState = prevWindowState
        Me.Refresh()
    End Sub

    Private Sub FadeTransition(targetOpacity As Double, duration As Double)
        Dim steps As Integer = 12 ' menos steps = transição mais rápida
        Dim stepTime As Integer = CInt(duration * 1000 / steps)
        Dim delta As Double = (targetOpacity - Me.Opacity) / steps

        For i As Integer = 1 To steps
            Me.Opacity += delta
            Application.DoEvents()
            Threading.Thread.Sleep(stepTime)
        Next
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnMaximize.Image = My.Resources.maximize


        If Form1.Nivel_usuarioComboBox.Text = "Bibliotecario" Then

            btnUser.Visible = False

        End If

        ' Exibe o nome do usuário no label
        lblUser.Text = "Bem-vindo, " & NomeUsuario

        ' Escolhe o ícone conforme o nível
        If NivelUsuario.ToLower() = "administrador" Then
            PictureBox2.Image = My.Resources.admIcon
        Else
            PictureBox2.Image = My.Resources.usuario
        End If

    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Escape Then
            ' Chama a mesma ação do botão de maximizar/restaurar
            btnMaximize.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles PanelContainer.Paint

    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub frmMain_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

End Class