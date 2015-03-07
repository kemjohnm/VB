Public NotInheritable Class SplashScreen2

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub SplashScreen2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.PerformStep()

        If (ProgressBar1.Value < 20) Then
            Label2.Text = "Computer Name:" & My.Computer.Info.OSFullName.ToString & ProgressBar1.Value & "%"
        Else
            If ProgressBar1.Value > 20 And ProgressBar1.Value < 50 Then
                Label2.Text = My.Computer.Info.OSVersion.ToString
            Else
                If ProgressBar1.Value > 50 And ProgressBar1.Value < 80 Then
                    Label2.Text = My.User.Name.ToString
                Else
                    If ProgressBar1.Value < 100 Then
                        Label2.Text = My.Settings.AccountsConnectionString.ToString
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
