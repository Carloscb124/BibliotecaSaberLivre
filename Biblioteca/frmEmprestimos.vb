Public Class frmEmprestimos

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim pesquisa As New frmPesquisa()
        pesquisa.TituloPesquisa = "Emprestimos"
        pesquisa.ShowDialog()
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class