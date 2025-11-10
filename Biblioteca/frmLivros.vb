Public Class frmLivros
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim pesquisa As New frmPesquisa()
        pesquisa.TituloPesquisa = "Livros"
        pesquisa.ShowDialog()
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub LivrosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LivrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBibiotecaAtual1DataSet)

    End Sub

    Private Sub frmLivros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DbBibiotecaAtual1DataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
        Me.LivrosTableAdapter.Fill(Me.DbBibiotecaAtual1DataSet.Livros)

    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.LivrosBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.LivrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBibiotecaAtual1DataSet)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.LivrosBindingSource.MoveNext()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.LivrosBindingSource.MovePrevious()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Me.LivrosBindingSource.MoveLast()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.LivrosBindingSource.MoveFirst()
    End Sub
End Class