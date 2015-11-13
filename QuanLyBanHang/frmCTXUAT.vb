Imports System.Data
Imports System.Data.SqlClient
Public Class frmCTXUAT
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
    Friend WithEvents Grb1 As System.Windows.Forms.GroupBox
    Friend WithEvents Grb2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button

    Friend WithEvents dgView As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbMAMH As System.Windows.Forms.ComboBox
    Friend WithEvents txtDONGIA As System.Windows.Forms.TextBox
    Friend WithEvents txtSOLUONG As System.Windows.Forms.TextBox
    Friend WithEvents dgCACMH As System.Windows.Forms.DataGrid
    Friend WithEvents txtTRIETKHAU As System.Windows.Forms.TextBox
    Friend WithEvents txtTONGGIATRI As System.Windows.Forms.TextBox
    Friend WithEvents txtNGAYBAN As System.Windows.Forms.TextBox
    Friend WithEvents txtSOHDBAN As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdSua As System.Windows.Forms.Button
    Friend WithEvents cmdTimKiem As System.Windows.Forms.Button
    Friend WithEvents cmdSuaMH As System.Windows.Forms.Button
    Friend WithEvents cbNam As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbThang As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbNgay As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents rAll As System.Windows.Forms.RadioButton
    Friend WithEvents rMa As System.Windows.Forms.RadioButton
    Friend WithEvents rNgay As System.Windows.Forms.RadioButton
    Friend WithEvents txtCTN As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTTMH As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTienSauTK As System.Windows.Forms.TextBox
    Friend WithEvents cmdClose2 As System.Windows.Forms.Button
    Friend WithEvents btnChiTiet As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCTXUAT))
        Me.Grb1 = New System.Windows.Forms.GroupBox()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.rAll = New System.Windows.Forms.RadioButton()
        Me.rMa = New System.Windows.Forms.RadioButton()
        Me.rNgay = New System.Windows.Forms.RadioButton()
        Me.txtCTN = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbNam = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbNgay = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnChiTiet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgView = New System.Windows.Forms.DataGrid()
        Me.cmdTimKiem = New System.Windows.Forms.Button()
        Me.cmdSua = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbMAMH = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSOLUONG = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDONGIA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTTMH = New System.Windows.Forms.TextBox()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.cmdClose2 = New System.Windows.Forms.Button()
        Me.txtTienSauTK = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgCACMH = New System.Windows.Forms.DataGrid()
        Me.txtTRIETKHAU = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTONGGIATRI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNGAYBAN = New System.Windows.Forms.TextBox()
        Me.txtSOHDBAN = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdSuaMH = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Grb1.SuspendLayout()
        Me.Grb2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCACMH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb1
        '
        Me.Grb1.Controls.Add(Me.GroupBox1)
        Me.Grb1.Controls.Add(Me.btnXoa)
        Me.Grb1.Controls.Add(Me.btnThem)
        Me.Grb1.Controls.Add(Me.cmdClose2)
        Me.Grb1.Controls.Add(Me.txtTienSauTK)
        Me.Grb1.Controls.Add(Me.Label11)
        Me.Grb1.Controls.Add(Me.PictureBox2)
        Me.Grb1.Controls.Add(Me.dgCACMH)
        Me.Grb1.Controls.Add(Me.txtTRIETKHAU)
        Me.Grb1.Controls.Add(Me.Label6)
        Me.Grb1.Controls.Add(Me.txtTONGGIATRI)
        Me.Grb1.Controls.Add(Me.Label5)
        Me.Grb1.Controls.Add(Me.Label3)
        Me.Grb1.Controls.Add(Me.txtNGAYBAN)
        Me.Grb1.Controls.Add(Me.txtSOHDBAN)
        Me.Grb1.Controls.Add(Me.lbName)
        Me.Grb1.Controls.Add(Me.lbID)
        Me.Grb1.Controls.Add(Me.cmdSave)
        Me.Grb1.Controls.Add(Me.cmdSuaMH)
        Me.Grb1.Controls.Add(Me.cmdBack)
        Me.Grb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grb1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb1.Location = New System.Drawing.Point(13, 20)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(703, 465)
        Me.Grb1.TabIndex = 4
        Me.Grb1.TabStop = False
        '
        'Grb2
        '
        Me.Grb2.Controls.Add(Me.rAll)
        Me.Grb2.Controls.Add(Me.rMa)
        Me.Grb2.Controls.Add(Me.rNgay)
        Me.Grb2.Controls.Add(Me.txtCTN)
        Me.Grb2.Controls.Add(Me.Label17)
        Me.Grb2.Controls.Add(Me.cbNam)
        Me.Grb2.Controls.Add(Me.Label16)
        Me.Grb2.Controls.Add(Me.cbThang)
        Me.Grb2.Controls.Add(Me.Label15)
        Me.Grb2.Controls.Add(Me.Label14)
        Me.Grb2.Controls.Add(Me.cbNgay)
        Me.Grb2.Controls.Add(Me.PictureBox1)
        Me.Grb2.Controls.Add(Me.btnChiTiet)
        Me.Grb2.Controls.Add(Me.Label1)
        Me.Grb2.Controls.Add(Me.dgView)
        Me.Grb2.Controls.Add(Me.cmdTimKiem)
        Me.Grb2.Controls.Add(Me.cmdSua)
        Me.Grb2.Controls.Add(Me.cmdDelete)
        Me.Grb2.Controls.Add(Me.cmdClose)
        Me.Grb2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb2.Location = New System.Drawing.Point(12, 20)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(730, 459)
        Me.Grb2.TabIndex = 5
        Me.Grb2.TabStop = False
        '
        'rAll
        '
        Me.rAll.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rAll.Location = New System.Drawing.Point(324, 118)
        Me.rAll.Name = "rAll"
        Me.rAll.Size = New System.Drawing.Size(114, 21)
        Me.rAll.TabIndex = 33
        Me.rAll.Text = "Chọn Tất Cả"
        '
        'rMa
        '
        Me.rMa.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMa.Location = New System.Drawing.Point(324, 87)
        Me.rMa.Name = "rMa"
        Me.rMa.Size = New System.Drawing.Size(133, 23)
        Me.rMa.TabIndex = 32
        Me.rMa.Text = "Tìm Theo Mã"
        '
        'rNgay
        '
        Me.rNgay.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rNgay.Location = New System.Drawing.Point(324, 58)
        Me.rNgay.Name = "rNgay"
        Me.rNgay.Size = New System.Drawing.Size(133, 23)
        Me.rNgay.TabIndex = 31
        Me.rNgay.Text = "Tìm Theo Ngày"
        '
        'txtCTN
        '
        Me.txtCTN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTN.Location = New System.Drawing.Point(174, 147)
        Me.txtCTN.Name = "txtCTN"
        Me.txtCTN.Size = New System.Drawing.Size(250, 23)
        Me.txtCTN.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(50, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(180, 21)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Mã Hoá Đơn Bán"
        '
        'cbNam
        '
        Me.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNam.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNam.Location = New System.Drawing.Point(156, 117)
        Me.cbNam.Name = "cbNam"
        Me.cbNam.Size = New System.Drawing.Size(73, 24)
        Me.cbNam.TabIndex = 28
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(50, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 22)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Năm"
        '
        'cbThang
        '
        Me.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThang.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbThang.Location = New System.Drawing.Point(156, 88)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(74, 24)
        Me.cbThang.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(50, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 22)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Tháng"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(50, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 21)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Ngày"
        '
        'cbNgay
        '
        Me.cbNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNgay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNgay.Location = New System.Drawing.Point(156, 59)
        Me.cbNgay.Name = "cbNgay"
        Me.cbNgay.Size = New System.Drawing.Size(74, 24)
        Me.cbNgay.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(117, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnChiTiet
        '
        Me.btnChiTiet.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChiTiet.Location = New System.Drawing.Point(405, 418)
        Me.btnChiTiet.Name = "btnChiTiet"
        Me.btnChiTiet.Size = New System.Drawing.Size(121, 26)
        Me.btnChiTiet.TabIndex = 16
        Me.btnChiTiet.Text = "Xem Chi Tiết"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(150, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 30)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Các Hoá Đơn Chứng Từ Bán Hàng"
        '
        'dgView
        '
        Me.dgView.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.dgView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgView.CaptionText = "Các Hoá Đơn Chứng Từ Bán Hàng"
        Me.dgView.DataMember = ""
        Me.dgView.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.GridLineColor = System.Drawing.Color.Maroon
        Me.dgView.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgView.Location = New System.Drawing.Point(2, 194)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(702, 204)
        Me.dgView.TabIndex = 14
        '
        'cmdTimKiem
        '
        Me.cmdTimKiem.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTimKiem.Location = New System.Drawing.Point(189, 417)
        Me.cmdTimKiem.Name = "cmdTimKiem"
        Me.cmdTimKiem.Size = New System.Drawing.Size(80, 27)
        Me.cmdTimKiem.TabIndex = 13
        Me.cmdTimKiem.Text = "&Tìm Kiếm"
        '
        'cmdSua
        '
        Me.cmdSua.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSua.Location = New System.Drawing.Point(81, 417)
        Me.cmdSua.Name = "cmdSua"
        Me.cmdSua.Size = New System.Drawing.Size(80, 27)
        Me.cmdSua.TabIndex = 12
        Me.cmdSua.Text = "&Sửa "
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(297, 417)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(80, 27)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "&Xoá Bỏ"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(542, 417)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(79, 27)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Đóng"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbMAMH)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSOLUONG)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDONGIA)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtTTMH)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 229)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Về Một Mặt Hàng"
        '
        'cbMAMH
        '
        Me.cbMAMH.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMAMH.Location = New System.Drawing.Point(9, 53)
        Me.cbMAMH.Name = "cbMAMH"
        Me.cbMAMH.Size = New System.Drawing.Size(175, 24)
        Me.cbMAMH.Sorted = True
        Me.cbMAMH.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 21)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Mã Mặt Hàng"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Số Lượng "
        '
        'txtSOLUONG
        '
        Me.txtSOLUONG.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSOLUONG.Location = New System.Drawing.Point(10, 104)
        Me.txtSOLUONG.Name = "txtSOLUONG"
        Me.txtSOLUONG.Size = New System.Drawing.Size(175, 23)
        Me.txtSOLUONG.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Đơn Giá"
        '
        'txtDONGIA
        '
        Me.txtDONGIA.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDONGIA.Location = New System.Drawing.Point(9, 148)
        Me.txtDONGIA.Name = "txtDONGIA"
        Me.txtDONGIA.Size = New System.Drawing.Size(178, 23)
        Me.txtDONGIA.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 177)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 22)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Thành Tiền"
        '
        'txtTTMH
        '
        Me.txtTTMH.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTTMH.Location = New System.Drawing.Point(9, 199)
        Me.txtTTMH.Name = "txtTTMH"
        Me.txtTTMH.Size = New System.Drawing.Size(179, 23)
        Me.txtTTMH.TabIndex = 30
        '
        'btnXoa
        '
        Me.btnXoa.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoa.Location = New System.Drawing.Point(324, 423)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(80, 27)
        Me.btnXoa.TabIndex = 35
        Me.btnXoa.Text = "Xoá"
        '
        'btnThem
        '
        Me.btnThem.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThem.Location = New System.Drawing.Point(123, 423)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(79, 28)
        Me.btnThem.TabIndex = 34
        Me.btnThem.Text = "Thêm"
        '
        'cmdClose2
        '
        Me.cmdClose2.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose2.Location = New System.Drawing.Point(604, 423)
        Me.cmdClose2.Name = "cmdClose2"
        Me.cmdClose2.Size = New System.Drawing.Size(79, 27)
        Me.cmdClose2.TabIndex = 33
        Me.cmdClose2.Text = "Đóng"
        '
        'txtTienSauTK
        '
        Me.txtTienSauTK.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTienSauTK.Location = New System.Drawing.Point(426, 385)
        Me.txtTienSauTK.Name = "txtTienSauTK"
        Me.txtTienSauTK.Size = New System.Drawing.Size(145, 23)
        Me.txtTienSauTK.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(232, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(188, 22)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Tiền Mặt Hàng Sau Chiết Khấu"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(102, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(36, 30)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'dgCACMH
        '
        Me.dgCACMH.CaptionFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCACMH.CaptionText = "Danh Sách Các Mặt Hàng Trong Hoá Đơn"
        Me.dgCACMH.DataMember = ""
        Me.dgCACMH.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgCACMH.GridLineColor = System.Drawing.Color.Maroon
        Me.dgCACMH.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCACMH.Location = New System.Drawing.Point(235, 145)
        Me.dgCACMH.Name = "dgCACMH"
        Me.dgCACMH.Size = New System.Drawing.Size(453, 229)
        Me.dgCACMH.TabIndex = 19
        '
        'txtTRIETKHAU
        '
        Me.txtTRIETKHAU.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTRIETKHAU.Location = New System.Drawing.Point(74, 388)
        Me.txtTRIETKHAU.Name = "txtTRIETKHAU"
        Me.txtTRIETKHAU.Size = New System.Drawing.Size(124, 23)
        Me.txtTRIETKHAU.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Chiết Khấu"
        '
        'txtTONGGIATRI
        '
        Me.txtTONGGIATRI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTONGGIATRI.Location = New System.Drawing.Point(174, 96)
        Me.txtTONGGIATRI.Name = "txtTONGGIATRI"
        Me.txtTONGGIATRI.Size = New System.Drawing.Size(230, 23)
        Me.txtTONGGIATRI.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 99)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tổng Giá Trị Của Hoá Đơn"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(144, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(445, 37)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Thông Tin Chi Tiết Một Chứng từ Bán Hàng"
        '
        'txtNGAYBAN
        '
        Me.txtNGAYBAN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNGAYBAN.Location = New System.Drawing.Point(521, 53)
        Me.txtNGAYBAN.Name = "txtNGAYBAN"
        Me.txtNGAYBAN.Size = New System.Drawing.Size(167, 23)
        Me.txtNGAYBAN.TabIndex = 11
        '
        'txtSOHDBAN
        '
        Me.txtSOHDBAN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSOHDBAN.Location = New System.Drawing.Point(174, 54)
        Me.txtSOHDBAN.Name = "txtSOHDBAN"
        Me.txtSOHDBAN.Size = New System.Drawing.Size(230, 23)
        Me.txtSOHDBAN.TabIndex = 10
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(452, 57)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(65, 17)
        Me.lbName.TabIndex = 8
        Me.lbName.Text = "Ngày Bán"
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(28, 59)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(108, 15)
        Me.lbID.TabIndex = 7
        Me.lbID.Text = "Số Hoá Đơn Bán"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(22, 423)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(78, 28)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "Lưu"
        '
        'cmdSuaMH
        '
        Me.cmdSuaMH.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuaMH.Location = New System.Drawing.Point(224, 424)
        Me.cmdSuaMH.Name = "cmdSuaMH"
        Me.cmdSuaMH.Size = New System.Drawing.Size(78, 27)
        Me.cmdSuaMH.TabIndex = 2
        Me.cmdSuaMH.Text = "&Sửa"
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(504, 422)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(80, 28)
        Me.cmdBack.TabIndex = 8
        Me.cmdBack.Text = "Quay Lại"
        '
        'frmCTXUAT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(984, 550)
        Me.Controls.Add(Me.Grb2)
        Me.Controls.Add(Me.Grb1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCTXUAT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Các Hoá Đơn Chứng Từ Bán Hàng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Grb1.ResumeLayout(False)
        Me.Grb1.PerformLayout()
        Me.Grb2.ResumeLayout(False)
        Me.Grb2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCACMH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim iRscount As Integer
    Dim sConnString = strconn
    Dim mySQLConnection As New SqlConnection(sConnString)
    ' chu y ten cua txtCTN (thuc ra can dat la txtSOHDBAN- ten cua textbox cho 
    'nguoi dung nhap vao khi tim kiem) do dat nham. Vi ko muon sua ma nen khong dat lai.

    ' hai bien nay luu soluong va don gia cua mat hang can sua chua
    Dim xOldDG As Decimal = 0
    Dim xOldSL As Byte = 0
    Dim xOldTT As Decimal = 0
    Dim xOldVT As Integer = 0

    Dim xTienMH As Decimal = 0
    'bien nay luu lai ma cua SOHDBAN can sua
    Dim xMa As String = ""
    'bien luu ma cua mat hang can sua 
    Dim xMaMH As String = ""

    ' ham kiem tra xem khi them moi mot mat hang vao hoa don no da ton tai chua. neu ton
    ' taithi bao loi
    Function checkItem(ByVal code As String) As Boolean
        Dim myconn As New SqlConnection(strconn)
        Dim Tg As String = ""
        Dim readcmd As New SqlCommand("select * from tblBAN where MAMH='" & code & "' and SOHDBAN='" & Me.txtSOHDBAN.Text & "'", myconn)
        Try
            myconn.Open()
            Dim drsqlreader As SqlDataReader = readcmd.ExecuteReader
            Do While drsqlreader.Read()
                Tg = drsqlreader.GetString(1)
            Loop

            If Tg <> "" Then
                checkItem = False
            Else
                checkItem = True
            End If
            drsqlreader.Close()
        Catch
            MessageBox.Show("Không thể đọc được dữ liệu từ bảng tblBAN để kiểm tra . Bạn hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If myconn.State = ConnectionState.Open Then
                myconn.Close()
            End If
        End Try

    End Function



    ' ham kiem tra xem khi sua mot mat hang thi ten cua no da ton tai chua neu ton tai 
    ' roi thi bao loi
    Private Function exitItem(ByVal xDK As String) As Boolean
        Dim VT As Integer = 0
        Dim xTg As String = ""
        Dim xok As Boolean = False
        VT = xOldVT - 1
        While VT >= 0
            xTg = ""
            xTg = Me.dgCACMH.Item(VT, 1)
            If xDK = xTg Then
                xok = True
                Exit While
            End If
            VT = VT - 1
        End While

        If xok = False Then
            VT = 0
            VT = xOldVT
            VT = VT + 1
            While VT <= Me.BindingContext(dsDataSet, "tblBAN").Count - 1
                xTg = ""
                xTg = Me.dgCACMH.Item(VT, 1)
                If xDK = xTg Then
                    xok = True
                    Exit While
                End If
                VT = VT + 1
            End While
        End If
        exitItem = xok

    End Function

    Private Sub fillcbDate()
        Me.cbNgay.Items.Clear()
        Me.cbThang.Items.Clear()
        Me.cbNam.Items.Clear()
        Dim i As Integer
        For i = 1 To 31
            Me.cbNgay.Items.Add(i)
        Next
        For i = 1 To 12
            Me.cbThang.Items.Add(i)
        Next
        For i = 2000 To 2010
            Me.cbNam.Items.Add(i)
        Next
    End Sub

    Function SplitCode(ByVal ch As String)
        Dim xcode As String = ""
        Dim len As Integer = 0
        Dim leng As Integer = 0
        If ch = "MH" Then
            len = InStr(Me.cbMAMH.Text, "--")
            leng = Microsoft.VisualBasic.Len(Me.cbMAMH.Text)
            If len > 1 Then
                xcode = Microsoft.VisualBasic.Right(Me.cbMAMH.Text, leng - len - 1)
            Else
                xcode = Me.cbMAMH.Text
            End If
            SplitCode = xcode
            Exit Function
        End If

    End Function

    Private Sub fillDG(ByVal dieukien As String)
        Dim st As String = ""
        st = "Select SOHDBAN as [Số Hoá Đơn Bán],MAMH as [Mã Mặt Hàng],(select TENMH from tblMATHANG where MAMH=tblBAN.MAMH)as [Tên Mặt Hàng],SOLUONG as [Số Lượng],DONGIA as [Đơn Giá] from  tblBAN where SOHDBAN='" & dieukien & "'"

        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter2 = New SqlClient.SqlDataAdapter(st, sqlConn)
        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder
        sqlCmdBuilder = New SqlClient.SqlCommandBuilder(sqlDataAdapter2)
        Me.dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "tblBAN")
        With dgCACMH
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "tblBAN")
        End With
    End Sub


    Private Sub GetData()
        Dim str As String = ""
        str = "Select SOHDBAN as [Số Hoá Đơn Bán],NGAYBAN as [Ngày Bán],TONGGIATRI as [Tổng Giá Trị],TRIETKHAU as [Triết Khấu] from tblHDBAN"
        If Me.rNgay.Checked = True Then
            If Me.cbNgay.Text <> "" Then
                str = str & " where day(NGAYBAN)='" & Me.cbNgay.Text & "'"
            End If
            If Me.cbThang.Text <> "" Then
                If Me.cbNgay.Text <> "" Then
                    str = str & " and month(NGAYBAN)='" & Me.cbThang.Text & "'"
                Else
                    str = str & " where month(NGAYBAN)='" & Me.cbThang.Text & "'"
                End If
            End If

            If Me.cbNam.Text <> "" Then
                If Me.cbNgay.Text = "" And Me.cbThang.Text = "" Then
                    str = str & " where year(NGAYBAN)=" & Me.cbNam.Text & ""
                Else
                    str = str & " and year(NGAYBAN)=" & Me.cbNam.Text & ""
                End If
            End If
        End If
        If Me.rMa.Checked = True Then
            str = str & " where SOHDBAN='" & Me.txtCTN.Text & "'"
        End If

        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter2 = _
            New SqlClient.SqlDataAdapter(str, sqlConn)
        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder
        sqlCmdBuilder = _
            New SqlClient.SqlCommandBuilder(sqlDataAdapter2)
        Me.dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "tblHDBAN")

        With dgView
            '.ReadOnly = False
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "tblHDBAN")
        End With
    End Sub

    Private Sub fillcombo(ByVal st As String, ByVal obj As String)
        Dim sConnString = strconn
        Dim mySQLConnection As New SqlConnection(sConnString)
        Dim xma As String = ""
        Dim xten As String = ""
        Dim sqlcmd As SqlCommand = New SqlCommand(st, mySQLConnection)
        Try
            mySQLConnection.Open()
            Dim drReader As SqlDataReader
            drReader = sqlcmd.ExecuteReader()
            If obj = "MAMH" Then
                Do While drReader.Read()
                    xma = ""
                    xten = ""
                    xma = drReader.GetString(0)
                    xten = drReader.GetString(1)
                    Me.cbMAMH.Items.Add(xten & "--" & xma)
                Loop
            End If
            drReader.Close()
            sqlcmd.Dispose()
        Catch
            MsgBox("Không Thể Đọc Được Dữ liệu !", MsgBoxStyle.Information, "Thông Báo !")
        Finally
            If mySQLConnection.State = ConnectionState.Open Then
                mySQLConnection.Close()
            End If
        End Try
    End Sub

    Dim mySQLDataAdapter As New SqlDataAdapter("Select * from tblHDBAN", mySQLConnection)
    Dim myDataSet As DataSet = New DataSet()

    Dim sqlCmdBuilder As SqlCommandBuilder

    Dim sqlDataAdapter2 As SqlClient.SqlDataAdapter
    Dim dsDataSet As New DataSet()
    Private Sub updateData(ByVal xstr As String)
        Dim sqlcmd As New SqlCommand(xstr, mySQLConnection)
        Try
            mySQLConnection.Open()
            sqlcmd.ExecuteNonQuery()
        Catch myException As Exception
            MessageBox.Show("Không Thể Lưu Những Thông Tin Bạn Vừa Thay Đổi. Hãy Thử Lại !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally

            If (mySQLConnection.State = ConnectionState.Open) Then
                mySQLConnection.Close()
            End If
        End Try
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Me.cmdSave.Text = "Cập Nhật" Then
            If Me.txtSOLUONG.Text = "" AndAlso Me.txtDONGIA.Text = "" Then
                MessageBox.Show("Bạn Hãy Chọn Một Mặt Hàng Trong Danh Sách, Sau Đó Kích Vào Nút Sửa !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            If Me.cbMAMH.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Tên Của Mặt Hàng Cần Lưu !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cbMAMH.Focus()
                Exit Sub
            End If
            If IsNumeric(Me.txtSOLUONG.Text) = False Then
                MessageBox.Show("Số Lượng Mặt Hàng Phải Là Kiểu Số. Bạn Hãy Thử Lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtSOLUONG.Focus()
                Exit Sub
            End If
            If IsNumeric(Me.txtDONGIA.Text) = False Then
                MessageBox.Show("Đơn Giá Mặt Hàng Phải Là Kiểu Số. Bạn Hãy Thử Lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDONGIA.Focus()
                Exit Sub
            End If
            If IsNumeric(Me.txtTTMH.Text) = False Then
                MessageBox.Show("Thành Tiền Của Mặt Hàng Phải Là Kiểu Số. Bạn Hãy Thử Lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTTMH.Focus()
                Exit Sub
            End If
            If IsNumeric(Me.txtTienSauTK.Text) = False Then
                MessageBox.Show("Thành Tiền Sau Triết Khấu Của Mặt Hàng Phải Là Kiểu Số. Bạn Hãy Thử Lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTienSauTK.Focus()
                Exit Sub
            End If
            If IsDate(Me.txtNGAYBAN.Text) = False Then
                MessageBox.Show("Dữ Liệu Không Phải Kiểu Ngày. Bạn Hãy Sửa Lại", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNGAYBAN.Focus()
                Exit Sub
            Else
                If checkDate(Me.txtNGAYBAN.Text) <> 2 Then
                    MessageBox.Show("Bạn hãy nhập đúng định dạng ngày theo kiểu : Ngày/Tháng/Năm .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNGAYBAN.Focus()
                    Exit Sub
                End If

            End If

            If exitItem(SplitCode("MH")) = True Then
                MessageBox.Show("Tên Mặt hàng này đã tồn tại trong danh sách các mặt hàng. Bạn hãy sửa lại tên mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim xTam1 As Decimal = 0
                xTam1 = Me.txtTONGGIATRI.Text
                Me.txtTONGGIATRI.Text = xTam1 - Me.txtTienSauTK.Text + xOldTT

                Me.cbMAMH.Focus()
                Exit Sub
            End If

            Dim sqlcmd1 As New SqlCommand("update tblHDBAN set NGAYBAN='" & Me.txtNGAYBAN.Text & "',TONGGIATRI='" & Me.txtTONGGIATRI.Text & "' where SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
            Dim sqlcmd2 As SqlCommand = New SqlCommand("update tblBAN set MAMH='" & SplitCode("MH") & "',SOLUONG='" & Me.txtSOLUONG.Text & "',DONGIA='" & Me.txtDONGIA.Text & "' where MAMH='" & xMaMH & "' and SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                sqlcmd1.ExecuteNonQuery()
                sqlcmd2.ExecuteNonQuery()
            Catch myException As Exception
                MessageBox.Show("Không Thể Lưu Những Thông Tin Bạn Vừa Thay Đổi. Hãy Thử Lại !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try
            Dim xDK As String = ""
            xDK = Me.dgCACMH.Item(Me.dgCACMH.CurrentCell.RowNumber, 0)
            Call fillDG(xDK)
            Me.txtSOLUONG.Text = ""
            Me.txtDONGIA.Text = ""
            Me.txtTTMH.Text = ""
            Me.txtTienSauTK.Text = ""
            Me.cbMAMH.Text = ""
            Me.cmdSave.Text = "Lưu"
        Else
            If Me.cbMAMH.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Tên Của Mặt Hàng Cần Lưu !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cbMAMH.Focus()
                Exit Sub
            End If
            If IsNumeric(Me.txtSOLUONG.Text) = False Then
                MessageBox.Show("Số Lượng Mặt Hàng Phải Là Kiểu Số. Bạn Hãy Thử Lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtSOLUONG.Focus()
                Exit Sub
            End If
            If IsNumeric(Me.txtDONGIA.Text) = False Then
                MessageBox.Show("Đơn Giá Mặt Hàng Phải Là Kiểu Số. Bạn Hãy Thử Lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDONGIA.Focus()
                Exit Sub
            End If
            If IsNumeric(Me.txtTTMH.Text) = False Then
                MessageBox.Show("Thành Tiền Của Mặt Hàng Phải Là Kiểu Số. Bạn Hãy Thử Lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTTMH.Focus()
                Exit Sub
            End If
            If IsNumeric(Me.txtTienSauTK.Text) = False Then
                MessageBox.Show("Thành Tiền Sau Triết Khấu Của Mặt Hàng Phải Là Kiểu Số. Bạn Hãy Thử Lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTienSauTK.Focus()
                Exit Sub
            End If

            If IsDate(Me.txtNGAYBAN.Text) = False Then
                MessageBox.Show("Dữ Liệu Không Phải Kiểu Ngày. Bạn Hãy Sửa Lại", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNGAYBAN.Focus()
                Exit Sub
            Else
                If checkDate(Me.txtNGAYBAN.Text) <> 2 Then
                    MessageBox.Show("Bạn hãy nhập đúng định dạng ngày theo kiểu : Ngày/Tháng/Năm .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNGAYBAN.Focus()
                    Exit Sub
                End If
            End If
            If checkItem(SplitCode("MH")) = False Then
                MessageBox.Show("Mặt hàng này đã tồn tại trong danh sách các mặt hàng. Bạn hãy sửa lại tên của mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim xTam As Decimal = 0
                xTam = Me.txtTONGGIATRI.Text
                Me.txtTONGGIATRI.Text = xTam - Me.txtTienSauTK.Text
                Me.txtSOLUONG.Text = ""
                Me.txtDONGIA.Text = ""
                Me.txtTTMH.Text = ""
                Me.txtTienSauTK.Text = ""
                Me.cbMAMH.Focus()
                Exit Sub
            End If
            Dim conn As New SqlConnection(strconn)
            Dim xCheck As Boolean = True
            Dim sqlcmd1 As New SqlCommand("insert into tblBAN(SOHDBAN,MAMH,SOLUONG,DONGIA) values('" & Me.txtSOHDBAN.Text & "','" & SplitCode("MH") & "'," & Me.txtSOLUONG.Text & "," & Me.txtDONGIA.Text & ")", conn)
            Dim sqlcmd2 As New SqlCommand("update tblHDBAN set NGAYBAN='" & Me.txtNGAYBAN.Text & "',TONGGIATRI=" & Me.txtTONGGIATRI.Text & "' where SOHDBAN='" & Me.txtSOHDBAN.Text & "'", conn)
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                sqlcmd1.ExecuteNonQuery()
                sqlcmd2.ExecuteNonQuery()
            Catch
                MessageBox.Show("Lỗi, Không Thể Lưu Được Thông Tin. Hãy Thử Lại !. ", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                xCheck = False
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
            If xCheck = True Then
                Me.cbMAMH.Text = ""
                Me.txtDONGIA.Text = ""
                Me.txtSOLUONG.Text = ""
                Me.txtTienSauTK.Text = ""
                Me.txtTTMH.Text = ""
                Call fillDG(Me.txtSOHDBAN.Text)
                Me.cbMAMH.Focus()
            Else
                Me.cmdSave.Focus()
            End If

        End If
        Me.cbMAMH.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim No = dgView.Item(dgView.CurrentCell.RowNumber, 0)

        If MsgBox("Bạn Có Thật Sự Muốn Xoá " & No & " Hay Không ?", MsgBoxStyle.YesNo, "Thông Báo !") = MsgBoxResult.Yes Then
            Call delItem2("tblHDBAN", "SOHDBAN", No, "Số Hoá Đơn Bán Hàng ")
            Call delItem2("tblBAN", "SOHDBAN", No, "Số Hoá Đơn Bán Hàng")
        End If
        GetData()
    End Sub
    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Me.Grb2.Visible = True
        Me.Grb1.Visible = False
        GetData()
        Me.txtSOHDBAN.Enabled = True
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub
    Private Sub frmCTXUAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call fillcbDate()
        Me.rAll.Checked = True
        GetData()

        iRscount = Me.BindingContext(dsDataSet, "tblHDBAN").Count

        If power = "NHAP" Or power = "BAN" Then
            Me.cmdSua.Enabled = False
            'Me.cmdTimKiem.Enabled = False
            Me.cmdDelete.Enabled = False
        End If
        Call fillcombo("select * from tblMATHANG", "MAMH")
    End Sub

    Private Sub cmdSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSua.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.cbMAMH.DropDownStyle = ComboBoxStyle.DropDown
        Me.txtTTMH.Enabled = True
        Me.txtTienSauTK.Enabled = True
        xMa = ""
        xMa = Me.dgView.Item(Me.dgView.CurrentCell.RowNumber, 0)
        Dim result As Integer = MessageBox.Show("Bạn Có Thật Sự Muốn Sửa Chữa Hoá Đơn Bán " & xMa & " Hay Không ?", "Thông báo !", MessageBoxButtons.YesNoCancel)
        If result = MsgBoxResult.Yes Then
            Me.Grb1.Visible = True
            Me.Grb2.Visible = False

            Me.txtSOHDBAN.Text = xMa
            Me.txtSOHDBAN.Enabled = False
            Me.txtNGAYBAN.Text = Me.dgView.Item(Me.dgView.CurrentCell.RowNumber, 1)
            Me.txtTONGGIATRI.Text = CDbl(Me.dgView.Item(Me.dgView.CurrentCell.RowNumber, 2))

            Me.txtTRIETKHAU.Text = CDbl(Me.dgView.Item(Me.dgView.CurrentCell.RowNumber, 3))
            Call fillDG(xMa)
            Me.txtSOLUONG.Text = ""
            Me.txtDONGIA.Text = ""
            Me.txtTTMH.Text = ""
            Me.txtTienSauTK.Text = ""
            Me.cbMAMH.Text = ""
            Me.txtTONGGIATRI.Enabled = False
            Me.txtTRIETKHAU.Enabled = False
            Me.cmdSuaMH.Enabled = True
            Me.cmdSave.Enabled = True
            Me.btnThem.Enabled = True
            Me.btnXoa.Enabled = True
            'Me.cbNV.DropDownStyle = ComboBoxStyle.DropDownList


        Else
            Exit Sub
        End If

    End Sub

    Private Sub cmdTimKiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTimKiem.Click
        GetData()
    End Sub

    Private Sub cmdSuaMH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuaMH.Click

        If Me.dgCACMH.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.cbMAMH.DropDownStyle = ComboBoxStyle.DropDown
        Me.txtTTMH.Enabled = False
        Me.txtTienSauTK.Enabled = False
        Dim xTg As Decimal = 0
        xOldDG = 0
        xOldSL = 0
        xOldVT = 0
        xOldVT = Me.dgCACMH.CurrentCell.RowNumber
        xOldDG = Me.dgCACMH.Item(Me.dgCACMH.CurrentCell.RowNumber, 4)
        xOldSL = Me.dgCACMH.Item(Me.dgCACMH.CurrentCell.RowNumber, 3)
        xTg = xOldSL * xOldDG

        xOldTT = xTg - xTg * Me.txtTRIETKHAU.Text

        xMaMH = Me.dgCACMH.Item(Me.dgCACMH.CurrentCell.RowNumber, 1)
        Me.cbMAMH.Text = xMaMH
        Me.txtSOLUONG.Text = Me.dgCACMH.Item(Me.dgCACMH.CurrentCell.RowNumber, 3)
        Me.txtDONGIA.Text = Me.dgCACMH.Item(Me.dgCACMH.CurrentCell.RowNumber, 4)
        Me.txtTTMH.Text = xTg
        If Me.txtTRIETKHAU.Text = 0 Then
            Me.txtTienSauTK.Text = xTg
        Else
            Me.txtTienSauTK.Text = xOldTT
        End If

        If Me.cmdSave.Text = "Lưu" Then
            Me.cmdSave.Text = "Cập Nhật"
        End If
        Me.cbMAMH.Focus()
    End Sub

    Private Sub rNgay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rNgay.CheckedChanged
        Me.cbNgay.Enabled = True
        Me.cbThang.Enabled = True
        Me.cbNam.Enabled = True
        Me.txtCTN.Enabled = False
        Me.cbNgay.Text = ""
        Me.cbThang.Text = ""
        Me.cbNam.Text = ""
        iRscount = Me.BindingContext(dsDataSet, "tblHDBAN").Count
    End Sub

    Private Sub rMa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rMa.CheckedChanged
        Me.txtCTN.Text = ""
        Me.cbNgay.Enabled = False
        Me.cbThang.Enabled = False
        Me.cbNam.Enabled = False
        Me.txtCTN.Enabled = True
        iRscount = Me.BindingContext(dsDataSet, "tblHDBAN").Count
    End Sub

    Private Sub rAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rAll.CheckedChanged
        Me.cbNgay.Text = ""
        Me.cbThang.Text = ""
        Me.cbNam.Text = ""
        Me.txtCTN.Text = ""
        Me.cbNgay.Enabled = False
        Me.cbThang.Enabled = False
        Me.cbNam.Enabled = False
        Me.txtCTN.Enabled = False
        GetData()
        iRscount = Me.BindingContext(dsDataSet, "tblHDBAN").Count
    End Sub

    Private Sub cbNgay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNgay.SelectedIndexChanged
        If IsNumeric(Me.cbNgay.Text) = False Then
            MessageBox.Show("Dữ liệu kiểu ngày phải là một số nguyên lớn hơn 0 và nhỏ hơn hoặc bằng 31. Bạn hãy sửa lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbNgay.Focus()
            Exit Sub
        Else
            If CInt(Me.cbNgay.Text) < 0 Or CInt(Me.cbNgay.Text) > 32 Then
                MessageBox.Show("Dữ liệu kiểu ngày phải là một số nguyên lớn hơn 0 và nhỏ hơn hoặc bằng 31. Bạn hãy sửa lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cbNgay.Focus()
                Exit Sub
            End If
        End If
        GetData()
        iRscount = Me.BindingContext(dsDataSet, "tblHDBAN").Count
    End Sub

    Private Sub cbThang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbThang.SelectedIndexChanged
        GetData()
        iRscount = Me.BindingContext(dsDataSet, "tblHDBAN").Count

    End Sub

    Private Sub cbNam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNam.SelectedIndexChanged
        GetData()
        iRscount = Me.BindingContext(dsDataSet, "tblHDBAN").Count

    End Sub

    Private Sub txtCTN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCTN.KeyPress
        If e.KeyChar = Chr(13) Then
            GetData()
            iRscount = Me.BindingContext(dsDataSet, "tblHDBAN").Count
        End If
    End Sub

    Private Sub txtDONGIA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDONGIA.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTienSauTK.Enabled = False
            Me.txtTTMH.Enabled = False
            If Me.cmdSave.Text = "Cập Nhật" Then
                If IsNumeric(Me.txtSOLUONG.Text) = True And Len(Me.txtSOLUONG.Text) <= 9 Then
                    If IsNumeric(Me.txtDONGIA.Text) = True Then

                        If Len(Me.txtDONGIA.Text) > 9 Then
                            MessageBox.Show("Giá trị số của đơn giá là quá lớn. Bạn hãy sửa lại. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.txtDONGIA.Focus()
                            Exit Sub
                        Else
                            'bien luu giu gia tri tong tien cu cua hoa don
                            Dim xTongtien As Decimal = 0
                            'bien luu triet khau
                            Dim xTrietkhau As Decimal = 0
                            xTrietkhau = Me.txtTRIETKHAU.Text
                            xTongtien = Me.txtTONGGIATRI.Text

                            Me.txtTTMH.Text = Me.txtSOLUONG.Text * Me.txtDONGIA.Text

                            If Me.txtTRIETKHAU.Text = 0 Then
                                Me.txtTienSauTK.Text = Me.txtTTMH.Text
                            Else
                                Dim xtg As Decimal = 0
                                xtg = Me.txtTTMH.Text
                                Me.txtTienSauTK.Text = xtg - xtg * Me.txtTRIETKHAU.Text
                            End If
                            Me.txtTONGGIATRI.Text = ""
                            Me.txtTONGGIATRI.Text = xTongtien - xOldTT + Me.txtTienSauTK.Text
                            Me.cmdSave.Focus()
                        End If

                    Else
                        MessageBox.Show("Đơn Giá Phải Là Kiểu Số và có chiều dài không quá 9 chữ số. Bạn Hãy Nhập Đúng Kiểu Dữ Liệu !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtDONGIA.Focus()
                    End If
                Else
                    MessageBox.Show("Dữ Liệu Không Hợp Lệ, Số Lượng Phải Là Kiểu Số Và Có Chiều Dài Không Quá 9 Chữ Số . Hãy Sửa Lại", "Thông Báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtSOLUONG.Focus()
                    Exit Sub
                End If
            Else
                If IsNumeric(Me.txtDONGIA.Text) = True Then
                    If Len(Me.txtDONGIA.Text) > 9 Then
                        MessageBox.Show("Giá trị số của đơn giá là quá lớn. Bạn hãy sửa lại. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtDONGIA.Focus()
                        Exit Sub
                    Else
                        If IsNumeric(Me.txtSOLUONG.Text) = True Then
                            If Len(Me.txtSOLUONG.Text) <= 9 Then
                                Dim xTam As Decimal = 0
                                xTam = Me.txtDONGIA.Text * Me.txtSOLUONG.Text
                                Me.txtTTMH.Text = xTam
                                Me.txtTienSauTK.Text = xTam - xTam * Me.txtTRIETKHAU.Text
                                xTam = 0
                                xTam = Me.txtTONGGIATRI.Text
                                Me.txtTONGGIATRI.Text = xTam + Me.txtTienSauTK.Text
                                Me.cmdSave.Focus()
                            Else
                                MessageBox.Show("Giá trị số của số lượng là quá lớn. Bạn hãy sửa lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.txtSOLUONG.Focus()
                                Exit Sub
                            End If
                        Else
                            MessageBox.Show("Giá trị của số lưọng không hợp lệ. Bạn hãy sửa lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.txtSOLUONG.Focus()
                            Exit Sub
                        End If
                    End If
                Else
                    MessageBox.Show("Dữ Liệu Không Hợp Lệ. Đơn Giá Phải Là Kiểu Số. Hãy Sửa Lại. ", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cmdSave.Focus()
                    Exit Sub
                End If

            End If
        End If

    End Sub

    Private Sub txtSOLUONG_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSOLUONG.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSOLUONG.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết số lượng của mặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtSOLUONG.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtSOLUONG.Text) = False Then
                    MessageBox.Show("Số Lượng Phải Là Kiểu Số. Bạn Hãy Nhập Đúng Kiểu Dữ Liệu", " Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtSOLUONG.Focus()
                    Exit Sub
                Else
                    If Len(Me.txtSOLUONG.Text) > 9 Then
                        MessageBox.Show("Giá trị của số của số lượng mặt hàng quá lớn. Bạn hãy sửa lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtSOLUONG.Focus()
                        Exit Sub
                    End If
                End If
            End If
            Me.txtDONGIA.Focus()
        End If
    End Sub

    Private Sub cbMAMH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbMAMH.KeyPress
        If e.KeyChar = "D" Or e.KeyChar = "d" Then
            Me.cbMAMH.DroppedDown = True
        End If
        If e.KeyChar = Chr(13) Then
            If Me.cbMAMH.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết tên của mặt hàng !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cbMAMH.Focus()
                Exit Sub
            End If
            Me.txtSOLUONG.Focus()
        End If
    End Sub

    Private Sub cmdClose2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose2.Click
        Me.Hide()
    End Sub

    Private Sub btnChiTiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiTiet.Click

        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        xMa = ""
        xMa = Me.dgView.Item(Me.dgView.CurrentCell.RowNumber, 0)
        Me.Grb1.Visible = True
        Me.Grb2.Visible = False

        Me.txtSOHDBAN.Text = xMa
        Me.txtSOHDBAN.Enabled = True
        Me.txtNGAYBAN.Text = Me.dgView.Item(Me.dgView.CurrentCell.RowNumber, 1)
        Me.txtTONGGIATRI.Text = CDbl(Me.dgView.Item(Me.dgView.CurrentCell.RowNumber, 2))

        Me.txtTRIETKHAU.Text = CDbl(Me.dgView.Item(Me.dgView.CurrentCell.RowNumber, 3))
        Call fillDG(xMa)
        Me.txtSOLUONG.Text = ""
        Me.txtDONGIA.Text = ""
        Me.txtTTMH.Text = ""
        Me.txtTienSauTK.Text = ""
        Me.cbMAMH.Text = ""
        Me.txtTONGGIATRI.Enabled = True
        Me.txtTRIETKHAU.Enabled = True
        Me.txtTienSauTK.Enabled = True
        Me.txtTTMH.Enabled = True

        Me.cmdSuaMH.Enabled = False
        Me.cmdSave.Enabled = False
        Me.btnThem.Enabled = False
        Me.btnXoa.Enabled = False
    End Sub


    Private Sub btnXoa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnXoa.Click

        If Me.dgCACMH.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim xx As String = ""
        Dim xxSl, xxDg As Decimal
        xxSl = 0
        xxDg = 0
        xxSl = Me.dgCACMH.Item(Me.dgCACMH.CurrentCell.RowNumber, 3)
        xxDg = Me.dgCACMH.Item(Me.dgCACMH.CurrentCell.RowNumber, 4)
        xx = Me.dgCACMH.Item(Me.dgCACMH.CurrentCell.RowNumber, 1)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá Mặt Hàng Có Mã " & xx & " Hay Không ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'xoa mat hang 
            Dim mySQLConnection As New SqlConnection(strconn)
            Dim cmd As New SqlCommand("delete from tblBAN where MAMH='" & xx & "' and SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                cmd.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không Thể Xoá Mặt Hàng Có Mã : " & xx, "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try

            Dim xxTg As Decimal = 0
            Dim xxTT As Decimal = 0
            xxTT = xxSl * xxDg
            xxTg = Me.txtTONGGIATRI.Text
            If Me.txtTRIETKHAU.Text <> 0 Then
                Me.txtTONGGIATRI.Text = ""
                Me.txtTONGGIATRI.Text = xxTg - (xxTT - xxTT * Me.txtTRIETKHAU.Text)
            Else
                Me.txtTONGGIATRI.Text = ""
                Me.txtTONGGIATRI.Text = xxTg - xxTT
            End If

            ' sau do cap nhat lai du lieu
            Dim sqlcmd As New SqlCommand("update tblHDBAN set NGAYBAN='" & Me.txtNGAYBAN.Text & "',TONGGIATRI='" & Me.txtTONGGIATRI.Text & "' where SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                sqlcmd.ExecuteNonQuery()
            Catch myException As Exception
                MessageBox.Show("Không Thể Lưu Những Thông Tin Bạn Vừa Thay Đổi. Hãy Thử Lại !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally

                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try
            Call fillDG(Me.txtSOHDBAN.Text)
        End If
        Me.cbMAMH.Text = ""
        Me.txtDONGIA.Text = ""
        Me.txtSOLUONG.Text = ""
        Me.txtTTMH.Text = ""
        Me.txtTienSauTK.Text = ""

    End Sub

    Private Sub btnThem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThem.Click
        If Me.cmdSave.Text <> "Lưu" Then
            Me.cmdSave.Text = "Lưu"
        End If
        Me.txtTienSauTK.Enabled = True
        Me.txtTTMH.Enabled = True
        Me.cbMAMH.Text = ""
        Me.txtDONGIA.Text = ""
        Me.txtSOLUONG.Text = ""
        Me.txtTienSauTK.Text = ""
        Me.txtTTMH.Text = ""
        Me.cbMAMH.Focus()

    End Sub

    Private Sub lblDen_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub lblXanh_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub lblDen_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Lưu Những Thông Tin Này Không ?  ", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
          
            If Me.txtNGAYBAN.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết ngày bán hàng !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNGAYBAN.Focus()
                Exit Sub
            Else
                If IsDate(Me.txtNGAYBAN.Text) = False Then
                    MessageBox.Show("Dữ liệu bạn nhập vào không phải kiểu ngày. Hãy sửa lại !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNGAYBAN.Focus()
                    Exit Sub
                Else
                    If checkDate(Me.txtNGAYBAN.Text) <> 2 Then
                        MessageBox.Show("Bạn hãy nhập đúng ngày bán theo kiểu: Ngày/Tháng/Năm. ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtNGAYBAN.Focus()
                        Exit Sub
                    End If

                End If
            End If
            Dim sqlcmd As New SqlCommand("update tblHDBAN set NGAYBAN='" & Me.txtNGAYBAN.Text & "' where SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                sqlcmd.ExecuteNonQuery()
            Catch myException As Exception
                MessageBox.Show("Không Thể Lưu Những Thông Tin Bạn Vừa Thay Đổi. Hãy Thử Lại !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally

                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub lblXanh_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Lưu Những Thông Tin Này Không ?  ", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            
            If Me.txtNGAYBAN.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết ngày bán hàng !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNGAYBAN.Focus()
                Exit Sub
            Else
                If IsDate(Me.txtNGAYBAN.Text) = False Then
                    MessageBox.Show("Dữ liệu bạn nhập vào không phải kiểu ngày. Hãy sửa lại !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNGAYBAN.Focus()
                    Exit Sub
                Else
                    If checkDate(Me.txtNGAYBAN.Text) <> 2 Then
                        MessageBox.Show("Bạn hãy nhập đúng ngày bán theo kiểu: Ngày/Tháng/Năm. ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtNGAYBAN.Focus()
                        Exit Sub
                    End If

                End If
            End If
            Dim sqlcmd As New SqlCommand("update tblHDBAN set NGAYBAN='" & Me.txtNGAYBAN.Text & "' where SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                sqlcmd.ExecuteNonQuery()
            Catch myException As Exception
                MessageBox.Show("Không Thể Lưu Những Thông Tin Bạn Vừa Thay Đổi. Hãy Thử Lại !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally

                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try
        End If
    End Sub


    Private Sub txtNGAYBAN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNGAYBAN.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtNGAYBAN.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết ngày bán hàng !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNGAYBAN.Focus()
                Exit Sub
            Else
                If IsDate(Me.txtNGAYBAN.Text) = False Then
                    MessageBox.Show("Dữ liệu bạn nhập vào không phải kiểu ngày. Hãy sửa lại !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNGAYBAN.Focus()
                    Exit Sub
                Else
                    If checkDate(Me.txtNGAYBAN.Text) <> 2 Then
                        MessageBox.Show("Bạn hãy nhập đúng ngày bán theo kiểu: Ngày/Tháng/Năm. ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtNGAYBAN.Focus()
                        Exit Sub
                    End If
                End If
            End If

        End If
    End Sub


    Private Sub btnChiTiet_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles btnChiTiet.ChangeUICues

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub dgCACMH_Navigate(sender As Object, ne As NavigateEventArgs) Handles dgCACMH.Navigate

    End Sub

    Private Sub txtTRIETKHAU_TextChanged(sender As Object, e As EventArgs) Handles txtTRIETKHAU.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class


