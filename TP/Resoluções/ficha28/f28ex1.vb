Module f28ex1
    Sub Main(args As String())
        Dim opt As Byte
        Dim frase1, frase2, frase3 As String

        Do
            menu_f28ex1(opt)
            Console.Clear()

            Select Case opt
                Case 1
                    Console.WriteLine("Insira três frases:")
                    frase1 = Console.ReadLine()
                    frase2 = Console.ReadLine()
                    frase3 = Console.ReadLine()
                Case 2
                    If frase1 = frase2 Or frase1 = frase3 Or frase2 = frase3 Then
                        Console.WriteLine("Existem frases iguais.")
                    End If
                Case 3
                    If Len(frase1) > Len(frase2) And Len(frase1) > Len(frase3) Then
                        Console.WriteLine("A frase 1 á a maior")
                    EndIf   
                    If Len(frase2) > Len(frase1) And Len(frase2) > Len(frase3) Then
                        Console.WriteLine("A frase 2 é a maior")   
                    EndIf
                    If Len(frase3) > Len(frase1) And Len(frase3) > Len(frase2) Then
                        Console.WriteLine("A frase 3 é a maior")
                    EndIf
                Case 4
                    'Fazer o "case4"
            End Select







        Loop



    End Sub

End Module
