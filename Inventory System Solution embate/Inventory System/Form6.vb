
Public Class Form6
    Dim cnn As New OleDb.OleDbConnection
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\Accounts.mdb"

        'get data into list
        Me.RefreshData()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("SELECT accId as [ID], accUser as [Username], accPass as [Password], accPos as [Position], accName as [Full Name] from tblAccounts", cnn)
        Dim dt As New DataTable
        'fill data to datatable
        da.Fill(dt)

        'offer data in data table into datagridview
        Me.dgvData.DataSource = dt

        'close connection
        cnn.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtId.Text = "" Then
            MessageBox.Show("ID is Required!")
            txtId.Focus()
        ElseIf txtUser.Text = "" Then
            MessageBox.Show("Username is Required!")
            txtUser.Focus()
        ElseIf txtPass.Text = "" Then
            MessageBox.Show("Password is Required!")
            txtPass.Focus()
        ElseIf cmbPos.Text = "" Then
            MessageBox.Show("Position is Required!")
            cmbPos.Focus()
        ElseIf txtName.Text = "" Then
            MessageBox.Show("Full Name is Required!")
            txtName.Focus()
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
                cmd.CommandText = "INSERT INTO tblAccounts(accId, accUser, accPass, accPos, accName)" & _
                                " VALUES(" & txtId.Text & ",'" & txtUser.Text & "','" & txtPass.Text & "','" & cmbPos.Text & "','" & txtName.Text & "')"
                Try
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("ID Already Exist!")
                    txtId.Focus()
                End Try

            Else
                'update data in table
                cmd.CommandText = "UPDATE tblAccounts " & _
                 " SET accId=" & txtId.Text & _
                 ", accUser='" & txtUser.Text & "'" & _
                  ", accPass='" & txtPass.Text & "'" & _
                  ", accPos='" & cmbPos.Text & "'" & _
                  ", accName='" & txtName.Text & "'" & _
                  " WHERE accId=" & txtId.Tag
                cmd.ExecuteNonQuery()
            End If
            'refresh data in list
            RefreshData()
            'clear form
            Me.btnClear.PerformClick()

            'close connection
            cnn.Close()

        End If
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtId.Text = ""
        txtPass.Text = ""
        txtUser.Text = ""
        txtName.Text = ""
        Me.txtId.Tag = ""
        'enable button edit
        Me.btnUpd.Enabled = True
        'set button add to add label
        Me.btnAdd.Text = "Add"
        '

        '
        Me.txtId.Focus()
    End Sub

    Private Sub btnUpd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpd.Click
        'check for the selected item in list
        If dgvData.Rows.Count > 0 Then
            If dgvData.SelectedRows.Count > 0 Then
                Dim intaccID As Integer = Me.dgvData.SelectedRows(0).Cells("id").Value

                'open connection
                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If
                'get data into datatable
                Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tblAccounts " & _
                                                     " WHERE accId=" & intaccID, cnn)
                Dim dt As New DataTable
                da.Fill(dt)

                txtId.Text = intaccID
                txtUser.Text = dt.Rows(0).Item("accUser")
                txtPass.Text = dt.Rows(0).Item("accPass")
                cmbPos.Text = dt.Rows(0).Item("accPos")
                txtName.Text = dt.Rows(0).Item("accName")
                'hide the id to be edited in TAG of txtstdid in case id is changed
                txtId.Tag = intaccID
                'change button add to update
                btnAdd.Text = "Update"
                'disable button edit
                btnUpd.Enabled = False
                'close connection
                cnn.Close()
            End If
        End If
    End Sub

    
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        'check for the selected item in list
        If dgvData.Rows.Count > 0 Then
            If dgvData.SelectedRows.Count > 0 Then
                Dim intaccID As Integer = dgvData.SelectedRows(0).Cells("id").Value
                'open connection
                If Not cnn.State = ConnectionState.Open Then
                    cnn.Open()
                End If

                'delete data
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cnn
                cmd.CommandText = "DELETE FROM tblAccounts WHERE accId=" & intaccID
                cmd.ExecuteNonQuery()
                'refresh data
                RefreshData()
                txtId.Text = ""
                txtUser.Text = ""
                txtPass.Text = ""
                txtName.Text = ""
                'close connection
                cnn.Close()
            End If
        End If
    End Sub

    Private Sub txtId_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtId.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MessageBox.Show("Numeric Only!")
        End If
    End Sub

    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged

    End Sub
End Class