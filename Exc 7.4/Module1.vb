Module Module1

    Sub Main()
        Dim P%, N%, i%
        Console.Write("N=")
        N = Console.ReadLine()
        P = 1
        For i = 1 To N
            P = P * i
        Next
        Console.WriteLine("P= " & P)
        Console.ReadKey()

    End Sub

End Module
