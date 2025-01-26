'Malachi Marlow
'Spring 2025
'RCET2265
'Simple Calculator
'https://github.com/MalachiMarlow/Simple_Calculator_MM.git

Option Explicit On
Option Strict On

Module Simple_Calc

    Sub Main()
        Dim val1 As Integer
        Dim val2 As Integer
        Dim userInput As String

        Console.WriteLine("Please enter a whole number:")
        val1 = CInt(Console.ReadLine())

        Console.WriteLine("Please enter a whole number:")
        val2 = CInt(Console.ReadLine())

        Console.WriteLine("Select One." & vbNewLine _
                          & "1. Addition" & vbNewLine _
                          & "2. Multiplication")
        userInput = Console.ReadLine
        If userInput = "1" Then
            Console.WriteLine($"{val1} + {val2} = {val1 + val2}")
        ElseIf userInput = "2" Then
            Console.WriteLine($"{val1} * {val2} = {val1 * val2}")
        Else
            Console.WriteLine("Try again.")
        End If


    End Sub

End Module
