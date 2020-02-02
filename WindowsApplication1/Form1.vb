Public Class frmJobTechFair
    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        lblDetails.Visible = True
        btnExit.Enabled = True
        btnDetails.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
