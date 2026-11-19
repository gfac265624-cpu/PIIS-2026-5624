Module Module1

    Sub Main()
        '1. Деклариране на променливи
        Dim A(,) As Double, M%, N%
        'Dim y(,) As Double, u%, z%
        '2. Входни данни
        Vhodni_Danni(A, M, N)
        ' Vhodni danni (y, u, r)
        '3. Из1ислителна част
        Console.WriteLine("Максимума е = " & Max(A, M, N))
        '4. Извеждане на матрицата на екрана
        Izvejdane_na_ekrana(A, M, N)

        Console.ReadKey()
    End Sub
    'Процедура за въвеждане на входни данни 
    'за двумерен масив от тип Double
    Sub Vhodni_Danni(ByRef Z(,) As Double, ByRef M%, ByRef N%)
        '1.  Деклариране на променливи
        Dim i%, j%
        '2. Входни данни
        Do
            Console.Write("Въведете М = ")
            M = Console.ReadLine()
        Loop Until M > 1 And M <= 8
        Do
            Console.Write("Въведете N = ")
            N = Console.ReadLine()
        Loop Until N > 1 And N <= 8
        ReDim Z(M, N)
        For i = 1 To M
            For j = 1 To M
                Console.Write("Z(" & i & "," & j & ") = ")
                Z(i, j) = Console.ReadLine()
            Next
        Next
    End Sub
    'Функция за намиране на максимум в двумерен масив
    Function Max(P(,) As Double, M%, N%) As Double
        '1.  Деклариране на променливи
        Dim i%, j%, maximum#
        '3. Изчислителна част
        maximum = P(1, 1)
        For i = 1 To M
            For j = 1 To N
                If P(i, j) > maximum Then
                    maximum = P(i, j)
                End If
            Next
        Next
        Return maximum
        'Max = maximum (алтернативен вариант)
    End Function
    Sub Izvejdane_na_ekrana(F(,) As Double, Q%, W%)
        Dim i%, j%
        For i = 1 To Q
            For j = 1 To W
                Console.Write(F(i, j) & " | ")
            Next j
            Console.WriteLine()
        Next i
    End Sub
End Module
