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
        'TODO: esta linha de código carrega dados na tabela 'DbBibiotecaAtual1DataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
        Me.UsuarioTableAdapter.Fill(Me.DbBibiotecaAtual1DataSet.Usuario)

    End Sub

    Private Sub UsuarioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBibiotecaAtual1DataSet)

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Me.UsuarioBindingSource.AddNew()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.UsuarioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbBibiotecaAtual1DataSet)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.UsuarioBindingSource.MoveNext()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.UsuarioBindingSource.MovePrevious()
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Me.UsuarioBindingSource.MoveLast()
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Me.UsuarioBindingSource.MoveFirst()
    End Sub
End Class