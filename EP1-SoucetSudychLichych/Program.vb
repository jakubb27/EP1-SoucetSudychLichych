Imports System

Module Program
    Sub Main(args As String())
        While True
            Dim celkovéèíslo As Integer = GetTotalNumbers()
            Dim lichýsouèet As Integer = 0
            Dim sudýsouèet As Integer = 0
            Dim Lichýpoèet As Integer = 0
            Dim sudýpoèet As Integer = 0

            For i As Integer = 1 To celkovéèíslo
                Dim number As Integer = GetNumber(i)
                If number Mod 2 = 0 Then
                    sudýsouèet += number
                    sudýpoèet += 1
                Else
                    lichýsouèet += number
                    Lichýpoèet += 1
                End If
            Next
            Console.WriteLine($"Souèet lichých èísel: {lichýsouèet}")
            Console.WriteLine($"Poèet lichých èísel: {Lichýpoèet}")
            Console.WriteLine($"Souèet sudých èísel: {sudýsouèet}")
            Console.WriteLine($"Poèet sudých èísel: {sudýpoèet}")

            Console.WriteLine("Chcete zadat další èísla? (a/n)")
            If Console.ReadLine().ToLower() <> "a" Then
                Exit While
            End If
        End While
    End Sub
End Module

