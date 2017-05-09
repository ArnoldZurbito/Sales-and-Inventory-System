<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Raw_Material
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Raw_Material))
        Me.cmbUNIT = New System.Windows.Forms.ComboBox()
        Me.cmdCancelMaintenance = New System.Windows.Forms.Button()
        Me.txtCQ1 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblExpired = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtRaw_Name = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSubmitAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmbUNIT
        '
        Me.cmbUNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUNIT.ForeColor = System.Drawing.Color.Maroon
        Me.cmbUNIT.FormattingEnabled = True
        Me.cmbUNIT.Items.AddRange(New Object() {"mG/s", "gram/s", "kG/s", "mL/s", "liter/s", "gallon/s", "piece/s", "dozen/s"})
        Me.cmbUNIT.Location = New System.Drawing.Point(261, 252)
        Me.cmbUNIT.Name = "cmbUNIT"
        Me.cmbUNIT.Size = New System.Drawing.Size(219, 28)
        Me.cmbUNIT.TabIndex = 39
        '
        'cmdCancelMaintenance
        '
        Me.cmdCancelMaintenance.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.cmdCancelMaintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdCancelMaintenance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancelMaintenance.ForeColor = System.Drawing.Color.Red
        Me.cmdCancelMaintenance.Location = New System.Drawing.Point(356, 338)
        Me.cmdCancelMaintenance.Name = "cmdCancelMaintenance"
        Me.cmdCancelMaintenance.Size = New System.Drawing.Size(160, 39)
        Me.cmdCancelMaintenance.TabIndex = 38
        Me.cmdCancelMaintenance.Text = "&Cancel"
        Me.cmdCancelMaintenance.UseVisualStyleBackColor = False
        '
        'txtCQ1
        '
        Me.txtCQ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCQ1.ForeColor = System.Drawing.Color.Maroon
        Me.txtCQ1.Location = New System.Drawing.Point(261, 191)
        Me.txtCQ1.MaxLength = 5
        Me.txtCQ1.Multiline = True
        Me.txtCQ1.Name = "txtCQ1"
        Me.txtCQ1.Size = New System.Drawing.Size(219, 28)
        Me.txtCQ1.TabIndex = 37
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Red
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Bisque
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.AntiqueWhite
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(259, 294)
        Me.DateTimePicker1.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 26)
        Me.DateTimePicker1.TabIndex = 32
        Me.DateTimePicker1.Value = New Date(2016, 5, 26, 0, 0, 0, 0)
        '
        'lblExpired
        '
        Me.lblExpired.AutoSize = True
        Me.lblExpired.BackColor = System.Drawing.Color.Transparent
        Me.lblExpired.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpired.ForeColor = System.Drawing.Color.White
        Me.lblExpired.Location = New System.Drawing.Point(83, 300)
        Me.lblExpired.Name = "lblExpired"
        Me.lblExpired.Size = New System.Drawing.Size(126, 20)
        Me.lblExpired.TabIndex = 29
        Me.lblExpired.Text = "Expiration Date :"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.White
        Me.lblQuantity.Location = New System.Drawing.Point(83, 199)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(76, 20)
        Me.lblQuantity.TabIndex = 28
        Me.lblQuantity.Text = "Quantity :"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.ForeColor = System.Drawing.Color.White
        Me.lblProductName.Location = New System.Drawing.Point(79, 143)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(117, 20)
        Me.lblProductName.TabIndex = 27
        Me.lblProductName.Text = "Raw Materials :"
        '
        'txtRaw_Name
        '
        Me.txtRaw_Name.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.txtRaw_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRaw_Name.ForeColor = System.Drawing.Color.Maroon
        Me.txtRaw_Name.Location = New System.Drawing.Point(261, 137)
        Me.txtRaw_Name.Name = "txtRaw_Name"
        Me.txtRaw_Name.Size = New System.Drawing.Size(219, 26)
        Me.txtRaw_Name.TabIndex = 40
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(330, 537)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(165, 26)
        Me.TextBox2.TabIndex = 42
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(218, 537)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(106, 26)
        Me.TextBox3.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(280, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(280, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 44
        '
        'cmdSubmitAdd
        '
        Me.cmdSubmitAdd.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.cmdSubmitAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdSubmitAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSubmitAdd.ForeColor = System.Drawing.Color.Red
        Me.cmdSubmitAdd.Location = New System.Drawing.Point(135, 338)
        Me.cmdSubmitAdd.Name = "cmdSubmitAdd"
        Me.cmdSubmitAdd.Size = New System.Drawing.Size(160, 39)
        Me.cmdSubmitAdd.TabIndex = 45
        Me.cmdSubmitAdd.Text = "&Add"
        Me.cmdSubmitAdd.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(109, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Unit :"
        '
        'Add_Raw_Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImage = Global.RED_CHEESE_PIZZA.My.Resources.Resources.logo81
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(693, 429)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSubmitAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtRaw_Name)
        Me.Controls.Add(Me.cmbUNIT)
        Me.Controls.Add(Me.cmdCancelMaintenance)
        Me.Controls.Add(Me.txtCQ1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblExpired)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblProductName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_Raw_Material"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adding Raw Materials"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbUNIT As System.Windows.Forms.ComboBox
    Friend WithEvents cmdCancelMaintenance As System.Windows.Forms.Button
    Friend WithEvents txtCQ1 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblExpired As System.Windows.Forms.Label
    Friend WithEvents lblQuantity As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtRaw_Name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdSubmitAdd As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
