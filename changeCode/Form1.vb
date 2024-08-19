
Public Class frmChange

    Dim da As SqlClient.SqlDataAdapter
    Dim ds As DataSet = New DataSet

    Dim subDA As Data.SqlClient.SqlDataAdapter
    Dim subDS As New Data.DataSet

    Dim chkColor As Boolean = False
    Dim chkColor2 As Boolean = False

    Dim chkProdList As Boolean = False
    Dim chkStk As Boolean = False
    Dim chkGrp As Boolean = False
    Dim chkGrp2 As Boolean = False

    Dim chkData2 As Boolean = False
    Dim chkData As Boolean = False
    Dim chkLoad As Boolean = False

    Dim lsvData As String()


    Sub addItemCBO()

        Dim da As SqlClient.SqlDataAdapter
        Dim ds As DataSet = New DataSet
        Dim iRow As Integer = 0


        txtSQL = "Select Th_Name3,"
        txtSQL = txtSQL & "Th_Code,Th_Th "
        txtSQL = txtSQL & "From ThMast "
        txtSQL = txtSQL & "Order by Th_Th "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "ThMast")
        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "ThMast2")

        If ds.Tables("ThMast").Rows.Count > 0 Then
            With cboThick
                .DataSource = ds.Tables("ThMast")
                .DisplayMember = "Th_Name3"
                .ValueMember = "Th_Code"
                .Text = ""
            End With
            With cboTh2
                .DataSource = ds.Tables("ThMast2")
                .DisplayMember = "Th_Name3"
                .ValueMember = "Th_Code"
                .Text = ""
            End With
        End If

        txtSQL = "Select  Size_Name_2,Size_Code  From SizeMast "
        txtSQL = txtSQL & "Order by Size_Name_2  "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "SizeMast")
        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "SizeMast2")

        If ds.Tables("SizeMast").Rows.Count > 0 Then
            With cboSize
                .DataSource = ds.Tables("SizeMast")
                .DisplayMember = "Size_Name_2"
                .ValueMember = "Size_Code"
                .Text = ""
            End With
            With cboSize2
                .DataSource = ds.Tables("SizeMast2")
                .DisplayMember = "Size_Name_2"
                .ValueMember = "Size_Code"
                .Text = ""
            End With
        End If

        txtSQL = "Select  Paper_Name,Paper_Code  From PaperMast "
        txtSQL = txtSQL & "Order by Paper_Code"

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "PaperMast")
        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "PaperMast2")

        If ds.Tables("PaperMast").Rows.Count > 0 Then
            With cboPaper
                .DataSource = ds.Tables("paperMast")
                .DisplayMember = "Paper_Name"
                .ValueMember = "Paper_Code"
                .Text = ""

            End With
            With cboPaper2
                .DataSource = ds.Tables("paperMast2")
                .DisplayMember = "Paper_Name"
                .ValueMember = "Paper_Code"
                .Text = ""

            End With
        End If

        txtSQL = "Select  G_Name,G_Code  From gMast "
        txtSQL = txtSQL & "Order by G_Name "

        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "GradeMast")
        da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        da.Fill(ds, "GradeMast2")


        If ds.Tables("GradeMast").Rows.Count > 0 Then
            With cboGrade
                .DataSource = ds.Tables("GradeMast")
                .DisplayMember = "G_Name"
                .ValueMember = "G_Code"
                .Text = ""
            End With
            With cboGrade2
                .DataSource = ds.Tables("GradeMast2")
                .DisplayMember = "G_Name"
                .ValueMember = "G_Code"
                .Text = ""
            End With
        End If

        'Call chgColorList()

    End Sub
    Sub addProdList()

        txtSQL = "Select * "
        txtSQL = txtSQL & "From ProGrpMast "
        txtSQL = txtSQL & "Order by ProGrp_id "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listData")
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listData2")
        If subDS.Tables("listData").Rows.Count > 0 Then
            cboProdList.DataSource = subDS.Tables("listData")
            cboProdList.ValueMember = "ProGrp_id"
            cboProdList.DisplayMember = "ProGrp_Name"
            'cboDClist.Text = ""
            cboProdList.SelectedItem = 0

            cboProdList2.DataSource = subDS.Tables("listData2")
            cboProdList2.ValueMember = "ProGrp_id"
            cboProdList2.DisplayMember = "ProGrp_Name"
            'cboDClist.Text = ""
            cboProdList2.SelectedItem = 0
        End If

      

    End Sub

    Private Sub frmChange_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If chkLoad = False Then
            getColListView()
            dbTools.openDB()
            Call addItemCBO()
            'Call addListDC()

            Call addProdList()
            chkLoad = True
        End If


    End Sub

    
    Private Sub cboProdList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProdList.SelectedIndexChanged
        Dim subDs As DataSet = New DataSet
        Dim subDa1 As SqlClient.SqlDataAdapter
        Try
            txtSQL = "Select  Type_Code,Type_Name  From TypeMast "
            txtSQL = txtSQL & "Where Type_Prod = '" & cboProdList.SelectedValue & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDa1.Fill(subDs, "dbList")
            chkProdList = True

            If subDs.Tables("dbList").Rows.Count > 0 Then
                With cboType
                    .DataSource = subDs.Tables("dbList")
                    .DisplayMember = "Type_Name"
                    .ValueMember = "Type_Code"                    
                    .Text = ""
                End With
                'cboType.SelectedItem = Nothing
            End If
            'lbTypeID.Text = cboType.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Function chkSize(ByVal stkCode1 As String, ByVal stkCode2 As String) As Boolean




    End Function

    Private Sub cmbRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRun.Click
        If txtStkCodeOld.Text = "" Then
            MsgBox("สินค้ารหัสที่  1 มีปัญหา โปรดตรวจสอบอีกครั้ง.")
            Exit Sub

        End If

        If Not (dbTools.getSizecode(txtStkCodeOld.Text) = dbTools.getSizecode(lbStkCodeNew.Text)) Then
            If MsgBox("พบความไม่สัมพันธ์ใน ขนาด กxย ของสินค้า ต้องการทำต่อหรือไม่ ? ", MsgBoxStyle.YesNo, MsgBoxStyle.Critical) = MsgBoxResult.Yes Then

            Else
                Exit Sub
            End If
        End If

        If Not (dbTools.getTHcode(txtStkCodeOld.Text) = dbTools.getTHcode(lbStkCodeNew.Text)) Then
            If MsgBox("พบความไม่สัมพันธ์ใน ความหนา ของสินค้า ต้องการทำต่อหรือไม่ ? ", MsgBoxStyle.YesNo, MsgBoxStyle.Critical) = MsgBoxResult.Yes Then

            Else
                Exit Sub
            End If
        End If

        If lbStkCodeNew.Text = "" Then
            MsgBox("สินค้ารหัสที่ 2 มีปัญหา โปรดตรวจสอบอีกครั้ง.")
            Exit Sub
        Else

            If MsgBox("แจ้งเตือน การทำการเปลี่ยนแปลงรหัสสินค้าและชื่อสินค้า อาจจะมีผลกับข้อมูลการขายสินค้า ", MsgBoxStyle.YesNo, "แจ้งเตือน") = MsgBoxResult.Yes Then
                Call changeCode(txtStkCodeOld.Text, lbStkCodeNew.Text)
                txtStkCodeOld.Text = ""
                lbStkName.Text = ""
                lbStkCodeNew.Text = ""
                lbStkName2.Text = ""
            Else

            End If



        End If


    End Sub

    Sub changeCode(ByVal strCodeOld As String, ByVal strCodeNew As String)
        Dim OLD_stock_VK As Double = 0
        Dim OLD_stock_PA As Double = 0
        Dim Stock_VK As Double = 0
        Dim Stock_PA As Double = 0

        ' 1.  ลบข้อมูลประวัติสินค้าเก่าใน BaseMast
        txtSQL = "Delete  "
        txtSQL = txtSQL & "From BaseMast "
        txtSQL = txtSQL & "Where stk_code='" & strCodeOld & "' "

        dbTools.dbDelSQLsrv(txtSQL, dbTools.getStkName(strCodeOld & " ในการเปลี่ยนประวัติ"))

        '   เช็ค Stock รหัสเก่า+ใหม่ เก็บในตัวแปร

        Stock_PA = dbTools.getStock(strCodeOld, "100001", "01")
        'Stock_VK = dbTools.getStock(strCodeOld, "110098", "12")

        OLD_stock_PA = dbTools.getStock(strCodeNew, "100001", "01")
        'OLD_stock_VK = dbTools.getStock(strCodeNew, "110098", "12")

        Stock_PA = Stock_PA + OLD_stock_PA
        'Stock_VK = Stock_VK + OLD_stock_VK
        '=============================================================

        ' 2. ลบข้อมูลรหัสใหม่ใน Stkdetl
        txtSQL = "Delete "
        txtSQL = txtSQL & "From Stkdetl "
        txtSQL = txtSQL & "Where Dtl_Code ='" & strCodeNew & "' "

        dbTools.dbDelSQLsrv(txtSQL, dbTools.getStkName(strCodeNew & " ในการเปลี่ยนประวัติ"))


        ' 3. เปลี่ยน รหัสเก่า เป็น  รหัสใหม่ ใน StkDetl

        txtSQL = "Update StkDetl "
        txtSQL = txtSQL & "Set dtl_code='" & strCodeNew & "', Dtl_Bal_Q1='" & Stock_PA & "' "
        txtSQL = txtSQL & "Where dtl_code='" & strCodeOld & "'  And dtl_wh='01' "

        dbTools.dbSaveSQLsrv(txtSQL, dbTools.getStkName(strCodeOld & " ในการเปลี่ยนประวัติ"))

        'txtSQL = "Update StkDetl "
        'txtSQL = txtSQL & "Set dtl_code='" & strCodeNew & "', Dtl_Bal_Q1='" & Stock_VK & "' "
        'txtSQL = txtSQL & "Where dtl_code='" & strCodeOld & "' And dtl_wh='12' "

        'dbTools.dbSaveSQLsrv(txtSQL, dbTools.getStkName(strCodeOld & " ในการเปลี่ยนประวัติ"))

        '4.  เปลี่ยนรหัสเก่าเป็นรหัสใหม่ ใน TranDataD

        txtSQL = "Update TranDataD "
        txtSQL = txtSQL & "Set dtl_idTrade ='" & strCodeNew & "' "
        txtSQL = txtSQL & "Where dtl_idTrade='" & strCodeOld & "' "
        dbTools.dbSaveSQLsrv(txtSQL, dbTools.getStkName(strCodeOld & " ในการเปลี่ยนประวัติ"))

        txtSQL = "Update TranDataD_E "
        txtSQL = txtSQL & "Set dtl_idTrade ='" & strCodeNew & "' "
        txtSQL = txtSQL & "Where dtl_idTrade='" & strCodeOld & "' "
        dbTools.dbSaveSQLsrv(txtSQL, dbTools.getStkName(strCodeOld & " ในการเปลี่ยนประวัติ"))

        txtSQL = "Update CostMast "
        txtSQL = txtSQL & "Set CS_Stk_Code ='" & strCodeNew & "' "
        txtSQL = txtSQL & "Where CS_Stk_Code='" & strCodeOld & "' "
        dbTools.dbSaveSQLsrv(txtSQL, dbTools.getStkName(strCodeOld & " ในการเปลี่ยนประวัติ"))

        txtSQL = "Update  Apprice "
        txtSQL = txtSQL & "Set P_Stk_CD='" & strCodeNew & "' "
        txtSQL = txtSQL & "Where P_Stk_CD='" & strCodeOld & "' "

        dbTools.dbSaveSQLsrv(txtSQL, dbTools.getStkName(strCodeOld & " ในการเปลี่ยนประวัติ"))


    End Sub


    Sub ShowData()

        Dim lvi As ListViewItem

        Dim itemStk_Name As String
        Dim itemStk_Code As String
        Dim itemDtl_Bal_PA As String
        Dim itemDtl_Bal_VK As String

        Dim txtSQL2 As String = ""
        Dim txtsql3 As String = ""

        txtSQL = "Select  Stk_Code,Stk_Name_1,"
        txtSQL = txtSQL & "Stk_Factor,ColorMast.Color_Name,"
        txtSQL = txtSQL & "ThMast.Th_Name,SizeMast.Size_Name, "
        txtSQL = txtSQL & "StkDetl.Dtl_Bal_Q1/*,TB2.Dtl_Bal_Q1 as Bal_Q1_VK*/ "

        txtSQL = txtSQL & "From  BaseMast Left Join ColorMast "
        txtSQL = txtSQL & "On BaseMast.Color_Code=ColorMast.Color_Code "
        txtSQL = txtSQL & "And BaseMast.Type_Code=ColorMast.Color_Type "

        txtSQL = txtSQL & "Left Join SizeMast "
        txtSQL = txtSQL & "On BaseMast.Size_Code=SizeMast.Size_Code "

        txtSQL = txtSQL & "Left Join ThMast "
        txtSQL = txtSQL & "On BaseMast.Th_Code=ThMast.Th_Code "

        txtSQL = txtSQL & "Left join stkDetl "
        txtSQL = txtSQL & "On BaseMast.Stk_code=stkDetl.Dtl_Code "

        'txtSQL = txtSQL & "Left join stkDetl TB2 "
        'txtSQL = txtSQL & "On BaseMast.Stk_code=TB2.Dtl_Code "

        '===================   Where  =========================

        txtSQL = txtSQL & "Where "
        txtSQL = txtSQL & " (Len(BaseMast.Stk_Name_1) > 0 ) "
        'txtSQL = txtSQL & "And (StkDetl.Dtl_Wh='01') "
        'txtSQL = txtSQL & "And (TB2.Dtl_Wh='12')"

        If Trim(cboType.Text) = "" Then

        Else
            If chkType0.Checked = True Then
                txtSQL = txtSQL & " And   BaseMast.Type_Code='" & cboType.SelectedValue & "' "
            End If

        End If

        If Trim(cboGrp.Text) = "" Then

        Else
            If chkGrp0.Checked = True Then
                txtSQL = txtSQL & " And  BaseMast.Grp_Code='" & cboGrp.SelectedValue & "' "
            End If

        End If

        If Trim(cboSize.Text) = "" Then
        Else
            If chkSize0.Checked = True Then
                txtSQL = txtSQL & " And  BaseMast.Size_Code='" & cboSize.SelectedValue & "' "

            End If

        End If

        If Trim(cboPaper.Text) = "" Then
        Else
            If chkPaper0.Checked = True Then
                txtSQL = txtSQL & " And  BaseMast.paper_code='" & cboPaper.SelectedValue & "' "
            End If

        End If

        If Trim(cboThick.Text) = "" Then
        Else
            If chkTh0.Checked = True Then
                txtSQL = txtSQL & " And  BaseMast.Th_Code='" & cboThick.SelectedValue & "' "
            End If

        End If

        If Trim(cboColor.Text) = "" Then

        Else
            If chkColor0.Checked = True Then
                txtSQL = txtSQL & " And  BaseMast.color_Code='" & cboColor.SelectedValue & "' "
            End If

        End If

        If Trim(cboGrade.Text) = "" Then
        Else
            If chkG0.Checked = True Then
                txtSQL = txtSQL & " And  BaseMast.G_Code='" & cboGrade.SelectedValue & "' "
            End If

        End If

        If Trim(cboProdList.Text) = "" Then
        Else

            txtSQL = txtSQL & "And BaseMast.Stk_Prod='" & cboProdList.SelectedValue & "' "

        End If
        'End If

        '===================   Where  =========================

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData = True Then
            subDS.Tables("Master").Clear()
            chkData = False
        End If

        subDA.Fill(subDS, "Master")
        chkData = True

        lsvShow.Items.Clear()
        For i = 0 To subDS.Tables("Master").Rows.Count - 1

            itemStk_Code = subDS.Tables("Master").Rows(i).Item("Stk_Code")
            itemStk_Name = subDS.Tables("Master").Rows(i).Item("Stk_Name_1")
            If IsDBNull(subDS.Tables("Master").Rows(i).Item("Dtl_Bal_Q1")) Then
                itemDtl_Bal_PA = 0
            Else
                itemDtl_Bal_PA = subDS.Tables("Master").Rows(i).Item("Dtl_Bal_Q1")
            End If

            'itemDtl_Bal_VK = subDS.Tables("Master").Rows(i).Item("Bal_Q1_VK")

            lsvData = New String() {i, itemStk_Code, itemStk_Name, itemDtl_Bal_PA, itemDtl_Bal_PA}
            'MsgBox("=")
            lvi = New ListViewItem(lsvData)
            lsvShow.Items.Add(lvi)

        Next

        'dataShow.DataSource = subDS.Tables("Master")
        'dataShow.Refresh()


        Try
            lbStkName.Text = subDS.Tables("Master").Rows(0).Item("Stk_name_1")
            txtStkCodeOld.Text = subDS.Tables("Master").Rows(0).Item("Stk_Code")



        Catch ex As Exception

        End Try

    End Sub

    Sub getColListView()

        lsvShow.Columns.Add("Item", 60, HorizontalAlignment.Center)
        lsvShow.Columns.Add("รหัสสินค้า", 230, HorizontalAlignment.Center)
        lsvShow.Columns.Add("ชื่อสินค้า", 500, HorizontalAlignment.Left)
        lsvShow.Columns.Add("", 100, HorizontalAlignment.Right)
        lsvShow.Columns.Add("", 200, HorizontalAlignment.Right)
        lsvShow.Columns.Add("", 200, HorizontalAlignment.Right)

        lsvShow.View = View.Details
        lsvShow.GridLines = True


    End Sub


    Sub ShowData2()

        Dim txtSQL2 As String = ""
        Dim txtsql3 As String = ""

        lbStkName2.Text = ""
        lbStkCodeNew.Text = ""

        txtSQL = "Select  Stk_Code,Stk_Name_1,"
        txtSQL = txtSQL & "Stk_Factor,ColorMast.Color_Name,"
        txtSQL = txtSQL & "ThMast.Th_Name,SizeMast.Size_Name "

        txtSQL = txtSQL & "From  BaseMast Left Join ColorMast "
        txtSQL = txtSQL & "On BaseMast.Color_Code=ColorMast.Color_Code "
        txtSQL = txtSQL & "And BaseMast.Type_Code=ColorMast.Color_Type "

        txtSQL = txtSQL & "Left Join SizeMast "
        txtSQL = txtSQL & "On BaseMast.Size_Code=SizeMast.Size_Code "

        txtSQL = txtSQL & "Left Join ThMast "
        txtSQL = txtSQL & "On BaseMast.Th_Code=ThMast.Th_Code "

        '===================   Where  =========================

        txtSQL = txtSQL & "Where "
        txtSQL = txtSQL & " (Len(BaseMast.Stk_Name_1) > 0 ) "

        If Trim(cboType.SelectedValue) = "" Then

        Else
            txtSQL = txtSQL & " And   BaseMast.Type_Code='" & cboType2.SelectedValue & "' "
        End If

        If Trim(cboGrp.SelectedValue) = "" Then

        Else

            txtSQL = txtSQL & " And  BaseMast.Grp_Code='" & cboGrp2.SelectedValue & "' "
        End If

        If Trim(cboSize.SelectedValue) = "" Then
        Else

            txtSQL = txtSQL & " And  BaseMast.Size_Code='" & cboSize2.SelectedValue & "' "
        End If

        If Trim(cboPaper.SelectedValue) = "" Then
        Else
            txtSQL = txtSQL & " And  BaseMast.paper_code='" & cboPaper2.SelectedValue & "' "
        End If

        If Trim(cboThick.SelectedValue) = "" Then
        Else

            txtSQL = txtSQL & " And  BaseMast.Th_Code='" & cboTh2.SelectedValue & "' "
        End If

        If Trim(cboColor.SelectedValue) = "" Then

        Else
            txtSQL = txtSQL & " And  BaseMast.color_Code='" & cboColor2.SelectedValue & "' "
        End If

        If Trim(cboGrade.SelectedValue) = "" Then
        Else
            txtSQL = txtSQL & " And  BaseMast.G_Code='" & cboGrade2.SelectedValue & "' "
        End If

        If Trim(cboProdList2.SelectedValue = "") Then

        Else
            txtSQL = txtSQL & "And BaseMast.Stk_Prod='" & cboProdList2.SelectedValue & "' "
        End If
        'End If

        '===================   Where  =========================


        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        If chkData2 = True Then
            subDS.Tables("Master2").Clear()
            chkData2 = False
        End If
        subDA.Fill(subDS, "Master2")
        chkData2 = True
        If subDS.Tables("Master2").Rows.Count - 1 < 0 Then
            MsgBox("ไม่พบข้อมูลสินค้า โปรดสร้างสินค้าก่อนการเปลี่ยนรหัส", MsgBoxStyle.Critical)
        End If

        Try
            lbStkName2.Text = subDS.Tables("Master2").Rows(0).Item("Stk_name_1")
            lbStkCodeNew.Text = subDS.Tables("Master2").Rows(0).Item("Stk_Code")

            lbStkPA02.Text = dbTools.getStock(lbStkCodeNew.Text, "100001", "01")
            'lbStkVK02.Text = dbTools.getStock(lbStkCodeNew.Text, "110098", "12")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdSel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSel1.Click
        'Dim stkCode As String
        'Dim stkName As String
        'Dim stkFactor As String
        'Dim stkTh As String
        'Dim stkColor As String

        lbStkName.Text = ""
        txtStkCodeOld.Text = ""

        Call ShowData()

    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        Call chgColorList()

        Try
            lbType.Text = cboType.Text
            Label4.Text = cboType.SelectedValue
            txtSQL = "Select  Grp_Code,Grp_Name,Grp_StkName  "
            txtSQL = txtSQL & "From GrpMast "
            If IsDBNull(cboType.SelectedValue) = True Then

            Else
                'txtSQL = txtSQL & "Where Grp_Type_Code='" & cboType.SelectedValue & "' "
            End If

            txtSQL = txtSQL & "Order by Grp_Name "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkGrp = True Then
                subDS.Tables("GrpMast").Clear()
                chkGrp = False

            End If

            subDA.Fill(subDS, "GrpMast")
            chkGrp = True
            If subDS.Tables("GrpMast").Rows.Count > 0 Then
                With cboGrp
                    .DataSource = subDS.Tables("GrpMast")
                    .DisplayMember = "Grp_Name"
                    .ValueMember = "Grp_Code"
                    .Text = ""
                End With
            End If

        Catch ex As Exception

        End Try
    End Sub

    Sub chgColorList()

        '==================================================================================================================
        Try

            txtSQL = "Select  Color_Code,(color_code1 + '-' + Color_StkName) as Color_StkName "
            txtSQL = txtSQL & "From ColorMast "

            If IsDBNull(cboType.SelectedValue) Then

            Else
                'txtSQL = txtSQL & "Where Color_Type='" & cboType.SelectedValue & "' "
            End If

            txtSQL = txtSQL & "Order by Color_StkName "

            da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkColor = True Then
                ds.Tables("ColorMast").Clear()
                chkColor = False
            End If

            da.Fill(ds, "ColorMast")
            chkColor = True
            If ds.Tables("ColorMast").Rows.Count > 0 Then
                cboColor.Items.Clear()
                With cboColor
                    .DataSource = ds.Tables("ColorMast")
                    .DisplayMember = "Color_StkName"
                    .ValueMember = "Color_Code"
                    .Text = ""
                End With
            End If
        Catch ex As Exception

        End Try

        'cboColor.Text = ""
        'cboColor.SelectedIndex = Nothing
        'cboColor.SelectedValue = "00001"

    End Sub

    Private Sub cmbSel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSel2.Click
        ShowData2()
    End Sub


    Private Sub cboProdList2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProdList2.SelectedIndexChanged

        Dim subDs As DataSet = New DataSet
        Dim subDa1 As SqlClient.SqlDataAdapter

        Try
            txtSQL = "Select  Type_Code,Type_Name  From TypeMast "
            txtSQL = txtSQL & "Where Type_Prod = '" & cboProdList2.SelectedValue & "' "
            txtSQL = txtSQL & "Order by Type_Code "

            subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDa1.Fill(subDs, "dbList")
            chkProdList = True

            If subDs.Tables("dbList").Rows.Count > 0 Then
                With cboType2
                    .DataSource = subDs.Tables("dbList")
                    .DisplayMember = "Type_Name"
                    .ValueMember = "Type_Code"
                    .Text = ""
                End With
                'cboType.SelectedItem = Nothing
            End If
            'lbTypeID.Text = cboType.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click

        End

    End Sub

    Private Sub cboType2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType2.SelectedIndexChanged
        Call chgColorList2()
        Try
            txtSQL = "Select  Grp_Code,Grp_Name,Grp_StkName  "
            txtSQL = txtSQL & "From GrpMast "
            If IsDBNull(cboType2.SelectedValue) = True Then

            Else
                txtSQL = txtSQL & "Where Grp_Type_Code='" & cboType2.SelectedValue & "' "
            End If

            txtSQL = txtSQL & "Order by Grp_Name "

            subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkGrp2 = True Then
                subDS.Tables("GrpMast2").Clear()
                chkGrp2 = False

            End If
            subDA.Fill(subDS, "GrpMast2")
            chkGrp2 = True
            If subDS.Tables("GrpMast2").Rows.Count > 0 Then
                With cboGrp2

                    .DataSource = subDS.Tables("GrpMast2")
                    .DisplayMember = "Grp_Name"
                    .ValueMember = "Grp_Code"
                    .Text = ""
                End With
            End If


        Catch ex As Exception

        End Try
    End Sub

    Sub chgColorList2()
        Dim iCount As Integer = 0
        '==================================================================================================================
        Try

            txtSQL = "Select  Color_Code,(color_code1 + '-' + Color_StkName) as Color_StkName "
            txtSQL = txtSQL & "From ColorMast "

            If IsDBNull(cboType2.SelectedValue) Then

            Else
                txtSQL = txtSQL & "Where Color_Type='" & cboType2.SelectedValue & "' "
            End If

            txtSQL = txtSQL & "Order by Color_StkName "

            da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkColor2 = True Then
                ds.Tables("ColorMast2").Clear()
                chkColor2 = False
            End If

            da.Fill(ds, "ColorMast2")
            chkColor2 = True
            'For icou = 0 To cboColor2.Items.Count - 1
            '    With cboColor2
            '        .Items.Remove(iCount)

            '    End With
            'Next
            If ds.Tables("ColorMast2").Rows.Count > 0 Then

                With cboColor2
                    .DataSource = ds.Tables("ColorMast2")
                    .DisplayMember = "Color_StkName"
                    .ValueMember = "Color_Code"
                    .Text = ""
                End With
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboGrp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrp.SelectedIndexChanged

    End Sub

    Private Sub cboGrp_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrp.SelectedValueChanged
        Try
            lbGrp.Text = cboGrp.Text
            Label3.Text = cboGrp.SelectedValue
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cboColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboColor.SelectedIndexChanged
        Try
            lbColor.Text = cboColor.Text
            Label8.Text = cboColor.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboThick_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboThick.SelectedIndexChanged
        Try
            lbTh.Text = cboThick.Text
            Label7.Text = cboThick.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.SelectedIndexChanged

        Try
            lbSize.Text = cboSize.Text
            Label6.Text = cboSize.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboPaper_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaper.SelectedIndexChanged
        Try
            lbPaper.Text = cboPaper.Text
            Label2.Text = cboPaper.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboGrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrade.SelectedIndexChanged
        Try
            lbGrade.Text = cboGrade.Text
            Label5.Text = cboGrade.SelectedValue
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lsvShow_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsvShow.SelectedIndexChanged
        Dim stkSelect As ListViewItem

        For i = 0 To lsvShow.SelectedItems.Count - 1

            stkSelect = lsvShow.SelectedItems(i)
            txtStkCodeOld.Text = lsvShow.Items(stkSelect.Index).SubItems(1).Text
            lbStkName.Text = lsvShow.Items(stkSelect.Index).SubItems(2).Text
            lsvShow.Items.Remove(stkSelect)
            lbStkPA01.Text = dbTools.getStock(txtStkCodeOld.Text, "100001", "01")
            'lbStkVK01.Text = dbTools.getStock(txtStkCodeOld.Text, "110098", "12")


        Next

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frmFindStk As New frmFindStk
        frmFindStk.ShowDialog()
        lbStkCodeNew.Text = SelectCode
        lbStkName2.Text = dbTools.getStkName(SelectCode)
        lbStkPA02.Text = dbTools.getStock(lbStkCodeNew.Text, "100001", "01")
        'lbStkVK02.Text = dbTools.getStock(lbStkCodeNew.Text, "110098", "12")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim frmFindStk2 As New frmFindStk
        frmFindStk2.ShowDialog()
        txtStkCodeOld.Text = SelectCode
        lbStkName.Text = dbTools.getStkName(SelectCode)
        lbStkPA01.Text = dbTools.getStock(txtStkCodeOld.Text, "100001", "01")
        'lbStkVK01.Text = dbTools.getStock(txtStkCodeOld.Text, "110098", "12")
    End Sub

    Private Sub btnGenCode_Click(sender As Object, e As EventArgs) Handles btnGenCode.Click
        Dim frmGenCode As New frmGenCode
        frmGenCode.Show()
    End Sub
End Class
