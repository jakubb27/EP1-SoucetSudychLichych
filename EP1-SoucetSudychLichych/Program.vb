Imports System

Module Program
    Sub Main(args As String())
        While True
            Dim celkov���slo As Integer = GetTotalNumbers()
            Dim lich�sou�et As Integer = 0
            Dim sud�sou�et As Integer = 0
            Dim Lich�po�et As Integer = 0
            Dim sud�po�et As Integer = 0

            For i As Integer = 1 To celkov���slo
                Dim number As Integer = GetNumber(i)
                If number Mod 2 = 0 Then
                    sud�sou�et += number
                    sud�po�et += 1
                Else
                    lich�sou�et += number
                    Lich�po�et += 1
                End If
            Next
            Console.WriteLine($"Sou�et lich�ch ��sel: {lich�sou�et}")
            Console.WriteLine($"Po�et lich�ch ��sel: {Lich�po�et}")
            Console.WriteLine($"Sou�et sud�ch ��sel: {sud�sou�et}")
            Console.WriteLine($"Po�et sud�ch ��sel: {sud�po�et}")

            Console.WriteLine("Chcete zadat dal�� ��sla? (a/n)")
            If Console.ReadLine().ToLower() <> "a" Then
                Exit While
            End If
        End While
    End Sub
End Module

