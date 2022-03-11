Module f28ex2
    Sub Main(args As String())
        Dim nome As String
        Dim i As Integer
        Dim nome1() As Char

        Console.WriteLine("Insira um nome:")
        nome = Console.ReadLine()
        ReDim nome1(Len(nome) - 1)
        nome1 = nome.ToCharArray
        Console.Write(nome1(Len(nome) - 1))
        esperaAlt()













    End Sub
End Module
