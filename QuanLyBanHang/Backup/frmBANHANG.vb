Imports System.Data
Imports System.Data.SqlClient
Public Class frmBANHANG
    Inherits System.Windows.Forms.Form

    Private Sub getlist()
        Me.lstboxHangBan.Items.Clear()
        Dim mysqlconnection As SqlConnection = New SqlConnection(strconn)
        Dim mysqlcmd As SqlCommand = New SqlCommand("select * from viewTONGHOP", mysqlconnection)
        Try
            mysqlconnection.Open()
            Dim mydatareader As SqlDataReader = mysqlcmd.ExecuteReader()

            Do While mydatareader.Read()
                Me.lstboxHangBan.Items.Add(mydatareader.GetValue(1) & "__" & mydatareader.GetValue(0) & "            : " & mydatareader.GetValue(2) & "   <" & mydatareader.GetValue(3) & ">       " & mydatareader.GetValue(4) & "      (Đồng/" & mydatareader.GetValue(3) & ")        --> " & mydatareader.GetValue(5))
                'Me.lstboxHangBan.Items.Add(vbCrLf)
            Loop

            mydatareader.Close()
            mysqlconnection.Close()
        Catch
            MessageBox.Show("Không Thể Đọc Được Dữ Liệu.Bạn Hãy Thử Lại!.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

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
    Friend WithEvents C As System.Windows.Forms.Label
    Friend WithEvents lstboxHangBan As System.Windows.Forms.ListBox
    Friend WithEvents lstboxHangMua As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents btnMua As System.Windows.Forms.Button
    Friend WithEvents btnTraLai As System.Windows.Forms.Button
    Friend WithEvents txtSLMUA As System.Windows.Forms.TextBox
    Friend WithEvents txtTONGTIEN As System.Windows.Forms.TextBox
    Friend WithEvents txtTRIETKHAU As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSOHDBAN As System.Windows.Forms.TextBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents txtNGAYB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnDongY As System.Windows.Forms.Button
    Friend WithEvents btnTHEM As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTIENSAUTK As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbNV As System.Windows.Forms.ComboBox
    Friend WithEvents ImgBANHANG As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBANHANG))
        Me.C = New System.Windows.Forms.Label()
        Me.lstboxHangBan = New System.Windows.Forms.ListBox()
        Me.lstboxHangMua = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSLMUA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTONGTIEN = New System.Windows.Forms.TextBox()
        Me.ImgBANHANG = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDongY = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTRIETKHAU = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnMua = New System.Windows.Forms.Button()
        Me.btnTraLai = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSOHDBAN = New System.Windows.Forms.TextBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.txtNGAYB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnTHEM = New System.Windows.Forms.Button()
        Me.txtTIENSAUTK = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbNV = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'C
        '
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.C.Location = New System.Drawing.Point(54, 8)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(252, 32)
        Me.C.TabIndex = 0
        Me.C.Text = "Chương Trình Bán Hàng"
        '
        'lstboxHangBan
        '
        Me.lstboxHangBan.ColumnWidth = 500
        Me.lstboxHangBan.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxHangBan.HorizontalScrollbar = True
        Me.lstboxHangBan.ItemHeight = 16
        Me.lstboxHangBan.Location = New System.Drawing.Point(16, 68)
        Me.lstboxHangBan.Name = "lstboxHangBan"
        Me.lstboxHangBan.ScrollAlwaysVisible = True
        Me.lstboxHangBan.Size = New System.Drawing.Size(752, 196)
        Me.lstboxHangBan.Sorted = True
        Me.lstboxHangBan.TabIndex = 1
        '
        'lstboxHangMua
        '
        Me.lstboxHangMua.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstboxHangMua.HorizontalScrollbar = True
        Me.lstboxHangMua.Location = New System.Drawing.Point(456, 293)
        Me.lstboxHangMua.Name = "lstboxHangMua"
        Me.lstboxHangMua.ScrollAlwaysVisible = True
        Me.lstboxHangMua.Size = New System.Drawing.Size(312, 160)
        Me.lstboxHangMua.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 282)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Số Lượng "
        '
        'txtSLMUA
        '
        Me.txtSLMUA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSLMUA.Location = New System.Drawing.Point(80, 282)
        Me.txtSLMUA.Name = "txtSLMUA"
        Me.txtSLMUA.Size = New System.Drawing.Size(112, 22)
        Me.txtSLMUA.TabIndex = 4
        Me.txtSLMUA.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Phần Trăm Triết Khấu"
        '
        'txtTONGTIEN
        '
        Me.txtTONGTIEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTONGTIEN.Location = New System.Drawing.Point(192, 320)
        Me.txtTONGTIEN.Name = "txtTONGTIEN"
        Me.txtTONGTIEN.Size = New System.Drawing.Size(256, 22)
        Me.txtTONGTIEN.TabIndex = 6
        Me.txtTONGTIEN.Text = ""
        '
        'ImgBANHANG
        '
        Me.ImgBANHANG.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgBANHANG.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgBANHANG.ImageStream = CType(resources.GetObject("ImgBANHANG.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgBANHANG.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnDongY
        '
        Me.btnDongY.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDongY.ImageList = Me.ImgBANHANG
        Me.btnDongY.Location = New System.Drawing.Point(232, 427)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(96, 24)
        Me.btnDongY.TabIndex = 8
        Me.btnDongY.Text = "Đồng Ý"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(62, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tổng Thành Tiền"
        '
        'txtTRIETKHAU
        '
        Me.txtTRIETKHAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTRIETKHAU.Location = New System.Drawing.Point(192, 352)
        Me.txtTRIETKHAU.Name = "txtTRIETKHAU"
        Me.txtTRIETKHAU.Size = New System.Drawing.Size(112, 22)
        Me.txtTRIETKHAU.TabIndex = 10
        Me.txtTRIETKHAU.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = " Các Mặt Hàng Bán"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(520, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = " Các Mặt Hàng Khách Mua"
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.Location = New System.Drawing.Point(344, 427)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(96, 24)
        Me.btnDong.TabIndex = 13
        Me.btnDong.Text = "Đóng"
        '
        'btnMua
        '
        Me.btnMua.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMua.Location = New System.Drawing.Point(224, 282)
        Me.btnMua.Name = "btnMua"
        Me.btnMua.Size = New System.Drawing.Size(88, 24)
        Me.btnMua.TabIndex = 14
        Me.btnMua.Text = "Mua"
        '
        'btnTraLai
        '
        Me.btnTraLai.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraLai.Location = New System.Drawing.Point(344, 282)
        Me.btnTraLai.Name = "btnTraLai"
        Me.btnTraLai.Size = New System.Drawing.Size(88, 24)
        Me.btnTraLai.TabIndex = 15
        Me.btnTraLai.Text = "Trả Lại"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(510, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Số Hoá Đơn Bán"
        '
        'txtSOHDBAN
        '
        Me.txtSOHDBAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSOHDBAN.Location = New System.Drawing.Point(623, 6)
        Me.txtSOHDBAN.Name = "txtSOHDBAN"
        Me.txtSOHDBAN.Size = New System.Drawing.Size(144, 22)
        Me.txtSOHDBAN.TabIndex = 17
        Me.txtSOHDBAN.Text = ""
        '
        'btnHuy
        '
        Me.btnHuy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHuy.ImageList = Me.ImgBANHANG
        Me.btnHuy.Location = New System.Drawing.Point(8, 427)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(96, 24)
        Me.btnHuy.TabIndex = 18
        Me.btnHuy.Text = "Huỷ Bỏ"
        '
        'txtNGAYB
        '
        Me.txtNGAYB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNGAYB.Location = New System.Drawing.Point(384, 6)
        Me.txtNGAYB.Name = "txtNGAYB"
        Me.txtNGAYB.Size = New System.Drawing.Size(118, 22)
        Me.txtNGAYB.TabIndex = 19
        Me.txtNGAYB.Text = ""
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(313, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Ngày Bán"
        '
        'btnTHEM
        '
        Me.btnTHEM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTHEM.Image = CType(resources.GetObject("btnTHEM.Image"), System.Drawing.Bitmap)
        Me.btnTHEM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTHEM.ImageIndex = 0
        Me.btnTHEM.ImageList = Me.ImgBANHANG
        Me.btnTHEM.Location = New System.Drawing.Point(120, 427)
        Me.btnTHEM.Name = "btnTHEM"
        Me.btnTHEM.Size = New System.Drawing.Size(95, 24)
        Me.btnTHEM.TabIndex = 21
        Me.btnTHEM.Text = "Thêm Mới"
        Me.btnTHEM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTIENSAUTK
        '
        Me.txtTIENSAUTK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIENSAUTK.Location = New System.Drawing.Point(192, 384)
        Me.txtTIENSAUTK.Name = "txtTIENSAUTK"
        Me.txtTIENSAUTK.Size = New System.Drawing.Size(256, 22)
        Me.txtTIENSAUTK.TabIndex = 22
        Me.txtTIENSAUTK.Text = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 23)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Tổng  Tiền Sau Triết Khấu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 23)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Nhân Viên Bán Hàng"
        '
        'cbNV
        '
        Me.cbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNV.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNV.Location = New System.Drawing.Point(456, 36)
        Me.cbNV.Name = "cbNV"
        Me.cbNV.Size = New System.Drawing.Size(312, 24)
        Me.cbNV.Sorted = True
        Me.cbNV.TabIndex = 27
        '
        'frmBANHANG
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 473)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbNV, Me.Label9, Me.PictureBox1, Me.Label8, Me.txtTIENSAUTK, Me.btnTHEM, Me.Label7, Me.txtNGAYB, Me.btnHuy, Me.txtSOHDBAN, Me.Label6, Me.btnTraLai, Me.btnMua, Me.btnDong, Me.Label5, Me.Label1, Me.txtTRIETKHAU, Me.Label4, Me.btnDongY, Me.txtTONGTIEN, Me.Label3, Me.txtSLMUA, Me.Label2, Me.lstboxHangMua, Me.lstboxHangBan, Me.C})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBANHANG"
        Me.Text = "Bán Hàng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim xGhi As Boolean

    Dim xMAMH As String = ""
    Dim xDONGIA As Integer = 0
    Dim xTHANHTIEN As Decimal = 0
    Dim xSL As Integer = 0
    Dim xTENMH As String = ""
    Dim xNUOCSX As String = ""
    Dim xSLMUA As Integer = 0

    Dim xTONGTIEN As Decimal = 0

    ' 2 cach khai bao nhu nhau
    'Dim mySQLConnection As SqlConnection = New SqlConnection(strconn)
    Dim mySQLConnection As New SqlConnection(strconn)
    Private Sub fillcombo(ByVal st As String)
        Dim xma As String = ""
        Dim xten As String = ""
        Dim sqlcmd As SqlCommand = New SqlCommand(st, mySQLConnection)
        Try
            mySQLConnection.Open()
            Dim drReader As SqlDataReader
            drReader = sqlcmd.ExecuteReader()
            Do While drReader.Read()
                xma = ""
                xten = ""
                xma = drReader.GetString(0)
                xten = drReader.GetString(1)
                Me.cbNV.Items.Add(xten & "--" & xma)
            Loop
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

    Function SplitCode() As String
        Dim xcode As String = ""
        Dim len As Integer = 0
        Dim leng As Integer = 0
        len = InStr(Me.cbNV.Text, "--")
        leng = Microsoft.VisualBasic.Len(Me.cbNV.Text)
        If len > 1 Then
            xcode = Microsoft.VisualBasic.Right(Me.cbNV.Text, leng - len - 1)
        Else
            xcode = Me.cbNV.Text
        End If
        SplitCode = xcode
        Exit Function
    End Function

    Private Function checkItemHHH(ByVal st As String, ByVal code As String) As Boolean
        Dim numline, curline, i As Byte
        Dim letter As String = ""
        Dim ln As String = ""
        numline = 0
        i = 0
        numline = Me.lstboxHangMua.Items.Count
        Dim a(numline - 1) As String
        curline = 1
        'lay tung dong du lieu dua vao mang a
        For i = 1 To numline
            a(i) = ""
            letter = Microsoft.VisualBasic.Mid(st, i, 1)
            If letter = Chr(13) Then
                curline = curline + 1
                ln = ""
            Else
                ln = ln + letter
                a(curline) = ln
            End If
        Next
        ' kiem tra xem ma mat hang chon co trong danh sach cac hang mua chua
        Dim Tg As String = ""
        For i = 1 To numline
            Tg = Microsoft.VisualBasic.Left(a(i), InStr(a(i), "__") - 1)
            If Tg = code Then
                checkItemHHH = False
                Exit For
                Exit Function
            End If
        Next
        checkItemHHH = True
    End Function

    Function checkItem(ByVal code As String) As Boolean
        Dim Tg As String = ""
        Dim readcmd As New SqlCommand("select * from tblBAN where MAMH='" & code & "' and SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
        Try
            mySQLConnection.Open()
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
            If mySQLConnection.State = ConnectionState.Open Then
                mySQLConnection.Close()
            End If
        End Try

    End Function


    Private Sub btnDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDong.Click
        If xGhi = False And Me.txtTONGTIEN.Text <> "" Then
            If MessageBox.Show("Bạn có muốn ghi lại hoá đơn này không. Nếu bạn muốn ghi lại hãy chọn Yes, nếu bạn chọn No hoá đơn sẽ bị xoá . ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                MessageBox.Show("Bạn hãy kích vào nút -- Đồng ý -- để ghi lại !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btnDongY.Focus()
                Exit Sub
            Else
                Dim cmd1 As New SqlCommand("delete from tblHDBAN where SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
                Dim cmd2 As New SqlCommand("delete from tblBAN where SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
                Try
                    mySQLConnection.Open()
                    cmd1.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                Catch
                    MessageBox.Show("Không thể xoá được hoá đơn này. Bạn hãy thử lại !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    If mySQLConnection.State = ConnectionState.Open Then
                        mySQLConnection.Close()
                    End If
                End Try

            End If
        End If
        Me.Hide()
    End Sub

    Private Sub frmBANHANG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtTONGTIEN.Enabled = True
        Me.txtTIENSAUTK.Enabled = True
        Me.txtNGAYB.Enabled = False
        Me.txtSOHDBAN.Enabled = False
        getlist()
        xGhi = False 'hoa don chua duoc ghi lai
        Call fillcombo("select * from tblNHANVIEN")
        Me.lstboxHangMua.Items.Clear()
        Me.txtSOHDBAN.Text = Tao_MA("tblHDBAN", "SOHDBAN", 7)
        'Me.txtNGAYB.Text = DateString
        Me.txtNGAYB.Text = ""
        Dim systime

        systime = DateTime.Today
        'Me.txtNGAYB.Enabled = False
        Dim ngay, thang, nam As Integer
        ngay = Microsoft.VisualBasic.Day(systime)
        thang = Microsoft.VisualBasic.Month(systime)
        nam = Microsoft.VisualBasic.Year(systime)
        Me.txtNGAYB.Text = ngay & "\" & thang & "\" & nam
        Me.cbNV.Focus()
    End Sub


    Private Sub btnMua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMua.Click
        xGhi = False
        Me.txtTONGTIEN.Enabled = False
        Me.txtTIENSAUTK.Enabled = False
        If Me.lstboxHangBan.SelectedItem = "" Then
            MessageBox.Show("Bạn Hãy Chọn Một Mặt Hàng Trong Danh Sách Các Mặt Hàng Bán.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.lstboxHangBan.Focus()
            Exit Sub
        End If
        'Lay ra MAMH cua mat Hang
        xMAMH = ""
        xTENMH = ""
        xTENMH = Microsoft.VisualBasic.Left(Me.lstboxHangBan.SelectedItem, InStr(Me.lstboxHangBan.SelectedItem, "__") - 1)
        'Me.txtSLMUA.Text = Trim(xMAMH)
        xSL = 0
        Dim xSLs As String
        xSLs = (Trim(Microsoft.VisualBasic.Mid(Me.lstboxHangBan.SelectedItem, (InStr(Me.lstboxHangBan.SelectedItem, ":") + 1), InStr(Me.lstboxHangBan.SelectedItem, "<") - InStr(Me.lstboxHangBan.SelectedItem, ":") - 1)))
        If xSLs = "" Then
            MessageBox.Show("Mặt Hàng Này Chưa Nhập Về Hoặc Đã Hết. Bạn Hãy Chọn Một Mặt Hàng Trong Danh Sách Các Mặt Hàng Bán.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.lstboxHangBan.Focus()
            Exit Sub
        Else
            xSL = CInt(xSLs)
        End If
        'Me.txtSLMUA.Text = CInt(Trim(xSL))
        'Lay ra Don Gia cua mat hang mua
        xDONGIA = 0
        xDONGIA = CInt(Trim(Microsoft.VisualBasic.Mid(Me.lstboxHangBan.SelectedItem, InStr(Me.lstboxHangBan.SelectedItem, ">") + 1, InStr(Me.lstboxHangBan.SelectedItem, "(") - InStr(Me.lstboxHangBan.SelectedItem, ">") - 2)))

        'Me.txtSLMUA.Text = CInt(Trim(xDONGIA))
        'lay ra Ten Cua Mat Hang

        xMAMH = Microsoft.VisualBasic.Mid(Me.lstboxHangBan.SelectedItem, InStr(Me.lstboxHangBan.SelectedItem, "__") + 2, InStr(Trim(Me.lstboxHangBan.SelectedItem), "    ") - InStr(Me.lstboxHangBan.SelectedItem, "__"))
        'Me.txtSLMUA.Text = xTENMH
        'Lay ra Ten Nuoc SX mat hang nay
        xNUOCSX = ""
        xNUOCSX = Microsoft.VisualBasic.Right(Me.lstboxHangBan.SelectedItem, Len(Me.lstboxHangBan.SelectedItem) - InStr(Me.lstboxHangBan.SelectedItem, "-->") + 1)
        'Me.txtSLMUA.Text = xNUOCSX

        If checkItem(xMAMH) = False Then
            MessageBox.Show("Mặt hàng này đã có trong danh sách các mặt hàng mua. Bạn hãy chọn mặt hàng khác hoặc chọn mặt hàng đó trong danh sách mặt hàng mua và sửa lại số lượng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If xSL <= 0 Then
            MessageBox.Show("Mặt Hàng Này Đã Hết Hoặc Chưa Nhập Về.Bạn Hãy Chọn Mặt Hàng Khác.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.lstboxHangBan.Focus()
            Exit Sub
        Else
            If Me.txtSLMUA.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Vào Số Lượng Mua.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtSLMUA.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtSLMUA.Text) = False Then
                    MessageBox.Show("Dữ Liệu Bạn Nhập Vào Không Hợp Lệ. Hãy Sửa Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtSLMUA.Focus()
                    Exit Sub
                Else
                    xSLMUA = 0
                    xSLMUA = CInt(Trim(Me.txtSLMUA.Text))
                    If xSLMUA > xSL Then
                        MessageBox.Show("Số Lượng Mua Quá Lớn, Không Thể Đáp Ứng Được. Bạn Hãy Sửa Lại Số Lượng Mua.  ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtSLMUA.Focus()
                        Exit Sub
                    Else
                        xTHANHTIEN = xSLMUA * xDONGIA
                        'Chen MAMH,soluong,dongia vao Bang tblBAN
                        Dim ok As Boolean = True
                        Dim mysqlconnection2 As New SqlConnection(strconn)
                        Dim xau As String = "insert into tblBAN(SOHDBAN,MAMH,SOLUONG,DONGIA) values('" & Me.txtSOHDBAN.Text & "','" & xMAMH & "'," & xSLMUA & "," & xDONGIA & ")"
                        Dim mysqlcmd2 As New SqlCommand(xau, mysqlconnection2)
                        Try
                            mysqlconnection2.Open()
                            mysqlcmd2.ExecuteNonQuery()
                        Catch
                            MessageBox.Show("Không Thể Chèn Được Bản Ghi Này Vào Bảng tblBAN. Hãy Thử Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ok = False
                        Finally
                            If mysqlconnection2.State = ConnectionState.Open Then
                                mysqlconnection2.Close()
                            End If

                        End Try
                        If ok = True Then
                            Me.lstboxHangMua.Items.Add(xMAMH & "__" & xTENMH & " :   " & xSLMUA & " * " & xDONGIA & "=" & xTHANHTIEN & "(Đồng)" & "   " & xNUOCSX)
                            ' dong moi them
                            xTONGTIEN = 0
                            If Me.txtTONGTIEN.Text <> "" Then
                                xTONGTIEN = Me.txtTONGTIEN.Text
                            End If

                            xTONGTIEN += xTHANHTIEN
                            getlist()
                            Me.txtSLMUA.Text = ""
                        End If
                        Me.txtTONGTIEN.Text = ""
                        Me.txtTIENSAUTK.Text = ""

                        Me.txtTONGTIEN.Text = xTONGTIEN
                        'dong sua
                        If Me.txtTRIETKHAU.Text <> "" Then
                            Me.txtTIENSAUTK.Text = xTONGTIEN - xTONGTIEN * Me.txtTRIETKHAU.Text
                        Else
                            Me.txtTIENSAUTK.Text = xTONGTIEN
                        End If

                        Me.txtSOHDBAN.Enabled = False
                        'Me.cbNV.Enabled = False
                        Me.txtNGAYB.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá Hoá Đơn Bán Có Số Hoá Đơn Là : " & Me.txtSOHDBAN.Text & " Hay Không ?", "Xin Chào !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            delItem2("tblBAN", "SOHDBAN", Me.txtSOHDBAN.Text, " Các Mặt Hàng Trong Hoá Đơn ")
            delItem2("tblHDBAN", "SOHDBAN", Me.txtSOHDBAN.Text, "Hoá Đơn Bán")
            Me.txtSOHDBAN.Enabled = False
            Me.txtSOHDBAN.Text = ""
            Me.txtSOHDBAN.Text = Tao_MA("tblHDBAN", "SOHDBAN", 7)
            Me.txtSLMUA.Text = ""
            getlist()
            Me.lstboxHangMua.Items.Clear()
            Me.txtNGAYB.Enabled = False
            Me.txtTONGTIEN.Text = ""
            Me.txtTRIETKHAU.Text = ""
            Me.txtTIENSAUTK.Text = ""
            xTONGTIEN = 0
            Me.txtTONGTIEN.Enabled = True
            Me.txtTIENSAUTK.Enabled = True
            xGhi = False
        End If
       
    End Sub

    Private Sub txtSLMUA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSLMUA.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnMua.Focus()
        End If
    End Sub

    Private Sub btnMua_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnMua.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.lstboxHangBan.Focus()
        End If
    End Sub


    Private Sub btnDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDongY.Click
        If Me.cbNV.Text = "" Then
            MsgBox("Bạn Hãy Cho Biết Nhân Viên Bán Hàng !", MsgBoxStyle.Information, "Thông Báo !")
            Me.cbNV.Focus()
            Me.cbNV.Enabled = True
            Exit Sub
        End If
        Dim ok As Boolean = True
        If Me.txtNGAYB.Text = "" Then
            MessageBox.Show("Hãy Nhập Ngày\Tháng\Năm Cho Hoá Đơn Bán Hàng.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtNGAYB.Focus()
            Exit Sub
        End If
        If Me.txtTRIETKHAU.Text <> "" Then
            If IsNumeric(Me.txtTRIETKHAU.Text) = False Then
                MessageBox.Show("Dữ Liệu Bạn Nhập Vào Không Hợp Lệ. Phần Trăm Chiết Khấu Phải Là Kiểu Số.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTRIETKHAU.Focus()
                Exit Sub
            Else
                If Me.txtTRIETKHAU.Text >= 1 Or Me.txtTRIETKHAU.Text < 0 Then
                    MessageBox.Show("Dữ Liệu bạn Nhập Vào Không Hợp Lệ, Triết Khấu Phải Có Giá Trị >=0 Và <1 ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtTRIETKHAU.Focus()
                    Exit Sub
                End If
            End If
        End If
        If Me.txtTONGTIEN.Text = "" Then
            MessageBox.Show("Bạn hãy chọn những mặt hàng cần mua.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.lstboxHangBan.Focus()
            Exit Sub
        End If
        'kiem tra xem Tong tien da tinh sau khi nhap triet khau chua
        'neu chua tinh thi tinh tong tien , neu tinh roi thi thoi
        Dim xTK As Decimal = 0
        If Me.txtTRIETKHAU.Text <> "" Then
            xTK = Me.txtTRIETKHAU.Text
        End If
        Dim mysqlconnection2 As New SqlConnection(strconn)
        Dim xau As String = "insert into tblHDBAN(SOHDBAN,NGAYBAN,TONGGIATRI,TRIETKHAU,MANV) values('" & Me.txtSOHDBAN.Text & "',getdate()," & Me.txtTIENSAUTK.Text & "," & xTK & ",'" & SplitCode() & "')"
        Dim mysqlcmd2 As New SqlCommand(xau, mysqlconnection2)
        Try
            mysqlconnection2.Open()
            mysqlcmd2.ExecuteNonQuery()
        Catch
            MessageBox.Show("Không Thể Chèn Được Bản Ghi Này Vào Bảng tblHDBAN. Hãy Thử Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ok = False
        Finally
            If mysqlconnection2.State = ConnectionState.Open Then
                mysqlconnection2.Close()
            End If

        End Try
        If ok = True Then
            xTONGTIEN = 0
            xGhi = True
        End If
        Me.txtNGAYB.Enabled = False
        Me.txtSLMUA.Text = ""
        Me.txtTONGTIEN.Text = ""
        Me.txtSOHDBAN.Enabled = False
        Me.txtTRIETKHAU.Text = ""
        Me.txtTIENSAUTK.Text = ""
        Me.txtSOHDBAN.Text = ""
        Me.txtTONGTIEN.Enabled = True
        Me.txtTIENSAUTK.Enabled = True

        Me.txtSOHDBAN.Text = Tao_MA("tblHDBAN", "SOHDBAN", 7)
        Me.lstboxHangMua.Items.Clear()
        getlist()
        xTONGTIEN = 0
        Me.lstboxHangBan.Focus()
    End Sub

    Private Sub btnTHEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTHEM.Click

        Dim xxok As Boolean = True
        If xGhi = False And Me.txtTONGTIEN.Text <> "" Then
            If MessageBox.Show("Bạn có muốn ghi lại hoá đơn này không. Nếu bạn muốn ghi lại hãy chọn Yes, nếu bạn chọn No hoá đơn sẽ bị xoá . ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                MessageBox.Show("Bạn hãy kích vào nút -- Đồng ý -- để ghi lại !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.btnDongY.Focus()
                Exit Sub
            Else
                Me.txtTONGTIEN.Enabled = True
                Me.txtTIENSAUTK.Enabled = True
                Dim cmd1 As New SqlCommand("delete from tblHDBAN where SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
                Dim cmd2 As New SqlCommand("delete from tblBAN where SOHDBAN='" & Me.txtSOHDBAN.Text & "'", mySQLConnection)
                Try
                    mySQLConnection.Open()
                    cmd1.ExecuteNonQuery()
                    cmd2.ExecuteNonQuery()
                Catch
                    xxok = False
                    MessageBox.Show("Không thể xoá được hoá đơn này. Bạn hãy thử lại !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    If mySQLConnection.State = ConnectionState.Open Then
                        mySQLConnection.Close()
                    End If
                End Try

            End If
        End If

        If xxok = False Then
            Exit Sub
        End If
        Me.txtNGAYB.Enabled = False
        Me.txtSLMUA.Text = ""
        Me.txtTONGTIEN.Text = ""
        Me.txtSOHDBAN.Enabled = False
        Me.txtTRIETKHAU.Text = ""
        Me.txtTIENSAUTK.Text = ""
        Me.txtSOHDBAN.Text = ""

        Me.txtSOHDBAN.Text = Tao_MA("tblHDBAN", "SOHDBAN", 7)
        Me.lstboxHangMua.Items.Clear()
        getlist()
        xTONGTIEN = 0
        Me.lstboxHangBan.Focus()

    End Sub


    Private Sub txtTRIETKHAU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTRIETKHAU.KeyPress
        Dim xTRIETKHAU As Decimal = 0
        Dim xTT As Decimal = 0

        If e.KeyChar = Chr(13) Then
            If Me.txtTRIETKHAU.Text <> "" Then
                If IsNumeric(Me.txtTRIETKHAU.Text) = False Then
                    MessageBox.Show("Dữ Liệu Bạn Nhập Vào Không Hợp Lệ. Phần Trăm Chiết Khấu Phải Là Kiểu Số.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtTRIETKHAU.Focus()
                    Exit Sub
                Else
                    If Me.txtTRIETKHAU.Text >= 1 Or Me.txtTRIETKHAU.Text < 0 Then
                        MessageBox.Show("Dữ Liệu bạn Nhập Vào Không Hợp Lệ, Triết Khấu Phải Có Giá Trị >=0 Và <1 ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtTRIETKHAU.Focus()
                        Exit Sub
                    End If
                    xTRIETKHAU = Me.txtTRIETKHAU.Text
                    xTT = Me.txtTONGTIEN.Text
                    xTT -= xTT * xTRIETKHAU
                    Me.txtTIENSAUTK.Text = xTT

                End If
            End If
            Me.btnDongY.Focus()
        End If

    End Sub

    Private Sub txtNGAYB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNGAYB.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtNGAYB.Text = "" Then
                MessageBox.Show("Hãy Nhập Ngày\Tháng\Năm Cho Hoá Đơn Bán Hàng.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNGAYB.Focus()
                Exit Sub
            Else
                If IsDate(Me.txtNGAYB.Text) = False Then
                    MessageBox.Show("Dữ Liệu Bạn Nhập Vào Không Hợp Lệ. Bạn Hãy Sửa Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNGAYB.Focus()
                    Exit Sub
                End If
            End If
        End If
    End Sub

    Dim xMA As String = ""

    Private Sub btnTraLai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraLai.Click

        If Me.lstboxHangMua.SelectedItem = "" Then
            MessageBox.Show("Bạn Hãy Chọn Mặt Hàng Cần Trả Lại Trong Danh Sách Các Mặt Hàng Khách Mua", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.lstboxHangMua.Focus()
            Exit Sub
        End If
        Dim ok As Boolean = True
        Dim xSL2 As Integer = 0
        Dim xDG2 As Decimal = 0
        xSL2 = CInt(Trim(Microsoft.VisualBasic.Mid(Me.lstboxHangMua.SelectedItem, InStr(Me.lstboxHangMua.SelectedItem, ":") + 1, InStr(Me.lstboxHangMua.SelectedItem, "*") - InStr(Me.lstboxHangMua.SelectedItem, ":") - 1)))
        xDG2 = CDec(Trim(Microsoft.VisualBasic.Mid(Me.lstboxHangMua.SelectedItem, InStr(Me.lstboxHangMua.SelectedItem, "*") + 1, InStr(Me.lstboxHangMua.SelectedItem, "=") - InStr(Me.lstboxHangMua.SelectedItem, "*") - 1)))

        xMA = ""
        xMA = Microsoft.VisualBasic.Left(Me.lstboxHangMua.SelectedItem, InStr(Me.lstboxHangMua.SelectedItem, "__") - 1)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Trả Lại Mặt Hàng Có Mã : " & xMA & " Hay Không ?", "Xin Chào !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim strconn2 = strconn
            Dim mySQLConnection As New SqlConnection(strconn2)
            Dim sqlcmd As New SqlCommand("delete from tblBAN where SOHDBAN='" & Me.txtSOHDBAN.Text & "' and MAMH='" & xMA & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                sqlcmd.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không Thể Xoá Mặt Hàng Có Mã: " & xMA, "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ok = False
            Finally
                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If

            End Try
            getlist()
        End If
        If ok = True Then
            xTHANHTIEN = 0
            xTHANHTIEN = xSL2 * xDG2

            Dim xTG As Decimal = 0
            xTONGTIEN = Me.txtTONGTIEN.Text

            Me.txtTONGTIEN.Text = ""
            Me.txtTIENSAUTK.Text = ""

            If Me.txtTRIETKHAU.Text = "" Then
                xTONGTIEN -= xTHANHTIEN
                Me.txtTONGTIEN.Text = xTONGTIEN
                Me.txtTIENSAUTK.Text = xTONGTIEN
            Else
                Me.txtTONGTIEN.Text = xTONGTIEN - xTHANHTIEN
                xTONGTIEN = 0
                xTONGTIEN = CDbl(Me.txtTONGTIEN.Text)
                xTG = 0
                xTG = CDbl(Me.txtTONGTIEN.Text)
                Me.txtTIENSAUTK.Text = xTG - xTG * Me.txtTRIETKHAU.Text
                xTONGTIEN = CDbl(Me.txtTIENSAUTK.Text)
            End If

            Me.lstboxHangMua.Items.Remove(Me.lstboxHangMua.SelectedItem)
            'Chu y tru di tong tien 
        End If
    End Sub
    Private Sub lstboxHangBan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstboxHangBan.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSLMUA.Focus()
        End If
    End Sub

    Private Sub lstboxHangMua_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstboxHangMua.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnTraLai.Focus()
        End If
    End Sub

    Private Sub btnTraLai_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnTraLai.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.lstboxHangBan.Focus()
        End If
    End Sub


    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ok As Boolean = True
        Dim xTK2 As Decimal = 0
        xTK2 = Me.txtTRIETKHAU.Text
        If MessageBox.Show("Bạn Có Thật Sự Muốn Cập Nhật Những Thông Tin Vừa Thay Đổi Đối Với Chứng Từ Bán Hàng : " & Me.txtSOHDBAN.Text & " Hay Không ?", "Xin Chào !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Call delItem2("tblHDBAN", "SOHDBAN", Me.txtSOHDBAN.Text, " Số Chứng Từ Nhập ")
            ' Dim xau As String = "insert into tblHDBAN(SOHDBAN,NGAYBAN,TONGGIATRI,MANV) values('" & Me.txtSOHDBAN.Text & "', getdate ," & Me.txtTIENSAUTK.Text & ",'" & SplitCode() & "')"
            Dim mysqlconnection2 As New SqlConnection(strconn)
            Dim xau2 As String = "update tblHDBAN set TONGGIATRI='" & Me.txtTIENSAUTK.Text & "',TRIETKHAU='" & xTK2 & "',MANV='" & SplitCode() & "' where SOHDBAN='" & Me.txtSOHDBAN.Text & "'"
            Dim mysqlcmd2 As New SqlCommand(xau2, mysqlconnection2)
            Try
                mysqlconnection2.Open()
                mysqlcmd2.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không Thể Chèn Được Bản Ghi Này Vào Bảng tblHDBAN. Hãy Thử Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ok = False
            Finally
                If mysqlconnection2.State = ConnectionState.Open Then
                    mysqlconnection2.Close()
                End If
            End Try
            If ok = True Then
                xTONGTIEN = 0
            End If
        End If
    End Sub

    Private Sub cbNV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbNV.KeyPress
        If e.KeyChar = "D" Or e.KeyChar = "d" Then
            Me.cbNV.DroppedDown = True
        End If
        If e.KeyChar = Chr(13) Then
            Me.lstboxHangBan.Focus()
        End If
    End Sub


    Private Sub btnTHEM_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles btnTHEM.ChangeUICues

    End Sub
End Class
