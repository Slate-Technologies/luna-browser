Public Class Form1
    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click, btnGo.Click
        WebBrowser1.Navigate(txtURL.Text)
    End Sub

    Private Sub srchGo_Click(sender As Object, e As EventArgs) Handles srchGo.Click
        WebBrowser1.Navigate("https://html.duckduckgo.com/html/?q=" & txtSearch.Text)
    End Sub

    Private Sub btnGoBack_Click(sender As Object, e As EventArgs) Handles btnGoBack.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub btnGoForth_Click(sender As Object, e As EventArgs) Handles btnGoForth.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub btnGoHome_Click(sender As Object, e As EventArgs) Handles btnGoHome.Click
        WebBrowser1.Navigate("file:///" & IO.Path.GetFullPath(".\luna.html"))
        txtURL.Text = "file:///" & IO.Path.GetFullPath(".\luna.html")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNewWindow.Click
        Dim proc As New System.Diagnostics.Process()
        proc = Process.Start("luna.exe", "")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtURL.Text = "file:///" & IO.Path.GetFullPath(".\luna.html")
        WebBrowser1.Navigate("file:///" & IO.Path.GetFullPath(".\luna.html"))
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        txtURL.Text = WebBrowser1.Document.Url.AbsoluteUri
    End Sub
End Class
