Public Class Form4
    Dim cnn As New OleDb.OleDbConnection
    Dim x As Boolean
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\Accounts.mdb"
        Me.RefreshData()
        btnDI.Enabled = False
    End Sub
    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT ItmNo as [Item No] , itmName as [Item Name], " & _
                                             "itmCat as [Categroy]  ,itmPrice as [Price]  , " & _
                                            "itmStat as [Status], itmStocks as [Stocks], " & _
                                            "itmDesc as [Description] from tblItems where itmStat='" & "active" & "'", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        DataGridView1.DataSource = dt

        'close connection
        cnn.Close()
    End Sub
    Public Sub search()


        cnn.Open()

        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter("SELECT ItmNo as [Item No] , itmName as [Item Name], " & _
                                             "itmCat as [Categroy]  ,itmPrice as [Price]  , " & _
                                            "itmStat as [Status], itmStocks as [Stocks], " & _
                                            "itmDesc as [Description] from tblItems where ItmNo='" & txtItm.Text & "'", cnn)

        da.Fill(dt)

        DataGridView1.DataSource = dt
        DataGridView1.Refresh()

        da.Dispose()

        cnn.Close()


    End Sub

    Public Function check()


        Dim dataTab As New DataTable
        Dim ds As New DataSet

        ds.Tables.Add(dataTab)

        cnn.Open()

        Dim dataAdap As New OleDb.OleDbDataAdapter("select * from tblItems", cnn)
        dataAdap.Fill(dataTab)

        For Each datarow In dataTab.Rows

            If txtItm.Text = datarow.Item(0) Then
                cnn.Close()
                btnDI.Enabled = True
                Return True

            End If
        Next


        cnn.Close()
        x = True
        Return False
        btnDI.Enabled = False
    End Function
    Private Sub SearchItem()
        
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        'get data into datatable




        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter("SELECT * from tblItems where ItmNo='" & txtItm.Text & "' and itmStat='" & "active" & "'", cnn)

        da.Fill(dt)

        Try
            lblName.Text = dt.Rows(0).Item("itmName")
            lblCat.Text = dt.Rows(0).Item("itmCat")
            lblPrice.Text = dt.Rows(0).Item("itmPrice")
            lblStocks.Text = dt.Rows(0).Item("itmStocks")

            lblDesc.Text = dt.Rows(0).Item("itmDesc")
        Catch ex As Exception
            MessageBox.Show("Item already Deactivated")
            btnDI.Enabled = False
            txtItm.Text = ""
        End Try
        cnn.Close()


    End Sub


   
    Private Sub txtItm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtItm.KeyPress
        '   



        If check() = True Then
            SearchItem()


        Else
            lblCat.Text = ""
            lblDesc.Text = ""
            lblName.Text = ""
            lblPrice.Text = ""
            lblStocks.Text = ""
            btnDI.Enabled = False
        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblCat.Text = ""
        lblDesc.Text = ""
        lblName.Text = ""
        lblPrice.Text = ""
        lblStocks.Text = ""
        txtItm.Text = ""
    End Sub

    Private Sub btnOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOut.Click
        Form2.Close()
        Me.Close()
        Form1.Opacity = 100
        Form1.Show()
    End Sub

    Private Sub btnDI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDI.Click
        Dim cmd As New OleDb.OleDbCommand
        If Not cnn.State = ConnectionState.Open Then
            'open connection if it is not yet open
            cnn.Open()
        End If
        cmd.Connection = cnn

        cmd.CommandText = "UPDATE tblItems " & _
                " SET ItmNo=" & txtItm.Text & _
                ", itmName='" & lblName.Text & "'" & _
                 ", itmCat='" & lblCat.Text & "'" & _
                 ", itmPrice='" & lblPrice.Text & "'" & _
                  ", itmStat='" & "inactive" & "'" & _
                   ", itmStocks='" & lblStocks.Text & "'" & _
                ", itmDesc='" & lblDesc.Text & "'" & _
                 " WHERE ItmNo='" & txtItm.Text & "'"
        cmd.ExecuteNonQuery()
        MessageBox.Show("Item Deactivated")
        btnClear.PerformClick()
        RefreshData()
    End Sub
End Class