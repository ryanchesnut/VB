Imports System, System.Numerics, System.Math

Module Problem6
    Public Function run()
        Dim upperBound As Integer = 100
        Dim squareSum = 0 
        Dim sumSquare = 0

        For i = 1 To upperBound
            sumSquare = sumSquare + i ^ 2
            squareSum = squareSum + i 
        Next 
        
        return (squareSum ^ 2) - sumSquare
    End Function 
End Module 