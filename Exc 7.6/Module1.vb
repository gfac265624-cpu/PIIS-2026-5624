Module Module1

    Sub Main()
        Dim A() As Double
        Dim M#, i%
        Console.Write("M=")
        M = Console.ReadLine()
        ReDim A(M)
        For i = 1 To M
            Console.Write("A(" & i & ")=")
            A(i) = Console.ReadLine()
        Next

        'a) sum of elements
        Dim S#
        S = 0
        For i = 1 To M
            S = S + A(i)
        Next
        Console.WriteLine("S=" & S)
        Console.ReadKey()

        'b) произведение на ненулеви елементи
        Dim P#
        P = 1
        For i = 1 To M
            If A(i) <> 0 Then
                P = P * A(i)
            End If
        Next
        Console.WriteLine("P=" & P)
        Console.ReadKey()

        'в) средно аритметично на положителните елементи
        Dim Ap#, Sp#, Np%
        Ap = 0
        Sp = 0
        Np = 0
        For i = 1 To M
            If A(i) > 0 Then Sp = Sp + A(i) : Np = Np + 1
        Next
        Ap = Sp / Np

        If Np > 0 Then
            Console.WriteLine("Ap=" & Ap)
            Console.ReadKey()
        Else
            Console.WriteLine("No positive elements for Ap")
            Console.ReadKey()
        End If

        'г) макс елемент на масива
        Dim Max#, imax%
        Max = A(1) : imax = 1
        For i = 2 To M
            If A(i) > Max Then Max = A(i) : imax = i

        Next
        Console.WriteLine("Maximum Max A(" & imax & ")=" & Max) 'A(3)=15       
        Console.ReadKey()

        'д) мин елемент на масива
        Dim Min#, imin%
        Min = A(1) : imin = 1
        For i = 2 To M
            If A(i) > Min Then Min = A(i) : imin = i
        Next
        Console.WriteLine("Minimum Min A(" & imin & ")=" & Min) 'A(3)=15    
        Console.ReadKey()

        '1
        Dim S1 As Double
        S1 = 0
        For i = 1 To M
            If A(i) < 0 Then
                S1 = S1 + A(i)
            End If
        Next
        Console.Write("S1=" & S1)
        Console.ReadKey()

        '2
        Dim Ap1, Sp1 As Double
        Dim Np1 As Integer
        Ap1 = 0
        Sp1 = 0
        Np1 = 0
        For i = 1 To M
            If A(i) < 0 Then Sp1 = Sp1 + A(i) : Np1 = Np + 1
        Next
        Ap1 = Sp1 / Np1
        If Np1 > 0 Then
            Console.WriteLine("Ap1=" & Ap1)
            Console.ReadKey()
        Else
            Console.WriteLine("nqma otricatelni elementi")
            Console.ReadKey()
        End If

        '3
        Dim P3 As Double
        P3 = 1
        For i = 1 To M
            If A(i) < 0 Then
                P3 = P3 * A(i)
            End If
        Next
        Console.WriteLine("P3=" & P3)
        Console.ReadKey()

        'е) подреждане на елементите във възходящ ред
        Dim B() As Double : ReDim B(M)
        Dim T#, j%
        For i = 1 To M
            B(i) = A(i)
        Next
        For i = 1 To M - 1
            For j = 1 To M - i
                If B(j) > B(j + 1) Then
                    T = B(j) : B(j) = B(j + 1) : B(j + 1) = T
                End If
            Next
        Next
        For i = 1 To M
            Console.WriteLine("B(" & i & ")=" & B(i)) 'B(1)=-10
            Console.ReadKey()
        Next

        'ж) скаларно произведение на елементи от двата масива
        Dim SkP As Double
            SkP = 0
            For i = 1 To M
                SkP = SkP + A(i) * B(i)
            Next i
            Console.WriteLine("Скаларно произведение= " & SkP)
        Console.ReadKey()

    End Sub
End Module
