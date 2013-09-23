Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        If Not (IsNumeric(txtFirstNum.Text) And IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: Please type a number")
            Return
        End If

        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        If (num1 < 0) Or (num2 < 0) Then
            MessageBox.Show("Error: Please type a positive number")
            Return
        End If

        If (num1 > num2) Then
            largerNum = num1
            txtResult.Text = "The larger number is " & largerNum
        ElseIf (num1 < num2) Then
            largerNum = num2
            txtResult.Text = "The larger number is " & largerNum
        Else
            txtResult.Text = "They are equal"
        End If

    End Sub
End Class
