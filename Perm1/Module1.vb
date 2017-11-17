Module Module1

    Sub Main()

        Dim S() As Char = {"A", "B", "C", "D"}

        Permutate(S, 0, 4)

        Console.ReadLine()

    End Sub

    Sub Permutate(ByRef S() As Char, L As Integer, R As Integer)

        If L = R Then
            For N = 0 To 3
                Console.Write(S(N))
            Next
            Console.WriteLine()
        Else
            For N = L To R - 1
                Swap(S, L, N)
                Permutate(S, L + 1, R)
                Swap(S, L, N)
            Next



        End If



    End Sub

    Sub Swap(ByRef S() As Char, Pos1 As Integer, Pos2 As Integer)

        Dim Temp As Char

        Temp = S(Pos1)
        S(Pos1) = S(Pos2)
        S(Pos2) = Temp

    End Sub

End Module
