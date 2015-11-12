Imports System.Data
Imports System.Data.SqlClient
Public Class frmNhanvien
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
    Friend WithEvents txtDIACHI As System.Windows.Forms.TextBox
    Friend WithEvents txtNSINH As System.Windows.Forms.TextBox
    Friend WithEvents txtHOTEN As System.Windows.Forms.TextBox
    Friend WithEvents txtMANV As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxGIOITINH As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAn As System.Windows.Forms.Button
    Friend WithEvents btnCuoi As System.Windows.Forms.Button
    Friend WithEvents btnDau As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents lblPos As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNhanvien))
        Me.Grb1 = New System.Windows.Forms.GroupBox()
        Me.btnAn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxGIOITINH = New System.Windows.Forms.ComboBox()
        Me.txtDIACHI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNSINH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHOTEN = New System.Windows.Forms.TextBox()
        Me.txtMANV = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgView = New System.Windows.Forms.DataGrid()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdNew1 = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.btnCuoi = New System.Windows.Forms.Button()
        Me.btnDau = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.Grb1.SuspendLayout()
        Me.Grb2.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb1
        '
        Me.Grb1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnAn, Me.PictureBox2, Me.Label5, Me.ComboBoxGIOITINH, Me.txtDIACHI, Me.Label3, Me.Label2, Me.txtNSINH, Me.Label1, Me.txtHOTEN, Me.txtMANV, Me.lbName, Me.lbID, Me.cmdSave, Me.cmdNew, Me.cmdBack})
        Me.Grb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grb1.Location = New System.Drawing.Point(8, 8)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(712, 400)
        Me.Grb1.TabIndex = 4
        Me.Grb1.TabStop = False
        '
        'btnAn
        '
        Me.btnAn.Location = New System.Drawing.Point(528, 312)
        Me.btnAn.Name = "btnAn"
        Me.btnAn.Size = New System.Drawing.Size(96, 23)
        Me.btnAn.TabIndex = 21
        Me.btnAn.Text = "Đóng"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Location = New System.Drawing.Point(88, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 40)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(56, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Giới Tính"
        '
        'ComboBoxGIOITINH
        '
        Me.ComboBoxGIOITINH.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxGIOITINH.Location = New System.Drawing.Point(216, 152)
        Me.ComboBoxGIOITINH.Name = "ComboBoxGIOITINH"
        Me.ComboBoxGIOITINH.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxGIOITINH.TabIndex = 18
        '
        'txtDIACHI
        '
        Me.txtDIACHI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDIACHI.Location = New System.Drawing.Point(216, 232)
        Me.txtDIACHI.Name = "txtDIACHI"
        Me.txtDIACHI.Size = New System.Drawing.Size(328, 23)
        Me.txtDIACHI.TabIndex = 17
        Me.txtDIACHI.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Địa Chỉ"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ngày Tháng Năm Sinh"
        '
        'txtNSINH
        '
        Me.txtNSINH.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNSINH.Location = New System.Drawing.Point(216, 192)
        Me.txtNSINH.Name = "txtNSINH"
        Me.txtNSINH.Size = New System.Drawing.Size(160, 23)
        Me.txtNSINH.TabIndex = 14
        Me.txtNSINH.Text = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nhập Các Thông Tin Nhân Viên Mới "
        '
        'txtHOTEN
        '
        Me.txtHOTEN.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHOTEN.Location = New System.Drawing.Point(216, 112)
        Me.txtHOTEN.Name = "txtHOTEN"
        Me.txtHOTEN.Size = New System.Drawing.Size(328, 23)
        Me.txtHOTEN.TabIndex = 11
        Me.txtHOTEN.Text = ""
        '
        'txtMANV
        '
        Me.txtMANV.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMANV.Location = New System.Drawing.Point(216, 72)
        Me.txtMANV.Name = "txtMANV"
        Me.txtMANV.Size = New System.Drawing.Size(160, 23)
        Me.txtMANV.TabIndex = 10
        Me.txtMANV.Text = ""
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(56, 120)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(64, 16)
        Me.lbName.TabIndex = 8
        Me.lbName.Text = "Họ Tên"
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(56, 80)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(104, 16)
        Me.lbID.TabIndex = 7
        Me.lbID.Text = "Mã Nhân Viên"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(232, 312)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(96, 24)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Ghi Lại"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(88, 312)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(96, 24)
        Me.cmdNew.TabIndex = 2
        Me.cmdNew.Text = "&Thêm Mới"
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(376, 312)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(96, 24)
        Me.cmdBack.TabIndex = 8
        Me.cmdBack.Text = "&Quay Lại"
        '
        'Grb2
        '
        Me.Grb2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCuoi, Me.btnDau, Me.btnNext, Me.btnback, Me.lblPos, Me.PictureBox3, Me.Label4, Me.dgView, Me.cmdUpdate, Me.cmdNew1, Me.cmdDelete, Me.cmdClose})
        Me.Grb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb2.Location = New System.Drawing.Point(8, 8)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(712, 399)
        Me.Grb2.TabIndex = 5
        Me.Grb2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Bitmap)
        Me.PictureBox3.Location = New System.Drawing.Point(162, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(211, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(340, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Danh Sách Các Nhân Viên"
        '
        'dgView
        '
        Me.dgView.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.dgView.CaptionText = "Danh Sách Các Nhân Viên Trong Công Ty"
        Me.dgView.DataMember = ""
        Me.dgView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.GridLineColor = System.Drawing.Color.Maroon
        Me.dgView.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgView.Location = New System.Drawing.Point(8, 56)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(696, 248)
        Me.dgView.TabIndex = 14
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(248, 360)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(96, 24)
        Me.cmdUpdate.TabIndex = 13
        Me.cmdUpdate.Text = "&Sửa Chữa"
        '
        'cmdNew1
        '
        Me.cmdNew1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew1.Location = New System.Drawing.Point(120, 360)
        Me.cmdNew1.Name = "cmdNew1"
        Me.cmdNew1.Size = New System.Drawing.Size(96, 24)
        Me.cmdNew1.TabIndex = 12
        Me.cmdNew1.Text = "&Thêm Mới"
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(376, 360)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(96, 24)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "&Xoá"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(504, 360)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(88, 24)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Đóng"
        '
        'btnCuoi
        '
        Me.btnCuoi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuoi.Location = New System.Drawing.Point(548, 320)
        Me.btnCuoi.Name = "btnCuoi"
        Me.btnCuoi.Size = New System.Drawing.Size(56, 23)
        Me.btnCuoi.TabIndex = 37
        Me.btnCuoi.Text = "Cuối"
        '
        'btnDau
        '
        Me.btnDau.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDau.Location = New System.Drawing.Point(109, 320)
        Me.btnDau.Name = "btnDau"
        Me.btnDau.Size = New System.Drawing.Size(56, 23)
        Me.btnDau.TabIndex = 36
        Me.btnDau.Text = "Đầu"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(484, 320)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(56, 23)
        Me.btnNext.TabIndex = 35
        Me.btnNext.Text = ">>"
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(173, 320)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(56, 23)
        Me.btnback.TabIndex = 34
        Me.btnback.Text = "<<"
        '
        'lblPos
        '
        Me.lblPos.BackColor = System.Drawing.Color.DarkGray
        Me.lblPos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPos.Location = New System.Drawing.Point(247, 320)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(216, 23)
        Me.lblPos.TabIndex = 33
        Me.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmNhanvien
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(728, 417)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Grb2, Me.Grb1})
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNhanvien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Danh Sách Nhân Viên Bán Hàng"
        Me.Grb1.ResumeLayout(False)
        Me.Grb2.ResumeLayout(False)
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim iRscount As Integer
    Dim icurrPos As Integer

    Dim xReSave As Boolean = False
    Dim xMA As String
    Private Sub blank()
        Me.txtMANV.Text = ""
        Me.txtHOTEN.Text = ""
        Me.txtDIACHI.Text = ""
        Me.txtNSINH.Text = ""
        Me.ComboBoxGIOITINH.Items.Clear()
        Me.ComboBoxGIOITINH.Items.Add("Nam")
        Me.ComboBoxGIOITINH.Items.Add("Nữ")
    End Sub

    Dim sConnString = strconn
    Dim mySQLConnection As New SqlConnection(sConnString)
    Dim mySQLDataAdapter As New SqlDataAdapter("Select MANV,HOTEN,GIOITINH,NSINH,DIACHI " & _
    " from tblNHANVIEN", mySQLConnection)
    Dim myDataSet As DataSet = New DataSet()

    Dim sqlCmdBuilder As SqlCommandBuilder

    Dim sqlDataAdapter2 As SqlClient.SqlDataAdapter
    Dim dsDataSet As New DataSet()

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If xReSave = False Then
            If Me.txtMANV.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Mã Cho Nhân Viên.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMANV.Focus()
                Exit Sub
            End If
            If Me.txtHOTEN.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Họ Tên Nhân Viên.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtHOTEN.Focus()
                Exit Sub
            End If
            If Me.ComboBoxGIOITINH.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Giới Tính Của Nhân Viên.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.ComboBoxGIOITINH.Focus()
                Exit Sub
            Else
                If Me.ComboBoxGIOITINH.Text <> "Nam" And Me.ComboBoxGIOITINH.Text <> "Nữ" Then
                    MessageBox.Show("Bạn hãy chọn đúng giới tính của nhân viên.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.ComboBoxGIOITINH.Focus()
                    Exit Sub
                End If
            End If

            If Me.txtNSINH.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Ngày Tháng Năm Sinh Của Nhân Viên.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNSINH.Focus()
                Exit Sub
            Else
                If IsDate(Me.txtNSINH.Text) = False Then
                    MessageBox.Show("Giá Trị Bạn Nhập Vào Không Hợp Lệ.Dữ Liệu Phải Là Kiểu: Ngày \Tháng \Năm ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNSINH.Focus()
                    Exit Sub
                Else
                    If checkDate(Me.txtNSINH.Text) <> 2 Then
                        MessageBox.Show("Ngày sinh phải nhập theo kiểu : Ngày/Tháng/Năm. Bạn hãy sửa lại !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtNSINH.Focus()
                        Exit Sub
                    End If

                End If
            End If
            If Me.txtDIACHI.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Địa Chỉ Của Nhân Viên.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDIACHI.Focus()
                Exit Sub
            End If
            Dim mySqlCommand As New SqlCommand("Insert into tblNHANVIEN(MANV,HOTEN,GIOITINH,NSINH,DIACHI) Values(N'" & UCase(Me.txtMANV.Text) & "',N'" & Me.txtHOTEN.Text & "',N'" & Me.ComboBoxGIOITINH.Text & "',N'" & Me.txtNSINH.Text & "',N'" & Me.txtDIACHI.Text & "')", mySQLConnection)

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
            Me.txtMANV.Text = Tao_MA("tblNHANVIEN", "NV", 2)
            Me.txtMANV.Enabled = False
            Me.txtHOTEN.Focus()

        Else
            If MessageBox.Show("Bạn Có Thật Sự Muốn Ghi Lại Những Thông Tin Vừa Thay Đổi Hay Không ?", "Chào Bạn !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim mysqlcmd As New SqlCommand("update tblNHANVIEN set MANV=N'" & UCase(Me.txtMANV.Text) & "',HOTEN=N'" & Me.txtHOTEN.Text & "',GIOITINH=N'" & Me.ComboBoxGIOITINH.Text & "',NSINH='" & Me.txtNSINH.Text & "',DIACHI=N'" & Me.txtDIACHI.Text & "' where MANV='" & xMA & "'", mySQLConnection)
                Try
                    mySQLConnection.Open()
                    mysqlcmd.ExecuteNonQuery()
                Catch
                    MessageBox.Show("Không Thể Cập Nhật Được Bản Ghi Này.Hãy Thử Lại! ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim no As String = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá: " & no & " Không?", "Xin Chào !", MsgBoxStyle.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
            'Call delItem2("tblNHANVIEN", "MANV", no, "Nhân Viên")
            Dim sqlcmd As New SqlCommand("delete from tblNHANVIEN where MANV='" & no & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                sqlcmd.ExecuteNonQuery()
            Catch
                MessageBox.Show("Khong the xoa duoc NV co ma la '" & no & "'", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                If mySQLConnection.State = ConnectionState.Open Then
                    mySQLConnection.Close()
                End If
            End Try
        End If
        GetData()
        iRscount = Me.BindingContext(dsDataSet, "tblNHANVIEN").Count

        lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRscount
    End Sub

    Private Sub cmdNew1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew1.Click
        Me.Grb1.Visible = True
        Me.Grb2.Visible = False
        blank()
        Me.txtMANV.Text = Tao_MA("tblNHANVIEN", "NV", 2)
        Me.txtMANV.Enabled = False
        Me.txtHOTEN.Focus()
        xReSave = False
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        blank()
        Me.txtMANV.Text = Tao_MA("tblNHANVIEN", "NV", 2)
        Me.txtMANV.Enabled = False
        Me.txtHOTEN.Focus()
        xReSave = False
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Me.Grb2.Visible = True
        Me.Grb1.Visible = False
        GetData()
        iRscount = Me.BindingContext(dsDataSet, "tblNHANVIEN").Count
        lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRscount
        Me.btnback.Enabled = False
    End Sub


    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        xMA = ""
        xMA = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Sửa Nhân Viên Có Mã : " & xMA & " Hay Không ?.", "Xin Chào !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Grb1.Visible = True
            Me.Grb2.Visible = False
            blank()
            Me.txtMANV.Text = dgView.Item(dgView.CurrentCell.RowNumber, 0)
            Me.txtHOTEN.Text = dgView.Item(dgView.CurrentCell.RowNumber, 1)
            Me.ComboBoxGIOITINH.Text = dgView.Item(dgView.CurrentCell.RowNumber, 2)
            Me.txtNSINH.Text = dgView.Item(dgView.CurrentCell.RowNumber, 3)
            Me.txtDIACHI.Text = dgView.Item(dgView.CurrentCell.RowNumber, 4)
            Me.txtMANV.Enabled = False
            Me.txtHOTEN.Focus()
            xReSave = True
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

    Private Sub GetData()
        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter2 = _
            New SqlClient.SqlDataAdapter( _
            "Select MANV as [Mã Nhân Viên],HOTEN as [Họ Tên],GIOITINH as [Giới Tính],NSINH as [Năm Sinh],DIACHI as [Địa Chỉ] from tblNHANVIEN", sqlConn)
        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder
        sqlCmdBuilder = _
            New SqlClient.SqlCommandBuilder(sqlDataAdapter2)
        dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "tblNHANVIEN")

        With dgView
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "tblNHANVIEN")
        End With
    End Sub

    Private Sub frmNhanvien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
        If power = "BAN" Then
            Me.cmdNew1.Enabled = False
            Me.cmdUpdate.Enabled = False
            Me.cmdDelete.Enabled = False
        End If

        iRscount = Me.BindingContext(dsDataSet, "tblNHANVIEN").Count
        If iRscount <= 0 Then
            lblPos.Text = "Không có bản ghi nào !"
        Else

            If Me.BindingContext(Me.dsDataSet, "tblNHANVIEN").Count = 1 Then
                Me.btnNext.Enabled = False
                lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRscount
                Me.btnDau.Enabled = False
                Me.btnCuoi.Enabled = False
                Exit Sub
            Else
                Me.btnDau.Enabled = True
                Me.btnCuoi.Enabled = True
                Me.btnNext.Enabled = True
            End If

            lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRscount
            Me.btnback.Enabled = False
        End If
    End Sub

    Private Sub txtMANV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMANV.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtMANV.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Mã Cho Nhân Viên.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMANV.Focus()
                Exit Sub
            Else
                If checkcode("tblNHANVIEN", "MANV", Me.txtMANV.Text) = False Then
                    MessageBox.Show("Mã Nhân Viên Bạn Nhập Vào Đã Tồn Tại. Hãy Sửa Lại !.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtMANV.Focus()
                    Exit Sub
                End If
            End If
            Me.txtHOTEN.Focus()
        End If
    End Sub

    Private Sub txtHOTEN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHOTEN.KeyPress

        If e.KeyChar = Chr(13) Then
            If Me.txtHOTEN.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết họ tên của nhân viên !.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtHOTEN.Focus()
                Exit Sub
            End If
            Me.ComboBoxGIOITINH.Focus()
            'Else
            'If (Asc(e.KeyChar) < 65 And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 8) Or Asc(e.KeyChar) > 122 Or (Asc(e.KeyChar) > 65 And Asc(e.KeyChar) < 97) Then
            'MessageBox.Show("Họ Tên Của Nhân Viên Không Được Chứa Ký Tự Là Số Hoặc Các Kí Tự Đặc Biệt. Bạn Hãy Sửa Lại !.", "Thông Báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'Me.txtHOTEN.Focus()
            'Exit Sub
            'End If
        End If
    End Sub

    Private Sub ComboBoxGIOITINH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBoxGIOITINH.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.ComboBoxGIOITINH.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết giới tính của nhân viên.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.ComboBoxGIOITINH.Focus()
                Exit Sub
            End If
            Me.txtNSINH.Focus()
        End If
    End Sub

    Private Sub txtNSINH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNSINH.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtNSINH.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết ngày sinh của nhân viên.", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNSINH.Focus()
                Exit Sub
            Else
                If IsDate(Me.txtNSINH.Text) = False Then
                    MessageBox.Show("Ngày sinh của nhân viên không hợp lệ. Bạn hãy thử lại !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNSINH.Focus()
                    Exit Sub
                Else

                    If checkDate(Me.txtNSINH.Text) <> 2 Then
                        MessageBox.Show("Ngày sinh phải nhập theo kiểu : Ngày/Tháng/Năm. Bạn hãy sửa lại !.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtNSINH.Focus()
                        Exit Sub
                    End If
                End If
            End If

            Me.txtDIACHI.Focus()
        End If
    End Sub

    Private Sub txtDIACHI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDIACHI.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmdSave.Focus()
        End If
    End Sub

    Private Sub btnAn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAn.Click
        Me.Hide()
    End Sub

    Private Sub btnDau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDau.Click
        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = 0
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        iRscount = Me.BindingContext(dsDataSet, "tblNHANVIEN").Count
        lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRscount
        Me.btnback.Enabled = False
        Me.btnNext.Enabled = True
    End Sub

    Private Sub btnCuoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuoi.Click
        iRscount = Me.BindingContext(dsDataSet, "tblNHANVIEN").Count
        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = iRscount - 1
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        lblPos.Text = "Bản ghi thứ " & iRscount & "/" & iRscount
        Me.btnback.Enabled = True
        Me.btnNext.Enabled = False
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        icurrPos = Me.dgView.CurrentRowIndex
        iRscount = Me.BindingContext(dsDataSet, "tblNHANVIEN").Count
        If iRscount < 1 Then
            lblPos.Text = "Không tồn tại bản ghi "
        Else
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            Me.dgView.CurrentRowIndex = icurrPos - 1
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            icurrPos = Me.dgView.CurrentRowIndex
            lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRscount
        End If
        If icurrPos < 1 Then
            Me.btnback.Enabled = False
        End If
        If icurrPos < iRscount Then
            Me.btnNext.Enabled = True
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        icurrPos = Me.dgView.CurrentRowIndex
        iRscount = Me.BindingContext(dsDataSet, "tblNHANVIEN").Count
        If icurrPos = iRscount Then
            Me.btnNext.Enabled = False
        Else
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            icurrPos += 1
            Me.dgView.CurrentRowIndex = icurrPos
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRscount
        End If
        If icurrPos >= 1 Then
            Me.btnback.Enabled = True
        End If
        If icurrPos = iRscount - 1 Then
            Me.btnNext.Enabled = False
        End If
    End Sub

    Private Sub dgView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgView.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        icurrPos = Me.dgView.CurrentRowIndex
        iRscount = Me.BindingContext(dsDataSet, "tblNHANVIEN").Count

        If icurrPos = 0 Or iRscount = 1 Then
            Me.btnback.Enabled = False
        End If
        If icurrPos > 0 And iRscount > 1 Then
            Me.btnback.Enabled = True
        End If
        If icurrPos < iRscount - 1 And iRscount > 1 Then
            Me.btnNext.Enabled = True
        End If
        If icurrPos = iRscount - 1 Or iRscount = 1 Then
            Me.btnNext.Enabled = False
        End If

        If icurrPos > 0 And icurrPos < iRscount - 1 Then
            Me.btnback.Enabled = True
            Me.btnNext.Enabled = True
        End If
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRscount
    End Sub
End Class


