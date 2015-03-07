Imports System.Data.OleDb

Public Class Form10
    Dim con As New OleDbConnection
    Dim counter As Integer
    Dim srch As String
    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.TblSalesTableAdapter.Fill(Me.AccountsDataSet.tblSales)
        con.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\Accounts.mdb"
        Dim cmd As New OleDbCommand
        cmd.Connection = con

        Dim total As Double
        Dim arrayDate(DataGridView1.Rows.Count) As String
        Dim ctr As Integer = 0
        Dim ctr1 As Integer = 0

        For i = 0 To DataGridView1.Rows.Count - 1
            Dim dit As String = DataGridView1.Rows(i).Cells(0).Value()
            If ctr1 = 0 Then
                'MessageBox.Show(dit)
                arrayDate(ctr1) = dit
                ctr1 = ctr1 + 1
            Else
                For l = 0 To ctr1
                    If arrayDate(l) = dit Then
                        'MessageBox.Show(dit & " " & arrayDate(l))
                        ctr = 0
                        Exit For
                    Else
                        ctr = 1
                    End If
                Next
                If ctr = 1 Then
                    'MessageBox.Show(dit)
                    arrayDate(ctr1) = dit
                    ctr1 = ctr1 + 1
                    ctr = 0
                End If
            End If
        Next

        Dim dot As String
        For b = 0 To ctr1 - 1
            dot = arrayDate(b)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(0).Value() = dot Then
                    Dim tempTotal As Double = DataGridView1.Rows(i).Cells(7).Value()
                    total = total + tempTotal
                End If
            Next
            Dim peso As String = "ᵽ "
            DataGridView2.Rows.Add(arrayDate(b), peso.ToUpper & total)
        Next
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False

    End Sub

  
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If srch = "date" Then
            con.Open()

            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter("SELECT * from tblSales where Trans_date='" & DateTimePicker1.Text & "'", con)

            da.Fill(dt)

            DataGridView1.DataSource = dt

            DataGridView1.Refresh()

            da.Dispose()

            con.Close()
        ElseIf srch = "itmname" Then
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter("SELECT * from tblSales where itmName='" & txtSearch.Text & "'", con)

            da.Fill(dt)

            DataGridView1.DataSource = dt

            DataGridView1.Refresh()

            da.Dispose()

            con.Close()
        ElseIf srch = "transNo" Then
            Dim dt As New DataTable
            Dim da As New OleDbDataAdapter("SELECT * from tblSales where trans_no=" & txtSearch.Text, con)

            da.Fill(dt)

            DataGridView1.DataSource = dt

            DataGridView1.Refresh()

            da.Dispose()

            con.Close()
        ElseIf srch = "salesDate" Then

        Else
            MessageBox.Show("Please Select Your Action First!", "Error Message")

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        srch = "date"
        DateTimePicker1.Visible = True
        txtSearch.Enabled = False

    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("SELECT * from tblSales", con)

        da.Fill(dt)

        DataGridView1.DataSource = dt

        DataGridView1.Refresh()

        da.Dispose()

        con.Close()
        txtSearch.Text = ""
      
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        srch = "itmname"
        txtSearch.Enabled = True
        DateTimePicker1.Visible = False

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        srch = "transNo"
        DateTimePicker1.Visible = False
        txtSearch.Enabled = True

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        DateTimePicker2.Visible = True
        srch = "salesDate"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        DataGridView2.Rows.Clear()
        Dim cmd As New OleDbCommand
        cmd.Connection = con

        Dim total As Double
        Dim arrayDate(DataGridView1.Rows.Count) As String
        Dim ctr As Integer = 0
        Dim ctr1 As Integer = 0

        For i = 0 To DataGridView1.Rows.Count - 1
            Dim dit As String = DataGridView1.Rows(i).Cells(0).Value()
            If ctr1 = 0 Then
                'MessageBox.Show(dit)
                arrayDate(ctr1) = dit
                ctr1 = ctr1 + 1
            Else
                For l = 0 To ctr1
                    If arrayDate(l) = dit Then
                        'MessageBox.Show(dit & " " & arrayDate(l))
                        ctr = 0
                        Exit For
                    Else
                        ctr = 1
                    End If
                Next
                If ctr = 1 Then
                    'MessageBox.Show(dit)
                    arrayDate(ctr1) = dit
                    ctr1 = ctr1 + 1
                    ctr = 0
                End If
            End If
        Next

        Dim dot As String
        For b = 0 To ctr1 - 1
            dot = arrayDate(b)
            For i = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(0).Value() = dot Then
                    Dim tempTotal As Double = DataGridView1.Rows(i).Cells(7).Value()
                    total = total + tempTotal
                End If
            Next
            Dim peso As String = "ᵽ "
            DataGridView2.Rows.Add(arrayDate(b), peso.ToUpper & total)
        Next

    End Sub
End Class