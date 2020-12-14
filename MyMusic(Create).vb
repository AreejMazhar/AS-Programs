Module Module1

    Sub Main()
        Dim CDtitle As String
        Dim CDArtist As String
        Dim CDLocation As String
        Dim MusicRecord As String

        FileOpen(1, "\MyMusic.txt", OpenMode.Output)

        For x = 1 To 15
            Console.Write("Enter Title of CD: ")
            CDtitle = Console.ReadLine()
            CDtitle = CDtitle & Space(40 - Strings.Len(CDtitle)) 'Fixed length of the string is 40
            Debug.Print("*" & CDtitle & "*")

            Console.Write("Enter Artist of CD: ")
            CDArtist = Console.ReadLine()
            CDArtist = CDArtist & Space(40 - Strings.Len(CDArtist)) 'Fixed length of the string is 40
            Debug.Print("*" & CDArtist & "*")

            Console.Write("Enter Location of CD: ")
            CDLocation = Console.ReadLine()
            CDLocation = CDLocation & Space(8 - Strings.Len(CDLocation)) 'Fixed length of the string is 8
            Debug.Print("*" & CDLocation & "*")

            MusicRecord = (CDtitle & "*" & CDArtist & "*" & CDLocation)
            WriteLine(1, MusicRecord)
        Next

        FileClose(1)
        Console.WriteLine("Your file, MyMusic, has been created.")
        Console.ReadLine()

    End Sub

End Module
