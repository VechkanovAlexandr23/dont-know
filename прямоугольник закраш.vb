Imports System

Module Program
    Sub Main(args As String())
        Console.SetWindowSize(100, 50)
        Const brush As Char = "0"c
        Dim leftX, topY, length, heit As Byte
        'Будем рисовать горизонтальную линию.
        Console.Write("heit=")
        heit = Console.ReadLine
        Console.Write("leftX=")
        leftX = Console.ReadLine()
        Console.Write("topY=")
        topY = Console.ReadLine()
        Console.Write("length=")
        length = Console.ReadLine()

        'Рисуем 
        Console.SetCursorPosition(leftX, topY)
        For j = 0 To heit

            For i As Integer = 0 To length
                Console.Write(brush)
            Next
            Console.SetCursorPosition(leftX, topY + j)


        Next







    End Sub
End Module
