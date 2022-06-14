Module Module1

    Sub Main()

        Dim num1 As Integer = 0
        Dim num2 As Integer = 0
        Dim mul As Integer = 0
        Dim count As Integer = 0

        Console.Write("Enter number1: ")
        num1 = Integer.Parse(Console.ReadLine())

        Console.Write("Enter number2: ")
        num2 = Integer.Parse(Console.ReadLine())

        mul = 0

        For count = 1 To num2 Step 1
            mul += num1
        Next

        Console.WriteLine("Multiplication is: {0}", mul)

    End Sub

End Module