Public Class Form3
    Dim cnn As New OleDb.OleDbConnection

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\Accounts.mdb"
        lblCash.Text = Form1.txtUser.Text
        Form1.txtUser.Text = ""
        Form1.txtPass.Text = ""
        getNames()
        txtPrice.Enabled = False
        txtDesc.Enabled = False
        txtItmName.Enabled = False
        txtAmt.Enabled = False
        Button1.Enabled = False
        btnSave.Enabled = False
        txtAvail.Enabled = False
        lblTrno.Text = (GetMaximumIndex() + 1).ToString.PadLeft(6, "0"c)
    End Sub

    Public Function GetMaximumIndex() As Integer
        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = "SELECT MAX(trans_no) FROM tblSales"
        Dim returnValue As Object
        Try
            returnValue = cmd.ExecuteScalar
        Finally
            cnn.Close()
        End Try
        If returnValue Is Nothing OrElse returnValue.GetType Is GetType(DBNull) Then
            Return -1
        Else
            Return CInt(returnValue)
        End If
        cnn.Close()
    End Function

    Public Sub getNames()
         Dim dataTab As New DataTable
        Dim ds As New DataSet
        ds.Tables.Add(dataTab)
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        Dim dataAdap As New OleDb.OleDbDataAdapter("select * from tblItems where itmStat='" & "active" & "'", cnn)
        dataAdap.Fill(dataTab)
        For Each datarow In dataTab.Rows
            cmbName.Items.Add(datarow(1))
        Next
        cnn.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        lbldate.Text = Date.Now.ToString("MMM dd, yyyy")
    End Sub

    Private Sub cmbName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbName.KeyDown
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tblItems " & _
                                             " WHERE itmName='" & cmbName.Text & "' and itmStat='" & "active" & "'", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        txtItmNo.Text = dt.Rows(0).Item("ItmNo")
        txtItmName.Text = dt.Rows(0).Item("itmName")
        txtDesc.Text = dt.Rows(0).Item("itmDesc")
        txtPrice.Text = dt.Rows(0).Item("itmPrice")
        txtAvail.Text = dt.Rows(0).Item("itmStocks")
        cnn.Close()
        txtQty.Focus()
    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        Dim allowchars As String = "1234567890."

        If allowchars.IndexOf(e.KeyChar) = -1 AndAlso Not e.KeyChar = ChrW(8) Then
            e.Handled = True
            MessageBox.Show("Numeric Only!")
            txtQty.Focus()
        End If
    End Sub
   
    Private Sub cmbName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbName.KeyPress
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tblItems " & _
                                             " WHERE itmName='" & cmbName.Text & "' and itmStat='" & "active" & "'", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        txtItmNo.Text = dt.Rows(0).Item("ItmNo")
        txtItmName.Text = dt.Rows(0).Item("itmName")
        txtDesc.Text = dt.Rows(0).Item("itmDesc")
        txtPrice.Text = dt.Rows(0).Item("itmPrice")
        txtAvail.Text = dt.Rows(0).Item("itmStocks")
        cnn.Close()
        txtQty.Focus()
    End Sub

    Private Sub cmbName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbName.KeyUp
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tblItems " & _
                                             " WHERE itmName='" & cmbName.Text & "' and itmStat='" & "active" & "'", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        txtItmNo.Text = dt.Rows(0).Item("ItmNo")
        txtItmName.Text = dt.Rows(0).Item("itmName")
        txtDesc.Text = dt.Rows(0).Item("itmDesc")
        txtPrice.Text = dt.Rows(0).Item("itmPrice")
        txtAvail.Text = dt.Rows(0).Item("itmStocks")
        cnn.Close()
        txtQty.Focus()
    End Sub

    Private Sub cmbName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbName.TextChanged
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tblItems " & _
                                             " WHERE itmName='" & cmbName.Text & "' and itmStat='" & "active" & "'", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        txtItmNo.Text = dt.Rows(0).Item("ItmNo")
        txtItmName.Text = dt.Rows(0).Item("itmName")
        txtDesc.Text = dt.Rows(0).Item("itmDesc")
        txtPrice.Text = dt.Rows(0).Item("itmPrice")
        txtAvail.Text = dt.Rows(0).Item("itmStocks")
        cnn.Close()
        txtQty.Focus()
        txtAmt.Text = ""
        txtQty.Text = ""
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtItmName.Text = ""
        txtDesc.Text = ""
        txtPrice.Text = ""
        txtAmt.Text = ""
        txtItmNo.Text = ""
        txtQty.Text = ""
        txtAvail.Text = ""
        cmbName.Items.Clear()
        getNames()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim flag As Boolean
        flag = False
        Dim item As String = txtItmNo.Text
        If txtItmNo.Text = "" Then
            MessageBox.Show("Item no is required!")
            txtItmNo.Focus()
        ElseIf txtItmName.Text = "" Then
            MessageBox.Show("Item name is required!")
            txtItmName.Focus()
        ElseIf txtPrice.Text = "" Then
            MessageBox.Show("Item price is required!")
            txtPrice.Focus()
        ElseIf txtQty.Text.ToString = "" Then
            MessageBox.Show("Quantity is needed!")
            txtQty.Focus()
        ElseIf txtDesc.Text = "" Then
            MessageBox.Show("Description is required!")
            txtDesc.Focus()
        Else
            If DataGridView1.Rows.Count > 0 Then
                For i = 0 To DataGridView1.Rows.Count - 1
                    Dim intItmNo As String = DataGridView1.Rows(i).Cells("itmNum").Value
                    If intItmNo = item Then
                        flag = True
                        MessageBox.Show("Error: Duplicating Item!")
                        btnClear.PerformClick()
                    End If
                Next
                If flag = False Then
                    DataGridView1.Rows.Add(txtItmNo.Text, txtItmName.Text, txtDesc.Text, txtPrice.Text, txtQty.Text, txtAmt.Text, txtAvail.Text)
                    MessageBox.Show("Item Successfully Added!")
                    computeAmount()
                    btnClear.PerformClick()
                    btnSave.Enabled = True
                    Button1.Enabled = True
                End If
            Else
                DataGridView1.Rows.Add(txtItmNo.Text, txtItmName.Text, txtDesc.Text, txtPrice.Text, txtQty.Text, txtAmt.Text, txtAvail.Text)
                MessageBox.Show("Item Successfully Added!")
                computeAmount()
                btnClear.PerformClick()
                btnSave.Enabled = True
                Button1.Enabled = True
            End If

        End If
    End Sub
    Public Sub computeAmount()
        Dim amtdue As Double = 0.0
        For index As Integer = 0 To DataGridView1.RowCount - 1
            amtdue += CDbl(DataGridView1.Rows(index).Cells(5).Value)
        Next
        lblDue.Text = Format(amtdue, "0.00")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For Each row As DataGridViewRow In DataGridView1.SelectedRows()
            DataGridView1.Rows.Remove(row)
        Next
        computeAmount()
        btnClear.PerformClick()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim cmd As New OleDb.OleDbCommand
        cnn.Open()
        cmd.Connection = cnn
        For i = 0 To DataGridView1.Rows.Count - 1
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value()
            Dim qty As Integer = DataGridView1.Rows(i).Cells(4).Value()
            Dim available As Integer = DataGridView1.Rows(i).Cells(6).Value()
            Dim newqty As Integer = available - qty
            cmd.CommandText = "UPDATE tblItems " & _
            " SET itmStocks='" & newqty & "'" & _
            " WHERE ItmNo='" & id & "'"
            cmd.ExecuteNonQuery()
        Next
        cnn.Close()
        Form7.Show()
    End Sub

    Public Sub Report()
            cnn.Open()
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cnn
            Dim Sno, sname, sdesc, sprice, sqty, samt, sdate, stime, cash, change, sdue As Object
            Dim tbl_test As New DataTable
            For i = 0 To DataGridView1.Rows.Add - 1 Step 1
                Sno = DataGridView1.Rows(i).Cells(0).Value()
                sname = DataGridView1.Rows(i).Cells(1).Value()
                sdesc = DataGridView1.Rows(i).Cells(2).Value()
                sprice = DataGridView1.Rows(i).Cells(3).Value()
                sqty = DataGridView1.Rows(i).Cells(4).Value()
                samt = DataGridView1.Rows(i).Cells(5).Value()
                sdate = lbldate.Text
                stime = lblTime.Text
                cash = Form7.txtCsh.Text
                change = Form7.lblChange.Text
                sdue = Form7.lblamtdue.Text
                cmd.CommandText = "insert into tblSales(trans_no,itmNum,itmName,itmDes,itmPrice,itmQty,itmAmt,Trans_date,Trans_time,Cashier,cash,change,itmAmtDue) " & _
                "values('" & lblTrno.Text & "','" & Sno & "','" & sname & "','" & sdesc & "','" & sprice & "','" & sqty & "','" & samt & "','" & sdate & "','" & stime & "','" & lblCash.Text & "','" & cash & "','" & change & "','" & sdue & "')"
                cmd.ExecuteNonQuery()
            Next
            cnn.Close()
            Form9.PrintPreviewDialog1.ShowDialog()
            MessageBox.Show("Thank You For Shopping! :) ")
            btnClear.PerformClick()
            lblDue.Text = "0.00"
            DataGridView1.Rows.Clear()
            btnSave.Enabled = False
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        Dim avail As Integer = txtAvail.Text
        If avail < CInt(Val(txtQty.Text)).ToString Then
            MessageBox.Show("Error: Your Stocks is " & txtAvail.Text, "Information Message")
            txtQty.Text = ""
            txtQty.Focus()
        Else
            Dim x As Double
            x = CDbl(Val(txtQty.Text)).ToString * CDbl(Val(txtPrice.Text)).ToString
            txtAmt.Text = CStr(x)
        End If
    End Sub

    Private Sub txtItmNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItmNo.KeyPress
        Dim allowchars As String = "1234567890."
        If allowchars.IndexOf(e.KeyChar) = -1 AndAlso Not e.KeyChar = ChrW(8) AndAlso Not e.KeyChar = ChrW(13) Then
            e.Handled = True
            MessageBox.Show("Numeric Only!")
            txtQty.Text = ""
            txtQty.Focus()
        End If
    End Sub

    Private Sub txtItmNo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtItmNo.TextChanged
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tblItems " & _
                                             " WHERE ItmNo='" & txtItmNo.Text & "' and itmStat='" & "active" & "'", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        Try
            txtItmName.Text = dt.Rows(0).Item("itmName")
            cmbName.SelectedItem = txtItmName.Text
            txtDesc.Text = dt.Rows(0).Item("itmDesc")
            txtPrice.Text = dt.Rows(0).Item("itmPrice")
            txtAvail.Text = dt.Rows(0).Item("itmStocks")
            txtQty.Focus()
            cnn.Close()
        Catch ex As Exception
            If txtItmNo.Text = "" Then
            Else
                txtItmName.Text = ""
                txtPrice.Text = ""
                cmbName.Items.Clear()
                txtDesc.Text = ""
                MessageBox.Show("Item No Not Found!")
                txtItmNo.Text = ""
                txtItmNo.Focus()
                getNames()
                cnn.Close()
            End If
        End Try
        txtAmt.Text = ""
        txtQty.Text = ""
    End Sub
End Class