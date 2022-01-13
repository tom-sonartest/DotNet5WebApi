Public Class Class1

    Public Shared Sub Bar(bar As String)
        Dim var = 6, a = 5 ' Noncompliant
        Print(var)
        Print(bar)
        Print(a)
    End Sub


End Class
