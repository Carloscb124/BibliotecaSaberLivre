Public Class frmUser
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim pesquisa As New frmPesquisa()
        pesquisa.TituloPesquisa = "Usuários"
        pesquisa.ShowDialog()
    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class