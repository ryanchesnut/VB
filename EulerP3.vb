Imports System, System.Numerics, System.Math

Module Problem3 
    Public Function run() As BigInteger
        Dim numberToFactor As BigInteger = 600851475143 
        Dim upperBound As BigInteger = Math.Floor(Math.Exp(BigInteger.Log(numberToFactor) / 2))
        Dim largestFactor As Integer = 0 
            For i As BigInteger = 1 To upperBound
                If isPrime(i) And ( numberToFactor Mod i = 0 ) And i > largestFactor Then 
                    largestFactor = i
                End If 
            Next 
        Return largestFactor
    End Function

    Public Function isPrime(ByVal num) As Boolean
        Dim upperBound As BigInteger = Math.Floor(Math.Exp(BigInteger.Log(num) / 2))
            For i As BigInteger = 2 To upperBound - 1
                If num Mod i = 0 Then 
                    Return false
                End If 
            Next 
        Return true 
    End Function 
End Module 