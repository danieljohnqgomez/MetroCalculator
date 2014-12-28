
Class CalculatorTools
    Shared Function HasOperator(expression As String) As Boolean
        If (expression.Contains("*") Or expression.Contains("/") Or expression.Contains("-") Or expression.Contains("+")) Then
            Return True
        Else
            Return False
        End If
    End Function


    Shared Function GetCurrentOperand(result As String) As String
        If (result.Equals("0")) Then
            Return "0"
        ElseIf (HasOperator(result)) Then
            For x As Integer = result.Length - 1 To 0 Step -1
                Dim current As Char = result.ElementAt(x)
                If (IsOperator(current)) Then
                    Return result.Substring(x + 2)
                End If
            Next
        Else
            Return result
        End If
        Return ""
    End Function

    Shared Function IsOperator(c As Char) As Boolean
        If (c = "*" Or c = "/" Or c = "+" Or c = "-") Then
            Return True
        Else
            Return False
        End If
    End Function

    Shared Function HasDivideByZero(expression As String) As Boolean
        For x As Integer = 0 To expression.Length
            Try
                If (expression.ElementAt(x).ToString().Equals("/")) Then
                    If (expression.ElementAt(x + 2).ToString().Equals("0")) Then
                        Return True
                    End If
                End If
            Catch ex As ArgumentOutOfRangeException
                Return False
            End Try
        Next
        Return False
    End Function

    Shared Function IsOperationPending(result As String) As Boolean
        Return String.IsNullOrEmpty(GetCurrentOperand(result))
    End Function


End Class
