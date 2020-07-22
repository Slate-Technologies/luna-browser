Imports System.ComponentModel

Public Class Luna
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click, btnAddressGo.Click
        WebBrowser1.Navigate(txtAddress.Text)
    End Sub

    Private Sub btnSearchGo_Click(sender As Object, e As EventArgs) Handles btnSearchGo.Click
        WebBrowser1.Navigate("https://html.duckduckgo.com/html/?q=" & txtSearch.Text)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        WebBrowser1.Navigate("file:///" & IO.Path.GetFullPath(".\luna.html"))
        txtAddress.Text = "file:///" & IO.Path.GetFullPath(".\luna.html")
    End Sub

    Private Sub btnNewWindow_Click(sender As Object, e As EventArgs) Handles btnNewWindow.Click
        Dim proc As New System.Diagnostics.Process()
        proc = Process.Start("Luna 2.exe", "")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAddress.Text = "file:///" & IO.Path.GetFullPath(".\luna.html")
        WebBrowser1.Navigate("file:///" & IO.Path.GetFullPath(".\luna.html"))
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        txtAddress.Text = WebBrowser1.Document.Url.AbsoluteUri
        If WebBrowser1.Document.Url.Host IsNot "" Then
            Me.Text = "Luna - " & WebBrowser1.Document.Url.Host
        End If

        If WebBrowser1.Document.Url.Host Is "" Then
            Me.Text = "Luna - Start"
        End If
    End Sub

    Private Sub Luna_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles Me.HelpButtonClicked
        Dim appPath As String = Application.StartupPath()
        Process.Start(appPath + "\help\LunaHelp.chm")
    End Sub

    Private Sub Luna_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles Me.HelpRequested
        Dim appPath As String = Application.StartupPath()
        Process.Start(appPath + "\help\LunaHelp.chm")
    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        If e.CurrentProgress < 10001 Then
            ProgressBar.Value = (e.CurrentProgress + 1)
        End If
        If e.CurrentProgress > 10001 Then
            ProgressBar.Value = 10001
        End If
    End Sub
End Class
