Public Class Form2

    Private Sub btnUsers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsers.Click
        Form6.Show()
    End Sub

    Private Sub btnItems_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnItems.Click
        Form5.Show()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Form4.Show()

    End Sub

    Private Sub btnRestock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestock.Click
        Form10.Show()
    End Sub
End Class