Public Class frmLeitores

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim pesquisa As New frmPesquisa()
        pesquisa.TituloPesquisa = "Leitores"
        pesquisa.ShowDialog()
    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmLeitores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'DbBibiotecaAtual1DataSet.Leitores'. Você pode movê-la ou removê-la conforme necessário.
        Me.LeitoresTableAdapter.Fill(Me.DbBibiotecaAtual1DataSet.Leitores)

    End Sub

    Private Sub LeitoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LeitoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBibiotecaAtual1DataSet)
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.LeitoresBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.LeitoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBibiotecaAtual1DataSet)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.LeitoresBindingSource.MoveNext()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.LeitoresBindingSource.MovePrevious()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Me.LeitoresBindingSource.MoveLast()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.LeitoresBindingSource.MoveFirst()
    End Sub
End Class