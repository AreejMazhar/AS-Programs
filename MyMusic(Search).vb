Module Module1

    Sub Main()
        Dim CDTitle, CDArtist As String
        Dim MusicRecord, CDSearch As String
        Dim Total As Integer

        Total = 0

        FileOpen(1, My.Application.Info.DirectoryPath & "\MyMusic.txt", OpenMode.Input)
        Console.Write("Enter the location to search: ")
        CDSearch = Console.ReadLine()
        While Not EOF(1)
            Input(1, MusicRecord)
            If Right(MusicRecord, 8) = CDSearch Then
                CDTitle = (Left(MusicRecord, 40))
                CDArtist = (Mid(MusicRecord, 41, 40))
                Console.WriteLine(CDTitle & " " & CDArtist)
                Total = Total + 1
            End If
        End While
        Console.WriteLine(Total & " " & "Number of CDs were found in" & " " & CDSearch)
        Console.ReadLine()
        FileClose(1)
    End Sub
End Module
