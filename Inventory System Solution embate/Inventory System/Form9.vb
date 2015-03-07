Public Class Form9
    Dim cnn As New OleDb.OleDbConnection
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=" & Application.StartupPath & "\Accounts.mdb"

        cnn.Open()
        Dim cmd As New OleDb.OleDbCommand

        cmd.Connection = cnn

        ''insert data to sql database row by row
        Dim Sno, sname, sdesc, sprice, sqty, samt As Object
        e.Graphics.DrawString("Sales Inventory System", SystemFonts.DefaultFont, Brushes.Black, 350, 100)
        e.Graphics.DrawString("Transaction No:         " & Form3.lblTrno.Text, SystemFonts.DefaultFont, Brushes.Black, 80, 130)
        e.Graphics.DrawString("Cashier's Name:         " & Form3.lblCash.Text, SystemFonts.DefaultFont, Brushes.Black, 80, 150)
        e.Graphics.DrawString("Date :                  " & Form3.lbldate.Text, SystemFonts.DefaultFont, Brushes.Black, 600, 130)
        e.Graphics.DrawString("Time :                 " & Form3.lblTime.Text, SystemFonts.DefaultFont, Brushes.Black, 600, 150)
        e.Graphics.DrawString("__________________________________________________________________________________________________________________", SystemFonts.DefaultFont, Brushes.Black, 50, 170)
        e.Graphics.DrawString("Item No", SystemFonts.DefaultFont, Brushes.Black, 80, 190)
        e.Graphics.DrawString("Item Name", SystemFonts.DefaultFont, Brushes.Black, 200, 190)
        e.Graphics.DrawString("Description", SystemFonts.DefaultFont, Brushes.Black, 400, 190)
        e.Graphics.DrawString("Price", SystemFonts.DefaultFont, Brushes.Black, 580, 190)
        e.Graphics.DrawString("Quantity", SystemFonts.DefaultFont, Brushes.Black, 630, 190)
        e.Graphics.DrawString("Amount", SystemFonts.DefaultFont, Brushes.Black, 700, 190)

        Dim tbl_test As New DataTable
        Dim height As Integer = 220
        For i = 0 To Form3.DataGridView1.Rows.Add - 1 Step 1
            Sno = Form3.DataGridView1.Rows(i).Cells(0).Value()
            sname = Form3.DataGridView1.Rows(i).Cells(1).Value()
            sdesc = Form3.DataGridView1.Rows(i).Cells(2).Value()
            sprice = Form3.DataGridView1.Rows(i).Cells(3).Value()
            sqty = Form3.DataGridView1.Rows(i).Cells(4).Value()
            samt = Form3.DataGridView1.Rows(i).Cells(5).Value()
    
            e.Graphics.DrawString(Sno, SystemFonts.DefaultFont, Brushes.Black, 80, height)
            e.Graphics.DrawString(sname, SystemFonts.DefaultFont, Brushes.Black, 200, height)
            e.Graphics.DrawString(sdesc, SystemFonts.DefaultFont, Brushes.Black, 400, height)
            e.Graphics.DrawString(sprice, SystemFonts.DefaultFont, Brushes.Black, 580, height)
            e.Graphics.DrawString(sqty, SystemFonts.DefaultFont, Brushes.Black, 630, height)
            e.Graphics.DrawString(samt, SystemFonts.DefaultFont, Brushes.Black, 700, height)
            height += 20
        Next

        cnn.Close()
        e.Graphics.DrawString("__________________________________________________________________________________________________________________", SystemFonts.DefaultFont, Brushes.Black, 50, height)
        e.Graphics.DrawString("TOTAL :", SystemFonts.DefaultFont, Brushes.Black, 630, height + 30)
        e.Graphics.DrawString("Php " & Form7.lblamtdue.Text, SystemFonts.DefaultFont, Brushes.Black, 700, height + 30)
        e.Graphics.DrawString("Cash :", SystemFonts.DefaultFont, Brushes.Black, 630, height + 80)
        e.Graphics.DrawString("Php " & Form7.txtCsh.Text, SystemFonts.DefaultFont, Brushes.Black, 700, height + 80)
        e.Graphics.DrawString("----------------------------------------", SystemFonts.DefaultFont, Brushes.Black, 630, height + 110)
        e.Graphics.DrawString("Change :", SystemFonts.DefaultFont, Brushes.Black, 630, height + 140)
        e.Graphics.DrawString("Php " & Form7.lblChange.Text, SystemFonts.DefaultFont, Brushes.Black, 700, height + 140)
        Form3.DataGridView1.Rows.Clear()
        Form3.Button1.Enabled = False
    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

    End Sub
End Class