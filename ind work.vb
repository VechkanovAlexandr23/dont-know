Imports System

Module Program
    Sub Main(args As String())
        Dim productName As String
        Dim clockSpeed As Integer
        Dim price As Double

        While True

            Console.WriteLine("������� ������������� ���������� � ��� ������")
            productName = Console.ReadLine()

            If productName.ToLower() = "exit" Then
                Exit While
            End If

            Console.WriteLine("������� �������� ������� ����������")
            clockSpeed = Console.ReadLine()
            Console.WriteLine("������� ����")
            price = Console.ReadLine()

            Console.WriteLine("������������, �������� �������: {0}, {1} GHz", productName, clockSpeed)
            Console.WriteLine("����: {0} ���", FormatNumber(price, 2))
        End While
    End Sub
End Module
