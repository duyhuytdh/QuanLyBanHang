Imports System.Data
Imports System.Data.SqlClient
Public Class frmKhach
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
    Friend WithEvents txtFAX As System.Windows.Forms.TextBox
    Friend WithEvents txtTEL As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKhach As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKhach As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents btnCuoi As System.Windows.Forms.Button
    Friend WithEvents btnDau As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents lblPos As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmKhach))
        Me.Grb1 = New System.Windows.Forms.GroupBox()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtFAX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTEL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDiaChi = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTenKhach = New System.Windows.Forms.TextBox()
        Me.txtMaKhach = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.btnCuoi = New System.Windows.Forms.Button()
        Me.btnDau = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.Grb1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDong, Me.PictureBox2, Me.txtFAX, Me.Label4, Me.txtTEL, Me.Label3, Me.txtDiaChi, Me.Label2, Me.Label1, Me.txtTenKhach, Me.txtMaKhach, Me.lbName, Me.lbID, Me.cmdSave, Me.cmdNew, Me.cmdBack})
        Me.Grb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grb1.Location = New System.Drawing.Point(16, 8)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(696, 392)
        Me.Grb1.TabIndex = 4
        Me.Grb1.TabStop = False
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(508, 336)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(80, 23)
        Me.btnDong.TabIndex = 20
        Me.btnDong.Text = "Đóng"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'txtFAX
        '
        Me.txtFAX.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFAX.Location = New System.Drawing.Point(236, 280)
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Size = New System.Drawing.Size(192, 23)
        Me.txtFAX.TabIndex = 18
        Me.txtFAX.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Số FAX"
        '
        'txtTEL
        '
        Me.txtTEL.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEL.Location = New System.Drawing.Point(236, 232)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Size = New System.Drawing.Size(192, 23)
        Me.txtTEL.TabIndex = 16
        Me.txtTEL.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Số Điện Thoại"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(236, 184)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(360, 23)
        Me.txtDiaChi.TabIndex = 14
        Me.txtDiaChi.Text = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Địa Chỉ"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 48)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nhập Những Thông Tin Chính Của Khách Hàng Mới "
        '
        'txtTenKhach
        '
        Me.txtTenKhach.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenKhach.Location = New System.Drawing.Point(236, 136)
        Me.txtTenKhach.Name = "txtTenKhach"
        Me.txtTenKhach.Size = New System.Drawing.Size(360, 23)
        Me.txtTenKhach.TabIndex = 11
        Me.txtTenKhach.Text = ""
        '
        'txtMaKhach
        '
        Me.txtMaKhach.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKhach.Location = New System.Drawing.Point(236, 88)
        Me.txtMaKhach.Name = "txtMaKhach"
        Me.txtMaKhach.Size = New System.Drawing.Size(192, 23)
        Me.txtMaKhach.TabIndex = 10
        Me.txtMaKhach.Text = ""
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(100, 144)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(128, 16)
        Me.lbName.TabIndex = 8
        Me.lbName.Text = "Tên Khách Hàng"
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(100, 96)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(112, 16)
        Me.lbID.TabIndex = 7
        Me.lbID.Text = "Mã Khách Hàng"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(236, 336)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(96, 24)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Ghi Lại"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(108, 336)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(96, 24)
        Me.cmdNew.TabIndex = 2
        Me.cmdNew.Text = "&Thêm Mới"
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(372, 336)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(96, 24)
        Me.cmdBack.TabIndex = 8
        Me.cmdBack.Text = "&Quay Lại"
        '
        'Grb2
        '
        Me.Grb2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCuoi, Me.btnDau, Me.btnNext, Me.btnback, Me.lblPos, Me.PictureBox1, Me.Label5, Me.dgView, Me.cmdUpdate, Me.cmdNew1, Me.cmdDelete, Me.cmdClose})
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
        Me.btnCuoi.Location = New System.Drawing.Point(540, 316)
        Me.btnCuoi.Name = "btnCuoi"
        Me.btnCuoi.Size = New System.Drawing.Size(56, 23)
        Me.btnCuoi.TabIndex = 37
        Me.btnCuoi.Text = "Cuối"
        '
        'btnDau
        '
        Me.btnDau.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDau.Location = New System.Drawing.Point(101, 316)
        Me.btnDau.Name = "btnDau"
        Me.btnDau.Size = New System.Drawing.Size(56, 23)
        Me.btnDau.TabIndex = 36
        Me.btnDau.Text = "Đầu"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(476, 316)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(56, 23)
        Me.btnNext.TabIndex = 35
        Me.btnNext.Text = ">>"
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(165, 316)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(56, 23)
        Me.btnback.TabIndex = 34
        Me.btnback.Text = "<<"
        '
        'lblPos
        '
        Me.lblPos.BackColor = System.Drawing.Color.DarkGray
        Me.lblPos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPos.Location = New System.Drawing.Point(239, 316)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(216, 23)
        Me.lblPos.TabIndex = 33
        Me.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(112, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 40)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(416, 32)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Danh Sách Các Khách Hàng Chính"
        '
        'dgView
        '
        Me.dgView.CaptionText = "Danh Sách Các Khách Hàng Chính"
        Me.dgView.DataMember = ""
        Me.dgView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.GridLineColor = System.Drawing.Color.Maroon
        Me.dgView.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgView.Location = New System.Drawing.Point(4, 56)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(688, 248)
        Me.dgView.TabIndex = 14
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(232, 355)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(96, 24)
        Me.cmdUpdate.TabIndex = 13
        Me.cmdUpdate.Text = "&Sửa Chữa"
        '
        'cmdNew1
        '
        Me.cmdNew1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew1.Location = New System.Drawing.Point(96, 355)
        Me.cmdNew1.Name = "cmdNew1"
        Me.cmdNew1.Size = New System.Drawing.Size(96, 24)
        Me.cmdNew1.TabIndex = 12
        Me.cmdNew1.Text = "&Thêm Mới"
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(368, 355)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(96, 24)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "&Xoá Bỏ"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(504, 355)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(96, 24)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Đóng"
        '
        'frmKhach
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(728, 414)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Grb2, Me.Grb1})
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKhach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Danh Sách Khách Hàng Quan Trọng"
        Me.Grb1.ResumeLayout(False)
        Me.Grb2.ResumeLayout(False)
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim xReSave As Boolean = False
    Dim iRsCount As Integer
    Dim icurrPos As Integer
    Dim xMA As String

    Dim sConnString = strconn

    Dim mySQLConnection As New SqlConnection(sConnString)
    Dim mySQLDataAdapter As New SqlDataAdapter("Select * from tblKHACH", mySQLConnection)
    Dim myDataSet As DataSet = New DataSet()

    Dim sqlCmdBuilder As SqlCommandBuilder

    Dim sqlDataAdapter2 As SqlClient.SqlDataAdapter
    Dim dsDataSet As New DataSet()
    Private Sub blank()
        Me.txtMaKhach.Text = ""
        Me.txtTenKhach.Text = ""
        Me.txtDiaChi.Text = ""
        Me.txtTEL.Text = ""
        Me.txtFAX.Text = ""
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If xReSave = False Then
            If Me.txtMaKhach.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Mã Cho Khách Hàng Mới.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMaKhach.Focus()
                Exit Sub
            End If
            If Me.txtTenKhach.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Vào Tên Khách Hàng .", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTenKhach.Focus()
                Exit Sub
            End If
            If Me.txtDiaChi.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Vào Địa Chỉ Của Khách Hàng .", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDiaChi.Focus()
                Exit Sub
            End If
            If Me.txtTEL.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Vào Số Điện Thoại Của Khách Hàng .", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTEL.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtTEL.Text) = False Then
                    MessageBox.Show(" Thông Tin Bạn Nhập Vào Không Hợp Lệ. Số Điện Phải Là Kiểu Số .", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtTEL.Focus()
                    Exit Sub
                End If
            End If
            If Me.txtFAX.Text <> "" Then
                If IsNumeric(Me.txtFAX.Text) = False Then
                    MessageBox.Show(" Thông Tin Bạn Nhập Vào Không Hợp Lệ. Số Fax Phải Là Kiểu Số .", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtFAX.Focus()
                    Exit Sub
                End If
            End If

            Dim mySqlCommand As New SqlCommand("Insert into tblKHACH(MAKHACH,TENKHACH,DIACHI,TEL,FAX) Values('" & UCase(Me.txtMaKhach.Text) & "',N'" & Me.txtTenKhach.Text & "',N'" & Me.txtDiaChi.Text & "','" & Me.txtTEL.Text & "','" & Me.txtFAX.Text & "')", mySQLConnection)

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
            Me.txtMaKhach.Text = ""
            Me.txtMaKhach.Enabled = False
            Me.txtMaKhach.Text = Tao_MA("tblKHACH", "K", 1)
            Me.txtTenKhach.Focus()
        Else
            Dim mysqlcmd As New SqlCommand("update tblKHACH set MAKHACH='" & UCase(Me.txtMaKhach.Text) & "',TENKHACH=N'" & Me.txtTenKhach.Text & "',DIACHI=N'" & Me.txtDiaChi.Text & "',TEL='" & Me.txtTEL.Text & "',FAX='" & Me.txtFAX.Text & "' where MAKHACH='" & xMA & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                mysqlcmd.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không Thể Cập Nhật Được Những Thông Tin Vừa Thay Đổi. Bạn Hãy Thử Lại.", "Chào Bạn !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                If mySQLConnection.State = ConnectionState.Open Then
                    mySQLConnection.Close()
                End If
            End Try
            blank()
            xReSave = False
            Me.txtMaKhach.Text = ""
            Me.txtMaKhach.Enabled = False
            Me.cmdBack.Focus()

        End If
       
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim No = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá " & No & " Hay Không ?.", "Xin Chào !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call delItem2("tblKHACH", "MAKHACH", No, "Khách Hàng")
        End If
        GetData()
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count
        If iRsCount >= 1 Then
            lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRsCount
            If iRsCount = 1 Then
                Me.btnback.Enabled = False
                Me.btnNext.Enabled = False
            End If
        Else
            lblPos.Text = "Không có bản ghi nào !"
            Me.btnback.Enabled = False
            Me.btnNext.Enabled = False

        End If

    End Sub

    Private Sub cmdNew1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew1.Click
        Me.Grb1.Visible = True
        Me.Grb2.Visible = False
        blank()
        Me.txtMaKhach.Text = ""
        Me.txtMaKhach.Enabled = False
        Me.txtMaKhach.Text = Tao_MA("tblKHACH", "K", 1)
        Me.txtTenKhach.Focus()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        blank()
        Me.txtMaKhach.Text = ""
        Me.txtMaKhach.Enabled = False
        Me.txtMaKhach.Text = Tao_MA("tblKHACH", "K", 1)
        Me.txtTenKhach.Focus()
        xReSave = False
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Me.Grb2.Visible = True
        Me.Grb1.Visible = False
        GetData()
        xReSave = False

        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count
        If iRsCount >= 1 Then
            lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRsCount
        End If

        If iRsCount <= 1 Then
            Me.btnback.Enabled = False
            Me.btnNext.Enabled = False
        Else
            Me.btnback.Enabled = False
            Me.btnNext.Enabled = True
        End If
    End Sub


    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        xMA = ""
        xMA = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Sửa Khách Hàng Có Mã : " & xMA & " Hay Không ?.", "Chào Bạn !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Grb1.Visible = True
            Me.Grb2.Visible = False
            blank()
            Me.txtMaKhach.Text = dgView.Item(dgView.CurrentCell.RowNumber, 0)
            Me.txtTenKhach.Text = dgView.Item(dgView.CurrentCell.RowNumber, 1)
            Me.txtDiaChi.Text = dgView.Item(dgView.CurrentCell.RowNumber, 2)
            Me.txtTEL.Text = dgView.Item(dgView.CurrentCell.RowNumber, 3)
            Me.txtFAX.Text = dgView.Item(dgView.CurrentCell.RowNumber, 4)
            xReSave = True
            Me.txtMaKhach.Enabled = False
        End If

    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

    Private Sub GetData()
        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter2 = New SqlClient.SqlDataAdapter("Select MAKHACH as [Mã Khách Hàng],TENKHACH as [Tên Khách],DIACHI as [Địa Chỉ],TEL as [Số Điện Thoại],FAX as [Số FAX] from tblKHACH", sqlConn)
        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder
        sqlCmdBuilder = New SqlClient.SqlCommandBuilder(sqlDataAdapter2)
        Me.dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "tblKHACH")
        With dgView
            .CaptionText = "Danh Sách Các Khách Hàng Chính"
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "tblKHACH")
        End With
    End Sub

    Private Sub frmKhach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
        If power = "BAN" Then
            Me.cmdNew1.Enabled = False
            Me.cmdUpdate.Enabled = False
            Me.cmdDelete.Enabled = False
        End If
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count
        If iRsCount <= 0 Then
            lblPos.Text = "Không có bản ghi nào !"
            Me.btnback.Enabled = False
            Me.btnNext.Enabled = False
        Else

            If Me.BindingContext(Me.dsDataSet, "tblKHACH").Count = 1 Then
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

            lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRsCount
            Me.btnback.Enabled = False
        End If
    End Sub

    Private Sub txtMaKhach_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaKhach.KeyPress
        If e.KeyChar = Chr(13) Then

            If Me.txtMaKhach.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Mã Của Khách Hàng.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMaKhach.Focus()
                Exit Sub
            Else
                If checkcode("tblKHACH", "MAKHACH", Me.txtMaKhach.Text) = False Then
                    MessageBox.Show(" Mã Khách Hàng Bạn Nhập Vào Đã Tồn Tại. Hãy Sửa Lại!.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtMaKhach.Focus()
                    Exit Sub
                End If
            End If
            Me.txtTenKhach.Focus()
        End If
    End Sub

    Private Sub txtTenKhach_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTenKhach.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDiaChi.Focus()
        End If
    End Sub

    Private Sub txtDiaChi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiaChi.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtTEL.Focus()
        End If
    End Sub

    Private Sub txtTEL_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTEL.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtFAX.Focus()
        End If
    End Sub

    Private Sub txtFAX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFAX.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmdSave.Focus()
        End If
    End Sub

    Private Sub btnDau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDau.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = 0
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count
        lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRsCount
        Me.btnback.Enabled = False
        If iRsCount > 1 Then
            Me.btnNext.Enabled = True
        Else
            Me.btnNext.Enabled = False
        End If

    End Sub

    Private Sub btnCuoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuoi.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count
        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = iRsCount - 1
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        lblPos.Text = "Bản ghi thứ " & iRsCount & "/" & iRsCount
        If iRsCount > 1 Then
            Me.btnback.Enabled = True
        Else
            Me.btnback.Enabled = False
        End If

        Me.btnNext.Enabled = False
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        icurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count
        If iRsCount < 1 Then
            lblPos.Text = "Không tồn tại bản ghi "
        Else
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            Me.dgView.CurrentRowIndex = icurrPos - 1
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            icurrPos = Me.dgView.CurrentRowIndex
            lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRsCount
        End If
        If icurrPos < 1 Then
            Me.btnback.Enabled = False
        End If
        If icurrPos < iRsCount Then
            Me.btnNext.Enabled = True
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        icurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count
        If icurrPos = iRsCount Then
            Me.btnNext.Enabled = False
        Else
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            icurrPos += 1
            Me.dgView.CurrentRowIndex = icurrPos
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRsCount
        End If
        If icurrPos >= 1 Then
            Me.btnback.Enabled = True
        End If
        If icurrPos = iRsCount - 1 Then
            Me.btnNext.Enabled = False
        End If
    End Sub

    Private Sub dgView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgView.Click

        icurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count

        If Me.dgView.VisibleRowCount < 2 Then
            Exit Sub
        End If
        If icurrPos = 0 Or iRsCount = 1 Then
            Me.btnback.Enabled = False
        End If
        If icurrPos > 0 And iRsCount > 1 Then
            Me.btnback.Enabled = True
        End If
        If icurrPos < iRsCount - 1 And iRsCount > 1 Then
            Me.btnNext.Enabled = True
        End If
        If icurrPos = iRsCount - 1 Or iRsCount = 1 Then
            Me.btnNext.Enabled = False
        End If

        If icurrPos > 0 And icurrPos < iRsCount - 1 Then
            Me.btnback.Enabled = True
            Me.btnNext.Enabled = True
        End If


        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRsCount
    End Sub

    Private Sub btnDong_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDong.Click
        Me.Hide()

    End Sub
End Class


