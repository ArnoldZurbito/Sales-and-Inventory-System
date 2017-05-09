Imports System
Imports System.Data
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Modall
    Public HeaderCheckBox As CheckBox
    Public checkboxHeader231 As CheckBox
    Public col, cols, colt, coly, coln, colm As DataGridViewCheckBoxColumn
    Public coldatagridchk4, coldatagridchk6, coldatagridchk7, coldatagridchk8, coldatagridchk9 As DataGridViewCheckBoxColumn
    Public chkBox As CheckBox
    Public _IsSelectAllChecked, _IsSelectAllCheckeds, _IsSelectAllCheckedr, _IsSelectAllCheckedy, _IsSelectAllCheckedt, _IsSelectAllCheckedn, _IsSelectAllCheckedm As Boolean
    Public der, ders, derr, dery, dert, dern, derm As Integer
    Public IDs, IDraw, IDr, clicking As String
    Public Named As String
    Public UserNamed As String
    Public txtSumDisplay As Integer
    Public CatIDdisplay As Integer
    Public quantitytest As Integer
    Public putExpired As Integer
    Public putCritical As Integer
    Public true_size As String
    Public fillsize As String
    Public fillsizeprod As String
    Public totalColumn As Double = 0
    Public totalnameColumn As String = "Total"
    Public Fillingindex As Boolean
    Public ifselecallchk As Boolean
    Public d As Integer
    Public coldtgchk As DataGridViewCheckBoxColumn
    Public totald As Decimal
    Public quantitytesting As Integer
    Public resdatefromsalest As String
    Public resdatetosalesrt As String

    Private Sub UpdateLabelFG(ByVal controls As ControlCollection, ByVal fgColor As Color)
        If controls Is Nothing Then Return
        For Each C As Control In controls
            If TypeOf C Is Label Then DirectCast(C, Label).ForeColor = fgColor
            If C.HasChildren Then UpdateLabelFG(C.Controls, fgColor)
        Next
    End Sub
    Private Sub Modall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  UpdateLabelFG(Me.Controls, Color.White)
        TabControl1.Visible = False
        dtpDateFomSales.CustomFormat = " "
        dtpDateFomSales.Format = DateTimePickerFormat.Custom

        dtpDateToSales.CustomFormat = " "
        dtpDateToSales.Format = DateTimePickerFormat.Custom

        hideadminnav()
        hidecrewnav()
        Me.Label25.Text = Date.Now.ToString("MM/dd/yyyy")
        '   bgColor()
        Hidelabeladmin()
        Hidelabelcrew()
        grpOrderProd.BringToFront()
        grpRecord.Hide()
        lblOrderProductClick()

        grpCritical.Hide()
        grpExpired.Hide()
        grpBgRawProducts.Hide()
        grpBgRawMats.Hide()
        grpBgProducts.Hide()

        Expired_Raw_Mats()
        Critical_Raw_Mats()
        lblUser.Text = Named
        lblAccountType.Text = UserNamed
        If putExpired = 0 Then
            Expiredasterisk1.Visible = False
            Expiredasterisk2.Visible = False
            Expiredasterisk3.Visible = False
            Expiredasterisk1_0.Visible = False
            Expiredasterisk2_0.Visible = False
            Expiredasterisk3_0.Visible = False
        ElseIf putExpired > 0 Then
            Expiredasterisk1.Show()
            Expiredasterisk2.Visible = False
            Expiredasterisk3.Visible = False
            Expiredasterisk1_0.Show()
            Expiredasterisk2_0.Visible = False
            Expiredasterisk3_0.Visible = False
        End If

        If putCritical = 0 Then
            Criticalquotation1.Visible = False
            Criticalquotation2.Visible = False
            Criticalquotation3.Visible = False
            Criticalquotation1_0.Visible = False
            Criticalquotation2_0.Visible = False
            Criticalquotation3_0.Visible = False
        ElseIf putCritical > 0 Then
            Criticalquotation1.Show()
            Criticalquotation2.Visible = False
            Criticalquotation3.Visible = False
            Criticalquotation1_0.Show()
            Criticalquotation2_0.Visible = False
            Criticalquotation3_0.Visible = False
        End If
    End Sub
    Private Sub HeaderCheckBox2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me._IsSelectAllChecked = True
        Dim cbx As CheckBox
        cbx = DirectCast(sender, CheckBox)
        Dim DataGridView2 As DataGridView = cbx.Parent
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Cells(1).Value = cbx.Checked
        Next
        'cmbDeleteProd.Enabled = True
        DataGridView2.EndEdit()
        Me._IsSelectAllChecked = False
    End Sub
    Private Sub HeaderCheckBox3_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me._IsSelectAllCheckeds = True
        Dim cbxs As CheckBox
        cbxs = DirectCast(sender, CheckBox)
        Dim DataGridView3 As DataGridView = cbxs.Parent
        For Each rows As DataGridViewRow In DataGridView3.Rows
            rows.Cells(1).Value = cbxs.Checked
        Next
        'cmbDeleteProd.Enabled = True
        DataGridView3.EndEdit()
        Me._IsSelectAllCheckeds = False

    End Sub
    Private Sub HeaderCheckBox4_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me._IsSelectAllCheckedr = True
        Dim cbr As CheckBox
        cbr = DirectCast(sender, CheckBox)
        Dim DataGridView2 As DataGridView = cbr.Parent
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Cells(1).Value = cbr.Checked
        Next
        'cmbDeleteProd.Enabled = True
        DataGridView4.EndEdit()
        Me._IsSelectAllCheckedr = False

    End Sub
    Private Sub HeaderCheckBox6_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me._IsSelectAllCheckedt = True
        Dim cbt As CheckBox
        cbt = DirectCast(sender, CheckBox)
        Dim DataGridView6 As DataGridView = cbt.Parent
        For Each row As DataGridViewRow In DataGridView6.Rows
            row.Cells(1).Value = cbt.Checked
        Next
        'cmbDeleteProd.Enabled = True
        DataGridView6.EndEdit()
        Me._IsSelectAllCheckedt = False

    End Sub
    Private Sub HeaderCheckBox7_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me._IsSelectAllCheckedy = True
        Dim cby As CheckBox
        cby = DirectCast(sender, CheckBox)
        Dim DataGridView2 As DataGridView = cby.Parent
        For Each row As DataGridViewRow In DataGridView2.Rows
            row.Cells(1).Value = cby.Checked
        Next
        'cmbDeleteProd.Enabled = True
        DataGridView7.EndEdit()
        Me._IsSelectAllCheckedy = False
    End Sub
    Private Sub HeaderCheckBox8_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me._IsSelectAllCheckedn = True
        Dim cbn As CheckBox
        cbn = DirectCast(sender, CheckBox)
        Dim DataGridView8 As DataGridView = cbn.Parent
        For Each row As DataGridViewRow In DataGridView8.Rows
            row.Cells(1).Value = cbn.Checked
        Next
        'cmbDeleteProd.Enabled = True
        DataGridView8.EndEdit()
        Me._IsSelectAllCheckedn = False
    End Sub
    Private Sub HeaderCheckBox9_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me._IsSelectAllCheckedm = True
        Dim cbm As CheckBox
        cbm = DirectCast(sender, CheckBox)
        Dim DataGridView10 As DataGridView = cbm.Parent
        For Each row As DataGridViewRow In DataGridView10.Rows
            row.Cells(1).Value = cbm.Checked
        Next
        'cmbDeleteProd.Enabled = True
        DataGridView10.EndEdit()
        Me._IsSelectAllCheckedm = False
    End Sub
    Private Sub HeaderCheckBox10_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.ifselecallchk = True
        Dim cbkbox As CheckBox
        cbkbox = DirectCast(sender, CheckBox)
        Dim dtgOrder As DataGridView = cbkbox.Parent
        For Each row As DataGridViewRow In dtgOrder.Rows
            row.Cells(1).Value = cbkbox.Checked
        Next
        dtgOrder.EndEdit()
        Me.ifselecallchk = False
    End Sub
    Private Sub DataGridView2_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim pcount As Integer = 0
        der = pcount
        pcount = der
        Dim DataGridView2 As DataGridView = DirectCast(sender, DataGridView)
        If Not Me._IsSelectAllChecked Then
            If DataGridView2.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                DirectCast(DataGridView2.Controls.Item("SelectAll"), CheckBox).Checked = False
                cmdDeletebtnProdRawHide.Visible = False
                cmdDeletebtnProdRaw.Show()
            Else
                Dim isAllChecked As Boolean = True
                For Each row As DataGridViewRow In DataGridView2.Rows
                    If row.Cells(1).Value = False Then
                        'cmbDeleteProd.Enabled = False
                        isAllChecked = False
                        Exit For
                    End If
                    ' cmbDeleteProd.Enabled = True
                    cmdDeletebtnProdRawHide.Visible = False
                    cmdDeletebtnProdRaw.Show()
                Next
                DirectCast(DataGridView2.Controls.Item("SelectAll"), CheckBox).Checked = isAllChecked
                'cmbDeleteProd.Enabled = False
            End If
            ' cmbDeleteProd.Enabled = False
            cmdDeletebtnProdRawHide.Show()
            cmdDeletebtnProdRaw.Visible = False
        End If
        For Each rowr As DataGridViewRow In DataGridView2.Rows
            If rowr.Cells(1).Value = True Then
                'cmbDeleteProd.Enabled = True
                cmdDeletebtnProdRawHide.Visible = False
                cmdDeletebtnProdRaw.Show()
                pcount += 1
            End If
        Next
        Label4.Show()
        Label4.Text = pcount & " selected"
        If pcount > 0 Then
            ' cmbDeleteProd.Enabled = True
            cmdDeletebtnProdRawHide.Visible = False
            cmdDeletebtnProdRaw.Show()
            'cmbDeleteProd.Cursor = Cursors.Hand
        Else
            Label4.Visible = False
            'cmbDeleteProd.Enabled = False
            cmdDeletebtnProdRawHide.Show()
            cmdDeletebtnProdRaw.Visible = False
        End If
    End Sub
    Private Sub DataGridView3_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim pcounts As Integer = 0
        ders = pcounts
        pcounts = ders
        Dim DataGridView3 As DataGridView = DirectCast(sender, DataGridView)
        If Not Me._IsSelectAllCheckeds Then
            If DataGridView3.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                DirectCast(DataGridView3.Controls.Item("SelectAll"), CheckBox).Checked = False
                cmdDeletebtnRawHide.Visible = False
                cmdDeletebtnRaw.Show()
            Else
                Dim isAllCheckeds As Boolean = True
                For Each row As DataGridViewRow In DataGridView3.Rows
                    If row.Cells(1).Value = False Then
                        'cmbDeleteProd.Enabled = False
                        isAllCheckeds = False
                        Exit For
                    End If
                    ' cmbDeleteProd.Enabled = True
                    cmdDeletebtnRawHide.Visible = False
                    cmdDeletebtnRaw.Show()
                Next
                DirectCast(DataGridView3.Controls.Item("SelectAll"), CheckBox).Checked = isAllCheckeds
                'cmbDeleteProd.Enabled = False
            End If
            ' cmbDeleteProd.Enabled = False
            cmdDeletebtnRawHide.Show()
            cmdDeletebtnRaw.Visible = False
        End If
        For Each roww As DataGridViewRow In DataGridView3.Rows
            If roww.Cells(1).Value = True Then
                'cmbDeleteProd.Enabled = True
                cmdDeletebtnRawHide.Visible = False
                cmdDeletebtnRaw.Show()
                pcounts += 1
            End If
        Next
        Label9.Show()
        Label9.Text = pcounts & " selected"
        If pcounts > 0 Then
            ' cmbDeleteProd.Enabled = True
            cmdDeletebtnRawHide.Visible = False
            cmdDeletebtnRaw.Show()
            'cmbDeleteProd.Cursor = Cursors.Hand
        Else
            Label9.Visible = False
            'cmbDeleteProd.Enabled = False
            cmdDeletebtnRawHide.Show()
            cmdDeletebtnRaw.Visible = False
        End If
    End Sub
    Private Sub DataGridView4_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim pcounted As Integer = 0
        derr = pcounted
        pcounted = derr
        Dim DataGridView4 As DataGridView = DirectCast(sender, DataGridView)
        If Not Me._IsSelectAllCheckedr Then
            If DataGridView4.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                DirectCast(DataGridView4.Controls.Item("SelectAll"), CheckBox).Checked = False
                cmdDeletebtnProdHide.Visible = False
                cmdDeletebtnProd.Show()
            Else
                Dim isAllCheckedr As Boolean = True
                For Each row As DataGridViewRow In DataGridView4.Rows
                    If row.Cells(1).Value = False Then
                        'cmbDeleteProd.Enabled = False
                        isAllCheckedr = False
                        Exit For
                    End If
                    ' cmbDeleteProd.Enabled = True
                    cmdDeletebtnProdHide.Visible = False
                    cmdDeletebtnProd.Show()
                Next
                DirectCast(DataGridView4.Controls.Item("SelectAll"), CheckBox).Checked = isAllCheckedr
                'cmbDeleteProd.Enabled = False
            End If
            ' cmbDeleteProd.Enabled = False
            cmdDeletebtnProdHide.Show()
            cmdDeletebtnProd.Visible = False
        End If
        For Each rawr As DataGridViewRow In DataGridView4.Rows
            If rawr.Cells(1).Value = True Then
                'cmbDeleteProd.Enabled = True
                cmdDeletebtnProdHide.Visible = False
                cmdDeletebtnProd.Show()
                pcounted += 1
            End If
        Next
        Label14.Show()
        Label14.Text = pcounted & " selected"
        If pcounted > 0 Then
            ' cmbDeleteProd.Enabled = True
            cmdDeletebtnProdHide.Visible = False
            cmdDeletebtnProd.Show()
            'cmbDeleteProd.Cursor = Cursors.Hand
        Else
            Label14.Visible = False
            'cmbDeleteProd.Enabled = False
            cmdDeletebtnProdHide.Show()
            cmdDeletebtnProd.Visible = False
        End If
    End Sub
    Private Sub DataGridView6_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim pcountedt As Integer = 0
        dert = pcountedt
        pcountedt = derr
        Dim DataGridView6 As DataGridView = DirectCast(sender, DataGridView)
        If Not Me._IsSelectAllCheckedt Then
            If DataGridView6.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                DirectCast(DataGridView6.Controls.Item("SelectAll"), CheckBox).Checked = False
                btnExpiredHide.Visible = False
                btnExpired.Show()
            Else
                Dim isAllCheckedt As Boolean = True
                For Each row As DataGridViewRow In DataGridView6.Rows
                    If row.Cells(1).Value = False Then
                        'cmbDeleteProd.Enabled = False
                        isAllCheckedt = False
                        Exit For
                    End If
                    ' cmbDeleteProd.Enabled = True
                    btnExpiredHide.Visible = False
                    btnExpired.Show()
                Next
                DirectCast(DataGridView6.Controls.Item("SelectAll"), CheckBox).Checked = isAllCheckedt
                'cmbDeleteProd.Enabled = False
            End If
            ' cmbDeleteProd.Enabled = False
            btnExpiredHide.Show()
            btnExpired.Visible = False
        End If
        For Each rawt As DataGridViewRow In DataGridView6.Rows
            If rawt.Cells(1).Value = True Then
                'cmbDeleteProd.Enabled = True
                btnExpiredHide.Visible = False
                btnExpired.Show()
                pcountedt += 1
            End If
        Next
        Label28.Show()
        Label28.Text = pcountedt & " selected"
        If pcountedt > 0 Then
            ' cmbDeleteProd.Enabled = True
            btnExpiredHide.Visible = False
            btnExpired.Show()
            'cmbDeleteProd.Cursor = Cursors.Hand
        Else
            Label28.Visible = False
            'cmbDeleteProd.Enabled = False
            btnExpiredHide.Show()
            btnExpired.Visible = False
        End If
    End Sub
    Private Sub DataGridView7_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim pcountedy As Integer = 0
        dery = pcountedy
        pcountedy = dery
        Dim DataGridView7 As DataGridView = DirectCast(sender, DataGridView)
        If Not Me._IsSelectAllCheckedy Then
            If DataGridView7.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                DirectCast(DataGridView7.Controls.Item("SelectAll"), CheckBox).Checked = False
                btnCriticalHide.Visible = False
                btnCritical.Show()
            Else
                Dim isAllCheckedy As Boolean = True
                For Each row As DataGridViewRow In DataGridView7.Rows
                    If row.Cells(1).Value = False Then
                        'cmbDeleteProd.Enabled = False
                        isAllCheckedy = False
                        Exit For
                    End If
                    ' cmbDeleteProd.Enabled = True
                    btnCriticalHide.Visible = False
                    btnCritical.Show()
                Next
                DirectCast(DataGridView7.Controls.Item("SelectAll"), CheckBox).Checked = isAllCheckedy
                'cmbDeleteProd.Enabled = False
            End If
            ' cmbDeleteProd.Enabled = False
            btnCriticalHide.Show()
            btnCritical.Visible = False
        End If
        For Each rawy As DataGridViewRow In DataGridView7.Rows
            If rawy.Cells(1).Value = True Then
                'cmbDeleteProd.Enabled = True
                btnCriticalHide.Visible = False
                btnCritical.Show()
                pcountedy += 1
            End If
        Next
        Label27.Show()
        Label27.Text = pcountedy & " selected"
        If pcountedy > 0 Then
            ' cmbDeleteProd.Enabled = True
            btnCriticalHide.Visible = False
            btnCritical.Show()
            'cmbDeleteProd.Cursor = Cursors.Hand
        Else
            Label27.Visible = False
            'cmbDeleteProd.Enabled = False
            btnCriticalHide.Show()
            btnCritical.Visible = False
        End If
    End Sub
    Private Sub DataGridView8_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim pcountn As Integer = 0
        dern = pcountn
        pcountn = dern
        Dim DataGridView8 As DataGridView = DirectCast(sender, DataGridView)
        If Not Me._IsSelectAllCheckedn Then
            If DataGridView8.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                DirectCast(DataGridView8.Controls.Item("SelectAll"), CheckBox).Checked = False
                btnAvailableProdHide.Visible = False
                btnAvailableProd.Show()
            Else
                Dim isAllCheckedn As Boolean = True
                For Each row As DataGridViewRow In DataGridView8.Rows
                    If row.Cells(1).Value = False Then
                        'cmbDeleteProd.Enabled = False
                        isAllCheckedn = False
                        Exit For
                    End If
                    ' cmbDeleteProd.Enabled = True
                    btnAvailableProdHide.Visible = False
                    btnAvailableProd.Show()
                Next
                DirectCast(DataGridView8.Controls.Item("SelectAll"), CheckBox).Checked = isAllCheckedn
                'cmbDeleteProd.Enabled = False
            End If
            ' cmbDeleteProd.Enabled = False
            btnAvailableProdHide.Show()
            btnAvailableProd.Visible = False
        End If
        For Each rown As DataGridViewRow In DataGridView8.Rows
            If rown.Cells(1).Value = True Then
                'cmbDeleteProd.Enabled = True
                btnAvailableProdHide.Visible = False
                btnAvailableProd.Show()
                pcountn += 1
            End If
        Next
        Label29.Show()
        Label29.Text = pcountn & " selected"
        If pcountn > 0 Then
            ' cmbDeleteProd.Enabled = True
            btnAvailableProdHide.Visible = False
            btnAvailableProd.Show()
            'cmbDeleteProd.Cursor = Cursors.Hand
        Else
            Label29.Visible = False
            'cmbDeleteProd.Enabled = False
            btnAvailableProdHide.Show()
            btnAvailableProd.Visible = False
        End If
    End Sub
    Private Sub DataGridView10_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim pcountedm As Integer = 0
        derm = pcountedm
        pcountedm = derm
        Dim DataGridView10 As DataGridView = DirectCast(sender, DataGridView)
        If Not Me._IsSelectAllCheckedm Then
            If DataGridView10.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = False Then
                DirectCast(DataGridView10.Controls.Item("SelectAll"), CheckBox).Checked = False
                btnDeleteLogHide.Visible = False
                btnDeleteLog.Show()
            Else
                Dim isAllCheckedm As Boolean = True
                For Each row As DataGridViewRow In DataGridView10.Rows
                    If row.Cells(1).Value = False Then
                        'cmbDeleteProd.Enabled = False
                        isAllCheckedm = False
                        Exit For
                    End If
                    ' cmbDeleteProd.Enabled = True
                    btnDeleteLogHide.Visible = False
                    btnDeleteLog.Show()
                Next
                DirectCast(DataGridView10.Controls.Item("SelectAll"), CheckBox).Checked = isAllCheckedm
                'cmbDeleteProd.Enabled = False
            End If
            ' cmbDeleteProd.Enabled = False
            btnDeleteLogHide.Show()
            btnDeleteLog.Visible = False
        End If
        For Each rawm As DataGridViewRow In DataGridView10.Rows
            If rawm.Cells(1).Value = True Then
                'cmbDeleteProd.Enabled = True
                btnDeleteLogHide.Visible = False
                btnDeleteLog.Show()
                pcountedm += 1
            End If
        Next
        Label48.Show()
        Label48.Text = pcountedm & " selected"
        If pcountedm > 0 Then
            ' cmbDeleteProd.Enabled = True
            btnDeleteLogHide.Visible = False
            btnDeleteLog.Show()
            'cmbDeleteProd.Cursor = Cursors.Hand
        Else
            Label48.Visible = False
            'cmbDeleteProd.Enabled = False
            btnDeleteLogHide.Show()
            btnDeleteLog.Visible = False
        End If
    End Sub
    Private Sub dtgOrder_CellChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim pcount As Integer = 0
        d = pcount
        pcount = d
        Dim dtgOrder As DataGridView = DirectCast(sender, DataGridView)
        If Not Me.ifselecallchk Then
            btnDelOrderHide.Show()
            btnDelOrder.Visible = False
        End If
        For Each rowr As DataGridViewRow In dtgOrder.Rows
            If rowr.Cells(1).Value = True Then
                btnDelOrderHide.Visible = False
                btnDelOrder.Show()
                pcount += 1
            End If
        Next
        lblselected.Show()
        lblselected.Text = pcount & " selected"
        If pcount > 0 Then
            btnDelOrderHide.Visible = False
            btnDelOrder.Show()
        Else
            lblselected.Visible = False
            btnDelOrderHide.Show()
            btnDelOrder.Visible = False
        End If
    End Sub
    Private Sub DataGridView2_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DataGridView2 As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf DataGridView2.CurrentCell Is DataGridViewCheckBoxCell Then
            DataGridView2.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub DataGridView3_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DataGridView3 As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf DataGridView3.CurrentCell Is DataGridViewCheckBoxCell Then
            DataGridView3.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub DataGridView4_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DataGridView4 As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf DataGridView4.CurrentCell Is DataGridViewCheckBoxCell Then
            DataGridView4.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub DataGridView6_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DataGridView6 As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf DataGridView6.CurrentCell Is DataGridViewCheckBoxCell Then
            DataGridView6.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub DataGridView7_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DataGridView7 As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf DataGridView7.CurrentCell Is DataGridViewCheckBoxCell Then
            DataGridView7.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub DataGridView8_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DataGridView8 As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf DataGridView8.CurrentCell Is DataGridViewCheckBoxCell Then
            DataGridView8.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub DataGridView10_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DataGridView10 As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf DataGridView10.CurrentCell Is DataGridViewCheckBoxCell Then
            DataGridView10.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Private Sub dtgOrder_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dtgOrder As DataGridView = DirectCast(sender, DataGridView)
        If TypeOf dtgOrder.CurrentCell Is DataGridViewCheckBoxCell Then
            dtgOrder.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
    Public Sub AddSelectAllCheckBox(ByVal DataGridView2 As DataGridView)
        Dim cbx As New CheckBox
        col = New DataGridViewCheckBoxColumn()
        col.Name = "CheckBox"
        cbx.Name = "SelectAll"
        cbx.Size = New Size(14, 14)
        Dim recta As Rectangle = Me.DataGridView2.GetCellDisplayRectangle(1, -1, True)
        cbx.Location = New System.Drawing.Point(recta.Location.X + ((recta.Width - cbx.Width) / 1.3), recta.Location.Y + ((recta.Height - cbx.Height) / 1.3))
        cbx.BackColor = Color.White
        Me.DataGridView2.Controls.Add(cbx)
        AddHandler cbx.Click, AddressOf HeaderCheckBox2_Click
        AddHandler DataGridView2.CellValueChanged, AddressOf DataGridView2_CellChecked
        AddHandler DataGridView2.CurrentCellDirtyStateChanged, AddressOf DataGridView2_CurrentCellDirtyStateChanged
    End Sub
    Public Sub AddSelectAllCheckBoxs(ByVal DataGridView3 As DataGridView)
        Dim cbxs As New CheckBox
        cols = New DataGridViewCheckBoxColumn()
        cols.Name = "CheckBox"
        cbxs.Name = "SelectAll"
        cbxs.Size = New Size(14, 14)
        Dim rectas As Rectangle = Me.DataGridView3.GetCellDisplayRectangle(1, -1, True)
        cbxs.Location = New System.Drawing.Point(rectas.Location.X + ((rectas.Width - cbxs.Width) / 1.3), rectas.Location.Y + ((rectas.Height - cbxs.Height) / 1.3))
        cbxs.BackColor = Color.White
        Me.DataGridView3.Controls.Add(cbxs)
        AddHandler cbxs.Click, AddressOf HeaderCheckBox3_Click
        AddHandler DataGridView3.CellValueChanged, AddressOf DataGridView3_CellChecked
        AddHandler DataGridView3.CurrentCellDirtyStateChanged, AddressOf DataGridView3_CurrentCellDirtyStateChanged
    End Sub
    Public Sub AddSelectAllCheckBoxr(ByVal DataGridView4 As DataGridView)
        Dim chkhead4 As New CheckBox
        coldatagridchk4 = New DataGridViewCheckBoxColumn()
        coldatagridchk4.Name = "CheckBox"
        chkhead4.Name = "SelectAll"
        chkhead4.Size = New Size(14, 14)
        Dim rectar As Rectangle = Me.DataGridView4.GetCellDisplayRectangle(1, -1, True)
        chkhead4.Location = New System.Drawing.Point(rectar.Location.X + ((rectar.Width - chkhead4.Width) / 1.3), rectar.Location.Y + ((rectar.Height - chkhead4.Height) / 1.3))
        chkhead4.BackColor = Color.White
        Me.DataGridView4.Controls.Add(chkhead4)
        AddHandler chkhead4.Click, AddressOf HeaderCheckBox4_Click
        AddHandler DataGridView4.CellValueChanged, AddressOf DataGridView4_CellChecked
        AddHandler DataGridView4.CurrentCellDirtyStateChanged, AddressOf DataGridView4_CurrentCellDirtyStateChanged
    End Sub
    Public Sub AddSelectAllCheckBoxt(ByVal DataGridView7 As DataGridView)
        Dim chkhead6 As New CheckBox
        coldatagridchk6 = New DataGridViewCheckBoxColumn()
        coldatagridchk6.Name = "CheckBox"
        chkhead6.Name = "SelectAll"
        chkhead6.Size = New Size(14, 14)
        Dim recta6 As Rectangle = Me.DataGridView6.GetCellDisplayRectangle(1, -1, True)
        chkhead6.Location = New System.Drawing.Point(recta6.Location.X + ((recta6.Width - chkhead6.Width) / 1.3), recta6.Location.Y + ((recta6.Height - chkhead6.Height) / 1.3))
        chkhead6.BackColor = Color.White
        Me.DataGridView6.Controls.Add(chkhead6)
        AddHandler chkhead6.Click, AddressOf HeaderCheckBox6_Click
        AddHandler DataGridView6.CellValueChanged, AddressOf DataGridView6_CellChecked
        AddHandler DataGridView6.CurrentCellDirtyStateChanged, AddressOf DataGridView6_CurrentCellDirtyStateChanged
    End Sub
    Public Sub AddSelectAllCheckBoxy(ByVal DataGridView7 As DataGridView)
        Dim chkhead7 As New CheckBox
        coldatagridchk7 = New DataGridViewCheckBoxColumn()
        coldatagridchk7.Name = "CheckBox"
        chkhead7.Name = "SelectAll"
        chkhead7.Size = New Size(14, 14)
        Dim recta7 As Rectangle = Me.DataGridView7.GetCellDisplayRectangle(1, -1, True)
        chkhead7.Location = New System.Drawing.Point(recta7.Location.X + ((recta7.Width - chkhead7.Width) / 1.3), recta7.Location.Y + ((recta7.Height - chkhead7.Height) / 1.3))
        chkhead7.BackColor = Color.White
        Me.DataGridView7.Controls.Add(chkhead7)
        AddHandler chkhead7.Click, AddressOf HeaderCheckBox7_Click
        AddHandler DataGridView7.CellValueChanged, AddressOf DataGridView7_CellChecked
        AddHandler DataGridView7.CurrentCellDirtyStateChanged, AddressOf DataGridView7_CurrentCellDirtyStateChanged
    End Sub
    Public Sub AddSelectAllCheckBoxn(ByVal DataGridView8 As DataGridView)
        Dim cbn As New CheckBox
        coln = New DataGridViewCheckBoxColumn()
        coln.Name = "CheckBox"
        cbn.Name = "SelectAll"
        cbn.Size = New Size(14, 14)
        Dim rectan As Rectangle = Me.DataGridView8.GetCellDisplayRectangle(1, -1, True)
        cbn.Location = New System.Drawing.Point(rectan.Location.X + ((rectan.Width - cbn.Width) / 1.3), rectan.Location.Y + ((rectan.Height - cbn.Height) / 1.3))
        cbn.BackColor = Color.White
        Me.DataGridView8.Controls.Add(cbn)
        AddHandler cbn.Click, AddressOf HeaderCheckBox8_Click
        AddHandler DataGridView8.CellValueChanged, AddressOf DataGridView8_CellChecked
        AddHandler DataGridView8.CurrentCellDirtyStateChanged, AddressOf DataGridView8_CurrentCellDirtyStateChanged
    End Sub
    Public Sub AddSelectAllCheckBoxw(ByVal dtgOrder As DataGridView)
        Dim cbx As New CheckBox
        coldtgchk = New DataGridViewCheckBoxColumn()
        coldtgchk.Name = "CheckBox"
        cbx.Name = "SelectAll"
        cbx.Size = New Size(14, 14)
        Dim recta As Rectangle = Me.dtgOrder.GetCellDisplayRectangle(1, -1, True)
        cbx.Location = New System.Drawing.Point(recta.Location.X + ((recta.Width - cbx.Width) / 1.3), recta.Location.Y + ((recta.Height - cbx.Height) / 1.3))
        cbx.BackColor = Color.White
        Me.dtgOrder.Controls.Add(cbx)
        AddHandler cbx.Click, AddressOf HeaderCheckBox10_Click
        AddHandler dtgOrder.CellValueChanged, AddressOf dtgOrder_CellChecked
        AddHandler dtgOrder.CurrentCellDirtyStateChanged, AddressOf dtgOrder_CurrentCellDirtyStateChanged
    End Sub
    Public Sub AddSelectAllCheckBoxm(ByVal DataGridView10 As DataGridView)
        Dim chkhead9 As New CheckBox
        coldatagridchk9 = New DataGridViewCheckBoxColumn()
        coldatagridchk9.Name = "CheckBox"
        chkhead9.Name = "SelectAll"
        chkhead9.Size = New Size(14, 14)
        Dim rectar As Rectangle = Me.DataGridView10.GetCellDisplayRectangle(1, -1, True)
        chkhead9.Location = New System.Drawing.Point(rectar.Location.X + ((rectar.Width - chkhead9.Width) / 1.3), rectar.Location.Y + ((rectar.Height - chkhead9.Height) / 1.3))
        chkhead9.BackColor = Color.White
        Me.DataGridView10.Controls.Add(chkhead9)
        AddHandler chkhead9.Click, AddressOf HeaderCheckBox9_Click
        AddHandler DataGridView10.CellValueChanged, AddressOf DataGridView10_CellChecked
        AddHandler DataGridView10.CurrentCellDirtyStateChanged, AddressOf DataGridView10_CurrentCellDirtyStateChanged
    End Sub
    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Try
            IDs = DataGridView2(2, DataGridView2.CurrentRow.Index).Value.ToString()
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "SELECT product_table.Product_ID,product_table.Cat_ID,product_table.Product_Name,product_size.Size_Name As 'true_sizes',(Case when product_size.Size_Name " _
                                 & " = 'None' Then 'pieces' when product_size.Size_Name IS NULL Then '' Else product_size.Size_Name  End) As 'Sized' from product_quantity RIGHT join product_table " _
                                 & " on product_quantity.Product_ID = product_table.Product_ID LEFT join product_size on product_quantity.Size_ID = product_size.size_ID INNER join category  on product_table.CAT_ID = category.Cat_ID WHERE product_table.Product_Name= '" & IDs & "'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    Add_Prod.txtProd.Text = objdr.GetString("product_name")
                    Add_Prod.TextBox8.Text = objdr.GetString("product_name")
                    Add_Prod.txcatIDs.Text = objdr.GetInt32("Cat_ID")
                    Dim fillsizeprodus As String = objdr.GetString("Sized")
                    Add_Prod.ComboBox1.Items.Add(fillsizeprodus)
                End While
            End If
            'objda.Dispose()
            objconn.Close()
            Add_Prod.Show()
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
        End Try
    End Sub
    Private Sub DataGridView3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellDoubleClick
        Try
            IDraw = DataGridView3(2, DataGridView3.CurrentRow.Index).Value.ToString()
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "SELECT  * FROM raw_material_table where Raw_Name ='" & IDraw & "'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    ModifyRaw.txtRawNamed.Text = objdr.GetString("Raw_Name")
                    ModifyRaw.txtputRaw.Text = objdr.GetString("Raw_Name")
                    ModifyRaw.txtputID.Text = objdr.GetInt32("Raw_ID")
                End While
            End If
            'objda.Dispose()
            objdr.Close()
            objconn.Close()
            ModifyRaw.loadchkRaws()
            ModifyRaw.Show()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Private Sub DataGridView4_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellDoubleClick
        IDr = DataGridView4(2, DataGridView4.CurrentRow.Index).Value.ToString()
        Try
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "SELECT product_table.Product_ID,product_table.Cat_ID,product_table.Product_Name,product_size.Size_Name As 'true_sizes',(Case when product_size.Size_Name " _
                                 & " = 'None' Then 'pieces' when product_size.Size_Name IS NULL Then '' Else product_size.Size_Name  End) As 'Sized' from product_quantity RIGHT join product_table on product_quantity.Product_ID = product_table.Product_ID LEFT join product_size on product_quantity.Size_ID = product_size.size_ID INNER join category  on product_table.CAT_ID = category.Cat_ID WHERE product_table.Product_Name= '" & IDr & "'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    CellClickableQuant.txtfillProd.Text = objdr.GetString("product_name")
                    CellClickableQuant.txtP.Text = objdr.GetString("product_name")
                    CellClickableQuant.txtID.Text = objdr.GetInt32("Product_ID")
                    Dim fillsizeprods As String = objdr.GetString("Sized")
                    CellClickableQuant.cmbselectSizes.Items.Add(fillsizeprods)
                    CellClickableQuant.cmbSized.Items.Add(fillsizeprods)
                    CellClickableQuant.txtCatID.Text = objdr.GetInt32("Cat_ID")
                    '  CellClickableQuant.txtQuants.Text = objdr.GetInt32("Quantity")
                End While
            End If
            objconn.Close()
            objconn.Dispose()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

        Try
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "Select ( CASE WHEN Sum(product_quantity.Quantity)  IS NULL THEN 0 ELSE Sum(product_quantity.Quantity) END) As 'QUANTITY' from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID  left join product_size on product_quantity.Size_ID = product_size.size_ID  where  product_table.Product_Name = '" & IDr & "'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    CellClickableQuant.TextBox1.Text = objdr.GetInt32("QUANTITY")
                End While
            End If
            objconn.Close()
            objconn.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CellClickableQuant.Show()
    End Sub
    Private Sub DataGridView2_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView2.DataBindingComplete
        DataGridView2.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
    End Sub
    Private Sub DataGridView3_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView3.DataBindingComplete
        DataGridView3.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
    End Sub
    Private Sub DataGridView4_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView4.DataBindingComplete
        DataGridView4.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
    End Sub
    Private Sub DataGridView7_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView7.DataBindingComplete
        DataGridView7.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
    End Sub
    Private Sub DataGridView8_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView8.DataBindingComplete
        DataGridView8.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
    End Sub
    Private Sub DataGridView9_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView9.DataBindingComplete
        DataGridView9.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
    End Sub
    Private Sub DataGridView10_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridView10.DataBindingComplete
        DataGridView10.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
    End Sub
    Private Sub dtgOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgOrder.CellClick
        If dtgOrder.Columns(3).ReadOnly = False Then
            Cursor = Cursors.IBeam
        Else
            Cursor.Current = Cursors.Default
        End If
    End Sub
    Private Sub dtgOrder_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dtgOrder.CellLeave
        dtgOrder.Cursor = Cursors.Default
    End Sub
    Public Sub AllowOnlyNumeric(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        'Dim strAllowed As String() = AllowedChar.Split(",")
        'Dim ienum As IEnumerator = strAllowed.GetEnumerator

        'While (ienum.MoveNext)
        '    If e.KeyChar.ToString().ToLower = ienum.Current.ToString().ToLower Then
        '        Return
        '    End If
        'End While

        If Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub
    Private Sub dtgOrder_MouseClick(sender As Object, e As MouseEventArgs) Handles dtgOrder.MouseClick
        For iv As Integer = 0 To dtgOrder.RowCount - 1
            If dtgOrder.Rows(iv).Cells(3).Value = "" Then
                MsgBox("Enter Quantity", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
                dtgOrder.BeginEdit(True)
                conditioncellcolor()
            ElseIf dtgOrder.Rows(iv).Cells(3).Value > Label73.Text Then
                question = MsgBox("You have entered a higher quantity than quantity of our product." & Environment.NewLine & ". " _
                                  & "Make sure you have entered exact quantity or lower than quantity of our product/s .", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
                dtgOrder.CurrentCell = dtgOrder.Rows(iv).Cells(3)
                dtgOrder.BeginEdit(True)
            ElseIf dtgOrder.Rows(iv).Cells(3).Value <= Label73.Text Then
                Dim a As Decimal = dtgOrder.Rows(iv).Cells(6).Value
                a = dtgOrder.Rows(iv).Cells(3).Value * Convert.ToDecimal(dtgOrder.Rows(iv).Cells(5).Value)
            Else
                conditioncellcolor()
            End If
        Next
        conditioncellcolor()
    End Sub
    Private Sub dtgOrder_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dtgOrder.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf dtgOrder_KeyPress
    End Sub
    Public Sub conditioncellcolor()
        For v As Integer = 0 To Me.dtgOrder.Rows.Count - 1
            For j As Integer = 0 To Me.dtgOrder.Columns.Count - 1
                If Me.dtgOrder.Rows(v).Cells(5).Value = "" Then
                    Me.dtgOrder.Rows(v).Cells(j).Style.BackColor = Color.Gray
                ElseIf Me.dtgOrder.Rows(v).Cells(5).Value <> "" Then
                    Me.dtgOrder.Rows(v).Cells(j).Style.BackColor = Color.Silver
                End If
            Next
        Next
    End Sub
    Public Sub conspecificcell()
        For v As Integer = 0 To Me.dtgOrder.Rows.Count - 1
            For j As Integer = 0 To Me.dtgOrder.Columns.Count - 1
                If Me.dtgOrder.Rows(v).Cells(5).Value > Label73.Text Then
                    Me.dtgOrder.Rows(v).Cells(j).Style.BackColor = Color.Gray
                Else
                    Me.dtgOrder.Rows(v).Cells(j).Style.BackColor = Color.Silver
                End If
            Next
        Next
    End Sub
    Private Sub bgColor()
        Dim child As Control
        For Each child In Me.Controls
            If TypeOf child Is MdiClient Then
                child.BackColor = Color.Wheat
                Exit For
            End If
        Next
        child = Nothing
    End Sub
    Public Sub Expired_Raw_Mats()
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "select COUNT(*) from raw_expiration_date where raw_expiration_date.Raw_Expiration_Date <= DATE_ADD(DATE(now()), INTERVAL 3 day) "
            objdr = objcmd.ExecuteReader
            Do While objdr.Read
                If objdr.HasRows Then
                    putExpired = objdr.GetInt32("Count(*)")
                End If
            Loop
            objdr.Close()
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Critical_Raw_Mats()
        Try
            objconn.Open()
            objcmd.Connection = objconn
            objcmd.CommandType = CommandType.Text
            objcmd.CommandText = "SELECT COUNT(*) from raw_expiration_date INNER Join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID INNER Join raw_material_table " _
                                & " ON  raw_expiration_date.Raw_ID = raw_material_table.Raw_ID WHERE raw_quantity < 2  AND unit_table.Unit_Name = 'dozen/s' OR raw_quantity < 3 AND unit_table.Unit_Name = 'kilo/s'  OR raw_quantity < 1 AND unit_table.Unit_Name = 'liter/s' "
            objdr = objcmd.ExecuteReader
            Do While objdr.Read
                If objdr.HasRows Then
                    putCritical = objdr.GetInt32("Count(*)")
                End If
            Loop

            objdr.Close()
            objconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Hidelabeladmin()
        lblOrderProduct.Visible = False
        lblAvailableProduct.Visible = False
        lblInventory2.Visible = False
        lblRawMaterials.Visible = False
        lblProducts.Visible = False
        lblRawMaterialsanditsProducts.Visible = False
        lblView2.Visible = False
        lblView3.Visible = False

        lblAccount.Visible = False
        lblExpiredRawMaterial.Visible = False
        lblCriticalRawMaterial.Visible = False
        lblRecords.Visible = False

        lblSystem2.Visible = False
        lblSystem3.Visible = False

        lblHelp2.Visible = False
        lblHelp3.Visible = False
        lblSystem4.Visible = False
        lblHelp4.Visible = False
        lblBackUpandRestore.Visible = False

        lblCalculator.Visible = False
        lblKeyboardShortcut.Visible = False
        lblViewHelp.Visible = False
        lblAbout.Visible = False

        Criticalquotation1.Visible = False
        Criticalquotation2.Visible = False
        Criticalquotation3.Visible = False
        Expiredasterisk1.Visible = False
        Expiredasterisk2.Visible = False
        Expiredasterisk3.Visible = False

    End Sub
    Public Sub Hidelabelcrew()
        lblOrderProduct_0.Visible = False
        lblAvailableProduct_0.Visible = False
        lblInventory2_0.Visible = False
        lblRawMaterials_0.Visible = False
        lblProducts_0.Visible = False
        lblRawMaterialsanditsProducts_0.Visible = False
        lblView2_0.Visible = False
        lblView3_0.Visible = False


        lblExpiredRawMaterial_0.Visible = False
        lblCriticalRawMaterial_0.Visible = False


        lblSystem2_0.Visible = False
        lblSystem3_0.Visible = False

        lblHelp2_0.Visible = False
        lblHelp3_0.Visible = False
        lblSystem4_0.Visible = False
        lblHelp4_0.Visible = False
        lblBackUpandRestore_0.Visible = False

        lblCalculator_0.Visible = False
        lblKeyboardShortcut_0.Visible = False
        lblViewHelp_0.Visible = False
        lblAbout_0.Visible = False

        Criticalquotation1_0.Visible = False
        Criticalquotation2_0.Visible = False
        Criticalquotation3_0.Visible = False
        Expiredasterisk1_0.Visible = False
        Expiredasterisk2_0.Visible = False
        Expiredasterisk3_0.Visible = False

    End Sub
    Public Sub showlabel()
        lblRawMaterials.Show()
        lblProducts.Show()
        lblRawMaterialsanditsProducts.Show()
    End Sub
    Public Sub hideadminnav()
        pctSales.Visible = False
        pctInventory.Visible = False
        pctView.Visible = False
        pctHelp.Visible = False
        pctSystem4.Visible = False
        pctView1.Visible = False
    End Sub
    Public Sub hidecrewnav()
        pctSales_0.Visible = False
        pctInventory_0.Visible = False
        pctView_0.Visible = False
        pctHelp_0.Visible = False
        pctSystem4_0.Visible = False
        pctView1_0.Visible = False
    End Sub
    Private Sub Modall_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        question = MsgBox("Do You Want To Logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text.ToString.ToLower & " were logout at ',CURRENT_TIMESTAMP, (select " _
                                 & "user_company_id from user_account where Username = Sha1('" & Loginfrm.UsernameTextBox.Text.ToString.ToLower & "') And Account_Type = '" & CStr(lblUser.Text) & "'))"
                .ExecuteNonQuery()
            End With
            objconn.Close()
            If objconn.State = ConnectionState.Open Then
                objconn.Close()
                objconn.Dispose()
            End If
            Me.Dispose()
            Loginfrm.Show()
            Loginfrm.lblPrompt.Text = "You Successfully Logged Out"
            Loginfrm.UsernameTextBox.Text = ""
            Loginfrm.PasswordTextBox.Text = ""
        ElseIf question = MsgBoxResult.No Then
            e.Cancel = True
            Exit Sub
        End If
    End Sub
    Private Sub Modall_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.P AndAlso e.Control And lblPrintCondition.Text = "a" Then
            PictureBox9_Click(PictureBox9, Nothing)
        ElseIf e.KeyCode = Keys.P AndAlso e.Control And lblPrintCondition.Text = "b" Then
            PictureBox7_Click(PictureBox7, Nothing)
        ElseIf e.KeyCode = Keys.P AndAlso e.Control And lblPrintCondition.Text = "c" Then
            pctprintCritical_Click(pctprintCritical, Nothing)
        ElseIf e.KeyCode = Keys.P AndAlso e.Control And lblPrintCondition.Text = "d" Then
            pctprintExpired_Click(pctprintExpired, Nothing)
        ElseIf e.KeyCode = Keys.P AndAlso e.Control And lblPrintCondition.Text = "e" Then 'Raw materials
            pctprintRaw_Click(pctprintRaw, Nothing)
        ElseIf e.KeyCode = Keys.P AndAlso e.Control And lblPrintCondition.Text = "f" Then ' Products
            pctprintProd_Click(pctprintProd, Nothing)
        ElseIf e.KeyCode = Keys.P AndAlso e.Control And lblPrintCondition.Text = "g" Then ' Products and its Raw Materials
            pctRawProdPrint_Click(pctRawProdPrint, Nothing)
        End If
    End Sub
    Private Sub txtSearchProd_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProd.TextChanged
        objdt = New DataTable
        objda = New MySqlDataAdapter("SELECT product_table.Product_Name,COALESCE(GROUP_CONCAT(TRIM(`Minus_Material_Every_Product`) + 0,' ',`Unit_Name`, ' of ',`Raw_Name`, ' at ',product_size.Size_Name, ' size ' SEPARATOR '\n'), '----')  AS 'CONSUME' " _
                                           & "from product_table  left join  `material_every_product` on product_table.Product_ID= material_every_product.Product_ID " _
                                           & "left join raw_material_table on raw_material_table.Raw_ID = material_every_product.Raw_ID left join unit_table " _
                                            & "on unit_table.Unit_ID = material_every_product.Unit_ID left join product_size " _
                                           & " on product_size.Size_ID = material_every_product.Size_ID " _
                                            & "where Product_Name like '%" & txtSearchProd.Text & "%' OR Unit_Name like '%" & txtSearchProd.Text & "%' OR Minus_Material_Every_Product like '%" & txtSearchProd.Text & "%' " _
                                       & "OR Raw_Name like '%" & txtSearchProd.Text & "%' OR Size_Name like '%" & txtSearchProd.Text & "%' GROUP by product_table.Product_Name ASC", objconn)
        objda.Fill(objdt)
        DataGridView2.DataSource = objdt
    End Sub
    Private Sub txtCriticalSearch_TextChanged(sender As Object, e As EventArgs) Handles txtCriticalSearch.TextChanged
        objdt = New DataTable
        objda = New MySqlDataAdapter("SELECT `Raw_Name` AS 'RAW_MATERIAL/S', CONCAT(TRIM(`Raw_Quantity`) + 0, '  ',`Unit_Name`) AS 'QUANTITY_LEFT' " _
                                        & "FROM raw_expiration_date INNER Join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID INNER Join raw_material_table " _
                                        & "ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID WHERE raw_quantity < 3  AND unit_table.Unit_Name = 'dozen/s' OR raw_quantity < 3 " _
                                        & "AND unit_table.Unit_Name = 'kilo/s'  OR raw_quantity < 2 AND unit_table.Unit_Name = 'liter/s' AND  Raw_Name like '%" & txtCriticalSearch.Text & "%'  Order by Raw_Name ASC", objconn)
        objda.Fill(objdt)
        DataGridView7.DataSource = objdt
    End Sub
    Private Sub lblprintExpired_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Expired_Raw_Mats_Report.Show()
    End Sub
    Private Sub lblprintCritical_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Critical_Raw_Mats_Report.Show()
    End Sub
    Private Sub cmdDeletebtnProdRaw_Click(sender As Object, e As EventArgs) Handles cmdDeletebtnProdRaw.Click
        question = MsgBox("Area you sure you want to remove selected " & Label4.Text & " product/s, consider with its raw material/s ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Red Cheese Pizza Message")
        If question = MsgBoxResult.Yes Then
            'yes of course
            For i As Integer = DataGridView2.Rows.Count() - 1 To 0 Step -1
                Dim delete As Boolean
                delete = DataGridView2.Rows(i).Cells(1).Value
                If delete = True Then
                    Try
                        objconn.Open()
                        DeleteQuery = "Delete  from product_table  where Product_Name  = '" & CStr(DataGridView2.Rows(i).Cells(2).Value.ToString) & "'"
                        objcmd = New MySqlCommand(DeleteQuery, objconn)
                        objdr = objcmd.ExecuteReader
                        objconn.Close()
                    Catch ex As Exception
                        MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
                    End Try
                End If
                Dim row As DataGridViewRow
                row = DataGridView2.Rows(i)
                DataGridView2.Rows.Remove(row)
            Next
            If objconn.State = ConnectionState.Open Then
                objconn.Close()
            End If
            fillProdukto()
            cmdDeletebtnProdRawHide.Visible = False
            cmdDeletebtnProdRaw.Show()
            Label4.Text = ""
            MsgBox("Successfully Deleted Product/s consider with its Raw Material/s !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Private Sub cmdDeletebtnRaw_Click(sender As Object, e As EventArgs) Handles cmdDeletebtnRaw.Click
        question = MsgBox("Are you sure you want to remove " & Label9.Text & " raw material/s ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Red Cheese Pizza Message")
        If question = MsgBoxResult.Yes Then
            'yes of course
            'yes of course
            For i As Integer = DataGridView3.Rows.Count() - 1 To 0 Step -1
                Dim deletes As Boolean
                deletes = DataGridView3.Rows(i).Cells(1).Value
                If deletes = True Then
                    Try
                        objconn.Open()
                        DeleteQuery = "Delete  from raw_material_table  where Raw_Name  = '" & CStr(DataGridView3.Rows(i).Cells(2).Value.ToString) & "'"
                        objcmd = New MySqlCommand(DeleteQuery, objconn)
                        objdr = objcmd.ExecuteReader
                        objconn.Close()
                    Catch ex As Exception
                        MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
                    End Try

                    objconn = New MySqlConnection
                    objconn.ConnectionString = "server=localhost; username=root; password=; database=red_cheese_pizza_database"
                    objconn.Open()

                    With objcmd
                        .Connection = objconn
                        .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text & " deleting raw material which is " & CStr(DataGridView3.Rows(i).Cells(2).Value.ToString) & " on ' ,CURRENT_TIMESTAMP, (Select user_Company_ID from user_table where Firstname = '" & lblUser.Text & "')) "
                        .ExecuteNonQuery()
                    End With
                    objconn.Close()
                End If
                Dim rowd As DataGridViewRow
                rowd = DataGridView3.Rows(i)
                DataGridView3.Rows.Remove(rowd)
            Next
            FillRawMats()
            cmdDeletebtnRawHide.Show()
            cmdDeletebtnRaw.Visible = False
            Label9.Text = ""
            MsgBox("Successfully Deleted Raw Material/s !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Private Sub txtSearchRaw_TextChanged(sender As Object, e As EventArgs) Handles txtSearchRaw.TextChanged
        objdt = New DataTable
        objda = New MySqlDataAdapter("SELECT CONCAT(UCASE(LEFT(Raw_Material_Table.Raw_Name,1)),LCASE(SUBSTRING(Raw_Material_Table.Raw_Name,2))) As Raw_Name, " _
                           & " CONCAT(CASE WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1000000 " _
                           & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mg/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1000000 , ' kG/s') " _
                           & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1000 " _
                           & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mg/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1000 , ' gram/s')" _
                           & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) + 0  >= 1 " _
                           & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mG/s' THEN 1 WHEN Unit_Name= 'gram/s'  THEN 1000 WHEN Unit_Name= 'kG/s' THEN 1000000 END)) / 1 , ' mG/s')" _
                           & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1000 " _
                           & " THEN CASE WHEN (TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) >= 3.785 THEN" _
                           & " CONCAT((TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) / 3.785 , ' gallon/s') " _
                           & "  WHEN (TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000) < 3.785 THEN" _
                           & " CONCAT((TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1000), ' liter/s') END" _
                           & " WHEN TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) + 0  >= 1 " _
                           & " THEN  CONCAT(TRIM(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'mL/s' THEN 1 WHEN Unit_Name= 'liter/s'  THEN 1000 WHEN Unit_Name= 'gallon/s' THEN 3785 END)) / 1 , ' mL/s')" _
                           & " WHEN SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12  END)  >= 12 " _
                           & " THEN  CONCAT(SUM(Raw_Quantity * CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) / 12 , ' dozen/s')" _
                           & " WHEN SUM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END) < 12 " _
                           & " THEN  CONCAT(TRIM(SUM(Raw_Quantity *  CASE  WHEN  Unit_Name= 'piece/s' THEN 1 WHEN Unit_Name= 'dozen/s'  THEN 12 END)) / 1 , ' piece/s')" _
                           & " END " _
                           & ") AS 'QUANTITY',  " _
                           & " GROUP_CONCAT(TRIM(CASE WHEN Raw_Quantity < 1 AND Unit_Name = 'gram/s' THEN Raw_Quantity *  1000  WHEN Raw_Quantity < 1 AND Unit_Name = 'kG/s' THEN " _
                           & " Raw_Quantity *  1000 WHEN Raw_Quantity < 1 AND Unit_Name = 'liter/s' THEN Raw_Quantity *  1000 WHEN Raw_Quantity > 3.785 AND Unit_Name = 'liter/s' " _
                           & " THEN Raw_Quantity /  3.785   WHEN Raw_Quantity < 1 AND Unit_Name = 'gallon/s' THEN " _
                           & " Raw_Quantity *  3.785  WHEN Raw_Quantity < 1 AND Unit_Name = 'dozen/s' THEN Raw_Quantity * 12 WHEN Raw_Quantity >= 12 AND Unit_Name = 'piece/s' " _
                           & " THEN Raw_Quantity / 12 ELSE Raw_Quantity END) + 0,' ',CASE WHEN Unit_Name = 'gram/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'mG/s'  WHEN Unit_Name = 'kG/s' " _
                           & " AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'gram/s' WHEN Unit_Name = 'liter/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'mL/s' " _
                           & " WHEN Unit_Name = 'gallon/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'liter/s' WHEN Unit_Name = 'liter/s' AND " _
                           & " Raw_Expiration_Date.Raw_Quantity > 3.785 THEN 'gallon/s' WHEN Unit_Name = 'piece/s' AND  Raw_Expiration_Date.Raw_Quantity > 12   THEN 'dozen/s' " _
                           & " WHEN Unit_Name = 'dozen/s' AND  Raw_Expiration_Date.Raw_Quantity < 1   THEN 'piece/s' ELSE Unit_Name END,' = ',DATE_FORMAT(Raw_Expiration_Date,'%m/%d/%Y\n'" _
                           & " ) SEPARATOR '')  AS 'Raw_Expiration_Date'" _
                         & " from Raw_Expiration_Date  inner join Raw_Material_Table ON Raw_Expiration_Date.Raw_ID=Raw_Material_Table.Raw_ID inner join unit_table  " _
                         & " ON unit_table.Unit_ID = raw_expiration_date.Unit_ID   where Raw_Quantity like '%" & txtSearchRaw.Text & "%' OR Unit_Name like '%" & txtSearchRaw.Text & "%' OR Raw_Name  like '%" & txtSearchRaw.Text & "%' OR Raw_Expiration_Date  like '%" & txtSearchRaw.Text & "%' GROUP BY Raw_Material_Table.Raw_ID order by Raw_Name ASC  ", objconn)
        objda.Fill(objdt)
        DataGridView3.DataSource = objdt
    End Sub
    Public Sub inventoryfunction()
        'grpExpired.Visible = False
        'For Each inventory As ToolStripMenuItem In MenuStrip2.Items
        '    InventoryToolStripMenuItem.BackColor = Color.PeachPuff
        '    For Each meh As ToolStripMenuItem In inventory.DropDownItems
        '        RawMaterialsToolStripMenuItem.BackColor = Color.PeachPuff
        '        ProductsToolStripMenuItem.BackColor = Color.PeachPuff
        '        ProductsanditsRawMaterialsToolStripMenuItem.BackColor = Color.PeachPuff
        '    Next
        'Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        Add_Raw_Material.Show()
    End Sub
    Private Sub ToolStripMenuItem18_Click(sender As Object, e As EventArgs)
        Import_and_Export.Show()
    End Sub
    Private Sub lblOrderProduct_Click(sender As Object, e As EventArgs) Handles lblOrderProduct.Click
        lblOrderProductClick()
    End Sub
    Private Sub lblOrderProduct_0_Click(sender As Object, e As EventArgs) Handles lblOrderProduct_0.Click
        lblOrderProductClick_0()
    End Sub
    Private Sub lblAvailableProduct_Click(sender As Object, e As EventArgs) Handles lblAvailableProduct.Click
        fillcmbcategory()
        lblAvailableProductClick()
    End Sub
    Private Sub lblAvailableProduct_0_Click(sender As Object, e As EventArgs) Handles lblAvailableProduct_0.Click
        fillcmbcategory()

        lblAvailableProductClick_0()
    End Sub
    Private Sub lblRawMaterials_Click(sender As Object, e As EventArgs) Handles lblRawMaterials.Click
        lblRawMaterialsClick()
        'lblRawMaterials.ForeColor = Color.Red
        'lblOrderProduct.ForeColor = Color.DarkRed
        'lblAvailableProduct.ForeColor = Color.DarkRed
        'lblAbout.ForeColor = Color.DarkRed
        'lblAccount.ForeColor = Color.DarkRed
        'lblBackUpandRestore.ForeColor = Color.DarkRed
        'lblCalculator.ForeColor = Color.DarkRed
        'lblCriticalRawMaterial.ForeColor = Color.DarkRed
        'lblExpiredRawMaterial.ForeColor = Color.DarkRed
        'lblKeyboardShortcut.ForeColor = Color.DarkRed
        'lblOrderProduct.ForeColor = Color.DarkRed
        'lblOrderProduct.ForeColor = Color.DarkRed
        'lblProducts.ForeColor = Color.DarkRed
        'lblRawMaterialsanditsProducts.ForeColor = Color.DarkRed
        'lblRecords.ForeColor = Color.DarkRed
        'lblViewHelp.ForeColor = Color.DarkRed


    End Sub
    Private Sub lblRawMaterials_0_Click(sender As Object, e As EventArgs) Handles lblRawMaterials_0.Click
        lblRawMaterialsClick()
        'lblRawMaterials_0.ForeColor = Color.Red
        'lblOrderProduct_0.ForeColor = Color.DarkRed
        'lblAvailableProduct_0.ForeColor = Color.DarkRed
        'lblAbout_0.ForeColor = Color.DarkRed
        'lblAccount.ForeColor = Color.DarkRed
        'lblBackUpandRestore_0.ForeColor = Color.DarkRed
        'lblCalculator_0.ForeColor = Color.DarkRed
        'lblCriticalRawMaterial_0.ForeColor = Color.DarkRed
        'lblExpiredRawMaterial_0.ForeColor = Color.DarkRed
        'lblKeyboardShortcut_0.ForeColor = Color.DarkRed
        'lblOrderProduct_0.ForeColor = Color.DarkRed
        'lblOrderProduct_0.ForeColor = Color.DarkRed
        'lblProducts_0.ForeColor = Color.DarkRed
        'lblRawMaterialsanditsProducts_0.ForeColor = Color.DarkRed
        'lblRecords.ForeColor = Color.DarkRed
        'lblViewHelp_0.ForeColor = Color.DarkRed
    End Sub
    Private Sub lblProducts_Click(sender As Object, e As EventArgs) Handles lblProducts.Click
        lblProductsClick()
        'lblRawMaterials.ForeColor = Color.DarkRed
        'lblOrderProduct.ForeColor = Color.DarkRed
        'lblAvailableProduct.ForeColor = Color.DarkRed
        'lblAbout.ForeColor = Color.DarkRed
        'lblAccount.ForeColor = Color.DarkRed
        'lblBackUpandRestore.ForeColor = Color.DarkRed
        'lblCalculator.ForeColor = Color.DarkRed
        'lblCriticalRawMaterial.ForeColor = Color.DarkRed
        'lblExpiredRawMaterial.ForeColor = Color.DarkRed
        'lblKeyboardShortcut.ForeColor = Color.DarkRed
        'lblOrderProduct.ForeColor = Color.DarkRed
        'lblOrderProduct.ForeColor = Color.DarkRed
        'lblProducts.ForeColor = Color.Red
        'lblRawMaterialsanditsProducts.ForeColor = Color.DarkRed
        'lblRecords.ForeColor = Color.DarkRed
        'lblViewHelp.ForeColor = Color.DarkRed

    End Sub
    Private Sub lblProducts_0_Click(sender As Object, e As EventArgs) Handles lblProducts_0.Click
        lblProductsClick()
        'lblRawMaterials_0.ForeColor = Color.Red
        'lblOrderProduct_0.ForeColor = Color.DarkRed
        'lblAvailableProduct_0.ForeColor = Color.DarkRed
        'lblAbout_0.ForeColor = Color.DarkRed
        'lblAccount.ForeColor = Color.DarkRed
        'lblBackUpandRestore_0.ForeColor = Color.DarkRed
        'lblCalculator_0.ForeColor = Color.DarkRed
        'lblCriticalRawMaterial_0.ForeColor = Color.DarkRed
        'lblExpiredRawMaterial_0.ForeColor = Color.DarkRed
        'lblKeyboardShortcut_0.ForeColor = Color.DarkRed
        'lblOrderProduct_0.ForeColor = Color.DarkRed
        'lblOrderProduct_0.ForeColor = Color.DarkRed
        'lblProducts_0.ForeColor = Color.DarkRed
        'lblRawMaterialsanditsProducts_0.ForeColor = Color.DarkRed
        'lblRecords.ForeColor = Color.DarkRed
        'lblViewHelp_0.ForeColor = Color.DarkRed
    End Sub
    Private Sub lblRawMaterialsanditsProducts_Click(sender As Object, e As EventArgs) Handles lblRawMaterialsanditsProducts.Click
        lblRawMaterialsanditsProductsClick()

    End Sub
    Private Sub lblRawMaterialsanditsProducts_0_Click(sender As Object, e As EventArgs) Handles lblRawMaterialsanditsProducts_0.Click
        lblRawMaterialsanditsProductsClick()
    End Sub
    Private Sub lblAccount_0_Click(sender As Object, e As EventArgs) Handles lblAccount.Click
        User_Account.Show()
    End Sub
    Private Sub lblAccount_Click(sender As Object, e As EventArgs) Handles lblAccount.Click
        User_Account.Show()
    End Sub
    Private Sub lblBackUpandRestore_Click(sender As Object, e As EventArgs) Handles lblBackUpandRestore.Click
        Import_and_Export.Show()
    End Sub
    Private Sub lblBackUpandRestore_0_Click(sender As Object, e As EventArgs) Handles lblBackUpandRestore_0.Click
        Import_and_Export.Show()
    End Sub
    Private Sub txtSearchProducts_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProducts.TextChanged
        objdt = New DataTable
        objda = New MySqlDataAdapter("Select product_table.Product_Name,Sum(product_quantity.Quantity) As 'QUANTITY', " _
                                         & " COALESCE(GROUP_CONCAT((Case when category.Cat_ID = 1 or category.Cat_ID = 2 or category.Cat_ID = 3  or category.Cat_ID = 5 or category.Cat_ID = 10 Then  CONCAT(product_quantity.Quantity, ' pieces') " _
                                         & " When category.Cat_ID = 6 Then CONCAT(product_quantity.Quantity, ' Solo') " _
                                         & " When category.Cat_ID = 8 OR category.Cat_ID = 9 Then CONCAT(product_quantity.Quantity, ' per serving') " _
                                         & " When category.Cat_ID = 11 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                         & " When category.Cat_ID = 12 And product_size.Size_Name = 'Can' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (Cans)' Else ' bottle (Can)' END) ) " _
                                         & " When category.Cat_ID = 12 And product_size.Size_Name = '12 oz.' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (12.oz.)' Else ' bottle (12.oz.)' END) ) " _
                                         & " When category.Cat_ID = 12 And product_size.Size_Name = '1.5 Liters' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' bottles (1.5 liters)' Else ' bottle (1.5 liters)' END) ) " _
                                         & " When category.Cat_ID = 12 And product_size.Size_Name = 'Glass' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Glasses' Else ' Glass' END) ) " _
                                         & " When category.Cat_ID = 12 And product_size.Size_Name = 'Pitcher' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Pitchers' Else ' Pitcher' END) ) " _
                                         & " When category.Cat_ID = 12 And product_size.Size_Name = 'Cup' Then  CONCAT(product_quantity.Quantity, (CASE when product_quantity.Quantity > 1 Then ' Cups' Else ' Cup' END) ) " _
                                         & " When category.Cat_ID = 12 And product_size.Size_Name = 'Small' Then   CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Small Size' Else ' piece Small size' END)) " _
                                         & " When category.Cat_ID = 12 And product_size.Size_Name = 'Medium' Then  CONCAT(product_quantity.Quantity,(CASE when product_quantity.Quantity > 1 Then ' pieces Medium Size' Else ' piece Medium size' END)) " _
                                         & " ELSE  CONCAT(product_quantity.Quantity,' box/es ',product_size.Size_Name, ' size') END) SEPARATOR '\n'), ' Not Available') AS 'SIZE', " _
                                         & " Group_Concat('₱ ', TRIM(product_quantity.Price) + 0 SEPARATOR '\n') As 'Prices' " _
                                            & " from product_quantity right join product_table on product_quantity.Product_ID = product_table.Product_ID " _
                                            & " left join product_size on product_quantity.Size_ID = product_size.size_ID inner JOIN category on product_table.Cat_ID = category.Cat_ID  where  Product_Name like '%" & txtSearchProducts.Text & "%' OR Size_Name like '%" & txtSearchProducts.Text & "%' OR Quantity like '%" & txtSearchProducts.Text & "%'  " _
                                            & " group by product_table.Product_Name ASC", objconn)
        objda.Fill(objdt)
        DataGridView4.DataSource = objdt
    End Sub
    Private Sub txtExpiredSearch_TextChanged(sender As Object, e As EventArgs) Handles txtExpiredSearch.TextChanged
        objdt = New DataTable
        objda = New MySqlDataAdapter("select  Raw_Name,CONCAT(TRIM(`Raw_Quantity`) + 0, ' ',`Unit_Name`) As 'QUANTITY',DATE_FORMAT(Raw_Expiration_Date,'%c/%d/%Y') AS 'EXPIRED_PROD' " _
                                     & "from raw_expiration_date inner join unit_table ON raw_expiration_date.Unit_ID = unit_table.Unit_ID inner join raw_material_table " _
                                     & "ON raw_expiration_date.Raw_ID = raw_material_table.Raw_ID where raw_expiration_date.Raw_Expiration_Date <= DATE_ADD(DATE(now()), " _
                                     & "INTERVAL 3 day) AND raw_material_table.Raw_Name like '%" & txtExpiredSearch.Text & "%' " _
                                     & " ORDER by raw_material_table.Raw_Name ASC", objconn)
        objda.Fill(objdt)
        DataGridView6.DataSource = objdt
    End Sub
    Private Sub lblCalculator_Click(sender As Object, e As EventArgs) Handles lblCalculator.Click
        Shell("Calc.exe")
    End Sub
    Private Sub lblCalculator_0_Click(sender As Object, e As EventArgs) Handles lblCalculator_0.Click
        Shell("Calc.exe")
    End Sub
    Private Sub lblKeyboardShortcut_0_Click(sender As Object, e As EventArgs) Handles lblKeyboardShortcut_0.Click
        Key_Shortcut.Show()
    End Sub
    Private Sub lblKeyboardShortcut_Click(sender As Object, e As EventArgs) Handles lblKeyboardShortcut.Click
        Key_Shortcut.Show()
    End Sub
    Private Sub Expiredasterisk3_Click(sender As Object, e As EventArgs) Handles Expiredasterisk3.Click
        Expiredasterisk3Click()
    End Sub
    Private Sub Expiredasterisk3_0_Click(sender As Object, e As EventArgs) Handles Expiredasterisk3_0.Click
        Expiredasterisk3Click()
    End Sub
    Private Sub Expiredasterisk2_Click(sender As Object, e As EventArgs) Handles Expiredasterisk2.Click
        Expiredasterisk2Click()
    End Sub
    Private Sub Expiredasterisk2_0_Click(sender As Object, e As EventArgs) Handles Expiredasterisk2_0.Click
        Expiredasterisk2Click()
    End Sub
    Private Sub Expiredasterisk1_Click(sender As Object, e As EventArgs) Handles Expiredasterisk1.Click
        Expiredasterisk1Click()
    End Sub
    Private Sub Expiredasterisk1_0_Click(sender As Object, e As EventArgs) Handles Expiredasterisk1_0.Click
        Expiredasterisk1Click()
    End Sub
    Private Sub Criticalquotation1_Click(sender As Object, e As EventArgs) Handles Criticalquotation1.Click
        Criticalquotation1Click()
    End Sub
    Private Sub dtgOrder_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtgOrder.KeyPress

        If dtgOrder.CurrentCell.ColumnIndex = 3 Then
            AllowOnlyNumeric(e)
        End If

    End Sub
    Private Sub Criticalquotation1_0_Click(sender As Object, e As EventArgs) Handles Criticalquotation1_0.Click
        Criticalquotation1Click()
    End Sub
    Private Sub Criticalquotation2_Click(sender As Object, e As EventArgs) Handles Criticalquotation2.Click
        Criticalquotation2Click()
    End Sub
    Private Sub Criticalquotation2_0_Click(sender As Object, e As EventArgs) Handles Criticalquotation2_0.Click
        Criticalquotation2Click()
    End Sub
    Private Sub Criticalquotation3_Click(sender As Object, e As EventArgs) Handles Criticalquotation3.Click
        Criticalquotation3Click()
    End Sub
    Private Sub Criticalquotation3_0_Click(sender As Object, e As EventArgs) Handles Criticalquotation3_0.Click
        Criticalquotation3Click()
    End Sub
    Private Sub lblPrintExpired_Click(sender As Object, e As EventArgs) Handles lblPrintExpired.Click
        If putExpired = "0" Then
            MessageBox.Show("There an empty Expired Raw Material so that you don't have permission to print expired raw material/s.", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf putExpired > 0 Then
            Expired_Raw_Mats_Report.Show()
        End If
    End Sub
    Private Sub pctprintExpired_Click(sender As Object, e As EventArgs) Handles pctprintExpired.Click
        If putExpired = "0" Then
            MessageBox.Show("There an empty Expired Raw Material so that you don't have permission to print expired raw material/s.", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf putExpired > 0 Then
            Expired_Raw_Mats_Report.Show()
        End If
    End Sub
    Private Sub lblprintCritical_Click(sender As Object, e As EventArgs)
        If putCritical = 0 Then
            MessageBox.Show("There an empty Critical Raw Material so that you don't have permission to print critical raw material/s.", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf putCritical > 0 Then
            Critical_Raw_Mats_Report.Show()
        End If
    End Sub
    Private Sub pctprintCritical_Click(sender As Object, e As EventArgs) Handles pctprintCritical.Click
        If putCritical = 0 Then
            MessageBox.Show("There an empty Critical Raw Material so that you don't have permission to print critical raw material/s.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf putCritical > 0 Then
            Critical_Raw_Mats_Report.Show()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label52.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub
    Private Sub lblSales_MouseHover(sender As Object, e As EventArgs) Handles lblSales.MouseHover
        Sales_Hover()
    End Sub
    Private Sub lblSales_0_MouseHover(sender As Object, e As EventArgs) Handles lblSales_0.MouseHover
        Sales_Hover_0()
    End Sub
    Private Sub lblInventory1_MouseHover(sender As Object, e As EventArgs) Handles lblInventory1.MouseHover
        lblInventory1MouseHover()
    End Sub
    Private Sub lblInventory1_0_MouseHover(sender As Object, e As EventArgs) Handles lblInventory1_0.MouseHover
        lblInventory1MouseHover_0()
    End Sub
    Private Sub lblInventory2_MouseHover(sender As Object, e As EventArgs) Handles lblInventory2.MouseHover
        lblInventory2MouseHover()
    End Sub
    Private Sub lblInventory2_0_MouseHover(sender As Object, e As EventArgs) Handles lblInventory2_0.MouseHover
        lblInventory2MouseHover_0()
    End Sub
    Private Sub lblView1_MouseHover(sender As Object, e As EventArgs) Handles lblView1.MouseHover
        lblView1MouseHover()
    End Sub
    Private Sub lblView1_0_MouseHover(sender As Object, e As EventArgs) Handles lblView1_0.MouseHover
        lblView1MouseHover_0()
    End Sub
    Private Sub lblView2_MouseHover(sender As Object, e As EventArgs) Handles lblView2.MouseHover
        lblView2MouseHover()
    End Sub
    Private Sub lblView2_0_MouseHover(sender As Object, e As EventArgs) Handles lblView2_0.MouseHover
        lblView2MouseHover_0()
    End Sub
    Private Sub lblView3_MouseHover(sender As Object, e As EventArgs) Handles lblView3.MouseHover
        lblView3MouseHover()
    End Sub
    Private Sub lblView3_0_MouseHover(sender As Object, e As EventArgs) Handles lblView3_0.MouseHover
        lblView3MouseHover_0()
    End Sub
    Private Sub lblSystem1_MouseHover(sender As Object, e As EventArgs) Handles lblSystem1.MouseHover
        lblSystem1MouseHover()
    End Sub
    Private Sub lblSystem1_0_MouseHover(sender As Object, e As EventArgs) Handles lblSystem1_0.MouseHover
        lblSystem1MouseHover_0()
    End Sub
    Private Sub lblSystem2_MouseHover(sender As Object, e As EventArgs) Handles lblSystem2.MouseHover
        lblSystem2MouseHover()
    End Sub
    Private Sub lblSystem2_0_MouseHover(sender As Object, e As EventArgs) Handles lblSystem2_0.MouseHover
        lblSystem2MouseHover_0()
    End Sub
    Private Sub lblSystem3_MouseHover(sender As Object, e As EventArgs) Handles lblSystem3.MouseHover
        lblSystem3MouseHover()
    End Sub
    Private Sub lblSystem3_0_MouseHover(sender As Object, e As EventArgs) Handles lblSystem3_0.MouseHover
        lblSystem3MouseHover_0()
    End Sub
    Private Sub lblSystem4_MouseHover(sender As Object, e As EventArgs) Handles lblSystem4.MouseHover
        lblSystem4MouseHover()
    End Sub
    Private Sub lblSystem4_0_MouseHover(sender As Object, e As EventArgs) Handles lblSystem4_0.MouseHover
        lblSystem4MouseHover_0()
    End Sub
    Private Sub lblHelp1_MouseHover(sender As Object, e As EventArgs) Handles lblHelp1.MouseHover
        lblHelp1MouseHover()
    End Sub
    Private Sub lblHelp1_0_MouseHover(sender As Object, e As EventArgs) Handles lblHelp1_0.MouseHover
        lblHelp1MouseHover_0()
    End Sub
    Private Sub lblHelp2_MouseHover(sender As Object, e As EventArgs) Handles lblHelp2.MouseHover
        lblHelp2MouseHover()
    End Sub
    Private Sub lblHelp2_0_MouseHover(sender As Object, e As EventArgs) Handles lblHelp2_0.MouseHover
        lblHelp2MouseHover_0()
    End Sub
    Private Sub lblHelp3_MouseHover(sender As Object, e As EventArgs) Handles lblHelp3.MouseHover
        lblHelp3MouseHover()
    End Sub
    Private Sub lblHelp3_0_MouseHover(sender As Object, e As EventArgs) Handles lblHelp3_0.MouseHover
        lblHelp3MouseHover_0()
    End Sub
    Private Sub lblHelp4_MouseHover(sender As Object, e As EventArgs) Handles lblHelp4.MouseHover
        lblHelp4MouseHover()
    End Sub
    Private Sub lblHelp4_0_MouseHover(sender As Object, e As EventArgs) Handles lblHelp4_0.MouseHover
        lblHelp4MouseHover_0()
    End Sub
    Private Sub btnExpired_Click(sender As Object, e As EventArgs) Handles btnExpired.Click
        btnExpired_Call()
    End Sub
    Private Sub txtAvailableProdSearch_TextChanged(sender As Object, e As EventArgs) Handles txtAvailableProdSearch.TextChanged
        If cmbcategory.SelectedIndex = 0 Then
            searchcmb1()
        ElseIf cmbcategory.SelectedIndex = 1 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 2 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 3 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 4 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 5 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 6 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 7 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 8 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 9 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 10 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 11 Then
            searchcmb()
        ElseIf cmbcategory.SelectedIndex = 12 Then
            searchcmb()
        End If
    End Sub
    Private Sub cmdDeletebtnProd_Click(sender As Object, e As EventArgs) Handles cmdDeletebtnProd.Click
        cmdDeletebtnProd_Call()
    End Sub
    Private Sub btnAvailableProd_Click(sender As Object, e As EventArgs) Handles btnAvailableProd.Click
        btnAvailableProd_Call()
    End Sub
    Private Sub DataGridView8_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView8.CellClick
        cmbOrderSize.Items.Clear()
        cmbOrderSize.Text = ""
        txtOrderName.Text = ""
        txtPrice.Text = ""
        clicking = DataGridView8(2, DataGridView8.CurrentRow.Index).Value.ToString()
        Try
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "Select product_table.Product_Name, ( CASE WHEN Sum(product_quantity.Quantity)  IS NULL THEN 0 ELSE " _
                               & " Sum(product_quantity.Quantity) END) As 'QUANTITY' from  product_quantity right join product_table on " _
                               & " product_quantity.Product_ID = product_table.Product_ID  left join product_size on  product_quantity.Size_ID " _
                               & " = product_size.size_ID  where  product_table.Product_Name = '" & clicking & "'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    txtOrderName.Text = objdr.GetString("Product_Name")
                    txtSumDisplay = objdr.GetInt32("QUANTITY")
                End While

                If txtSumDisplay > 0 Then
                    txtOrderName.Enabled = True
                    txtOrderQuant.Enabled = True
                    cmbOrderSize.Enabled = True
                    btnOrderProd.Enabled = True
                    txtOrderQuant.Text = ""
                ElseIf txtSumDisplay = 0 Then
                    txtOrderQuant.Enabled = False
                    cmbOrderSize.Enabled = False
                    btnOrderProd.Enabled = False
                    cmbOrderSize.Text = "N/A"
                End If
            End If

            objconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "SELECT product_size.Size_Name As 'true_size',(Case when product_size.Size_Name = 'None' Then 'pieces' Else product_size.Size_Name End) As 'Size'  " _
                             & " from product_quantity INNER join product_table on product_quantity.Product_ID = " _
                             & " product_table.Product_ID  INNER join product_size on product_quantity.Size_ID = product_size.size_ID  INNER join category " _
                             & " on product_table.CAT_ID = category.Cat_ID WHERE product_table.Product_Name = '" & clicking & "'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    true_size = objdr.GetString("true_size")
                    fillsize = objdr.GetString("Size")
                    cmbOrderSize.Items.Add(fillsize)
                End While
            End If
            objconn.Dispose()
            objconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If cmbOrderSize.Items.Count > 1 Then
            cmbOrderSize.SelectedIndex = -1
        End If
    End Sub
    Private Sub cmbOrderSize_TextChanged(sender As Object, e As EventArgs) Handles cmbOrderSize.TextChanged

    End Sub
    Private Sub cmbOrderSize_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbOrderSize.SelectedIndexChanged
        Label72.Text = cmbOrderSize.SelectedItem
        If cmbOrderSize.SelectedItem = "pieces" Then
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "Select  Quantity,Price from product_quantity inner join product_table  on product_quantity.Product_ID = product_table.Product_ID " _
                    & "inner join product_size on product_quantity.Size_ID = product_size.Size_ID where product_Name = '" & CStr(txtOrderName.Text) & "' And product_size.Size_Name='None'"
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    txtPrice.Text = objdr.GetDecimal("Price")
                End While
            End If

            objconn.Close()
        Else
            objconn.Open()
            objdt = New DataTable
            With objcmd
                .Connection = objconn
                .CommandText = "Select  Quantity,Price from product_quantity inner join product_table  on product_quantity.Product_ID = product_table.Product_ID " _
                    & "inner join product_size on product_quantity.Size_ID = product_size.Size_ID where product_Name = '" & CStr(txtOrderName.Text) & "' And  product_size.Size_Name='" & CStr(Label72.Text) & "' "
            End With
            objda.SelectCommand = objcmd
            objda.Fill(objdt)
            objdr = objcmd.ExecuteReader
            If objdr.HasRows Then
                While objdr.Read
                    txtPrice.Text = objdr.GetDecimal("Price")
                End While
            End If

            objconn.Close()

        End If

        Try
            objconn.Open()
            cmbQuery = "SELECT product_quantity.Quantity As 'quant_test' from product_quantity INNER join product_table on product_quantity.Product_ID =  " _
                              & " product_table.Product_ID INNER join product_size on product_size.Size_ID = product_quantity.Size_ID where product_table.Product_Name " _
                              & " = '" & clicking & "' And product_size.Size_Name = '" & Label72.Text & "'"
            objcmd = New MySqlCommand(cmbQuery, objconn)
            objdr = objcmd.ExecuteReader
            While objdr.Read
                Label73.Text = objdr.GetInt32("quant_test")
            End While
            objconn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Red Cheese Pizza Error Program, Contact Programmer about this. Thank You.")
        End Try
    End Sub
    Private Sub txtOrderQuant_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub
    Private Sub cmbOrderSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbOrderSize.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub txtOrderName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrderName.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedCharacters.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub lblPrintAvailableProd_Click(sender As Object, e As EventArgs) Handles lblPrintAvailableProd.Click
        Available_Prod_Report.Show()
    End Sub
    Private Sub txtSearchOrderProd_TextChanged(sender As Object, e As EventArgs) Handles txtSearchOrderProd.TextChanged
        objdt = New DataTable
        objda = New MySqlDataAdapter("SELECT product_table.Product_Name, CONCAT(Order_Quantity , CASE WHEN order_table.Order_Quantity > 1 THEN ' box/es' ELSE ' box' END) AS 'QUANTITY',Concat(product_size.Size_Name, ' size') As 'SIZES',DATE_FORMAT(order_table.Order_Date,'%c/%d/%Y %h:%i %p') " _
                                     & " As 'Order_Date' FROM `order_table` inner join product_table on order_table.Product_ID = product_table.Product_ID inner JOIN product_size on order_table.Size_ID = product_size.Size_ID  " _
                                     & " where product_table.Product_Name like '%" & txtSearchOrderProd.Text & "%' OR product_size.Size_Name like '%" & txtSearchOrderProd.Text & "%' OR order_table.Order_Quantity like '%" & txtSearchOrderProd.Text & "%' OR DATE_FORMAT(order_table.Order_Date,'%c/%d/%Y %h:%i %p') like " _
                                     & " '%" & txtSearchOrderProd.Text & "%' Order by product_table.Product_Name ASC", objconn)

        objda = New MySqlDataAdapter("SELECT product_table.Product_Name, CONCAT(Order_Quantity , CASE " _
                                           & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 16) or " _
                                           & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 6) or " _
                                            & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 7) or " _
                                & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 8) THEN ' piece/s' " _
                             & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 9)  THEN ' Glass/es' " _
                                                            & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 10)  THEN ' Pitcher/s' " _
                                                                                           & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 11)  THEN ' Cup/s' " _
                                           & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 1) or " _
                                           & "  product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 2) or " _
                                           & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 3) or " _
                                           & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 4) or " _
                                    & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 5) THEN ' box/es' " _
                                           & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 12) or " _
                                           & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 13) or " _
                           & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 14) THEN ' bottle/s' " _
                              & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 15) THEN ' can/s'  END, ' (',(Case when product_size.Size_Name " _
                              & " = 'None' Then 'piece/s'  Else   Concat(product_size.Size_Name, ' size') End ) , ') ') AS 'QUANTITY',Concat('P ',Price) As 'Price', DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As 'Order_Date' FROM order_table " _
                              & " inner join product_table on order_table.Product_ID = product_table.Product_ID  inner JOIN product_size on order_table.Size_ID = product_size.Size_ID " _
                                     & " where product_table.Product_Name like '%" & txtSearchOrderProd.Text & "%' OR product_size.Size_Name like '%" & txtSearchOrderProd.Text & "%' OR order_table.Order_Quantity like '%" & txtSearchOrderProd.Text & "%' OR DATE_FORMAT(order_table.Order_Date,'%c/%d/%Y %h:%i %p') like " _
                                     & " '%" & txtSearchOrderProd.Text & "%' Order by product_table.Product_Name ASC", objconn)



        objda.Fill(objdt)
        DataGridView9.DataSource = objdt
    End Sub
    Private Sub lblAbout_0_Click(sender As Object, e As EventArgs) Handles lblAbout_0.Click
        About_Us.Show()
    End Sub
    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        About_Us.Show()
    End Sub
    Private Sub lblViewHelp_Click(sender As Object, e As EventArgs) Handles lblViewHelp.Click
        Help.Show()
    End Sub
    Private Sub lblViewHelp_0_Click(sender As Object, e As EventArgs) Handles lblViewHelp_0.Click
        Help.Show()
    End Sub
    Private Sub lblExpiredRawMaterial_Click(sender As Object, e As EventArgs) Handles lblExpiredRawMaterial.Click
        lblExpiredRawMaterialClick()
    End Sub
    Private Sub lblExpiredRawMaterial_0_Click(sender As Object, e As EventArgs) Handles lblExpiredRawMaterial_0.Click
        lblExpiredRawMaterialClick()
    End Sub
    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        If objconn.State = ConnectionState.Open Then
            objconn.Close()
        End If
        AddProduct.Show()
    End Sub
    Private Sub lblRecords_Click(sender As Object, e As EventArgs) Handles lblRecords.Click
        lblRecordsClick()
    End Sub
    Private Sub lblRecords_0_Click(sender As Object, e As EventArgs)
        lblRecordsClick()
    End Sub
    Private Sub lblCriticalRawMaterial_Click(sender As Object, e As EventArgs) Handles lblCriticalRawMaterial.Click
        lblCriticalRawMaterialClick()
    End Sub
    Private Sub lblCriticalRawMaterial_0_Click(sender As Object, e As EventArgs) Handles lblCriticalRawMaterial_0.Click
        lblCriticalRawMaterialClick()
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If dtpDateFrom.CustomFormat = " " Then  'An empty 
            MessageBox.Show("Required field", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDateFrom.BackColor = Color.PapayaWhip
            dtpDateFrom.Focus()

        ElseIf dtpDateTo.CustomFormat = " " Then  'An empty SPACE        
            MessageBox.Show("Required field", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDateTo.BackColor = Color.PapayaWhip
            dtpDateTo.Focus()

        Else
            SearchLogsUser()
        End If
    End Sub
    Private Sub dtpDateFomSales_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFomSales.ValueChanged
        dtpDateFomSales.CustomFormat = "yyyy-MM-dd hh:mm:ss"
    End Sub
    Private Sub dtpDateToSales_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateToSales.ValueChanged
        dtpDateToSales.CustomFormat = "yyyy-MM-dd hh:mm:ss"
    End Sub
    Private Sub dtpDateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateFrom.ValueChanged
        dtpDateFrom.CustomFormat = "MM/dd/yyyy hh:mm tt"
    End Sub
    Private Sub dtpDateTo_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTo.ValueChanged
        dtpDateTo.CustomFormat = "MM/dd/yyyy hh:mm tt"
    End Sub
    Private Sub lblSignout_Click(sender As Object, e As EventArgs) Handles lblSignout.Click
        question = MsgBox("Do You Want To Logout?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
        If question = MsgBoxResult.Yes Then
            objconn.Open()
            With objcmd
                .Connection = objconn
                .CommandText = "Insert Into logs (Log_ID,Log_View,Log_Date,User_Company_ID)values (NULL,'" & Loginfrm.UsernameTextBox.Text.ToString.ToLower & " were logout at ',CURRENT_TIMESTAMP, (select " _
                                 & "user_company_id from user_account where Username = Sha1('" & Loginfrm.UsernameTextBox.Text.ToString.ToLower & "') And Account_Type = '" & CStr(lblAccountType.Text) & "'))"
                .ExecuteNonQuery()
            End With
            objconn.Close()
            objconn.Dispose()
            If objconn.State = ConnectionState.Open Then
                objconn.Close()
            End If
            Me.Dispose()
            Loginfrm.Show()
            Loginfrm.lblPrompt.Text = "You Successfully Logged Out"
            Loginfrm.UsernameTextBox.Text = ""
            Loginfrm.PasswordTextBox.Text = ""
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Private Sub btnDeleteLog_Click_1(sender As Object, e As EventArgs) Handles btnDeleteLog.Click
        question = MsgBox("Area you sure you want to remove " & Label48.Text & " log/s of all user ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Red Cheese Pizza Message")
        If question = MsgBoxResult.Yes Then
            'yes of course
            For i As Integer = DataGridView10.Rows.Count() - 1 To 0 Step -1
                Dim deletes As Boolean
                deletes = DataGridView10.Rows(i).Cells(1).Value
                If deletes = True Then
                    Try
                        objconn.Open()
                        DeleteQuery = "delete from logs where DATE_FORMAT(logs.Log_Date, '%m/%d/%Y') =  '" & CStr(DataGridView10.Rows(i).Cells(2).Value.ToString) & "'"
                        objcmd = New MySqlCommand(DeleteQuery, objconn)
                        objdr = objcmd.ExecuteReader
                        objconn.Close()
                    Catch ex As Exception
                        MsgBox(Err.Description, MsgBoxStyle.Critical, "Contact your Programmer About this Error. Thank You.")
                    End Try
                End If
                Dim row As DataGridViewRow
                row = DataGridView10.Rows(i)
                DataGridView10.Rows.Remove(row)
            Next
            fillLogRec()
            btn.Visible = False
            btnDeleteLogHide.Show()
            MsgBox("Successfully Deleted !", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Private Sub btnOrderProd_Click(sender As Object, e As EventArgs) Handles btnOrderProd.Click
        If txtOrderQuant.Text = "" Then
            MsgBox("Enter Quantity", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        ElseIf txtOrderQuant.Text = "0" Then
            MsgBox("Not allowed Quantity", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        ElseIf IsNothing(cmbOrderSize.SelectedItem) Then
            MsgBox("Select Size", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        Else
            'dito
            Dim firstColumnprod As String = txtOrderName.Text
            Dim secondColumnquant As String = txtOrderQuant.Text
            Dim thirdColumndesc As String = cmbOrderSize.Text
            Dim fourthColumnprice As String = CDec(txtPrice.Text)
            ' Dim secondColumndesc As String = cmbOrderSize.Text
            '  Dim thirdColumnprice As String = CDec(txtPrice.Text)
            ' Dim fourthColumnquant As String = txtOrderQuant.Text
            Dim fifthColumntotal As Decimal = CInt(txtOrderQuant.Text) * CDec(txtPrice.Text)


            If txtOrderQuant.Text > Label73.Text Then
                MsgBox("You have entered an higher quantity than quantity of our product.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
            ElseIf txtOrderQuant.Text = Label73.Text Then

                '   Dim totals As Integer
                Dim row As String() = New String() {firstColumnprod, thirdColumndesc}

                Dim n As Integer = dtgOrder.Rows.Add()

                dtgOrder.Rows.Item(n).Cells(2).Value = firstColumnprod
                'desc 
                dtgOrder.Rows.Item(n).Cells(3).Value = secondColumnquant 'quant 3
                'price
                dtgOrder.Rows.Item(n).Cells(4).Value = thirdColumndesc 'desc 4
                'quant
                dtgOrder.Rows.Item(n).Cells(5).Value = fourthColumnprice 'price 5
                'total
                dtgOrder.Rows.Item(n).Cells(6).Value = fifthColumntotal 'total 6
                For i As Integer = 0 To dtgOrder.RowCount - 1
                    totald += fifthColumntotal
                Next
                lblTotalPrice.Text = totald
                cmdDeletebtnRawHide.Show()
                cmdDeletebtnRaw.Hide()
                btnAvailableProd.Visible = False
                txtOrderName.Enabled = False
                txtOrderName.Text = ""
                txtOrderQuant.Enabled = False
                txtOrderQuant.Text = ""
                cmbOrderSize.Enabled = False
                cmbOrderSize.Text = ""
                btnOrderProd.Enabled = False
                MsgBox("Sucessfully Added to cart .", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
            Else
                Dim row As String() = New String() {firstColumnprod, thirdColumndesc}

                Dim n As Integer = dtgOrder.Rows.Add()

                dtgOrder.Rows.Item(n).Cells(2).Value = firstColumnprod
                'desc 
                dtgOrder.Rows.Item(n).Cells(3).Value = secondColumnquant 'quant 3
                'price
                dtgOrder.Rows.Item(n).Cells(4).Value = thirdColumndesc 'desc 4
                'quant
                dtgOrder.Rows.Item(n).Cells(5).Value = fourthColumnprice 'price 5
                'total
                dtgOrder.Rows.Item(n).Cells(6).Value = fifthColumntotal 'total 6

                Dim totald As Decimal = 0
                For i As Integer = 0 To dtgOrder.RowCount - 1
                    totald += dtgOrder.Rows(i).Cells(6).Value
                Next
                lblTotalPrice.Text = totald
                cmdDeletebtnRawHide.Show()
                cmdDeletebtnRaw.Hide()
                btnAvailableProd.Visible = False
                txtOrderName.Enabled = False
                txtOrderName.Text = ""
                txtOrderQuant.Enabled = False
                txtOrderQuant.Text = ""
                cmbOrderSize.Enabled = False
                cmbOrderSize.Text = ""
                btnOrderProd.Enabled = False
                MsgBox("Sucessfully Added to cart .", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
            End If
        End If
    End Sub
    Private Sub cmbcategory_DrawItem(sender As Object, e As DrawItemEventArgs) Handles cmbcategory.DrawItem
        Try

            If e.Index = 0 Then
                e.DrawBackground()
                Dim text As String = DirectCast(sender, ComboBox).Items(e.Index).ToString()
                Dim brush As Brush
                brush = Brushes.Black
                e.Graphics.DrawString(text, (DirectCast(sender, Control)).Font, brush, e.Bounds.X, e.Bounds.Y)
            Else

                If (e.Index > 0 AndAlso DirectCast(sender, ComboBox).Items(e.Index) IsNot Nothing) Then
                    e.DrawBackground()
                    Dim combo As ComboBox = DirectCast(sender, ComboBox)
                    Dim text As String = combo.Items(e.Index).ToString()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cmbcategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbcategory.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub cmbcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcategory.SelectedIndexChanged
        If cmbcategory.SelectedIndex = 0 Then
            fillAvailableProd()
        ElseIf cmbcategory.SelectedIndex = 1 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 2 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 3 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 4 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 5 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 6 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 7 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 8 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 9 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 10 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 11 Then
            fillAvailableProds()
        ElseIf cmbcategory.SelectedIndex = 12 Then
            fillAvailableProds()
        End If
    End Sub
    Private Sub txtOrderQuant_KeyPress1(sender As Object, e As KeyPressEventArgs) Handles txtOrderQuant.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then e.Handled = True
        If e.KeyChar = Chr(8) Then e.Handled = False
    End Sub
    Private Sub ComboBox6_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox6.SelectionChangeCommitted
        If ComboBox6.SelectedIndex = 0 Then
            filterAvailableProd10()
            ComboBox6.SelectionLength = 0
        ElseIf ComboBox6.SelectedIndex = 1 Then
            filterAvailableProd25()
            ComboBox6.SelectionLength = 0
        ElseIf ComboBox6.SelectedIndex = 2 Then
            filterAvailableProd50()
            ComboBox6.SelectionLength = 0
        ElseIf ComboBox6.SelectedIndex = 3 Then
            filterAvailableProd100()
            ComboBox6.SelectionLength = 0
        ElseIf ComboBox6.SelectedIndex = 4 Then
            ComboBox6.SelectionLength = 0
            fillAvailableProd()
        End If
    End Sub
    Private Sub ComboBox8_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox8.SelectionChangeCommitted
        If ComboBox8.SelectedIndex = 0 Then
            filterOrderProd10()
        ElseIf ComboBox8.SelectedIndex = 1 Then
            filterOrderProd25()
        ElseIf ComboBox8.SelectedIndex = 2 Then
            filterOrderProd50()
        ElseIf ComboBox8.SelectedIndex = 3 Then
            filterOrderProd100()
        ElseIf ComboBox8.SelectedIndex = 4 Then
            fillOrderProd()
        End If
    End Sub
    Private Sub ComboBox4_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox4.SelectionChangeCommitted
        If ComboBox4.SelectedIndex = 0 Then
            filterExpired10()
        ElseIf ComboBox4.SelectedIndex = 1 Then
            filterExpired25()
        ElseIf ComboBox4.SelectedIndex = 2 Then
            filterExpired50()
        ElseIf ComboBox4.SelectedIndex = 3 Then
            filterExpired100()
        ElseIf ComboBox4.SelectedIndex = 4 Then
            fillExpired()
        End If
    End Sub
    Private Sub ComboBox7_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox7.SelectionChangeCommitted
        If ComboBox7.SelectedIndex = 0 Then
            filterRecord10()
        ElseIf ComboBox7.SelectedIndex = 1 Then
            filterRecord25()
        ElseIf ComboBox7.SelectedIndex = 2 Then
            filterRecord50()
        ElseIf ComboBox7.SelectedIndex = 3 Then
            filterRecord100()
        ElseIf ComboBox7.SelectedIndex = 4 Then
            fillLogRec()
        End If
    End Sub
    Private Sub ComboBox5_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox5.SelectionChangeCommitted
        If ComboBox5.SelectedIndex = 0 Then
            filterCritical10()
        ElseIf ComboBox5.SelectedIndex = 1 Then
            filterCritical25()
        ElseIf ComboBox5.SelectedIndex = 2 Then
            filterCritical50()
        ElseIf ComboBox5.SelectedIndex = 3 Then
            filterCritical100()
        ElseIf ComboBox5.SelectedIndex = 4 Then
            fillCritical()
        End If
    End Sub
    Private Sub ComboBox3_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox3.SelectionChangeCommitted
        If ComboBox3.SelectedIndex = 0 Then
            filterProduct10()
        ElseIf ComboBox3.SelectedIndex = 1 Then
            filterProduct25()
        ElseIf ComboBox3.SelectedIndex = 2 Then
            filterProduct50()
        ElseIf ComboBox3.SelectedIndex = 3 Then
            filterProduct100()
        ElseIf ComboBox3.SelectedIndex = 4 Then
            fillProductQuantity()
        End If
    End Sub
    Private Sub ComboBox2_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox2.SelectionChangeCommitted
        If ComboBox2.SelectedIndex = 0 Then
            filterRawMats10()
        ElseIf ComboBox2.SelectedIndex = 1 Then
            filterRawMats25()
        ElseIf ComboBox2.SelectedIndex = 2 Then
            filterRawMats50()
        ElseIf ComboBox2.SelectedIndex = 3 Then
            filterRawMats100()
        ElseIf ComboBox2.SelectedIndex = 4 Then
            FillRawMats()
        End If
    End Sub
    Private Sub ComboBox1_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ComboBox1.SelectionChangeCommitted
        If ComboBox1.SelectedIndex = 0 Then
            filterProdRawMats10()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            filterProdRawMats25()
        ElseIf ComboBox1.SelectedIndex = 2 Then
            filterProdRawMats50()
        ElseIf ComboBox1.SelectedIndex = 3 Then
            filterProdRawMats100()
        ElseIf ComboBox1.SelectedIndex = 4 Then
            fillProdukto()
        End If
    End Sub
    Private Sub TabControl1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles TabControl1.DrawItem

        '  Identify which TabPage is currently selected
        Dim SelectedTab As TabPage = TabControl1.TabPages(e.Index)

        '  Get the area of the header of this TabPage
        Dim HeaderRect As Rectangle = TabControl1.GetTabRect(e.Index)

        '  Create two Brushes to paint the Text
        Dim BlackTextBrush As New SolidBrush(Color.Black)
        Dim RedTextBrush As New SolidBrush(Color.Red)

        '  Set the Alignment of the Text
        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center

        '  Paint the Text using the appropriate Bold and Color setting 
        If Convert.ToBoolean(e.State And DrawItemState.Selected) Then
            Dim BoldFont As New Font(TabControl1.Font.Name, TabControl1.Font.Size, FontStyle.Bold)
            e.Graphics.DrawString(SelectedTab.Text, BoldFont, RedTextBrush, HeaderRect, sf)

        Else
            e.Graphics.DrawString(SelectedTab.Text, e.Font, BlackTextBrush, HeaderRect, sf)
        End If

        '  Job done - dispose of the Brushes
        BlackTextBrush.Dispose()
        RedTextBrush.Dispose()
    End Sub
    Private Sub dtgOrder_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dtgOrder.DataBindingComplete
        dtgOrder.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
    End Sub
    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click

    End Sub
    Public Sub orderCustomer()


        If txtCash.Text = "" Then
            MsgBox("Cash is Required.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        ElseIf Val(txtCash.Text) < lblTotalPrice.Text Then
            MsgBox("Please input the same amount as your order.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        Else

            'For iv As Integer = 0 To dtgOrder.RowCount - 1
            '    If dtgOrder.Rows(iv).Cells(5).Value = "" Then
            '        MsgBox("Enter Quantity", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
            '        dtgOrder.BeginEdit(True)
            '        conditioncellcolor()
            '    End If
            'Next
            'conditioncellcolor()

            question = MsgBox("Are you sure you want to accept an order?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation")
            If question = MsgBoxResult.Yes Then
                For k As Integer = 0 To dtgOrder.RowCount - 1
                    objconn.Open()
                    cmbQuery = "SELECT product_quantity.Quantity As 'quant_test' from product_quantity INNER join product_table on product_quantity.Product_ID =  " _
                                      & " product_table.Product_ID INNER join product_size on product_size.Size_ID = product_quantity.Size_ID where product_table.Product_Name " _
                                      & " = '" & dtgOrder.Rows(k).Cells(2).Value & "' And product_size.Size_Name =  '" & If(dtgOrder.Rows(k).Cells(4).Value = "pieces", "None", dtgOrder.Rows(k).Cells(4).Value) & "'"
                    objcmd = New MySqlCommand(cmbQuery, objconn)
                    objdr = objcmd.ExecuteReader
                    While objdr.Read
                        quantitytesting = objdr.GetInt32("quant_test")
                    End While
                    objconn.Close()
                    If dtgOrder.Rows(k).Cells(3).Value = quantitytesting Then
                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert Into order_table(Order_ID,Product_ID,Order_Quantity,Size_ID,Price,Order_Date)  values (NULL,(Select Product_ID from product_table where Product_Name = '" & CStr(dtgOrder.Rows(k).Cells(2).Value) & "')," & CInt(dtgOrder.Rows(k).Cells(3).Value) & ",(Select Size_ID from product_size " _
                                            & " where Size_Name =  '" & If(dtgOrder.Rows(k).Cells(4).Value = "pieces", "None", dtgOrder.Rows(k).Cells(4).Value) & "')," & CDec(dtgOrder.Rows(k).Cells(6).Value) & ",CURRENT_TIMESTAMP); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()

                        objconn.Open()
                        DeleteQuery = "update product_quantity Set Quantity = Quantity - " & CInt(dtgOrder.Rows(k).Cells(3).Value) & " where Product_ID = (SELECT Product_ID from product_table where " _
                                       & " Product_Name = '" & dtgOrder.Rows(k).Cells(2).Value & "')  And Size_ID = (Select Size_ID from product_size WHERE Size_Name =  '" & If(dtgOrder.Rows(k).Cells(4).Value = "pieces", "None", dtgOrder.Rows(k).Cells(4).Value) & "')"
                        objcmd = New MySqlCommand(DeleteQuery, objconn)
                        objdr = objcmd.ExecuteReader
                        objconn.Close()
                        fillAvailableProd()
                    Else
                        objconn.Open()
                        With objcmd
                            .Connection = objconn
                            .CommandText = "Insert Into order_table(Order_ID,Product_ID,Order_Quantity,Size_ID,Price,Order_Date)  values (NULL,(Select Product_ID from product_table where Product_Name = '" & CStr(dtgOrder.Rows(k).Cells(2).Value) & "')," & CInt(dtgOrder.Rows(k).Cells(3).Value) & ",(Select Size_ID from product_size " _
                                            & " where Size_Name =  '" & If(dtgOrder.Rows(k).Cells(4).Value = "pieces", "None", dtgOrder.Rows(k).Cells(4).Value) & "'), " & CDec(dtgOrder.Rows(k).Cells(6).Value) & ",CURRENT_TIMESTAMP); "
                            .ExecuteNonQuery()
                        End With
                        objconn.Close()
                        objconn.Open()
                        ModifyQuerys = "update product_quantity Set Quantity = Quantity - " & CInt(dtgOrder.Rows(k).Cells(3).Value) & " where Product_ID = (SELECT Product_ID from product_table where " _
                                       & " Product_Name = '" & dtgOrder.Rows(k).Cells(2).Value & "')  And Size_ID = (Select Size_ID from product_size WHERE Size_Name =  '" & If(dtgOrder.Rows(k).Cells(4).Value = "pieces", "None", dtgOrder.Rows(k).Cells(4).Value) & "')"
                        objcmd = New MySqlCommand(ModifyQuerys, objconn)
                        objdr = objcmd.ExecuteReader
                        objconn.Close()
                        fillAvailableProd()
                    End If
                Next
                dtgOrder.Rows.Clear()
                lblTotalPrice.Text = ""
                txtCash.Text = ""
                txtCash.Enabled = False
                Label58.Text = ""
                question = MsgBox("Thank you for Ordering.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
                If question = MsgBoxResult.Ok Then
                    TabControl1.SelectedTab = TabPage1
                End If
            ElseIf question = MsgBoxResult.No Then
                If objconn.State = ConnectionState.Open Then
                    objconn.Close()
                    objconn.Dispose()
                End If
            End If
        End If
    End Sub
    Private Sub cmdSubmitAdd_Click(sender As Object, e As EventArgs) Handles cmdSubmitAdd.Click
        orderCustomer()
    End Sub
    Private Sub txtTotalPrice_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Back) Then
            e.Handled = True
        End If
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = ""
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab Is TabPage1 Then
            ' tab1Text.Focus()
        ElseIf TabControl1.SelectedTab Is TabPage2 Then
            '  tab2Text.Focus()
            If dtgOrder.Rows.Count = 0 Then
                cmdSubmitAdd.Enabled = False
                btnDelOrder.Hide()
                btnDelOrderHide.Show()
                txtCash.Text = ""
                txtCash.Enabled = False
                Label58.Text = ""
            Else
                cmdSubmitAdd.Enabled = True
                txtCash.Enabled = True
                btnDelOrder.Show()
                btnDelOrderHide.Hide()
            End If
            dtgOrder.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            AddSelectAllCheckBoxw(dtgOrder)
        End If
    End Sub
    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress


        Dim allowedChars As String = "0987654321."
        If (txtCash.Text.IndexOf(".") >= 0 And e.KeyChar = "." Or Not allowedChars.Contains(e.KeyChar.ToString.ToLower)) Then
            e.Handled = True
            CType(sender, TextBox).Clear()
        End If
    End Sub
    Private Sub btnDelOrder_Click(sender As Object, e As EventArgs) Handles btnDelOrder.Click
        question = MsgBox("Area you sure you want to remove selected " & lblselected.Text & " product/s ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Red Cheese Pizza Message")
        If question = MsgBoxResult.Yes Then
            'yes of course
            For i As Integer = dtgOrder.Rows.Count() - 1 To 0 Step -1
                Dim delete As Boolean
                delete = dtgOrder.Rows(i).Cells(1).Value = True

                If delete = True Then
                    Dim row As DataGridViewRow
                    row = dtgOrder.Rows(i)
                    dtgOrder.Rows.Remove(row)
                End If
            Next
            lblselected.Text = ""
            btnDelOrderHide.Show()
            btnDelOrder.Visible = False

            If dtgOrder.Rows.Count = 0 Then
                cmdSubmitAdd.Enabled = False
                lblTotalPrice.Text = ""
                txtCash.Text = ""
                Label58.Text = ""
            Else
                cmdSubmitAdd.Enabled = True
                Dim totald As Decimal = 0
                For i As Integer = 0 To dtgOrder.RowCount - 1
                    totald += dtgOrder.Rows(i).Cells(6).Value
                Next
                lblTotalPrice.Text = totald
                txtCash.Text = ""
                Label58.Text = ""
            End If
            MsgBox("Selected Ordered Products has been Sucessfully Removed.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Red Cheese Pizza Message")
        ElseIf question = MsgBoxResult.No Then
            Exit Sub
        End If
    End Sub
    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        'Dim str As Double = 0


        'str = CDbl(Convert.ToDouble(txtCash.Text) - Convert.ToDouble(lblTotalPrice.Text))
        'Label58.Text = Val(str)
        Dim num1 As Decimal
        Dim num2 As Decimal

        If Decimal.TryParse(txtCash.Text, num1) And Decimal.TryParse(lblTotalPrice.Text, num2) Then
            Label58.Text = (num1 - num2).ToString()
        ElseIf txtCash.Text = "" Then
            Label58.Text = ""
        End If
    End Sub
    Private Sub btnViewSalesRec_Click(sender As Object, e As EventArgs) Handles btnViewSalesRec.Click
  If dtpDateFomSales.CustomFormat = " " Then  'An empty 
            MessageBox.Show("Required field", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDateFomSales.BackColor = Color.PapayaWhip
            dtpDateFomSales.Focus()

        ElseIf dtpDateToSales.CustomFormat = " " Then  'An empty SPACE        
            MessageBox.Show("Required field", "Red Cheese Pizza Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpDateToSales.BackColor = Color.PapayaWhip
            dtpDateToSales.Focus()

        Else
            SalesFiltering()
        End If
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Available_Prod_Report.Show()
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        'PrintOrderProd.Show()

        'Dim Report As New Sales
        'Dim xfrom As New CrystalDecisions.Shared.ParameterDiscreteValue
        'Dim resdatefromsalesr As String = Format(dtpDateFomSales.Value, "yyyy-MM-dd hh:mm:ss")
        'Dim resdatetosalesr As String = Format(dtpDateToSales.Value, "yyyy-MM-dd hh:mm:ss")

        'Rpt_SqlStr = "SELECT product_table.Product_Name, CONCAT(Order_Quantity , CASE " _
        '                                     & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 16) or " _
        '                                     & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 6) or " _
        '                                      & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 7) or " _
        '                          & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 8) THEN ' piece/s' " _
        '                       & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 9)  THEN ' Glass/es' " _
        '                                                      & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 10)  THEN ' Pitcher/s' " _
        '                                                                                     & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 11)  THEN ' Cup/s' " _
        '                                     & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 1) or " _
        '                                     & "  product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 2) or " _
        '                                     & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 3) or " _
        '                                     & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 4) or " _
        '                              & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 5) THEN ' box/es' " _
        '                                     & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 12) or " _
        '                                     & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 13) or " _
        '                     & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 14) THEN ' bottle/s' " _
        '                        & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 15) THEN ' can/s'  " _
        '                        & " END, ' (',(Case when product_size.Size_Name = 'None' Then 'piece/s'  Else   Concat(product_size.Size_Name, ' size') End ) , ') ') AS 'QUANTITY',Concat('P ',Price) As 'Price', " _
        '                        & " DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As 'Order_Date' FROM order_table inner join product_table on order_table.Product_ID = product_table.Product_ID  inner JOIN product_size on " _
        '                        & " order_table.Size_ID = product_size.Size_ID where order_table.Order_Date BETWEEN '" & resdatefromsalesr & "' And '" & resdatetosalesr & "'  Order by DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') DESC"
        '' globalFRM = "Sales_Report"
        'ParamDVFrom.Value = dtpDateFomSales.Value
        'ParamDVTo.Value = dtpDateToSales.Value
        'Report.Show()

        Sales.FirstDate = Format(dtpDateFomSales.Value, "yyyy-MM-dd hh:mm:ss")
        Sales.SecondDate = Format(dtpDateToSales.Value, "yyyy-MM-dd hh:mm:ss")
        Sales.Show()
    End Sub

    Private Sub lblprintProd_Click(sender As Object, e As EventArgs)
        Print_Products.Show()
        'Prod
    End Sub

    Private Sub pctprintProd_Click(sender As Object, e As EventArgs) Handles pctprintProd.Click
        Print_Products.Show()
        'Prod
    End Sub

    Private Sub pctRawProdPrint_Click(sender As Object, e As EventArgs) Handles pctRawProdPrint.Click
        Prod_Report.Show()
        'Prod and Raw
    End Sub

    Private Sub lblRawProdPrint_Click(sender As Object, e As EventArgs)
        Prod_Report.Show()
        'Prod and Raw
    End Sub

    Private Sub lblprintRaw_Click(sender As Object, e As EventArgs)
        Print_Raw_Material.Show()
        'Raw
    End Sub

    Private Sub pctprintRaw_Click(sender As Object, e As EventArgs) Handles pctprintRaw.Click
        Print_Raw_Material.Show()
        'Raw
    End Sub

    Private Sub lblPrintOrderProd_Click(sender As Object, e As EventArgs) Handles lblPrintOrderProd.Click
        Sales.FirstDate = Format(dtpDateFomSales.Value, "yyyy-MM-dd hh:mm:ss")
        Sales.SecondDate = Format(dtpDateToSales.Value, "yyyy-MM-dd hh:mm:ss")
        Sales.Show()

        'Dim pField As New ParameterField
        'Dim pFields As New ParameterFields
        'Dim pRange As New ParameterDiscreteValue

        'pField.ParameterFieldName = "product_size"
        'pRange.Value = "  ss Record from: " & Format(dtpDateFomSales.Value, "yyyy-MM-dd hh:mm:ss") & " To: " & Format(dtpDateToSales.Value, "yyyy-MM-dd hh:mm:ss")
        'pField.CurrentValues.Add(pRange)
        'pFields.Add(pField)
        'Sales.CrystalReportViewer1.ParameterFieldInfo = pFields

        'reports("SELECT product_table.Product_Name, CONCAT(Order_Quantity , CASE " _
        '                                       & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 16) or " _
        '                                       & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 6) or " _
        '                                        & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 7) or " _
        '                            & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 8) THEN ' piece/s' " _
        '                         & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 9)  THEN ' Glass/es' " _
        '                                                        & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 10)  THEN ' Pitcher/s' " _
        '                                                                                       & " WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 11)  THEN ' Cup/s' " _
        '                                       & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 1) or " _
        '                                       & "  product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 2) or " _
        '                                       & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 3) or " _
        '                                       & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 4) or " _
        '                                & " product_size.Size_ID =(Select  product_size.Size_ID from product_size where product_size.Size_ID = 5) THEN ' box/es' " _
        '                                       & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 12) or " _
        '                                       & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 13) or " _
        '                       & " product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 14) THEN ' bottle/s' " _
        '                          & "  WHEN order_table.Order_Quantity > 0 And product_size.Size_ID = (Select  product_size.Size_ID from product_size where product_size.Size_ID = 15) THEN ' can/s'  END, ' (',(Case when product_size.Size_Name = 'None' Then 'piece/s'  Else   Concat(product_size.Size_Name, ' size') End ) , ') ') AS 'QUANTITY',Concat('P ',Price) As 'Price', DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') As 'Order_Date' FROM order_table inner join product_table on order_table.Product_ID = product_table.Product_ID  inner JOIN product_size on order_table.Size_ID = product_size.Size_ID where order_table.Order_Date BETWEEN '" & Format(dtpDateFomSales.Value, "yyyy-MM-dd hh:mm:ss") & "' And '" & Format(dtpDateToSales.Value, "yyyy-MM-dd hh:mm:ss") & "'  Order by DATE_FORMAT(order_table.Order_Date,'%m/%d/%Y %h:%i %p') DESC", "LogsheetName", Sales.CrystalReportViewer1)
        'Sales.ShowDialog()
        'Sales.Dispose()
    End Sub



    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub




End Class
