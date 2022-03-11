'4. Cria um programa que coloca um espaço depois de cada caracter NÃO ESPAÇO da string

Module f28ex4
    Sub Main(args As String())
        Dim palavra As String
        Dim palavra1() As Char
        Dim i As Byte

        Console.WriteLine("Insira uma palavra:")
        palavra = Console.ReadLine()
        ReDim palavra1(Len(palavra) - 1)
        Console.Clear()
        palavra1 = palavra.ToCharArray

        For i = 0 To Len(palavra) - 1
            Console.Write(palavra1(i))
            If palavra1(i) <> " " Then
                Console.Write(" ")
            End If
        Next
        esperaAlt()



    End Sub
End Module
