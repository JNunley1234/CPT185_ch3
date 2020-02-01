Public Class frmTechJobFair
    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        lblInformation.Visible = True
        btnExit.Enabled = True
        btnDetails.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
