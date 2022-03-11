Module f28ex5
    Sub Main(args As String())
        Dim palavra As String
        Dim palavra1() As Char
        Dim i As Byte

        Console.WriteLine("Insira uma palavra:")
        palavra = Console.ReadLine()
        palavra1 = palavra.ToCharArray
        For i = 0 To Len(palavra) - 1
            If i Mod 2 = 0 Then
                Console.Write(LCase(palavra1(i)))

            End If

        Next

    End Sub

End Module
