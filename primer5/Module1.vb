Module Module1

    Sub Main()
        '1. Деклариране на променливи
        Dim Y#, x#, c#
        ' # - As Double
        ' % - As Integer
        ' ! - As Single
        ' $ - As string+
        '2. входни данни
        Console.Write("Vuvedete x = ")
        x = Console.ReadLine()
        Console.Write("Vuvedete c = ")
        c = Console.ReadLine()
        '3. Изчислителна част
        If x > c Then Y = Math.Abs(x) Else Y = Math.Atan(x)
        Console.WriteLine("Y (x) = " & Y)
        Console.ReadKey()


    End Sub

End Module
