Public Class Form5
    Dim cnn As New OleDb.OleDbConnection
    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\Accounts.mdb"

        'get data into list
        Me.RefreshData()


    End Sub

    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT ItmNo as [Item No] , itmName as [Item Name], " & _
                                             "itmCat as [Categroy]  ,itmPrice as [Price]  , " & _
                                            "itmStat as [Status], itmStocks as [Stocks], " & _
                                            "itmDesc as [Description] from tblItems", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        DataGridView1.DataSource = dt

        'close connection
        cnn.Close()
    End Sub


    Private Sub SearchItem()
        cnn.Open()

        Dim dt As New DataTable("tblItems")
        Dim da As New OleDb.OleDbDataAdapter("SELECT ItmNo as [Item No] , itmName as [Item Name], " & _
                                             "itmCat as [Categroy]  ,itmPrice as [Price]  , " & _
                                            "itmStat as [Status], itmStocks as [Stocks], " & _
                                            "itmDesc as [Description] from tblItems where ItmNo='" & txtSearch.Text & "' or itmName='" & txtSearch.Text & "'", cnn)

        da.Fill(dt)

        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        da.Dispose()

        cnn.Close()



    End Sub
    Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("Numeric Only!")
            txtId.Text = ""
        End If
    End Sub

    Private Sub txtStocks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStocks.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("Numeric Only!")
            txtStocks.Text = ""
        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtId.Text = ""
        txtName.Text = ""
        txtCat.Text = ""
        txtPrice.Text = ""
        txtDesc.Text = ""
        txtStocks.Text = ""
        txtId.Tag = ""

        Me.btnUpd.Enabled = True
        'set button add to add label
        Me.btnAdd.Text = "Add"
        txtId.Enabled = True
        Me.txtId.Focus()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtId.Text = "" Then
            MessageBox.Show("Item No is Required!")
            txtId.Focus()
        ElseIf txtName.Text = "" Then
            MessageBox.Show("Item Name is Required!")
            txtName.Focus()
        ElseIf txtCat.Text = "" Then
            MessageBox.Show("Category is Required!")
            txtCat.Focus()
        ElseIf txtPrice.Text = "" Then
            MessageBox.Show("Price is Required!")
            txtPrice.Focus()
        ElseIf txtStocks.Text = "" Then
            MessageBox.Show("Stocks is Required!")
            txtStocks.Focus()
        ElseIf cmbStat.Text = "" Then
            MessageBox.Show("Status is Required!")
            cmbStat.Focus()
        Else
            btnAdd.Focus()
            Dim cmd As New OleDb.OleDbCommand
            If Not cnn.State = ConnectionState.Open Then
                'open connection if it is not yet open
                cnn.Open()
            End If

            cmd.Connection = cnn
            'check whether add new or update

            If txtId.Tag & "" = "" Then
                'add new 
                'add data to table
                cmd.CommandText = "INSERT INTO tblItems(ItmNo, itmName, itmCat, itmPrice, itmStat, itmStocks, itmDesc)" & _
                                " VALUES(" & txtId.Text & ",'" & txtName.Text & "','" & txtCat.Text & "','" & txtPrice.Text & "','" & _
                                cmbStat.Text & "','" & txtStocks.Text & "','" & txtDesc.Text & "')"
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Item No Already Exist!")
                    txtId.Focus()
                End Try

            Else
                'update data in table
                cmd.CommandText = "UPDATE tblItems " & _
                 " SET ItmNo=" & txtId.Text & _
                 ", itmName='" & txtName.Text & "'" & _
                  ", itmCat='" & txtCat.Text & "'" & _
                  ", itmPrice='" & txtPrice.Text & "'" & _
                   ", itmStat='" & cmbStat.Text & "'" & _
                    ", itmStocks='" & txtStocks.Text & "'" & _
                 ", itmDesc='" & txtDesc.Text & "'" & _
                  " WHERE ItmNo='" & txtId.Text & "'"
                cmd.ExecuteNonQuery()
            End If
            'refresh data in list
            RefreshData()
            'clear form
            btnClear.PerformClick()

            'close connection
            cnn.Close()

        End If
    End Sub

    Private Sub btnUpd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpd.Click

        If DataGridView1.Rows.Count > 0 Then
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim intItmNo As String = DataGridView1.SelectedRows(0).Cells("item no").Value
                'get data from database followed by student id
                'open connection
                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If
                'get data into datatable


                txtId.Text = intItmNo

                Dim dt As New DataTable
                Dim da As New OleDb.OleDbDataAdapter("SELECT * from tblItems where ItmNo='" & txtId.Text & "'", cnn)

                da.Fill(dt)

                txtId.Text = intItmNo
                txtId.Enabled = False
                txtName.Text = dt.Rows(0).Item("itmName")
                txtCat.Text = dt.Rows(0).Item("itmCat")
                txtPrice.Text = dt.Rows(0).Item("itmPrice")
                txtStocks.Text = dt.Rows(0).Item("itmStocks")
                cmbStat.Text = dt.Rows(0).Item("itmStat")
                txtDesc.Text = dt.Rows(0).Item("itmDesc")
                '
                'hide the id to be edited in TAG of txtid in case id is changed
                txtId.Tag = intItmNo
                'change button add to update
                btnAdd.Text = "Update"
                'disable button edit
                btnUpd.Enabled = False
                'close connection
                cnn.Close()
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchItem()

    End Sub


    Private Sub cmbCat_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbCat.KeyDown
        cnn.Open()

        Dim dt As New DataTable("tblItems")
        Dim da As New OleDb.OleDbDataAdapter("SELECT ItmNo as [Item No] , itmName as [Item Name], " & _
                                             "itmCat as [Categroy]  ,itmPrice as [Price]  , " & _
                                            "itmStat as [Status], itmStocks as [Stocks], " & _
                                            "itmDesc as [Description] from tblItems where itmCat='" & cmbCat.Text & "'", cnn)

        da.Fill(dt)

        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        da.Dispose()

        cnn.Close()
    End Sub



    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        RefreshData()
        txtSearch.Text = ""
    End Sub

  

    Private Sub LogOutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Form2.Close()
        Form1.Opacity = 100
        Form1.Show()

        Me.Close()
    End Sub

    Private Sub SalesLogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesLogToolStripMenuItem.Click
        Form8.Show()
    End Sub
End Class