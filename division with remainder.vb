Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("����� �����, ������� ����� ���������:")
        Dim input, sm, dm, m, remainder As Decimal
        input = Console.ReadLine()
        m = input \ 100
        remainder = input Mod 100
        dm = remainder \ 10
        sm = remainder Mod 10
        Console.WriteLine("{0} �� ���: {1} �, {2} ��, {3} ��", input, m, dm, sm)
    End Sub
End Module
