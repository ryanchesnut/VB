Imports System 

' If we list all the natural numbers below 10
' that are multiples of 3 or 5, we get 
' 3, 5, 6 and 9. The sum of these multiples is 23.
' Find the sum of all the multiples of 3 or 5 below 1000.

Module Problem1 
    Public Function run() As Integer
        Dim upperBound = 1000
        Dim sum As Integer = 0
        For i = 0 to upperBound - 1
            if i Mod 3 = 0 Or i Mod 5 = 0 Then
                sum = sum + i 
            End if 
        Next 
        Return sum  
    End Function 
End Module