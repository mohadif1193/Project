Public Class Application
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Approval.Show()
        Me.Hide()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class