Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("������� ������")
        Dim str As String
        Dim spaces, signs, vowels, consonants As Integer

        str = Console.ReadLine()

        For i As Integer = 0 To str.Length - 1
            Select Case Asc(str.Chars(i))
                Case 32
                    spaces += 1
                Case 33 To 48, 59 To 64, 91 To 96, 123 To 126
                    signs += 1
                Case 65, 69, 73, 79, 85, 89, 97, 101, 105, 111, 117, 121
                    vowels += 1
                Case 66 To 68, 70 To 72, 74 To 78, 80 To 84, 86 To 88, 90, 98 To 100, 102 To 104, 106 To 110, 112 To 116, 118 To 120, 122
                    consonants += 1
            End Select
        Next

        Console.WriteLine("� ������ {0} ��������", spaces)
        Console.WriteLine("� ������ {0} ������ ����������", signs)
        Console.WriteLine("� ������ {0} �������", vowels)
        Console.WriteLine("� ������ {0} ���������", consonants)
    End Sub
End Module
