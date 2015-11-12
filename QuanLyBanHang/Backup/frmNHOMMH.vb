Imports System.Data
Imports System.Data.SqlClient
Public Class frmNHOMMH
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
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdBack As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button

    Friend WithEvents cmdNew1 As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents dgView As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImgNhomMH As System.Windows.Forms.ImageList
    Friend WithEvents anh1 As System.Windows.Forms.PictureBox
    Friend WithEvents anh2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtTENNHOM As System.Windows.Forms.TextBox
    Friend WithEvents txtMANHOM As System.Windows.Forms.TextBox
    Friend WithEvents lbName As System.Windows.Forms.Label
    Friend WithEvents lbID As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents lblPos As System.Windows.Forms.Label
    Friend WithEvents btnDau As System.Windows.Forms.Button
    Friend WithEvents btnCuoi As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmNHOMMH))
        Me.Grb1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.ImgNhomMH = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.btnCuoi = New System.Windows.Forms.Button()
        Me.btnDau = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.lblPos = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtTENNHOM = New System.Windows.Forms.TextBox()
        Me.txtMANHOM = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.anh2 = New System.Windows.Forms.PictureBox()
        Me.anh1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Grb1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.cmdNew, Me.cmdBack})
        Me.Grb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grb1.Location = New System.Drawing.Point(16, 8)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(574, 360)
        Me.Grb1.TabIndex = 4
        Me.Grb1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Thêm Vào Nhóm Mặt Hàng Mới"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Image = CType(resources.GetObject("cmdNew.Image"), System.Drawing.Bitmap)
        Me.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew.ImageIndex = 1
        Me.cmdNew.ImageList = Me.ImgNhomMH
        Me.cmdNew.Location = New System.Drawing.Point(99, 248)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(106, 24)
        Me.cmdNew.TabIndex = 2
        Me.cmdNew.Text = "&Thêm Mới"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImgNhomMH
        '
        Me.ImgNhomMH.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgNhomMH.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImgNhomMH.ImageStream = CType(resources.GetObject("ImgNhomMH.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgNhomMH.TransparentColor = System.Drawing.Color.Transparent
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(371, 248)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(104, 24)
        Me.cmdBack.TabIndex = 8
        Me.cmdBack.Text = "&Quay Lại"
        '
        'Grb2
        '
        Me.Grb2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCuoi, Me.btnDau, Me.btnNext, Me.btnback, Me.lblPos, Me.cmdSave, Me.txtTENNHOM, Me.txtMANHOM, Me.lbName, Me.lbID, Me.anh2, Me.anh1, Me.Label2, Me.dgView, Me.cmdUpdate, Me.cmdNew1, Me.cmdDelete, Me.cmdClose})
        Me.Grb2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grb2.Location = New System.Drawing.Point(12, 8)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(701, 392)
        Me.Grb2.TabIndex = 5
        Me.Grb2.TabStop = False
        '
        'btnCuoi
        '
        Me.btnCuoi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuoi.Location = New System.Drawing.Point(543, 312)
        Me.btnCuoi.Name = "btnCuoi"
        Me.btnCuoi.Size = New System.Drawing.Size(56, 23)
        Me.btnCuoi.TabIndex = 27
        Me.btnCuoi.Text = "Cuối"
        '
        'btnDau
        '
        Me.btnDau.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDau.Location = New System.Drawing.Point(104, 312)
        Me.btnDau.Name = "btnDau"
        Me.btnDau.Size = New System.Drawing.Size(56, 23)
        Me.btnDau.TabIndex = 26
        Me.btnDau.Text = "Đầu"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(479, 312)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(56, 23)
        Me.btnNext.TabIndex = 25
        Me.btnNext.Text = ">>"
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(168, 312)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(56, 23)
        Me.btnback.TabIndex = 24
        Me.btnback.Text = "<<"
        '
        'lblPos
        '
        Me.lblPos.BackColor = System.Drawing.Color.DarkGray
        Me.lblPos.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPos.Location = New System.Drawing.Point(242, 312)
        Me.lblPos.Name = "lblPos"
        Me.lblPos.Size = New System.Drawing.Size(216, 23)
        Me.lblPos.TabIndex = 23
        Me.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.ImageList = Me.ImgNhomMH
        Me.cmdSave.Location = New System.Drawing.Point(400, 352)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(96, 24)
        Me.cmdSave.TabIndex = 22
        Me.cmdSave.Text = "&Ghi Lại"
        '
        'txtTENNHOM
        '
        Me.txtTENNHOM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTENNHOM.Location = New System.Drawing.Point(328, 54)
        Me.txtTENNHOM.Name = "txtTENNHOM"
        Me.txtTENNHOM.Size = New System.Drawing.Size(232, 23)
        Me.txtTENNHOM.TabIndex = 21
        Me.txtTENNHOM.Text = ""
        '
        'txtMANHOM
        '
        Me.txtMANHOM.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMANHOM.Location = New System.Drawing.Point(88, 54)
        Me.txtMANHOM.Name = "txtMANHOM"
        Me.txtMANHOM.Size = New System.Drawing.Size(160, 23)
        Me.txtMANHOM.TabIndex = 20
        Me.txtMANHOM.Text = ""
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(248, 62)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(80, 16)
        Me.lbName.TabIndex = 19
        Me.lbName.Text = "Tên Nhóm"
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(9, 62)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(72, 16)
        Me.lbID.TabIndex = 18
        Me.lbID.Text = "Mã Nhóm"
        '
        'anh2
        '
        Me.anh2.Image = CType(resources.GetObject("anh2.Image"), System.Drawing.Bitmap)
        Me.anh2.Location = New System.Drawing.Point(133, 14)
        Me.anh2.Name = "anh2"
        Me.anh2.Size = New System.Drawing.Size(32, 32)
        Me.anh2.TabIndex = 17
        Me.anh2.TabStop = False
        '
        'anh1
        '
        Me.anh1.Image = CType(resources.GetObject("anh1.Image"), System.Drawing.Bitmap)
        Me.anh1.Location = New System.Drawing.Point(126, 8)
        Me.anh1.Name = "anh1"
        Me.anh1.Size = New System.Drawing.Size(40, 32)
        Me.anh1.TabIndex = 16
        Me.anh1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(170, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(404, 28)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Danh Sách Các Nhóm Mặt Hàng"
        '
        'dgView
        '
        Me.dgView.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.dgView.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.dgView.CaptionText = "Danh Sách Các Nhóm Mặt Hàng"
        Me.dgView.DataMember = ""
        Me.dgView.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.GridLineColor = System.Drawing.Color.Maroon
        Me.dgView.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgView.Location = New System.Drawing.Point(3, 88)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(694, 208)
        Me.dgView.TabIndex = 14
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUpdate.ImageList = Me.ImgNhomMH
        Me.cmdUpdate.Location = New System.Drawing.Point(144, 352)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(102, 24)
        Me.cmdUpdate.TabIndex = 13
        Me.cmdUpdate.Text = "&Sửa Chữa"
        '
        'cmdNew1
        '
        Me.cmdNew1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew1.Image = CType(resources.GetObject("cmdNew1.Image"), System.Drawing.Bitmap)
        Me.cmdNew1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNew1.ImageIndex = 1
        Me.cmdNew1.ImageList = Me.ImgNhomMH
        Me.cmdNew1.Location = New System.Drawing.Point(272, 352)
        Me.cmdNew1.Name = "cmdNew1"
        Me.cmdNew1.Size = New System.Drawing.Size(104, 24)
        Me.cmdNew1.TabIndex = 12
        Me.cmdNew1.Text = "&Thêm Mới"
        Me.cmdNew1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Bitmap)
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.ImageIndex = 5
        Me.cmdDelete.ImageList = Me.ImgNhomMH
        Me.cmdDelete.Location = New System.Drawing.Point(24, 352)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(96, 24)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "&Xoá Bỏ"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.ImageList = Me.ImgNhomMH
        Me.cmdClose.Location = New System.Drawing.Point(584, 352)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(96, 24)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Đóng"
        '
        'frmNHOMMH
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 414)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Grb2, Me.Grb1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNHOMMH"
        Me.Text = "Danh Sách Các Nhóm Mặt Hàng"
        Me.Grb1.ResumeLayout(False)
        Me.Grb2.ResumeLayout(False)
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim iRsCount As Integer
    Dim icurrPos As Integer
    ' Dim vt As Integer

    Dim xMA As String
    Dim xReSave As Boolean = False

    Dim sConnString = strconn
    Dim mySQLConnection As New SqlConnection(sConnString)
    Dim mySQLDataAdapter As New SqlDataAdapter("Select MANHOM,TENNHOM " & _
    " from tblNHOMMH", mySQLConnection)
    Dim myDataSet As DataSet = New DataSet()

    Dim sqlCmdBuilder As SqlCommandBuilder

    Dim sqlDataAdapter2 As SqlClient.SqlDataAdapter
    Dim dsDataSet As New DataSet()

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If xReSave = False Then
            If Me.txtMANHOM.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Mã Của Nhóm Hàng.", "Xin Chào ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMANHOM.Focus()
                Exit Sub
            End If
            If Me.txtTENNHOM.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Tên Của Nhóm Hàng.", "Xin Chào", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTENNHOM.Focus()
                Exit Sub
            End If
            Dim mySqlCommand As New SqlCommand("Insert into tblNHOMMH(MANHOM,TENNHOM) Values(N'" & UCase(Me.txtMANHOM.Text) & "',N'" & Me.txtTENNHOM.Text & "')", mySQLConnection)

            Try
                mySQLConnection.Open()
                mySqlCommand.ExecuteNonQuery()
            Catch
                MessageBox.Show("Bản Ghi Này Không Thể Ghi Lại, Hãy Thử Lại", "Xin Chào", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Finally

                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try
            Me.txtMANHOM.Text = ""
            Me.txtTENNHOM.Text = ""
            Me.txtMANHOM.Focus()
            Me.lblPos.Text = "Bản ghi thứ 1/1"
        Else
            If Me.txtMANHOM.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Mã Của Nhóm Hàng.", "Xin Chào ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMANHOM.Focus()
                Exit Sub
                'Else
                'If checkcode("tblNHOMMH", "MANHOM", Me.txtMANHOM.Text) = False Then
                'MessageBox.Show("Mã Nhóm Mặt Hàng Bạn Nhập Vào Đã Tồn Tại. Bạn Hãy Sửa Lại !. ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.txtMANHOM.Focus()
                'Exit Sub
                'End If
            End If
            Dim mysqlcmd As New SqlCommand("update tblNHOMMH set MANHOM=N'" & UCase(Me.txtMANHOM.Text) & "',TENNHOM=N'" & Me.txtTENNHOM.Text & "' where MANHOM='" & xMA & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                mysqlcmd.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không Thể Cập Nhật Được Bản Ghi Có Mã Nước Là : " & xMA & " Bạn Hãy Thử Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                If mySQLConnection.State = ConnectionState.Open Then
                    mySQLConnection.Close()
                End If
            End Try
            'xMA = ""
            Me.txtMANHOM.Text = ""
            Me.txtTENNHOM.Text = ""
            Me.txtMANHOM.Text = Tao_MA("tblNHOMMH", "NHOM", 4)
            xReSave = False
            Me.cmdBack.Focus()
        End If
        Me.lblPos.Text = "Bản ghi thứ 1/1"
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim no = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá " & no & " Không ?", "Xin Chào", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            'Call delItem(no)
            Call delItem2("tblNHOMMH", "MANHOM", no, "Nhóm Mặt Hàng")
            GetData()
            Me.txtTENNHOM.Enabled = True
            Me.txtTENNHOM.Text = ""

            Me.txtMANHOM.Enabled = False
            Me.txtMANHOM.Text = Tao_MA("tblNHOMMH", "NHOM", 4)

            xReSave = False
            iRsCount = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
            lblPos.Text = "Bản ghi thứ 1" & "/" & iRsCount
            Me.txtTENNHOM.Focus()
        End If

    End Sub

    Private Sub cmdNew1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew1.Click
        Me.anh1.Visible = False
        Me.anh2.Visible = True
        Me.txtMANHOM.Text = ""
        Me.txtMANHOM.Text = Tao_MA("tblNHOMMH", "NHOM", 4)
        Me.txtMANHOM.Enabled = False
        Me.txtTENNHOM.Text = ""

        Me.txtTENNHOM.Enabled = True
        Me.lblPos.Text = "Thêm Mới Bản Ghi"
        xReSave = False
        Me.txtTENNHOM.Focus()
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        Me.txtMANHOM.Text = ""
        Me.txtMANHOM.Text = Tao_MA("tblNHOMMH", "NHOM", 4)
        Me.txtMANHOM.Enabled = False
        Me.txtTENNHOM.Text = ""
        Me.txtTENNHOM.Focus()
        xReSave = False
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Me.Grb2.Visible = True
        Me.Grb1.Visible = False
        GetData()

    End Sub

    'nut sua click
    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        xMA = ""
        xMA = dgView.Item(dgView.CurrentCell.RowNumber, 0)

        If MessageBox.Show("Bạn Có Thật Sự Muốn Sửa Nhóm Mặt Hàng Có Mã: " & xMA & " Hay Không ?.", "Xin Chào !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Me.txtMANHOM.Text = ""
            Me.txtMANHOM.Text = Tao_MA("tblNHOMMH", "NHOM", 4)
            Me.txtMANHOM.Enabled = False
            Me.txtTENNHOM.Text = ""
            Me.txtMANHOM.Text = dgView.Item(dgView.CurrentCell.RowNumber, 0)
            Me.txtTENNHOM.Text = dgView.Item(dgView.CurrentCell.RowNumber, 1)
            Me.txtTENNHOM.Enabled = True
            Me.txtTENNHOM.Focus()
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
            "Select MANHOM as [Mã Nhóm],TENNHOM as [Tên Nhóm] from tblNHOMMH", sqlConn)

        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder

        sqlCmdBuilder = _
            New SqlClient.SqlCommandBuilder(sqlDataAdapter2)
        Me.dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "tblNHOMMH")
        With dgView
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "tblNHOMMH")
        End With
    End Sub
    Private Sub frmNHOMMH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
        iRsCount = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
        Me.anh1.Visible = True
        Me.anh2.Visible = False
        Me.txtMANHOM.Text = Tao_MA("tblNHOMMH", "NHOM", 4)
        Me.txtMANHOM.Enabled = False
        Me.txtTENNHOM.Focus()

        If power = "BAN" Then
            Me.cmdNew1.Enabled = False
            Me.cmdUpdate.Enabled = False
            Me.cmdDelete.Enabled = False
        End If
        If iRsCount <= 1 Then
            Me.btnback.Enabled = False
            Me.btnNext.Enabled = False
            Me.btnDau.Enabled = False
            Me.btnCuoi.Enabled = False
            Me.txtTENNHOM.Enabled = True
            Exit Sub

        End If
        Dim Count1 = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
        lblPos.Text = "Bản ghi thứ " & 1 & "/" & Count1
        Me.btnback.Enabled = False

    End Sub

    Private Sub txtMANHOM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If Me.txtMANHOM.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Vào Mã Nhóm Mặt Hàng !. ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMANHOM.Focus()
                Exit Sub
            Else
                If checkcode("tblNHOMMH", "MANHOM", Me.txtMANHOM.Text) = False Then
                    MessageBox.Show("Mã Nhóm Mặt Hàng Bạn Nhập Vào Đã Tồn Tại. Bạn Hãy Sửa Lại !. ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtMANHOM.Focus()
                    Exit Sub
                End If
            End If

            Me.txtTENNHOM.Focus()
        End If
    End Sub


    Private Sub cmdSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If xReSave = False Then
            
            If Me.txtTENNHOM.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Tên Của Nhóm Hàng.", "Xin Chào", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTENNHOM.Focus()
                Exit Sub
            End If
            Dim mySqlCommand As New SqlCommand("Insert into tblNHOMMH(MANHOM,TENNHOM) Values(N'" & UCase(Me.txtMANHOM.Text) & "',N'" & Me.txtTENNHOM.Text & "')", mySQLConnection)

            Try
                mySQLConnection.Open()
                mySqlCommand.ExecuteNonQuery()
            Catch
                MessageBox.Show("Bản Ghi Này Không Thể Ghi Lại, Hãy Thử Lại", "Xin Chào", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Finally

                If (mySQLConnection.State = ConnectionState.Open) Then
                    mySQLConnection.Close()
                End If
            End Try
            Me.txtMANHOM.Text = ""
            Me.txtTENNHOM.Text = ""
            Me.txtMANHOM.Enabled = False
            Me.txtMANHOM.Text = Tao_MA("tblNHOMMH", "NHOM", 4)
            Me.anh1.Visible = False
            Me.anh2.Visible = True
            Me.txtTENNHOM.Focus()

        Else
            If Me.txtMANHOM.Text = "" Then
                MessageBox.Show("Bạn Hãy Nhập Mã Của Nhóm Hàng.", "Xin Chào ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMANHOM.Focus()
                Exit Sub
                'Else
                'If checkcode("tblNHOMMH", "MANHOM", Me.txtMANHOM.Text) = False Then
                'MessageBox.Show("Mã Nhóm Mặt Hàng Bạn Nhập Vào Đã Tồn Tại. Bạn Hãy Sửa Lại !. ", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Me.txtMANHOM.Focus()
                'Exit Sub
                'End If
            End If
            Dim mysqlcmd As New SqlCommand("update tblNHOMMH set MANHOM=N'" & UCase(Me.txtMANHOM.Text) & "',TENNHOM=N'" & Me.txtTENNHOM.Text & "' where MANHOM='" & Me.txtMANHOM.Text & "'", mySQLConnection)
            Try
                mySQLConnection.Open()
                mysqlcmd.ExecuteNonQuery()
            Catch
                MessageBox.Show("Không Thể Cập Nhật Được Bản Ghi Có Mã Nước Là : " & xMA & " Bạn Hãy Thử Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Finally
                If mySQLConnection.State = ConnectionState.Open Then
                    mySQLConnection.Close()
                End If
            End Try
            'xMA = ""
            Me.txtMANHOM.Text = ""
            Me.txtTENNHOM.Text = ""
            Me.txtMANHOM.Text = Tao_MA("tblNHOMMH", "NHOM", 4)
            xReSave = False
            Me.cmdBack.Focus()
        End If
        GetData()
        Me.anh1.Visible = True
        Me.anh2.Visible = False
        iRsCount = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
        lblPos.Text = "Bản ghi thứ 1" & "/" & iRsCount

    End Sub

    Private Sub txtTENNHOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTENNHOM.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.cmdSave.Focus()
        End If
    End Sub

    Private Sub updateLabel()
        iRsCount = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
        icurrPos = Me.BindingContext(dsDataSet, "tblNHOMMH").Position + 1
        If iRsCount <= 1 Then
            lblPos.Text = "Không tồn tại bản ghi "
        Else
            lblPos.Text = "Bản ghi thứ " & icurrPos & "/" & iRsCount
        End If
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        icurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
        If iRsCount < 1 Then
            lblPos.Text = "Không tồn tại bản ghi "
        Else
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            Me.dgView.CurrentRowIndex = icurrPos - 1
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            icurrPos = Me.dgView.CurrentRowIndex
            lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRsCount
            Me.txtMANHOM.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
            Me.txtTENNHOM.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
            xReSave = True
            Me.txtTENNHOM.Enabled = False
        End If
        If icurrPos < 1 Then
            Me.btnback.Enabled = False
        End If
        If icurrPos < iRsCount Then
            Me.btnNext.Enabled = True
        End If
    End Sub


    Private Sub dgView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgView.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        iRsCount = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
        icurrPos = Me.dgView.CurrentRowIndex

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
        Me.txtTENNHOM.Enabled = False
        Me.txtMANHOM.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
        Me.txtTENNHOM.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
        xReSave = True
    End Sub

    Private Sub dgView_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgView.CurrentCellChanged
        'iRsCount = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
        'icurrPos = Me.dgView.CurrentRowIndex
        'If icurrPos <= iRsCount - 1 Then
        'Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        'Me.dgView.Select(Me.dgView.CurrentRowIndex + 1)
        'lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRsCount
        'End If
        
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        icurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
        If icurrPos = iRsCount Then
            Me.btnNext.Enabled = False
        Else
            Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
            icurrPos += 1
            Me.dgView.CurrentRowIndex = icurrPos
            Me.dgView.Select(Me.dgView.CurrentRowIndex)
            lblPos.Text = "Bản ghi thứ " & icurrPos + 1 & "/" & iRsCount
            Me.txtTENNHOM.Enabled = False
            Me.txtMANHOM.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
            Me.txtTENNHOM.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
            xReSave = True
        End If
        If icurrPos >= 1 Then
            Me.btnback.Enabled = True
        End If
        If icurrPos = iRsCount - 1 Then
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
        iRsCount = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
        lblPos.Text = "Bản ghi thứ " & 1 & "/" & iRsCount
        Me.btnback.Enabled = False
        Me.btnNext.Enabled = True
        Me.txtTENNHOM.Enabled = False
        Me.txtMANHOM.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
        Me.txtTENNHOM.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
        xReSave = True
    End Sub

    Private Sub btnCuoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuoi.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        iRsCount = Me.BindingContext(dsDataSet, "tblNHOMMH").Count
        Me.dgView.UnSelect(Me.dgView.CurrentRowIndex)
        Me.dgView.CurrentRowIndex = iRsCount - 1
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
        lblPos.Text = "Bản ghi thứ " & iRsCount & "/" & iRsCount
        Me.btnback.Enabled = True
        Me.btnNext.Enabled = False
        Me.txtTENNHOM.Enabled = False
        Me.txtMANHOM.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 0)
        Me.txtTENNHOM.Text = Me.dgView.Item(Me.dgView.CurrentRowIndex, 1)
        xReSave = True
    End Sub

    
End Class


