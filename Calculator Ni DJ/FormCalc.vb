' Use SetResultText() when changing the text of the result to prevent alignment and scroll changes
Imports System.ComponentModel

Public Class FormCalc

    Private Sub ZeroClick(sender As Object, e As EventArgs) Handles btn_0.Click
        If (GetCurrentOperand().Equals("0")) Then
            'Do Nothing - no first trailing zeros
        Else
            SetResultText(tbResult.Text + btn_0.Text)
        End If
        btn_equals.Focus()
    End Sub

    Private Sub PointClick(sender As Object, e As EventArgs) Handles btn_point.Click
        If (GetCurrentOperand().Contains(".")) Then
            'Do Nothing - Only 1 decimal point is allowed
        Else
            If (IsOperationPending()) Then
                btn_0.PerformClick()
            End If
            SetResultText(tbResult.Text + btn_point.Text)
        End If
        btn_equals.Focus()
    End Sub

    Private Sub NumberClick(sender As Object, e As EventArgs) Handles btn_1.Click, btn_2.Click, btn_3.Click, btn_4.Click, btn_5.Click, btn_6.Click, btn_7.Click, btn_8.Click, btn_9.Click
        'Click event listener for all number buttons except 0
        Dim button As Button = DirectCast(sender, Button)

        If (GetCurrentOperand().Equals("0")) Then
            SetResultText(tbResult.Text.Substring(0, tbResult.Text.Length - 1) + button.Text)
        Else
            SetResultText(tbResult.Text + button.Text)
            End If
        btn_equals.Focus()
    End Sub

    Private Sub OperatorClick(sender As Object, e As EventArgs) Handles btn_multiply.Click, btn_divide.Click, btn_add.Click, btn_subtract.Click
        Dim button As Button = DirectCast(sender, Button)
        'Does short circuit evaluation using AndAlso to prevent ArgumentOutOfRangeException 
        'when dealing with short-lengthed expression 
        If (tbResult.Text.Contains(" ") AndAlso (IsOperator(tbResult.Text.ElementAt(tbResult.Text.Length - 2)))) Then
            SetResultText(tbResult.Text.Substring(0, tbResult.Text.Length - 2) & button.Text + " ")
        Else
            SetResultText(tbResult.Text & " " & button.Text + " ")
        End If
        btn_equals.Focus()
    End Sub

    Function GetFirstIndexOfLastOperand() As Integer

        For x As Integer = tbResult.Text.Length - 1 To 0 Step -1
            Dim current As Char = tbResult.Text.ElementAt(x)
            If ((Not Char.IsDigit(current)) And (Not current.ToString().Equals("."))) Then
                Return x + 1
            End If
        Next
        Return -1
    End Function

    Function GetCurrentOperand() As String
        If (tbResult.Text.Equals("0")) Then
            Return "0"
        ElseIf (HasOperator(tbResult.Text)) Then
            For x As Integer = tbResult.Text.Length - 1 To 0 Step -1
                Dim current As Char = tbResult.Text.ElementAt(x)
                If (IsOperator(current)) Then
                    Return tbResult.Text.Substring(x + 2)
                End If
            Next
        Else
            Return tbResult.Text
        End If

        Return ""
    End Function

    Function IsOperator(c As Char) As Boolean
        If (c = "*" Or c = "/" Or c = "+" Or c = "-") Then
            Return True
        Else
            Return False
        End If

    End Function

    Function HasOperator(expression As String) As Boolean
        If (expression.Contains("*") Or expression.Contains("/") Or expression.Contains("-") Or expression.Contains("+")) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btn_equals_Click(sender As Object, e As EventArgs) Handles btn_equals.Click

        If (HasDivideByZero(tbResult.Text)) Then
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Exclamation) 'Error sound
            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Reset()
        Else
            Try
                Dim result = New DataTable().Compute(tbResult.Text, Nothing)
                If (result.ToString().Contains("E")) Then 'If scientific notation, add parentheses
                    result = result.ToString().Insert(0, "(")
                    result = result.ToString().Insert(result.ToString().Length, ")")
                End If
                SetResultText(result)
            Catch syntaxError As SyntaxErrorException
                MessageBox.Show("Syntax Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Reset()
            Catch uException As Exception
                Dim message As String = uException.Message & vbCrLf & vbCrLf & "Stacktrace: " & uException.StackTrace
                MessageBox.Show("Exception occured: " & vbCrLf & message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Reset()
            End Try
        End If
    End Sub

    Function HasDivideByZero(expression As String) As Boolean
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

    Private Sub Reset()
        SetResultText("0")
    End Sub

    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click
        'Scientific Notation Issue
        If (tbResult.Text.Equals("0")) Then
            'Do Nothing
        ElseIf (IsOperationPending()) Then
            SetResultText(tbResult.Text.Substring(0, tbResult.Text.Length - 3))
        ElseIf (tbResult.Text.Contains(")") And tbResult.Text.Contains("(")) Then
            SetResultText(tbResult.Text.Substring(1, tbResult.Text.Length - 2))
        Else
            If (tbResult.Text.Length.Equals(1)) Then
                SetResultText("0")
            Else
                SetResultText(tbResult.Text.Substring(0, tbResult.Text.Length - 1))
            End If
        End If
        btn_equals.Focus()
    End Sub

    Private Sub btn_clear_all_Click(sender As Object, e As EventArgs) Handles btn_clear_all.Click
        Reset()
        btn_equals.Focus()
    End Sub

    Private Function IsOperationPending() As Boolean
        Return String.IsNullOrEmpty(GetCurrentOperand())
    End Function

    Private Sub SetResultText(value As String)
        'Since richtextbox doesn't support text alignment,
        'This method aligns the text using selection alignment
        'This, however, should be done whenever its text is to be changed 
        tbResult.Text = value
        tbResult.SelectAll()
        tbResult.SelectionAlignment = HorizontalAlignment.Right

        'This will set the scrollbar to right, thats how calculator works isn't?
        tbResult.ScrollToCaret()
    End Sub

    Private Sub MinimizeApp(sender As Object, e As EventArgs) Handles lbl_maximize.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub CloseApp(sender As Object, e As EventArgs) Handles lbl_close.Click
        Environment.Exit(0)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetResultText("0")
        KeyPreview = True
    End Sub

#Region "Code snippet to allow movement of borderless form"
    Private _isFormBeingDragged As Boolean = False
    Private _mouseDownX As Integer
    Private _mouseDownY As Integer
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then
            _isFormBeingDragged = True
            _mouseDownX = e.X
            _mouseDownY = e.Y
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            _isFormBeingDragged = False
        End If
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove

        If _isFormBeingDragged Then
            Dim temp As Point = New Point()

            temp.X = Location.X + (e.X - _mouseDownX)
            temp.Y = Location.Y + (e.Y - _mouseDownY)
            Location = temp
            temp = Nothing
        End If
    End Sub
#End Region

    Private Sub FormCalc_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim k As Keys = e.KeyCode
        If (k = Keys.NumPad0 Or k = Keys.D0) Then
            btn_0.PerformClick()
        ElseIf (k = Keys.NumPad1 Or k = Keys.D1) Then
            btn_1.PerformClick()
        ElseIf (k = Keys.NumPad2 Or k = Keys.D2) Then
            btn_2.PerformClick()
        ElseIf (k = Keys.NumPad3 Or k = Keys.D3) Then
            btn_3.PerformClick()
        ElseIf (k = Keys.NumPad4 Or k = Keys.D4) Then
            btn_4.PerformClick()
        ElseIf (k = Keys.NumPad5 Or k = Keys.D5) Then
            btn_5.PerformClick()
        ElseIf (k = Keys.NumPad6 Or k = Keys.D6) Then
            btn_6.PerformClick()
        ElseIf (k = Keys.NumPad7 Or k = Keys.D7) Then
            btn_7.PerformClick()
        ElseIf (k = Keys.NumPad8 Or k = Keys.D8) Then
            btn_8.PerformClick()
        ElseIf (k = Keys.NumPad9 Or k = Keys.D9) Then
            btn_9.PerformClick()
        ElseIf (k = Keys.Return) Then
            btn_equals.PerformClick()
        ElseIf (k = Keys.Multiply) Then
            btn_multiply.PerformClick()
        ElseIf (k = Keys.Divide Or k = Keys.OemBackslash) Then
            btn_divide.PerformClick()
        ElseIf (k = Keys.Add Or k = Keys.Oemplus) Then
            btn_add.PerformClick()
        ElseIf (k = Keys.Subtract Or k = Keys.OemMinus) Then
            btn_subtract.PerformClick()
        ElseIf (k = Keys.OemPeriod Or k = Keys.OemPeriod) Then
            btn_point.PerformClick()
        ElseIf (k = Keys.Back) Then
            btn_del.PerformClick()
        End If
    End Sub

 

End Class
