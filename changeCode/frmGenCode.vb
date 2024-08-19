Public Class frmGenCode
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboGrade As System.Windows.Forms.ComboBox
    Friend WithEvents lb01 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbGenCode As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPaper As System.Windows.Forms.ComboBox
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents cboTh As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboColor As System.Windows.Forms.ComboBox
    Friend WithEvents cmbExit As System.Windows.Forms.Button
    Friend WithEvents lbLenName As System.Windows.Forms.Label
    Friend WithEvents lb02 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSave As System.Windows.Forms.Button
    Friend WithEvents cmbDel As System.Windows.Forms.Button
    Friend WithEvents cmbCancel As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbStkDetl As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboType As System.Windows.Forms.ComboBox
    Friend WithEvents cboGrp As System.Windows.Forms.ComboBox
    Friend WithEvents txtStkName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbWeight As System.Windows.Forms.TextBox
    Friend WithEvents lbCutWeight As System.Windows.Forms.TextBox
    Friend WithEvents lbCount As System.Windows.Forms.Label
    Friend WithEvents lbWeight2 As System.Windows.Forms.Label
    Friend WithEvents lbCutWeight2 As System.Windows.Forms.Label
    Friend WithEvents lbStkCode3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cboProdList As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dataShow As System.Windows.Forms.DataGrid
    Friend WithEvents lbGrp As System.Windows.Forms.Label
    Friend WithEvents lbGrade As System.Windows.Forms.Label
    Friend WithEvents lbPaper As System.Windows.Forms.Label
    Friend WithEvents lbSize As System.Windows.Forms.Label
    Friend WithEvents lbTh As System.Windows.Forms.Label
    Friend WithEvents lbColor As System.Windows.Forms.Label
    Friend WithEvents lbType As System.Windows.Forms.Label
    Friend WithEvents lbGrpID As System.Windows.Forms.Label
    Friend WithEvents lbGradeID As System.Windows.Forms.Label
    Friend WithEvents lbPaperID As System.Windows.Forms.Label
    Friend WithEvents lbSizeID As System.Windows.Forms.Label
    Friend WithEvents lbThID As System.Windows.Forms.Label
    Friend WithEvents lbColorID As System.Windows.Forms.Label
    Friend WithEvents lbTypeID As System.Windows.Forms.Label
    Friend WithEvents lbFindStk As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboStore As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtStkCodeN As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtPcCode As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtStkName2 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbFindWord As System.Windows.Forms.TextBox
    Friend WithEvents txtSemiFGName As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbStkCode As System.Windows.Forms.TextBox
    Friend WithEvents optVatAll As RadioButton
    Friend WithEvents optNVat As RadioButton
    Friend WithEvents optVAT As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents chkType0 As RadioButton
    Friend WithEvents chkType2 As RadioButton
    Friend WithEvents chkType1 As RadioButton
    Friend WithEvents lbStkCode2 As Label
    Friend WithEvents lbProDid As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbGrpID = New System.Windows.Forms.Label()
        Me.lbGradeID = New System.Windows.Forms.Label()
        Me.lbPaperID = New System.Windows.Forms.Label()
        Me.lbSizeID = New System.Windows.Forms.Label()
        Me.lbThID = New System.Windows.Forms.Label()
        Me.lbColorID = New System.Windows.Forms.Label()
        Me.lbTypeID = New System.Windows.Forms.Label()
        Me.lbGrp = New System.Windows.Forms.Label()
        Me.lbGrade = New System.Windows.Forms.Label()
        Me.lbPaper = New System.Windows.Forms.Label()
        Me.lbSize = New System.Windows.Forms.Label()
        Me.lbTh = New System.Windows.Forms.Label()
        Me.lbColor = New System.Windows.Forms.Label()
        Me.lbType = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboGrp = New System.Windows.Forms.ComboBox()
        Me.cboGrade = New System.Windows.Forms.ComboBox()
        Me.cmbGenCode = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPaper = New System.Windows.Forms.ComboBox()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.cboTh = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboColor = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lb02 = New System.Windows.Forms.Label()
        Me.lb01 = New System.Windows.Forms.Label()
        Me.txtStkName = New System.Windows.Forms.TextBox()
        Me.lbLenName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbStkDetl = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbCancel = New System.Windows.Forms.Button()
        Me.cmbDel = New System.Windows.Forms.Button()
        Me.cmbSave = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbStkCode2 = New System.Windows.Forms.Label()
        Me.lbWeight = New System.Windows.Forms.TextBox()
        Me.lbCutWeight = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbCutWeight2 = New System.Windows.Forms.Label()
        Me.lbWeight2 = New System.Windows.Forms.Label()
        Me.lbCount = New System.Windows.Forms.Label()
        Me.lbStkCode3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbProDid = New System.Windows.Forms.Label()
        Me.cboProdList = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.chkType0 = New System.Windows.Forms.RadioButton()
        Me.chkType2 = New System.Windows.Forms.RadioButton()
        Me.chkType1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.optVAT = New System.Windows.Forms.RadioButton()
        Me.optVatAll = New System.Windows.Forms.RadioButton()
        Me.optNVat = New System.Windows.Forms.RadioButton()
        Me.txtSemiFGName = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbFindWord = New System.Windows.Forms.TextBox()
        Me.txtStkName2 = New System.Windows.Forms.TextBox()
        Me.cboStore = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbFindStk = New System.Windows.Forms.Label()
        Me.dataShow = New System.Windows.Forms.DataGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtStkCodeN = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPcCode = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbStkCode = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.lbGrpID)
        Me.GroupBox2.Controls.Add(Me.lbGradeID)
        Me.GroupBox2.Controls.Add(Me.lbPaperID)
        Me.GroupBox2.Controls.Add(Me.lbSizeID)
        Me.GroupBox2.Controls.Add(Me.lbThID)
        Me.GroupBox2.Controls.Add(Me.lbColorID)
        Me.GroupBox2.Controls.Add(Me.lbTypeID)
        Me.GroupBox2.Controls.Add(Me.lbGrp)
        Me.GroupBox2.Controls.Add(Me.lbGrade)
        Me.GroupBox2.Controls.Add(Me.lbPaper)
        Me.GroupBox2.Controls.Add(Me.lbSize)
        Me.GroupBox2.Controls.Add(Me.lbTh)
        Me.GroupBox2.Controls.Add(Me.lbColor)
        Me.GroupBox2.Controls.Add(Me.lbType)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cboGrp)
        Me.GroupBox2.Controls.Add(Me.cboGrade)
        Me.GroupBox2.Controls.Add(Me.cmbGenCode)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cboPaper)
        Me.GroupBox2.Controls.Add(Me.cboSize)
        Me.GroupBox2.Controls.Add(Me.cboTh)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cboColor)
        Me.GroupBox2.Controls.Add(Me.cboType)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 435)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(1428, 119)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'lbGrpID
        '
        Me.lbGrpID.BackColor = System.Drawing.Color.Green
        Me.lbGrpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGrpID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbGrpID.ForeColor = System.Drawing.Color.White
        Me.lbGrpID.Location = New System.Drawing.Point(226, 75)
        Me.lbGrpID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGrpID.Name = "lbGrpID"
        Me.lbGrpID.Size = New System.Drawing.Size(138, 24)
        Me.lbGrpID.TabIndex = 59
        Me.lbGrpID.Text = "-"
        Me.lbGrpID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbGradeID
        '
        Me.lbGradeID.BackColor = System.Drawing.Color.Green
        Me.lbGradeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGradeID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbGradeID.ForeColor = System.Drawing.Color.White
        Me.lbGradeID.Location = New System.Drawing.Point(1117, 78)
        Me.lbGradeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGradeID.Name = "lbGradeID"
        Me.lbGradeID.Size = New System.Drawing.Size(67, 22)
        Me.lbGradeID.TabIndex = 58
        Me.lbGradeID.Text = "-"
        Me.lbGradeID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbPaperID
        '
        Me.lbPaperID.BackColor = System.Drawing.Color.Green
        Me.lbPaperID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPaperID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPaperID.ForeColor = System.Drawing.Color.White
        Me.lbPaperID.Location = New System.Drawing.Point(1008, 78)
        Me.lbPaperID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPaperID.Name = "lbPaperID"
        Me.lbPaperID.Size = New System.Drawing.Size(61, 22)
        Me.lbPaperID.TabIndex = 57
        Me.lbPaperID.Text = "-"
        Me.lbPaperID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbSizeID
        '
        Me.lbSizeID.BackColor = System.Drawing.Color.Green
        Me.lbSizeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSizeID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSizeID.ForeColor = System.Drawing.Color.White
        Me.lbSizeID.Location = New System.Drawing.Point(768, 76)
        Me.lbSizeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSizeID.Name = "lbSizeID"
        Me.lbSizeID.Size = New System.Drawing.Size(172, 22)
        Me.lbSizeID.TabIndex = 56
        Me.lbSizeID.Text = "-"
        Me.lbSizeID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbThID
        '
        Me.lbThID.BackColor = System.Drawing.Color.Green
        Me.lbThID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbThID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbThID.ForeColor = System.Drawing.Color.White
        Me.lbThID.Location = New System.Drawing.Point(638, 78)
        Me.lbThID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbThID.Name = "lbThID"
        Me.lbThID.Size = New System.Drawing.Size(74, 22)
        Me.lbThID.TabIndex = 55
        Me.lbThID.Text = "-"
        Me.lbThID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbColorID
        '
        Me.lbColorID.BackColor = System.Drawing.Color.Green
        Me.lbColorID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbColorID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbColorID.ForeColor = System.Drawing.Color.White
        Me.lbColorID.Location = New System.Drawing.Point(398, 76)
        Me.lbColorID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbColorID.Name = "lbColorID"
        Me.lbColorID.Size = New System.Drawing.Size(192, 22)
        Me.lbColorID.TabIndex = 53
        Me.lbColorID.Text = "-"
        Me.lbColorID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbTypeID
        '
        Me.lbTypeID.BackColor = System.Drawing.Color.Green
        Me.lbTypeID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTypeID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTypeID.ForeColor = System.Drawing.Color.White
        Me.lbTypeID.Location = New System.Drawing.Point(68, 78)
        Me.lbTypeID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTypeID.Name = "lbTypeID"
        Me.lbTypeID.Size = New System.Drawing.Size(117, 22)
        Me.lbTypeID.TabIndex = 54
        Me.lbTypeID.Text = "-"
        Me.lbTypeID.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbGrp
        '
        Me.lbGrp.BackColor = System.Drawing.Color.Black
        Me.lbGrp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGrp.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbGrp.ForeColor = System.Drawing.Color.Yellow
        Me.lbGrp.Location = New System.Drawing.Point(226, 52)
        Me.lbGrp.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGrp.Name = "lbGrp"
        Me.lbGrp.Size = New System.Drawing.Size(138, 20)
        Me.lbGrp.TabIndex = 52
        Me.lbGrp.Text = "-"
        Me.lbGrp.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbGrade
        '
        Me.lbGrade.BackColor = System.Drawing.Color.Black
        Me.lbGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbGrade.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbGrade.ForeColor = System.Drawing.Color.Yellow
        Me.lbGrade.Location = New System.Drawing.Point(1117, 55)
        Me.lbGrade.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbGrade.Name = "lbGrade"
        Me.lbGrade.Size = New System.Drawing.Size(67, 20)
        Me.lbGrade.TabIndex = 51
        Me.lbGrade.Text = "-"
        Me.lbGrade.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbPaper
        '
        Me.lbPaper.BackColor = System.Drawing.Color.Black
        Me.lbPaper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbPaper.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbPaper.ForeColor = System.Drawing.Color.Yellow
        Me.lbPaper.Location = New System.Drawing.Point(1008, 55)
        Me.lbPaper.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbPaper.Name = "lbPaper"
        Me.lbPaper.Size = New System.Drawing.Size(61, 20)
        Me.lbPaper.TabIndex = 50
        Me.lbPaper.Text = "-"
        Me.lbPaper.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbSize
        '
        Me.lbSize.BackColor = System.Drawing.Color.Black
        Me.lbSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbSize.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbSize.ForeColor = System.Drawing.Color.Yellow
        Me.lbSize.Location = New System.Drawing.Point(768, 55)
        Me.lbSize.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbSize.Name = "lbSize"
        Me.lbSize.Size = New System.Drawing.Size(172, 20)
        Me.lbSize.TabIndex = 49
        Me.lbSize.Text = "-"
        Me.lbSize.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbTh
        '
        Me.lbTh.BackColor = System.Drawing.Color.Black
        Me.lbTh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbTh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbTh.ForeColor = System.Drawing.Color.Yellow
        Me.lbTh.Location = New System.Drawing.Point(638, 55)
        Me.lbTh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbTh.Name = "lbTh"
        Me.lbTh.Size = New System.Drawing.Size(74, 20)
        Me.lbTh.TabIndex = 48
        Me.lbTh.Text = "-"
        Me.lbTh.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbColor
        '
        Me.lbColor.BackColor = System.Drawing.Color.Black
        Me.lbColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbColor.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbColor.ForeColor = System.Drawing.Color.Yellow
        Me.lbColor.Location = New System.Drawing.Point(398, 55)
        Me.lbColor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbColor.Name = "lbColor"
        Me.lbColor.Size = New System.Drawing.Size(192, 20)
        Me.lbColor.TabIndex = 46
        Me.lbColor.Text = "-"
        Me.lbColor.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbType
        '
        Me.lbType.BackColor = System.Drawing.Color.Black
        Me.lbType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbType.ForeColor = System.Drawing.Color.Yellow
        Me.lbType.Location = New System.Drawing.Point(68, 52)
        Me.lbType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbType.Name = "lbType"
        Me.lbType.Size = New System.Drawing.Size(117, 22)
        Me.lbType.TabIndex = 47
        Me.lbType.Text = "-"
        Me.lbType.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(191, 52)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 18)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "กลุ่ม"
        '
        'cboGrp
        '
        Me.cboGrp.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboGrp.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboGrp.ForeColor = System.Drawing.Color.White
        Me.cboGrp.Location = New System.Drawing.Point(187, 17)
        Me.cboGrp.Margin = New System.Windows.Forms.Padding(2)
        Me.cboGrp.Name = "cboGrp"
        Me.cboGrp.Size = New System.Drawing.Size(179, 31)
        Me.cboGrp.TabIndex = 44
        '
        'cboGrade
        '
        Me.cboGrade.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboGrade.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboGrade.ForeColor = System.Drawing.Color.White
        Me.cboGrade.Location = New System.Drawing.Point(1083, 17)
        Me.cboGrade.Margin = New System.Windows.Forms.Padding(2)
        Me.cboGrade.Name = "cboGrade"
        Me.cboGrade.Size = New System.Drawing.Size(102, 31)
        Me.cboGrade.TabIndex = 24
        '
        'cmbGenCode
        '
        Me.cmbGenCode.BackColor = System.Drawing.Color.Maroon
        Me.cmbGenCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbGenCode.ForeColor = System.Drawing.Color.White
        Me.cmbGenCode.Location = New System.Drawing.Point(1195, 17)
        Me.cmbGenCode.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbGenCode.Name = "cmbGenCode"
        Me.cmbGenCode.Size = New System.Drawing.Size(218, 83)
        Me.cmbGenCode.TabIndex = 31
        Me.cmbGenCode.Text = "Code"
        Me.cmbGenCode.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(1082, 56)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 19)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "เกรด"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(955, 55)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "กระดาษ"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(720, 55)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "ขนาด"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(594, 55)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 18)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "หนา"
        '
        'cboPaper
        '
        Me.cboPaper.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboPaper.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboPaper.ForeColor = System.Drawing.Color.White
        Me.cboPaper.Location = New System.Drawing.Point(945, 17)
        Me.cboPaper.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPaper.Name = "cboPaper"
        Me.cboPaper.Size = New System.Drawing.Size(126, 31)
        Me.cboPaper.TabIndex = 23
        '
        'cboSize
        '
        Me.cboSize.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboSize.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboSize.ForeColor = System.Drawing.Color.White
        Me.cboSize.Location = New System.Drawing.Point(721, 17)
        Me.cboSize.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(219, 31)
        Me.cboSize.TabIndex = 22
        '
        'cboTh
        '
        Me.cboTh.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboTh.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboTh.ForeColor = System.Drawing.Color.White
        Me.cboTh.Location = New System.Drawing.Point(599, 17)
        Me.cboTh.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTh.Name = "cboTh"
        Me.cboTh.Size = New System.Drawing.Size(115, 31)
        Me.cboTh.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(376, 55)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "สี"
        '
        'cboColor
        '
        Me.cboColor.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboColor.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboColor.ForeColor = System.Drawing.Color.White
        Me.cboColor.Location = New System.Drawing.Point(367, 17)
        Me.cboColor.Margin = New System.Windows.Forms.Padding(2)
        Me.cboColor.Name = "cboColor"
        Me.cboColor.Size = New System.Drawing.Size(226, 31)
        Me.cboColor.TabIndex = 18
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboType.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboType.ForeColor = System.Drawing.Color.White
        Me.cboType.Location = New System.Drawing.Point(12, 17)
        Me.cboType.Margin = New System.Windows.Forms.Padding(2)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(172, 31)
        Me.cboType.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(10, 58)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ประเภท"
        '
        'lb02
        '
        Me.lb02.BackColor = System.Drawing.Color.PowderBlue
        Me.lb02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb02.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb02.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lb02.Location = New System.Drawing.Point(199, 20)
        Me.lb02.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb02.Name = "lb02"
        Me.lb02.Size = New System.Drawing.Size(192, 33)
        Me.lb02.TabIndex = 40
        Me.lb02.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lb02.Visible = False
        '
        'lb01
        '
        Me.lb01.BackColor = System.Drawing.Color.PowderBlue
        Me.lb01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb01.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb01.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lb01.Location = New System.Drawing.Point(14, 21)
        Me.lb01.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lb01.Name = "lb01"
        Me.lb01.Size = New System.Drawing.Size(178, 33)
        Me.lb01.TabIndex = 33
        Me.lb01.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lb01.Visible = False
        '
        'txtStkName
        '
        Me.txtStkName.BackColor = System.Drawing.Color.Beige
        Me.txtStkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStkName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtStkName.ForeColor = System.Drawing.Color.Black
        Me.txtStkName.Location = New System.Drawing.Point(98, 20)
        Me.txtStkName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStkName.Name = "txtStkName"
        Me.txtStkName.Size = New System.Drawing.Size(657, 36)
        Me.txtStkName.TabIndex = 54
        '
        'lbLenName
        '
        Me.lbLenName.BackColor = System.Drawing.Color.OliveDrab
        Me.lbLenName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbLenName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbLenName.ForeColor = System.Drawing.Color.White
        Me.lbLenName.Location = New System.Drawing.Point(804, 21)
        Me.lbLenName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbLenName.Name = "lbLenName"
        Me.lbLenName.Size = New System.Drawing.Size(64, 34)
        Me.lbLenName.TabIndex = 34
        Me.lbLenName.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(1, 28)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 31)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "ชื่อเต็ม"
        '
        'cmbExit
        '
        Me.cmbExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbExit.Location = New System.Drawing.Point(1216, 22)
        Me.cmbExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbExit.Name = "cmbExit"
        Me.cmbExit.Size = New System.Drawing.Size(199, 52)
        Me.cmbExit.TabIndex = 32
        Me.cmbExit.Text = "Exit"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbStkDetl)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmbCancel)
        Me.GroupBox1.Controls.Add(Me.cmbDel)
        Me.GroupBox1.Controls.Add(Me.cmbSave)
        Me.GroupBox1.Controls.Add(Me.cmbExit)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 640)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(1422, 89)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'cmbStkDetl
        '
        Me.cmbStkDetl.Location = New System.Drawing.Point(554, 35)
        Me.cmbStkDetl.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbStkDetl.Name = "cmbStkDetl"
        Me.cmbStkDetl.Size = New System.Drawing.Size(130, 28)
        Me.cmbStkDetl.TabIndex = 5
        Me.cmbStkDetl.Text = "รายละเอียดสินค้า"
        Me.cmbStkDetl.Visible = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(406, 35)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "AutoGenCode"
        Me.Button1.Visible = False
        '
        'cmbCancel
        '
        Me.cmbCancel.Location = New System.Drawing.Point(694, 35)
        Me.cmbCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCancel.Name = "cmbCancel"
        Me.cmbCancel.Size = New System.Drawing.Size(100, 28)
        Me.cmbCancel.TabIndex = 2
        Me.cmbCancel.Text = "Cancel"
        Me.cmbCancel.Visible = False
        '
        'cmbDel
        '
        Me.cmbDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbDel.Location = New System.Drawing.Point(801, 22)
        Me.cmbDel.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbDel.Name = "cmbDel"
        Me.cmbDel.Size = New System.Drawing.Size(200, 52)
        Me.cmbDel.TabIndex = 1
        Me.cmbDel.Text = "DEL"
        '
        'cmbSave
        '
        Me.cmbSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cmbSave.Location = New System.Drawing.Point(1009, 22)
        Me.cmbSave.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbSave.Name = "cmbSave"
        Me.cmbSave.Size = New System.Drawing.Size(200, 52)
        Me.cmbSave.TabIndex = 0
        Me.cmbSave.Text = "SAVE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbStkCode2)
        Me.GroupBox3.Controls.Add(Me.lbWeight)
        Me.GroupBox3.Controls.Add(Me.lbCutWeight)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.lbCutWeight2)
        Me.GroupBox3.Controls.Add(Me.lbWeight2)
        Me.GroupBox3.Controls.Add(Me.lbCount)
        Me.GroupBox3.Controls.Add(Me.lbStkCode3)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lb01)
        Me.GroupBox3.Controls.Add(Me.lb02)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 558)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(1428, 78)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        '
        'lbStkCode2
        '
        Me.lbStkCode2.BackColor = System.Drawing.Color.Black
        Me.lbStkCode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkCode2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbStkCode2.Location = New System.Drawing.Point(193, 18)
        Me.lbStkCode2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbStkCode2.Name = "lbStkCode2"
        Me.lbStkCode2.Size = New System.Drawing.Size(661, 38)
        Me.lbStkCode2.TabIndex = 66
        Me.lbStkCode2.Text = "Label22"
        Me.lbStkCode2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbWeight
        '
        Me.lbWeight.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbWeight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWeight.Location = New System.Drawing.Point(964, 31)
        Me.lbWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.lbWeight.Name = "lbWeight"
        Me.lbWeight.Size = New System.Drawing.Size(91, 32)
        Me.lbWeight.TabIndex = 65
        Me.lbWeight.Text = "0"
        Me.lbWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbCutWeight
        '
        Me.lbCutWeight.BackColor = System.Drawing.Color.DodgerBlue
        Me.lbCutWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCutWeight.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCutWeight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lbCutWeight.Location = New System.Drawing.Point(1232, 31)
        Me.lbCutWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.lbCutWeight.Name = "lbCutWeight"
        Me.lbCutWeight.Size = New System.Drawing.Size(76, 32)
        Me.lbCutWeight.TabIndex = 64
        Me.lbCutWeight.Text = "0"
        Me.lbCutWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(1314, 38)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 19)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Kg./แผ่น"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(1170, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "น้ำหนักตัด"
        '
        'lbCutWeight2
        '
        Me.lbCutWeight2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbCutWeight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCutWeight2.Location = New System.Drawing.Point(632, 20)
        Me.lbCutWeight2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCutWeight2.Name = "lbCutWeight2"
        Me.lbCutWeight2.Size = New System.Drawing.Size(91, 34)
        Me.lbCutWeight2.TabIndex = 61
        Me.lbCutWeight2.Visible = False
        '
        'lbWeight2
        '
        Me.lbWeight2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbWeight2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbWeight2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbWeight2.Location = New System.Drawing.Point(455, 20)
        Me.lbWeight2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbWeight2.Name = "lbWeight2"
        Me.lbWeight2.Size = New System.Drawing.Size(91, 33)
        Me.lbWeight2.TabIndex = 62
        Me.lbWeight2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbWeight2.Visible = False
        '
        'lbCount
        '
        Me.lbCount.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lbCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbCount.Location = New System.Drawing.Point(398, 20)
        Me.lbCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbCount.Name = "lbCount"
        Me.lbCount.Size = New System.Drawing.Size(51, 34)
        Me.lbCount.TabIndex = 63
        Me.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbCount.Visible = False
        '
        'lbStkCode3
        '
        Me.lbStkCode3.BackColor = System.Drawing.Color.Yellow
        Me.lbStkCode3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkCode3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkCode3.ForeColor = System.Drawing.Color.Blue
        Me.lbStkCode3.Location = New System.Drawing.Point(552, 20)
        Me.lbStkCode3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbStkCode3.Name = "lbStkCode3"
        Me.lbStkCode3.Size = New System.Drawing.Size(73, 34)
        Me.lbStkCode3.TabIndex = 60
        Me.lbStkCode3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lbStkCode3.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(900, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "น้ำหนักเท"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(1059, 37)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 20)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Kg./แผ่น"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbProDid)
        Me.GroupBox6.Controls.Add(Me.cboProdList)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Location = New System.Drawing.Point(11, 379)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox6.Size = New System.Drawing.Size(906, 55)
        Me.GroupBox6.TabIndex = 124
        Me.GroupBox6.TabStop = False
        '
        'lbProDid
        '
        Me.lbProDid.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbProDid.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbProDid.ForeColor = System.Drawing.Color.White
        Me.lbProDid.Location = New System.Drawing.Point(375, 17)
        Me.lbProDid.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbProDid.Name = "lbProDid"
        Me.lbProDid.Size = New System.Drawing.Size(132, 29)
        Me.lbProDid.TabIndex = 72
        '
        'cboProdList
        '
        Me.cboProdList.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.cboProdList.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboProdList.ForeColor = System.Drawing.Color.White
        Me.cboProdList.FormattingEnabled = True
        Me.cboProdList.Location = New System.Drawing.Point(87, 13)
        Me.cboProdList.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProdList.Name = "cboProdList"
        Me.cboProdList.Size = New System.Drawing.Size(283, 37)
        Me.cboProdList.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(11, 20)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 22)
        Me.Label18.TabIndex = 71
        Me.Label18.Text = "กลุ่มหลัก"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cboStore)
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.GroupBox5)
        Me.GroupBox7.Controls.Add(Me.txtSemiFGName)
        Me.GroupBox7.Controls.Add(Me.lbLenName)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.lbFindWord)
        Me.GroupBox7.Controls.Add(Me.txtStkName2)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.lbFindStk)
        Me.GroupBox7.Controls.Add(Me.txtStkName)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 181)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox7.Size = New System.Drawing.Size(1428, 200)
        Me.GroupBox7.TabIndex = 125
        Me.GroupBox7.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.chkType0)
        Me.GroupBox8.Controls.Add(Me.chkType2)
        Me.GroupBox8.Controls.Add(Me.chkType1)
        Me.GroupBox8.Location = New System.Drawing.Point(974, 68)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox8.Size = New System.Drawing.Size(220, 108)
        Me.GroupBox8.TabIndex = 74
        Me.GroupBox8.TabStop = False
        '
        'chkType0
        '
        Me.chkType0.AutoSize = True
        Me.chkType0.Checked = True
        Me.chkType0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkType0.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkType0.Location = New System.Drawing.Point(21, 20)
        Me.chkType0.Margin = New System.Windows.Forms.Padding(2)
        Me.chkType0.Name = "chkType0"
        Me.chkType0.Size = New System.Drawing.Size(184, 24)
        Me.chkType0.TabIndex = 70
        Me.chkType0.TabStop = True
        Me.chkType0.Text = "คิดต้นทุนเป็น น้ำหนัก 0"
        Me.chkType0.UseVisualStyleBackColor = True
        '
        'chkType2
        '
        Me.chkType2.AutoSize = True
        Me.chkType2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkType2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkType2.Location = New System.Drawing.Point(21, 75)
        Me.chkType2.Margin = New System.Windows.Forms.Padding(2)
        Me.chkType2.Name = "chkType2"
        Me.chkType2.Size = New System.Drawing.Size(111, 24)
        Me.chkType2.TabIndex = 72
        Me.chkType2.Text = "2  ยังไม่ระบุ"
        Me.chkType2.UseVisualStyleBackColor = True
        '
        'chkType1
        '
        Me.chkType1.AutoSize = True
        Me.chkType1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.chkType1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkType1.Location = New System.Drawing.Point(21, 48)
        Me.chkType1.Margin = New System.Windows.Forms.Padding(2)
        Me.chkType1.Name = "chkType1"
        Me.chkType1.Size = New System.Drawing.Size(178, 24)
        Me.chkType1.TabIndex = 71
        Me.chkType1.Text = "คิดต้นทุนเป็น หน่วย  1"
        Me.chkType1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.optVAT)
        Me.GroupBox5.Controls.Add(Me.optVatAll)
        Me.GroupBox5.Controls.Add(Me.optNVat)
        Me.GroupBox5.Location = New System.Drawing.Point(759, 68)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(211, 108)
        Me.GroupBox5.TabIndex = 73
        Me.GroupBox5.TabStop = False
        '
        'optVAT
        '
        Me.optVAT.AutoSize = True
        Me.optVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optVAT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optVAT.Location = New System.Drawing.Point(21, 20)
        Me.optVAT.Margin = New System.Windows.Forms.Padding(2)
        Me.optVAT.Name = "optVAT"
        Me.optVAT.Size = New System.Drawing.Size(160, 24)
        Me.optVAT.TabIndex = 70
        Me.optVAT.TabStop = True
        Me.optVAT.Text = "ขายได้เฉพาะ V (3)"
        Me.optVAT.UseVisualStyleBackColor = True
        '
        'optVatAll
        '
        Me.optVatAll.AutoSize = True
        Me.optVatAll.Checked = True
        Me.optVatAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optVatAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optVatAll.Location = New System.Drawing.Point(21, 75)
        Me.optVatAll.Margin = New System.Windows.Forms.Padding(2)
        Me.optVatAll.Name = "optVatAll"
        Me.optVatAll.Size = New System.Drawing.Size(177, 24)
        Me.optVatAll.TabIndex = 72
        Me.optVatAll.TabStop = True
        Me.optVatAll.Text = "ขายได้ทั้ง V ทั้ง N (1)"
        Me.optVatAll.UseVisualStyleBackColor = True
        '
        'optNVat
        '
        Me.optNVat.AutoSize = True
        Me.optNVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.optNVat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.optNVat.Location = New System.Drawing.Point(21, 48)
        Me.optNVat.Margin = New System.Windows.Forms.Padding(2)
        Me.optNVat.Name = "optNVat"
        Me.optNVat.Size = New System.Drawing.Size(161, 24)
        Me.optNVat.TabIndex = 71
        Me.optNVat.TabStop = True
        Me.optNVat.Text = "ขายได้เฉพาะ N (2)"
        Me.optNVat.UseVisualStyleBackColor = True
        '
        'txtSemiFGName
        '
        Me.txtSemiFGName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSemiFGName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSemiFGName.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSemiFGName.ForeColor = System.Drawing.Color.Black
        Me.txtSemiFGName.Location = New System.Drawing.Point(98, 146)
        Me.txtSemiFGName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSemiFGName.Name = "txtSemiFGName"
        Me.txtSemiFGName.Size = New System.Drawing.Size(657, 36)
        Me.txtSemiFGName.TabIndex = 59
        '
        'Label14
        '
        Me.Label14.Enabled = False
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(1205, 154)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 19)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "เลือกคลัง"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(872, 27)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(95, 22)
        Me.Label21.TabIndex = 69
        Me.Label21.Text = "ความยาวชื่อ"
        '
        'lbFindWord
        '
        Me.lbFindWord.BackColor = System.Drawing.Color.Green
        Me.lbFindWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindWord.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindWord.ForeColor = System.Drawing.SystemColors.Info
        Me.lbFindWord.Location = New System.Drawing.Point(98, 100)
        Me.lbFindWord.Margin = New System.Windows.Forms.Padding(2)
        Me.lbFindWord.Name = "lbFindWord"
        Me.lbFindWord.Size = New System.Drawing.Size(657, 36)
        Me.lbFindWord.TabIndex = 68
        '
        'txtStkName2
        '
        Me.txtStkName2.BackColor = System.Drawing.Color.Black
        Me.txtStkName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStkName2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtStkName2.ForeColor = System.Drawing.Color.Yellow
        Me.txtStkName2.Location = New System.Drawing.Point(98, 64)
        Me.txtStkName2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStkName2.Name = "txtStkName2"
        Me.txtStkName2.Size = New System.Drawing.Size(657, 32)
        Me.txtStkName2.TabIndex = 61
        '
        'cboStore
        '
        Me.cboStore.BackColor = System.Drawing.Color.LimeGreen
        Me.cboStore.Enabled = False
        Me.cboStore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cboStore.Location = New System.Drawing.Point(1258, 145)
        Me.cboStore.Margin = New System.Windows.Forms.Padding(2)
        Me.cboStore.Name = "cboStore"
        Me.cboStore.Size = New System.Drawing.Size(162, 33)
        Me.cboStore.TabIndex = 52
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(4, 115)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(95, 22)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "ชื่อค้นหา"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(4, 158)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 22)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "PC-Name"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Maroon
        Me.Label19.Location = New System.Drawing.Point(-2, 72)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 31)
        Me.Label19.TabIndex = 58
        Me.Label19.Text = "ShotName"
        '
        'lbFindStk
        '
        Me.lbFindStk.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbFindStk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFindStk.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbFindStk.ForeColor = System.Drawing.Color.White
        Me.lbFindStk.Location = New System.Drawing.Point(758, 21)
        Me.lbFindStk.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbFindStk.Name = "lbFindStk"
        Me.lbFindStk.Size = New System.Drawing.Size(43, 34)
        Me.lbFindStk.TabIndex = 57
        Me.lbFindStk.Text = "..."
        Me.lbFindStk.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'dataShow
        '
        Me.dataShow.CaptionBackColor = System.Drawing.Color.SlateGray
        Me.dataShow.DataMember = ""
        Me.dataShow.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dataShow.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dataShow.Location = New System.Drawing.Point(630, 2)
        Me.dataShow.Margin = New System.Windows.Forms.Padding(2)
        Me.dataShow.Name = "dataShow"
        Me.dataShow.ReadOnly = True
        Me.dataShow.Size = New System.Drawing.Size(808, 175)
        Me.dataShow.TabIndex = 54
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtStkCodeN)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtPcCode)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.lbStkCode)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(11, 8)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(615, 170)
        Me.GroupBox4.TabIndex = 126
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "iD_StockMaster"
        '
        'txtStkCodeN
        '
        Me.txtStkCodeN.BackColor = System.Drawing.Color.Black
        Me.txtStkCodeN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStkCodeN.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtStkCodeN.ForeColor = System.Drawing.Color.Yellow
        Me.txtStkCodeN.Location = New System.Drawing.Point(78, 100)
        Me.txtStkCodeN.Margin = New System.Windows.Forms.Padding(2)
        Me.txtStkCodeN.Name = "txtStkCodeN"
        Me.txtStkCodeN.Size = New System.Drawing.Size(520, 32)
        Me.txtStkCodeN.TabIndex = 59
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(9, 115)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 22)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "รหัส FG-N"
        '
        'txtPcCode
        '
        Me.txtPcCode.BackColor = System.Drawing.Color.Black
        Me.txtPcCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPcCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtPcCode.ForeColor = System.Drawing.Color.Yellow
        Me.txtPcCode.Location = New System.Drawing.Point(78, 61)
        Me.txtPcCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPcCode.Name = "txtPcCode"
        Me.txtPcCode.Size = New System.Drawing.Size(520, 32)
        Me.txtPcCode.TabIndex = 57
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(16, 75)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 22)
        Me.Label15.TabIndex = 58
        Me.Label15.Text = "รหัส GP"
        '
        'lbStkCode
        '
        Me.lbStkCode.BackColor = System.Drawing.Color.Black
        Me.lbStkCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbStkCode.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lbStkCode.ForeColor = System.Drawing.Color.Yellow
        Me.lbStkCode.Location = New System.Drawing.Point(78, 22)
        Me.lbStkCode.Margin = New System.Windows.Forms.Padding(2)
        Me.lbStkCode.Name = "lbStkCode"
        Me.lbStkCode.Size = New System.Drawing.Size(520, 32)
        Me.lbStkCode.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(16, 35)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 22)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "รหัส FG"
        '
        'frmGenCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1471, 736)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.dataShow)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmGenCode"
        Me.Text = "โปรแกรมสร้างรหัสสินค้า 18-08-57"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dataShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim ChkColor As Boolean = False
    Dim chkGrp As Boolean = False
    Dim chkProdList As Boolean = False
    Dim chkBaseList As Boolean = False

    Dim subDs As DataSet = New DataSet()
    Dim subDa1 As SqlClient.SqlDataAdapter


    'Dim subDs As DataSet = New DataSet
    'Dim subDa1 As SqlClient.SqlDataAdapter

    Sub txtCLS()

        lbStkCode.Text = ""
        txtPcCode.Text = ""
        txtStkCodeN.Text = ""

        txtStkName2.Text = ""
        txtStkName.Text = ""
        lbFindWord.Text = ""
        txtSemiFGName.Text = ""

        lb01.Text = 0
        lb02.Text = 0
        lbWeight.Text = 1
        lbWeight2.Text = 1

    End Sub

    Function getFindWord()

        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim Ans As String = ""
        'Dim Count01 As Integer

        txtSQL = "Select  *  "
        txtSQL &= "From SizeMast "
        txtSQL &= "Where Size_Code='" & cboSize.SelectedValue & "' "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "SizeMast")



        txtSQL = "Select  *  From thMast "
        txtSQL &= "Where th_Code='" & cboTh.SelectedValue & "' "
        subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa1.Fill(subDS, "ThMast")

        txtSQL = "Select  *  From BaseMast "
        txtSQL &= "Where Stk_Code='" & lbStkCode.Text & "' "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "chkBaseMast")

        Ans = subDS.Tables("ThMast").Rows(0).Item("Th_Th").ToString + "*" + subDS.Tables("SizeMast").Rows(0).Item("Size_Width").ToString + "*" + subDS.Tables("SizeMast").Rows(0).Item("Size_Height").ToString
        Return Ans

    End Function

    Sub genCode()

        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        Dim Count01 As Integer


        Dim prod4Cbo As String = cboProdList.SelectedValue
        Dim type4Cbo As String = cboType.SelectedValue
        Dim grp4Cbo As String = cboGrp.SelectedValue
        Dim color4Cbo As String = cboColor.SelectedValue
        Dim size4Cbo As String = cboSize.SelectedValue
        Dim Th4Cbo As String = cboTh.SelectedValue


        ' สร้างรหัสสินค้าจาก cbo ต่างๆ ก่อน แล้วคอยนำไปหาสินค้าว่ามีสร้างไว้แล้วหรือยัง 
        Dim stkCode As String
        stkCode = cboType.SelectedValue & cboGrp.SelectedValue &
        cboColor.SelectedValue & cboTh.SelectedValue & cboSize.SelectedValue & cboPaper.SelectedValue & cboGrade.SelectedValue

        '=====================================
        lbStkCode.Text = stkCode

        Dim strCode2 As String
        ' Dim strCode As String = ""
        Dim strProD_id As String = "--"
        Dim strType_id As String = "--"
        Dim strGrp_id As String = "--"
        Dim strColor_id As String = "-----"
        Dim strTh_id As String = "----"
        Dim strSize_id As String = "--------"
        Dim strPaper_id As String = "--"
        Dim strGrade_id As String = "-"

        strType_id = lbTypeID.Text
        strGrp_id = lbGrpID.Text
        strTh_id = lbThID.Text
        strColor_id = lbColorID.Text
        strSize_id = lbSizeID.Text
        strPaper_id = lbPaperID.Text
        strGrade_id = lbGradeID.Text
        strCode2 = strType_id & strGrp_id & strTh_id & strColor_id & strSize_id & strPaper_id & strGrade_id
        lbStkCode2.Text = strCode2

        'txtSQL = "Select  *  From thMast "
        'txtSQL &= "Where th_Code='" & cboTh.SelectedValue & "' "
        'subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'subDa1.Fill(subDS, "ThMast")

        ' lbBOMCT.Text = cboColor.SelectedValue & cboSColor.SelectedValue & cboTh.SelectedValue

        ' ===================  ตรวจสอบรหัสสินค้าว่ามีการสร้างมาหรือยัง ====================================

        'Dim chkCode As Boolean


        txtSQL = "Select  *  From BaseMast "
        txtSQL &= "Where Stk_Code='" & stkCode & "' "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "chkBaseMast")


        txtSQL = "Select  *  "
        txtSQL &= "From SizeMast "
        txtSQL &= "Where Size_Code='" & cboSize.SelectedValue & "' "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "SizeMast")

        lb01.Text = (subDS.Tables("SizeMast").Rows(0).Item("Size_Width"))

        txtSQL = "Select  *  From thMast "
        txtSQL &= "Where th_Code='" & cboTh.SelectedValue & "' "
        subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa1.Fill(subDS, "ThMast")
        lb01.Text = (subDS.Tables("SizeMast").Rows(0).Item("Size_Width"))


        Dim dblTh As Double
        Dim dblSize As Double
        dblTh = subDS.Tables("ThMast").Rows(0).Item("Th_Th")
        dblSize = subDS.Tables("SizeMast").Rows(0).Item("Size_Width") * subDS.Tables("SizeMast").Rows(0).Item("Size_Height")

        lbCutWeight.Text = calCutWeight(subDS.Tables("ThMast").Rows(0).Item("Th_Th"), subDS.Tables("SizeMast").Rows(0).Item("Size_Width"), subDS.Tables("SizeMast").Rows(0).Item("Size_Height"), getSG(cboType.SelectedValue)).ToString("#,###,###.####")
        lbWeight.Text = lbCutWeight.Text

        '====================================================================================
        If subDS.Tables("chkBaseMast").Rows.Count > 0 Then

            MsgBox("รหัส '" & lbStkCode.Text & txtStkName.Text & "' มีข้อมูลสินค้านี้อยู่แล้ว โปรดตรวจสอบอีกครั้ง", MsgBoxStyle.Critical, "แจ้งเตือน!")
            Call showDataDetail(stkCode)

            'lbCount.Text = Count01



            'txtStkName.Text = subDS.Tables("chkBaseMast").Rows(0).Item("Stk_Name_1")
            'If IsDBNull(subDS.Tables("chkBaseMast").Rows(0).Item("Stk_Name_2")) Then

            'Else

            'End If


            'If IsDBNull(subDS.Tables("chkBaseMast").Rows(0).Item("Stk_Code_PC")) Or Trim(subDS.Tables("chkBaseMast").Rows(0).Item("Stk_Code_PC").ToString) = "" Then

            'Else
            '    txtPcCode.Text = Trim(subDS.Tables("chkBaseMast").Rows(0).Item("Stk_Code_PC"))
            'End If

            'If IsDBNull(subDS.Tables("chkBaseMast").Rows(0).Item("Stk_Code_N")) Or Trim(subDS.Tables("chkBaseMast").Rows(0).Item("Stk_Code_N").ToString) = "" Then

            'Else
            '    txtStkCodeN.Text = Trim(subDS.Tables("chkBaseMast").Rows(0).Item("Stk_Code_N"))
            'End If

            'lbStkCode.Text = subDS.Tables("chkBaseMast").Rows(0).Item("Stk_Code")
            'lbLenName.Text = (Len(txtStkName.Text))

            'lbCutWeight.Text = calCutWeight(subDS.Tables("ThMast").Rows(0).Item("Th_Th"), subDS.Tables("SizeMast").Rows(0).Item("Size_Width"), subDS.Tables("SizeMast").Rows(0).Item("Size_Height"), getSG(cboType.SelectedValue)).ToString("#,###,###.####")

            'If cboGrp.SelectedValue = "05" And cboProdList.SelectedValue = "04" Then
            '    lbWeight.Text = 1

            'ElseIf cboType.SelectedValue = "04" And cboProdList.SelectedValue = "05" Then

            '    lbWeight.Text = 1

            'ElseIf cboProdList.SelectedValue = "01" Then

            '    lbCutWeight.Text = dbTools.getStkWight(lbStkCode.Text)
            '    lbWeight.Text = dbTools.getStkWight(lbStkCode.Text)

            'ElseIf cboProdList.SelectedValue = "05" Then
            '    lbCutWeight.Text = dbTools.getStkWight(lbStkCode.Text)
            '    lbWeight.Text = dbTools.getStkWight(lbStkCode.Text)
            'Else

            '    If subDS.Tables("SizeMast").Rows.Count > 0 Then

            '    Else

            '        If IsNumeric(subDS.Tables("SizeMast").Rows(0).Item("Size_width")) = True Then

            '            lbCutWeight.Text = calCutWeight(subDS.Tables("ThMast").Rows(0).Item("Th_Th"), subDS.Tables("SizeMast").Rows(0).Item("Size_Width"), subDS.Tables("SizeMast").Rows(0).Item("Size_Height"), getSG(cboType.SelectedValue)).ToString("#,###,###.####")

            '        End If
            '    End If
            'End If
            'lbWeight.Text = lbCutWeight.Text
            'lbFindWord.Text = getFindWord()
            'showData(lbStkCode.Text)

            ''==========================================
            ''lbStkCode.Text = SelectCode
            '
            ''==========================================


        Else



            Call genNameStk()

            '===================================================================
            txtPcCode.Text = cboType.SelectedValue & cboGrp.SelectedValue & cboColor.SelectedValue & cboTh.SelectedValue
            '===================================================================

            txtStkCodeN.Text = cboType.SelectedValue & cboGrp.SelectedValue & cboColor.SelectedValue & cboTh.SelectedValue &
        cboSize.SelectedValue & cboPaper.SelectedValue & cboGrade.SelectedValue
            '===================================================================


            Count01 = genCode2(cboType.SelectedValue, cboGrp.SelectedValue, cboSize.SelectedValue)

            lbCount.Text = Count01
            lbLenName.Text = (Len(txtStkName.Text))

            txtSemiFGName.Text = genNamePC()
            lbFindWord.Text = getFindWord()

            'lbStkName.Text = genNameStk()


            If cboGrp.SelectedValue = "05" Then
                lbCutWeight.Text = 1
                lbWeight.Text = 1

            ElseIf cboType.SelectedValue = "04" Then
                lbCutWeight.Text = 1
                lbWeight.Text = 1
            Else

                If IsNumeric(subDS.Tables("SizeMast").Rows(0).Item("Size_width")) = True Then


                    lbCutWeight.Text = calCutWeight(subDS.Tables("ThMast").Rows(0).Item("Th_Th"), subDS.Tables("SizeMast").Rows(0).Item("Size_Width"), subDS.Tables("SizeMast").Rows(0).Item("Size_Height"), getSG(cboType.SelectedValue)).ToString("#,###,###.####")
                End If
            End If


            'txtSQL = "Select  *  From bomMastD  "
            'txtSQL &= "Where rm_Code='04001' "
            'txtSQL &= ""
            'subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            'subDA.Fill(subDS, "BOMMastD")
            lbWeight.Text = lbCutWeight.Text
            lbFindWord.Text = getFindWord()

        End If

        '===========================================================================

    End Sub

    Sub genCodePC()

        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        'Dim Count01 As Integer



        txtPcCode.Text = cboType.SelectedValue & cboGrp.SelectedValue & cboColor.SelectedValue & cboTh.SelectedValue

        txtStkCodeN.Text = cboType.SelectedValue & cboGrp.SelectedValue & cboColor.SelectedValue & cboTh.SelectedValue & cboSize.SelectedValue &
        cboPaper.SelectedValue & cboGrade.SelectedValue

        ' ===================  ตรวจสอบรหัสสินค้าว่ามีการสร้างมาหรือยัง ====================================

        'Dim chkCode As Boolean

        txtSQL = "Select  *  From BaseMast "
        txtSQL &= "Where Stk_Code='" & lbStkCode.Text & "' "
        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDS.Tables("chkBaseMast").Clear()
        subDA.Fill(subDS, "chkBaseMast")

        '====================================================================================
        If subDS.Tables("chkBaseMast").Rows.Count > 0 Then

            MsgBox("รหัส '" & lbStkCode.Text & txtStkName.Text & "' มีข้อมูลสินค้านี้อยู่แล้ว โปรดตรวจสอบอีกครั้ง")
            'lbCount.Text = Count01
            'txtStkName.Text = subDS.Tables("chkBaseMast").Rows(0).Item("Stk_Name_2")
            'lbLenName.Text = (Len(txtStkName.Text))

            'If cboGrp.SelectedValue = "05" Then
            '    lbCutWeight.Text = 1
            '    lbWeight.Text = 1
            'ElseIf cboType.SelectedValue = "04" Then
            '    lbCutWeight.Text = 1
            '    lbWeight.Text = 1
            'Else
            '    If subDS.Tables("SizeMast").Rows.Count > 0 Then
            '    Else
            '        If IsNumeric(subDS.Tables("SizeMast").Rows(0).Item("Size_width")) = True Then
            '            lbCutWeight.Text = calCutWeight(subDS.Tables("ThMast").Rows(0).Item("Th_Th"), subDS.Tables("SizeMast").Rows(0).Item("Size_Width"), subDS.Tables("SizeMast").Rows(0).Item("Size_Height"), getSG(cboType.SelectedValue)).ToString("#,###,###.####")
            '        End If
            '    End If
            'End If
            'lbWeight.Text = lbCutWeight.Text

        Else


            'Count01 = genCode2(cboType.SelectedValue, cboGrp.SelectedValue, cboSize.SelectedValue)

            'lbCount.Text = Count01
            'lbLenName.Text = (Len(txtStkName.Text))

            'txtSQL = "Select  *  "
            'txtSQL &= "From SizeMast "
            'txtSQL &= "Where Size_Code='" & cboSize.SelectedValue & "' "
            'subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            'subDA.Fill(subDS, "SizeMast")

            'lb01.Text = (subDS.Tables("SizeMast").Rows(0).Item("Size_Width"))

            'txtSQL = "Select  *  From thMast "
            'txtSQL &= "Where th_Code='" & cboTh.SelectedValue & "' "
            'subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            'subDa1.Fill(subDS, "ThMast")
            'lb01.Text = (subDS.Tables("SizeMast").Rows(0).Item("Size_Width"))

            'If cboGrp.SelectedValue = "05" Then
            '    lbCutWeight.Text = 1
            '    lbWeight.Text = 1
            'ElseIf cboType.SelectedValue = "04" Then
            '    lbCutWeight.Text = 1
            '    lbWeight.Text = 1
            'Else

            '    If IsNumeric(subDS.Tables("SizeMast").Rows(0).Item("Size_width")) = True Then
            '        lbCutWeight.Text = calCutWeight(subDS.Tables("ThMast").Rows(0).Item("Th_Th"), subDS.Tables("SizeMast").Rows(0).Item("Size_Width"), subDS.Tables("SizeMast").Rows(0).Item("Size_Height"), getSG(cboType.SelectedValue)).ToString("#,###,###.####")
            '    End If
            'End If


            'txtSQL = "Select  *  From bomMastD  "
            'txtSQL &= "Where rm_Code='04001' "
            'txtSQL &= ""
            'subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            'subDA.Fill(subDS, "BOMMastD")
            'lbWeight.Text = lbCutWeight.Text

        End If

        '===========================================================================
        'Call FormatGrd()
    End Sub

    Sub showData(ByVal stkCode As String)

        Try
            If dbTools.chkStkDetl(stkCode) = True Then
                txtSQL = "Select dtl_Store,Ar_Name,type_Code,Stk_Code,Stk_Name_1,"
                txtSQL &= "Stk_Factor,Dtl_Bal_Q1,Dtl_wh  "

                txtSQL &= "From  BaseMast "
                txtSQL &= "Left Join StkDetl "
                txtSQL &= "On Stk_Code=dtl_Code "
                txtSQL &= "Left Join ArFile "
                txtSQL &= "On Dtl_Store=ArFile.Ar_Cus_id "

                txtSQL &= "Where len(Stk_Name_1) > 0 "
                txtSQL &= "And Stk_Code='" & stkCode & "'"


                txtSQL &= "Order by Stk_Code,Dtl_Wh "


            Else
                txtSQL = "Select dtl_Store,Ar_Name,type_Code,Stk_Code,Stk_Name_1,"
                txtSQL &= "Stk_Factor,Dtl_Bal_Q1,Dtl_wh  "

                txtSQL &= "From  BaseMast "
                txtSQL &= "Left Join StkDetl "
                txtSQL &= "On Stk_Code=dtl_Code "
                txtSQL &= "Left Join ArFile "
                txtSQL &= "On Dtl_Store=ArFile.Ar_Cus_id "

                txtSQL &= "Where len(Stk_Name_1) > 0 "

                txtSQL &= "And Stk_Prod='" & lbProDid.Text & "' "
                txtSQL &= "And Type_code='" & lbTypeID.Text & "' "
                'txtSQL &= "And Type_code='" & lbTypeID.Text & "' "

                If cboColor.Text = "" Then

                Else
                    txtSQL &= "And Color_Code='" & cboColor.SelectedValue & "' "
                End If

                If cboTh.Text = "" Then

                Else
                    txtSQL &= "And Th_Code='" & cboTh.SelectedValue & "' "
                End If

                If cboSize.Text = "" Then



                Else

                    txtSQL &= "And Size_Code='" & cboSize.SelectedValue & "' "
                End If
                txtSQL &= "Order by Stk_Code,Dtl_Wh "

            End If



            subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkBaseList = True Then
                subDs.Tables("chkBaseMast").Clear()
                chkBaseList = False
            End If

            subDa1.Fill(subDs, "chkBaseMast")
            chkBaseList = True

            With dataShow
                .DataSource = subDs.Tables("chkBaseMast")
                .Refresh()
            End With

            FormatGrd()

        Catch ex As Exception


        End Try


    End Sub

    Sub FormatGrd()

        Dim grdTS As DataGridTableStyle = New DataGridTableStyle

        Dim stkCode As New DataGridTextBoxColumn
        Dim stkName As New DataGridTextBoxColumn
        Dim stkFactor As New DataGridTextBoxColumn
        Dim stkQ1 As New DataGridTextBoxColumn
        Dim stk_WH As New DataGridTextBoxColumn
        Dim stk_Str As New DataGridTextBoxColumn
        Dim Str_Name As New DataGridTextBoxColumn


        With grdTS
            .AlternatingBackColor = Color.LemonChiffon
            .BackColor = Color.White
            .MappingName = "chkBaseMast"  'กำหนดให้ DatagridTalbleStyle ใช้กับ Table ใด

        End With

        With stkCode
            .HeaderText = "รหัสสินค้า"
            .MappingName = "Stk_Code"
            .Alignment = HorizontalAlignment.Center
            '.ReadOnly = True
            .Width = 1
        End With

        With stk_WH
            .HeaderText = "คลังสินค้า"
            .MappingName = "dtl_wh"
            '.ReadOnly = True
            .Width = 1
        End With
        With stk_Str
            .HeaderText = "ชือคลังย่อย"
            .MappingName = "dtl_Store"
            '.ReadOnly = True
            .Width = 1
        End With
        With Str_Name
            .HeaderText = "คลัง"
            .MappingName = "Ar_Name"
            '.ReadOnly = True
            .Width = 1
        End With

        With stkName
            .HeaderText = "ชื่อสินค้า"
            .MappingName = "Stk_Name_1"
            '.ReadOnly = True
            .Width = 350
        End With

        With stkFactor
            .HeaderText = "น้ำหนัก"
            .MappingName = "Stk_Factor"
            .Alignment = HorizontalAlignment.Right
            .Format = "#,##0"
            '.ReadOnly = True
            .Width = 100
        End With

        With stkQ1
            .HeaderText = "Stock"
            .MappingName = "dtl_Bal_Q1"
            '.ReadOnly = True
            .Width = 80
        End With

        grdTS.GridColumnStyles.Add(stkName)
        grdTS.GridColumnStyles.Add(stkFactor)
        grdTS.GridColumnStyles.Add(stkQ1)
        grdTS.GridColumnStyles.Add(stk_WH)
        grdTS.GridColumnStyles.Add(stk_Str)
        grdTS.GridColumnStyles.Add(Str_Name)
        grdTS.GridColumnStyles.Add(stkCode)


        With dataShow

            .TableStyles.Clear()
            .CaptionText = "ข้อมูลรายละเอียดสินค้า"
            .FlatMode = True
            .TableStyles.Add(grdTS)
            '.Controls.Clear()

        End With


    End Sub


    Function genCode2(ByVal StkType As String, ByVal StkGrp As String, ByVal StkSize As String) As Integer
        'Dim subDs As DataSet = New DataSet
        'Dim subDa As SqlClient.SqlDataAdapter

        'Dim i As Integer
        Dim Count01 As Integer
        'Dim S01 As String
        'Dim S02 As String

        txtSQL = "Select   max(stk_Run)as max  "
        txtSQL &= "From  BaseMast "
        txtSQL &= "Where ( Type_Code='" & StkType & "' ) "
        txtSQL &= "And  (Grp_Code='" & StkGrp & "' ) "
        txtSQL &= "And  (Size_Code='" & StkSize & "') "

        subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa1.Fill(subDs, "Data01")
        Count01 = 0

        If Not IsDBNull(subDs.Tables("Data01").Rows(0).Item("max")) Then
            Count01 = subDs.Tables("Data01").Rows(0).Item("max")
        Else
            Count01 = 0
        End If
        'subDs = Nothing
        'subDa1 = Nothing
        Count01 = Count01 + 1
        Return Count01

    End Function
    Function chkData() As Boolean

        If Len(lbTypeID.Text) < 2 Then
            MsgBox("ข้อมูล <ประเภท-สินค้า> ไม่ถูกต้อง ตรวจสอบอีกครั้ง", MsgBoxStyle.Critical, "แจ้งเตือน")
            Return False
        Else
            Return True

        End If
        If Len(lbGrpID.Text) < 2 Then
            MsgBox("ข้อมูล <กลุ่ม-สินค้า> ไม่ถูกต้อง ตรวจสอบอีกครั้ง", MsgBoxStyle.Critical, "แจ้งเตือน")
            Return False
        Else
            Return True
        End If

        If Len(lbColorID.Text) < 5 Then
            MsgBox("ข้อมูล <สี-สินค้า> ไม่ถูกต้อง ตรวจสอบอีกครั้ง", MsgBoxStyle.Critical, "แจ้งเตือน")
            Return False
        Else
            Return True
        End If

        If Len(lbThID.Text) < 4 Then
            MsgBox("ข้อมูล <ความหนา-สินค้า> ไม่ถูกต้อง ตรวจสอบอีกครั้ง", MsgBoxStyle.Critical, "แจ้งเตือน")
            Return False
        Else
            Return True
        End If

        If Len(lbSizeID.Text) < 8 Then
            MsgBox("ข้อมูล <ขนาด-สินค้า> ไม่ถูกต้อง ตรวจสอบอีกครั้ง", MsgBoxStyle.Critical, "แจ้งเตือน")
            Return False
        Else
            Return True
        End If

        If Len(lbPaperID.Text) < 2 Then
            MsgBox("ข้อมูล <วัสดุปิด-สินค้า> ไม่ถูกต้อง ตรวจสอบอีกครั้ง", MsgBoxStyle.Critical, "แจ้งเตือน")
            Return False
        Else
            Return True
        End If

        If Len(lbGradeID.Text) < 1 Then
            MsgBox("ข้อมูล <เกรด-สินค้า> ไม่ถูกต้อง ตรวจสอบอีกครั้ง", MsgBoxStyle.Critical, "แจ้งเตือน")
            Return False
        Else
            Return True
        End If

    End Function
    Private Sub cmbGenCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGenCode.Click


        If chkData() = True Then
            Call genCode()
        Else
            Exit Sub

        End If


    End Sub


    Sub getColFactor()


        'txtSQL = "Select  Type_Code,Type_Name,Type_Stk_Name  From TypeMast "
        'txtSQL &= "Order by Type_Code "

        'da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'da.Fill(ds, "TypeMast")

        'If ds.Tables("TypeMast").Rows.Count > 0 Then
        '    With cboType
        '        .DataSource = ds.Tables("TypeMast")
        '        .DisplayMember = "Type_Name"
        '        .ValueMember = "Type_Code"
        '        .Text = ""
        '    End With
        'End If

        'txtSQL = "Select  Grp_Code,Grp_Name,Grp_StkName  From GrpMast "
        'txtSQL &= "Order by Grp_Code "

        'da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'da.Fill(ds, "GrpMast")

        'If ds.Tables("GrpMast").Rows.Count > 0 Then
        '    With cboGrp
        '        .DataSource = ds.Tables("GrpMast")
        '        .DisplayMember = "Grp_Name"
        '        .ValueMember = "Grp_Code"
        '        .Text = ""
        '    End With
        'End If


        'txtSQL = "Select  Color_Code,(color_code1 + '-'+ Color_StkName) as Color_StkName "
        'txtSQL &= "From ColorMast "
        'txtSQL &= "Order by Color_Code "

        'da = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'da.Fill(ds, "ColorMast")

        'If ds.Tables("ColorMast").Rows.Count > 0 Then
        '    With cboColor
        '        .DataSource = ds.Tables("ColorMast")
        '        .DisplayMember = "Color_StkName"
        '        .ValueMember = "Color_Code"
        '        .Text = ""
        '    End With
        'End If


        txtSQL = "Select  Th_Name,Th_Code,Th_Th  "
        txtSQL &= "From ThMast "
        txtSQL &= "Order by Th_th "

        subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa1.Fill(subDs, "ThMast")

        If subDs.Tables("ThMast").Rows.Count > 0 Then
            With cboTh
                .DataSource = subDs.Tables("ThMast")
                .DisplayMember = "Th_Th"
                .ValueMember = "Th_Code"
                .Text = ""
            End With
        End If

        txtSQL = "Select  Size_Name_2,Size_Code "
        txtSQL &= "From SizeMast "
        txtSQL &= "Order by Size_Name_2  "

        subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa1.Fill(subDs, "SizeMast")

        If subDs.Tables("SizeMast").Rows.Count > 0 Then
            With cboSize
                .DataSource = subDs.Tables("SizeMast")
                .DisplayMember = "Size_Name_2"
                .ValueMember = "Size_Code"
                .Text = ""
            End With
        End If

        txtSQL = "Select  Paper_Name,Paper_Code  "
        txtSQL &= "From PaperMast "
        txtSQL &= "Order by Paper_Code"

        subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa1.Fill(subDs, "PaperMast")

        If subDs.Tables("PaperMast").Rows.Count > 0 Then
            With cboPaper
                .DataSource = subDs.Tables("paperMast")
                .DisplayMember = "Paper_Name"
                .ValueMember = "Paper_Code"
                .Text = ""
            End With
        End If


        txtSQL = "Select  G_Name,G_Name_2,G_Code  "
        txtSQL &= "From GMast "
        txtSQL &= "Order by G_Code"

        subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa1.Fill(subDs, "GMast")

        If subDs.Tables("GMast").Rows.Count > 0 Then
            With cboGrade
                .DataSource = subDs.Tables("GMast")
                .DisplayMember = "G_Name"
                .ValueMember() = "G_Code"
                .Text = ""
            End With
        End If

    End Sub
    Sub addProdList()

        Dim subDA As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet
        txtSQL = "Select * "
        txtSQL &= "From ProGrpMast "
        txtSQL &= "Order by ProGrp_id "

        subDA = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA.Fill(subDS, "listData")
        If subDS.Tables("listData").Rows.Count > 0 Then
            cboProdList.DataSource = subDS.Tables("listData")
            cboProdList.ValueMember = "ProGrp_id"
            cboProdList.DisplayMember = "ProGrp_Name"
            'cboDClist.Text = ""
            cboProdList.SelectedItem = 0
        End If

    End Sub

    Private Sub frmGenCode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FormatGrd()
        'dbTools.openDB()
        getColFactor()
        Call addProdList()

        Call comboStore()

    End Sub


    Sub genNameStk()

        Dim subDa2 As SqlClient.SqlDataAdapter

        Dim subDs As DataSet = New DataSet
        Dim stkName As String = ""
        Dim pcName As String = ""

        'If cboProdList.Text = "" Then
        '    MsgBox("ไม่พบข้อมูล -กลุ่มสินค้าหลัก- โปรตรวจสอบ", MsgBoxStyle.Critical, "แจ้งเตือน")
        '    Exit Sub

        'End If
        'If cboType.Text = "" Then
        '    MsgBox("ไม่พบข้อมูล -ประเภท- โปรตรวจสอบ", MsgBoxStyle.Critical, "แจ้งเตือน")
        '    Exit Sub

        'End If
        'If cboGrp.Text = "" Then
        '    MsgBox("ไม่พบข้อมูล -กลุ่ม- โปรตรวจสอบ", MsgBoxStyle.Critical, "แจ้งเตือน")
        '    Exit Sub

        'End If

        'If cboColor.Text = "" Then
        '    MsgBox("ไม่พบข้อมูล -สี- โปรตรวจสอบ", MsgBoxStyle.Critical, "แจ้งเตือน")
        '    Exit Sub

        'End If

        'If cboTh.Text = "" Then
        '    MsgBox("ไม่พบข้อมูล -หนา- โปรตรวจสอบ", MsgBoxStyle.Critical, "แจ้งเตือน")
        '    Exit Sub

        'End If
        'If cboSize.Text = "" Then
        '    MsgBox("ไม่พบข้อมูล -ขนาด- โปรตรวจสอบ", MsgBoxStyle.Critical, "แจ้งเตือน")
        '    Exit Sub

        'End If

        'If cboPaper.Text = "" Then
        '    MsgBox("ไม่พบข้อมูล -กระดาษ- โปรตรวจสอบ", MsgBoxStyle.Critical, "แจ้งเตือน")
        '    Exit Sub

        'End If
        'If cboGrade.Text = "" Then
        '    MsgBox("ไม่พบข้อมูล -เกรด- โปรตรวจสอบ", MsgBoxStyle.Critical, "แจ้งเตือน")
        '    Exit Sub

        'End If

        'ProGrpMast

        txtSQL = "Select  *  "
        txtSQL &= "From ProGrpMast "
        txtSQL &= "Where ProGrp_ID='" & cboProdList.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ProGrpMast")
        '============================================================================================
        txtSQL = "Select  *  From TypeMast "
        txtSQL &= "Where type_Prod='" & cboProdList.SelectedValue & "' "
        txtSQL &= "and Type_Code='" & cboType.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "TypeMast")
        '============================================================================================

        Dim strTypeName As String = subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name").ToString

        If cboProdList.SelectedValue = "01" Then
            stkName = strTypeName

        Else
            stkName = strTypeName
            pcName = strTypeName
        End If

        '============================================================================================

        txtSQL = "Select  *  "
        txtSQL &= "From GrpMast "
        txtSQL &= "Where Grp_Prod_Code='" & cboProdList.SelectedValue & "' "
        txtSQL &= "And Grp_Type_Code='" & cboType.SelectedValue & "' "
        txtSQL &= "And Grp_Code='" & cboGrp.SelectedValue & "' "

        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "GrpMast")

        Dim strGrpName As String = subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName").ToString
        If strTypeName = "GP" Then
        Else
            stkName = stkName & strGrpName
            pcName = pcName & strGrpName
        End If


        '============================================================================================

        txtSQL = "Select  *  "
        txtSQL &= "From ColorMast "
        txtSQL &= "Where Color_Code='" & cboColor.SelectedValue & "' "
        txtSQL &= "And Color_Type='" & cboType.SelectedValue & "' "
        txtSQL &= "And ColorProd_code='" & cboProdList.SelectedValue & "' "

        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ColorMast")
        Dim strColorName As String = subDs.Tables("ColorMast").Rows(0).Item("Color_StkName").ToString
        Dim strColorNamePC As String = "#" & subDs.Tables("ColorMast").Rows(0).Item("Color_Code1").ToString
        If strTypeName = "GP" Then
            stkName = stkName & strColorName & strGrpName
            pcName = pcName & strColorNamePC & strGrpName
        Else
            stkName = stkName & "" & strColorName
            pcName = pcName & strColorNamePC
        End If


        '============================================================================================

        txtSQL = "Select  *  "
        txtSQL &= "From thMast "
        txtSQL &= "Where th_Code='" & cboTh.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ThMast")
        Dim strThName As String = subDs.Tables("ThMast").Rows(0).Item("th_th").ToString
        stkName = stkName & ".-" & strThName
        pcName = pcName & ".-" & strThName
        '============================================================================================

        txtSQL = "Select  *  "
        txtSQL &= "From SizeMast "
        txtSQL &= "Where Size_Code='" & cboSize.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "SizeMast")
        stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Name_2"))
        pcName = pcName & "*" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_width") & "*" & subDs.Tables("SizeMast").Rows(0).Item("Size_Height"))
        '============================================================================================

        txtSQL = "Select  *  "
        txtSQL &= "From PaperMast "
        txtSQL &= "Where Paper_Code='" & cboPaper.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "paperMast")
        stkName = stkName & Trim(subDs.Tables("PaperMast").Rows(0).Item("Paper_Name"))
        pcName = pcName & Trim(subDs.Tables("PaperMast").Rows(0).Item("Paper_Name"))
        '============================================================================================

        txtSQL = "Select  * "
        txtSQL &= "From gMast "
        txtSQL &= "Where g_Code='" & cboGrade.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "gMast")
        stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
        pcName = pcName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
        txtStkName.Text = stkName
        txtStkName2.Text = pcName

        '============================================================================================

        'If cboProdList.SelectedValue = "02" Then  '  สร้างชื่อ TT

        ''stkName = "TT-" & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))
        ''stkName = stkName & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))
        ''stkName = stkName & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Name_2"))

        'ElseIf cboProdList.SelectedValue = "05" Then  '  สร้างชื่อ   NPD

        '    stkName = "NPD-" & Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name")) & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))

        'ElseIf cboProdList.SelectedValue = "01" Then      '  สร้างชื่อ   GP  และ อื่นๆ 

        '    'If subDs.Tables("ColorMast").Rows.Count = 0 Then
        '    '    stkName = ""
        '    'Else
        '    '    '  ประเภท + กลุ่ม + สี  + ความหนา
        '    '    stkName = Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name"))
        '    '    stkName = stkName & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))
        '    '    stkName = stkName & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))


        '    'End If
        'Else

        '    If subDs.Tables("ColorMast").Rows.Count = 0 Then
        '        stkName = ""
        '    Else

        '        '  ประเภท + กลุ่ม + สี  + ความหนา
        '        stkName = Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name"))
        '        stkName = stkName & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))
        '        stkName = stkName & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))


        '    End If

        'End If



        'If Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_Code")) = "05" And Trim(subDs.Tables("ProGrpMast").Rows(0).Item("ProGrp_id")) = "04" Then

        '    stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
        '    lbCutWeight.Text = 0
        '    lbWeight.Text = 0

        'ElseIf Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Code")) = "04" Then



        'Else

        '    'stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
        '    'stkName = stkName & Trim(subDs.Tables("ColorSMast").Rows(0).Item("Color_S_Name_2"))
        '    'stkName = stkName & ".-" & Trim(subDs.Tables("ThMast").Rows(0).Item("Th_th"))
        '    'stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Name_2"))
        '    'stkName = stkName & " " & Trim(subDs.Tables("PaperMast").Rows(0).Item("Paper_Name"))
        '    'stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))


        'End If


        'Return stkName

    End Sub

    Function genNameGP() As String

        Dim subDa2 As SqlClient.SqlDataAdapter

        Dim subDs As DataSet = New DataSet
        Dim stkName As String


        txtSQL = "Select  *  From TypeMast "
        txtSQL &= "Where Type_Code='" & cboType.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "TypeMast")

        txtSQL = "Select  *  From GrpMast "
        txtSQL &= "Where Grp_Code='" & cboGrp.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "GrpMast")

        txtSQL = "Select  *  From ColorMast "
        txtSQL &= "Where Color_Code='" & cboColor.SelectedValue & "' "
        txtSQL &= "And Color_Type='" & cboType.SelectedValue & "'"
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ColorMast")

        txtSQL = "Select  *  From SizeMast "
        txtSQL &= "Where Size_Code='" & cboSize.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "SizeMast")

        txtSQL = "Select  *  From thMast "
        txtSQL &= "Where th_Code='" & cboTh.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ThMast")

        txtSQL = "Select  *  From gMast "
        txtSQL &= "Where g_Code='" & cboGrade.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "gMast")

        txtSQL = "Select  *  From PaperMast "
        txtSQL &= "Where Paper_Code='" & cboPaper.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "paperMast")

        'subDs.Tables("Stkname").Rows(0).Item("Stk_Name_1")
        If cboProdList.SelectedValue = "02" Then

            'stkName = "TT-" & Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name")) & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))
            stkName = "TT-" & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))
            stkName = stkName & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))
            stkName = stkName & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Name_2"))
            'stkName = stkName

        ElseIf cboProdList.SelectedValue = "05" Then
            stkName = "NPD-" & Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name")) & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))
            'stkName = stkName & Trim(subDs.Tables("ColorSMast").Rows(0).Item("Color_S_Name"))
            'stkName = stkName & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))  'เอาออก 28-01-56  แก้ไขชื่อสินค้า NPD

        Else
            If subDs.Tables("ColorMast").Rows.Count = 0 Then
                stkName = ""
            Else
                stkName = Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name")) & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName")) & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))
            End If

            'stkName = stkName & Trim(subDs.Tables("ColorSMast").Rows(0).Item("Color_S_Name"))
            'stkName = stkName & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))

        End If



        If Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_Code")) = "05" Then

            stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
            lbCutWeight.Text = 0
            lbWeight.Text = 0

        ElseIf Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Code")) = "04" Then

        Else

            'stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
            'stkName = stkName & Trim(subDs.Tables("ColorSMast").Rows(0).Item("Color_S_Name_2"))
            stkName = stkName & ".-" & Trim(subDs.Tables("ThMast").Rows(0).Item("Th_th"))
            stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Name_2"))
            'stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Width"))
            'stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Height"))
            stkName = stkName & " " & Trim(subDs.Tables("PaperMast").Rows(0).Item("Paper_Name"))
            stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))

        End If



        Return stkName
    End Function
    Function genNamePC() As String

        Dim subDa2 As SqlClient.SqlDataAdapter

        Dim subDs As DataSet = New DataSet
        Dim stkName As String

        If lbType.Text = "" Then

            MsgBox("ไม่พบข้อมูลประเภทสินค้า")
            Return ""
            Exit Function

        End If
        txtSQL = "Select  *  From TypeMast "
        txtSQL &= "Where Type_Code='" & lbTypeID.Text & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "TypeMast")
        If lbGrp.Text = "" Then
            MsgBox("ไม่พบข้อมูลกลุ่มสินค้า")
            Return ""
            Exit Function

        End If
        txtSQL = "Select  *  From GrpMast "
        txtSQL &= "Where Grp_Code='" & lbGrpID.Text & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "GrpMast")
        If lbColor.Text = "" Then
            MsgBox("ไม่พบข้อมูลสี")
            Return ""
            Exit Function

        End If
        txtSQL = "Select  *  From ColorMast "
        txtSQL &= "Where Color_Code='" & lbColorID.Text & "' "
        txtSQL &= "And Color_Type='" & lbTypeID.Text & "'"
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ColorMast")

        If lbTh.Text = "" Then
            MsgBox("ไม่พบข้อมูลความหนา")
            Return ""
            Exit Function

        End If
        txtSQL = "Select  *  From thMast "
        txtSQL &= "Where th_Code='" & lbThID.Text & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ThMast")

        If lbSize.Text = "" Then
            MsgBox("ไม่พบข้อมูลขนาด")
            Return ""
            Exit Function

        End If
        txtSQL = "Select  *  From SizeMast "
        txtSQL &= "Where Size_Code='" & cboSize.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "SizeMast")



        If lbProDid.Text = "02" Then
            stkName = "TT-" & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))

            stkName = stkName & "-" & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))
            stkName = stkName & ".-" & Trim(subDs.Tables("ThMast").Rows(0).Item("Th_th"))
            stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Name_2"))
        ElseIf lbProDid.Text = "05" Then
            stkName = "NPD-" & Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name")) & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))

        Else
            'If subDs.Tables("ColorMast").Rows.Count = 0 Then
            '    stkName = ""
            'Else

            stkName = subDs.Tables("ColorMast").Rows(0).Item("Color_Code1")
            stkName = stkName & ".-" & subDs.Tables("ThMast").Rows(0).Item("Th_Th")
            stkName = stkName & "*" & subDs.Tables("SizeMast").Rows(0).Item("Size_width") & "*" & subDs.Tables("SizeMast").Rows(0).Item("Size_Height")

            'End If
        End If

        'If Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_Code")) = "05" Then

        '    stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
        '    lbCutWeight.Text = 0
        '    lbWeight.Text = 0

        'ElseIf Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Code")) = "04" Then

        'Else

        '    'stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
        '    'stkName = stkName & Trim(subDs.Tables("ColorSMast").Rows(0).Item("Color_S_Name_2"))
        '    stkName = stkName & ".-" & Trim(subDs.Tables("ThMast").Rows(0).Item("Th_th"))
        '    stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Name_2"))
        '    'stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Width"))
        '    'stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Height"))
        '    stkName = stkName & " " & Trim(subDs.Tables("PaperMast").Rows(0).Item("Paper_Name"))
        '    stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))

        'End If

        Return stkName

    End Function

    Function genNameNotGP() As String

        Dim subDa2 As SqlClient.SqlDataAdapter

        Dim subDs As DataSet = New DataSet
        Dim stkName As String
        'Dim strColorS As String
        'Dim strColor As String


        'txtSQL = "Select  Color_S_Name, Color_S_Name_2,Color_S_Name_3,Color_S_Code  "
        'txtSQL &= "From ColorSMast "
        'txtSQL &= "Where Color_S_Code='" '& cboSColor.SelectedValue & "' "

        'subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'subDa2.Fill(subDs, "ColorSMast")
        txtSQL = "Select  *  From TypeMast "
        txtSQL &= "Where Type_Code='" & cboType.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "TypeMast")

        txtSQL = "Select  *  From GrpMast "
        txtSQL &= "Where Grp_Code='" & cboGrp.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "GrpMast")

        txtSQL = "Select  *  From ColorMast "
        txtSQL &= "Where Color_Code='" & cboColor.SelectedValue & "' "
        txtSQL &= "And Color_Type='" & cboType.SelectedValue & "'"
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ColorMast")

        txtSQL = "Select  *  From SizeMast "
        txtSQL &= "Where Size_Code='" & cboSize.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "SizeMast")

        txtSQL = "Select  *  From thMast "
        txtSQL &= "Where th_Code='" & cboTh.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ThMast")

        txtSQL = "Select  *  From gMast "
        txtSQL &= "Where g_Code='" & cboGrade.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "gMast")

        txtSQL = "Select  *  From PaperMast "
        txtSQL &= "Where Paper_Code='" & cboPaper.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "paperMast")

        'subDs.Tables("Stkname").Rows(0).Item("Stk_Name_1")
        If cboProdList.SelectedValue = "02" Then

            'stkName = "TT-" & Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name")) & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))
            stkName = "TT-" & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))
            stkName = stkName & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))
            stkName = stkName & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Name_2"))
            'stkName = stkName

        ElseIf cboProdList.SelectedValue = "05" Then
            stkName = "NPD-" & Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name")) & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))
            'stkName = stkName & Trim(subDs.Tables("ColorSMast").Rows(0).Item("Color_S_Name"))
            'stkName = stkName & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))  'เอาออก 28-01-56  แก้ไขชื่อสินค้า NPD

        Else
            If subDs.Tables("ColorMast").Rows.Count = 0 Then
                stkName = ""
            Else
                stkName = Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name")) & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName")) & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))
            End If

            'stkName = stkName & Trim(subDs.Tables("ColorSMast").Rows(0).Item("Color_S_Name"))
            'stkName = stkName & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))

        End If



        If Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_Code")) = "05" Then

            stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
            lbCutWeight.Text = 0
            lbWeight.Text = 0

        ElseIf Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Code")) = "04" Then

        Else

            'stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
            'stkName = stkName & Trim(subDs.Tables("ColorSMast").Rows(0).Item("Color_S_Name_2"))
            stkName = stkName & ".-" & Trim(subDs.Tables("ThMast").Rows(0).Item("Th_th"))
            stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Name_2"))
            'stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Width"))
            'stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Height"))
            stkName = stkName & " " & Trim(subDs.Tables("PaperMast").Rows(0).Item("Paper_Name"))
            stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))

        End If



        Return stkName
    End Function

    Function genNameStk2() As String

        Dim subDa2 As SqlClient.SqlDataAdapter

        Dim subDs As DataSet = New DataSet
        Dim stkName As String
        'Dim strColorS As String
        'Dim strColor As String


        'txtSQL = "Select  Color_S_Name, Color_S_Name_2,Color_S_Name_3,Color_S_Code  "
        'txtSQL &= "From ColorSMast "
        'txtSQL &= "Where Color_S_Code='" '& cboSColor.SelectedValue & "' "

        'subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        'subDa2.Fill(subDs, "ProdID")

        txtSQL = "Select  *  From ProGRpMast "
        txtSQL &= "Where ProGrp_ID='" & cboProdList.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ProdID")

        txtSQL = "Select  *  From TypeMast "
        txtSQL &= "Where Type_Code='" & cboType.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "TypeMast")

        txtSQL = "Select  *  From GrpMast "
        txtSQL &= "Where Grp_Code='" & cboGrp.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "GrpMast")

        txtSQL = "Select  *  From ColorMast "
        txtSQL &= "Where Color_Code='" & cboColor.SelectedValue & "' "
        txtSQL &= "And Color_Type='" & cboType.SelectedValue & "'"
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ColorMast")

        txtSQL = "Select  *  From SizeMast "
        txtSQL &= "Where Size_Code='" & cboSize.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "SizeMast")

        txtSQL = "Select  *  From thMast "
        txtSQL &= "Where th_Code='" & cboTh.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "ThMast")

        txtSQL = "Select  *  From gMast "
        txtSQL &= "Where g_Code='" & cboGrade.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "gMast")

        txtSQL = "Select  *  From PaperMast "
        txtSQL &= "Where Paper_Code='" & cboPaper.SelectedValue & "' "
        subDa2 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa2.Fill(subDs, "paperMast")

        'subDs.Tables("Stkname").Rows(0).Item("Stk_Name_1")
        Dim colorName As String = ""
        Dim grpName As String = ""
        'Dim 
        If subDs.Tables("grpMast").Rows.Count > 0 Then
            grpName = subDs.Tables("grpMast").Rows(0).Item("grp_stkName")
        End If

        If subDs.Tables("ColorList").Rows.Count > 0 Then
            If (grpName = "K" Or grpName = "Z") And subDs.Tables("ProdID").Rows(0).Item("ProGRp_ID") = "01" Then '
                If grpName = "K" Then
                    colorName = subDs.Tables("ColorList").Rows(0).Item("Color_Code1") & "K"
                ElseIf grpName = "Z" Then
                    colorName = subDs.Tables("ColorList").Rows(0).Item("Color_Code1") & "Z"
                End If
            Else
                colorName = subDs.Tables("ColorList").Rows(0).Item("Color_Code1")
            End If

        End If

        stkName = Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Stk_Name")) & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_Name")) & Trim(subDs.Tables("ColorMast").Rows(0).Item("Color_Name"))
        'stkName = stkName & Trim(subDs.Tables("ColorSMast").Rows(0).Item("Color_S_Name"))
        stkName = stkName & Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_StkName"))

        If Trim(subDs.Tables("GrpMast").Rows(0).Item("Grp_Code")) = "05" Then

            stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
            lbCutWeight.Text = 0
            lbWeight.Text = 0

        ElseIf Trim(subDs.Tables("TypeMast").Rows(0).Item("Type_Code")) = "04" Then

        Else

            'stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))
            'stkName = stkName & Trim(subDs.Tables("ColorSMast").Rows(0).Item("Color_S_Name_2"))
            stkName = stkName & "-" & Trim(subDs.Tables("ThMast").Rows(0).Item("Th_Th"))
            stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Name"))
            'stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Width"))
            'stkName = stkName & "x" & Trim(subDs.Tables("SizeMast").Rows(0).Item("Size_Height"))
            stkName = stkName & Trim(subDs.Tables("PaperMast").Rows(0).Item("Paper_Name"))
            stkName = stkName & Trim(subDs.Tables("gMast").Rows(0).Item("g_Name_2"))

        End If



        Return stkName
    End Function

    Function calCutWeight(ByVal th As Double, ByVal w As Double, ByVal h As Double, ByVal sg As Double) As Double

        Dim CutWeight As Double
        'Dim sg As Double = getSG()

        CutWeight = CDbl(th)
        CutWeight = CutWeight * CDbl(w)
        CutWeight = CutWeight * CDbl(h) * sg
        CutWeight = CutWeight / 1000000
        Return CutWeight

    End Function


    Private Sub cmbExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExit.Click
        Me.Close()
    End Sub

    Sub saveStkMast()

        Dim subDs As DataSet = New DataSet
        Dim subDa As SqlClient.SqlDataAdapter
        Dim subCom As SqlClient.SqlCommand = New SqlClient.SqlCommand
        Dim ProdGrpID As String = ""
        'Dim subDs As DataSet = New DataSet()
        'Dim subDa As SqlClient.SqlDataAdapter

        txtSQL = "Select * From BaseMast "
        txtSQL &= "Where Stk_Code='" & lbStkCode.Text & "' "

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDs, "StkDataSet")


        If subDs.Tables("StkDataSet").Rows.Count = 0 Then

            txtSQL = "Insert into BaseMast("
            txtSQL &= "Stk_Code2,"
            txtSQL &= "Stk_Run,"
            txtSQL &= "Stk_Code,"                 '1 รหัสสินค้า
            txtSQL &= "Stk_Name_1,"           '2 ชื่อสินค้า
            txtSQL &= "Type_Code,"             '3
            txtSQL &= "Grp_Code,"                '4
            txtSQL &= "Th_Code,"                  '5
            txtSQL &= "Size_Code,"              '6
            txtSQL &= "Color_Code,"            '7
            txtSQL &= "Paper_Code,"          '8
            txtSQL &= "G_Code,"                   '9
            txtSQL &= "Stk_Name_2,"          '10  ชื่อที่ 2
            txtSQL &= "Stk_Bar,"                    '11  Barcode
            txtSQL &= "Stk_Factor,"              '12  ขนาดบรรจุ- น้ำหนัก
            txtSQL &= "Stk_Factor2,"            '13  ขนาดบรรจุ2/ น้ำหนัก เท
            txtSQL &= "Stk_Unit_1,"               '14  หน่วยหลัก
            txtSQL &= "Stk_Unit_2,"               '15  หน่วยย่อย
            txtSQL &= "Stk_Servce,"             '16  กำหนดว่านับ Stock 
            txtSQL &= "Stk_Equ,Stk_Type,"                   '17  
            'txtSQL &= "Stk_Alt,":
            txtSQL &= "Stk_Cost,"                  '18   ทุน
            txtSQL &= "Stk_Vat,"                    '19    Vat  
            'txtSQL &= "Stk_Std_Q1,"            ' 20
            'txtSQL &= "Stk_Std_Q2,"            ' 21
            ''txtSQL &= "Stk_T_Mark,"
            ''txtSQL &= "Stk_SubGrp,"
            'txtSQL &= "Stk_Tag,"                   ' 22
            'txtSQL &= "Stk_Tdc,"                    ' 23
            ''txtSQL &= "Stk_Same_C,"
            ''txtSQL &= "Stk_BOM_Code_1,"
            ''txtSQL &= "Stk_BOM_Code_2,"
            txtSQL &= "Stk_Date,"                   ' 24
            txtSQL &= "Stk_Prod,"
            txtSQL &= "Stk_NPD,"
            txtSQL &= "Stk_Code_N,"
            txtSQL &= "Stk_Code_PC,"
            txtSQL &= "Stk_TypeGrp_Code,"
            txtSQL &= "Stk_Find_Word"
            txtSQL &= ") "

            txtSQL &= "Values("
            txtSQL &= " '" & Microsoft.VisualBasic.Right(lbStkCode.Text, 11) & "',"                                    'รหัสสินค้า  1
            txtSQL &= " '" & lbCount.Text & "',"                                    'รหัสสินค้า  1

            'txtSQL &= " '" & lbStkCode.Text & "',"                                    'รหัสสินค้า  1
            'txtSQL &= " '" & Trim(txtStkName.Text) & "',"                                   'ชื่อสินค้า    2
            'txtSQL &= " '" & Trim(cboType.SelectedValue) & "',"                  ' Type     3
            'txtSQL &= " '" & Trim(cboGrp.SelectedValue) & "',"                      ' Group   4
            'txtSQL &= " '" & cboTh.SelectedValue & "' ,"                       'ความหนา  5
            'txtSQL &= " '" & cboSize.SelectedValue & "' ,"                   '  Size      6
            'txtSQL &= " '" & cboColor.SelectedValue & "' ,"                 '  Color   7
            'txtSQL &= " '" & cboPaper.SelectedValue & "' ,"               '  Paper  8
            'txtSQL &= " '" & cboGrade.SelectedValue & "' ,"               '  Grade 9

            txtSQL &= " '" & lbStkCode.Text & "',"                                    'รหัสสินค้า  1
            txtSQL &= " '" & Trim(txtStkName.Text) & "',"                                   'ชื่อสินค้า    2

            txtSQL &= " '" & Trim(lbTypeID.Text) & "',"                  ' Type     3
            txtSQL &= " '" & Trim(lbGrpID.Text) & "',"                      ' Group   4
            txtSQL &= " '" & Trim(lbThID.Text) & "' ,"                       'ความหนา  5
            txtSQL &= " '" & Trim(lbSizeID.Text) & "' ,"                   '  Size      6
            txtSQL &= " '" & Trim(lbColorID.Text) & "' ,"                 '  Color   7
            txtSQL &= " '" & Trim(lbPaperID.Text) & "' ,"               '  Paper  8
            txtSQL &= " '" & Trim(lbGradeID.Text) & "' ,"               '  Grade 9


            txtSQL &= " '" & Trim(txtStkName2.Text) & "' ,"                                    '  10  stk_Name_2

            txtSQL &= " '" & lbStkCode.Text & "',"                                    '  11
            txtSQL &= " " & lbCutWeight.Text & ", "                                  '  12
            txtSQL &= " " & lbWeight.Text & ","                                         '   13
            txtSQL &= " 'แผ่น',"                                                                          '  14
            txtSQL &= "'kg',"                                                                            '  15
            txtSQL &= "-1,"                                                                                 '  16
            If chkType0.Checked = True Then
                txtSQL &= "0,0,"  ' EQU      
            ElseIf chkType1.Checked = True Then
                txtSQL &= "1,1,"  ' EQU      
            End If
            '  17    

            txtSQL &= "1,"                                                                                  '  18

            If optVAT.Checked = True Then
                txtSQL &= "3,"  '  stk_vat   
            ElseIf optVatAll.Checked = True Then
                txtSQL &= "1,"  '  stk_vat   
            ElseIf optNVat.Checked = True Then
                txtSQL &= "2,"  '  stk_vat   
            End If
            '  19
            'txtSQL &= "0,"                                                                                  '  20
            'txtSQL &= "0,"                                                                                  '  21
            'txtSQL &= "1,"                                                                                  '22
            'txtSQL &= "'" & lbBOMCT.Text & "' ,"
            'txtSQL &= "'" & lbBOMST.Text & "' ,"

            txtSQL &= "'" & Now.ToString("MM/dd/yyyy") & "', "
            ProdGrpID = cboProdList.SelectedValue
            txtSQL &= "'" & ProdGrpID & "',"

            'If chkQD.Checked = True Then
            'txtSQL &= "'01'"
            'Else
            txtSQL &= "'02',"
            txtSQL &= "'" & txtStkCodeN.Text & "',"
            txtSQL &= "'" & txtPcCode.Text & "',"
            txtSQL &= "'00',"
            txtSQL &= "'" & lbFindWord.Text & "'"
            'End If

            txtSQL &= ")"

        Else

            txtSQL = "Update  BaseMast  Set "
            txtSQL &= "Stk_Name_1='" & Trim(txtStkName.Text) & "',"           '2 ชื่อสินค้า
            txtSQL &= "Stk_Name_2='" & Trim(txtStkName2.Text) & "',"         '10  ชื่อที่ 2
            txtSQL &= "Stk_PC_Name='" & Trim(txtStkName2.Text) & "',"
            txtSQL &= "Stk_Find_Word='" & " " & lbFindWord.Text & "', "

            If chkType1.Checked = True Then

                txtSQL &= "Stk_Type='1',"
                txtSQL &= "Stk_EQU='1',"

            ElseIf chkType0.Checked = True Then
                txtSQL &= "Stk_Type='0',"
                txtSQL &= "Stk_EQU='0',"

            End If

            txtSQL &= "Stk_Factor=" & lbCutWeight.Text & ", "                      '12  ขนาดบรรจุ- น้ำหนัก
            txtSQL &= "Stk_Factor2=" & " " & lbCutWeight.Text & ", "              '13  ขนาดบรรจุ2/ น้ำหนัก เท

            'txtSQL &= "Type_Code='" & Trim(lbTypeID.Text) & "',"      '3

            txtSQL &= "Stk_Code_PC='" & " " & txtPcCode.Text & "', "
            txtSQL &= "Stk_Code_n='" & " " & txtStkCodeN.Text & "', "

            'txtSQL &= "Stk_Unit_1,"               '14  หน่วยหลัก
            'txtSQL &= "Stk_Unit_2,"               '15  หน่วยย่อย
            If optVatAll.Checked = True Then

                txtSQL &= "Stk_VAT=1 ,"
            ElseIf optNVat.Checked = True Then

                txtSQL &= "Stk_VAT=2,"
            ElseIf optVAT.Checked = True Then

                txtSQL &= "Stk_VAT=3,"
            Else
                txtSQL &= "Stk_VAT=1 ,"

            End If

            txtSQL &= "Stk_Date='" & Now.ToString("MM/dd/yyyy") & "' "                  ' 24        

            txtSQL &= "Where Stk_Code='" & lbStkCode.Text & "' "
        End If

        'Try
        If MessageBox.Show("ต้องการบันทึกข้อมูล ' " & lbStkCode.Text & " ' ที่ระบุหรือไม่", "คำยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            With subCom
                .CommandType = CommandType.Text
                .CommandText = txtSQL
                .Connection = Conn
                .ExecuteNonQuery()
            End With
            'dbTools.dbSaveSQLsrv(txtSQL, "test")
        End If
        MsgBox("บันทึกเรียบร้อย", MsgBoxStyle.OkOnly)
        'Catch errprocess As Exception
        'MessageBox.Show("ไม่สามารถเพิ่มข้อมูลได้เนื่องจาก " & errprocess.Message, "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub cmbSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSave.Click
        If chkStkDetl(lbStkCode.Text) = False Then

            Call saveStkMast()
            'dbTools.dbSaveSQLsrv(SQLsaveStkDetlVK(txtSQL), selCode)
            dbTools.dbSaveSQLsrv(SQLsaveStkDetlPan(txtSQL), selCode)

        Else

            Call saveStkMast()

        End If

        Call txtCLS()
    End Sub

    'Function SQLsaveStkDetlVK(ByVal txtsql As String) As String


    '    txtsql = "Insert into stkDetl("
    '    txtsql &= "dtl_store,Dtl_wh,dtl_code,dtl_dist,"

    '    'txtsql &= "dtl_acct,dtl_ac_dm,dtl_ac_cs,"
    '    'txtsql &= "dtl_ac_cr,dtl_ac_sl,"
    '    'txtsql &= "dtl_ac_sr,dtl_ac_ex,"
    '    'txtsql &= "dtl_ac_wp,dtl_ac_rt,"

    '    txtsql &= "dtl_ls_tt,dtl_ls_q1,"
    '    txtsql &= "dtl_ls_q2,dtl_bal_q1,"
    '    txtsql &= "dtl_bal_q2,dtl_iss_q1,"
    '    txtsql &= "dtl_iss_q2,dtl_rcv_q1,"
    '    txtsql &= "dtl_rcv_q2,dtl_bal_tt,"

    '    txtsql &= "dtl_min_pt,dtl_max_pt"
    '    txtsql &= ")"

    '    txtsql &= "Values("
    '    txtsql &= " '110805','12', '" & Trim(lbStkCode.Text) & "','00',"

    '    'If cboStore.SelectedValue = "23" Then
    '    '    txtsql &= " '701100',"
    '    'ElseIf cboStore.SelectedValue = "22" Then
    '    '    txtsql &= " '703102',"
    '    'ElseIf cboStore.SelectedValue = "25" Then
    '    '    txtsql &= " '703010',"
    '    'End If

    '    'txtsql &= "  '225000','501010', "
    '    'txtsql &= " '225000','401030',"
    '    'txtsql &= "'401111','225000',"
    '    'txtsql &= "'225000','225000',"

    '    txtsql &= "'0','0',"
    '    txtsql &= "'0','0',"
    '    txtsql &= "'0','0',"
    '    txtsql &= "'0','0',"
    '    txtsql &= "'0','0','1',"
    '    txtsql &= "'1'"


    '    txtsql &= ")"

    '    Return txtsql


    'End Function
    Function SQLsaveStkDetlPan(ByVal txtsql As String) As String

        txtsql = "Insert into stkDetl("
        txtsql &= "dtl_store,Dtl_wh,dtl_code,dtl_dist,"

        'txtsql &= "dtl_acct,dtl_ac_dm,dtl_ac_cs,"
        'txtsql &= "dtl_ac_cr,dtl_ac_sl,"
        'txtsql &= "dtl_ac_sr,dtl_ac_ex,"
        'txtsql &= "dtl_ac_wp,dtl_ac_rt,"

        txtsql &= "dtl_ls_tt,dtl_ls_q1,"
        txtsql &= "dtl_ls_q2,dtl_bal_q1,"
        txtsql &= "dtl_bal_q2,dtl_iss_q1,"
        txtsql &= "dtl_iss_q2,dtl_rcv_q1,"
        txtsql &= "dtl_rcv_q2,dtl_bal_tt,"
        txtsql &= "dtl_min_pt,dtl_max_pt"

        txtsql &= ")"

        txtsql &= "Values("
        txtsql &= " '100001','01', '" & Trim(lbStkCode.Text) & "','00',"

        'If cboStore.SelectedValue = "23" Then
        '    txtsql &= " '701100',"
        'ElseIf cboStore.SelectedValue = "22" Then
        '    txtsql &= " '703102',"
        'ElseIf cboStore.SelectedValue = "25" Then
        '    txtsql &= " '703010',"
        'End If

        'txtsql &= "  '225000','501010', "
        'txtsql &= " '225000','401030',"
        'txtsql &= "'401111','225000',"
        'txtsql &= "'225000','225000',"

        txtsql &= "'0','0',"
        txtsql &= "'0','0',"
        txtsql &= "'0','0',"
        txtsql &= "'0','0',"
        txtsql &= "'0','0','1',"
        txtsql &= "'1'"


        txtsql &= ")"

        Return txtsql
    End Function

    Sub autoGenC()

        Dim facColor As Integer : Dim facColorS As Integer
        Dim facTh As Integer : Dim facSize As Integer
        Dim facPaper As Integer : Dim facG As Integer
        Dim i As Integer : Dim j As Integer
        Dim k As Integer : Dim l As Integer
        Dim m As Integer : Dim n As Integer


        '  facColor = cboColor.Items.Count : facColorS = cboSColor.Items.Count
        facTh = cboTh.Items.Count : facSize = cboSize.Items.Count
        facPaper = cboPaper.Items.Count : facG = cboGrade.Items.Count
        For i = 0 To facColor - 1
            cboColor.SelectedIndex = i
            For j = 0 To facColorS - 1
                'cboSColor.SelectedIndex = j
                For k = 0 To facTh - 1
                    cboTh.SelectedIndex = k
                    For l = 0 To facSize - 1
                        cboSize.SelectedIndex = l
                        For m = 0 To facPaper - 1
                            cboPaper.SelectedIndex = m
                            For n = 0 To facG - 1
                                cboGrade.SelectedIndex = n
                                Call genCode()
                                Call saveStkMast()
                            Next
                        Next
                    Next
                Next
            Next
        Next
        'Call genCode()
        'Call saveStkMast()
        'Label12.Text = cboColor.SelectedValue

    End Sub

    Private Sub cmbStkDetl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStkDetl.Click
        'Dim frmStkdetl As Form1 = New Form1
        'frmStkdetl.Show()
    End Sub

    Sub delStkMast(ByVal stkCode As String)

        If (MsgBox("ต้องการลบข้อมูลสินค้า -" & dbTools.getStkName(stkCode) & "- จากระบบใช่หรือไม่ ?", MsgBoxStyle.YesNo, "แจ้งเตือน")) = MsgBoxResult.Yes Then


            txtSQL = "Delete  "
            txtSQL &= "From BaseMast "
            txtSQL &= "Where Stk_Code='" & stkCode & "'"

            dbTools.dbDelSQLsrv(txtSQL, "")

            txtSQL = "Delete "
            txtSQL &= "From StkDetl "
            txtSQL &= "Where Dtl_Code ='" & stkCode & "' "
            dbTools.dbDelSQLsrv(txtSQL, "")



        End If


    End Sub


    Private Sub cmbDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDel.Click

        delStkMast(lbStkCode.Text)
        MsgBox("ลบข้อมูลเรียบร้อย")
        Call txtCLS()

    End Sub


    Sub comboStore()

        Dim DS01 As DataSet = New DataSet
        Dim DA01 As SqlClient.SqlDataAdapter

        DS01.Clear()


        txtSQL = " SELECT *   From salegrup WHERE GRUP_TYPE='ST' order by grup_CODE"

        DA01 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        DA01.Fill(DS01, "store")

        If DS01.Tables("store").Rows.Count > 0 Then
            With cboStore
                .DataSource = DS01.Tables("store")
                .DisplayMember = "GRUP_NAME"
                .ValueMember = "GRUP_CODE"
                .Text = ""
            End With
        End If
        'cboCS.Text = ""
        cboStore.SelectedIndex = 13
    End Sub

    Private Sub cboType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboType.KeyDown
        If e.KeyCode = 13 Then
            cboGrp.Focus()
        End If
    End Sub

    Private Sub cboGrp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGrp.KeyDown
        If e.KeyCode = 13 Then
            cboColor.Focus()
        End If
    End Sub

    Private Sub cboColor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboColor.KeyDown
        If e.KeyCode = 13 Then
            cboTh.Focus()
        End If
    End Sub

    Private Sub cboTh_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboTh.KeyDown
        If e.KeyCode = 13 Then
            cboSize.Focus()
        End If
    End Sub

    Private Sub cboSize_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboSize.KeyDown
        If e.KeyCode = 13 Then
            cboPaper.Focus()
        End If
    End Sub

    Private Sub cboPaper_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboPaper.KeyDown
        If e.KeyCode = 13 Then
            cboGrade.Focus()
        End If
    End Sub

    Private Sub cboGrade_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboGrade.KeyDown
        If e.KeyCode = 13 Then
            cmbGenCode.Focus()
        End If
    End Sub

    Sub selProd()
        Dim subDs As DataSet = New DataSet
        Dim subDa1 As SqlClient.SqlDataAdapter
        Try
            txtSQL = "Select  Type_Code,Type_Name  From TypeMast "
            txtSQL &= "Where Type_Prod = '" & cboProdList.SelectedValue & "' "
            txtSQL &= "Order by Type_Code "

            subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDa1.Fill(subDs, "dbList")
            chkProdList = True

            If subDs.Tables("dbList").Rows.Count > 0 Then
                With cboType

                    .DataSource = subDs.Tables("dbList")
                    .DisplayMember = "Type_Name"
                    .ValueMember = "Type_Code"
                    '.Items.Add("")
                    '.Text = ""
                End With
                'cboType.SelectedItem = Nothing
            End If
            lbProDid.Text = cboProdList.SelectedValue
            If cboProdList.SelectedValue = "01" Then
                chkType0.Checked = True
                chkType1.Checked = False
            Else
                chkType0.Checked = False
                chkType1.Checked = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cboProdList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProdList.SelectedIndexChanged
        Call selProd()
    End Sub

    Private Sub cboType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboType.LostFocus
        lbTypeID.Text = cboType.SelectedValue
    End Sub
    Sub selType()

        Try
            lbType.Text = cboType.Text

            txtSQL = "Select  Grp_Code,Grp_Name,Grp_StkName  "
            txtSQL &= "From GrpMast "

            If lbType.Text = "" Then
                MsgBox("ไม่พบข้อมูล ประเภทสินค้า โปรดตรวจสอบข้อมูลอีกครั้ง", MsgBoxStyle.Critical, "เตือนข้อมูลผิด.")
            Else
                txtSQL &= "Where Grp_Type_Code='" & cboType.SelectedValue & "' "
                txtSQL &= "And Grp_Prod_Code='" & cboProdList.SelectedValue & "' "
                'If cboType.SelectedValue <> "05" Then

                'ElseIf cboProdList.SelectedValue = "05" And cboType.SelectedValue = "05" Then
                '    txtSQL &= "Where Grp_Type_Code='" & cboType.SelectedValue & "' "
                'Else

                'End If

            End If

            txtSQL &= "Order by Grp_Name "

            subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If chkGrp = True Then
                subDs.Tables("GrpMast").Clear()
                chkGrp = False

            End If
            subDa1.Fill(subDs, "GrpMast")
            chkGrp = True

            If subDs.Tables("GrpMast").Rows.Count > 0 Then
                With cboGrp
                    .DataSource = subDs.Tables("GrpMast")
                    .DisplayMember = "Grp_Name"
                    .ValueMember = "Grp_Code"
                    If cboType.Text = "GP" Then
                        .SelectedValue = 2
                    End If
                End With

            End If


            txtSQL = "Select  Color_Code,(color_code1 + ' ; '+ Color_StkName) as Color_StkName  "
            txtSQL &= "From ColorMast "
            txtSQL &= "Where Color_Type = '" & CStr(cboType.SelectedValue) & "' "
            txtSQL &= "And ColorProd_Code='" & CStr(cboProdList.SelectedValue) & "' "

            txtSQL &= "Order by Color_stkname "

            subDa1 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            If ChkColor = True Then
                subDs.Tables("ColorMast").Clear()
                ChkColor = False

            End If
            subDa1.Fill(subDs, "ColorMast")
            ChkColor = True

            If subDs.Tables("ColorMast").Rows.Count > 0 Then
                With cboColor
                    .DataSource = subDs.Tables("ColorMast")
                    .DisplayMember = "Color_StkName"
                    .ValueMember = "Color_Code"
                    .Text = ""
                End With
                cboColor.SelectedItem = Nothing
            End If

            ' Call showData(lbStkCode.Text)

        Catch ex As Exception
            'MsgBox("พบข้อมูลผิดพลาดโปรดแจ้ง ICT ", MsgBoxStyle.Critical, "Error Program")

        End Try
    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        Call selType()
    End Sub

    Private Sub cboColor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboColor.LostFocus

        lbColorID.Text = cboColor.SelectedValue



    End Sub




    Private Sub cboColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboColor.SelectedIndexChanged

        'Call showData(lbStkCode.Text)

        lbColor.Text = cboColor.Text
        Dim subDS As New DataSet
        Dim subDa As New SqlClient.SqlDataAdapter

        ' Call showData(lbStkCode.Text)


        txtSQL = "Select * "
        txtSQL &= "FRom ColorMast "
        txtSQL &= "Where (color_code1 + ' ; '+ Color_StkName)='" & cboColor.Text & "' "

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDS, "ColorDB")
        If subDS.Tables("ColorDB").Rows.Count > 0 Then
            lbColorID.Text = subDS.Tables("ColorDB").Rows(0).Item("Color_Code")
        End If

    End Sub

    Private Sub cboSize_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSize.LostFocus
        lbSizeID.Text = cboSize.SelectedValue

    End Sub

    'Sub FormatGrd()

    '    Dim grdTS As DataGridTableStyle = New DataGridTableStyle

    '    Dim StkChk As New DataGridTextBoxColumn


    '    Dim StkColor As New DataGridTextBoxColumn
    '    Dim stkSize As New DataGridTextBoxColumn
    '    Dim stkThick As New DataGridTextBoxColumn
    '    Dim StkName As New DataGridTextBoxColumn
    '    Dim StkFactor As New DataGridTextBoxColumn
    '    Dim StkCode As New DataGridTextBoxColumn
    '    Dim Q1 As New DataGridTextBoxColumn
    '    Dim StkQty As New DataGridTextBoxColumn

    '    Dim StkWH As New DataGridTextBoxColumn
    '    Dim stkStr As New DataGridTextBoxColumn
    '    Dim stkStrCode As New DataGridTextBoxColumn


    '    With grdTS
    '        .AlternatingBackColor = Color.LemonChiffon
    '        .BackColor = Color.White
    '        .MappingName = "Master"  'กำหนดให้ DatagridTalbleStyle ใช้กับ Table ใด

    '    End With

    '    With StkChk

    '    End With

    '    With StkColor
    '        .HeaderText = "Color"
    '        .MappingName = "Color_Name"
    '        .Alignment = HorizontalAlignment.Center
    '        '.ReadOnly = True
    '        .Width = 90
    '    End With

    '    With stkSize
    '        .HeaderText = "ขนาด"
    '        .MappingName = "Size_Name"
    '        .Alignment = HorizontalAlignment.Center
    '        '.ReadOnly = True
    '        .Width = 70
    '    End With

    '    With stkThick
    '        .HeaderText = "หนา"
    '        .MappingName = "Th_Name"
    '        .Alignment = HorizontalAlignment.Center
    '        '.ReadOnly = True
    '        .Width = 70
    '    End With
    '    With StkWH
    '        .HeaderText = "คลัง"
    '        .MappingName = "wh_Name"
    '        .Alignment = HorizontalAlignment.Left
    '        '.ReadOnly = True
    '        .Width = 80
    '    End With
    '    With stkStr
    '        .HeaderText = "ลูกค้า"
    '        .MappingName = "Ar_Name"
    '        .Alignment = HorizontalAlignment.Left
    '        '.ReadOnly = True
    '        .Width = 180
    '    End With
    '    With StkCode
    '        .HeaderText = "รหัสสินค้า"
    '        .MappingName = "Stk_Code"
    '        .Alignment = HorizontalAlignment.Center
    '        '.ReadOnly = True
    '        .Width = 170
    '    End With

    '    With StkName
    '        .HeaderText = "ชื่อ"
    '        .MappingName = "Stk_Name_1"
    '        ' .ReadOnly = True
    '        .Width = 250
    '    End With

    '    With StkQty
    '        .HeaderText = "คงเหลือ"
    '        .MappingName = "Dtl_Bal_Q1"
    '        .Alignment = HorizontalAlignment.Right
    '        .Format = "#,##0"
    '        ' .ReadOnly = True
    '        .Width = 75
    '    End With

    '    With StkFactor
    '        .HeaderText = "น้ำหนัก/แผ่น"
    '        .MappingName = "Stk_Factor"
    '        .Alignment = HorizontalAlignment.Right
    '        .Format = "#,##0.00"
    '        ' .ReadOnly = True
    '        .Width = 100
    '    End With
    '    With Q1
    '        .HeaderText = "น้ำหนักรวม"
    '        .MappingName = "w1"
    '        .Alignment = HorizontalAlignment.Right
    '        .Format = "#,##0.00"
    '        ' .ReadOnly = True
    '        .Width = 75
    '    End With

    '    With stkStrCode
    '        .HeaderText = "รหัสคลัง"
    '        .MappingName = "Dtl_Store"
    '        .Alignment = HorizontalAlignment.Right
    '        '.ReadOnly = True
    '        .Width = 200
    '    End With

    '    grdTS.GridColumnStyles.Add(StkWH) '0
    '    grdTS.GridColumnStyles.Add(stkStr) '1
    '    'grdTS.GridColumnStyles.Add(StkColor)
    '    'grdTS.GridColumnStyles.Add(stkThick)
    '    'grdTS.GridColumnStyles.Add(stkSize)
    '    grdTS.GridColumnStyles.Add(StkName) '2
    '    grdTS.GridColumnStyles.Add(StkFactor) '3
    '    grdTS.GridColumnStyles.Add(StkQty) '7
    '    grdTS.GridColumnStyles.Add(Q1) '5
    '    grdTS.GridColumnStyles.Add(StkCode) '6
    '    grdTS.GridColumnStyles.Add(stkStrCode) '7


    '    With dataShow

    '        .TableStyles.Clear()
    '        .CaptionText = "รายงานรายชื่อสินค้า"
    '        .FlatMode = True
    '        .TableStyles.Add(grdTS)
    '        '.Controls.Clear()
    '    End With

    'End Sub

    Private Sub cboSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.SelectedIndexChanged
        Dim subDS As New DataSet
        Dim subDa As New SqlClient.SqlDataAdapter

        ' Call showData(lbStkCode.Text)

        lbSize.Text = cboSize.Text
        txtSQL = "Select * "
        txtSQL &= "FRom SizeMast "
        txtSQL &= "Where Size_Name='" & cboSize.Text & "' "

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subDS, "SizeDB")
        If subDS.Tables("SizeDB").Rows.Count > 0 Then
            lbSizeID.Text = subDS.Tables("SizeDB").Rows(0).Item("Size_Code")
        End If


    End Sub

    Private Sub cboGrp_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrp.LostFocus
        lbGrpID.Text = cboGrp.SelectedValue

    End Sub

    Private Sub cboGrp_MouseCaptureChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrp.MouseCaptureChanged

    End Sub


    Private Sub cboGrp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrp.SelectedIndexChanged
        Dim subDa As New SqlClient.SqlDataAdapter
        Dim subds As New DataSet

        lbGrp.Text = cboGrp.Text

        txtSQL = "Select * "
        txtSQL &= "FRom GrpMast "
        txtSQL &= "Where Grp_Name='" & cboGrp.Text & "' "

        subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDa.Fill(subds, "GrpDB")
        If subds.Tables("GrpDB").Rows.Count > 0 Then
            lbGrpID.Text = subds.Tables("GrpDB").Rows(0).Item("Grp_Code")
        End If
    End Sub

    Private Sub cboTh_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTh.LostFocus
        lbThID.Text = cboTh.SelectedValue
    End Sub

    Private Sub cboTh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTh.SelectedIndexChanged
        lbTh.Text = cboTh.Text
        Dim subDa As New SqlClient.SqlDataAdapter
        Dim subDS As New DataSet


        ' Call showData(lbStkCode.Text)



        Try
            txtSQL = "Select * "
            txtSQL &= "FRom ThMast "
            txtSQL &= "Where Th_Th='" & cboTh.Text & "' "

            subDa = New SqlClient.SqlDataAdapter(txtSQL, Conn)
            subDa.Fill(subDS, "ThDB")
            If subDS.Tables("ThDB").Rows.Count > 0 Then
                lbThID.Text = subDS.Tables("ThDB").Rows(0).Item("Th_Code")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboPaper_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPaper.LostFocus
        lbPaperID.Text = cboPaper.SelectedValue

    End Sub

    Private Sub cboPaper_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaper.SelectedIndexChanged
        lbPaper.Text = cboPaper.Text
    End Sub

    Private Sub cboGrade_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles cboGrade.Layout

    End Sub

    Private Sub cboGrade_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrade.LostFocus
        lbGradeID.Text = cboGrade.SelectedValue
    End Sub

    Private Sub cboGrade_MarginChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboGrade.MarginChanged

    End Sub

    Private Sub cboGrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGrade.SelectedIndexChanged
        lbGrade.Text = cboGrade.Text
    End Sub


    Private Sub lbLenName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbLenName.Click

    End Sub

    Sub showDataDetail(stkCode As String)


        Dim subDA11 As New SqlClient.SqlDataAdapter
        Dim subDS11 As New DataSet

        ' Call txtCLS()
        txtSQL = "Select * "
        txtSQL &= "From BaseMast "
        txtSQL &= "Where Stk_Code='" & stkCode & "'"

        subDA11 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
        subDA11.Fill(subDS11, "StkMast0")



        'Call txtCLS()
        If Len(lbStkCode.Text) > 0 Then
            With subDS11.Tables("StkMast0").Rows(0)
                lbProDid.Text = .Item("stk_Prod")
                cboProdList.SelectedValue = lbProDid.Text
                Call selProd()
                lbTypeID.Text = .Item("Type_Code")
                lbGrpID.Text = .Item("Grp_Code")
                Call selType()



                lbColorID.Text = .Item("Color_Code")
                lbThID.Text = .Item("Th_Code")
                lbSizeID.Text = .Item("Size_Code")
                lbPaperID.Text = .Item("Paper_Code")
                lbGradeID.Text = .Item("G_Code")

                cboType.SelectedValue = lbTypeID.Text
                cboGrp.SelectedValue = lbGrpID.Text
                cboColor.SelectedValue = lbColorID.Text
                cboTh.SelectedValue = lbThID.Text
                cboSize.SelectedValue = lbSizeID.Text
                cboPaper.SelectedValue = lbPaperID.Text
                cboGrade.SelectedValue = lbGradeID.Text

                txtSQL = "Select  *  "
                txtSQL &= "From SizeMast "
                txtSQL &= "Where Size_Code='" & cboSize.SelectedValue & "' "
                subDA11 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                subDA11.Fill(subDS11, "SizeMast")


                txtSQL = "Select  *  From thMast "
                txtSQL &= "Where th_Code='" & cboTh.SelectedValue & "' "
                subDA11 = New SqlClient.SqlDataAdapter(txtSQL, Conn)
                subDA11.Fill(subDS11, "ThMast")

                lb01.Text = (subDS11.Tables("SizeMast").Rows(0).Item("Size_Width"))

                Dim dblTh As Double
                Dim dblWidth As Double
                Dim dblHeight As Double

                dblTh = subDS11.Tables("ThMast").Rows(0).Item("Th_Th")
                dblWidth = subDS11.Tables("SizeMast").Rows(0).Item("Size_Width")
                dblHeight = subDS11.Tables("SizeMast").Rows(0).Item("Size_Height")

                If IsDBNull(.Item("Stk_Prod")) Then
                    lbProDid.Text = ""

                Else
                    lbProDid.Text = .Item("Stk_Prod")
                End If


                If .Item("Stk_VAT") = 3 Then
                    optVAT.Checked = True
                ElseIf .Item("Stk_VAT") = 2 Then
                    optNVat.Checked = True
                ElseIf .Item("Stk_VAT") = 1 Then
                    optVatAll.Checked = True
                End If

                If IsDBNull(.Item("Stk_type")) Then
                    chkType2.Checked = True
                Else
                    If .Item("Stk_Type") = 1 Then
                        chkType1.Checked = True

                    ElseIf .Item("Stk_Type") = 0 Then
                        chkType0.Checked = True

                    End If
                End If


                txtStkName.Text = Trim(.Item("Stk_Name_1"))
                If IsDBNull(.Item("Stk_Find_Word")) Then
                    MsgBox("ปรับปรุง Stk_Find_Word ใหม่ โปรดกด Save หลังจากนี้")
                    lbFindWord.Text = ""
                Else
                    lbFindWord.Text = Trim(.Item("Stk_Find_Word"))
                End If

                If IsDBNull(.Item("Stk_PC_Name")) Then
                    MsgBox("ปรับปรุง Skt_PC_Name ใหม่ โปรดกด Save หลังจากนี้")
                    txtSemiFGName.Text = genNamePC()
                Else
                    txtSemiFGName.Text = Trim(.Item("Stk_PC_Name"))
                End If

                txtStkName2.Text = Trim(.Item("Stk_Name_2"))

                If IsDBNull(.Item("Stk_Code_PC")) Then

                    MsgBox("ปรับปรุง Stk_Code_PC ใหม่ โปรดกด Save หลังจากนี้")
                    txtPcCode.Text = cboType.SelectedValue & cboGrp.SelectedValue & cboColor.SelectedValue & cboTh.SelectedValue
                    txtStkCodeN.Text = cboType.SelectedValue & cboGrp.SelectedValue & cboColor.SelectedValue & cboTh.SelectedValue &
                    cboSize.SelectedValue & cboPaper.SelectedValue & cboGrade.SelectedValue

                Else
                    txtPcCode.Text = Trim(.Item("Stk_Code_PC"))
                    If IsDBNull(.Item("Stk_Code_N")) Then
                        txtStkCodeN.Text = ""
                    Else
                        txtStkCodeN.Text = Trim(.Item("Stk_Code_N"))
                    End If



                End If

                If cboType.SelectedValue = "02" Or cboType.SelectedValue = "01" Then
                    lbCutWeight.Text = calCutWeight(dblTh, dblWidth, dblHeight, getSG(cboType.SelectedValue)).ToString("#,###,###.####")
                    lbWeight.Text = lbCutWeight.Text
                Else

                    lbCutWeight.Text = Trim(Format(.Item("Stk_Factor"), "#,##0.00"))
                    lbWeight.Text = Trim(Format(.Item("Stk_Factor2"), "#,##0.00"))
                End If


            End With

        End If

        Call showData(lbStkCode.Text)

    End Sub

    Private Sub lbFindStk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbFindStk.Click
        ' Dim frmFindStk As New frmFindStk
        Dim subDA11 As New SqlClient.SqlDataAdapter
        Dim subDS11 As New DataSet


        frmFindStk.ShowDialog()
        lbStkCode.Text = SelectCode

        Call showDataDetail(SelectCode)


    End Sub



    Private Sub dataShow_CurrentCellChanged(sender As Object, e As EventArgs) Handles dataShow.CurrentCellChanged

    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
