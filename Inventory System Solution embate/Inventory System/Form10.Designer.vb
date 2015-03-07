<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TransdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItmNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItmNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItmDesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TransnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItmPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItmQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItmAmtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TranstimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CashDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChangeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItmAmtDueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsDataSet = New Inventory_System.AccountsDataSet()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblSalesTableAdapter = New Inventory_System.AccountsDataSetTableAdapters.tblSalesTableAdapter()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransdateDataGridViewTextBoxColumn, Me.ItmNumDataGridViewTextBoxColumn, Me.ItmNameDataGridViewTextBoxColumn, Me.ItmDesDataGridViewTextBoxColumn, Me.TransnoDataGridViewTextBoxColumn, Me.ItmPriceDataGridViewTextBoxColumn, Me.ItmQtyDataGridViewTextBoxColumn, Me.ItmAmtDataGridViewTextBoxColumn, Me.TranstimeDataGridViewTextBoxColumn, Me.CashierDataGridViewTextBoxColumn, Me.CashDataGridViewTextBoxColumn, Me.ChangeDataGridViewTextBoxColumn, Me.ItmAmtDueDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TblSalesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(533, 211)
        Me.DataGridView1.TabIndex = 0
        '
        'TransdateDataGridViewTextBoxColumn
        '
        Me.TransdateDataGridViewTextBoxColumn.DataPropertyName = "Trans_date"
        Me.TransdateDataGridViewTextBoxColumn.HeaderText = "Trans_date"
        Me.TransdateDataGridViewTextBoxColumn.Name = "TransdateDataGridViewTextBoxColumn"
        '
        'ItmNumDataGridViewTextBoxColumn
        '
        Me.ItmNumDataGridViewTextBoxColumn.DataPropertyName = "itmNum"
        Me.ItmNumDataGridViewTextBoxColumn.HeaderText = "itmNum"
        Me.ItmNumDataGridViewTextBoxColumn.Name = "ItmNumDataGridViewTextBoxColumn"
        Me.ItmNumDataGridViewTextBoxColumn.Visible = False
        '
        'ItmNameDataGridViewTextBoxColumn
        '
        Me.ItmNameDataGridViewTextBoxColumn.DataPropertyName = "itmName"
        Me.ItmNameDataGridViewTextBoxColumn.HeaderText = "itmName"
        Me.ItmNameDataGridViewTextBoxColumn.Name = "ItmNameDataGridViewTextBoxColumn"
        '
        'ItmDesDataGridViewTextBoxColumn
        '
        Me.ItmDesDataGridViewTextBoxColumn.DataPropertyName = "itmDes"
        Me.ItmDesDataGridViewTextBoxColumn.HeaderText = "itmDes"
        Me.ItmDesDataGridViewTextBoxColumn.Name = "ItmDesDataGridViewTextBoxColumn"
        '
        'TransnoDataGridViewTextBoxColumn
        '
        Me.TransnoDataGridViewTextBoxColumn.DataPropertyName = "trans_no"
        Me.TransnoDataGridViewTextBoxColumn.HeaderText = "trans_no"
        Me.TransnoDataGridViewTextBoxColumn.Name = "TransnoDataGridViewTextBoxColumn"
        '
        'ItmPriceDataGridViewTextBoxColumn
        '
        Me.ItmPriceDataGridViewTextBoxColumn.DataPropertyName = "itmPrice"
        Me.ItmPriceDataGridViewTextBoxColumn.HeaderText = "itmPrice"
        Me.ItmPriceDataGridViewTextBoxColumn.Name = "ItmPriceDataGridViewTextBoxColumn"
        '
        'ItmQtyDataGridViewTextBoxColumn
        '
        Me.ItmQtyDataGridViewTextBoxColumn.DataPropertyName = "itmQty"
        Me.ItmQtyDataGridViewTextBoxColumn.HeaderText = "itmQty"
        Me.ItmQtyDataGridViewTextBoxColumn.Name = "ItmQtyDataGridViewTextBoxColumn"
        '
        'ItmAmtDataGridViewTextBoxColumn
        '
        Me.ItmAmtDataGridViewTextBoxColumn.DataPropertyName = "itmAmt"
        Me.ItmAmtDataGridViewTextBoxColumn.HeaderText = "itmAmt"
        Me.ItmAmtDataGridViewTextBoxColumn.Name = "ItmAmtDataGridViewTextBoxColumn"
        '
        'TranstimeDataGridViewTextBoxColumn
        '
        Me.TranstimeDataGridViewTextBoxColumn.DataPropertyName = "Trans_time"
        Me.TranstimeDataGridViewTextBoxColumn.HeaderText = "Trans_time"
        Me.TranstimeDataGridViewTextBoxColumn.Name = "TranstimeDataGridViewTextBoxColumn"
        '
        'CashierDataGridViewTextBoxColumn
        '
        Me.CashierDataGridViewTextBoxColumn.DataPropertyName = "Cashier"
        Me.CashierDataGridViewTextBoxColumn.HeaderText = "Cashier"
        Me.CashierDataGridViewTextBoxColumn.Name = "CashierDataGridViewTextBoxColumn"
        '
        'CashDataGridViewTextBoxColumn
        '
        Me.CashDataGridViewTextBoxColumn.DataPropertyName = "cash"
        Me.CashDataGridViewTextBoxColumn.HeaderText = "cash"
        Me.CashDataGridViewTextBoxColumn.Name = "CashDataGridViewTextBoxColumn"
        '
        'ChangeDataGridViewTextBoxColumn
        '
        Me.ChangeDataGridViewTextBoxColumn.DataPropertyName = "change"
        Me.ChangeDataGridViewTextBoxColumn.HeaderText = "change"
        Me.ChangeDataGridViewTextBoxColumn.Name = "ChangeDataGridViewTextBoxColumn"
        '
        'ItmAmtDueDataGridViewTextBoxColumn
        '
        Me.ItmAmtDueDataGridViewTextBoxColumn.DataPropertyName = "itmAmtDue"
        Me.ItmAmtDueDataGridViewTextBoxColumn.HeaderText = "itmAmtDue"
        Me.ItmAmtDueDataGridViewTextBoxColumn.Name = "ItmAmtDueDataGridViewTextBoxColumn"
        '
        'TblSalesBindingSource
        '
        Me.TblSalesBindingSource.DataMember = "tblSales"
        Me.TblSalesBindingSource.DataSource = Me.AccountsDataSet
        '
        'AccountsDataSet
        '
        Me.AccountsDataSet.DataSetName = "AccountsDataSet"
        Me.AccountsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView2.Location = New System.Drawing.Point(551, 34)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(289, 210)
        Me.DataGridView2.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Date"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Total"
        Me.Column2.Name = "Column2"
        '
        'TblSalesTableAdapter
        '
        Me.TblSalesTableAdapter.ClearBeforeFill = True
        '
        'btnSearch
        '
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Location = New System.Drawing.Point(95, 95)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(312, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(98, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Transaction No"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(31, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(107, 17)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Transaction Date"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(184, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(76, 17)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Item Name"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnView)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 129)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search Action"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(31, 58)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(208, 97)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(202, 20)
        Me.txtSearch.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.LightGray
        Me.GroupBox2.Location = New System.Drawing.Point(551, 251)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 129)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Option"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(92, 36)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(87, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Sales Vault"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(551, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Sales Report"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(92, 13)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(107, 17)
        Me.RadioButton4.TabIndex = 8
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Transaction Date"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.ForeColor = System.Drawing.Color.Black
        Me.btnView.Location = New System.Drawing.Point(14, 95)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 8
        Me.btnView.Text = "View All"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(104, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "View All"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Inventory_System.My.Resources.Resources.images__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(852, 392)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents AccountsDataSet As Inventory_System.AccountsDataSet
    Friend WithEvents TblSalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSalesTableAdapter As Inventory_System.AccountsDataSetTableAdapters.tblSalesTableAdapter
    Friend WithEvents TransdateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItmNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItmNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItmDesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TransnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItmPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItmQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItmAmtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TranstimeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashierDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CashDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChangeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItmAmtDueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
