Module Module1

    Sub Main()
        Dim M, N As Integer

        'Входни данни:
        Console.Write("M=")
        M = Console.ReadLine()
        Console.Write("N=")
        N = Console.ReadLine()
        Dim sum As Integer = 0

        'Операции:
        For index = M To N
            sum += index ^ 2
        Next

        'Изход:
        Console.WriteLine($" S = {sum}")
        Console.ReadKey()

    End Sub

End Module
