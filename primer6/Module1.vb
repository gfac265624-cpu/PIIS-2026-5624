Module Module1

    Sub Main()
        'Калкулатор
        'Пресмятане на две числа и операцията между тях
        '1. Деклариране на променливи
        Dim a#, b#, S#, c$
        '2. Входни данни
        Console.Write("Vuvedete purvoto chislo=")
        a = Console.ReadLine()
et1:    Console.Write("Vuvedete vtoroto chislo=")
        b = Console.ReadLine()
et2:    Console.Write("Vuvedete operator (+, -, *, /) = ")
        c = Console.ReadLine()
        '3. Изчислителна част
        S = 0
        Select Case c
            Case "+"
                S = a + b
            Case "-"
                S = a + b
            Case "*"
                S = a * b
            Case "/"
                If b <> 0 Then
                    S = a / b
                Else
                    Console.WriteLine("Delenie na 0 ne e pozvoleno")
                    GoTo et1
                End If
            Case Else
                Console.WriteLine("Greshen operator")
                GoTo et2

        End Select
        '4. Извеждане на резуултати
        Console.WriteLine("S = " & a & c & b & " = " & S)
        Console.ReadKey()

    End Sub

End Module
        