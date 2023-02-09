Imports System
Imports System.ComponentModel.DataAnnotations

Module Program
    Sub Main(args As String())
        Console.SetWindowSize(100, 50)
        Console.Write("Выберите задачу: 1 - Hline, 2 - Vline, 3 - Filrect, 4 - Rect")
        Dim N As Integer
        N = CInt(Console.ReadLine)
        Select Case N
            Case 1 : Hline(10, 10, 15)
            Case 2 : Vline(6, 5, 10)
            Case 3 : Fillrect(5, 5, 15, 10)

            Case 4 : Rect(5, 5, 20, 10)

        End Select

        'If N = 1 Then
        '    Hline(10, 10, 20)
        'ElseIf N = 2 Then
        '    Vline(6, 5, 10)
        'ElseIf N = 3 Then
        '    Fillrect(5, 5, 15, 10)
        'End If


        Console.Read()
    End Sub

    Sub Rect(leftX As Byte, topY As Byte, width As Byte, height As Byte)
        Hline(leftX, topY, width)
        Vline(leftX, topY, height)
        Hline(leftX, topY + height - 1, width)
        Vline(leftX + width - 1, topY, height)
    End Sub

    Sub Hline(leftX As Byte, topY As Byte, length As Byte)

        Console.SetCursorPosition(leftX, topY)


        For J As Byte = 1 To length

            Console.Write("0")

        Next

    End Sub

    Sub Vline(leftX As Byte, topY As Byte, wigth As Byte)

        Console.SetCursorPosition(leftX, topY)


        For i As Byte = 0 To wigth - 1

            Console.Write("0")
            Console.SetCursorPosition(leftX, topY + i)

        Next
    End Sub

    Sub Fillrect(leftX As Byte, topY As Byte, W As Byte, H As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i As Byte = 0 To H
            Hline(leftX, topY + i, W)
        Next
    End Sub

End Module
