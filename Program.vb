Imports System

Module Program
    Sub Main(args As String())
        Dim Variable As Integer
        Console.WriteLine("Menu")
        Do Until Variable = 4
            Console.WriteLine("Esta es ka opcion 1")
            Console.WriteLine("Esta es la opcion 2")
            Console.WriteLine("Opcion 3")
            Console.WriteLine("Salir")
            Variable = Console.ReadLine
            If Variable = 1 Then
                Console.WriteLine("Este es una opcion 1")
            ElseIf Variable = 2 Then
                Console.WriteLine("Este es una opcion 2")
            ElseIf Variable = 3 Then
                Console.WriteLine("Este es una opcion tres")
            ElseIf Variable = 4 Then
                Console.WriteLine("Este es opcion 3")
            End If
            Console.WriteLine("Esto es opcion 4")
        Loop
    End Sub
End Module
