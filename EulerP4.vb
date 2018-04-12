Imports System
'A palindromic number reads the same both ways. 
'The largest palindrome made from the product 
'of two 2-digit numbers is 9009 = 91 × 99.
'Find the largest palindrome made from 
'the product of two 3-digit numbers.

Module Problem4
    Public Function run()
        Dim numberOfDigits As Integer = 3 
        Dim upperBound = 999
        Dim largestPalindrome = 0 
        For i As Integer = upperBound To 1 Step -1
            For j As Integer = upperBound To 1 Step -1
                If isPalindrome((i * j).toString()) And i * j > largestPalindrome Then 
                    largestPalindrome = i * j 
                End If 
            Next 
        Next 
        return largestPalindrome
    End Function 

    Public Function isPalindrome(ByVal testString As String) As Boolean
        Dim stringArray() As Char = testString.toArray()
        Dim j = stringArray.Length - 1 
        For i As Integer = 0 To Math.Floor((stringArray.Length / 2) - 1)
            If Not(stringArray(i) = stringArray(j)) Then
                Return false 
            End If 
            j = j - 1
        Next 
        Return true
    End Function 
End Module