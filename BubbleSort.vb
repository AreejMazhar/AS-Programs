Module Module1

    Sub Main()
        Dim Temp As String
        Dim Swap As Boolean
        Dim I As Integer
        Dim FirstID As Integer
        Dim SecondID As Integer
        Dim UpperBound As Integer
        Dim UserNameArray = {"432145Dean", "743235Nathan", "544643Zach", "244652Vale", "943245Shu", "332565Elton"}

        UpperBound = 5

        Do
            Swap = False
            For I = 0 To (UpperBound - 1)
                FirstID = Left(UserNameArray(I), 6)
                SecondID = Left(UserNameArray(I + 1), 6)
                If FirstID > SecondID Then
                    Temp = UserNameArray(I)
                    UserNameArray(I) = UserNameArray(I + 1)
                    UserNameArray(I + 1) = Temp
                    Swap = True
                End If
            Next
        Loop Until (Swap = False)

        For I = 0 To 5
            Console.WriteLine("Username" & ":" & UserNameArray(I))
        Next
        Console.ReadKey()

    End Sub

End Module
