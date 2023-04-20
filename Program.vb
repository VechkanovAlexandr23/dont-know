Imports System

Module Program
    Sub Main()
        Dim a, x, s, z, y As Double

        a = 121.3
        x = 0.75
        s = 0.393

        z = ((x * s) / 2) - (a ^ 2 / 2) * Math.Log(x + s)

        y = Math.Sqrt(Math.Abs(x ^ 2 - a ^ 2)) + Math.Tan(2 * a / x + 0.184) - z




        Console.WriteLine("y = {0}", y)
    End Sub
End Module
