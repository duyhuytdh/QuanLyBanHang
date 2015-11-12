Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Public Class frmMain
    Inherits System.Windows.Forms.Form

    Dim cmcontextmenu As New ContextMenu()
    Dim menuitemA As New MenuItem("Thoát Alt+F4")
    Dim menuitemB As New MenuItem("Thay Đổi Mật Khẩu")
    'Dim menuitemC As New MenuItem("Đăng Nhập Hệ Thống")
    Dim menuitemD As New MenuItem("Thông Tin Về Sản Phẩm")
    Dim menuitemE As New MenuItem("Hướng Dẫn Sử Dụng Chương Trình")
    Private WithEvents frmNhanvien As frmNhanvien
    Private WithEvents frmNHOMMH As frmNHOMMH
    Private WithEvents frmchangepass As frmchangepass
    Private WithEvents frmNUOC As frmNUOC
    Private WithEvents childform1 As frmFlash
    Private WithEvents frmMathang As frmMathang
    Private WithEvents frmNCC As frmNCC
    Private WithEvents frmKhach As frmKhach
    Private WithEvents frmCTNHAP As frmCTNHAP
    Private WithEvents frmCTXUAT As frmCTXUAT
    Private WithEvents frmBanHang2 As frmBanHang2
    Private WithEvents frmBanHang As frmBanHang
    Private WithEvents frmBAOCAO As frmBAOCAO
    Private WithEvents frmTTSP As frmTTSP
    Private WithEvents frmThemNSD As frmThemNSD
    'Private WithEvents Hoang_Help As  
    Dim childform2 As frmLogin


    Private Sub startup()
        childform1 = New frmFlash()
        childform1.Show()
        childform1.Refresh()
        Dim i As Long = 0
        For i = 0 To 140000000
        Next
        childform1.Hide()
    End Sub

    Private Sub addcontexmenu()
        With cmcontextmenu
            .MenuItems.Add(menuitemA)
            .MenuItems.Add(menuitemB)

            .MenuItems.Add(menuitemD)
            .MenuItems.Add(menuitemE)
            ntfIcon.ContextMenu = cmcontextmenu
            AddHandler menuitemA.Click, AddressOf mnuThoat_Click
            AddHandler menuitemB.Click, AddressOf mnuChangepass_Click

            AddHandler menuitemD.Click, AddressOf mnuTTSP_Click
            AddHandler menuitemE.Click, AddressOf mnuTroGiup_Click
        End With
    End Sub
#Region " Windows Form Designer generated code "


    Public Sub New()

        MyBase.New()


        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Call startup()
        addcontexmenu()
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

    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuNHOMMH As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents A As System.Windows.Forms.StatusBarPanel
    Friend WithEvents B As System.Windows.Forms.StatusBarPanel
    Friend WithEvents C As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ntfIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents mnuChangepass As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNuocSX As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNhanvien As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMathang As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNCC As System.Windows.Forms.MenuItem
    Friend WithEvents mnuKhach As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCTNHAP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCTXUAT As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBanHang As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBaoCao As System.Windows.Forms.MenuItem
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents Timer_Stop As System.Timers.Timer
    Friend WithEvents mnuHeThong As System.Windows.Forms.MenuItem
    Friend WithEvents mnuDanhMuc As System.Windows.Forms.MenuItem
    Friend WithEvents mnuNhapXuat As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReports As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents listimg As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton4 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton7 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton11 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton12 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton13 As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuThoat As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTTSP As System.Windows.Forms.MenuItem
    Friend WithEvents toolbtnBan As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuThemNguoiSD As System.Windows.Forms.MenuItem
    Friend WithEvents toolbtnThemNSD As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton14 As System.Windows.Forms.ToolBarButton
    Friend WithEvents StatusBarPanel1 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents mnuTroGiup As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBanHang2 As System.Windows.Forms.MenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMain))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.mnuHeThong = New System.Windows.Forms.MenuItem()
        Me.mnuChangepass = New System.Windows.Forms.MenuItem()
        Me.mnuThemNguoiSD = New System.Windows.Forms.MenuItem()
        Me.mnuThoat = New System.Windows.Forms.MenuItem()
        Me.mnuDanhMuc = New System.Windows.Forms.MenuItem()
        Me.mnuNHOMMH = New System.Windows.Forms.MenuItem()
        Me.mnuMathang = New System.Windows.Forms.MenuItem()
        Me.mnuNuocSX = New System.Windows.Forms.MenuItem()
        Me.mnuNCC = New System.Windows.Forms.MenuItem()
        Me.mnuNhanvien = New System.Windows.Forms.MenuItem()
        Me.mnuKhach = New System.Windows.Forms.MenuItem()
        Me.mnuNhapXuat = New System.Windows.Forms.MenuItem()
        Me.mnuBanHang = New System.Windows.Forms.MenuItem()
        Me.mnuCTNHAP = New System.Windows.Forms.MenuItem()
        Me.mnuCTXUAT = New System.Windows.Forms.MenuItem()
        Me.mnuBanHang2 = New System.Windows.Forms.MenuItem()
        Me.mnuReports = New System.Windows.Forms.MenuItem()
        Me.mnuBaoCao = New System.Windows.Forms.MenuItem()
        Me.mnuHelp = New System.Windows.Forms.MenuItem()
        Me.mnuTroGiup = New System.Windows.Forms.MenuItem()
        Me.mnuTTSP = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.StatusBar = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.B = New System.Windows.Forms.StatusBarPanel()
        Me.C = New System.Windows.Forms.StatusBarPanel()
        Me.A = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton()
        Me.toolbtnThemNSD = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton4 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton7 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton()
        Me.toolbtnBan = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton14 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton11 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton12 = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButton13 = New System.Windows.Forms.ToolBarButton()
        Me.listimg = New System.Windows.Forms.ImageList(Me.components)
        Me.ntfIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry()
        Me.Timer_Stop = New System.Timers.Timer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.A, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timer_Stop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHeThong, Me.mnuDanhMuc, Me.mnuNhapXuat, Me.mnuReports, Me.mnuHelp})
        '
        'mnuHeThong
        '
        Me.mnuHeThong.Index = 0
        Me.mnuHeThong.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuChangepass, Me.mnuThemNguoiSD, Me.mnuThoat})
        Me.mnuHeThong.Text = "Hệ &Thống"
        '
        'mnuChangepass
        '
        Me.mnuChangepass.Index = 0
        Me.mnuChangepass.Shortcut = System.Windows.Forms.Shortcut.CtrlM
        Me.mnuChangepass.Text = "Thay Đổi &Mật Khẩu  "
        '
        'mnuThemNguoiSD
        '
        Me.mnuThemNguoiSD.Index = 1
        Me.mnuThemNguoiSD.Shortcut = System.Windows.Forms.Shortcut.CtrlD
        Me.mnuThemNguoiSD.Text = "Thêm Người Sử &Dụng"
        '
        'mnuThoat
        '
        Me.mnuThoat.Index = 2
        Me.mnuThoat.Shortcut = System.Windows.Forms.Shortcut.CtrlT
        Me.mnuThoat.Text = "&Thoát Khỏi Hệ Thống"
        '
        'mnuDanhMuc
        '
        Me.mnuDanhMuc.Index = 1
        Me.mnuDanhMuc.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuNHOMMH, Me.mnuMathang, Me.mnuNuocSX, Me.mnuNCC, Me.mnuNhanvien, Me.mnuKhach})
        Me.mnuDanhMuc.Text = "&Các Danh Mục"
        '
        'mnuNHOMMH
        '
        Me.mnuNHOMMH.Index = 0
        Me.mnuNHOMMH.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.mnuNHOMMH.Text = "&Nhóm Mặt Hàng"
        '
        'mnuMathang
        '
        Me.mnuMathang.Index = 1
        Me.mnuMathang.Shortcut = System.Windows.Forms.Shortcut.CtrlH
        Me.mnuMathang.Text = "Danh Sách Các Mặt Hàng"
        '
        'mnuNuocSX
        '
        Me.mnuNuocSX.Index = 2
        Me.mnuNuocSX.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.mnuNuocSX.Text = "Danh Sách  Nước Sản Xuất"
        '
        'mnuNCC
        '
        Me.mnuNCC.Index = 3
        Me.mnuNCC.Shortcut = System.Windows.Forms.Shortcut.CtrlC
        Me.mnuNCC.Text = "Danh Sách Nhà Cung Cấp"
        '
        'mnuNhanvien
        '
        Me.mnuNhanvien.Index = 4
        Me.mnuNhanvien.Shortcut = System.Windows.Forms.Shortcut.CtrlV
        Me.mnuNhanvien.Text = "Danh Sách Nhân &Viên"
        '
        'mnuKhach
        '
        Me.mnuKhach.Index = 5
        Me.mnuKhach.Shortcut = System.Windows.Forms.Shortcut.CtrlK
        Me.mnuKhach.Text = "Danh Sách Khách Hàng "
        '
        'mnuNhapXuat
        '
        Me.mnuNhapXuat.Index = 2
        Me.mnuNhapXuat.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBanHang, Me.mnuCTNHAP, Me.mnuCTXUAT, Me.mnuBanHang2})
        Me.mnuNhapXuat.Text = "Nhập Xuất Hàng"
        '
        'mnuBanHang
        '
        Me.mnuBanHang.Index = 0
        Me.mnuBanHang.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.mnuBanHang.Text = "Bán Hàng"
        '
        'mnuCTNHAP
        '
        Me.mnuCTNHAP.Index = 1
        Me.mnuCTNHAP.Shortcut = System.Windows.Forms.Shortcut.CtrlJ
        Me.mnuCTNHAP.Text = "Chứng Từ Nhập Hàng"
        '
        'mnuCTXUAT
        '
        Me.mnuCTXUAT.Index = 2
        Me.mnuCTXUAT.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.mnuCTXUAT.Text = "Chứng Từ Xuất Hàng"
        '
        'mnuBanHang2
        '
        Me.mnuBanHang2.Index = 3
        Me.mnuBanHang2.Text = "Bán Hàng"
        '
        'mnuReports
        '
        Me.mnuReports.Index = 3
        Me.mnuReports.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBaoCao})
        Me.mnuReports.Text = "&Báo Cáo"
        '
        'mnuBaoCao
        '
        Me.mnuBaoCao.Index = 0
        Me.mnuBaoCao.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.mnuBaoCao.Text = "Báo Cáo"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 4
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuTroGiup, Me.mnuTTSP, Me.MenuItem1})
        Me.mnuHelp.Text = "Trợ &Giúp"
        '
        'mnuTroGiup
        '
        Me.mnuTroGiup.Index = 0
        Me.mnuTroGiup.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.mnuTroGiup.Text = "Hướng Dẫn Sử Dụng Phần Mềm"
        '
        'mnuTTSP
        '
        Me.mnuTTSP.Index = 1
        Me.mnuTTSP.Shortcut = System.Windows.Forms.Shortcut.F2
        Me.mnuTTSP.Text = "Thông Tin Về &Sản Phẩm"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 2
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem2, Me.MenuItem3, Me.MenuItem4})
        Me.MenuItem1.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.MenuItem1.Text = "Tìm Kiếm"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 0
        Me.MenuItem2.Text = "Hoá Đơn bán Hàng"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.Text = "Hoá Đơn Nhập Hàng"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.Text = ""
        '
        'StatusBar
        '
        Me.StatusBar.Location = New System.Drawing.Point(0, 371)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel2, Me.B, Me.C, Me.A, Me.StatusBarPanel1})
        Me.StatusBar.ShowPanels = True
        Me.StatusBar.Size = New System.Drawing.Size(624, 22)
        Me.StatusBar.TabIndex = 3
        Me.StatusBar.Text = "StatusBar1"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "CopyRight : Đinh Đức Hoàng"
        Me.StatusBarPanel2.ToolTipText = "Người Viết Chương Trình"
        Me.StatusBarPanel2.Width = 170
        '
        'B
        '
        Me.B.Text = "Email : ThaiNguyenKing81@yahoo.com"
        Me.B.ToolTipText = "Địa Chỉ Email Của Tác Giả"
        Me.B.Width = 200
        '
        'C
        '
        Me.C.Text = "Tel : 0280.822253"
        Me.C.ToolTipText = "Số Điện Thoại Liên Hệ Với Tác Giả"
        '
        'A
        '
        Me.A.ToolTipText = "Ngày Được Tính Theo Dương Lịch"
        Me.A.Width = 150
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.Text = "Ready"
        Me.StatusBarPanel1.ToolTipText = "Chương Trình Đã Sẵn Sàng Làm Việc"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton2, Me.toolbtnThemNSD, Me.ToolBarButton3, Me.ToolBarButton4, Me.ToolBarButton5, Me.ToolBarButton6, Me.ToolBarButton7, Me.ToolBarButton8, Me.ToolBarButton9, Me.ToolBarButton10, Me.toolbtnBan, Me.ToolBarButton14, Me.ToolBarButton11, Me.ToolBarButton12, Me.ToolBarButton13})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(23, 22)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.listimg
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(624, 25)
        Me.ToolBar1.TabIndex = 6
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.ToolTipText = "Thoát Khỏi Hệ Thống"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.ToolTipText = "Thay Đổi Mật Khẩu"
        '
        'toolbtnThemNSD
        '
        Me.toolbtnThemNSD.ImageIndex = 34
        Me.toolbtnThemNSD.ToolTipText = "Thêm Người Sử Dụng Mới"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 47
        Me.ToolBarButton3.ToolTipText = "Danh Sách Nhóm Mặt Hàng"
        '
        'ToolBarButton4
        '
        Me.ToolBarButton4.ImageIndex = 6
        Me.ToolBarButton4.ToolTipText = "Danh Sách Các Mặt Hàng"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.ImageIndex = 20
        Me.ToolBarButton5.ToolTipText = "Danh Sách Nước Sản Xuất"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.ImageIndex = 2
        Me.ToolBarButton6.ToolTipText = "Danh Sách Nhà Cung Cấp"
        '
        'ToolBarButton7
        '
        Me.ToolBarButton7.ImageIndex = 18
        Me.ToolBarButton7.ToolTipText = "Danh Sách Nhân Viên"
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.ImageIndex = 7
        Me.ToolBarButton8.ToolTipText = "Danh Sách Khách Hàng"
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.ImageIndex = 44
        Me.ToolBarButton9.ToolTipText = "Chứng Từ Nhập Hàng"
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.ImageIndex = 40
        Me.ToolBarButton10.ToolTipText = "Danh Sách Chứng Từ Bán Hàng"
        '
        'toolbtnBan
        '
        Me.toolbtnBan.ImageIndex = 38
        Me.toolbtnBan.ToolTipText = "Bán Hàng"
        '
        'ToolBarButton14
        '
        Me.ToolBarButton14.ImageIndex = 59
        Me.ToolBarButton14.ToolTipText = " Báo Cáo "
        '
        'ToolBarButton11
        '
        Me.ToolBarButton11.ImageIndex = 63
        Me.ToolBarButton11.ToolTipText = "Thông Tin Về Sản Phẩm"
        '
        'ToolBarButton12
        '
        Me.ToolBarButton12.ImageIndex = 5
        Me.ToolBarButton12.ToolTipText = "Hướng Dẫn Sử Dụng Chương Trình"
        '
        'ToolBarButton13
        '
        Me.ToolBarButton13.ImageIndex = 4
        Me.ToolBarButton13.ToolTipText = "Tìm Kiếm"
        '
        'listimg
        '
        Me.listimg.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.listimg.ImageSize = New System.Drawing.Size(16, 16)
        Me.listimg.ImageStream = CType(resources.GetObject("listimg.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.listimg.TransparentColor = System.Drawing.Color.Transparent
        '
        'ntfIcon
        '
        Me.ntfIcon.Icon = CType(resources.GetObject("ntfIcon.Icon"), System.Drawing.Icon)
        Me.ntfIcon.Text = "Chương Trình Bán Hàng"
        Me.ntfIcon.Visible = True
        '
        'Timer_Stop
        '
        Me.Timer_Stop.Enabled = True
        Me.Timer_Stop.Interval = 15000
        Me.Timer_Stop.SynchronizingObject = Me
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 393)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.ToolBar1, Me.StatusBar})
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chương Trình  Bán Hàng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.A, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timer_Stop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim xNgay, xThang, xNam As String
        xNgay = ""
        xThang = ""
        xNam = ""
        xNgay = CStr(Microsoft.VisualBasic.Day(DateString))
        xThang = CStr(Microsoft.VisualBasic.Month(DateString))
        xNam = CStr(Microsoft.VisualBasic.Year(DateString))
        Me.StatusBar.Panels.Item(3).Text = "Hôm Nay Ngày : " & xNgay & "-" & xThang & "-" & xNam
        'Timer_Stop.Enabled = True
        'childform2 = New frmLogin()
        'childform2.ShowDialog()
        'If xLogin = False Then
        'End
        'End If
        'chuy neu cho phep login thi xoa dong duoi di (power="FULL")
        power = "FULL"
        If power = "BAN" Then
            Me.mnuThemNguoiSD.Enabled = False
            Me.toolbtnThemNSD.Visible = False
        End If
        If power = "NHAP" Then
            Me.mnuBanHang.Enabled = False
            Me.toolbtnBan.Visible = False
            Me.mnuThemNguoiSD.Enabled = False
            Me.toolbtnThemNSD.Visible = False
        End If
    End Sub

    Private Sub mnuNHOMMH_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuNHOMMH.Click
        frmNHOMMH = New frmNHOMMH()
        frmNHOMMH.MdiParent = Me
        frmNHOMMH.Show()
    End Sub

    Private Sub mnuChangepass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChangepass.Click
        frmchangepass = New frmChangepass()
        frmchangepass.MdiParent = Me
        frmchangepass.Show()

    End Sub
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0
                If MessageBox.Show("Bạn Có Thật Sự Muốn Thoát Khỏi Hệ Thống Không ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    End
                End If
            Case 1
                frmchangepass = New frmChangepass()
                frmchangepass.MdiParent = Me
                frmchangepass.Show()
                'Me.StatusBar.Panels.Item(2).Text = "Thay Đổi PassWord..."
            Case 2
                frmThemNSD = New frmThemNSD()
                frmThemNSD.MdiParent = Me
                frmThemNSD.Show()
            Case 3
                frmNHOMMH = New frmNHOMMH()
                frmNHOMMH.MdiParent = Me
                frmNHOMMH.Show()
                'Me.StatusBar.Panels.Item(2).Text = "Nhóm Mặt Hàng..."

            Case 4
                frmMathang = New frmMathang()
                frmMathang.MdiParent = Me
                frmMathang.Show()
            Case 5
                frmNUOC = New frmNUOC()
                frmNUOC.MdiParent = Me
                frmNUOC.Show()
            Case 6
                frmNCC = New frmNCC()
                frmNCC.MdiParent = Me
                frmNCC.Show()
            Case 7
                frmNhanvien = New frmNhanvien()
                frmNhanvien.MdiParent = Me
                frmNhanvien.Show()
                'Me.StatusBar.Panels.Item(2).Text = "Danh Sách Nhân Viên..."
            Case 8
                frmKhach = New frmKhach()
                frmKhach.MdiParent = Me
                frmKhach.Show()
            Case 9
                frmCTNHAP = New frmCTNHAP()
                frmCTNHAP.MdiParent = Me
                frmCTNHAP.Show()
            Case 10
                frmCTXUAT = New frmCTXUAT()
                frmCTXUAT.MdiParent = Me
                frmCTXUAT.Show()
            Case 11
                frmBanHang2 = New frmBanHang2()
                frmBanHang2.MdiParent = Me
                frmBanHang2.Show()
                frmBanHang2.StartPosition = FormStartPosition.CenterParent
            Case 12
                frmBAOCAO = New frmBAOCAO()
                frmBAOCAO.MdiParent = Me
                frmBAOCAO.Show()
            Case 13
                frmTTSP = New frmTTSP()
                frmTTSP.MdiParent = Me
                frmTTSP.Show()
            Case 14
                'Dim AppPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
                Dim url As String = ""
                url = "\DoAn_Hoang_VBNET\Hoang_Help.chm"
                'url = AppPath & url
                Help.ShowHelp(Me, url)


        End Select
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Private Sub mnuNuocSX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNuocSX.Click
        frmNUOC = New frmNUOC()
        frmNUOC.MdiParent = Me
        frmNUOC.Show()
    End Sub
    Private Sub mnuNhanvien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNhanvien.Click
        frmNhanvien = New frmNhanvien()
        frmNhanvien.MdiParent = Me
        frmNhanvien.Show()
    End Sub
    Private Sub mnuMathang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMathang.Click
        frmMathang = New frmMathang()
        frmMathang.MdiParent = Me
        frmMathang.Show()
    End Sub
    Private Sub mnuNCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuNCC.Click
        frmNCC = New frmNCC()
        frmNCC.MdiParent = Me
        frmNCC.Show()
    End Sub
    Private Sub mnuKhach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuKhach.Click
        frmKhach = New frmKhach()
        frmKhach.MdiParent = Me
        frmKhach.Show()
    End Sub
    Private Sub mnuCTNHAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCTNHAP.Click
        frmCTNHAP = New frmCTNHAP()
        frmCTNHAP.MdiParent = Me
        frmCTNHAP.Show()
    End Sub
    Private Sub mnuCTXUAT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCTXUAT.Click
        frmCTXUAT = New frmCTXUAT()
        frmCTXUAT.MdiParent = Me
        frmCTXUAT.Show()
    End Sub

    Private Sub mnuBanHang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBanHang.Click
        frmBanHang = New frmBANHANG()
        frmBanHang.MdiParent = Me
        frmBanHang.Show()
    End Sub
    Private Sub mnuBaoCao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBaoCao.Click
        frmBAOCAO = New frmBAOCAO()
        frmBAOCAO.MdiParent = Me
        frmBAOCAO.Show()
    End Sub
    Private Sub mnuThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThoat.Click
        If MessageBox.Show("Bạn Có Thật Sự Muốn Thoát Khỏi Hệ Thống Không ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            End
        End If
    End Sub
    Private Sub mnuTTSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTTSP.Click
        frmTTSP = New frmTTSP()
        frmTTSP.MdiParent = Me
        frmTTSP.Show()
    End Sub

    Private Sub mnuThemNguoiSD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThemNguoiSD.Click
        frmThemNSD = New frmThemNSD()
        frmThemNSD.MdiParent = Me
        frmThemNSD.Show()
    End Sub

    Private Sub frmNHOMMH_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles frmNHOMMH.Load
        'Me.mnuNHOMMH.Enabled = False
    End Sub

    Private Sub frmNHOMMH_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles frmNHOMMH.Closing
        'Me.mnuNHOMMH.Enabled = True
    End Sub

    Private Sub mnuTroGiup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTroGiup.Click
        'Dim AppPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        Dim url As String = ""
        url = "\DoAn_Hoang_VBNET\Hoang_Help.chm"
        'url = AppPath & url
        Help.ShowHelp(Me, url)
    End Sub

    Private Sub mnuBanHang2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBanHang2.Click

        frmBanHang2 = New frmBanHang2()
        frmBanHang2.MdiParent = Me
        frmBanHang2.Show()

    End Sub
End Class
