Imports System.Net
Imports System.IO

Module httpGet

    Sub Main()

        Dim Request As HttpWebRequest
        Dim Response As WebResponse
        Dim Reader As StreamReader
        Dim Line As String

        Request = WebRequest.Create("http://chart.finance.yahoo.com/table.csv?s=MKS.L&ignore=.csv")
        Response = Request.GetResponse()

        Reader = New StreamReader(Response.GetResponseStream())
        Line = Reader.ReadLine()

        While Line IsNot Nothing
            Console.WriteLine(Line)
            Line = Reader.ReadLine()
        End While

        Console.ReadKey()

    End Sub

End Module
