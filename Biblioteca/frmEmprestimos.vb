Public Class frmEmprestimos

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim pesquisa As New frmPesquisa()
        pesquisa.TituloPesquisa = "Emprestimos"
        frmPesquisaEmprestimo.ShowDialog()
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub EmprestimosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmprestimosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBibiotecaAtual1DataSet)

    End Sub

    Private Sub frmEmprestimos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DbBibiotecaAtual1DataSet.Emprestimos'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmprestimosTableAdapter.Fill(Me.DbBibiotecaAtual1DataSet.Emprestimos)

    End Sub


    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.EmprestimosBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.EmprestimosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBibiotecaAtual1DataSet)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.EmprestimosBindingSource.MovePrevious()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Me.EmprestimosBindingSource.MoveLast()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.EmprestimosBindingSource.MoveFirst()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.EmprestimosBindingSource.MoveNext()
    End Sub
End Class