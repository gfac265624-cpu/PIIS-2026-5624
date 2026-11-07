Module Module1

    Sub Main()
        'Програма за определяне разстоянието
        'между две точки в пространството
        '1. Деклариране на променливи
        Dim x1, y1, z1, x2, y2, z2, D As Double
        '2. Входни данни
        Console.Write("Vuvedete x1 = ")
        x1 = Console.ReadLine()
        Console.Write("Vuvedete y1 = ")
        y1 = Console.ReadLine()
        Console.Write("Vuvedete z1 = ")
        z1 = Console.ReadLine()
        Console.Write("Vuvedete x2 = ")
        x2 = Console.ReadLine()
        Console.Write("Vuvedete y2 = ")
        y2 = Console.ReadLine()
        Console.Write("Vuvedete z2 = ")
        z2 = Console.ReadLine()

        '3. Изчислителна част
        D = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2 + (z2 - z1) ^ 2)
        '4. Извеждане на резултати
        Console.WriteLine("D = " & D)
        Console.ReadKey()



    End Sub

End Module
