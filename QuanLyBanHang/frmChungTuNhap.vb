Imports System.Data
Imports System.Data.SqlClient
Public Class frmCTNHAP
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
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button

    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnHuyCTN As System.Windows.Forms.Button
    Friend WithEvents Grb2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgView As System.Windows.Forms.DataGrid
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tabCTN As System.Windows.Forms.TabControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cbNgay As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbThang As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbNam As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCTN As System.Windows.Forms.TextBox
    Friend WithEvents rNgay As System.Windows.Forms.RadioButton
    Friend WithEvents rMa As System.Windows.Forms.RadioButton
    Friend WithEvents rAll As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDATRA As System.Windows.Forms.TextBox
    Friend WithEvents txtThanhTien As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents txtSL As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbNCC As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNgayHenTra As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDONGIA As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents txtNgayN As System.Windows.Forms.TextBox
    Friend WithEvents txtTONGTIEN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNO As System.Windows.Forms.TextBox
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSOCTN As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMH As System.Windows.Forms.ComboBox
    Friend WithEvents cmDong As System.Windows.Forms.Button
    Friend WithEvents cmdThemCTN As System.Windows.Forms.Button
    Friend WithEvents cmdXoaCTN As System.Windows.Forms.Button
    Friend WithEvents dgMHNhap As System.Windows.Forms.DataGrid
    Friend WithEvents btnSuaCTN As System.Windows.Forms.Button
    Friend WithEvents btnXoaMH As System.Windows.Forms.Button
    Friend WithEvents btnThemMH As System.Windows.Forms.Button
    Friend WithEvents btnChiTiet As System.Windows.Forms.Button
    Friend WithEvents btnHoanThanh As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCTNHAP))
        Me.Grb1 = New System.Windows.Forms.GroupBox()
        Me.btnHoanThanh = New System.Windows.Forms.Button()
        Me.btnXoaMH = New System.Windows.Forms.Button()
        Me.btnThemMH = New System.Windows.Forms.Button()
        Me.cmDong = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbMH = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSL = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDONGIA = New System.Windows.Forms.TextBox()
        Me.txtThanhTien = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgMHNhap = New System.Windows.Forms.DataGrid()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cbNCC = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnHuyCTN = New System.Windows.Forms.Button()
        Me.CheckBox = New System.Windows.Forms.CheckBox()
        Me.txtNgayHenTra = New System.Windows.Forms.TextBox()
        Me.txtNO = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDATRA = New System.Windows.Forms.TextBox()
        Me.txtTONGTIEN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNgayN = New System.Windows.Forms.TextBox()
        Me.txtSOCTN = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.tabCTN = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.btnSuaCTN = New System.Windows.Forms.Button()
        Me.rAll = New System.Windows.Forms.RadioButton()
        Me.rMa = New System.Windows.Forms.RadioButton()
        Me.rNgay = New System.Windows.Forms.RadioButton()
        Me.btnChiTiet = New System.Windows.Forms.Button()
        Me.txtCTN = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbNam = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbNgay = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgView = New System.Windows.Forms.DataGrid()
        Me.cmdThemCTN = New System.Windows.Forms.Button()
        Me.cmdXoaCTN = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Grb1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgMHNhap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCTN.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Grb2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb1
        '
        Me.Grb1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.Grb1.Controls.Add(Me.btnHoanThanh)
        Me.Grb1.Controls.Add(Me.btnXoaMH)
        Me.Grb1.Controls.Add(Me.btnThemMH)
        Me.Grb1.Controls.Add(Me.cmDong)
        Me.Grb1.Controls.Add(Me.GroupBox1)
        Me.Grb1.Controls.Add(Me.dgMHNhap)
        Me.Grb1.Controls.Add(Me.PictureBox3)
        Me.Grb1.Controls.Add(Me.PictureBox1)
        Me.Grb1.Controls.Add(Me.cbNCC)
        Me.Grb1.Controls.Add(Me.Label9)
        Me.Grb1.Controls.Add(Me.btnHuyCTN)
        Me.Grb1.Controls.Add(Me.CheckBox)
        Me.Grb1.Controls.Add(Me.txtNgayHenTra)
        Me.Grb1.Controls.Add(Me.txtNO)
        Me.Grb1.Controls.Add(Me.Label12)
        Me.Grb1.Controls.Add(Me.Label11)
        Me.Grb1.Controls.Add(Me.btnSua)
        Me.Grb1.Controls.Add(Me.Label10)
        Me.Grb1.Controls.Add(Me.txtDATRA)
        Me.Grb1.Controls.Add(Me.txtTONGTIEN)
        Me.Grb1.Controls.Add(Me.Label8)
        Me.Grb1.Controls.Add(Me.Label4)
        Me.Grb1.Controls.Add(Me.Label2)
        Me.Grb1.Controls.Add(Me.txtNgayN)
        Me.Grb1.Controls.Add(Me.txtSOCTN)
        Me.Grb1.Controls.Add(Me.lbName)
        Me.Grb1.Controls.Add(Me.lbID)
        Me.Grb1.Controls.Add(Me.cmdSave)
        Me.Grb1.Controls.Add(Me.cmdNew)
        Me.Grb1.Controls.Add(Me.cmdBack)
        Me.Grb1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb1.Location = New System.Drawing.Point(6, 0)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(776, 451)
        Me.Grb1.TabIndex = 4
        Me.Grb1.TabStop = False
        '
        'btnHoanThanh
        '
        Me.btnHoanThanh.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHoanThanh.Location = New System.Drawing.Point(32, 396)
        Me.btnHoanThanh.Name = "btnHoanThanh"
        Me.btnHoanThanh.Size = New System.Drawing.Size(120, 43)
        Me.btnHoanThanh.TabIndex = 51
        Me.btnHoanThanh.Text = "Hoàn Thành Nhập"
        '
        'btnXoaMH
        '
        Me.btnXoaMH.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXoaMH.Location = New System.Drawing.Point(32, 313)
        Me.btnXoaMH.Name = "btnXoaMH"
        Me.btnXoaMH.Size = New System.Drawing.Size(120, 23)
        Me.btnXoaMH.TabIndex = 50
        Me.btnXoaMH.Text = "Xoá Mặt Hàng"
        '
        'btnThemMH
        '
        Me.btnThemMH.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThemMH.Location = New System.Drawing.Point(32, 352)
        Me.btnThemMH.Name = "btnThemMH"
        Me.btnThemMH.Size = New System.Drawing.Size(120, 23)
        Me.btnThemMH.TabIndex = 49
        Me.btnThemMH.Text = "Thêm Mặt Hàng"
        '
        'cmDong
        '
        Me.cmDong.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmDong.Location = New System.Drawing.Point(672, 410)
        Me.cmDong.Name = "cmDong"
        Me.cmDong.Size = New System.Drawing.Size(86, 24)
        Me.cmDong.TabIndex = 48
        Me.cmDong.Text = "Đóng"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbMH)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtSL)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtDONGIA)
        Me.GroupBox1.Controls.Add(Me.txtThanhTien)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 169)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập Thông Tin Cho Mặt Hàng"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Mã Mặt Hàng"
        '
        'cbMH
        '
        Me.cbMH.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMH.ItemHeight = 16
        Me.cbMH.Location = New System.Drawing.Point(24, 44)
        Me.cbMH.Name = "cbMH"
        Me.cbMH.Size = New System.Drawing.Size(244, 24)
        Me.cbMH.Sorted = True
        Me.cbMH.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Số Lượng"
        '
        'txtSL
        '
        Me.txtSL.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSL.Location = New System.Drawing.Point(133, 74)
        Me.txtSL.Name = "txtSL"
        Me.txtSL.Size = New System.Drawing.Size(135, 23)
        Me.txtSL.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 23)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Đơn Giá"
        '
        'txtDONGIA
        '
        Me.txtDONGIA.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDONGIA.Location = New System.Drawing.Point(133, 106)
        Me.txtDONGIA.Name = "txtDONGIA"
        Me.txtDONGIA.Size = New System.Drawing.Size(135, 23)
        Me.txtDONGIA.TabIndex = 22
        '
        'txtThanhTien
        '
        Me.txtThanhTien.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThanhTien.Location = New System.Drawing.Point(133, 138)
        Me.txtThanhTien.Name = "txtThanhTien"
        Me.txtThanhTien.Size = New System.Drawing.Size(135, 23)
        Me.txtThanhTien.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 23)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Thành Tiền "
        '
        'dgMHNhap
        '
        Me.dgMHNhap.CaptionText = "Danh Sách Các Mặt Hàng Trong Chứng Từ Nhập"
        Me.dgMHNhap.DataMember = ""
        Me.dgMHNhap.GridLineColor = System.Drawing.Color.Maroon
        Me.dgMHNhap.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMHNhap.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.dgMHNhap.Location = New System.Drawing.Point(184, 232)
        Me.dgMHNhap.Name = "dgMHNhap"
        Me.dgMHNhap.Size = New System.Drawing.Size(576, 162)
        Me.dgMHNhap.TabIndex = 46
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(16, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 28)
        Me.PictureBox3.TabIndex = 45
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(64, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 28)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'cbNCC
        '
        Me.cbNCC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNCC.ItemHeight = 16
        Me.cbNCC.Location = New System.Drawing.Point(421, 75)
        Me.cbNCC.Name = "cbNCC"
        Me.cbNCC.Size = New System.Drawing.Size(337, 24)
        Me.cbNCC.Sorted = True
        Me.cbNCC.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(96, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(383, 32)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = " Thông Tin Chứng Từ Nhập Mới"
        '
        'btnHuyCTN
        '
        Me.btnHuyCTN.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuyCTN.Location = New System.Drawing.Point(344, 410)
        Me.btnHuyCTN.Name = "btnHuyCTN"
        Me.btnHuyCTN.Size = New System.Drawing.Size(85, 23)
        Me.btnHuyCTN.TabIndex = 39
        Me.btnHuyCTN.Text = "Huỷ Bỏ "
        '
        'CheckBox
        '
        Me.CheckBox.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox.Location = New System.Drawing.Point(384, 136)
        Me.CheckBox.Name = "CheckBox"
        Me.CheckBox.Size = New System.Drawing.Size(348, 32)
        Me.CheckBox.TabIndex = 38
        Me.CheckBox.Text = "Nếu Không Nợ Thì Hãy Đánh Dấu Chọn Vào Ô này"
        Me.CheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNgayHenTra
        '
        Me.txtNgayHenTra.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNgayHenTra.Location = New System.Drawing.Point(670, 171)
        Me.txtNgayHenTra.Name = "txtNgayHenTra"
        Me.txtNgayHenTra.Size = New System.Drawing.Size(88, 23)
        Me.txtNgayHenTra.TabIndex = 35
        '
        'txtNO
        '
        Me.txtNO.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNO.Location = New System.Drawing.Point(365, 197)
        Me.txtNO.Name = "txtNO"
        Me.txtNO.Size = New System.Drawing.Size(195, 23)
        Me.txtNO.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(571, 173)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 23)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Ngày Hẹn Trả"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(301, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 23)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Còn Nợ"
        '
        'btnSua
        '
        Me.btnSua.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSua.Location = New System.Drawing.Point(32, 274)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(120, 23)
        Me.btnSua.TabIndex = 29
        Me.btnSua.Text = "Sửa Mặt Hàng"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(301, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 23)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Đã Trả"
        '
        'txtDATRA
        '
        Me.txtDATRA.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDATRA.Location = New System.Drawing.Point(365, 170)
        Me.txtDATRA.Name = "txtDATRA"
        Me.txtDATRA.Size = New System.Drawing.Size(195, 23)
        Me.txtDATRA.TabIndex = 26
        '
        'txtTONGTIEN
        '
        Me.txtTONGTIEN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTONGTIEN.Location = New System.Drawing.Point(421, 107)
        Me.txtTONGTIEN.Name = "txtTONGTIEN"
        Me.txtTONGTIEN.Size = New System.Drawing.Size(337, 23)
        Me.txtTONGTIEN.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(301, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 24)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Tổng Thành Tiền "
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(301, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nhà Cung Cấp"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, -88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(744, 88)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nhập Các Hoá Đơn Chứng Từ Của Những Mặt Hàng Mới Nhập"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNgayN
        '
        Me.txtNgayN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNgayN.Location = New System.Drawing.Point(672, 43)
        Me.txtNgayN.Name = "txtNgayN"
        Me.txtNgayN.Size = New System.Drawing.Size(86, 23)
        Me.txtNgayN.TabIndex = 11
        '
        'txtSOCTN
        '
        Me.txtSOCTN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSOCTN.Location = New System.Drawing.Point(421, 46)
        Me.txtSOCTN.Name = "txtSOCTN"
        Me.txtSOCTN.Size = New System.Drawing.Size(170, 23)
        Me.txtSOCTN.TabIndex = 10
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(597, 48)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(80, 19)
        Me.lbName.TabIndex = 8
        Me.lbName.Text = "Ngày Nhập"
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(301, 49)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(137, 20)
        Me.lbID.TabIndex = 7
        Me.lbID.Text = "Số Chứng từ Nhập"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(32, 234)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(120, 24)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Lưu"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(184, 396)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(120, 43)
        Me.cmdNew.TabIndex = 2
        Me.cmdNew.Text = "&Thêm Chứng Từ Nhập"
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(508, 410)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(85, 24)
        Me.cmdBack.TabIndex = 8
        Me.cmdBack.Text = "&Quay Lại"
        '
        'tabCTN
        '
        Me.tabCTN.Controls.Add(Me.TabPage1)
        Me.tabCTN.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabCTN.ItemSize = New System.Drawing.Size(77, 21)
        Me.tabCTN.Location = New System.Drawing.Point(1, 0)
        Me.tabCTN.Name = "tabCTN"
        Me.tabCTN.SelectedIndex = 0
        Me.tabCTN.Size = New System.Drawing.Size(784, 494)
        Me.tabCTN.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Grb1)
        Me.TabPage1.Controls.Add(Me.Grb2)
        Me.TabPage1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(776, 465)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thông Tin Chứng Từ Nhập"
        '
        'Grb2
        '
        Me.Grb2.Controls.Add(Me.btnSuaCTN)
        Me.Grb2.Controls.Add(Me.rAll)
        Me.Grb2.Controls.Add(Me.rMa)
        Me.Grb2.Controls.Add(Me.rNgay)
        Me.Grb2.Controls.Add(Me.btnChiTiet)
        Me.Grb2.Controls.Add(Me.txtCTN)
        Me.Grb2.Controls.Add(Me.Label17)
        Me.Grb2.Controls.Add(Me.cbNam)
        Me.Grb2.Controls.Add(Me.Label16)
        Me.Grb2.Controls.Add(Me.cbThang)
        Me.Grb2.Controls.Add(Me.Label15)
        Me.Grb2.Controls.Add(Me.Label14)
        Me.Grb2.Controls.Add(Me.cbNgay)
        Me.Grb2.Controls.Add(Me.PictureBox2)
        Me.Grb2.Controls.Add(Me.Label1)
        Me.Grb2.Controls.Add(Me.dgView)
        Me.Grb2.Controls.Add(Me.cmdThemCTN)
        Me.Grb2.Controls.Add(Me.cmdXoaCTN)
        Me.Grb2.Controls.Add(Me.cmdClose)
        Me.Grb2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb2.Location = New System.Drawing.Point(7, 12)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(769, 439)
        Me.Grb2.TabIndex = 5
        Me.Grb2.TabStop = False
        '
        'btnSuaCTN
        '
        Me.btnSuaCTN.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuaCTN.Location = New System.Drawing.Point(341, 400)
        Me.btnSuaCTN.Name = "btnSuaCTN"
        Me.btnSuaCTN.Size = New System.Drawing.Size(104, 23)
        Me.btnSuaCTN.TabIndex = 29
        Me.btnSuaCTN.Text = "&Sửa "
        '
        'rAll
        '
        Me.rAll.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rAll.Location = New System.Drawing.Point(652, 82)
        Me.rAll.Name = "rAll"
        Me.rAll.Size = New System.Drawing.Size(112, 24)
        Me.rAll.TabIndex = 28
        Me.rAll.Text = "Chọn Tất Cả"
        '
        'rMa
        '
        Me.rMa.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rMa.Location = New System.Drawing.Point(652, 57)
        Me.rMa.Name = "rMa"
        Me.rMa.Size = New System.Drawing.Size(112, 24)
        Me.rMa.TabIndex = 27
        Me.rMa.Text = "Tìm Theo Mã"
        '
        'rNgay
        '
        Me.rNgay.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rNgay.Location = New System.Drawing.Point(652, 30)
        Me.rNgay.Name = "rNgay"
        Me.rNgay.Size = New System.Drawing.Size(127, 24)
        Me.rNgay.TabIndex = 26
        Me.rNgay.Text = "Tìm Theo Ngày"
        '
        'btnChiTiet
        '
        Me.btnChiTiet.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChiTiet.Location = New System.Drawing.Point(77, 400)
        Me.btnChiTiet.Name = "btnChiTiet"
        Me.btnChiTiet.Size = New System.Drawing.Size(104, 23)
        Me.btnChiTiet.TabIndex = 25
        Me.btnChiTiet.Text = "Xem Chi Tiết"
        '
        'txtCTN
        '
        Me.txtCTN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTN.Location = New System.Drawing.Point(512, 70)
        Me.txtCTN.Name = "txtCTN"
        Me.txtCTN.Size = New System.Drawing.Size(130, 23)
        Me.txtCTN.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(383, 74)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(136, 23)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Mã Chứng Từ Nhập"
        '
        'cbNam
        '
        Me.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNam.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNam.Location = New System.Drawing.Point(290, 71)
        Me.cbNam.Name = "cbNam"
        Me.cbNam.Size = New System.Drawing.Size(88, 24)
        Me.cbNam.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(249, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 24)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Năm"
        '
        'cbThang
        '
        Me.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThang.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbThang.Location = New System.Drawing.Point(170, 71)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(64, 24)
        Me.cbThang.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(119, 74)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 23)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Tháng"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 23)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Ngày"
        '
        'cbNgay
        '
        Me.cbNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNgay.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNgay.Location = New System.Drawing.Point(47, 71)
        Me.cbNgay.Name = "cbNgay"
        Me.cbNgay.Size = New System.Drawing.Size(65, 24)
        Me.cbNgay.TabIndex = 17
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(138, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(172, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 32)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Danh Sách Các Hoá Đơn Chứng Từ Nhập"
        '
        'dgView
        '
        Me.dgView.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.dgView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgView.CaptionText = "Danh Sách Các Hoá Đơn Chứng Từ Nhập"
        Me.dgView.DataMember = ""
        Me.dgView.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.GridLineColor = System.Drawing.Color.Maroon
        Me.dgView.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgView.Location = New System.Drawing.Point(8, 118)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(767, 256)
        Me.dgView.TabIndex = 14
        '
        'cmdThemCTN
        '
        Me.cmdThemCTN.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdThemCTN.Location = New System.Drawing.Point(212, 400)
        Me.cmdThemCTN.Name = "cmdThemCTN"
        Me.cmdThemCTN.Size = New System.Drawing.Size(96, 24)
        Me.cmdThemCTN.TabIndex = 12
        Me.cmdThemCTN.Text = "&Thêm "
        '
        'cmdXoaCTN
        '
        Me.cmdXoaCTN.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdXoaCTN.Location = New System.Drawing.Point(476, 400)
        Me.cmdXoaCTN.Name = "cmdXoaCTN"
        Me.cmdXoaCTN.Size = New System.Drawing.Size(96, 24)
        Me.cmdXoaCTN.TabIndex = 9
        Me.cmdXoaCTN.Text = "&Xoá Bỏ"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(604, 400)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(96, 24)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Đóng"
        '
        'frmCTNHAP
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(1032, 480)
        Me.Controls.Add(Me.tabCTN)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCTNHAP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Danh Sách Các Chứng Từ Nhập"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Grb1.ResumeLayout(False)
        Me.Grb1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgMHNhap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCTN.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Grb2.ResumeLayout(False)
        Me.Grb2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim iRscount As Integer
    Dim okThem, okSua As Boolean
    Dim xMA As String
    Dim xGhiMoi As Boolean


    Dim mySQLDataAdapter As New SqlDataAdapter("Select * from tblCTNHAP", mySQLConnection)

    Dim sqlCmdBuilder As SqlCommandBuilder
    Dim sqlDataAdapter2 As SqlClient.SqlDataAdapter
    Dim dsDataSet As New DataSet()

    Dim oSL As Integer = 0
    Dim oDG As Decimal = 0
    Dim oTT As Decimal = 0
    Dim oMAMH As String = ""
    Dim oVITRI As Integer = 0

    Dim sConnString = strconn
    Dim mySQLConnection As New SqlConnection(sConnString)

    Private Function exitItem(ByVal xDK As String) As Boolean
        Dim VT As Integer = 0
        Dim xTg As String = ""
        Dim xok As Boolean = False
        VT = oVITRI - 1
        While VT >= 0
            xTg = ""
            xTg = Me.dgMHNhap.Item(VT, 1)
            If xDK = xTg Then
                xok = True
                Exit While
            End If
            VT = VT - 1
        End While

        If xok = False Then
            VT = 0
            VT = oVITRI
            VT = VT + 1
            While VT <= Me.BindingContext(dsDataSet, "tblNHAPKHO").Count - 1
                xTg = ""
                xTg = Me.dgMHNhap.Item(VT, 1)
                If xDK = xTg Then
                    xok = True
                    Exit While
                End If
                VT = VT + 1
            End While
        End If
        exitItem = xok

    End Function
    Function checkItem(ByVal code As String) As Boolean
        Dim myconn As New SqlConnection(strconn)
        Dim Tg As String = ""
        Dim readcmd As New SqlCommand("select * from tblNHAPKHO where MAMH='" & code & "' and SOCTN='" & Me.txtSOCTN.Text & "'", myconn)
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
            MessageBox.Show("Không thể đọc được dữ liệu từ bảng tblNHAPKHO để kiểm tra . Bạn hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If myconn.State = ConnectionState.Open Then
                myconn.Close()
            End If
        End Try

    End Function


    Private Sub fillDgMH(ByVal dieukien As String)
        Dim st As String = ""
        st = "Select SOCTN as [Số Chứng Từ Nhập],MAMH as [Mã Mặt Hàng],(select TENMH from tblMATHANG where MAMH=tblNHAPKHO.MAMH)as [Tên Mặt Hàng],SOLUONG as [Số Lượng],DONGIA as [Đơn Giá] from  tblNHAPKHO where SOCTN='" & dieukien & "'"

        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter2 = New SqlClient.SqlDataAdapter(st, sqlConn)
        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder
        sqlCmdBuilder = New SqlClient.SqlCommandBuilder(sqlDataAdapter2)

        Me.dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "tblNHAPKHO")

        With dgMHNhap
            .DataSource = dsDataSet
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "tblNHAPKHO")
        End With
    End Sub

    Private Sub GetData()
        Dim str As String = ""
        str = "Select SOCTN as [Số Chứng Từ Nhập],NGAYN as [Ngày Nhập],MANV as [Mã Nhân Viên],MANCC as [Mã Nhà Cung Cấp],TONGGIATRI as [Tổng Giá Trị],DATRA as [Đã Trả],CONNO as [Còn Nợ],NGAYHENTRA as [Ngày Hẹn Trả] from tblCTNHAP"
        If Me.rNgay.Checked = True Then
            If Me.cbNgay.Text <> "" Then
                str = str & " where day(NGAYN)='" & Me.cbNgay.Text & "'"
            End If
            If Me.cbThang.Text <> "" Then
                If Me.cbNgay.Text <> "" Then
                    str = str & " and month(NGAYN)='" & Me.cbThang.Text & "'"
                Else
                    str = str & " where month(NGAYN)='" & Me.cbThang.Text & "'"
                End If
            End If

            If Me.cbNam.Text <> "" Then
                If Me.cbNgay.Text = "" And Me.cbThang.Text = "" Then
                    str = str & " where year(NGAYN)=" & Me.cbNam.Text & ""
                Else
                    str = str & " and year(NGAYN)=" & Me.cbNam.Text & ""
                End If
            End If
        End If
        If Me.rMa.Checked = True Then
            str = str & " where SOCTN='" & Me.txtCTN.Text & "'"
        End If

        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter2 = New SqlClient.SqlDataAdapter(str, sqlConn)
        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder
        sqlCmdBuilder = New SqlClient.SqlCommandBuilder(sqlDataAdapter2)
        Me.dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "tblCTNHAP")
        With dgView
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "tblCTNHAP")
        End With
        If mySQLConnection.State = ConnectionState.Open Then
            mySQLConnection.Close()
        End If
    End Sub

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
            len = InStr(Me.cbMH.Text, "--")
            leng = Microsoft.VisualBasic.Len(Me.cbMH.Text)
            If len > 1 Then
                xcode = Microsoft.VisualBasic.Right(Me.cbMH.Text, leng - len - 1)
            Else
                xcode = Me.cbMH.Text
            End If
            SplitCode = xcode
            Exit Function
        End If
        If ch = "NCC" Then
            len = InStr(Me.cbNCC.Text, "--")
            leng = Microsoft.VisualBasic.Len(Me.cbNCC.Text)
            If len > 1 Then
                xcode = Microsoft.VisualBasic.Right(Me.cbNCC.Text, leng - len - 1)
            Else
                xcode = Me.cbNCC.Text
            End If
            SplitCode = xcode
            Exit Function
        End If
       
    End Function
    'Xây dựng thủ tục thực hiện việc đưa dữ liệu vào trong các combobox: MANV,MANCC,MAMH...
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
            If obj = "MH" Then
                Do While drReader.Read()
                    xma = ""
                    xten = ""
                    xma = drReader.GetString(0)
                    xten = drReader.GetString(1)
                    Me.cbMH.Items.Add(xten & "--" & xma)
                Loop
            End If
            If obj = "NCC" Then
                Do While drReader.Read()
                    xma = ""
                    xten = ""
                    xma = drReader.GetString(0)
                    xten = drReader.GetString(1)
                    Me.cbNCC.Items.Add(xten & "--" & xma)
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


    Private Sub blank()
        Me.txtSOCTN.Text = ""
        Me.txtNgayN.Text = ""
        Me.txtSL.Text = ""
        Me.txtDONGIA.Text = ""
        Me.txtThanhTien.Text = ""
        Me.txtTONGTIEN.Text = ""
        Me.txtDATRA.Text = ""
        Me.txtNO.Text = ""
        Me.txtNgayHenTra.Text = ""
        Me.cbMH.Text = ""
        Me.cbNCC.Text = ""
        Me.CheckBox.Checked = False
        Me.txtSOCTN.Enabled = True
        Me.txtNgayN.Enabled = True
    End Sub
    'nut ghilai cho phep ghi lai khi nhap 1 mat hang cua chung tu nhap moi hoac khi muon
    'cap nhat lai nhung thay doi cua 1 mat hang trong hoa don sua 
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If Me.txtNgayN.Text = "" Then
            MessageBox.Show("Bạn Hãy Cho Biết Ngày Nhập Hàng Của Chứng Từ Nhập !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtNgayN.Focus()
            Exit Sub
        Else
            If IsDate(Me.txtNgayN.Text) = False Then
                MessageBox.Show("Giá Trị Kiểu Ngày Bạn Nhập Vào Không Hợp Lệ.Hãy Nhập Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNgayN.Focus()
                Exit Sub
            Else
                If checkDate(Me.txtNgayN.Text) <> 2 Then
                    MessageBox.Show("Bạn hãy nhập đúng định dạng ngày theo kiểu : Ngày/Tháng/Năm . ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNgayN.Focus()
                    Exit Sub
                End If
            End If
        End If
        If Me.cbNCC.Text = "" Then
            MessageBox.Show("Bạn hãy cho biết nhà cung cấp hàng !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbNCC.Focus()
            Exit Sub
        End If
        If (Me.CheckBox.Checked = False AndAlso Me.txtNgayHenTra.Text = "" AndAlso okSua = True AndAlso Me.txtTONGTIEN.Text <> Me.txtDATRA.Text AndAlso Me.txtThanhTien.Text = "") Then
            MessageBox.Show("Bạn hãy cho biết ngày hẹn trả số tiền còn lại.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtNgayHenTra.Focus()
            Exit Sub
        End If
        If okSua = True And Me.btnThemMH.Enabled = False Then
            'ghi lai chung tu sau khi sua CTN thanh khong con no gi 
            Dim strcmd = "update tblCTNHAP set SOCTN='" & UCase(Me.txtSOCTN.Text) & "',NGAYN='" & Me.txtNgayN.Text & "',MANCC='" & UCase(SplitCode("NCC")) & "',TONGGIATRI=" & Me.txtTONGTIEN.Text & ",DATRA=" & Me.txtTONGTIEN.Text & ",CONNO=0 where SOCTN='" & xMA & "'"
            Dim ook As Boolean = True
            Dim xcmd As New SqlCommand(strcmd, mySQLConnection)
            Try
                mySQLConnection.Open()
                xcmd.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không thể Lưu được thông tin của chứng từ nhập này. Hãy thử lại !.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ook = False
            Finally
                If mySQLConnection.State = ConnectionState.Open Then
                    mySQLConnection.Close()
                End If
            End Try
            If ook Then
                Call blank()
                Me.CheckBox.Checked = False
                Call fillDgMH(Me.txtSOCTN.Text)
            End If

            Exit Sub
        End If

        If okSua = True AndAlso Me.txtSL.Text = "" AndAlso Me.txtDONGIA.Text = "" AndAlso Me.txtThanhTien.Text = "" Then
            'chi cap nhat nhung thong tin trong bang CTNHAP

            Dim strcmd = "update tblCTNHAP set SOCTN='" & UCase(Me.txtSOCTN.Text) & "',NGAYN='" & Me.txtNgayN.Text & "',MANCC='" & UCase(SplitCode("NCC")) & "',TONGGIATRI=" & Me.txtTONGTIEN.Text & ",DATRA=" & Me.txtDATRA.Text & ",CONNO=" & Me.txtNO.Text & ",NGAYHENTRA='" & Me.txtNgayHenTra.Text & "' where SOCTN='" & xMA & "'"
            Dim cmdCTN As New SqlCommand(strcmd, mySQLConnection)
            Dim ok1 As Boolean = True
            Try
                mySQLConnection.Open()
                cmdCTN.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không thể Lưu được thông tin của chứng từ nhập này. Hãy thử lại !.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ok1 = False
            Finally
                If mySQLConnection.State = ConnectionState.Open Then
                    mySQLConnection.Close()
                End If
            End Try
            If ok1 = True Then
                Call blank()
                Me.CheckBox.Checked = False
                Call fillDgMH(Me.txtSOCTN.Text)
            End If
            Exit Sub
        End If
        If Me.cbMH.Text = "" Then
            MessageBox.Show("Bạn hãy cho biết tên của mặt hàng ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbMH.Focus()
            Exit Sub
        End If

        If Me.txtSL.Text = "" Then
            MessageBox.Show("Bạn Hãy Cho Biết Số Lượng Của Mặt Hàng !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtSL.Focus()
            Exit Sub
        Else
            If IsNumeric(Me.txtSL.Text) = False Then
                MessageBox.Show("Giá Trị Bạn Nhập Vào Không Hợp Lệ,Số Lượng Hàng Phải Là Kiểu Số.Hãy Nhập Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtSL.Focus()
                Exit Sub
            Else
                If Len(Me.txtSL.Text) > 9 Then
                    MessageBox.Show("Giá trị của số quá lớn. Bạn hãy sửa lại !.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtSL.Focus()
                    Exit Sub
                End If
            End If
        End If
        If Me.txtDONGIA.Text = "" Then
            MessageBox.Show("Bạn Hãy Cho Biết Đơn Giá Của Mặt Hàng.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtDONGIA.Focus()
            Exit Sub
        Else
            If IsNumeric(Me.txtDONGIA.Text) = False Then
                MessageBox.Show("Giá Trị Bạn Nhập Vào Không Hợp Lệ. Đơn Giá Phải Là Kiểu Số.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDONGIA.Focus()
                Exit Sub
            Else
                If Len(Me.txtDONGIA.Text) > 9 Then
                    MessageBox.Show("Giá trị của số quá lớn. Bạn hãy sửa lại !.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtDONGIA.Focus()
                    Exit Sub
                End If
            End If
        End If

        Dim cmdNK As SqlCommand
        Dim cmdCT As SqlCommand

        If Me.cmdSave.Text = "Lưu" Then
            If okThem = True Then
                If Me.txtSOCTN.Text = "" Then
                    MessageBox.Show("Bạn Hãy Nhập Vào Số Chứng Từ Nhập !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtSOCTN.Focus()
                    Exit Sub
                Else
                    If checkcode("tblCTNHAP", "SOCTN", Me.txtSOCTN.Text) = False Then
                        MessageBox.Show("Số Chứng Từ Nhập Này Đã Tồn Tại. Bạn Hãy Sửa Lại !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtSOCTN.Focus()
                        Exit Sub
                    End If
                End If
                'ghi lai thong tin trong truong hop nhap chung tu lan dau  tien
                'insert,insert,okthem=false
                cmdNK = New SqlCommand("Insert into tblNHAPKHO(SOCTN,MAMH,SOLUONG,DONGIA) Values('" & UCase(Me.txtSOCTN.Text) & "','" & UCase(SplitCode("MH")) & "','" & Me.txtSL.Text & "','" & Me.txtDONGIA.Text & "')", mySQLConnection)
                Dim str = "insert into tblCTNHAP(SOCTN,NGAYN,MANCC,TONGGIATRI) values('" & UCase(Me.txtSOCTN.Text) & "','" & Me.txtNgayN.Text & "','" & UCase(SplitCode("NCC")) & "'," & Me.txtTONGTIEN.Text & ")"
                cmdCT = New SqlCommand(str, mySQLConnection)
            Else
                If checkItem(SplitCode("MH")) = False Then
                    MessageBox.Show("Mặt hàng này đã được nhập, nếu bạn muốn sửa nó thì hãy chọn nó trong danh sách các mặt hàng, sau đó kích vào nút sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim xx As Decimal = 0
                    xx = Me.txtTONGTIEN.Text
                    Me.txtTONGTIEN.Text = xx - Me.txtSL.Text * Me.txtDONGIA.Text
                    If Me.txtDATRA.Text <> "" Then
                        Me.txtNO.Text = Me.txtTONGTIEN.Text - Me.txtDATRA.Text
                    End If
                    Me.txtSL.Enabled = True
                    Me.txtDONGIA.Enabled = True
                    Me.cbMH.Focus()
                    Exit Sub
                End If
                'cho phep ghi lai thong tin khi ghi lai tu lan thu 2 (nhap MH lan 2)
                'update,insert
                cmdNK = New SqlCommand("Insert into tblNHAPKHO(SOCTN,MAMH,SOLUONG,DONGIA) Values('" & UCase(Me.txtSOCTN.Text) & "','" & UCase(SplitCode("MH")) & "','" & Me.txtSL.Text & "','" & Me.txtDONGIA.Text & "')", mySQLConnection)
                Dim strcmd = "update tblCTNHAP set SOCTN='" & UCase(Me.txtSOCTN.Text) & "',NGAYN='" & Me.txtNgayN.Text & "',MANCC='" & UCase(SplitCode("NCC")) & "',TONGGIATRI=" & Me.txtTONGTIEN.Text & " where SOCTN='" & Me.txtSOCTN.Text & "'"
                cmdCT = New SqlCommand(strcmd, mySQLConnection)
            End If

            If okSua = True Then 'cho phep ghi lai khi them vaoCTNHAP mat hang moi
                cmdNK = New SqlCommand("Insert into tblNHAPKHO(SOCTN,MAMH,SOLUONG,DONGIA) Values('" & UCase(Me.txtSOCTN.Text) & "','" & UCase(SplitCode("MH")) & "','" & Me.txtSL.Text & "','" & Me.txtDONGIA.Text & "')", mySQLConnection)
                Dim strcmd = "update tblCTNHAP set SOCTN='" & UCase(Me.txtSOCTN.Text) & "',NGAYN='" & Me.txtNgayN.Text & "',MANCC='" & UCase(SplitCode("NCC")) & "',TONGGIATRI=" & Me.txtTONGTIEN.Text & ",DATRA=" & Me.txtDATRA.Text & ",CONNO=" & Me.txtNO.Text & ",NGAYHENTRA='" & Me.txtNgayHenTra.Text & "' where SOCTN='" & xMA & "'"
                cmdCT = New SqlCommand(strcmd, mySQLConnection)
            End If

        Else
            If exitItem(SplitCode("MH")) = True Then
                MessageBox.Show("Tên mặt hàng này đã tồn tại trong danh sách các mặt hàng. Bạn hãy sửa lại tên của mặt hàng. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDONGIA.Enabled = True
                Me.cbMH.Focus()
                Exit Sub
            End If
            If okSua = True And xMA <> "" Then
                cmdNK = New SqlCommand("update tblNHAPKHO set MAMH='" & SplitCode("MH") & "',SOLUONG=" & Me.txtSL.Text & ",DONGIA=" & Me.txtDONGIA.Text & " where MAMH='" & oMAMH & "' and SOCTN='" & xMA & "'", mySQLConnection)
                'nut Me.cmdSave.Text = "Cập Nhật"
                Dim strcmd = "update tblCTNHAP set SOCTN='" & UCase(Me.txtSOCTN.Text) & "',NGAYN='" & Me.txtNgayN.Text & "',MANCC='" & UCase(SplitCode("NCC")) & "',TONGGIATRI=" & Me.txtTONGTIEN.Text & ",DATRA=" & Me.txtDATRA.Text & ",CONNO=" & Me.txtNO.Text & ",NGAYHENTRA='" & Me.txtNgayHenTra.Text & "' where SOCTN='" & xMA & "'"
                cmdCT = New SqlCommand(strcmd, mySQLConnection)
            End If

            If okThem = False And xMA = "" And okSua = False Then
                cmdNK = New SqlCommand("update tblNHAPKHO set MAMH='" & SplitCode("MH") & "',SOLUONG=" & Me.txtSL.Text & ",DONGIA=" & Me.txtDONGIA.Text & " where MAMH='" & oMAMH & "' and SOCTN='" & Me.txtSOCTN.Text & "'", mySQLConnection)
                'nut Me.cmdSave.Text = "Cập Nhật"
                Dim strcmd = "update tblCTNHAP set SOCTN='" & UCase(Me.txtSOCTN.Text) & "',NGAYN='" & Me.txtNgayN.Text & "',MANCC='" & UCase(SplitCode("NCC")) & "',TONGGIATRI=" & Me.txtTONGTIEN.Text & " where SOCTN='" & Me.txtSOCTN.Text & "'"
                cmdCT = New SqlCommand(strcmd, mySQLConnection)
            End If
        End If

        Try
            mySQLConnection.Open()
            cmdCT.ExecuteNonQuery()
            cmdNK.ExecuteNonQuery()
        Catch
            MessageBox.Show("Không Thể Lưu Những Thông Tin Trên. Bạn Hãy Thử Lại !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'chu y phai goi lai thu tuc load lai TONGGIATRI ...
            Me.cmdSave.Text = "Lưu"
        Finally
            If Me.mySQLConnection.State = ConnectionState.Open Then
                Me.mySQLConnection.Close()
            End If
        End Try
        If okThem = True Then
            okThem = False 'de cho biet la chung tu duoc ghi laij lan 2 khong phai lan1 
        End If

        Me.txtSOCTN.Enabled = False
        Me.txtNgayN.Enabled = False
        Me.txtSL.Text = ""
        Me.txtDONGIA.Text = ""
        Me.txtThanhTien.Text = ""
        Me.cmdSave.Text = "Lưu"
        Me.CheckBox.Checked = False
        Call fillDgMH(Me.txtSOCTN.Text)
        Me.txtDONGIA.Enabled = True
        Me.txtThanhTien.Enabled = True
        Me.cbMH.Focus()
        Me.cbMH.DropDownStyle = ComboBoxStyle.DropDownList
        Me.txtTONGTIEN.Enabled = False
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXoaCTN.Click
        'If Me.dgView.CurrentCell.RowNumber = 0 Then
        'MessageBox.Show("Bản Ghi Này Rỗng Không Thể Xoá. Bạn Hãy Thử Lại !", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Exit Sub
        'End If
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống rỗng. Bạn không thể thực hiện chức năng này.  ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim No = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá Toàn Bộ Hoá Đơn " & No & " Hay Không ?.", "Xin Chào !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call delItem2("tblCTNHAP", "SOCTN", No, "Hoá Đơn Nhập Hàng")
            Call delItem2("tblNHAPKHO", "SOCTN", No, "Hoá Đơn Nhập Hàng")
        End If
        GetData()
    End Sub

    Private Sub cmdThemCTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThemCTN.Click
        xGhiMoi = False
        okThem = True
        okSua = False
        xMA = ""
        Me.Grb1.Visible = True
        Me.Grb2.Visible = False
        blank()

        Me.cbNCC.DropDownStyle = ComboBoxStyle.DropDownList
        Me.cbMH.DropDownStyle = ComboBoxStyle.DropDownList

        Me.txtSOCTN.Enabled = True
        Me.txtNgayN.Enabled = True
        Me.btnHoanThanh.Enabled = True
        Me.CheckBox.Checked = False
        Me.txtSOCTN.Focus()
        Call fillDgMH(Me.txtSOCTN.Text)
        Me.btnThemMH.Enabled = True
        Me.btnXoaMH.Enabled = True
        Me.btnSua.Enabled = True

        Me.btnHuyCTN.Enabled = True
        Me.cmdNew.Enabled = True
        Me.cmdSave.Enabled = True
        Me.cmdSave.Text = "Lưu"
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        xGhiMoi = False
        okThem = True 'bien kiem tra : neu no =true thi cho ghi lai lan1 
        okSua = False
        xMA = ""
        blank()
        Me.txtSOCTN.Enabled = True
        Me.txtNgayN.Enabled = True
        Me.CheckBox.Checked = False
        Me.btnHoanThanh.Enabled = True

        Me.btnHuyCTN.Enabled = True
        Me.cmdNew.Enabled = True
        Me.cmdSave.Enabled = True
        Me.cmdSave.Text = "Lưu"
        Call fillDgMH(Me.txtSOCTN.Text)
        Me.txtSOCTN.Focus()
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click

        If xGhiMoi = False Then
            If MessageBox.Show("Bạn có muốn Lưu chứng từ nhập này không?. Bạn chọn Yes để Lưu, nếu bạn chọn No thì chứng từ nhập này sẽ bị xoá. ", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                MessageBox.Show("Bạn hãy kích vào nút --Hoàn Thành Nhập-- để kết thúc.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                ' goi thu tuc xoa chung tu nhap
                If Me.txtSOCTN.Text <> "" Then
                    Dim del As New SqlCommand("delete from tblNHAPKHO where SOCTN='" & Me.txtSOCTN.Text & "'", mySQLConnection)
                    Dim cmdDel As New SqlCommand("delete  from tblCTNHAP where SOCTN='" & Me.txtSOCTN.Text & "'", mySQLConnection)
                    Try
                        mySQLConnection.Open()
                        del.ExecuteNonQuery()
                        cmdDel.ExecuteNonQuery()
                    Catch
                        MessageBox.Show("Không thể xoá chứng từ nhập này, cũng có thể chứng từ nhập này không tồn tại. Hãy thử lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Finally
                        If mySQLConnection.State = ConnectionState.Open Then
                            mySQLConnection.Close()
                        End If
                    End Try
                End If
            End If
        End If
        Call blank()
        Me.Grb2.Visible = True
        Me.Grb1.Visible = False
        GetData()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub
    Private Sub frmCTNHAP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Grb1.Visible = False
        Me.Grb2.Visible = True
        GetData()
        fillcombo("select MAMH,TENMH from tblMATHANG", "MH")
        fillcombo("select MANCC,TENNCC from tblNCC", "NCC")
        fillcbDate()
        Me.rAll.Checked = True
        iRscount = Me.BindingContext(dsDataSet, "tblCTNHAP").Count

        If power = "BAN" Then
            Me.cmdThemCTN.Enabled = False
            Me.btnSuaCTN.Enabled = False
            Me.btnHuyCTN.Enabled = False
            Me.cmdXoaCTN.Enabled = False
            Me.btnHoanThanh.Enabled = False
        End If
    End Sub

    Private Sub txtSOCTN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSOCTN.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSOCTN.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Vào Số Chứng Từ Nhập !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtSOCTN.Focus()
                Exit Sub
            Else
                If checkcode("tblCTNHAP", "SOCTN", Me.txtSOCTN.Text) = False Then
                    MessageBox.Show("Số Chứng Từ Nhập Này Đã Tồn Tại. Bạn Hãy Sửa Lại !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtSOCTN.Focus()
                    Exit Sub
                End If
            End If
            Me.txtNgayN.Focus()
        End If
    End Sub

    Private Sub txtNgayN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNgayN.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtNgayN.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Ngày Nhập Hàng Của Chứng Từ Nhập !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNgayN.Focus()
                Exit Sub
            Else
                If IsDate(Me.txtNgayN.Text) = False Then
                    MessageBox.Show("Giá Trị Kiểu Ngày Bạn Nhập Vào Không Hợp Lệ.Hãy Nhập Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNgayN.Focus()
                    Exit Sub
                Else
                    If checkDate(Me.txtNgayN.Text) <> 2 Then
                        MessageBox.Show("Bạn hãy nhập đúng định dạng ngày theo kiểu : Ngày/Tháng/Năm . ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtNgayN.Focus()
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtMANV_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.cbNCC.Focus()
        End If
    End Sub

    Private Sub txtMANCC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.cbMH.Focus()
        End If
    End Sub

    Private Sub txtMAMH_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.txtSL.Focus()
        End If
    End Sub

    Private Sub txtSL_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSL.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSL.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Số Lượng Của Mặt Hàng !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtSL.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtSL.Text) = False Then
                    MessageBox.Show("Giá Trị Bạn Nhập Vào Không Hợp Lệ,Số Lượng Hàng Phải Là Kiểu Số.Hãy Nhập Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtSL.Focus()
                    Exit Sub
                Else
                    If Len(Me.txtSL.Text) > 9 Then
                        MessageBox.Show("Giá trị của số quá lớn. Bạn hãy sửa lại !.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtSL.Focus()
                        Exit Sub
                    End If
                End If
            End If
            Me.txtDONGIA.Focus()
        End If
    End Sub

    Private Sub txtDONGIA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDONGIA.KeyPress
        If e.KeyChar = Chr(13) Then

            If Me.txtDONGIA.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Đơn Giá Của Mặt Hàng.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDONGIA.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtDONGIA.Text) = False Then
                    MessageBox.Show("Giá Trị Bạn Nhập Vào Không Hợp Lệ. Đơn Giá Phải Là Kiểu Số.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtDONGIA.Focus()
                    Exit Sub
                Else
                    If Len(Me.txtDONGIA.Text) > 9 Then
                        MessageBox.Show("Giá trị số của đơn giá quá lớn. Bạn hãy sửa lại. ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtDONGIA.Focus()
                        Exit Sub
                    End If
                    If Me.txtSL.Text = "" Then
                        MessageBox.Show("Bạn Hãy Cho Biết Số Lượng Của Mặt Hàng !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtSL.Focus()
                        Exit Sub
                    Else
                        If IsNumeric(Me.txtSL.Text) = False Then
                            MessageBox.Show("Giá Trị Bạn Nhập Vào Không Hợp Lệ,Số Lượng Hàng Phải Là Kiểu Số.Hãy Nhập Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.txtSL.Focus()
                            Exit Sub
                        Else
                            If Len(Me.txtSL.Text) > 9 Then
                                MessageBox.Show("Giá trị của số quá lớn. Bạn hãy sửa lại !.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.txtSL.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                End If

            End If
            Dim xTien As Decimal = 0
            Dim xxSL, xxDG As Decimal
            'xxSL = 0
            'xxSL = Me.txtSL.Text
            'xxDG = 0
            'xxDG = CDbl(Me.txtDONGIA.Text)
            'xTien = xxSL * xxDG
            Me.txtThanhTien.Text = ""
            Me.txtThanhTien.Text = Me.txtSL.Text * Me.txtDONGIA.Text 'xTien
            Dim oTG As Decimal = 0
            If Me.txtTONGTIEN.Text <> "" Then
                oTG = Me.txtTONGTIEN.Text
            Else
                oTG = 0
            End If
            If Me.cmdSave.Text = "Lưu" Then
                Me.txtTONGTIEN.Text = oTG + Me.txtThanhTien.Text
            Else

                Me.txtTONGTIEN.Text = oTG - oTT + Me.txtThanhTien.Text
            End If
            If Me.txtDATRA.Text <> "" Then
                Me.txtNO.Text = ""
                Me.txtNO.Text = Me.txtTONGTIEN.Text - Me.txtDATRA.Text
            End If
            Me.txtDONGIA.Enabled = False
            Me.txtThanhTien.Enabled = False
            Me.cmdSave.Focus()
        End If
    End Sub

    Private Sub txtDATRA_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDATRA.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtDATRA.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Số Tiền Đã Trả.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDATRA.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtDATRA.Text) = False Then
                    MessageBox.Show("Dữ Liệu Bạn Nhập Vào Không hợp Lệ, Số Tiền Đã Trả Phải Là Kiểu Số.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtDATRA.Focus()
                    Exit Sub
                Else
                    If Len(Me.txtDATRA.Text) > 9 Then
                        MessageBox.Show("Dữ Liệu Bạn Nhập Vào Không hợp Lệ, Số Tiền Đã Trả Có Giá Trị Quá Lớn .", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtDATRA.Focus()
                        Exit Sub
                    End If
                    If CDec(Me.txtDATRA.Text) > CDec(Me.txtTONGTIEN.Text) Then
                        MessageBox.Show("Dữ Liệu Bạn Nhập Vào Không hợp Lệ, Số Tiền Đã Trả Phải Nhỏ Hơn Hoặc Bằng Tổng Số Tiền Mua.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtDATRA.Focus()
                        Exit Sub
                    End If
                    If Me.txtTONGTIEN.Text = "" Then
                        MessageBox.Show("Bạn hãy cho biết tổng tiền của chứng từ nhập.", " Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtTONGTIEN.Focus()
                        Exit Sub
                    End If
                    Me.txtNO.Text = ""
                    Me.txtNO.Text = Me.txtTONGTIEN.Text - Me.txtDATRA.Text
                    Me.txtNgayHenTra.Focus()
                End If
                Me.txtNO.Enabled = False
                Me.txtNgayHenTra.Focus()
            End If
        End If
    End Sub

    Private Sub txtNgayHenTra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNgayHenTra.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtNgayHenTra.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Ngày Hẹn Trả Của Chứng Từ Nhập !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNgayHenTra.Focus()
                Exit Sub
            Else
                If IsDate(Me.txtNgayHenTra.Text) = False Then
                    MessageBox.Show("Giá Trị Kiểu Ngày Bạn Nhập Vào Không Hợp Lệ.Hãy Nhập Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNgayHenTra.Focus()
                    Exit Sub
                Else
                    If checkDate(Me.txtNgayHenTra.Text) <> 2 Then
                        MessageBox.Show("Bạn hãy nhập đúng định dạng ngày theo kiểu : Ngày/Tháng/Năm . ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtNgayHenTra.Focus()
                        Exit Sub
                    End If
                End If
            End If
            Me.btnHoanThanh.Focus()
        End If
    End Sub

    Private Sub CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox.CheckedChanged
        If Me.CheckBox.Checked = True Then
            Me.txtDATRA.Enabled = False
            Me.txtNO.Enabled = False
            Me.txtNgayHenTra.Enabled = False
            Me.btnThemMH.Enabled = False
            Me.btnXoaMH.Enabled = False
            Me.btnSua.Enabled = False
            If okSua = False Then
                Me.cmdSave.Enabled = False
            End If
            Me.cmdSave.Focus()

        Else
            Me.txtDATRA.Enabled = True
            Me.txtNO.Enabled = True
            Me.btnThemMH.Enabled = True
            Me.btnXoaMH.Enabled = True
            Me.btnSua.Enabled = True
            Me.cmdSave.Enabled = True
            Me.txtNgayHenTra.Enabled = True
        End If
    End Sub

    Private Sub btnHuyCTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuyCTN.Click
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá Bỏ Hoá Đơn Nhập Hàng Này Không ?", "Xin Chào !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call delItem2("tblCTNHAP", "SOCTN", Me.txtSOCTN.Text, "Hoá Đơn Nhập Hàng")
            Call delItem2("tblNHAPKHO", "SOCTN", Me.txtSOCTN.Text, "Hoá Đơn Nhập Hàng")
            Me.txtSOCTN.Enabled = True
            Me.txtNgayN.Enabled = True

            Me.CheckBox.Checked = False
            blank()
            Call fillDgMH(Me.txtSOCTN.Text)
            xGhiMoi = False
            okThem = True
            okSua = False
            xMA = ""
            Me.txtSOCTN.Focus()
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSua.Click

        'MsgBox(Me.dgMHNhap.CurrentCell.RowNumber)
        'MsgBox(Me.dgMHNhap.Item(Me.dgMHNhap.CurrentCell.RowNumber + 1, 1))

        'MsgBox(Me.dgMHNhap.VisibleRowCount - 1)
        'Exit Sub

        If Me.dgMHNhap.VisibleRowCount < 2 Then
            MessageBox.Show("Không có bất kì mặt hàng nào trong lưới dữ liệu. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Me.cbMH.DropDownStyle = ComboBoxStyle.DropDown
        Me.cbMH.Text = ""
        oMAMH = Me.dgMHNhap.Item(Me.dgMHNhap.CurrentCell.RowNumber, 1)

        Me.cbMH.Text = Me.dgMHNhap.Item(Me.dgMHNhap.CurrentCell.RowNumber, 1)
        oSL = 0
        oDG = 0
        oTT = 0
        oSL = Me.dgMHNhap.Item(Me.dgMHNhap.CurrentCell.RowNumber, 3)
        oDG = Me.dgMHNhap.Item(Me.dgMHNhap.CurrentCell.RowNumber, 4)
        oVITRI = Me.dgMHNhap.CurrentCell.RowNumber
        Me.txtSL.Text = ""
        Me.txtSL.Text = Me.dgMHNhap.Item(Me.dgMHNhap.CurrentCell.RowNumber, 3)
        Me.txtDONGIA.Text = ""
        Me.txtDONGIA.Text = Me.dgMHNhap.Item(Me.dgMHNhap.CurrentCell.RowNumber, 4)
        Me.txtThanhTien.Text = ""
        oTT = Me.txtSL.Text * Me.txtDONGIA.Text
        Me.txtThanhTien.Text = oTT
        Me.txtThanhTien.Enabled = False
        Me.cmdSave.Text = "Cập Nhật"
    End Sub


    Private Sub cbNCC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbNCC.KeyPress
        If e.KeyChar = "D" Or e.KeyChar = "d" Then
            Me.cbNCC.DroppedDown = True
        End If
        If e.KeyChar = Chr(13) Then
            If Me.cbNCC.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết tên nhà cung cấp !.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cbNCC.Focus()
                Exit Sub
            End If
            Me.cbMH.Focus()
        End If
    End Sub

    Private Sub cbMH_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbMH.KeyPress
        If e.KeyChar = "D" Or e.KeyChar = "d" Then
            Me.cbMH.DroppedDown = True
        End If
        If e.KeyChar = Chr(13) Then
            If Me.cbMH.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết tên của mặt hàng !.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cbMH.Focus()
                Exit Sub
            End If
            Me.txtSL.Focus()
        End If
    End Sub

    Private Sub cmdSave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmdSave.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cbMH.Focus()
        End If
    End Sub

    Private Sub rAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rAll.CheckedChanged
        Me.cbNgay.Enabled = False
        Me.cbThang.Enabled = False
        Me.cbNam.Enabled = False
        Me.txtCTN.Enabled = False
        Me.txtCTN.Text = ""
        Me.cbNgay.Text = ""
        Me.cbThang.Text = ""
        Me.cbNam.Text = ""
        GetData()

        iRscount = Me.BindingContext(dsDataSet, "tblCTNHAP").Count

    End Sub

    Private Sub rMa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rMa.CheckedChanged
        Me.txtCTN.Enabled = True
        Me.txtCTN.Text = ""
        Me.cbNgay.Enabled = False
        Me.cbThang.Enabled = False
        Me.cbNam.Enabled = False
        iRscount = Me.BindingContext(dsDataSet, "tblCTNHAP").Count

    End Sub

    Private Sub rNgay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rNgay.CheckedChanged
        Me.cbNgay.Enabled = True
        Me.cbThang.Enabled = True
        Me.cbNam.Enabled = True
        Me.txtCTN.Enabled = False
        Me.cbNgay.Text = ""
        Me.cbThang.Text = ""
        Me.cbNam.Text = ""
        iRscount = Me.BindingContext(dsDataSet, "tblCTNHAP").Count
    End Sub

    Private Sub tabCTN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabCTN.SelectedIndexChanged
        GetData()
        iRscount = Me.BindingContext(dsDataSet, "tblCTNHAP").Count
    End Sub

    Private Sub cbThang_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbThang.SelectedIndexChanged
        GetData()
        iRscount = Me.BindingContext(dsDataSet, "tblCTNHAP").Count
    End Sub

    Private Sub cbNam_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNam.SelectedIndexChanged
        GetData()
        iRscount = Me.BindingContext(dsDataSet, "tblCTNHAP").Count
    End Sub

    Private Sub txtCTN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCTN.KeyPress
        If e.KeyChar = Chr(13) Then
            GetData()
            iRscount = Me.BindingContext(dsDataSet, "tblCTNHAP").Count

        End If
    End Sub
    Private Sub cbNgay_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNgay.SelectedIndexChanged
        GetData()
        iRscount = Me.BindingContext(dsDataSet, "tblCTNHAP").Count
    End Sub

    Private Sub btnSuaCTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSuaCTN.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống rỗng. Bạn không thể thực hiện chức năng này.  ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If


        Me.btnHoanThanh.Enabled = False
        okSua = True
        okThem = False
        xGhiMoi = True
        xMA = ""
        xMA = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Sửa Chứng Từ Nhập Có Số Chứng Từ Nhập Là:  " & xMA & " Hay Không ?.", "Chào Bạn !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Me.Grb1.Visible = True
            Me.Grb2.Visible = False
            blank()
            Me.cbNCC.DropDownStyle = ComboBoxStyle.DropDown
            Me.txtSOCTN.Enabled = True
            Me.txtNgayN.Enabled = True
            Me.CheckBox.Checked = False
            Dim xtg As String = ""
            xtg = dgView.Item(dgView.CurrentCell.RowNumber, 0)
            Me.txtSOCTN.Text = xtg
            Me.txtNgayN.Text = dgView.Item(dgView.CurrentCell.RowNumber, 1)
            Me.cbNCC.Text = dgView.Item(dgView.CurrentCell.RowNumber, 3)
            Me.txtTONGTIEN.Text = Me.dgView.Item(dgView.CurrentCell.RowNumber, 4)
            Dim xTONGTIEN = CDec(dgView.Item(dgView.CurrentCell.RowNumber, 4))
            Dim xTRA = CDec(dgView.Item(dgView.CurrentCell.RowNumber, 5))
            Me.txtDATRA.Text = (dgView.Item(dgView.CurrentCell.RowNumber, 5))
            Me.txtNO.Text = dgView.Item(dgView.CurrentCell.RowNumber, 6)

            If xTRA < xTONGTIEN Or Me.txtNO.Text < 0 Then
                Me.txtNgayHenTra.Text = dgView.Item(dgView.CurrentCell.RowNumber, 7)
            Else
                Me.txtNgayHenTra.Text = ""
            End If

            Call fillDgMH(xtg)
        End If
        Me.btnThemMH.Enabled = True
        Me.btnXoaMH.Enabled = True
        Me.btnSua.Enabled = True
        Me.btnHuyCTN.Enabled = True
        Me.cmdNew.Enabled = True
        Me.cmdSave.Enabled = True


    End Sub

    Private Sub btnChiTiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChiTiet.Click

        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống rỗng. Bạn không thể thực hiện chức năng này.  ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        xGhiMoi = True

        xMA = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        Me.Grb1.Visible = True
        Me.Grb2.Visible = False
        blank()
        Me.txtSOCTN.Enabled = True
        Me.txtNgayN.Enabled = True
        Me.CheckBox.Checked = False
        Me.btnHoanThanh.Enabled = False
        Dim xtg As String = ""
        xtg = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        Me.txtSOCTN.Text = xtg
        Me.txtNgayN.Text = dgView.Item(dgView.CurrentCell.RowNumber, 1)
        Me.cbNCC.Text = dgView.Item(dgView.CurrentCell.RowNumber, 3)
        Me.txtTONGTIEN.Text = Me.dgView.Item(dgView.CurrentCell.RowNumber, 4)
        Dim xTONGTIEN = CDec(dgView.Item(dgView.CurrentCell.RowNumber, 4))
        Dim xTRA = CDec(dgView.Item(dgView.CurrentCell.RowNumber, 5))
        Me.txtDATRA.Text = (dgView.Item(dgView.CurrentCell.RowNumber, 5))
        Me.txtNO.Text = dgView.Item(dgView.CurrentCell.RowNumber, 6)

        If xTRA <> xTONGTIEN Then
            Me.txtNgayHenTra.Text = dgView.Item(dgView.CurrentCell.RowNumber, 7)
        Else
            Me.txtNgayHenTra.Text = ""
        End If
        Call fillDgMH(xtg)

        Me.btnThemMH.Enabled = False
        Me.btnXoaMH.Enabled = False
        Me.btnSua.Enabled = False
        Me.btnHuyCTN.Enabled = False
        Me.cmdNew.Enabled = False
        Me.cmdSave.Enabled = False

        Me.cmdBack.Focus()
    End Sub

    Private Sub btnThemMH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnThemMH.Click
        If Me.cmdSave.Text <> "Lưu" Then
            Me.cmdSave.Text = "Lưu"
        End If
        Me.cbMH.Text = ""
        Me.txtSL.Text = ""
        Me.txtDONGIA.Text = ""
        Me.txtThanhTien.Text = ""

        Me.cbMH.Focus()
    End Sub


    Private Sub btnHoanThanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHoanThanh.Click
        If Me.txtSOCTN.Text = "" Then
            MessageBox.Show("Bạn Hãy Nhập Vào Số Chứng Từ Nhập !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtSOCTN.Focus()
            Exit Sub
        End If
        If Me.txtNgayN.Text = "" Then
            MessageBox.Show("Bạn Hãy Cho Biết Ngày Nhập Hàng Của Chứng Từ Nhập !.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtNgayN.Focus()
            Exit Sub
        Else
            If IsDate(Me.txtNgayN.Text) = False Then
                MessageBox.Show("Giá Trị Kiểu Ngày Bạn Nhập Vào Không Hợp Lệ.Hãy Nhập Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNgayN.Focus()
                Exit Sub
            Else
                If checkDate(Me.txtNgayN.Text) <> 2 Then
                    MessageBox.Show("Bạn hãy nhập đúng định dạng ngày theo kiểu : Ngày/Tháng/Năm . ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNgayN.Focus()
                    Exit Sub
                End If
            End If
        End If
        If Me.cbNCC.Text = "" Then
            MessageBox.Show("Bạn hãy cho biết nhà cung cấp hàng !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbNCC.Focus()
            Exit Sub
        End If
        If Me.CheckBox.Checked = False Then
            If Me.txtDATRA.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Số Tiền Đã Trả Của Chứng Từ Nhập Này.", "Chào Bạn !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDATRA.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtDATRA.Text) = False Then
                    MessageBox.Show("Số Tiền Đã Trả Của Chứng Từ Nhập Phải Là Kiểu Số. Bạn Hãy Sửa Lại ! ", "Chào Bạn !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtDATRA.Focus()
                    Exit Sub
                Else
                    If Len(Me.txtDATRA.Text) > 9 Then
                        MessageBox.Show("Giá trị của số quá lớn. Bạn hãy sửa lại !. ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtDATRA.Focus()
                        Exit Sub
                    End If
                End If
            End If
            If Me.txtNO.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Số Tiền Còn Nợ Lại.", "Chào bạn !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNO.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtNO.Text) = False Then
                    MessageBox.Show("Số Tiền Còn Nợ Của Chứng Từ Nhập Phải Là Kiểu Số. Bạn Hãy Sửa Lại ! ", "Chào Bạn !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNO.Focus()
                    Exit Sub
                End If
            End If
            If Me.txtNgayHenTra.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Ngày Hẹn Trả Số Tiền Còn Nợ.", "Chào Bạn !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNgayHenTra.Focus()
                Exit Sub
            Else
                If IsDate(Me.txtNgayHenTra.Text) = False Then
                    MessageBox.Show("Định dạng ngày nhập không hợp lệ, phải có định dạng: Ngày/Tháng/Năm. Hãy sửa lại !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNgayHenTra.Focus()
                    Exit Sub
                Else
                    If checkDate(Me.txtNgayHenTra.Text) <> 2 Then
                        MessageBox.Show("Bạn hãy nhập đúng định dạng ngày theo kiểu : Ngày/Tháng/Năm . ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtNgayHenTra.Focus()
                        Exit Sub
                    End If
                End If
            End If
        End If
        Dim xxok As Boolean = True
        Dim cmdCT As New SqlCommand()

        Dim str1 = "update tblCTNHAP set SOCTN='" & UCase(Me.txtSOCTN.Text) & "',NGAYN='" & Me.txtNgayN.Text & "',MANCC='" & UCase(SplitCode("NCC")) & "',TONGGIATRI=" & Me.txtTONGTIEN.Text & ",DATRA=" & Me.txtTONGTIEN.Text & ",CONNO=0 where SOCTN='" & Me.txtSOCTN.Text & "'"
        Dim str2 = "update tblCTNHAP set SOCTN='" & UCase(Me.txtSOCTN.Text) & "',NGAYN='" & Me.txtNgayN.Text & "',MANCC='" & UCase(SplitCode("NCC")) & "',TONGGIATRI=" & Me.txtTONGTIEN.Text & ",DATRA=" & Me.txtDATRA.Text & ",CONNO=" & Me.txtNO.Text & ",NGAYHENTRA='" & Me.txtNgayHenTra.Text & "' where SOCTN='" & Me.txtSOCTN.Text & "'"
        If Me.CheckBox.Checked = True Then
            cmdCT = New SqlCommand(str1, mySQLConnection)
        Else
            cmdCT = New SqlCommand(str2, mySQLConnection)
        End If
        Try
            mySQLConnection.Open()
            cmdCT.ExecuteNonQuery()
        Catch
            MessageBox.Show("Không thể ghi đủ những thông tin của chứng từ nhập này. Hãy thử lại !.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            xxok = False
        Finally
            If mySQLConnection.State = ConnectionState.Open Then
                mySQLConnection.Close()
            End If
        End Try
        If xxok Then
            Me.cbNCC.DropDownStyle = ComboBoxStyle.DropDown
            Me.cbNCC.Text = ""
            Call blank()
            Call fillDgMH(Me.txtSOCTN.Text)
            xGhiMoi = True
            okSua = False
            okThem = True
            Me.txtSOCTN.Focus()
            Me.cbNCC.DropDownStyle = ComboBoxStyle.DropDownList
        End If
        Me.txtNO.Enabled = True
    End Sub

    Private Sub btnXoaMH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoaMH.Click
        If Me.dgMHNhap.VisibleRowCount < 2 Then
            MessageBox.Show("Không có bất kì mặt hàng nào trong lưới dữ liệu. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim xx As String = ""
        Dim xxSl, xxDg As Decimal
        xxSl = 0
        xxDg = 0
        xxSl = Me.dgMHNhap.Item(Me.dgMHNhap.CurrentCell.RowNumber, 3)
        xxDg = Me.dgMHNhap.Item(Me.dgMHNhap.CurrentCell.RowNumber, 4)
        xx = Me.dgMHNhap.Item(Me.dgMHNhap.CurrentCell.RowNumber, 1)
        If MessageBox.Show("Bạn có thật sự muốn xoá mặt hàng " & xx & " hay không ?.", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'xoa mat hang
            Dim xok As Boolean = True
            Dim mySQLConnection As New SqlConnection(strconn)
            Dim cmd As New SqlCommand("delete from tblNHAPKHO where MAMH='" & xx & "' and SOCTN='" & Me.txtSOCTN.Text & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                cmd.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không Thể Xoá Mặt Hàng Có Mã : " & xx, "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                xok = False
            Finally
                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try
            If xok Then
                Dim xxTg As Decimal = 0
                xxTg = Me.txtTONGTIEN.Text
                Me.txtTONGTIEN.Text = xxTg - xxSl * xxDg
                Call fillDgMH(Me.txtSOCTN.Text)
                If Me.txtDATRA.Text <> "" Then
                    Me.txtNO.Text = ""
                    Me.txtNO.Text = Me.txtTONGTIEN.Text - Me.txtDATRA.Text
                End If
            End If
            'xoa xong phai cap nhat lai du lieu
            Dim cmdUpdate1 As New SqlCommand("update tblCTNHAP set TONGGIATRI=" & Me.txtTONGTIEN.Text & " where SOCTN='" & Me.txtSOCTN.Text & "'", mySQLConnection)
            Dim cmdUpdate2 As New SqlCommand("update tblCTNHAP set TONGGIATRI=" & Me.txtTONGTIEN.Text & ",DATRA=" & Me.txtDATRA.Text & ",CONNO=" & Me.txtNO.Text & ",NGAYHENTRA='" & Me.txtNgayHenTra.Text & "' where SOCTN='" & Me.txtSOCTN.Text & "'", mySQLConnection)

            Try
                mySQLConnection.Open()
                If Me.txtDATRA.Text <> "" And Me.txtNO.Text <> "" Then
                    cmdUpdate2.ExecuteNonQuery()
                    ' chu y neu can thiet thi bat loi nhu: Tong tien, ngay hen tra ...
                Else
                    cmdUpdate1.ExecuteNonQuery()
                End If
            Catch
                MessageBox.Show("Không thể cập nhật được thông tin đối với tổng số tiền sau khi xoá. Bạn hãy thử lại hoặc sửa lại thông tin cho đúng", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                If mySQLConnection.State = ConnectionState.Open Then
                    mySQLConnection.Close()
                End If
            End Try


        End If
    End Sub

    Private Sub cmDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmDong.Click
        If xGhiMoi = False Then
            If MessageBox.Show("Bạn có muốn lưu chứng từ nhập này không?. Bạn chọn Yes để Lưu, nếu bạn chọn No thì chứng từ nhập này sẽ bị xoá. ", "Thông báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                MessageBox.Show("Bạn hãy kích vào nút --Hoàn Thành Nhập-- để kết thúc.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            Else
                ' goi thu tuc xoa chung tu nhap
                If Me.txtSOCTN.Text <> "" Then
                    Dim del As New SqlCommand("delete from tblNHAPKHO where SOCTN='" & Me.txtSOCTN.Text & "'", mySQLConnection)
                    Dim cmdDel As New SqlCommand("delete  from tblCTNHAP where SOCTN='" & Me.txtSOCTN.Text & "'", mySQLConnection)
                    Try
                        mySQLConnection.Open()
                        del.ExecuteNonQuery()
                        cmdDel.ExecuteNonQuery()
                    Catch
                        MessageBox.Show("Không thể xoá chứng từ nhập này, cũng có thể chứng từ nhập này không tồn tại. Hãy thử lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Finally
                        If mySQLConnection.State = ConnectionState.Open Then
                            mySQLConnection.Close()
                        End If
                    End Try
                End If
            End If
        End If

        Me.Hide()
    End Sub




    Private Sub lbID_Click(sender As Object, e As EventArgs) Handles lbID.Click

    End Sub


End Class