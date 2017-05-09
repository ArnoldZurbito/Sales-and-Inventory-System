<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Account
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Account))
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.User_Company_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Firstname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Middlename = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lastname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RawNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RawExpirationDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Account_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSAVE = New System.Windows.Forms.Button()
        Me.btnDELETE = New System.Windows.Forms.Button()
        Me.btnCLEAR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnFname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCANCEL = New System.Windows.Forms.Button()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.btnADD = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLname = New System.Windows.Forms.TextBox()
        Me.btnCHANGE = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.TextBox()
        Me.btnMname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnNum = New System.Windows.Forms.TextBox()
        Me.btnPass = New System.Windows.Forms.TextBox()
        Me.cmbAccType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtUName = New System.Windows.Forms.TextBox()
        Me.txtUpass = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.cmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Red
        Me.cmdCancel.Location = New System.Drawing.Point(525, 663)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(160, 39)
        Me.cmdCancel.TabIndex = 6
        Me.cmdCancel.Text = "&Back"
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeight = 35
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.User_Company_ID, Me.Firstname, Me.Middlename, Me.Lastname, Me.RawNameDataGridViewTextBoxColumn, Me.Column1, Me.RawExpirationDateDataGridViewTextBoxColumn, Me.Password, Me.Account_Type})
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.InactiveCaption
        Me.DataGridView2.Location = New System.Drawing.Point(23, 112)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.DataGridView2.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray
        Me.DataGridView2.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView2.RowTemplate.DefaultCellStyle.Format = "N2"
        Me.DataGridView2.RowTemplate.DefaultCellStyle.NullValue = "1"
        Me.DataGridView2.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkGray
        Me.DataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridView2.RowTemplate.Height = 25
        Me.DataGridView2.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(684, 242)
        Me.DataGridView2.TabIndex = 51
        '
        'User_Company_ID
        '
        Me.User_Company_ID.DataPropertyName = "User_Company_ID"
        Me.User_Company_ID.HeaderText = "User_ID"
        Me.User_Company_ID.Name = "User_Company_ID"
        Me.User_Company_ID.ReadOnly = True
        Me.User_Company_ID.Visible = False
        Me.User_Company_ID.Width = 5
        '
        'Firstname
        '
        Me.Firstname.DataPropertyName = "Firstname"
        Me.Firstname.HeaderText = "Fname"
        Me.Firstname.Name = "Firstname"
        Me.Firstname.ReadOnly = True
        Me.Firstname.Visible = False
        Me.Firstname.Width = 5
        '
        'Middlename
        '
        Me.Middlename.DataPropertyName = "Middlename"
        Me.Middlename.HeaderText = "Mname"
        Me.Middlename.Name = "Middlename"
        Me.Middlename.ReadOnly = True
        Me.Middlename.Visible = False
        Me.Middlename.Width = 5
        '
        'Lastname
        '
        Me.Lastname.DataPropertyName = "Lastname"
        Me.Lastname.HeaderText = "Lastname"
        Me.Lastname.Name = "Lastname"
        Me.Lastname.ReadOnly = True
        Me.Lastname.Visible = False
        Me.Lastname.Width = 5
        '
        'RawNameDataGridViewTextBoxColumn
        '
        Me.RawNameDataGridViewTextBoxColumn.DataPropertyName = "Fullname"
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RawNameDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.RawNameDataGridViewTextBoxColumn.HeaderText = "                         NAME"
        Me.RawNameDataGridViewTextBoxColumn.Name = "RawNameDataGridViewTextBoxColumn"
        Me.RawNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.RawNameDataGridViewTextBoxColumn.Width = 260
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Contact_Num"
        Me.Column1.HeaderText = "       CONTACT NO."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 180
        '
        'RawExpirationDateDataGridViewTextBoxColumn
        '
        Me.RawExpirationDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.RawExpirationDateDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.RawExpirationDateDataGridViewTextBoxColumn.HeaderText = "      USERNAME"
        Me.RawExpirationDateDataGridViewTextBoxColumn.Name = "RawExpirationDateDataGridViewTextBoxColumn"
        Me.RawExpirationDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.RawExpirationDateDataGridViewTextBoxColumn.ToolTipText = "Just Hover Your Pointer Mouse On Cell For More Information about expiration Date " & _
    "of A Raw Materials"
        Me.RawExpirationDateDataGridViewTextBoxColumn.Visible = False
        '
        'Password
        '
        Me.Password.DataPropertyName = "Password"
        Me.Password.HeaderText = "       PASSWORD"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        Me.Password.Visible = False
        Me.Password.Width = 150
        '
        'Account_Type
        '
        Me.Account_Type.DataPropertyName = "Account_Type"
        Me.Account_Type.HeaderText = "            ACCOUNT TYPE"
        Me.Account_Type.Name = "Account_Type"
        Me.Account_Type.ReadOnly = True
        Me.Account_Type.Width = 200
        '
        'btnSAVE
        '
        Me.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnSAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSAVE.ForeColor = System.Drawing.Color.Red
        Me.btnSAVE.Location = New System.Drawing.Point(347, 76)
        Me.btnSAVE.Name = "btnSAVE"
        Me.btnSAVE.Size = New System.Drawing.Size(121, 39)
        Me.btnSAVE.TabIndex = 52
        Me.btnSAVE.Text = "&SAVE"
        Me.btnSAVE.UseVisualStyleBackColor = False
        '
        'btnDELETE
        '
        Me.btnDELETE.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDELETE.ForeColor = System.Drawing.Color.Red
        Me.btnDELETE.Location = New System.Drawing.Point(347, 166)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(121, 39)
        Me.btnDELETE.TabIndex = 54
        Me.btnDELETE.Text = "&DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = False
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLEAR.ForeColor = System.Drawing.Color.Red
        Me.btnCLEAR.Location = New System.Drawing.Point(347, 211)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(121, 39)
        Me.btnCLEAR.TabIndex = 55
        Me.btnCLEAR.Text = "&CLEAR"
        Me.btnCLEAR.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Controls.Add(Me.btnFname)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCANCEL)
        Me.GroupBox1.Controls.Add(Me.lblProductName)
        Me.GroupBox1.Controls.Add(Me.btnADD)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnLname)
        Me.GroupBox1.Controls.Add(Me.btnCHANGE)
        Me.GroupBox1.Controls.Add(Me.btnUser)
        Me.GroupBox1.Controls.Add(Me.btnMname)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnNum)
        Me.GroupBox1.Controls.Add(Me.btnSAVE)
        Me.GroupBox1.Controls.Add(Me.btnPass)
        Me.GroupBox1.Controls.Add(Me.cmbAccType)
        Me.GroupBox1.Controls.Add(Me.btnCLEAR)
        Me.GroupBox1.Controls.Add(Me.btnDELETE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(81, 371)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(501, 275)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adding,Modifying and Deleting of User Account"
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.Red
        Me.btnUpdate.Location = New System.Drawing.Point(347, 76)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 39)
        Me.btnUpdate.TabIndex = 75
        Me.btnUpdate.Text = "&SAVE"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnFname
        '
        Me.btnFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFname.ForeColor = System.Drawing.Color.Maroon
        Me.btnFname.Location = New System.Drawing.Point(152, 31)
        Me.btnFname.Name = "btnFname"
        Me.btnFname.Size = New System.Drawing.Size(175, 26)
        Me.btnFname.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Middlename :"
        '
        'btnCANCEL
        '
        Me.btnCANCEL.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCANCEL.ForeColor = System.Drawing.Color.Red
        Me.btnCANCEL.Location = New System.Drawing.Point(347, 31)
        Me.btnCANCEL.Name = "btnCANCEL"
        Me.btnCANCEL.Size = New System.Drawing.Size(121, 39)
        Me.btnCANCEL.TabIndex = 74
        Me.btnCANCEL.Text = "&CANCEL"
        Me.btnCANCEL.UseVisualStyleBackColor = False
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.ForeColor = System.Drawing.Color.White
        Me.lblProductName.Location = New System.Drawing.Point(10, 31)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(88, 20)
        Me.lblProductName.TabIndex = 59
        Me.lblProductName.Text = "Firstname :"
        '
        'btnADD
        '
        Me.btnADD.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnADD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADD.ForeColor = System.Drawing.Color.Red
        Me.btnADD.Location = New System.Drawing.Point(347, 31)
        Me.btnADD.Name = "btnADD"
        Me.btnADD.Size = New System.Drawing.Size(121, 39)
        Me.btnADD.TabIndex = 72
        Me.btnADD.Text = "&ADD"
        Me.btnADD.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(10, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 20)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Lastname :"
        '
        'btnLname
        '
        Me.btnLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLname.ForeColor = System.Drawing.Color.Maroon
        Me.btnLname.Location = New System.Drawing.Point(152, 96)
        Me.btnLname.Name = "btnLname"
        Me.btnLname.Size = New System.Drawing.Size(175, 26)
        Me.btnLname.TabIndex = 58
        '
        'btnCHANGE
        '
        Me.btnCHANGE.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCHANGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCHANGE.ForeColor = System.Drawing.Color.Red
        Me.btnCHANGE.Location = New System.Drawing.Point(347, 121)
        Me.btnCHANGE.Name = "btnCHANGE"
        Me.btnCHANGE.Size = New System.Drawing.Size(121, 39)
        Me.btnCHANGE.TabIndex = 71
        Me.btnCHANGE.Text = "&UPDATE"
        Me.btnCHANGE.UseVisualStyleBackColor = False
        '
        'btnUser
        '
        Me.btnUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.Maroon
        Me.btnUser.Location = New System.Drawing.Point(152, 162)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(175, 26)
        Me.btnUser.TabIndex = 62
        '
        'btnMname
        '
        Me.btnMname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMname.ForeColor = System.Drawing.Color.Maroon
        Me.btnMname.Location = New System.Drawing.Point(152, 63)
        Me.btnMname.Name = "btnMname"
        Me.btnMname.Size = New System.Drawing.Size(175, 26)
        Me.btnMname.TabIndex = 57
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(9, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 20)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Contact No. :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(10, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Username :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(10, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Password :"
        '
        'btnNum
        '
        Me.btnNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNum.ForeColor = System.Drawing.Color.Maroon
        Me.btnNum.Location = New System.Drawing.Point(151, 128)
        Me.btnNum.MaxLength = 11
        Me.btnNum.Name = "btnNum"
        Me.btnNum.Size = New System.Drawing.Size(175, 26)
        Me.btnNum.TabIndex = 69
        '
        'btnPass
        '
        Me.btnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPass.ForeColor = System.Drawing.Color.Maroon
        Me.btnPass.Location = New System.Drawing.Point(152, 195)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(175, 26)
        Me.btnPass.TabIndex = 66
        Me.btnPass.UseSystemPasswordChar = True
        '
        'cmbAccType
        '
        Me.cmbAccType.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.cmbAccType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbAccType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAccType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAccType.ForeColor = System.Drawing.Color.Maroon
        Me.cmbAccType.FormattingEnabled = True
        Me.cmbAccType.Items.AddRange(New Object() {"CREW", "ADMIN"})
        Me.cmbAccType.Location = New System.Drawing.Point(151, 228)
        Me.cmbAccType.Name = "cmbAccType"
        Me.cmbAccType.Size = New System.Drawing.Size(176, 28)
        Me.cmbAccType.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Account Type :"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(184, 751)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(10, 26)
        Me.TextBox2.TabIndex = 75
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(427, 748)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(219, 26)
        Me.TextBox3.TabIndex = 76
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.Location = New System.Drawing.Point(149, 96)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(352, 13)
        Me.LinkLabel1.TabIndex = 77
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Note :  If you want to modify or remove an account just click of each row."
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Red
        '
        'txtUName
        '
        Me.txtUName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUName.Location = New System.Drawing.Point(270, 758)
        Me.txtUName.Name = "txtUName"
        Me.txtUName.Size = New System.Drawing.Size(175, 26)
        Me.txtUName.TabIndex = 76
        '
        'txtUpass
        '
        Me.txtUpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpass.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUpass.Location = New System.Drawing.Point(270, 791)
        Me.txtUpass.Name = "txtUpass"
        Me.txtUpass.Size = New System.Drawing.Size(175, 26)
        Me.txtUpass.TabIndex = 77
        Me.txtUpass.UseSystemPasswordChar = True
        '
        'User_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        'Me.BackgroundImage = Global.RED_CHEESE_PIZZA.My.Resources.Resources.logo81
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 733)
        Me.Controls.Add(Me.txtUName)
        Me.Controls.Add(Me.txtUpass)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "User_Account"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registered User"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSAVE As System.Windows.Forms.Button
    ' Friend WithEvents UPDATE As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLname As System.Windows.Forms.TextBox
    Friend WithEvents btnMname As System.Windows.Forms.TextBox
    Friend WithEvents btnFname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnPass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnUser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnNum As System.Windows.Forms.TextBox
    Friend WithEvents cmbAccType As System.Windows.Forms.ComboBox
    Friend WithEvents btnADD As System.Windows.Forms.Button
    Friend WithEvents btnCHANGE As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnCANCEL As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents txtUName As System.Windows.Forms.TextBox
    Friend WithEvents txtUpass As System.Windows.Forms.TextBox
    Friend WithEvents User_Company_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Firstname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Middlename As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lastname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RawNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RawExpirationDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Account_Type As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
