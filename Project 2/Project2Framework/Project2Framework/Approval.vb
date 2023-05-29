Public Class Approval
    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click


        Dim LoanAmount As Double
        Dim InterestRate As Double
        Dim Interest As Double
        Dim FutureValue As Double
        Dim Periods As Double
        Dim i As Double
        Dim p As Double

        Try
            LoanAmount = CDbl(txtAmount.Text)
        Catch ex As Exception
            MsgBox("The value you entered for the " & "loan amount is not valid")
        End Try

        Try
            InterestRate = CDbl(txtInterest.Text)
        Catch ex As Exception
            MsgBox("Wrong Value: The interest rate must " & "be a value between 0 and 100")
        End Try

        Try
            Periods = CDbl(txtPeriods.Text)
        Catch ex As Exception
            MsgBox("You entered an invalid value for the periods")
        End Try

        i = InterestRate / 100
        p = Periods
        Interest = LoanAmount * i * p
        FutureValue = LoanAmount + Interest

        txtCurrent.Text = Interest.ToString("C")
        txtFuture.Text = FutureValue.ToString("C")
    End Sub

    Private Sub Approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAmount.Text = Application.txtAmount.Text
    End Sub

    Private Sub Reject_Click(sender As Object, e As EventArgs) Handles Reject.Click
        Application.Show()
        Me.Hide()
    End Sub

    Private Sub Proceed_Click(sender As Object, e As EventArgs) Handles Proceed.Click
        RiskLevel.Show()
        Me.Hide()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class