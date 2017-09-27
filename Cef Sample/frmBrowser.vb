Imports CefSharp
Imports CefSharp.WinForms
Public Class frmBrowser

    Private WithEvents _browser As ChromiumWebBrowser

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _browser = New ChromiumWebBrowser("http://google.com")


        pnlBrowser.Controls.Add(_browser)
    End Sub

    Private Sub btnMSDN_Click(sender As Object, e As EventArgs) Handles btnMSDN.Click
        _browser.Load("https://msdn.com")
    End Sub

    Private Sub Form1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        _browser.Dispose()
        CefSharp.Cef.Shutdown()
    End Sub

    Private Async Sub btnH1s_ClickAsync(sender As Object, e As EventArgs) Handles btnH1s.Click
        _browser.ShowDevTools
        Dim finder As New JQueryElementFinder(_browser.GetBrowser)
        Dim tmp = Await finder.FindElement("div")
        Stop
        Console.WriteLine(tmp)
    End Sub

    Private Sub _browser_LoadingStateChanged(sender As Object, e As LoadingStateChangedEventArgs) Handles _browser.LoadingStateChanged

        Dim xtn = Sub()
                      pnlActions.Enabled = Not e.IsLoading
                  End Sub
        If InvokeRequired Then
            Invoke(Sub()
                       xtn()
                   End Sub
                )
        Else
            xtn.Invoke
        End If

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

        Dim pth As String = IO.Path.Combine(My.Application.Info.DirectoryPath, "TestPage.html")
        _browser.Load(pth)
    End Sub

    Private Sub _browser_ConsoleMessage(sender As Object, e As ConsoleMessageEventArgs) Handles _browser.ConsoleMessage
        Console.WriteLine(e.Message)
    End Sub
End Class
