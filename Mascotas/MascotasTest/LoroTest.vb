
Module LoroTest

    Sub Main()
        Dim loro1 As Loro
        loro1 = New Loro

        'test de setters
        loro1.Nombre = "peperepe"
        loro1.FechaNac = #2/2/1993#
        loro1.Memoria.Enqueue("hola mundo")


        'test de getters

        Console.WriteLine("nombre: " & loro1.Nombre)
        Console.WriteLine("fecha de nacimiento: " & loro1.FechaNac)
        Console.WriteLine("edad: " & loro1.CalcularEdad(loro1.FechaNac))
        Console.WriteLine("Memoria: " & loro1.Memoria.Peek)
        Console.WriteLine("escuchando.. ")
        Dim aux As String = Console.ReadLine
        loro1.Escuchar(aux)
        Console.WriteLine("Memoria: " & loro1.Memoria.Peek)
        For Each palabras In loro1.Memoria
            Console.WriteLine("  {0}", palabras)
        Next palabras

        Console.ReadKey()


    End Sub

End Module
