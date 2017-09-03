Imports CefSharp.WinForms
Public Class Form1

    Private ReadOnly _browser As ChromiumWebBrowser

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _browser = New ChromiumWebBrowser("http://google.com")
        pnlBrowser.Controls.Add(_browser)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _browser.Load("https://msdn.com")
    End Sub

    Private Sub Form1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        _browser.Dispose()
        CefSharp.Cef.Shutdown()
    End Sub
End Class
