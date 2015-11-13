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
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents cmdBack As System.Windows.Forms.Button

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFAX As System.Windows.Forms.TextBox
    Friend WithEvents txtTEL As System.Windows.Forms.TextBox
    Friend WithEvents txtDiaChi As System.Windows.Forms.TextBox
    Friend WithEvents txtTenKhach As System.Windows.Forms.TextBox
    Friend WithEvents txtMaKhach As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdNew1 As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents dgView As System.Windows.Forms.DataGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Grb2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDong As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmKhach))
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
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdNew1 = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.dgView = New System.Windows.Forms.DataGrid()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.Grb1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grb2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grb1
        '
        Me.Grb1.Controls.Add(Me.btnDong)
        Me.Grb1.Controls.Add(Me.PictureBox2)
        Me.Grb1.Controls.Add(Me.txtFAX)
        Me.Grb1.Controls.Add(Me.Label4)
        Me.Grb1.Controls.Add(Me.txtTEL)
        Me.Grb1.Controls.Add(Me.Label3)
        Me.Grb1.Controls.Add(Me.txtDiaChi)
        Me.Grb1.Controls.Add(Me.Label2)
        Me.Grb1.Controls.Add(Me.Label1)
        Me.Grb1.Controls.Add(Me.txtTenKhach)
        Me.Grb1.Controls.Add(Me.txtMaKhach)
        Me.Grb1.Controls.Add(Me.lbName)
        Me.Grb1.Controls.Add(Me.lbID)
        Me.Grb1.Controls.Add(Me.cmdSave)
        Me.Grb1.Controls.Add(Me.cmdNew)
        Me.Grb1.Controls.Add(Me.cmdBack)
        Me.Grb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grb1.Location = New System.Drawing.Point(21, 10)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(872, 490)
        Me.Grb1.TabIndex = 4
        Me.Grb1.TabStop = False
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(653, 420)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(103, 29)
        Me.btnDong.TabIndex = 20
        Me.btnDong.Text = "Đóng"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 62)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'txtFAX
        '
        Me.txtFAX.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFAX.Location = New System.Drawing.Point(303, 350)
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Size = New System.Drawing.Size(247, 27)
        Me.txtFAX.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 29)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Số FAX"
        '
        'txtTEL
        '
        Me.txtTEL.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEL.Location = New System.Drawing.Point(303, 290)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Size = New System.Drawing.Size(247, 27)
        Me.txtTEL.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(129, 290)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 29)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Số Điện Thoại"
        '
        'txtDiaChi
        '
        Me.txtDiaChi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiaChi.Location = New System.Drawing.Point(303, 230)
        Me.txtDiaChi.Name = "txtDiaChi"
        Me.txtDiaChi.Size = New System.Drawing.Size(463, 27)
        Me.txtDiaChi.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(129, 230)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 29)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Địa Chỉ"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(82, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(803, 60)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nhập Những Thông Tin Chính Của Khách Hàng Mới "
        '
        'txtTenKhach
        '
        Me.txtTenKhach.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTenKhach.Location = New System.Drawing.Point(303, 170)
        Me.txtTenKhach.Name = "txtTenKhach"
        Me.txtTenKhach.Size = New System.Drawing.Size(463, 27)
        Me.txtTenKhach.TabIndex = 11
        '
        'txtMaKhach
        '
        Me.txtMaKhach.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaKhach.Location = New System.Drawing.Point(303, 110)
        Me.txtMaKhach.Name = "txtMaKhach"
        Me.txtMaKhach.Size = New System.Drawing.Size(247, 27)
        Me.txtMaKhach.TabIndex = 10
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(129, 180)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(164, 20)
        Me.lbName.TabIndex = 8
        Me.lbName.Text = "Tên Khách Hàng"
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(129, 120)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(144, 20)
        Me.lbID.TabIndex = 7
        Me.lbID.Text = "Mã Khách Hàng"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(303, 420)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(124, 30)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Lưu"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(139, 420)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(123, 30)
        Me.cmdNew.TabIndex = 2
        Me.cmdNew.Text = "&Thêm"
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(478, 420)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(124, 30)
        Me.cmdBack.TabIndex = 8
        Me.cmdBack.Text = "&Quay Lại"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(642, 410)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(123, 30)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Đóng"
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(467, 410)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(124, 30)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "&Xoá "
        '
        'cmdNew1
        '
        Me.cmdNew1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew1.Location = New System.Drawing.Point(117, 410)
        Me.cmdNew1.Name = "cmdNew1"
        Me.cmdNew1.Size = New System.Drawing.Size(124, 30)
        Me.cmdNew1.TabIndex = 12
        Me.cmdNew1.Text = "&Thêm "
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(292, 410)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(124, 30)
        Me.cmdUpdate.TabIndex = 13
        Me.cmdUpdate.Text = "&Sửa "
        '
        'dgView
        '
        Me.dgView.CaptionText = "Danh Sách Các Khách Hàng Chính"
        Me.dgView.DataMember = ""
        Me.dgView.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.GridLineColor = System.Drawing.Color.Maroon
        Me.dgView.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgView.Location = New System.Drawing.Point(0, 67)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(850, 310)
        Me.dgView.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(216, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(571, 40)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Danh Sách Các Khách Hàng Chính"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(144, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 50)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Grb2
        '
        Me.Grb2.Controls.Add(Me.PictureBox1)
        Me.Grb2.Controls.Add(Me.Label5)
        Me.Grb2.Controls.Add(Me.dgView)
        Me.Grb2.Controls.Add(Me.cmdUpdate)
        Me.Grb2.Controls.Add(Me.cmdNew1)
        Me.Grb2.Controls.Add(Me.cmdDelete)
        Me.Grb2.Controls.Add(Me.cmdClose)
        Me.Grb2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb2.Location = New System.Drawing.Point(21, 10)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(872, 465)
        Me.Grb2.TabIndex = 5
        Me.Grb2.TabStop = False
        '
        'frmKhach
        '
        Me.ClientSize = New System.Drawing.Size(892, 464)
        Me.Controls.Add(Me.Grb2)
        Me.Controls.Add(Me.Grb1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmKhach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Danh Sách Khách Hàng Quan Trọng"
        Me.Grb1.ResumeLayout(False)
        Me.Grb1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grb2.ResumeLayout(False)
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

    Private Sub btnDau_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = 0
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count

    End Sub

    Private Sub btnCuoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count
        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = iRsCount - 1
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        icurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        icurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count
    End Sub

    Private Sub dgView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgView.Click

        icurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblKHACH").Count

        If Me.dgView.VisibleRowCount < 2 Then
            Exit Sub
        End If
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
    End Sub

    Private Sub btnDong_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDong.Click
        Me.Hide()

    End Sub
End Class


