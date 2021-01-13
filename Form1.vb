Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        txtName.Text = "Hello " & txtName.Text
    End Sub

    Private Sub txtMessage_Click(sender As Object, e As EventArgs) Handles txtMessage.Click
        MessageBox.Show("Hello " & txtName.Text,
                        "Hello " & txtName.Text)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click
        Try
            Dim firstNum As Integer = CInt(txtAddValue1.Text)
            Dim secondNum As Integer = CInt(txtAddValue2.Text)
            Dim sum = firstNum + secondNum

            txtSumAnswer.Text = CStr(sum)

        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter numbers to sum",
                            "Error")

            Console.WriteLine("InvalidCastExcpetion Occured")

        Catch ex As Exception
            MessageBox.Show("Unkown Error Occured",
                            "Error")

            Console.WriteLine("UnkownException Occured")
        End Try
    End Sub

    Private Sub btnDivideValues_Click(sender As Object, e As EventArgs) Handles btnDivideValues.Click
        Dim firstNum As Decimal = CDec(txtDivide1.Text)
        Dim secondNum As Decimal = CDec(txtDivide2.Text)
        Dim intSolution As Integer = CType(firstNum / secondNum, Integer)

        txtDivAnswer.Text = CStr(intSolution)


    End Sub
End Class

'Integers -2147483648 - 2147483648
'Long
'Decimal (Precise to 29 Dpoints)
'Double (Non-Precise)
'Boolean