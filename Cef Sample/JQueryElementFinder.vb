Imports CefSharp

Public Class JQueryElementFinder
    Private ReadOnly _browser As IBrowser

    Public Sub New(ByVal browser As IBrowser)
        _browser = browser

    End Sub
    Private Async Function LoadJQueryAsync() As Task


        Dim result = Await _browser.MainFrame.EvaluateScriptAsync("(typeof jQuery=='undefined');")
        If result.Result = True Then
            Dim js As String = My.Resources.LoadJQuery
            Await _browser.MainFrame.EvaluateScriptAsync(js)

        End If




    End Function

    Public Async Function FindElement(Selector As String) As Task(Of JavascriptResponse)
        Await LoadJQueryAsync()
        Dim result = Await _browser.MainFrame.EvaluateScriptAsync($"jQuery('{Selector}');")
        Return result

    End Function
End Class
