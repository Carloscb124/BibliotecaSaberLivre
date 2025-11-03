
Public Class frmMain

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

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class