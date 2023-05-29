Public Class Dashboard
    Private Sub BTNApplication_Click(sender As Object, e As EventArgs) Handles BTNApplication.Click
        Application.Show()
        Me.Hide()
    End Sub

    Private Sub BTNApproval_Click(sender As Object, e As EventArgs) Handles BTNApproval.Click
        Approval.Show()
        Me.Hide()
    End Sub

    Private Sub BTNRiskLvl_Click(sender As Object, e As EventArgs) Handles BTNRiskLvl.Click
        RiskLevel.Show()
        Me.Hide()
    End Sub

    Private Sub BTNDataVisual_Click(sender As Object, e As EventArgs) Handles BTNDataVisual.Click
        DataVisualization.Show()
        Me.Hide()
    End Sub
End Class
