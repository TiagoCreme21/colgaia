Module f28ex3
    Sub Main(args As String())
        Dim palavra As String
        Dim palavra1() As Char
        Dim i As Byte

        Console.Write("Insira uma palavra:")
        palavra = Console.ReadLine()
        ReDim palavra1(Len(palavra) - 1)
        palavra1 = palavra.ToCharArray
        Console.Write(palavra1(0))
        For i = 1 To Len(palavra) - 1
            If palavra1(i) <> palavra1(i - 1) Then
                Console.Write(palavra1(i))
            End If
        Next










    End Sub
End Module
