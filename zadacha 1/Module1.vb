Module Module1


    Sub Main()
        Dim Z(,) As Double
        Dim M%, N%
        Dim i%, j%

        '1. Входни данни
        Do
            Console.Write("M е диапазона на 2 до 8, M=")
            M = Console.ReadLine()
        Loop Until M > 1 And M <= 8

        Do
            Console.Write("N е диапазона на 2 до 8, N=")
            N = Console.ReadLine()
        Loop Until N > 1 And N <= 8

        '2. Предеклариране на масива
        ReDim Z(M, N)
        For i = 1 To M
            For j = 1 To N
                Console.Write("Z(" & i & "," & j & ")=")    'Z(i, j) =...
                Z(i, j) = Console.ReadLine()
            Next
        Next

        'а) сума на всички елементи
        Dim S#
        S = 0
        For i = 1 To M
            For j = 1 To M
                S = S + Z(i, j)
            Next
        Next

        Console.WriteLine("Sum S=" & S)
        Console.ReadKey()

        'б) произведение на ненулеви елементи
        Dim P#
        P = 1
        For i = 1 To M
            For j = 1 To N
                If Z(i, j) <> 0 Then
                    P = P * Z(i, j)
                End If
            Next
        Next
        Console.WriteLine("Product P=" & P)
        Console.ReadKey()

        'в) максимум на матрицата и местоположението му (ред и стълб)
        Dim Max#
        Dim imax%, jmax%
        Max = Z(1, 1)
        imax = 1 : jmax = 1
        For i = 1 To M
            For j = 1 To N
                If Z(i, j) > Max Then
                    Max = Z(i, j)
                    imax = i
                    jmax = j
                End If
            Next
        Next
        Console.WriteLine("Z(" & imax & "," & jmax & ")=" & Max)       'Z(imax, jmax)=...
        Console.ReadKey()

        'г) минимум на матрицата и местоположението му (ред и стълб)
        Dim Min#
        Dim imin%, jmin%
        Min = Z(1, 1)
        imin = 1 : jmin = 1
        For i = 1 To M
            For j = 1 To N
                If Z(i, j) < Min Then
                    Min = Z(i, j)
                    imin = i
                    jmin = j
                End If
            Next
        Next
        Console.WriteLine("Z(" & imin & "," & jmin & ")=" & Min)       'Z(imin, jmin)=...
        Console.ReadKey()


        Dim Av#
        Av = S / (M * N)
        Console.WriteLine("Average Av=" & Av)
        Console.ReadKey()

        'д) средно аритметично на положителните елементи над главния диагонал, ако матрицата е квадратнa
        Dim Sp#, Ap#
        Dim Np%
        Sp = 0 : Np = 0
        For i = 1 To M
        Next
        For j = 1 To N
            If i < j Then
            End If
        Next


        'е) средно аритметично на положителните елементи над главен диагонал, при квадратна матрица
        If M = N Then

            Sp = 0 : Np = 0
            For i = 1 To M
                For j = 1 To N
                    If i < j Then
                        If Z(i, j) > 0 Then
                            Sp = Sp + Z(i, j)
                            Np = Np + 1
                        End If
                    End If
                Next
            Next
            If Np > 0 Then
                    Ap = Sp / Np
                    Console.WriteLine("Ap=" & Ap)
                    Console.ReadKey()
                Else
                    Console.WriteLine("Няма положителни елементи над главния диагонал")
                    Console.ReadKey()
                End If
                Else
                Console.WriteLine("Матрицата не е квадратна")
                Console.ReadKey()
                End If


        'ж) макс под второстепенен диагонал
        If M = N Then
            Dim Max2#
            Max2 = Z(M, N)
            For i = 1 To M
                For j = 1 To N
                    If i + j > N + 1 Then
                        If Z(i, j) > Max2 Then Max2 = Z(i, j)
                    End If
                Next
            Next
            Console.WriteLine("Max под второстепенен диагонал Max2=" & Max2)
            Console.ReadKey()
        End If

        'з) С Max увеличете лява половина и намалете дясна половина
        If N Mod 2 = 0 Then
            For i = 1 To M
                For j = 1 To N
                    If j <= M / 2 Then
                        Z(i, j) = Z(i, j) + Max
                    Else
                        Z(i, j) = Z(i, j) - Max
                    End If
                Next
            Next
            For i = 1 To M
                For j = 1 To N
                    Console.Write(Z(i, j) & "     ")
                Next
                Console.WriteLine()
            Next
        End If


    End Sub

End Module
