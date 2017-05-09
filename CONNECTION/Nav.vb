Imports MySql.Data.MySqlClient
Module Nav
    Public Sub Sales_Hover()
        Modall.pctSales.Show()
        Modall.pctInventory.Visible = False
        Modall.pctView.Visible = False
        Modall.pctSystem4.Visible = False
        Modall.pctHelp.Visible = False
        ' pctSystem3.Visible = False
        Modall.pctView1.Visible = False

        Modall.lblOrderProduct.Show()
        Modall.lblAvailableProduct.Show()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblInventory2.Show()

        Modall.lblInventory1.Visible = False

        Modall.lblRawMaterials.Visible = False
        Modall.lblProducts.Visible = False
        Modall.lblRawMaterialsanditsProducts.Visible = False

        Modall.lblView1.Visible = False
        Modall.lblView2.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk2.Show()
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation2.Show()
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If


        Modall.lblView3.Visible = False

        Modall.lblAccount.Visible = False
        Modall.lblExpiredRawMaterial.Visible = False
        Modall.lblCriticalRawMaterial.Visible = False
        Modall.lblRecords.Visible = False

        Modall.lblSystem1.Visible = False
        Modall.lblSystem2.Show()
        Modall.lblSystem3.Visible = False

        Modall.lblHelp1.Visible = False
        Modall.lblHelp2.Show()
        Modall.lblHelp3.Visible = False
        Modall.lblSystem4.Visible = False
        Modall.lblHelp4.Visible = False

        Modall.lblCalculator.Visible = False
        Modall.lblKeyboardShortcut.Visible = False
        Modall.lblViewHelp.Visible = False
        Modall.lblAbout.Visible = False

        Modall.lblBackUpandRestore.Visible = False
    End Sub
    Public Sub lblInventory1MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Show()
        Modall.pctView.Visible = False
        Modall.pctSystem4.Visible = False
        Modall.pctHelp.Visible = False
        ' pctSystem3.Visible = False
        Modall.pctView1.Visible = False

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblAccount.Visible = False
        Modall.lblExpiredRawMaterial.Visible = False
        Modall.lblCriticalRawMaterial.Visible = False
        Modall.lblRecords.Visible = False

        Modall.lblRawMaterials.Show()
        Modall.lblProducts.Show()
        Modall.lblRawMaterialsanditsProducts.Show()

        Modall.lblView1.Visible = False
        Modall.lblView2.Visible = False
        Modall.lblView3.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk3.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk1.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation3.Show()
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation1.Visible = False
        End If
        Modall.lblHelp1.Visible = False
        Modall.lblHelp2.Visible = False
        Modall.lblHelp3.Show()

        Modall.lblSystem1.Visible = False
        Modall.lblSystem2.Visible = False

        Modall.lblSystem3.Show()
        Modall.lblSystem4.Visible = False
        Modall.lblHelp4.Visible = False

        Modall.lblBackUpandRestore.Visible = False


        Modall.lblCalculator.Visible = False
        Modall.lblKeyboardShortcut.Visible = False
        Modall.lblViewHelp.Visible = False
        Modall.lblAbout.Visible = False
    End Sub
    Public Sub lblInventory2MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Show()
        Modall.pctView.Visible = False
        Modall.pctSystem4.Visible = False
        Modall.pctHelp.Visible = False
        ' pctSystem3.Visible = False
        Modall.pctView1.Visible = False

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblInventory2.Visible = False
        Modall.lblInventory1.Show()

        Modall.lblOrderProduct.Visible = False
        Modall.lblAvailableProduct.Visible = False

        Modall.lblRawMaterials.Show()
        Modall.lblProducts.Show()
        Modall.lblRawMaterialsanditsProducts.Show()

        Modall.lblView2.Visible = False
        Modall.lblView3.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk3.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk1.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation3.Show()
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation1.Visible = False
        End If

        Modall.lblSystem1.Visible = False
        Modall.lblSystem2.Visible = False

        Modall.lblSystem3.Show()

        Modall.lblAccount.Visible = False
        Modall.lblExpiredRawMaterial.Visible = False
        Modall.lblCriticalRawMaterial.Visible = False
        Modall.lblRecords.Visible = False

        Modall.lblHelp1.Visible = False
        Modall.lblHelp2.Visible = False
        Modall.lblHelp3.Show()
        Modall.lblSystem4.Visible = False
        Modall.lblHelp4.Visible = False

        Modall.lblCalculator.Visible = False
        Modall.lblKeyboardShortcut.Visible = False
        Modall.lblViewHelp.Visible = False
        Modall.lblAbout.Visible = False
        Modall.lblBackUpandRestore.Visible = False
    End Sub
    Public Sub lblView1MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Show()
        Modall.pctSystem4.Visible = False
        Modall.pctHelp.Visible = False
        Modall.pctView1.Visible = False
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()

        Modall.dtpDateFrom.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateFrom.Format = DateTimePickerFormat.Custom

        Modall.dtpDateTo.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateTo.Format = DateTimePickerFormat.Custom


        Modall.lblView1.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1.Show()
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If

        Modall.lblView2.Visible = False
        Modall.lblOrderProduct.Visible = False
        Modall.lblAvailableProduct.Visible = False
        Modall.lblView2.Visible = False
        Modall.lblView3.Visible = False

        Modall.lblInventory1.Show()
        Modall.lblInventory2.Visible = False

        Modall.lblAccount.Show()
        Modall.lblExpiredRawMaterial.Show()
        Modall.lblCriticalRawMaterial.Show()
        Modall.lblRecords.Show()

        Modall.lblSystem1.Visible = False
        Modall.lblSystem2.Visible = False
        Modall.lblSystem3.Visible = False
        Modall.lblSystem4.Show()

        Modall.lblHelp1.Visible = False
        Modall.lblHelp4.Show()
        Modall.lblHelp2.Visible = False
        Modall.lblHelp3.Visible = False
        ' lblHelp4.Visible = False

        Modall.lblBackUpandRestore.Visible = False
        Modall.lblCalculator.Visible = False
        Modall.lblKeyboardShortcut.Visible = False
        Modall.lblViewHelp.Visible = False
        Modall.lblAbout.Visible = False
    End Sub
    Public Sub lblView2MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Show()
        Modall.pctSystem4.Visible = False
        Modall.pctHelp.Visible = False
        Modall.pctView1.Visible = False
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.dtpDateFrom.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateFrom.Format = DateTimePickerFormat.Custom

        Modall.dtpDateTo.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateTo.Format = DateTimePickerFormat.Custom

        Modall.lblView1.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1.Show()
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If
        Modall.lblView2.Visible = False
        Modall.lblOrderProduct.Visible = False
        Modall.lblAvailableProduct.Visible = False
        Modall.lblView2.Visible = False

        Modall.lblInventory1.Show()
        Modall.lblInventory2.Visible = False

        Modall.lblAccount.Show()
        Modall.lblExpiredRawMaterial.Show()
        Modall.lblCriticalRawMaterial.Show()
        Modall.lblRecords.Show()
        Modall.lblSystem1.Visible = False
        Modall.lblSystem2.Visible = False
        Modall.lblSystem3.Visible = False
        Modall.lblSystem4.Show()

        Modall.lblHelp2.Visible = False
        Modall.lblHelp3.Visible = False
        'lblHelp4.Visible = False
        Modall.lblCalculator.Visible = False
        Modall.lblKeyboardShortcut.Visible = False
        Modall.lblViewHelp.Visible = False
        Modall.lblAbout.Visible = False
        ' lblSystem4.Show()
        Modall.lblHelp4.Show()
        Modall.lblBackUpandRestore.Visible = False
    End Sub
    Public Sub lblView3MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Show()
        Modall.pctSystem4.Visible = False
        Modall.pctHelp.Visible = False
        ' pctSystem3.Visible = False
        Modall.pctView1.Visible = False
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.dtpDateFrom.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateFrom.Format = DateTimePickerFormat.Custom
        Modall.dtpDateTo.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateTo.Format = DateTimePickerFormat.Custom

        Modall.lblView1.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1.Show()
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If
        Modall.lblView3.Visible = False
        Modall.lblRawMaterials.Visible = False
        Modall.lblProducts.Visible = False
        Modall.lblRawMaterialsanditsProducts.Visible = False

        Modall.lblAccount.Show()
        Modall.lblExpiredRawMaterial.Show()
        Modall.lblCriticalRawMaterial.Show()
        Modall.lblRecords.Show()

        ' lblSystem4.Show()

        ' lblHelp3.Visible = False

        Modall.lblSystem1.Visible = False
        Modall.lblSystem2.Visible = False
        Modall.lblSystem3.Visible = False
        Modall.lblSystem4.Show()

        'lblHelp3.Show()
        Modall.lblHelp3.Visible = False
        Modall.lblHelp4.Show()

        Modall.lblBackUpandRestore.Visible = False
        Modall.lblCalculator.Visible = False
        Modall.lblKeyboardShortcut.Visible = False
        Modall.lblViewHelp.Visible = False
        Modall.lblAbout.Visible = False
    End Sub
    Public Sub lblSystem1MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Visible = False
        Modall.pctSystem4.Show()
        Modall.pctHelp.Visible = False
        ' pctSystem3.Visible = False
        Modall.pctView1.Visible = False

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblOrderProduct.Visible = False
        Modall.lblAvailableProduct.Visible = False
        Modall.lblInventory2.Visible = False

        Modall.lblInventory1.Show()

        Modall.lblRawMaterials.Visible = False
        Modall.lblProducts.Visible = False
        Modall.lblRawMaterialsanditsProducts.Visible = False

        Modall.lblView1.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1.Show()
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If
        Modall.lblView2.Visible = False
        Modall.lblView3.Visible = False

        Modall.lblAccount.Visible = False
        Modall.lblExpiredRawMaterial.Visible = False
        Modall.lblCriticalRawMaterial.Visible = False
        Modall.lblRecords.Visible = False

        Modall.lblSystem1.Show()
        Modall.lblSystem2.Visible = False
        Modall.lblSystem3.Visible = False
        Modall.lblSystem4.Visible = False
        Modall.lblHelp1.Show()
        Modall.lblHelp2.Visible = False
        Modall.lblHelp3.Visible = False
        Modall.lblHelp4.Visible = False

        Modall.lblBackUpandRestore.Show()
        Modall.lblCalculator.Visible = False
        Modall.lblKeyboardShortcut.Visible = False
        Modall.lblViewHelp.Visible = False
        Modall.lblAbout.Visible = False
    End Sub
    Public Sub lblSystem2MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Visible = False
        Modall.pctSystem4.Show()
        Modall.pctHelp.Visible = False
        ' pctSystem3.Visible = False
        Modall.pctView1.Visible = False

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblOrderProduct.Visible = False
        Modall.lblAvailableProduct.Visible = False
        Modall.lblInventory1.Show()
        Modall.lblInventory2.Visible = False
        Modall.lblView1.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1.Show()
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If
        Modall.lblView2.Visible = False
        Modall.lblView3.Visible = False
        Modall.lblSystem4.Visible = False
        Modall.lblSystem3.Visible = False
        Modall.lblSystem2.Visible = False
        Modall.lblSystem1.Show()
        Modall.lblBackUpandRestore.Show()
        Modall.lblHelp1.Show()
        Modall.lblHelp2.Visible = False
        Modall.lblHelp3.Visible = False

        Modall.lblCalculator.Visible = False
        Modall.lblKeyboardShortcut.Visible = False
        Modall.lblViewHelp.Visible = False
        Modall.lblAbout.Visible = False
    End Sub
    Public Sub lblSystem3MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Visible = False
        Modall.pctSystem4.Show()
        Modall.pctHelp.Visible = False
        ' pctSystem3.Visible = False
        Modall.pctView1.Visible = False

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblSystem4.Visible = False
        Modall.lblSystem3.Visible = False
        Modall.lblSystem2.Visible = False
        Modall.lblSystem1.Show()
        Modall.lblAccount.Visible = False
        Modall.lblRawMaterials.Visible = False
        Modall.lblProducts.Visible = False
        Modall.lblRawMaterialsanditsProducts.Visible = False
        Modall.lblBackUpandRestore.Show()
        Modall.lblHelp4.Visible = False
        Modall.lblHelp3.Visible = False
        Modall.lblView1.Show()
        Modall.lblView2.Visible = False
        Modall.lblView3.Visible = False

        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1.Show()
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If

        Modall.lblCalculator.Visible = False
        Modall.lblKeyboardShortcut.Visible = False
        Modall.lblViewHelp.Visible = False
        Modall.lblAbout.Visible = False
    End Sub
    Public Sub lblSystem4MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Visible = False
        Modall.pctSystem4.Show()
        Modall.pctHelp.Visible = False
        ' pctSystem3.Visible = False
        Modall.pctView1.Visible = False

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblSystem4.Visible = False
        Modall.lblSystem3.Visible = False
        Modall.lblSystem2.Visible = False
        Modall.lblSystem1.Show()
        Modall.lblAccount.Visible = False
        Modall.lblExpiredRawMaterial.Visible = False
        Modall.lblCriticalRawMaterial.Visible = False
        Modall.lblRecords.Visible = False
        Modall.lblBackUpandRestore.Show()
        Modall.lblHelp4.Visible = False
        Modall.lblHelp1.Show()

        Modall.lblCalculator.Visible = False
        Modall.lblKeyboardShortcut.Visible = False
        Modall.lblViewHelp.Visible = False
        Modall.lblAbout.Visible = False
    End Sub
    Public Sub lblHelp1MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Visible = False
        Modall.pctSystem4.Visible = False
        Modall.pctHelp.Show()
        Modall.pctView1.Visible = False

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblCalculator.Show()
        Modall.lblKeyboardShortcut.Show()
        Modall.lblViewHelp.Show()
        Modall.lblAbout.Show()

        Modall.lblBackUpandRestore.Visible = False
    End Sub
    Public Sub lblHelp2MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Visible = False
        Modall.pctSystem4.Visible = False
        Modall.pctHelp.Show()
        Modall.pctView1.Visible = False

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblOrderProduct.Visible = False
        Modall.lblAvailableProduct.Visible = False

        Modall.lblInventory1.Show()
        Modall.lblInventory2.Visible = False

        Modall.lblView1.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1.Show()
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If
        Modall.lblView2.Visible = False
        Modall.lblView3.Visible = False
        Modall.lblSystem1.Show()
        Modall.lblSystem2.Visible = False
        Modall.lblSystem3.Visible = False
        Modall.lblHelp1.Show()
        Modall.lblHelp2.Visible = False
        Modall.lblHelp3.Visible = False
        Modall.lblHelp4.Visible = False

        Modall.lblCalculator.Show()
        Modall.lblKeyboardShortcut.Show()
        Modall.lblViewHelp.Show()
        Modall.lblAbout.Show()
    End Sub
    Public Sub lblHelp3MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Visible = False
        Modall.pctSystem4.Visible = False
        Modall.pctHelp.Show()
        Modall.pctView1.Visible = False

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblHelp4.Visible = False
        Modall.lblHelp1.Show()
        Modall.lblSystem1.Show()
        Modall.lblSystem2.Visible = False
        Modall.lblSystem3.Visible = False
        Modall.lblSystem4.Visible = False

        Modall.lblAccount.Visible = False
        Modall.lblCriticalRawMaterial.Visible = False
        Modall.lblExpiredRawMaterial.Visible = False
        Modall.lblRecords.Visible = False

        Modall.lblCalculator.Show()
        Modall.lblKeyboardShortcut.Show()
        Modall.lblViewHelp.Show()
        Modall.lblAbout.Show()

        Modall.lblRawMaterials.Visible = False
        Modall.lblRawMaterialsanditsProducts.Visible = False
        Modall.lblProducts.Visible = False

        Modall.lblView1.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1.Show()
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If
        Modall.lblView2.Visible = False
        Modall.lblView3.Visible = False
    End Sub
    Public Sub lblHelp4MouseHover()
        Modall.pctSales.Visible = False
        Modall.pctInventory.Visible = False
        Modall.pctView.Visible = False
        Modall.pctSystem4.Visible = False
        Modall.pctHelp.Show()
        Modall.pctView1.Visible = False

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblHelp4.Visible = False
        Modall.lblHelp3.Visible = False
        Modall.lblHelp2.Visible = False
        Modall.lblHelp1.Show()
        Modall.lblSystem1.Show()
        Modall.lblSystem2.Visible = False
        Modall.lblSystem3.Visible = False
        Modall.lblSystem4.Visible = False

        Modall.lblAccount.Visible = False
        Modall.lblCriticalRawMaterial.Visible = False
        Modall.lblExpiredRawMaterial.Visible = False
        Modall.lblRecords.Visible = False

        Modall.lblCalculator.Show()
        Modall.lblKeyboardShortcut.Show()
        Modall.lblViewHelp.Show()
        Modall.lblAbout.Show()

        Modall.lblRawMaterials.Visible = False
        Modall.lblRawMaterialsanditsProducts.Visible = False
        Modall.lblProducts.Visible = False

        Modall.lblView1.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1.Show()
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If
        Modall.lblView2.Visible = False
        Modall.lblView3.Visible = False
    End Sub
    Public Sub lblOrderProductClick()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "a"
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk2.Show()
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation2.Show()
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If

        Modall.grpOrderProd.Show()
        Modall.ComboBox8.SelectedIndex = 4
        fillOrderProd()
        Modall.grpRecord.Visible = False
        Modall.TabControl1.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.grpExpired.Visible = False
        Modall.grpCritical.Visible = False
        Modall.DataGridView9.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Public Sub lblAvailableProductClick()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "b"
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk2.Visible = False
            Modall.Expiredasterisk3.Visible = False
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk2.Show()
            Modall.Expiredasterisk1.Visible = False
            Modall.Expiredasterisk3.Visible = False
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation2.Visible = False
            Modall.Criticalquotation3.Visible = False
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation2.Show()
            Modall.Criticalquotation1.Visible = False
            Modall.Criticalquotation3.Visible = False
        End If
        Modall.TabControl1.Show()
        Modall.Label25.BringToFront()

        Modall.ComboBox6.SelectedIndex = 4
        fillAvailableProd()
        Modall.grpRecord.Visible = False
        Modall.grpOrderProd.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.grpExpired.Visible = False
        Modall.grpCritical.Visible = False
        Modall.DataGridView8.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxn(Modall.DataGridView8)
        Modall.cmdDeletebtnRawHide.Show()
        Modall.btnAvailableProd.Visible = False
        Modall.txtOrderName.Enabled = False
        Modall.txtOrderQuant.Enabled = False
        Modall.cmbOrderSize.Enabled = False
        Modall.btnOrderProd.Enabled = False
    End Sub

    Public Sub lblRawMaterialsClick()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "e"
        Modall.grpBgRawMats.Show()
        Modall.ComboBox2.SelectedIndex = 4
        FillRawMats()
        Modall.grpOrderProd.Visible = False
        Modall.grpRecord.Visible = False
        Modall.TabControl1.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.grpExpired.Visible = False
        Modall.grpCritical.Visible = False
        Modall.DataGridView3.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxs(Modall.DataGridView3)
        Modall.cmdDeletebtnRawHide.Show()
        Modall.cmdDeletebtnRaw.Visible = False
    End Sub
    Public Sub lblProductsClick()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "f"
        Modall.grpOrderProd.Visible = False
        Modall.grpRecord.Visible = False
        Modall.TabControl1.Visible = False
        Modall.grpBgProducts.Show()
        Modall.ComboBox3.SelectedIndex = 4
        fillProductQuantity()
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.grpExpired.Visible = False
        Modall.grpCritical.Visible = False

        Modall.DataGridView4.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxr(Modall.DataGridView4)
        Modall.cmdDeletebtnProdHide.Show()
        Modall.cmdDeletebtnProd.Visible = False
    End Sub
    Public Sub lblRawMaterialsanditsProductsClick()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "g"
        Modall.grpOrderProd.Visible = False
        Modall.grpRecord.Visible = False
        Modall.TabControl1.Visible = False
        Modall.grpBgRawProducts.Show()
        Modall.ComboBox1.SelectedIndex = 4
        fillProdukto()
        Modall.grpCritical.Visible = False
        Modall.grpExpired.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.DataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBox(Modall.DataGridView2)
        Modall.cmdDeletebtnProdRawHide.Show()
        Modall.cmdDeletebtnProdRaw.Visible = False
    End Sub
    Public Sub Expiredasterisk3Click()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "d"
        Modall.grpOrderProd.Visible = False
        Modall.grpRecord.Visible = False
        Modall.grpExpired.Show()
        Modall.ComboBox4.SelectedIndex = 4
        fillExpired()
        Modall.TabControl1.Visible = False
        Modall.grpCritical.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.DataGridView6.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxt(Modall.DataGridView6)
    End Sub
    Public Sub Expiredasterisk2Click()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "d"
        Modall.grpOrderProd.Visible = False
        Modall.grpExpired.Show()
        Modall.grpRecord.Visible = False
        Modall.ComboBox4.SelectedIndex = 4
        fillExpired()
        Modall.TabControl1.Visible = False
        Modall.grpCritical.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.DataGridView6.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxt(Modall.DataGridView6)
    End Sub
    Public Sub Expiredasterisk1Click()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "d"
        Modall.grpOrderProd.Visible = False
        Modall.grpExpired.Show()
        Modall.grpRecord.Visible = False
        Modall.ComboBox4.SelectedIndex = 4
        fillExpired()
        Modall.TabControl1.Visible = False
        Modall.grpCritical.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.DataGridView6.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxt(Modall.DataGridView6)
    End Sub
    Public Sub Criticalquotation1Click()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "c"
        Modall.grpOrderProd.Visible = False
        Modall.grpRecord.Visible = False
        Modall.grpCritical.Show()
        Modall.ComboBox5.SelectedIndex = 4
        fillCritical()
        Modall.TabControl1.Visible = False
        Modall.grpExpired.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.DataGridView7.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxy(Modall.DataGridView7)
    End Sub
    Public Sub Criticalquotation2Click()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "c"
        Modall.grpOrderProd.Visible = False
        Modall.grpRecord.Visible = False
        Modall.grpCritical.Show()
        Modall.ComboBox5.SelectedIndex = 4
        fillCritical()
        Modall.TabControl1.Visible = False
        Modall.grpExpired.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.DataGridView7.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxy(Modall.DataGridView7)
    End Sub
    Public Sub Criticalquotation3Click()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "c"
        Modall.grpOrderProd.Visible = False
        Modall.grpRecord.Visible = False
        Modall.grpCritical.Show()
        Modall.ComboBox5.SelectedIndex = 4
        fillCritical()
        Modall.TabControl1.Visible = False
        Modall.grpExpired.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.DataGridView7.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxy(Modall.DataGridView7)
    End Sub

    Public Sub lblRecordsClick()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.grpRecord.Show()
        Modall.btnDeleteLog.Visible = False
        Modall.btnDeleteLogHide.Show()
        Modall.ComboBox7.SelectedIndex = 4
        fillLogRec()
        Modall.grpOrderProd.Visible = False
        Modall.TabControl1.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.grpExpired.Visible = False
        Modall.grpCritical.Visible = False
        Modall.DataGridView10.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxm(Modall.DataGridView10)
    End Sub
    Public Sub lblCriticalRawMaterialClick()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "c"
        Modall.grpOrderProd.Visible = False
        Modall.grpRecord.Visible = False
        Modall.grpCritical.Show()
        Modall.ComboBox5.SelectedIndex = 4
        fillCritical()
        Modall.TabControl1.Visible = False
        Modall.grpExpired.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.DataGridView7.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxy(Modall.DataGridView7)
    End Sub

    Public Sub lblExpiredRawMaterialClick()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "d"
        Modall.grpOrderProd.Visible = False
        Modall.grpExpired.Show()
        Modall.grpRecord.Visible = False
        fillExpired()
        Modall.TabControl1.Visible = False
        Modall.grpCritical.Visible = False
        Modall.grpBgProducts.Visible = False
        Modall.grpBgRawMats.Visible = False
        Modall.grpBgRawProducts.Visible = False
        Modall.DataGridView6.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxt(Modall.DataGridView6)
    End Sub
End Module
