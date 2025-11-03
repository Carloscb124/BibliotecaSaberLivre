Public Class frmLeitores

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim pesquisa As New frmPesquisa()
        pesquisa.TituloPesquisa = "Leitores"
        pesquisa.ShowDialog()
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click

    End Sub

    Private Sub frmLeitores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class