Imports System.Data
Imports System.Data.SqlClient
Public Class frmBanHang2
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
    Friend WithEvents Grb2 As System.Windows.Forms.GroupBox

    Friend WithEvents dgView As System.Windows.Forms.DataGrid
    Friend WithEvents cbNV As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNGAYB As System.Windows.Forms.TextBox
    Friend WithEvents txtSOHDBAN As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTIENSAUTK As System.Windows.Forms.TextBox
    Friend WithEvents btnHuy As System.Windows.Forms.Button
    Friend WithEvents btnTraLai As System.Windows.Forms.Button
    Friend WithEvents btnMua As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents txtTRIETKHAU As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDongY As System.Windows.Forms.Button
    Friend WithEvents txtTONGTIEN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSLMUA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgViewMH As System.Windows.Forms.DataGrid
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBanHang2))
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.dgViewMH = New System.Windows.Forms.DataGrid()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTIENSAUTK = New System.Windows.Forms.TextBox()
        Me.btnHuy = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnTraLai = New System.Windows.Forms.Button()
        Me.btnMua = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.txtTRIETKHAU = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDongY = New System.Windows.Forms.Button()
        Me.txtTONGTIEN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSLMUA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbNV = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNGAYB = New System.Windows.Forms.TextBox()
        Me.txtSOHDBAN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C = New System.Windows.Forms.Label()
        Me.dgView = New System.Windows.Forms.DataGrid()
        Me.Grb2.SuspendLayout()
        CType(Me.dgViewMH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb2
        '
        Me.Grb2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgViewMH, Me.Label8, Me.txtTIENSAUTK, Me.btnHuy, Me.btnTraLai, Me.btnMua, Me.btnDong, Me.txtTRIETKHAU, Me.Label4, Me.btnDongY, Me.txtTONGTIEN, Me.Label3, Me.txtSLMUA, Me.Label2, Me.cbNV, Me.Label9, Me.PictureBox1, Me.Label7, Me.txtNGAYB, Me.txtSOHDBAN, Me.Label6, Me.C, Me.dgView})
        Me.Grb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb2.Location = New System.Drawing.Point(8, 0)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(784, 464)
        Me.Grb2.TabIndex = 5
        Me.Grb2.TabStop = False
        '
        'dgViewMH
        '
        Me.dgViewMH.CaptionForeColor = System.Drawing.Color.White
        Me.dgViewMH.CaptionText = "Danh Sách Các Mặt Hàng Khách Mua"
        Me.dgViewMH.DataMember = ""
        Me.dgViewMH.GridLineColor = System.Drawing.Color.Maroon
        Me.dgViewMH.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgViewMH.LinkColor = System.Drawing.Color.DeepSkyBlue
        Me.dgViewMH.Location = New System.Drawing.Point(394, 292)
        Me.dgViewMH.Name = "dgViewMH"
        Me.dgViewMH.Size = New System.Drawing.Size(388, 170)
        Me.dgViewMH.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 48)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Tổng  Tiền Sau Triết Khấu"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTIENSAUTK
        '
        Me.txtTIENSAUTK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTIENSAUTK.Location = New System.Drawing.Point(83, 392)
        Me.txtTIENSAUTK.Name = "txtTIENSAUTK"
        Me.txtTIENSAUTK.Size = New System.Drawing.Size(261, 22)
        Me.txtTIENSAUTK.TabIndex = 50
        Me.txtTIENSAUTK.Text = ""
        '
        'btnHuy
        '
        Me.btnHuy.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHuy.ImageList = Me.ImageList1
        Me.btnHuy.Location = New System.Drawing.Point(83, 424)
        Me.btnHuy.Name = "btnHuy"
        Me.btnHuy.Size = New System.Drawing.Size(85, 32)
        Me.btnHuy.TabIndex = 48
        Me.btnHuy.Text = "Huỷ Bỏ"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnTraLai
        '
        Me.btnTraLai.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTraLai.Location = New System.Drawing.Point(302, 300)
        Me.btnTraLai.Name = "btnTraLai"
        Me.btnTraLai.Size = New System.Drawing.Size(88, 24)
        Me.btnTraLai.TabIndex = 47
        Me.btnTraLai.Text = "Trả Lại"
        '
        'btnMua
        '
        Me.btnMua.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMua.Location = New System.Drawing.Point(206, 300)
        Me.btnMua.Name = "btnMua"
        Me.btnMua.Size = New System.Drawing.Size(88, 24)
        Me.btnMua.TabIndex = 46
        Me.btnMua.Text = "Mua"
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.ImageList = Me.ImageList1
        Me.btnDong.Location = New System.Drawing.Point(187, 424)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(85, 32)
        Me.btnDong.TabIndex = 45
        Me.btnDong.Text = "Đóng"
        '
        'txtTRIETKHAU
        '
        Me.txtTRIETKHAU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTRIETKHAU.Location = New System.Drawing.Point(168, 363)
        Me.txtTRIETKHAU.Name = "txtTRIETKHAU"
        Me.txtTRIETKHAU.Size = New System.Drawing.Size(112, 22)
        Me.txtTRIETKHAU.TabIndex = 43
        Me.txtTRIETKHAU.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 18)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Tổng Thành Tiền"
        '
        'btnDongY
        '
        Me.btnDongY.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDongY.Image = CType(resources.GetObject("btnDongY.Image"), System.Drawing.Bitmap)
        Me.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDongY.ImageIndex = 2
        Me.btnDongY.ImageList = Me.ImageList1
        Me.btnDongY.Location = New System.Drawing.Point(291, 424)
        Me.btnDongY.Name = "btnDongY"
        Me.btnDongY.Size = New System.Drawing.Size(85, 32)
        Me.btnDongY.TabIndex = 41
        Me.btnDongY.Text = "Đồng Ý"
        Me.btnDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTONGTIEN
        '
        Me.txtTONGTIEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTONGTIEN.Location = New System.Drawing.Point(128, 333)
        Me.txtTONGTIEN.Name = "txtTONGTIEN"
        Me.txtTONGTIEN.Size = New System.Drawing.Size(261, 22)
        Me.txtTONGTIEN.TabIndex = 40
        Me.txtTONGTIEN.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 371)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 23)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Phần Trăm Triết Khấu"
        '
        'txtSLMUA
        '
        Me.txtSLMUA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSLMUA.Location = New System.Drawing.Point(69, 300)
        Me.txtSLMUA.Name = "txtSLMUA"
        Me.txtSLMUA.Size = New System.Drawing.Size(128, 22)
        Me.txtSLMUA.TabIndex = 38
        Me.txtSLMUA.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 24)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Số Lượng "
        '
        'cbNV
        '
        Me.cbNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNV.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNV.Location = New System.Drawing.Point(368, 34)
        Me.cbNV.Name = "cbNV"
        Me.cbNV.Size = New System.Drawing.Size(328, 24)
        Me.cbNV.Sorted = True
        Me.cbNV.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(224, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 16)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Nhân Viên Bán Hàng"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Ngày Bán"
        '
        'txtNGAYB
        '
        Me.txtNGAYB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNGAYB.Location = New System.Drawing.Point(296, 9)
        Me.txtNGAYB.Name = "txtNGAYB"
        Me.txtNGAYB.Size = New System.Drawing.Size(128, 22)
        Me.txtNGAYB.TabIndex = 31
        Me.txtNGAYB.Text = ""
        '
        'txtSOHDBAN
        '
        Me.txtSOHDBAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSOHDBAN.Location = New System.Drawing.Point(533, 9)
        Me.txtSOHDBAN.Name = "txtSOHDBAN"
        Me.txtSOHDBAN.Size = New System.Drawing.Size(232, 22)
        Me.txtSOHDBAN.TabIndex = 30
        Me.txtSOHDBAN.Text = ""
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(424, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Số Hoá Đơn Bán"
        '
        'C
        '
        Me.C.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.C.Location = New System.Drawing.Point(50, 24)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(134, 30)
        Me.C.TabIndex = 28
        Me.C.Text = " Bán Hàng"
        '
        'dgView
        '
        Me.dgView.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.dgView.CaptionText = "Danh sách Các Mặt Hàng Bán"
        Me.dgView.DataMember = ""
        Me.dgView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.GridLineColor = System.Drawing.Color.Maroon
        Me.dgView.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgView.Location = New System.Drawing.Point(2, 63)
        Me.dgView.Name = "dgView"
        Me.dgView.ReadOnly = True
        Me.dgView.Size = New System.Drawing.Size(779, 225)
        Me.dgView.TabIndex = 14
        '
        'frmBanHang2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(800, 473)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Grb2})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBanHang2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bán Hàng"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Grb2.ResumeLayout(False)
        CType(Me.dgViewMH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim xGhiLan1 As Boolean = True
    'bien cho biet so dong cua dgView
    Dim xRowDgview As Integer = 0
    Dim xRowDgMH As Integer = 0

    Dim sConnString As String = strconn
    Dim mySQLConnection As New SqlConnection(sConnString)
    Dim mySQLDataAdapter As New SqlDataAdapter("Select * from viewTONGHOP", mySQLConnection)
    Dim sqlCmdBuilder As SqlCommandBuilder
    Dim sqlDataAdapter2 As SqlClient.SqlDataAdapter
    Dim sqlDataAdapter1 As SqlClient.SqlDataAdapter
    Dim dsDataSet As New DataSet()
    Dim myDataset As New DataSet()

    Private Sub GetData()
        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter2 = _
            New SqlClient.SqlDataAdapter("Select * from viewTONGHOP", sqlConn)
        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder
        sqlCmdBuilder = _
            New SqlClient.SqlCommandBuilder(sqlDataAdapter2)
        Me.dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "viewTONGHOP")
        xRowDgview = Me.BindingContext(dsDataSet, "viewTONGHOP").Count

        With dgView
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "viewTONGHOP")
        End With
    End Sub


    Private Sub GetData_MH()

        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter1 = _
            New SqlClient.SqlDataAdapter("Select(select TENMH from tblMATHANG where MAMH=tblBAN.MAMH)as [Tên Mặt Hàng],SOLUONG as [Số Lượng],DONGIA as [Đơn Giá],MAMH as [Mã Mặt Hàng],SOHDBAN as [Số Hoá Đơn Bán] from tblBAN where SOHDBAN='" & Me.txtSOHDBAN.Text & "'", sqlConn)
        Dim sqlCmdBuilder1 As SqlClient.SqlCommandBuilder
        sqlCmdBuilder1 = _
            New SqlClient.SqlCommandBuilder(sqlDataAdapter1)
        Me.myDataset.Clear()
        sqlDataAdapter1.Fill(myDataset, "tblBAN")
        xRowDgMH = Me.BindingContext(myDataset, "tblBAN").Count
        With dgViewMH
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.MediumAquamarine
            .SetDataBinding(myDataset, "tblBAN")
        End With
        'sqlConn.Close()
    End Sub


    Private Sub fillcombo()
        Dim xma As String = ""
        Dim xten As String = ""
        Dim sqlcmd As SqlCommand = New SqlCommand("select * from tblNHANVIEN", mySQLConnection)
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



    Private Function exitItem() As Boolean
        Dim VT As Integer = 0
        Dim xTg As String = ""
        Dim xDK As String = ""
        Dim xok1 As Boolean = False
        Dim oVITRI As Integer = 0
        xDK = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
        'MsgBox(xDK)
        oVITRI = Me.dgViewMH.CurrentRowIndex
        VT = oVITRI
        While VT >= 0 And xok1 = False
            xTg = ""
            xTg = Trim(Me.dgViewMH.Item(VT, 3))
            If xTg = xDK Then
                xok1 = True
            End If
            VT = VT - 1
        End While

        If xok1 = False Then
            VT = oVITRI + 1
            While (VT <= (xRowDgMH - 1) And (xok1 = False))
                xTg = ""
                xTg = Trim(Me.dgViewMH.Item(VT, 3))
                If xTg = xDK Then
                    xok1 = True
                End If
                VT = VT + 1
            End While
        End If
        exitItem = xok1
    End Function
    'dau vao la vitri hien tai dau ra la vi tri can tim 
    Private Function FindIndex(ByVal Key As String) As Integer
        xRowDgview = Me.BindingContext(dsDataSet, "viewTONGHOP").Count
        Dim xIndex As Integer = 0
        Dim i As Integer = 0
        Dim xTG As String = ""
        If xRowDgview >= 0 Then
            For i = 0 To (xRowDgview - 1)
                xTG = ""
                xTG = Microsoft.VisualBasic.Left(Me.dgView.Item(i, 1), 1)
                If UCase(xTG) = UCase(Key) Then
                    xIndex = i
                    Exit For
                End If
            Next
        End If
        FindIndex = xIndex
    End Function



    Private Sub frmBanHang2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()

        Me.txtSOHDBAN.Text = Tao_MA("tblHDBAN", "SOHDBAN", 7)
        fillcombo()

        Me.txtNGAYB.Text = ""
        Dim systime As String

        systime = DateTime.Today
        Me.txtNGAYB.Enabled = False
        Me.txtSOHDBAN.Enabled = False
        Me.txtTONGTIEN.Enabled = False
        Me.txtTIENSAUTK.Enabled = False

        Dim ngay, thang, nam As Integer
        ngay = Microsoft.VisualBasic.Day(systime)
        thang = Microsoft.VisualBasic.Month(systime)
        nam = Microsoft.VisualBasic.Year(systime)
        Me.txtNGAYB.Text = ngay & "\" & thang & "\" & nam
        Me.cbNV.Focus()


    End Sub

    Private Sub btnDongY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDongY.Click
        If Me.cbNV.Text = "" Then
            MessageBox.Show("Bạn hãy cho biết tên nhân viên bán hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbNV.Focus()
            Exit Sub
        End If
        If Me.txtTONGTIEN.Text = "" Then
            MessageBox.Show("Bạn hãy chọn một mặt hàng trong danh sách các mặt hàng bán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.dgView.Focus()
            Exit Sub
        End If


        Dim str2 As String = ""
        Dim xTK As Decimal = 0
        Dim ook As Boolean = True
        If Me.txtTRIETKHAU.Text = "" Then
            xTK = 0
        Else
            xTK = Me.txtTRIETKHAU.Text
        End If
        str2 = "update tblHDBAN set TONGGIATRI=" & Me.txtTIENSAUTK.Text & ",TRIETKHAU=" & xTK & ",MANV='" & SplitCode() & "' where SOHDBAN='" & Me.txtSOHDBAN.Text & "'"
        Dim mycmd As New SqlCommand(str2, mySQLConnection)
        Try
            mySQLConnection.Open()
            mycmd.ExecuteNonQuery()

        Catch
            ook = False
            MessageBox.Show("Không thể cập nhật được thông tin vào bảng tblHDBAN. Bạn hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If mySQLConnection.State = ConnectionState.Open Then
                mySQLConnection.Close()
            End If

        End Try
        If ook = True Then
            Me.txtSLMUA.Text = ""
            Me.txtTONGTIEN.Text = ""
            Me.txtTIENSAUTK.Text = ""
            Me.txtTONGTIEN.Enabled = False
            Me.txtTIENSAUTK.Enabled = False
            Me.txtTRIETKHAU.Text = ""
            Me.txtSOHDBAN.Text = ""
            Me.txtSOHDBAN.Text = Tao_MA("tblHDBAN", "SOHDBAN", 7)
            Call GetData_MH()
            Call GetData()
            xGhiLan1 = True
            Me.dgView.Focus()
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            Me.dgView.CurrentRowIndex = 0
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            Me.dgView_CurrentCellChanged(sender, e)

        End If

    End Sub

    Private Sub btnDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDong.Click
        Me.Hide()
    End Sub

    Private Sub btnHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHuy.Click
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá Hoá Đơn Bán Có Số Hoá Đơn Là : " & Me.txtSOHDBAN.Text & " Hay Không ?", "Xin Chào !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            delItem2("tblBAN", "SOHDBAN", Me.txtSOHDBAN.Text, " Các Mặt Hàng Trong Hoá Đơn ")
            delItem2("tblHDBAN", "SOHDBAN", Me.txtSOHDBAN.Text, "Hoá Đơn Bán")
            Me.txtSOHDBAN.Enabled = False
            Me.txtSOHDBAN.Text = ""
            Me.txtSOHDBAN.Text = Tao_MA("tblHDBAN", "SOHDBAN", 7)
            Me.txtSLMUA.Text = ""
            GetData()
            GetData_MH()
            Me.txtNGAYB.Enabled = False
            Me.txtTONGTIEN.Text = ""
            Me.txtTRIETKHAU.Text = ""
            Me.txtTIENSAUTK.Text = ""

            Me.txtTONGTIEN.Enabled = False
            Me.txtTIENSAUTK.Enabled = False

        End If

    End Sub



    Private Sub dgView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgView.Click
        Me.dgView.Focus()
    End Sub

    Private Sub dgView_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgView.CurrentCellChanged

    End Sub

    Private Sub btnMua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMua.Click
        If Me.cbNV.Text = "" Then
            MessageBox.Show("Bạn hãy cho biết tên nhân viên bán hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbNV.Focus()
            Exit Sub
        End If
        If Me.txtTRIETKHAU.Text <> "" Then
            If IsNumeric(Me.txtTRIETKHAU.Text) = False Then
                MessageBox.Show("Dữ liệu phải là kiểu số bạn hãy nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTRIETKHAU.Focus()
                Exit Sub
            Else
                If Me.txtTRIETKHAU.Text < 0 Or Me.txtTRIETKHAU.Text >= 1 Then
                    MessageBox.Show("Giá trị số của % triết khấu phải >0 và <1 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtTRIETKHAU.Focus()
                    Exit Sub
                End If
            End If
        End If


        If exitItem() = True Then
            MessageBox.Show("Mặt hàng này đã tồn tại trong danh sách các mặt hàng mua. Bạn hãy chọn mặt hàng khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.dgView.Focus()
            Exit Sub
        End If
        If Me.txtSLMUA.Text = "" Then
            MessageBox.Show("Bạn Hãy Cho Biết Số Lượng Mua.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtSLMUA.Focus()
            Exit Sub
        Else

            If IsNumeric(Me.txtSLMUA.Text) = False Then
                MessageBox.Show("Dữ Liệu Phải Là Kiểu Số. Bạn Hãy Sửa Lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtSLMUA.Focus()
                Exit Sub
            Else
                If Me.txtSLMUA.Text <= 0 Then
                    MessageBox.Show("Số Lượng Phải Có Giá Trị Số Là Số Dương (>0). Bạn Hãy Sửa Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtSLMUA.Focus()
                    Exit Sub
                Else
                    If CInt(Me.dgView.Item(Me.dgView.CurrentRowIndex, 2)) = 0 Then
                        MessageBox.Show("Mặt Hàng Này Đã Hết Hoặc Chưa Được Nhập. Bạn Hãy Chọn Mặt Hàng Khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.dgView.Focus()
                        Exit Sub
                    Else
                        If Me.txtSLMUA.Text > Me.dgView.Item(Me.dgView.CurrentRowIndex, 2) Then
                            MessageBox.Show("Số Lượng Mua Quá Lớn So Với Số Lượng Hàng Hiện Có. Bạn Hãy Sửa Lại Số Lượng Mua. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.txtSLMUA.Focus()
                            Exit Sub
                        End If
                    End If

                End If
            End If
        End If
        Dim ok As Boolean = True
        Dim mysqlconnection2 As New SqlConnection(strconn)
        Dim xau As String = "insert into tblBAN(SOHDBAN,MAMH,SOLUONG,DONGIA) values('" & Me.txtSOHDBAN.Text & "','" & Me.dgView.Item(Me.dgView.CurrentRowIndex, 0) & "'," & Me.txtSLMUA.Text & "," & Me.dgView.Item(Me.dgView.CurrentRowIndex, 4) & ")"
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
        If ok Then
            Dim xGia As Decimal = 0
            xGia = Me.dgView.Item(Me.dgView.CurrentRowIndex, 4)
            If Me.txtTONGTIEN.Text = "" Then
                Me.txtTONGTIEN.Text = Me.txtSLMUA.Text * xGia
                If Me.txtTRIETKHAU.Text = "" Then
                    Me.txtTIENSAUTK.Text = Me.txtTONGTIEN.Text
                Else
                    Dim TTam As Decimal = 0
                    TTam = Me.txtTONGTIEN.Text
                    Me.txtTIENSAUTK.Text = TTam - TTam * Me.txtTRIETKHAU.Text
                End If
            Else
                Dim xTien As Decimal = 0
                xTien = Me.txtTONGTIEN.Text
                Me.txtTONGTIEN.Text = xTien + Me.txtSLMUA.Text * xGia
                If Me.txtTRIETKHAU.Text = "" Then
                    Me.txtTIENSAUTK.Text = Me.txtTONGTIEN.Text
                Else
                    Dim xTemp As Decimal = 0
                    xTemp = Me.txtTONGTIEN.Text
                    Me.txtTIENSAUTK.Text = xTemp - xTemp * Me.txtTRIETKHAU.Text
                End If
            End If
            Me.txtTONGTIEN.Enabled = False
            Me.txtTIENSAUTK.Enabled = False

            ' chen thong tin hoac cap nhat lai thong tin trong bang tblHDBAN
            If xGhiLan1 Then
                Dim str1 As String = ""
                Dim xTK As Decimal = 0
                Dim ook As Boolean = True
                If Me.txtTRIETKHAU.Text = "" Then
                    xTK = 0
                Else
                    xTK = Me.txtTRIETKHAU.Text
                End If
                str1 = "insert into tblHDBAN(SOHDBAN,NGAYBAN,TONGGIATRI,TRIETKHAU,MANV) values('" & Me.txtSOHDBAN.Text & "',getdate()," & Me.txtTIENSAUTK.Text & ",'" & xTK & "','" & SplitCode() & "')"
                Dim mycmd As New SqlCommand(str1, mySQLConnection)
                Try
                    mySQLConnection.Open()
                    mycmd.ExecuteNonQuery()

                Catch
                    MessageBox.Show("Không thể thêm thông tin vào bảng tblHDBAN.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ook = False
                Finally
                    If mySQLConnection.State = ConnectionState.Open Then
                        mySQLConnection.Close()
                    End If
                End Try
                If ook = True Then
                    xGhiLan1 = False
                End If
            Else
                Dim str2 As String = ""
                Dim xTK As Decimal = 0
                If Me.txtTRIETKHAU.Text = "" Then
                    xTK = 0
                Else
                    xTK = Me.txtTRIETKHAU.Text
                End If
                str2 = "update tblHDBAN set TONGGIATRI=" & Me.txtTIENSAUTK.Text & ",TRIETKHAU=" & xtk & ",MANV='" & SplitCode() & "' where SOHDBAN='" & Me.txtSOHDBAN.Text & "'"
                Dim mycmd As New SqlCommand(str2, mySQLConnection)
                Try
                    mySQLConnection.Open()
                    mycmd.ExecuteNonQuery()

                Catch
                    MessageBox.Show("Không thể cập nhật được thông tin vào bảng tblHDBAN. Bạn hãy thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    If mySQLConnection.State = ConnectionState.Open Then
                        mySQLConnection.Close()
                    End If

                End Try

            End If


        End If

        Me.txtSLMUA.Text = ""
        GetData_MH()
        GetData()

        Me.dgView.Focus()

        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = 0
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        Me.dgView_CurrentCellChanged(sender, e)


    End Sub

    Private Sub txtSLMUA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSLMUA.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtSLMUA.Text = "" Then
                MessageBox.Show("Bạn Hãy Cho Biết Số Lượng Mua.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtSLMUA.Focus()
                Exit Sub
            Else

                If IsNumeric(Me.txtSLMUA.Text) = False Then
                    MessageBox.Show("Dữ Liệu Phải Là Kiểu Số. Bạn Hãy Sửa Lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtSLMUA.Focus()
                    Exit Sub
                Else
                    If Me.txtSLMUA.Text <= 0 Then
                        MessageBox.Show("Số Lượng Phải Có Giá Trị Số Là Số Dương (>0). Bạn Hãy Sửa Lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtSLMUA.Focus()
                        Exit Sub
                    Else
                        If CInt(Me.dgView.Item(Me.dgView.CurrentRowIndex, 2)) = 0 Then
                            MessageBox.Show("Mặt Hàng Này Đã Hết Hoặc Chưa Được Nhập. Bạn Hãy Chọn Mặt Hàng Khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.dgView.Focus()
                            Exit Sub
                        Else
                            If Me.txtSLMUA.Text > Me.dgView.Item(Me.dgView.CurrentRowIndex, 2) Then
                                MessageBox.Show("Số Lượng Mua Quá Lớn So Với Số Lượng Hàng Hiện Có. Bạn Hãy Sửa Lại Số Lượng Mua. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.txtSLMUA.Focus()
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If


            Me.btnMua.Focus()
        End If
    End Sub

    Private Sub dgView_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgView.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtSLMUA.Focus()
            Exit Sub
        End If
        Dim xChar As String = ""
        xChar = CStr(e.KeyChar)
        Dim currInd As Integer = 0
        Dim ii As Integer = 0
        currInd = Me.dgView.CurrentRowIndex
        ii = FindIndex(xChar)

        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = ii
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        Me.dgView_CurrentCellChanged(sender, e)

    End Sub

    Private Sub cbNV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbNV.KeyPress
        If e.KeyChar = "D" Or e.KeyChar = "d" Then
            Me.cbNV.DroppedDown = True
        End If
        If e.KeyChar = Chr(13) Then
            Me.txtSLMUA.Focus()
        End If
    End Sub

    Private Sub btnTraLai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTraLai.Click
        If Me.dgViewMH.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dũ liệu chứa danh sách các mặt hàng khách mua bị trống. Bạn không thể thực hiện chứac năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim xTam1 As String = ""
        Dim xTam2 As String = ""
        xTam2 = Me.dgViewMH.Item(Me.dgViewMH.CurrentRowIndex, 0)
        xTam1 = Me.dgViewMH.Item(Me.dgViewMH.CurrentRowIndex, 3)
        Dim ok As Boolean = True
        If MessageBox.Show("Bạn có thật sự muốn trả lại mặt hàng: " & xTam2 & " trong hoá đơn hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim xSL As Decimal = 0
            Dim xDG As Decimal = 0
            xSL = Me.dgViewMH.Item(Me.dgViewMH.CurrentRowIndex, 1)
            xDG = Me.dgViewMH.Item(Me.dgViewMH.CurrentRowIndex, 2)

            Dim myconn As New SqlConnection(strconn)
            Dim sqlcmd As New SqlCommand("delete from tblBAN where SOHDBAN='" & Me.txtSOHDBAN.Text & "' and MAMH='" & xTam1 & "'", myconn)
            Try
                myconn.Open()
                sqlcmd.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không Thể Xoá Mặt Hàng : " & xTam2, "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ok = False
            Finally
                If (myconn.State = ConnectionState.Open) Then
                    myconn.Close()
                End If
            End Try
            If ok Then
                Call GetData_MH()
                Call GetData()

                ' chu y cap nhat lai tong tien 
                Dim xTT As Decimal = 0
                xTT = Me.txtTONGTIEN.Text
                Me.txtTONGTIEN.Text = xTT - xSL * xDG
                If Me.txtTRIETKHAU.Text = "" Then
                    Me.txtTIENSAUTK.Text = Me.txtTONGTIEN.Text
                Else
                    xTT = Me.txtTONGTIEN.Text
                    Me.txtTIENSAUTK.Text = xTT - xTT * Me.txtTRIETKHAU.Text

                End If

            End If

        End If

    End Sub

    Private Sub txtTRIETKHAU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTRIETKHAU.KeyPress
        If e.KeyChar = Chr(13) Then
            If IsNumeric(Me.txtTRIETKHAU.Text) = False Then
                MessageBox.Show("Dữ liệu phải là kiểu số bạn hãy nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTRIETKHAU.Focus()
                Exit Sub
            Else
                If Me.txtTRIETKHAU.Text < 0 Or Me.txtTRIETKHAU.Text >= 1 Then
                    MessageBox.Show("Giá trị số của % triết khấu phải >0 và <1 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtTRIETKHAU.Focus()
                    Exit Sub
                End If
                If Me.txtTONGTIEN.Text <> "" Then
                    Dim xTam As Decimal = 0
                    xTam = Me.txtTONGTIEN.Text
                    Me.txtTIENSAUTK.Text = xTam - xTam * Me.txtTRIETKHAU.Text
                End If
            End If
            Me.btnDongY.Focus()
        End If

    End Sub
End Class


