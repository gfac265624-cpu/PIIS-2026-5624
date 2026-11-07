Module Module1

    Sub Main()
        'Сума на числата от 1 до 100
        ' i% -> Integer 
        Dim sum As Integer = 0
        For index = 1 To 100
            sum += index
        Next
        Console.WriteLine($"Sum is {sum}.")
    End Sub

End Module
