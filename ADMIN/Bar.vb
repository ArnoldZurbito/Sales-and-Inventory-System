

Imports MySql.Data.MySqlClient
Module Bar
    Public Sub Sales_Hover_0()
        Modall.pctSales_0.Show()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Hide()
        Modall.pctHelp_0.Hide()

        ' pctSystem3.Hide()
        Modall.pctView1_0.Hide()

        Modall.lblOrderProduct_0.Show()
        Modall.lblAvailableProduct_0.Show()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblInventory2_0.Show()

        Modall.lblInventory1_0.Hide()

        Modall.lblRawMaterials_0.Hide()
        Modall.lblProducts_0.Hide()
        Modall.lblRawMaterialsanditsProducts_0.Hide()

        Modall.lblView1_0.Hide()
        Modall.lblView2_0.Show()
        If Modall.putExpired = "0" Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > "0" Then
            Modall.Expiredasterisk2_0.Show()
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = "0" Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > "0" Then
            Modall.Criticalquotation2_0.Show()
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If


        Modall.lblView3_0.Hide()

        Modall.lblExpiredRawMaterial_0.Hide()
        Modall.lblCriticalRawMaterial_0.Hide()

        Modall.lblSystem1_0.Hide()
        Modall.lblSystem2_0.Show()
        Modall.lblSystem3_0.Hide()

        Modall.lblHelp1_0.Hide()
        Modall.lblHelp2_0.Show()
        Modall.lblHelp3_0.Hide()
        Modall.lblSystem4_0.Hide()
        Modall.lblHelp4_0.Hide()

        Modall.lblCalculator_0.Hide()
        Modall.lblKeyboardShortcut_0.Hide()
        Modall.lblViewHelp_0.Hide()
        Modall.lblAbout_0.Hide()

        Modall.lblBackUpandRestore_0.Hide()
    End Sub
    Public Sub lblInventory1MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Show()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Hide()
        Modall.pctHelp_0.Hide()
        ' pctSystem3.Hide()
        Modall.pctView1_0.Hide()

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblExpiredRawMaterial_0.Hide()
        Modall.lblCriticalRawMaterial_0.Hide()

        Modall.lblRawMaterials_0.Show()
        Modall.lblProducts_0.Show()
        Modall.lblRawMaterialsanditsProducts_0.Show()

        Modall.lblView1_0.Hide()
        Modall.lblView2_0.Hide()
        Modall.lblView3_0.Show()
        If Modall.putExpired = "0" Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk3_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk1_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation3_0.Show()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation1_0.Hide()
        End If
        Modall.lblHelp1_0.Hide()
        Modall.lblHelp2_0.Hide()
        Modall.lblHelp3_0.Show()

        Modall.lblSystem1_0.Hide()
        Modall.lblSystem2_0.Hide()

        Modall.lblSystem3_0.Show()
        Modall.lblSystem4_0.Hide()
        Modall.lblHelp4_0.Hide()

        Modall.lblBackUpandRestore_0.Hide()


        Modall.lblCalculator_0.Hide()
        Modall.lblKeyboardShortcut_0.Hide()
        Modall.lblViewHelp_0.Hide()
        Modall.lblAbout_0.Hide()
    End Sub
    Public Sub lblInventory2MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Show()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Hide()
        Modall.pctHelp_0.Hide()
        ' pctSystem3.Hide()
        Modall.pctView1_0.Hide()

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblInventory2_0.Hide()
        Modall.lblInventory1_0.Show()

        Modall.lblOrderProduct_0.Hide()
        Modall.lblAvailableProduct_0.Hide()

        Modall.lblRawMaterials_0.Show()
        Modall.lblProducts_0.Show()
        Modall.lblRawMaterialsanditsProducts_0.Show()

        Modall.lblView2_0.Hide()
        Modall.lblView3_0.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk3_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk1_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation3_0.Show()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation1_0.Hide()
        End If

        Modall.lblSystem1_0.Hide()
        Modall.lblSystem2_0.Hide()

        Modall.lblSystem3_0.Show()

        Modall.lblExpiredRawMaterial_0.Hide()
        Modall.lblCriticalRawMaterial_0.Hide()


        Modall.lblHelp1_0.Hide()
        Modall.lblHelp2_0.Hide()
        Modall.lblHelp3_0.Show()
        Modall.lblSystem4_0.Hide()
        Modall.lblHelp4_0.Hide()

        Modall.lblCalculator_0.Hide()
        Modall.lblKeyboardShortcut_0.Hide()
        Modall.lblViewHelp_0.Hide()
        Modall.lblAbout_0.Hide()
        Modall.lblBackUpandRestore_0.Hide()
    End Sub
    Public Sub lblView1MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Show()
        Modall.pctSystem4_0.Hide()
        Modall.pctHelp_0.Hide()
        Modall.pctView1_0.Hide()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()

        Modall.dtpDateFrom.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateFrom.Format = DateTimePickerFormat.Custom

        Modall.dtpDateTo.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateTo.Format = DateTimePickerFormat.Custom


        Modall.lblView1_0.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1_0.Show()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If

        Modall.lblView2_0.Hide()
        Modall.lblOrderProduct_0.Hide()
        Modall.lblAvailableProduct_0.Hide()
        Modall.lblView2_0.Hide()
        Modall.lblView3_0.Hide()

        Modall.lblInventory1_0.Show()
        Modall.lblInventory2_0.Hide()


        Modall.lblExpiredRawMaterial_0.Show()
        Modall.lblCriticalRawMaterial_0.Show()


        Modall.lblSystem1_0.Hide()
        Modall.lblSystem2_0.Hide()
        Modall.lblSystem3_0.Hide()
        Modall.lblSystem4_0.Show()

        Modall.lblHelp1_0.Hide()
        Modall.lblHelp4_0.Show()
        Modall.lblHelp2_0.Hide()
        Modall.lblHelp3_0.Hide()
        ' lblHelp4.Hide()

        Modall.lblBackUpandRestore_0.Hide()
        Modall.lblCalculator_0.Hide()
        Modall.lblKeyboardShortcut_0.Hide()
        Modall.lblViewHelp_0.Hide()
        Modall.lblAbout_0.Hide()
    End Sub
    Public Sub lblView2MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Show()
        Modall.pctSystem4_0.Hide()
        Modall.pctHelp_0.Hide()
        Modall.pctView1_0.Hide()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.dtpDateFrom.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateFrom.Format = DateTimePickerFormat.Custom

        Modall.dtpDateTo.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateTo.Format = DateTimePickerFormat.Custom

        Modall.lblView1_0.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1_0.Show()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If
        Modall.lblView2_0.Hide()
        Modall.lblOrderProduct_0.Hide()
        Modall.lblAvailableProduct_0.Hide()
        Modall.lblView2_0.Hide()

        Modall.lblInventory1_0.Show()
        Modall.lblInventory2_0.Hide()


        Modall.lblExpiredRawMaterial_0.Show()
        Modall.lblCriticalRawMaterial_0.Show()

        Modall.lblSystem1_0.Hide()
        Modall.lblSystem2_0.Hide()
        Modall.lblSystem3_0.Hide()
        Modall.lblSystem4_0.Show()

        Modall.lblHelp2_0.Hide()
        Modall.lblHelp3_0.Hide()
        'lblHelp4.Hide()
        Modall.lblCalculator_0.Hide()
        Modall.lblKeyboardShortcut_0.Hide()
        Modall.lblViewHelp_0.Hide()
        Modall.lblAbout_0.Hide()
        ' lblSystem4.Show()
        Modall.lblHelp4_0.Show()
        Modall.lblBackUpandRestore_0.Hide()
    End Sub
    Public Sub lblView3MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Show()
        Modall.pctSystem4_0.Hide()
        Modall.pctHelp_0.Hide()
        ' pctSystem3.Hide()
        Modall.pctView1_0.Hide()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.dtpDateFrom.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateFrom.Format = DateTimePickerFormat.Custom
        Modall.dtpDateTo.CustomFormat = " "  'An empty SPACE
        Modall.dtpDateTo.Format = DateTimePickerFormat.Custom

        Modall.lblView1_0.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1_0.Show()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If
        Modall.lblView3_0.Hide()
        Modall.lblRawMaterials_0.Hide()
        Modall.lblProducts_0.Hide()
        Modall.lblRawMaterialsanditsProducts_0.Hide()


        Modall.lblExpiredRawMaterial_0.Show()
        Modall.lblCriticalRawMaterial_0.Show()


        ' lblSystem4.Show()

        ' lblHelp3.Hide()

        Modall.lblSystem1_0.Hide()
        Modall.lblSystem2_0.Hide()
        Modall.lblSystem3_0.Hide()
        Modall.lblSystem4_0.Show()

        'lblHelp3.Show()
        Modall.lblHelp3_0.Hide()
        Modall.lblHelp4_0.Show()

        Modall.lblBackUpandRestore_0.Hide()
        Modall.lblCalculator_0.Hide()
        Modall.lblKeyboardShortcut_0.Hide()
        Modall.lblViewHelp_0.Hide()
        Modall.lblAbout_0.Hide()
    End Sub
    Public Sub lblSystem1MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Show()
        Modall.pctHelp_0.Hide()
        ' pctSystem3.Hide()
        Modall.pctView1_0.Hide()

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblOrderProduct_0.Hide()
        Modall.lblAvailableProduct_0.Hide()
        Modall.lblInventory2_0.Hide()

        Modall.lblInventory1_0.Show()

        Modall.lblRawMaterials_0.Hide()
        Modall.lblProducts_0.Hide()
        Modall.lblRawMaterialsanditsProducts_0.Hide()

        Modall.lblView1_0.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1_0.Show()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If
        Modall.lblView2_0.Hide()
        Modall.lblView3_0.Hide()


        Modall.lblExpiredRawMaterial_0.Hide()
        Modall.lblCriticalRawMaterial_0.Hide()


        Modall.lblSystem1_0.Show()
        Modall.lblSystem2_0.Hide()
        Modall.lblSystem3_0.Hide()
        Modall.lblSystem4_0.Hide()
        Modall.lblHelp1_0.Show()
        Modall.lblHelp2_0.Hide()
        Modall.lblHelp3_0.Hide()
        Modall.lblHelp4_0.Hide()

        Modall.lblBackUpandRestore_0.Show()
        Modall.lblCalculator_0.Hide()
        Modall.lblKeyboardShortcut_0.Hide()
        Modall.lblViewHelp_0.Hide()
        Modall.lblAbout_0.Hide()
    End Sub
    Public Sub lblSystem2MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Show()
        Modall.pctHelp_0.Hide()
        ' pctSystem3.Hide()
        Modall.pctView1_0.Hide()

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblOrderProduct_0.Hide()
        Modall.lblAvailableProduct_0.Hide()
        Modall.lblInventory1_0.Show()
        Modall.lblInventory2_0.Hide()
        Modall.lblView1_0.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1_0.Show()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If
        Modall.lblView2_0.Hide()
        Modall.lblView3_0.Hide()
        Modall.lblSystem4_0.Hide()
        Modall.lblSystem3_0.Hide()
        Modall.lblSystem2_0.Hide()
        Modall.lblSystem1_0.Show()
        Modall.lblBackUpandRestore_0.Show()
        Modall.lblHelp1_0.Show()
        Modall.lblHelp2_0.Hide()
        Modall.lblHelp3_0.Hide()

        Modall.lblCalculator_0.Hide()
        Modall.lblKeyboardShortcut_0.Hide()
        Modall.lblViewHelp_0.Hide()
        Modall.lblAbout_0.Hide()
    End Sub
    Public Sub lblSystem3MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Show()
        Modall.pctHelp_0.Hide()
        ' pctSystem3.Hide()
        Modall.pctView1_0.Hide()

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblSystem4_0.Hide()
        Modall.lblSystem3_0.Hide()
        Modall.lblSystem2_0.Hide()
        Modall.lblSystem1_0.Show()

        Modall.lblRawMaterials_0.Hide()
        Modall.lblProducts_0.Hide()
        Modall.lblRawMaterialsanditsProducts_0.Hide()
        Modall.lblBackUpandRestore_0.Show()
        Modall.lblHelp4_0.Hide()
        Modall.lblHelp3_0.Hide()
        Modall.lblView1_0.Show()
        Modall.lblView2_0.Hide()
        Modall.lblView3_0.Hide()

        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1_0.Show()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If

        Modall.lblCalculator_0.Hide()
        Modall.lblKeyboardShortcut_0.Hide()
        Modall.lblViewHelp_0.Hide()
        Modall.lblAbout_0.Hide()
    End Sub
    Public Sub lblSystem4MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Show()
        Modall.pctHelp_0.Hide()
        ' pctSystem3.Hide()
        Modall.pctView1_0.Hide()

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblSystem4_0.Hide()
        Modall.lblSystem3_0.Hide()
        Modall.lblSystem2_0.Hide()
        Modall.lblSystem1_0.Show()

        Modall.lblExpiredRawMaterial_0.Hide()
        Modall.lblCriticalRawMaterial_0.Hide()

        Modall.lblBackUpandRestore_0.Show()
        Modall.lblHelp4_0.Hide()
        Modall.lblHelp1_0.Show()

        Modall.lblCalculator_0.Hide()
        Modall.lblKeyboardShortcut_0.Hide()
        Modall.lblViewHelp_0.Hide()
        Modall.lblAbout_0.Hide()
    End Sub
    Public Sub lblHelp1MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Hide()
        Modall.pctHelp_0.Show()
        Modall.pctView1_0.Hide()

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblCalculator_0.Show()
        Modall.lblKeyboardShortcut_0.Show()
        Modall.lblViewHelp_0.Show()
        Modall.lblAbout_0.Show()

        Modall.lblBackUpandRestore_0.Hide()
    End Sub
    Public Sub lblHelp2MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Hide()
        Modall.pctHelp_0.Show()
        Modall.pctView1_0.Hide()

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblOrderProduct_0.Hide()
        Modall.lblAvailableProduct_0.Hide()

        Modall.lblInventory1_0.Show()
        Modall.lblInventory2_0.Hide()

        Modall.lblView1_0.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1_0.Show()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If
        Modall.lblView2_0.Hide()
        Modall.lblView3_0.Hide()
        Modall.lblSystem1_0.Show()
        Modall.lblSystem2_0.Hide()
        Modall.lblSystem3_0.Hide()
        Modall.lblHelp1_0.Show()
        Modall.lblHelp2_0.Hide()
        Modall.lblHelp3_0.Hide()
        Modall.lblHelp4_0.Hide()

        Modall.lblCalculator_0.Show()
        Modall.lblKeyboardShortcut_0.Show()
        Modall.lblViewHelp_0.Show()
        Modall.lblAbout_0.Show()
    End Sub
    Public Sub lblHelp3MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Hide()
        Modall.pctHelp_0.Show()
        Modall.pctView1_0.Hide()

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblHelp4_0.Hide()
        Modall.lblHelp1_0.Show()
        Modall.lblSystem1_0.Show()
        Modall.lblSystem2_0.Hide()
        Modall.lblSystem3_0.Hide()
        Modall.lblSystem4_0.Hide()


        Modall.lblCriticalRawMaterial_0.Hide()
        Modall.lblExpiredRawMaterial_0.Hide()


        Modall.lblCalculator_0.Show()
        Modall.lblKeyboardShortcut_0.Show()
        Modall.lblViewHelp_0.Show()
        Modall.lblAbout_0.Show()

        Modall.lblRawMaterials_0.Hide()
        Modall.lblRawMaterialsanditsProducts_0.Hide()
        Modall.lblProducts_0.Hide()

        Modall.lblView1_0.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1_0.Show()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If
        Modall.lblView2_0.Hide()
        Modall.lblView3_0.Hide()
    End Sub
    Public Sub lblHelp4MouseHover_0()
        Modall.pctSales_0.Hide()
        Modall.pctInventory_0.Hide()
        Modall.pctView_0.Hide()
        Modall.pctSystem4_0.Hide()
        Modall.pctHelp_0.Show()
        Modall.pctView1_0.Hide()

        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblHelp4_0.Hide()
        Modall.lblHelp3_0.Hide()
        Modall.lblHelp2_0.Hide()
        Modall.lblHelp1_0.Show()
        Modall.lblSystem1_0.Show()
        Modall.lblSystem2_0.Hide()
        Modall.lblSystem3_0.Hide()
        Modall.lblSystem4_0.Hide()


        Modall.lblCriticalRawMaterial_0.Hide()
        Modall.lblExpiredRawMaterial_0.Hide()


        Modall.lblCalculator_0.Show()
        Modall.lblKeyboardShortcut_0.Show()
        Modall.lblViewHelp_0.Show()
        Modall.lblAbout_0.Show()

        Modall.lblRawMaterials_0.Hide()
        Modall.lblRawMaterialsanditsProducts_0.Hide()
        Modall.lblProducts_0.Hide()

        Modall.lblView1_0.Show()
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk1_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation1_0.Show()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If
        Modall.lblView2_0.Hide()
        Modall.lblView3_0.Hide()
    End Sub
    Public Sub lblOrderProductClick_0()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "a"
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk2_0.Show()
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation2_0.Show()
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If

        Modall.grpOrderProd.Show()
        Modall.ComboBox8.SelectedIndex = 4
        fillOrderProd()
        Modall.grpRecord.Hide()
        Modall.TabControl1.Hide()
        Modall.grpBgRawMats.Hide()
        Modall.grpBgProducts.Hide()
        Modall.grpBgRawProducts.Hide()
        Modall.grpExpired.Hide()
        Modall.grpCritical.Hide()
        Modall.DataGridView9.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub

    Public Sub lblAvailableProductClick_0()
        Modall.Expired_Raw_Mats()
        Modall.Critical_Raw_Mats()
        Modall.lblPrintCondition.Text = "b"
        If Modall.putExpired = 0 Then
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk2_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        ElseIf Modall.putExpired > 0 Then
            Modall.Expiredasterisk2_0.Show()
            Modall.Expiredasterisk1_0.Hide()
            Modall.Expiredasterisk3_0.Hide()
        End If

        If Modall.putCritical = 0 Then
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation2_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        ElseIf Modall.putCritical > 0 Then
            Modall.Criticalquotation2_0.Show()
            Modall.Criticalquotation1_0.Hide()
            Modall.Criticalquotation3_0.Hide()
        End If
        Modall.TabControl1.Show()
        Modall.ComboBox6.SelectedIndex = 4
        fillAvailableProd()
        Modall.grpRecord.Hide()
        Modall.grpOrderProd.Hide()
        Modall.grpBgRawMats.Hide()
        Modall.grpBgProducts.Hide()
        Modall.grpBgRawProducts.Hide()
        Modall.grpExpired.Hide()
        Modall.grpCritical.Hide()
        Modall.DataGridView8.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        Modall.AddSelectAllCheckBoxn(Modall.DataGridView8)
        Modall.cmdDeletebtnRawHide.Show()
        Modall.btnAvailableProd.Hide()
        Modall.txtOrderName.Enabled = False
        Modall.txtOrderQuant.Enabled = False
        Modall.cmbOrderSize.Enabled = False
        Modall.btnOrderProd.Enabled = False
    End Sub

End Module

