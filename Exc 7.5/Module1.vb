Module Module1

    Sub Main()
        Dim M%, N%, i%, P#, Pg%, Pd%
        Console.Write("M=")
        M = Console.ReadLine()
        Console.Write("N=")
        N = Console.ReadLine()
        Pg = 1
        For i = 1 To N
            Pg = Pg * i
        Next
        Pd = 1
        For i = 1 To M - 1
            Pd = Pd * i
        Next
        P = Pg / Pd
        Console.WriteLine(" Product P= " & P)
        Console.ReadKey()
    End Sub

End Module
