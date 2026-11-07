Module Module1

    Sub Main()
        'Сума на числата от 1 до 100
        '1. Деклариране на променливи
        Dim i%, S%
        '2. входни данни
        '3. Изчислителна част 
        S = 0
        For i = 1 To 100
            S = S + i ' S += i
        Next i
        '4. Извеждане на резултати
        Console.WriteLine("S = " & S)
        Console.ReadKey()
        '5. Тестване


    End Sub

End Module
