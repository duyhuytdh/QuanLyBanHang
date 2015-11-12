Imports System.Data
Imports System.Data.SqlClient
Public Class frmMathang
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
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button

    Friend WithEvents cmdNew1 As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents dgView As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDONGIA As System.Windows.Forms.TextBox
    Friend WithEvents txtDVTINH As System.Windows.Forms.TextBox
    Friend WithEvents txtTENMH As System.Windows.Forms.TextBox
    Friend WithEvents txtMAMH As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents comboMANUOC As System.Windows.Forms.ComboBox
    Friend WithEvents comboMANHOM As System.Windows.Forms.ComboBox
    Friend WithEvents cbNHOMMH2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Dong2 As System.Windows.Forms.Button
    Friend WithEvents btnCuoi As System.Windows.Forms.Button
    Friend WithEvents btnDau As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblPos As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMathang))
        Me.Grb1 = New System.Windows.Forms.GroupBox()
        Me.Dong2 = New System.Windows.Forms.Button()
        Me.comboMANUOC = New System.Windows.Forms.ComboBox()
        Me.comboMANHOM = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtDONGIA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDVTINH = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTENMH = New System.Windows.Forms.TextBox()
        Me.txtMAMH = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.btnCuoi = New System.Windows.Forms.Button()
        Me.btnDau = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbNHOMMH2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgView = New System.Windows.Forms.DataGrid()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdNew1 = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Grb1.SuspendLayout()
        Me.Grb2.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb1
        '
        Me.Grb1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Dong2, Me.comboMANUOC, Me.comboMANHOM, Me.PictureBox2, Me.txtDONGIA, Me.Label5, Me.Label4, Me.txtDVTINH, Me.Label3, Me.Label2, Me.Label1, Me.txtTENMH, Me.txtMAMH, Me.lbName, Me.lbID, Me.cmdSave, Me.cmdNew, Me.cmdBack})
        Me.Grb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grb1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb1.Location = New System.Drawing.Point(16, 8)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(696, 392)
        Me.Grb1.TabIndex = 4
        Me.Grb1.TabStop = False
        '
        'Dong2
        '
        Me.Dong2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dong2.Location = New System.Drawing.Point(505, 328)
        Me.Dong2.Name = "Dong2"
        Me.Dong2.Size = New System.Drawing.Size(88, 24)
        Me.Dong2.TabIndex = 24
        Me.Dong2.Text = "&Đóng"
        '
        'comboMANUOC
        '
        Me.comboMANUOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMANUOC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMANUOC.Location = New System.Drawing.Point(232, 240)
        Me.comboMANUOC.Name = "comboMANUOC"
        Me.comboMANUOC.Size = New System.Drawing.Size(288, 24)
        Me.comboMANUOC.Sorted = True
        Me.comboMANUOC.TabIndex = 23
        '
        'comboMANHOM
        '
        Me.comboMANHOM.AllowDrop = True
        Me.comboMANHOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMANHOM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboMANHOM.Location = New System.Drawing.Point(232, 160)
        Me.comboMANHOM.Name = "comboMANHOM"
        Me.comboMANHOM.Size = New System.Drawing.Size(288, 24)
        Me.comboMANHOM.Sorted = True
        Me.comboMANHOM.TabIndex = 22
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Location = New System.Drawing.Point(64, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 48)
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'txtDONGIA
        '
        Me.txtDONGIA.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDONGIA.Location = New System.Drawing.Point(232, 280)
        Me.txtDONGIA.Name = "txtDONGIA"
        Me.txtDONGIA.Size = New System.Drawing.Size(280, 23)
        Me.txtDONGIA.TabIndex = 20
        Me.txtDONGIA.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(80, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Đơn Giá"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Mã Nước Sản Xuất"
        '
        'txtDVTINH
        '
        Me.txtDVTINH.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDVTINH.Location = New System.Drawing.Point(232, 200)
        Me.txtDVTINH.Name = "txtDVTINH"
        Me.txtDVTINH.Size = New System.Drawing.Size(168, 23)
        Me.txtDVTINH.TabIndex = 16
        Me.txtDVTINH.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Đơn Vị Tính"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Mã Nhóm"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(476, 40)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nhập Các Thông Tin Cho Mặt Hàng Mới"
        '
        'txtTENMH
        '
        Me.txtTENMH.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTENMH.Location = New System.Drawing.Point(232, 120)
        Me.txtTENMH.Name = "txtTENMH"
        Me.txtTENMH.Size = New System.Drawing.Size(392, 23)
        Me.txtTENMH.TabIndex = 11
        Me.txtTENMH.Text = ""
        '
        'txtMAMH
        '
        Me.txtMAMH.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMAMH.Location = New System.Drawing.Point(232, 80)
        Me.txtMAMH.Name = "txtMAMH"
        Me.txtMAMH.Size = New System.Drawing.Size(168, 23)
        Me.txtMAMH.TabIndex = 10
        Me.txtMAMH.Text = ""
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(80, 128)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(104, 16)
        Me.lbName.TabIndex = 8
        Me.lbName.Text = "Tên Mặt Hàng"
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(80, 88)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(96, 16)
        Me.lbID.TabIndex = 7
        Me.lbID.Text = "Mã Mặt hàng"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(238, 328)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(88, 24)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Ghi Lại"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(103, 328)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(88, 24)
        Me.cmdNew.TabIndex = 2
        Me.cmdNew.Text = "&Thêm Mới"
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(373, 328)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(88, 24)
        Me.cmdBack.TabIndex = 8
        Me.cmdBack.Text = "&Quay Lại"
        '
        'Grb2
        '
        Me.Grb2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCuoi, Me.btnDau, Me.btnNext, Me.btnBack, Me.lblPos, Me.Label7, Me.cbNHOMMH2, Me.PictureBox1, Me.Label6, Me.dgView, Me.cmdUpdate, Me.cmdNew1, Me.cmdDelete, Me.cmdClose})
        Me.Grb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb2.Location = New System.Drawing.Point(16, 8)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(696, 392)
        Me.Grb2.TabIndex = 5
        Me.Grb2.TabStop = False
        '
        'btnCuoi
        '
        Me.btnCuoi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuoi.Location = New System.Drawing.Point(504, 318)
        Me.btnCuoi.Name = "btnCuoi"
        Me.btnCuoi.Size = New System.Drawing.Size(56, 23)
        Me.btnCuoi.TabIndex = 29
        Me.btnCuoi.Text = "Cuối"
        '
        'btnDau
        '
        Me.btnDau.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDau.Location = New System.Drawing.Point(136, 318)
        Me.btnDau.Name = "btnDau"
        Me.btnDau.Size = New System.Drawing.Size(56, 23)
        Me.btnDau.TabIndex = 28
        Me.btnDau.Text = "Đầu"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(448, 318)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 23)
        Me.btnNext.TabIndex = 27
        Me.btnNext.Text = ">>"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(200, 318)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(48, 23)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "<<"
        '
        'lblPos
        '
        Me.lblPos.BackColor = System.Drawing.Color.DarkGray
        Me.lblPos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPos.Location = New System.Drawing.Point(256, 318)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(184, 23)
        Me.lblPos.TabIndex = 25
        Me.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(400, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 23)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Chọn Theo Nhóm"
        '
        'cbNHOMMH2
        '
        Me.cbNHOMMH2.AllowDrop = True
        Me.cbNHOMMH2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNHOMMH2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNHOMMH2.Location = New System.Drawing.Point(526, 15)
        Me.cbNHOMMH2.Name = "cbNHOMMH2"
        Me.cbNHOMMH2.Size = New System.Drawing.Size(168, 24)
        Me.cbNHOMMH2.Sorted = True
        Me.cbNHOMMH2.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(62, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 27)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Danh Sách Các Mặt hàng"
        '
        'dgView
        '
        Me.dgView.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.dgView.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.CaptionText = "Danh Sách Các Loại Mặt Hàng"
        Me.dgView.DataMember = ""
        Me.dgView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.GridLineColor = System.Drawing.Color.Maroon
        Me.dgView.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgView.Location = New System.Drawing.Point(3, 57)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(688, 248)
        Me.dgView.TabIndex = 14
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(188, 356)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(88, 24)
        Me.cmdUpdate.TabIndex = 13
        Me.cmdUpdate.Text = "&Sửa Chữa"
        '
        'cmdNew1
        '
        Me.cmdNew1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew1.Location = New System.Drawing.Point(68, 356)
        Me.cmdNew1.Name = "cmdNew1"
        Me.cmdNew1.Size = New System.Drawing.Size(88, 24)
        Me.cmdNew1.TabIndex = 12
        Me.cmdNew1.Text = "&Thêm Mới"
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(308, 356)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(88, 24)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "&Xoá Bỏ"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(540, 356)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(88, 24)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Đóng"
        '
        'frmMathang
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 417)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Grb2, Me.Grb1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMathang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Danh Sách Các Mặt Hàng"
        Me.Grb1.ResumeLayout(False)
        Me.Grb2.ResumeLayout(False)
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sConnString = strconn
    Dim mySQLConnection As New SqlConnection(sConnString)
    Dim iRsCount As Integer
    Dim iCurrPos As Integer
    Function SplitCode(ByVal ch As String)
        Dim xcode As String = ""
        Dim len As Integer = 0
        Dim leng As Integer = 0
        If ch = "NHOM" Then
            len = InStr(Me.comboMANHOM.Text, "--")
            leng = Microsoft.VisualBasic.Len(Me.comboMANHOM.Text)
            If len > 1 Then
                xcode = Microsoft.VisualBasic.Right(Me.comboMANHOM.Text, leng - len - 1)
            Else
                xcode = Me.comboMANHOM.Text
            End If
            SplitCode = xcode
            Exit Function
        End If
        If ch = "NHOM2" Then
            len = InStr(Me.cbNHOMMH2.Text, "--")
            leng = Microsoft.VisualBasic.Len(Me.cbNHOMMH2.Text)
            If len > 1 Then
                xcode = Microsoft.VisualBasic.Right(Me.cbNHOMMH2.Text, leng - len - 1)
            Else
                xcode = Me.cbNHOMMH2.Text
            End If
            SplitCode = xcode
            Exit Function
        End If
        If ch = "NUOC" Then
            len = InStr(Me.comboMANUOC.Text, "--")
            leng = Microsoft.VisualBasic.Len(Me.comboMANUOC.Text)
            If len > 1 Then
                xcode = Microsoft.VisualBasic.Right(Me.comboMANUOC.Text, leng - len - 1)
            Else
                xcode = Me.comboMANUOC.Text
            End If
            SplitCode = xcode
            Exit Function
        End If
    End Function


    Private Sub fillcombo(ByVal st As String, ByVal obj As String)
        Dim xma As String = ""
        Dim xten As String = ""
        Dim sqlcmd As SqlCommand = New SqlCommand(st, mySQLConnection)
        Try
            mySQLConnection.Open()
            Dim drReader As SqlDataReader
            drReader = sqlcmd.ExecuteReader()
            If obj = "NHOM" Then
                Do While drReader.Read()
                    xma = ""
                    xten = ""
                    xma = drReader.GetString(0)
                    xten = drReader.GetString(1)
                    Me.comboMANHOM.Items.Add(xten & "--" & xma)
                Loop
            End If
            If obj = "NHOM2" Then
                Me.cbNHOMMH2.Items.Add("Tất Cả")
                Do While drReader.Read()
                    xma = ""
                    xten = ""
                    xma = drReader.GetString(0)
                    xten = drReader.GetString(1)
                    Me.cbNHOMMH2.Items.Add(xten & "--" & xma)
                Loop

            End If
            If obj = "NUOC" Then
                Do While drReader.Read()
                    xma = ""
                    xten = ""
                    xma = drReader.GetString(0)
                    xten = drReader.GetString(1)
                    Me.comboMANUOC.Items.Add(xten & "--" & xma)
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

    Dim xMA As String
    Dim xReSave As Boolean = False

    Dim mySQLDataAdapter As New SqlDataAdapter("Select * from tblMATHANG", mySQLConnection)
    Dim myDataSet As DataSet = New DataSet()

    Dim sqlCmdBuilder As SqlCommandBuilder

    Dim sqlDataAdapter2 As SqlClient.SqlDataAdapter
    Dim dsDataSet As New DataSet()

    Private Sub blank()
        Me.txtMAMH.Text = ""
        Me.txtTENMH.Text = ""
        Me.comboMANHOM.Text = ""
        Me.comboMANUOC.Text = ""
        Me.txtDVTINH.Text = ""
        Me.txtDONGIA.Text = ""
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim xmanhom, xnuoc As String
        xmanhom = ""
        xnuoc = ""
        
        xmanhom = SplitCode("NHOM")
        xnuoc = SplitCode("NUOC")
        If xReSave = False Then
            If Me.txtMAMH.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Mã Của Mặt Hàng.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMAMH.Focus()
                Exit Sub
            End If
            If Me.txtTENMH.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Vào Tên Mặt Hàng.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTENMH.Focus()
                Exit Sub
            End If
            If Me.comboMANHOM.Text = "" Then
                MessageBox.Show(" Bạn Hãy Cho Biết Mặt Hàng Thuộc Nhóm Nào.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.comboMANHOM.Focus()
                Exit Sub
            End If

            If Me.txtDVTINH.Text = "" Then
                MessageBox.Show(" Bạn Hãy Cho Biết Đơn Vị Tính Của Mặt Hàng.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDVTINH.Focus()
                Exit Sub
            End If
            If Me.comboMANUOC.Text = "" Then
                MessageBox.Show(" Bạn Hãy Cho Biết Mã Nước Sản Xuất Mặt Hàng Này.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.comboMANUOC.Focus()
                Exit Sub
            End If

            If Me.txtDONGIA.Text = "" Then
                MessageBox.Show(" Bạn Hãy Cho Biết Giá Bán Mặt Hàng Này.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDONGIA.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtDONGIA.Text) = False Then
                    MessageBox.Show(" Giá Trị Bạn Nhập Vào Không Hợp Lệ. Đơn Giá Phải Là Một Số.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtDONGIA.Focus()
                    Exit Sub
                End If
            End If
            Dim mySqlCommand As New SqlCommand("Insert into tblMATHANG(MAMH,TENMH,MANHOM,DVTINH,MANUOC,DONGIA) Values(N'" & UCase(Me.txtMAMH.Text) & "',N'" & Me.txtTENMH.Text & "',N'" & UCase(xmanhom) & "',N'" & Me.txtDVTINH.Text & "',N'" & UCase(xnuoc) & "','" & Me.txtDONGIA.Text & "')", mySQLConnection)
            Try
                mySQLConnection.Open()
                mySqlCommand.ExecuteNonQuery()
            Catch myException As Exception
                MessageBox.Show(myException.ToString())
            Finally
                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try
            blank()
            Me.txtMAMH.Text = Tao_MA("tblMATHANG", "MH", 2)
            Me.txtTENMH.Focus()
        Else
            If MessageBox.Show("Bạn Có Muốn Ghi Lại Những Thông Tin Vừa Mới Thay Đổi Đối Với Mặt Hàng Có Mã : " & xMA & " Hay Không ?. ", "Chào Bạn !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim mysqlcmd As New SqlCommand("update tblMATHANG set MAMH=N'" & UCase(Me.txtMAMH.Text) & "',TENMH=N'" & Me.txtTENMH.Text & "',MANHOM=N'" & UCase(xmanhom) & "',DVTINH=N'" & Me.txtDVTINH.Text & "',MANUOC=N'" & UCase(xnuoc) & "',DONGIA=" & Me.txtDONGIA.Text & " where MAMH='" & xMA & "'", mySQLConnection)
                Try
                    mySQLConnection.Open()
                    mysqlcmd.ExecuteNonQuery()
                Catch
                    MessageBox.Show("Không Thể Cập Nhật Được Bản Ghi Này. ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Finally
                    If mySQLConnection.State = ConnectionState.Open Then
                        mySQLConnection.Close()
                    End If
                End Try

            End If
            blank()
            xReSave = False
            Me.cmdBack.Focus()

        End If
        Me.comboMANHOM.Text = ""
        Me.comboMANUOC.Text = ""
        Me.comboMANHOM.DropDownStyle = ComboBoxStyle.DropDownList
        Me.comboMANUOC.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim no = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá " & no & " Hay Không ?", "Xin Chào !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call delItem2("tblMATHANG", "MAMH", no, "Mặt Hàng")
        End If
        GetData()
        iRsCount = Me.BindingContext(dsDataSet, "tblMatHang").Count
        lblPos.Text = "Bản ghi thứ 1" & "/" & iRsCount
        Me.btnBack.Enabled = False
    End Sub

    Private Sub cmdNew1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew1.Click
        Me.Grb1.Visible = True
        Me.Grb2.Visible = False
        blank()

        Me.comboMANHOM.Text = ""
        Me.comboMANUOC.Text = ""
        Me.comboMANHOM.DropDownStyle = ComboBoxStyle.DropDownList
        Me.comboMANUOC.DropDownStyle = ComboBoxStyle.DropDownList
        Me.txtMAMH.Text = Tao_MA("tblMATHANG", "MH", 2)
        Me.txtMAMH.Enabled = False
        Me.txtTENMH.Focus()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        blank()
        Me.comboMANHOM.Text = ""
        Me.comboMANUOC.Text = ""
        Me.comboMANHOM.DropDownStyle = ComboBoxStyle.DropDownList
        Me.comboMANUOC.DropDownStyle = ComboBoxStyle.DropDownList
        Me.txtMAMH.Text = Tao_MA("tblMATHANG", "MH", 2)
        Me.txtMAMH.Enabled = False
        Me.txtTENMH.Focus()
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Me.Grb2.Visible = True
        Me.Grb1.Visible = False
        GetData()
        iRsCount = Me.BindingContext(dsDataSet, "tblMatHang").Count
        lblPos.Text = "Bản ghi thứ 1" & "/" & iRsCount
        Me.btnBack.Enabled = False
    End Sub

    'day la ma cua nut sua 
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        xMA = ""
        xMA = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Sửa Lại Mặt Hàng Có Mã : " & xMA & " Hay Không ?.", "Chào Bạn !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Grb1.Visible = True
            Me.Grb2.Visible = False
            blank()

            Me.comboMANHOM.DropDownStyle = ComboBoxStyle.DropDown
            Me.comboMANUOC.DropDownStyle = ComboBoxStyle.DropDown

            Me.txtMAMH.Text = Me.dgView.Item(dgView.CurrentCell.RowNumber, 0)
            Me.txtMAMH.Enabled = False
            Me.txtTENMH.Text = Me.dgView.Item(dgView.CurrentCell.RowNumber, 1)
            Me.comboMANHOM.Text = ""
            Me.comboMANHOM.Text = Me.dgView.Item(dgView.CurrentCell.RowNumber, 2)
            Me.txtDVTINH.Text = Me.dgView.Item(dgView.CurrentCell.RowNumber, 3)
            Me.comboMANUOC.Text = ""
            Me.comboMANUOC.Text = Me.dgView.Item(dgView.CurrentCell.RowNumber, 4)
            Me.txtDONGIA.Text = Me.dgView.Item(dgView.CurrentCell.RowNumber, 5)
            xReSave = True ' ghi lai sau khi sua
            Me.txtTENMH.Focus()
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

    Private Sub GetData()
        Dim sqlstr As String = ""
        sqlstr = "Select MAMH as [Mã Mặt Hàng],TENMH as [Tên Mặt Hàng],MANHOM as [Mã Nhóm],DVTINH as [Đơn Vị Tính],MANUOC as [Mã Nước],DONGIA as [Đơn Giá] from tblMATHANG"
        If Me.cbNHOMMH2.Text <> "Tất Cả" And Me.cbNHOMMH2.Text <> "" Then
            sqlstr = sqlstr & " where MANHOM='" & SplitCode("NHOM2") & "'"
        End If
        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter2 = _
            New SqlClient.SqlDataAdapter(sqlstr, sqlConn)

        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder

        sqlCmdBuilder = _
            New SqlClient.SqlCommandBuilder(sqlDataAdapter2)
        Me.dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "tblMATHANG")

        With dgView
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "tblMATHANG")
        End With
    End Sub


    Private Sub frmMathang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbNHOMMH2.Text = ""
        GetData()
        If power = "BAN" Then
            Me.cmdNew1.Enabled = False
            Me.cmdUpdate.Enabled = False
            Me.cmdDelete.Enabled = False
        End If
        fillcombo("select * from tblNHOMMH", "NHOM")
        fillcombo("select * from tblNUOC", "NUOC")
        fillcombo("select * from tblNHOMMH", "NHOM2")
        iRsCount = Me.BindingContext(dsDataSet, "tblMatHang").Count
        If iRsCount <= 0 Then
            lblPos.Text = "Không có bản ghi nào !"
        Else

            If Me.BindingContext(Me.dsDataSet, "tblMatHang").Count = 1 Then
                Me.btnNext.Enabled = False
                lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRsCount
                Me.btnDau.Enabled = False
                Me.btnCuoi.Enabled = False
                Exit Sub
            Else
                Me.btnDau.Enabled = True
                Me.btnCuoi.Enabled = True
                Me.btnNext.Enabled = True
            End If

            lblPos.Text = "Bản ghi thứ " & iCurrPos + 1 & "/" & iRsCount
            Me.btnBack.Enabled = False
        End If
        
    End Sub

    Private Sub txtMAMH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMAMH.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtMAMH.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Mã Cho Mặt Hàng Mới.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMAMH.Focus()
                Exit Sub
            Else
                If checkcode("tblMATHANG", "MAMH", Me.txtMAMH.Text) = False Then
                    MessageBox.Show("Mã Mặt Hàng Bạn Nhập Vào Đã Tồn Tại. Hãy Nhập Lại !.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtMAMH.Focus()
                    Exit Sub
                End If
            End If
            Me.txtTENMH.Focus()
        End If
    End Sub

    Private Sub txtTENMH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTENMH.KeyPress
       
        If e.KeyChar = Chr(13) Then
            Me.comboMANHOM.Focus()
        End If
    End Sub

    Private Sub comboMANHOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles comboMANHOM.KeyPress
        If e.KeyChar = "D" Or e.KeyChar = "d" Then
            Me.comboMANHOM.DroppedDown = True
        End If
        If e.KeyChar = Chr(13) Then
            Me.txtDVTINH.Focus()
        End If
    End Sub

    Private Sub txtDVTINH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDVTINH.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.comboMANUOC.Focus()
        End If
    End Sub

    Private Sub comboMANUOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles comboMANUOC.KeyPress
        If e.KeyChar = "D" Or e.KeyChar = "d" Then
            Me.comboMANUOC.DroppedDown = True
        End If
        If e.KeyChar = Chr(13) Then
            Me.txtDONGIA.Focus()
        End If
    End Sub
    Private Sub txtDONGIA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDONGIA.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtDONGIA.Text = "" Then
                MessageBox.Show(" Bạn Hãy Cho Biết Giá Bán Mặt Hàng Này.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDONGIA.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtDONGIA.Text) = False Then
                    MessageBox.Show(" Giá Trị Bạn Nhập Vào Không Hợp Lệ. Đơn Giá Phải Là Một Số.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtDONGIA.Focus()
                    Exit Sub
                End If
            End If
            Me.cmdSave.Focus()
        End If
    End Sub

    Private Sub cbNHOMMH2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbNHOMMH2.SelectedIndexChanged
        GetData()
        Me.btnBack.Enabled = False
        If Me.BindingContext(Me.dsDataSet, "tblMatHang").Count = 1 Then
            Me.btnNext.Enabled = False
            lblPos.Text = "Bản ghi thứ " & 1 & "/1"
            Me.btnDau.Enabled = False
            Me.btnCuoi.Enabled = False
            Exit Sub
        Else
            Me.btnDau.Enabled = True
            Me.btnCuoi.Enabled = True
            Me.btnNext.Enabled = True
        End If

        iRsCount = Me.BindingContext(dsDataSet, "tblMatHang").Count
        If iRsCount <= 0 Then
            lblPos.Text = "Không có bản ghi nào !"
            Me.btnBack.Enabled = False
            Me.btnNext.Enabled = False
            Me.btnDau.Enabled = False
            Me.btnCuoi.Enabled = False
        Else
            lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRsCount
            Me.btnBack.Enabled = False
            Me.btnDau.Enabled = True
            Me.btnCuoi.Enabled = True
        End If
    End Sub



    Private Sub cbNHOMMH2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbNHOMMH2.KeyPress
        'If e.KeyChar = "D" Or e.KeyChar = "d" Then
        'Me.comboMANUOC.DroppedDown = True
        'End If
        'GetData()
    End Sub

    Private Sub Dong2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dong2.Click
        Me.Hide()
    End Sub

    Private Sub btnDau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDau.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = 0
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        iRsCount = Me.BindingContext(dsDataSet, "tblMatHang").Count
        lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRsCount
        Me.btnBack.Enabled = False
        Me.btnNext.Enabled = True

    End Sub

    Private Sub btnCuoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuoi.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        iRsCount = Me.BindingContext(dsDataSet, "tblMatHang").Count
        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = iRsCount - 1
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        lblPos.Text = "Bản ghi thứ " & iRsCount & "/" & iRsCount
        Me.btnBack.Enabled = True
        Me.btnNext.Enabled = False

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        iCurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblMatHang").Count
        If iRsCount < 1 Then
            lblPos.Text = "Không tồn tại bản ghi "
        Else
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            Me.dgView.CurrentRowIndex = iCurrPos - 1
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            iCurrPos = Me.dgView.CurrentRowIndex
            lblPos.Text = "Bản ghi thứ " & iCurrPos + 1 & "/" & iRsCount
        End If
        If iCurrPos < 1 Then
            Me.btnBack.Enabled = False
        End If
        If iCurrPos < iRsCount Then
            Me.btnNext.Enabled = True
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        iCurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblMatHang").Count
        If iCurrPos = iRsCount Then
            Me.btnNext.Enabled = False
        Else
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            iCurrPos += 1
            Me.dgView.CurrentRowIndex = iCurrPos
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            lblPos.Text = "Bản ghi thứ " & iCurrPos + 1 & "/" & iRsCount
        End If
        If iCurrPos >= 1 Then
            Me.btnBack.Enabled = True
        End If
        If iCurrPos = iRsCount - 1 Then
            Me.btnNext.Enabled = False
        End If
    End Sub

    Private Sub dgView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgView.Click
        If Me.dgView.VisibleRowCount < 2 Then
            Exit Sub
        End If
        iCurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblMatHang").Count

        If iCurrPos = 0 Or iRsCount = 1 Then
            Me.btnBack.Enabled = False
        End If
        If iCurrPos > 0 And iRsCount > 1 Then
            Me.btnBack.Enabled = True
        End If
        If iCurrPos < iRsCount - 1 And iRsCount > 1 Then
            Me.btnNext.Enabled = True
        End If
        If iCurrPos = iRsCount - 1 Or iRsCount = 1 Then
            Me.btnNext.Enabled = False
        End If

        If iCurrPos > 0 And iCurrPos < iRsCount - 1 Then
            Me.btnBack.Enabled = True
            Me.btnNext.Enabled = True
        End If
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        lblPos.Text = "Bản ghi thứ " & iCurrPos + 1 & "/" & iRsCount
    End Sub
End Class


