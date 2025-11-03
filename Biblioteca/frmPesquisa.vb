Imports System.Runtime.InteropServices
Public Class frmPesquisa
    Public Property TituloPesquisa As String
    Private Sub frmPesquisa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTitle.Text = "Pesquisa de " & TituloPesquisa

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    Private Sub frmPesquisa_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class