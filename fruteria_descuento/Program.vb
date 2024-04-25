Imports System

'Una frutería ofrece manzanas con descuentos según la siguiente tabla:

'Kilos comprados
'0-2
'2.01-5
'5.01-10
'10.01-15
'15.01- en adelante

'Descuento:
'0%
'10%
'15%
'20%
'25%

'Determinar cuánto pagara una persona que compre manzanas en esa fruteria

'Con los comandos Dim, console.readline, console write

Module Program
    Sub Main(args As String())
        Dim kilos As Single
        Dim descuento_porcentaje As Single
        Dim monto_total As Single
        Dim descuento_monto As Single
        Dim total As Single



        Console.WriteLine("Fruteria Hernandez")
        Console.WriteLine("Precio de el kilo de manzana 96 lempiras")
        Console.WriteLine("Ingrese la cantidad de kilos de manzanas a comprar: ")

        'Try catch ayuda a manejar errores de ejecucion
        'por ejemplo ingresar una letra en vez de un numero cuando el 
        'tipo es single y no string causando un error de ejecucion
        Try

            kilos = Console.ReadLine()
        Catch
            Try
                Console.WriteLine("Ingrese numeros no letras")
                kilos = Console.ReadLine()

            Catch
                Console.WriteLine("Adios, no ingresa la cantidad de kilos")

            End Try

        End Try




        If kilos > 0.0 And kilos <= 2.0 Then

            descuento_porcentaje = 0.0

        ElseIf kilos >= 2.1 And kilos <= 5.0 Then

            descuento_porcentaje = 0.1

        ElseIf kilos >= 5.01 And kilos <= 10.0 Then
            descuento_porcentaje = 0.15

        ElseIf kilos <= 10.01 And kilos <= 15.0 Then
            descuento_porcentaje = 0.2

        ElseIf kilos >= 15.01 Then
            descuento_porcentaje = 0.25
        End If



        total = kilos * 96

        descuento_monto = total * descuento_porcentaje

        monto_total = total - descuento_monto

        Console.WriteLine("Total:")
        Console.WriteLine(total)

        Console.WriteLine("Descuento:")
        Console.WriteLine(descuento_monto)

        Console.WriteLine("Monto total:")
        Console.WriteLine(monto_total)

    End Sub
End Module
