Public Class Form7

    Dim cnn As New OleDb.OleDbConnection
    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblamtdue.Text = Form3.lblDue.Text
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\Accounts.mdb"
    End Sub

    Private Sub btnFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinish.Click
        If btnFinish.Text = "Cancel" Then
            Me.Close()
            Form3.Show()
        Else
            Form3.Report()
            Form3.lblTrno.Text = (Form3.GetMaximumIndex() + 1).ToString.PadLeft(6, "0"c)
        End If
        cnn.Close()
        Me.Close()
    End Sub

    Private Sub txtCsh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCsh.KeyPress
        Dim allowchars As String = "1234567890."

        If allowchars.IndexOf(e.KeyChar) = -1 AndAlso Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            MessageBox.Show("Numeric Only!")
        End If


    End Sub

    Private Sub txtCsh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCsh.TextChanged
        Dim change, amount As Decimal

        change = lblChange.Text
        amount = lblamtdue.Text
        Try
            If txtCsh.Text < amount Then
                If change < 0 Then
                    change = 0.0
                Else
                    lblChange.Text = "0.00"
                    btnFinish.Text = "Cancel"
                End If
            Else
                Dim ca As Decimal = txtCsh.Text
                Dim d As Decimal
                Decimal.TryParse(ca - amount, d)
                lblChange.Text = d.ToString
                btnFinish.Text = "Finish"
                btnFinish.Enabled = True
            End If
        Catch ex As Exception
            lblamtdue.Text = CStr(Form3.lblDue.Text)
        End Try
    End Sub
End Class