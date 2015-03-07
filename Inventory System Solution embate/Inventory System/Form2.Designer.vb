<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.btnItems = New System.Windows.Forms.Button()
        Me.btnRestock = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUsers
        '
        Me.btnUsers.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.Black
        Me.btnUsers.Image = Global.Inventory_System.My.Resources.Resources.Oxygen_Icons_org_Oxygen_Actions_user_group_new
        Me.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUsers.Location = New System.Drawing.Point(179, 31)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(134, 77)
        Me.btnUsers.TabIndex = 4
        Me.btnUsers.Text = "USERS"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsers.UseVisualStyleBackColor = False
        '
        'btnItems
        '
        Me.btnItems.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnItems.Image = Global.Inventory_System.My.Resources.Resources.c38752a41
        Me.btnItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnItems.Location = New System.Drawing.Point(12, 136)
        Me.btnItems.Name = "btnItems"
        Me.btnItems.Size = New System.Drawing.Size(134, 77)
        Me.btnItems.TabIndex = 3
        Me.btnItems.Text = "ITEMS"
        Me.btnItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnItems.UseVisualStyleBackColor = False
        '
        'btnRestock
        '
        Me.btnRestock.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnRestock.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestock.Image = Global.Inventory_System.My.Resources.Resources.StockPlusIcon_4column1
        Me.btnRestock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRestock.Location = New System.Drawing.Point(152, 136)
        Me.btnRestock.Name = "btnRestock"
        Me.btnRestock.Size = New System.Drawing.Size(161, 77)
        Me.btnRestock.TabIndex = 1
        Me.btnRestock.Text = "RESTOCK"
        Me.btnRestock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRestock.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.SystemColors.ControlDark
        Me.btnDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Image = Global.Inventory_System.My.Resources.Resources.Awicons_Vista_Artistic_Delete
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(12, 31)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(134, 77)
        Me.btnDel.TabIndex = 0
        Me.btnDel.Text = "DELETE"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Inventory_System.My.Resources.Resources.asa
        Me.ClientSize = New System.Drawing.Size(328, 249)
        Me.Controls.Add(Me.btnUsers)
        Me.Controls.Add(Me.btnItems)
        Me.Controls.Add(Me.btnRestock)
        Me.Controls.Add(Me.btnDel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator Control"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnRestock As System.Windows.Forms.Button
    Friend WithEvents btnItems As System.Windows.Forms.Button
    Friend WithEvents btnUsers As System.Windows.Forms.Button
End Class
