Imports System.Data.OleDb
Imports System
Public Class Form1
    Dim con As New OleDbConnection
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtUser.Focus()
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source = Accounts.mdb"
    End Sub

    Public Function ask()
        Dim dataTab As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dataTab)
        con.Open()
        Dim dataAdap As New OleDbDataAdapter("select * from tblAccounts", con)
        dataAdap.Fill(dataTab)
        For Each datarow In dataTab.Rows
            If txtUser.Text = datarow.Item(1) And txtPass.Text = datarow(2) Then
                con.Close()
                Return True
            End If
        Next
        con.Close()
        Return False
    End Function

    Public Function Pos()
        Dim dataTab As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dataTab)
        con.Open()
        Dim dataAdap As New OleDbDataAdapter("select * from tblAccounts", con)
        dataAdap.Fill(dataTab)
        For Each datarow In dataTab.Rows
            If txtUser.Text = datarow.Item(1) And txtPass.Text = datarow(2) And "admin" = datarow(3) Then
                con.Close()
                Return True
            End If
        Next
        con.Close()

        Return False
    End Function
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If ask() = True Then
            MessageBox.Show("login Success!")
            If Pos() = True Then
                SplashScreen1.Show()
                txtPass.Text = ""
                txtUser.Text = ""
                txtUser.Focus()
                Me.Opacity = 0
            Else
                SplashScreen2.Show()
                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                Dim da As New OleDbDataAdapter("SELECT * FROM tblAccounts " & _
                                                     " WHERE accUser='" & txtUser.Text & "'", con)
                Dim dt As New DataTable
                da.Fill(dt)
                txtUser.Text = dt.Rows(0).Item("accName")
                con.Close()
            End If
        Else
            MessageBox.Show("Username/Password Incorrect!")
            txtUser.Focus()
        End If
    End Sub
    Private Sub txtUser_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUser.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("Shutdown", "-r -t 00")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Are you sure you want to shutdown?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        System.Diagnostics.Process.Start("Shutdown", "-s -t 00")
    End Sub

End Class
