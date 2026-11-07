Module Module1

    Sub Main()
        'Сума на числата от 1 до 50
        '1. Декларираме променливите
        Dim i, N, M, S As Integer
        Console.Write("Vuvedete M=")
        M = Console.ReadLine()
        Console.Write("Vuvedete N=")
        N = Console.ReadLine()
        '3. Изчислителна част
        S = 0
        For i = M To N
            S = S + i ^ 2
        Next i
        '4. Извеждане на резултати
        Console.WriteLine("S = " & S)
        Console.ReadKey()
    End Sub

End Module
