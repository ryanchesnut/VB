Imports System, System.Numerics, System.Math

Module Problem5 
    Public Function run()
        Dim numberFound As Boolean = false 
        Dim number As BigInteger = 1 

        while Not(numberFound)    
            'Console.WriteLine(number)
            For i = 1 to 20 
                If number Mod i <> 0 Then 
                    number = number + 1
                    Exit For
                End If 
                If i = 20 Then 
                    numberFound = true
                End if 
            Next 
        End While
        return number 
    End Function 
End Module 