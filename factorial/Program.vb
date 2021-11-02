Imports System

Module factorial_for
    Sub Main(args As String())
        Dim n, i, f As Integer
        Console.Write("Enter a Number: ")
        n = Console.ReadLine()
        f = 1
        If n < 0 Then
        ElseIf n = 0 Or n = 1 Then
            Console.WriteLine("Factorial of  {0} is 1", n)
        Else
            For i = 1 To n
                f *= i
            Next
            Console.WriteLine("Factorial of {0} is {1}", n, f)
        End If
        Console.ReadLine()
    End Sub
End Module
