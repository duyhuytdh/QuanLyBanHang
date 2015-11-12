Imports System.Data
Imports System.Data.SqlClient
Public Class frmNUOC
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
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button

    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTENNUOC As System.Windows.Forms.TextBox
    Friend WithEvents txtMANUOC As System.Windows.Forms.TextBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdSua As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents dgView As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents anh1 As System.Windows.Forms.PictureBox
    Friend WithEvents anh2 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDau As System.Windows.Forms.Button
    Friend WithEvents btnCuoi As System.Windows.Forms.Button
    Friend WithEvents lblPos As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNUOC))
        Me.Grb1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTENNUOC = New System.Windows.Forms.TextBox()
        Me.txtMANUOC = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.btnCuoi = New System.Windows.Forms.Button()
        Me.btnDau = New System.Windows.Forms.Button()
        Me.anh2 = New System.Windows.Forms.PictureBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgView = New System.Windows.Forms.DataGrid()
        Me.anh1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdSua = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.MainMenu1 = New System.Windows.Forms.MainMenu()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Grb1.SuspendLayout()
        Me.Grb2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb1
        '
        Me.Grb1.Controls.AddRange(New System.Windows.Forms.Control() {Me.PictureBox2, Me.Label1})
        Me.Grb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grb1.Location = New System.Drawing.Point(8, 8)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(560, 336)
        Me.Grb1.TabIndex = 4
        Me.Grb1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Bitmap)
        Me.PictureBox2.Location = New System.Drawing.Point(97, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 48)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nhập Tên Nước Mới Vào Danh Mục Các Nước Sản Xuất"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTENNUOC
        '
        Me.txtTENNUOC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTENNUOC.Location = New System.Drawing.Point(6, 112)
        Me.txtTENNUOC.Name = "txtTENNUOC"
        Me.txtTENNUOC.Size = New System.Drawing.Size(240, 22)
        Me.txtTENNUOC.TabIndex = 11
        Me.txtTENNUOC.Text = ""
        '
        'txtMANUOC
        '
        Me.txtMANUOC.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMANUOC.Location = New System.Drawing.Point(32, 56)
        Me.txtMANUOC.Name = "txtMANUOC"
        Me.txtMANUOC.Size = New System.Drawing.Size(200, 22)
        Me.txtMANUOC.TabIndex = 10
        Me.txtMANUOC.Text = ""
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(64, 96)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(144, 16)
        Me.lbName.TabIndex = 8
        Me.lbName.Text = "Tên Nước Sản Xuất"
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(96, 40)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(64, 16)
        Me.lbID.TabIndex = 7
        Me.lbID.Text = "Mã Nước "
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(24, 256)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(104, 24)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Ghi Lại"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(152, 256)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(104, 24)
        Me.cmdNew.TabIndex = 2
        Me.cmdNew.Text = "&Thêm Tiếp"
        '
        'Grb2
        '
        Me.Grb2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCuoi, Me.btnDau, Me.anh2, Me.btnNext, Me.btnBack, Me.lblPos, Me.GroupBox1, Me.dgView, Me.anh1, Me.Label2, Me.cmdSua, Me.cmdDelete, Me.cmdClose, Me.cmdNew, Me.cmdSave})
        Me.Grb2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb2.Location = New System.Drawing.Point(8, 8)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(712, 392)
        Me.Grb2.TabIndex = 5
        Me.Grb2.TabStop = False
        '
        'btnCuoi
        '
        Me.btnCuoi.Location = New System.Drawing.Point(644, 352)
        Me.btnCuoi.Name = "btnCuoi"
        Me.btnCuoi.Size = New System.Drawing.Size(56, 23)
        Me.btnCuoi.TabIndex = 24
        Me.btnCuoi.Text = "Cuối"
        '
        'btnDau
        '
        Me.btnDau.Location = New System.Drawing.Point(276, 352)
        Me.btnDau.Name = "btnDau"
        Me.btnDau.Size = New System.Drawing.Size(56, 23)
        Me.btnDau.TabIndex = 23
        Me.btnDau.Text = "Đầu"
        '
        'anh2
        '
        Me.anh2.Image = CType(resources.GetObject("anh2.Image"), System.Drawing.Bitmap)
        Me.anh2.Location = New System.Drawing.Point(124, 9)
        Me.anh2.Name = "anh2"
        Me.anh2.Size = New System.Drawing.Size(40, 47)
        Me.anh2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.anh2.TabIndex = 22
        Me.anh2.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(588, 352)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 23)
        Me.btnNext.TabIndex = 21
        Me.btnNext.Text = ">>"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(340, 352)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(48, 23)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "<<"
        '
        'lblPos
        '
        Me.lblPos.BackColor = System.Drawing.Color.DarkGray
        Me.lblPos.Location = New System.Drawing.Point(396, 352)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(184, 23)
        Me.lblPos.TabIndex = 19
        Me.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbID, Me.txtMANUOC, Me.lbName, Me.txtTENNUOC})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 152)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông Tin Về Nước Sản Xuất"
        '
        'dgView
        '
        Me.dgView.CaptionFont = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.CaptionText = "Danh Sách Các Nước Sản Xuất"
        Me.dgView.DataMember = ""
        Me.dgView.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.dgView.GridLineColor = System.Drawing.Color.Maroon
        Me.dgView.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgView.Location = New System.Drawing.Point(272, 80)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(432, 248)
        Me.dgView.TabIndex = 17
        '
        'anh1
        '
        Me.anh1.Image = CType(resources.GetObject("anh1.Image"), System.Drawing.Bitmap)
        Me.anh1.Location = New System.Drawing.Point(108, 16)
        Me.anh1.Name = "anh1"
        Me.anh1.Size = New System.Drawing.Size(56, 48)
        Me.anh1.TabIndex = 16
        Me.anh1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(432, 48)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Danh Sách Các Nước Sản Xuất"
        '
        'cmdSua
        '
        Me.cmdSua.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSua.Location = New System.Drawing.Point(24, 304)
        Me.cmdSua.Name = "cmdSua"
        Me.cmdSua.Size = New System.Drawing.Size(104, 24)
        Me.cmdSua.TabIndex = 13
        Me.cmdSua.Text = "&Sửa"
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(152, 304)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(104, 24)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "&Xoá"
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(88, 352)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(104, 24)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Đóng"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmNUOC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 414)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Grb2, Me.Grb1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.Name = "frmNUOC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Danh Sách Các Nước Sản Xuất"
        Me.Grb1.ResumeLayout(False)
        Me.Grb2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim xMA As String
    Dim xReSave As Boolean = False

    Dim sConnString = strconn
    Dim iRsCount As Integer
    Dim iCurrPos As Integer
    Dim mySQLConnection As New SqlConnection(sConnString)
    Dim mySQLDataAdapter As New SqlDataAdapter("Select * from tblNUOC", mySQLConnection)

    Dim dsDataSet As DataSet = New DataSet()
    Dim sqlCmdBuilder As SqlCommandBuilder
    Dim sqlDataAdapter2 As SqlClient.SqlDataAdapter

    Private Sub GetData()
        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter2 = _
            New SqlClient.SqlDataAdapter( _
            "Select MANUOC as [Mã Nước],TENNUOC as [Tên Nước] from tblNUOC", sqlConn)

        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder

        sqlCmdBuilder = _
            New SqlClient.SqlCommandBuilder(sqlDataAdapter2)
        Me.dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "tblNUOC")
        With dgView
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "tblNUOC")
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If xReSave = False Then
            
            If Me.txtTENNUOC.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Tên Nước Sản Xuất! ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTENNUOC.Focus()
                Exit Sub
            End If
            Dim mySqlCommand As New SqlCommand("Insert into tblNUOC(MANUOC,TENNUOC) Values(N'" & UCase(Me.txtMANUOC.Text) & "',N'" & Me.txtTENNUOC.Text & "')", mySQLConnection)
            Try
                mySQLConnection.Open()
                mySqlCommand.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không Thể Ghi Lại Được Bản Ghi Này", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try
            Me.txtMANUOC.Text = ""
            Me.txtTENNUOC.Text = ""
            Me.txtMANUOC.Text = Tao_MA("tblNUOC", "NSX", 3)
            Me.txtMANUOC.Enabled = False
            Me.txtTENNUOC.Enabled = True
            Me.txtTENNUOC.Focus()
        Else
            Dim mySqlCommand As New SqlCommand("update tblNUOC set MANUOC='" & UCase(Me.txtMANUOC.Text) & "',TENNUOC=N'" & Me.txtTENNUOC.Text & "' where MANUOC='" & Me.txtMANUOC.Text & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                mySqlCommand.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không Thể Cập Nhật Được Bản Ghi Này.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'MessageBox.Show("Không Thể Ghi Lại Được Bản Ghi Này", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try
            xMA = ""
            xReSave = False
            Me.txtMANUOC.Text = ""
            Me.txtTENNUOC.Text = ""
            Me.txtMANUOC.Text = Tao_MA("tblNUOC", "NSX", 3)
            Me.txtMANUOC.Enabled = False
            Me.txtTENNUOC.Focus()
        End If
        GetData()
        Me.anh1.Visible = True
        Me.anh2.Visible = False
        iRsCount = Me.BindingContext(dsDataSet, "tblNUOC").Count
        lblPos.Text = "Bản ghi thứ 1" & "/" & iRsCount
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim no = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá " & Trim(no) & " Không ?", "Xin Chào", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call delItem2("tblNUOC", "MANUOC", no, "Nước")
            GetData()
            Me.txtMANUOC.Text = Tao_MA("tblNUOC", "NSX", 3)
            Me.txtTENNUOC.Text = ""
            Me.txtTENNUOC.Enabled = True

            xReSave = False
            iRsCount = Me.BindingContext(dsDataSet, "tblNUOC").Count
            lblPos.Text = "Bản ghi thứ 1" & "/" & iRsCount
            Me.txtTENNUOC.Focus()
        End If
       
    End Sub

    Private Sub cmdNew1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Grb1.Visible = True
        Me.Grb2.Visible = False
        Me.txtMANUOC.Text = ""
        Me.txtTENNUOC.Text = ""
        Me.txtMANUOC.Text = Tao_MA("tblNUOC", "NSX", 3)
        Me.txtMANUOC.Enabled = False
        Me.txtTENNUOC.Focus()
        xReSave = False
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        Me.anh2.Visible = True
        Me.anh1.Visible = False
        Me.txtMANUOC.Text = ""
        Me.txtTENNUOC.Text = ""
        Me.txtMANUOC.Text = Tao_MA("tblNUOC", "NSX", 3)
        Me.txtMANUOC.Enabled = False
        Me.txtTENNUOC.Enabled = True

        xReSave = False
        Me.lblPos.Text = "Thêm mới 1 bản ghi"
        Me.txtTENNUOC.Focus()
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Grb2.Visible = True
        Me.Grb1.Visible = False
        GetData()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

    Private Sub frmNUOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.anh1.Visible = True
        Me.anh2.Visible = False
        GetData()
        Me.txtMANUOC.Enabled = False
        If power = "BAN" Then
            Me.cmdSua.Enabled = False
            Me.cmdDelete.Enabled = False
        End If
        iRsCount = Me.BindingContext(dsDataSet, "tblNUOC").Count
        If iRsCount <= 1 Then
            Me.btnBack.Enabled = False
            Me.btnNext.Enabled = False
            Me.btnDau.Enabled = False
            Me.btnCuoi.Enabled = False
            Me.txtTENNUOC.Enabled = True
            Exit Sub

        End If
        lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRsCount
        Me.txtMANUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
        Me.txtTENNUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
        Me.txtTENNUOC.Enabled = False
        Me.txtMANUOC.Enabled = False
        Me.btnBack.Enabled = False
    End Sub


    Private Sub txtMANUOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMANUOC.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtMANUOC.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Mã Của Nước Sản Xuất.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMANUOC.Focus()
                Exit Sub
            Else
                If checkcode("tblNUOC", "MANUOC", Me.txtMANUOC.Text) = False Then
                    MessageBox.Show("Mã Nước Bạn Nhập Vào Đã Tồn Tại. Hãy Sửa Lại !.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtMANUOC.Focus()
                    Exit Sub
                End If
            End If
            Me.txtTENNUOC.Focus()
        End If
    End Sub

    Private Sub txtTENNUOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTENNUOC.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmdSave.Focus()
        End If
    End Sub

    Private Sub cmdSave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmdSave.KeyPress
        If e.KeyChar = Chr(13) Then

        End If
    End Sub

    Private Sub cmdSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSua.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        xMA = ""
        xMA = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Sửa Đổi Bản Ghi Có Mã " & xMA & " Hay Không ?", "Xin Chào ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            GetData()
            Exit Sub
        Else
            Me.txtMANUOC.Text = ""
            Me.txtTENNUOC.Text = ""
            Me.txtMANUOC.Text = xMA
            Me.txtTENNUOC.Text = dgView.Item(dgView.CurrentCell.RowNumber, 1)
            Me.txtTENNUOC.Enabled = True
            Me.txtTENNUOC.Focus()

        End If
        xReSave = True
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        iCurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblNUOC").Count
        If iRsCount < 1 Then
            lblPos.Text = "Không tồn tại bản ghi "
        Else
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            Me.dgView.CurrentRowIndex = iCurrPos - 1
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            iCurrPos = Me.dgView.CurrentRowIndex
            lblPos.Text = "Bản ghi thứ " & iCurrPos + 1 & "/" & iRsCount
            Me.txtMANUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
            Me.txtTENNUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
            xReSave = True
            Me.txtTENNUOC.Enabled = False
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
        iRsCount = Me.BindingContext(dsDataSet, "tblNUOC").Count
        If iCurrPos = iRsCount Then
            Me.btnNext.Enabled = False
        Else
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            iCurrPos += 1
            Me.dgView.CurrentRowIndex = iCurrPos
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            lblPos.Text = "Bản ghi thứ " & iCurrPos + 1 & "/" & iRsCount
            Me.txtTENNUOC.Enabled = False
            Me.txtMANUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
            Me.txtTENNUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
            xReSave = True
        End If
        If iCurrPos >= 1 Then
            Me.btnBack.Enabled = True
        End If
        If iCurrPos = iRsCount - 1 Then
            Me.btnNext.Enabled = False
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
        iRsCount = Me.BindingContext(dsDataSet, "tblNUOC").Count
        lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRsCount
        Me.btnBack.Enabled = False
        Me.btnNext.Enabled = True
        Me.txtTENNUOC.Enabled = False
        Me.txtMANUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
        Me.txtTENNUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
        xReSave = True
    End Sub

    Private Sub btnCuoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuoi.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        iRsCount = Me.BindingContext(dsDataSet, "tblNUOC").Count
        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = iRsCount - 1
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        lblPos.Text = "Bản ghi thứ " & iRsCount & "/" & iRsCount
        Me.btnBack.Enabled = True
        Me.btnNext.Enabled = False
        Me.txtTENNUOC.Enabled = False
        Me.txtMANUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
        Me.txtTENNUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
        xReSave = True
    End Sub

    Private Sub dgView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgView.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        iCurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblNUOC").Count
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
        Me.txtTENNUOC.Enabled = False
        Me.txtMANUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
        Me.txtTENNUOC.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
        xReSave = True
    End Sub
End Class


