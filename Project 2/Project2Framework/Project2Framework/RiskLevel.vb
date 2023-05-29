Public Class RiskLevel
    Private Sub Proceed_Click(sender As Object, e As EventArgs) Handles Proceed.Click
        DataVisualization.Show()
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub RiskLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class