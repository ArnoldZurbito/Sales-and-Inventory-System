<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProduct))
        Me.cmdCancelMaintenance = New System.Windows.Forms.Button()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtProdukto = New System.Windows.Forms.TextBox()
        Me.cmdSubmitAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbfillCat = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cmdCancelMaintenance
        '
        Me.cmdCancelMaintenance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.cmdCancelMaintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancelMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelMaintenance.ForeColor = System.Drawing.Color.Red
        Me.cmdCancelMaintenance.Location = New System.Drawing.Point(353, 322)
        Me.cmdCancelMaintenance.Name = "cmdCancelMaintenance"
        Me.cmdCancelMaintenance.Size = New System.Drawing.Size(160, 39)
        Me.cmdCancelMaintenance.TabIndex = 38
        Me.cmdCancelMaintenance.Text = "&Cancel"
        Me.cmdCancelMaintenance.UseVisualStyleBackColor = False
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.ForeColor = System.Drawing.Color.White
        Me.lblProductName.Location = New System.Drawing.Point(51, 206)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(118, 20)
        Me.lblProductName.TabIndex = 27
        Me.lblProductName.Text = "Product Name :"
        '
        'txtProdukto
        '
        Me.txtProdukto.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdukto.ForeColor = System.Drawing.Color.Maroon
        Me.txtProdukto.Location = New System.Drawing.Point(175, 193)
        Me.txtProdukto.Multiline = True
        Me.txtProdukto.Name = "txtProdukto"
        Me.txtProdukto.Size = New System.Drawing.Size(277, 33)
        Me.txtProdukto.TabIndex = 40
        '
        'cmdSubmitAdd
        '
        Me.cmdSubmitAdd.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.cmdSubmitAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSubmitAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmitAdd.ForeColor = System.Drawing.Color.Red
        Me.cmdSubmitAdd.Location = New System.Drawing.Point(121, 322)
        Me.cmdSubmitAdd.Name = "cmdSubmitAdd"
        Me.cmdSubmitAdd.Size = New System.Drawing.Size(160, 39)
        Me.cmdSubmitAdd.TabIndex = 41
        Me.cmdSubmitAdd.Text = "&Add"
        Me.cmdSubmitAdd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(51, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Category :"
        '
        'cmbfillCat
        '
        Me.cmbfillCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbfillCat.ForeColor = System.Drawing.Color.Maroon
        Me.cmbfillCat.FormattingEnabled = True
        Me.cmbfillCat.IntegralHeight = False
        Me.cmbfillCat.ItemHeight = 20
        Me.cmbfillCat.Location = New System.Drawing.Point(175, 154)
        Me.cmbfillCat.Name = "cmbfillCat"
        Me.cmbfillCat.Size = New System.Drawing.Size(277, 28)
        Me.cmbfillCat.TabIndex = 46
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.RED_CHEESE_PIZZA.My.Resources.Resources.logo81
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(628, 436)
        Me.Controls.Add(Me.cmbfillCat)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSubmitAdd)
        Me.Controls.Add(Me.txtProdukto)
        Me.Controls.Add(Me.cmdCancelMaintenance)
        Me.Controls.Add(Me.lblProductName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddProduct"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adding Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancelMaintenance As System.Windows.Forms.Button
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtProdukto As System.Windows.Forms.TextBox
    Friend WithEvents cmdSubmitAdd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbfillCat As System.Windows.Forms.ComboBox
End Class
