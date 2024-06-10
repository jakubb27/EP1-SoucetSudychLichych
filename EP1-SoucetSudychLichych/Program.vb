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
Function GetTotalNumbers() As Integer
    While True
        Console.WriteLine("Zadejte celkový poèet èísel:")
        Dim input As String = Console.ReadLine()
        Dim totalNumbers As Integer
        If Integer.TryParse(input, totalNumbers) AndAlso totalNumbers > 0 Then
            Return totalNumbers
        Else
            Console.WriteLine("Neplatný vstup, zadejte kladné celé èíslo.")
        End If
    End While
End Function
Function GetNumber(index As Integer) As Integer

    While True
        Console.WriteLine($"Zadejte èíslo {index}:")
        Dim input As String = Console.ReadLine()
        Dim number As Integer
        If Integer.TryParse(input, number) AndAlso number >= 0 Then
            Return number
        Else
            Console.WriteLine("Neplatný vstup, zadejte kladné celé èíslo.")
        End If
    End While
End Function

