Imports System.Data
Imports System.Data.SqlClient
Public Class frmNCC
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
    Friend WithEvents txtTENNCC As System.Windows.Forms.TextBox
    Friend WithEvents txtMANCC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDIACHI As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTEL As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFAX As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnDong As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNCC))
        Me.Grb1 = New System.Windows.Forms.GroupBox()
        Me.Grb2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgView = New System.Windows.Forms.DataGrid()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdNew1 = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtFAX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTEL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDIACHI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTENNCC = New System.Windows.Forms.TextBox()
        Me.txtMANCC = New System.Windows.Forms.TextBox()
        Me.lbName = New System.Windows.Forms.Label()
        Me.lbID = New System.Windows.Forms.Label()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdNew = New System.Windows.Forms.Button()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.Grb1.SuspendLayout()
        Me.Grb2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Grb1
        '
        Me.Grb1.Controls.Add(Me.Grb2)
        Me.Grb1.Controls.Add(Me.btnDong)
        Me.Grb1.Controls.Add(Me.PictureBox4)
        Me.Grb1.Controls.Add(Me.PictureBox2)
        Me.Grb1.Controls.Add(Me.txtFAX)
        Me.Grb1.Controls.Add(Me.Label4)
        Me.Grb1.Controls.Add(Me.txtTEL)
        Me.Grb1.Controls.Add(Me.Label3)
        Me.Grb1.Controls.Add(Me.txtDIACHI)
        Me.Grb1.Controls.Add(Me.Label2)
        Me.Grb1.Controls.Add(Me.Label1)
        Me.Grb1.Controls.Add(Me.txtTENNCC)
        Me.Grb1.Controls.Add(Me.txtMANCC)
        Me.Grb1.Controls.Add(Me.lbName)
        Me.Grb1.Controls.Add(Me.lbID)
        Me.Grb1.Controls.Add(Me.cmdSave)
        Me.Grb1.Controls.Add(Me.cmdNew)
        Me.Grb1.Controls.Add(Me.cmdBack)
        Me.Grb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Grb1.Location = New System.Drawing.Point(49, 21)
        Me.Grb1.Name = "Grb1"
        Me.Grb1.Size = New System.Drawing.Size(720, 400)
        Me.Grb1.TabIndex = 4
        Me.Grb1.TabStop = False
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
        Me.Grb2.Location = New System.Drawing.Point(0, 9)
        Me.Grb2.Name = "Grb2"
        Me.Grb2.Size = New System.Drawing.Size(720, 400)
        Me.Grb2.TabIndex = 5
        Me.Grb2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(132, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 40)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(176, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(440, 32)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Danh Sách Các Nhà Cung Cấp Hàng"
        '
        'dgView
        '
        Me.dgView.AlternatingBackColor = System.Drawing.SystemColors.Info
        Me.dgView.CaptionText = "Danh Sách Các Nhà Cung Cấp Hàng "
        Me.dgView.DataMember = ""
        Me.dgView.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgView.GridLineColor = System.Drawing.Color.Maroon
        Me.dgView.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgView.Location = New System.Drawing.Point(21, 82)
        Me.dgView.Name = "dgView"
        Me.dgView.Size = New System.Drawing.Size(683, 248)
        Me.dgView.TabIndex = 14
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdate.Location = New System.Drawing.Point(258, 342)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(88, 24)
        Me.cmdUpdate.TabIndex = 13
        Me.cmdUpdate.Text = "&Sửa "
        '
        'cmdNew1
        '
        Me.cmdNew1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew1.Location = New System.Drawing.Point(131, 342)
        Me.cmdNew1.Name = "cmdNew1"
        Me.cmdNew1.Size = New System.Drawing.Size(88, 24)
        Me.cmdNew1.TabIndex = 12
        Me.cmdNew1.Text = "&Thêm"
        '
        'cmdDelete
        '
        Me.cmdDelete.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(379, 342)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(88, 24)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "&Xoá "
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Location = New System.Drawing.Point(499, 342)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(87, 24)
        Me.cmdClose.TabIndex = 11
        Me.cmdClose.Text = "&Đóng"
        '
        'btnDong
        '
        Me.btnDong.Location = New System.Drawing.Point(528, 331)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(88, 23)
        Me.btnDong.TabIndex = 21
        Me.btnDong.Text = "Đóng"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(63, 40)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(16, 24)
        Me.PictureBox4.TabIndex = 20
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(79, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 42)
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'txtFAX
        '
        Me.txtFAX.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFAX.Location = New System.Drawing.Point(204, 282)
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Size = New System.Drawing.Size(232, 23)
        Me.txtFAX.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Số FAX"
        '
        'txtTEL
        '
        Me.txtTEL.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTEL.Location = New System.Drawing.Point(204, 231)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Size = New System.Drawing.Size(232, 23)
        Me.txtTEL.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Số Điện Thoại"
        '
        'txtDIACHI
        '
        Me.txtDIACHI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDIACHI.Location = New System.Drawing.Point(204, 181)
        Me.txtDIACHI.Name = "txtDIACHI"
        Me.txtDIACHI.Size = New System.Drawing.Size(448, 23)
        Me.txtDIACHI.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Địa Chỉ"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(122, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(520, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Những Thông Tin Chính Về Nhà Cung Cấp Mới"
        '
        'txtTENNCC
        '
        Me.txtTENNCC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTENNCC.Location = New System.Drawing.Point(204, 130)
        Me.txtTENNCC.Name = "txtTENNCC"
        Me.txtTENNCC.Size = New System.Drawing.Size(448, 23)
        Me.txtTENNCC.TabIndex = 11
        '
        'txtMANCC
        '
        Me.txtMANCC.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMANCC.Location = New System.Drawing.Point(204, 80)
        Me.txtMANCC.Name = "txtMANCC"
        Me.txtMANCC.Size = New System.Drawing.Size(232, 23)
        Me.txtMANCC.TabIndex = 10
        '
        'lbName
        '
        Me.lbName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbName.Location = New System.Drawing.Point(64, 133)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(136, 16)
        Me.lbName.TabIndex = 8
        Me.lbName.Text = "Tên Nhà Cung Cấp"
        '
        'lbID
        '
        Me.lbID.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbID.Location = New System.Drawing.Point(63, 84)
        Me.lbID.Name = "lbID"
        Me.lbID.Size = New System.Drawing.Size(128, 16)
        Me.lbID.TabIndex = 7
        Me.lbID.Text = "Mã Nhà Cung Cấp"
        '
        'cmdSave
        '
        Me.cmdSave.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.Location = New System.Drawing.Point(248, 331)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(96, 24)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Lưu"
        '
        'cmdNew
        '
        Me.cmdNew.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNew.Location = New System.Drawing.Point(96, 331)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(104, 24)
        Me.cmdNew.TabIndex = 2
        Me.cmdNew.Text = "&Thêm"
        '
        'cmdBack
        '
        Me.cmdBack.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBack.Location = New System.Drawing.Point(392, 331)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(96, 24)
        Me.cmdBack.TabIndex = 8
        Me.cmdBack.Text = "&Quay Lại"
        '
        'frmNCC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 16)
        Me.ClientSize = New System.Drawing.Size(915, 504)
        Me.Controls.Add(Me.Grb1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmNCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Danh Sách Các Nhà Cung Cấp"
        Me.Grb1.ResumeLayout(False)
        Me.Grb1.PerformLayout()
        Me.Grb2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim xMA As String
    Dim xReSave As Boolean = False
    Dim iRsCount As Integer
    Dim icurrPos As Integer
    Dim sConnString = strconn

    Dim mySQLConnection As New SqlConnection(sConnString)
    'Dim mySQLDataAdapter As New SqlDataAdapter("select * from tblNCC", mySQLConnection)
    'Dim myDataSet As DataSet = New DataSet()

    'Dim sqlCmdBuilder As SqlCommandBuilder

    Dim sqlDataAdapter2 As SqlClient.SqlDataAdapter
    Dim dsDataSet As New DataSet()

    Private Sub blank()
        Me.txtMANCC.Text = ""
        Me.txtTENNCC.Text = ""
        Me.txtDIACHI.Text = ""
        Me.txtTEL.Text = ""
        Me.txtFAX.Text = ""
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If xReSave = False Then
            If Me.txtMANCC.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Mã Của Nhà Cung Cấp.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMANCC.Focus()
                Exit Sub
            End If
            If Me.txtTENNCC.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Tên Của Nhà Cung Cấp.")
                Me.txtTENNCC.Focus()
                Exit Sub
            End If
            If Me.txtDIACHI.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Địa Chỉ Của Nhà Cung Cấp.")
                Me.txtDIACHI.Focus()
                Exit Sub
            End If
            If Me.txtTEL.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Số Điện Thoại Của Nhà Cung Cấp.")
                Me.txtTEL.Focus()
                Exit Sub
            Else
                If IsNumeric(Me.txtTEL.Text) = False Then
                    MessageBox.Show("Bạn Hãy Nhập Đúng Số Điện Thoại Của Nhà Cung Cấp.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtTEL.Focus()
                    Exit Sub
                End If
            End If
            'If Me.txtFAX.Text = "" Then
            'MessageBox.Show(" Bạn Hãy Nhập Số Fax Của Nhà Cung Cấp.")
            'Exit Sub
            'End If
            If Me.txtFAX.Text <> "" Then
                If IsNumeric(Me.txtFAX.Text) = False Then
                    MessageBox.Show("Bạn Hãy Nhập Đúng Số Fax Của Nhà Cung Cấp.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtFAX.Focus()
                    Exit Sub
                End If
            End If

            Dim mySqlCommand As New SqlCommand("Insert into tblNCC(MANCC,TENNCC,DIACHI,TEL,FAX) Values('" & UCase(Me.txtMANCC.Text) & "',N'" & Me.txtTENNCC.Text & "',N'" & Me.txtDIACHI.Text & "','" & Me.txtTEL.Text & "','" & Me.txtFAX.Text & "')", mySQLConnection)
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

            Me.txtMANCC.Enabled = False
            Me.txtMANCC.Text = ""
            Me.txtMANCC.Text = Tao_MA("tblNCC", "NCC", 3)
            Me.txtTENNCC.Focus()
        Else
            If Me.txtTEL.Text <> "" Then
                If IsNumeric(Me.txtTEL.Text) = False Then
                    MessageBox.Show("Số Điện Thoại Bạn Nhập Vào Không Hợp Lệ . Hãy Nhập Lại.", "Chào Bạn !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtTEL.Focus()
                    Exit Sub
                End If
            End If
            If Me.txtFAX.Text <> "" Then
                If IsNumeric(Me.txtFAX.Text) = False Then
                    MessageBox.Show("Số FAX Bạn Nhập Vào Không Hợp Lệ . Hãy Nhập Lại.", "Chào Bạn !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtFAX.Focus()
                    Exit Sub
                End If
            End If

            If MessageBox.Show("Bạn Có Thật Sự Muốn Ghi Lại Những Thay Đổi Vừa Rồi Hay Không ?.", "Chào Bạn !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim mysqlcmd As New SqlCommand("update tblNCC set MANCC='" & UCase(Me.txtMANCC.Text) & "',TENNCC=N'" & Me.txtTENNCC.Text & "',DIACHI=N'" & Me.txtDIACHI.Text & "',TEL='" & Me.txtTEL.Text & "',FAX='" & Me.txtFAX.Text & "' where MANCC='" & xMA & "'", mySQLConnection)
                Try
                    mySQLConnection.Open()
                    mysqlcmd.ExecuteNonQuery()
                Catch
                    MessageBox.Show("Không Thể Cập Nhật Được Bản Ghi Này.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Finally
                    If mySQLConnection.State = ConnectionState.Open Then
                        mySQLConnection.Close()
                    End If
                End Try
            End If
            blank()
            Me.cmdBack.Focus()
            xReSave = False
        End If
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim No = dgView.Item(dgView.CurrentCell.RowNumber, 0)
        If MessageBox.Show("Bạn Có Thật Sự Muốn Xoá " & No & " Không ?", " Chào Bạn !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Call delItem2("tblNCC", "MANCC", No, "Nhà Cung Cấp")
        End If
        GetData()
        Me.txtMANCC.Enabled = False
        Me.txtMANCC.Text = Tao_MA("tblNCC", "NCC", 3)
        iRsCount = Me.BindingContext(dsDataSet, "tblNCC").Count
    End Sub

    Private Sub cmdNew1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew1.Click
        Me.Grb1.Visible = True
        Me.Grb2.Visible = False
        blank()
        Me.txtMANCC.Enabled = False
        Me.txtMANCC.Text = Tao_MA("tblNCC", "NCC", 3)

        Me.txtTENNCC.Focus()
        xReSave = False
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        blank()
        xReSave = False
        Me.txtMANCC.Enabled = False
        Me.txtMANCC.Text = Tao_MA("tblNCC", "NCC", 3)

        Me.txtTENNCC.Focus()
    End Sub

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        Me.Grb2.Visible = True
        Me.Grb1.Visible = False
        GetData()
        iRsCount = Me.BindingContext(dsDataSet, "tblNCC").Count
    End Sub


    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If Me.dgView.VisibleRowCount < 2 Then
            MessageBox.Show("Lưới dữ liệu trống. Bạn không thể thực hiện chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        xMA = ""
        xMA = dgView.Item(dgView.CurrentCell.RowNumber, 0)

        If MessageBox.Show("Bạn Có Thật Sự Muốn Sửa Lại Những Thông Tin Của Nhà Cung Cấp : " & xMA & " Hay Không ?", "Chào Bạn !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Grb1.Visible = True
            Me.Grb2.Visible = False
            blank()
            Me.txtMANCC.Text = dgView.Item(dgView.CurrentCell.RowNumber, 0)
            Me.txtTENNCC.Text = dgView.Item(dgView.CurrentCell.RowNumber, 1)
            Me.txtDIACHI.Text = dgView.Item(dgView.CurrentCell.RowNumber, 2)
            Me.txtTEL.Text = dgView.Item(dgView.CurrentCell.RowNumber, 3)
            Me.txtFAX.Text = dgView.Item(dgView.CurrentCell.RowNumber, 4)
            xReSave = True
            Me.txtMANCC.Enabled = False

        End If

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Hide()
    End Sub

    Private Sub GetData()
        Dim sqlConn As New SqlClient.SqlConnection(sConnString)
        sqlDataAdapter2 = _
            New SqlClient.SqlDataAdapter("Select MANCC as [Mã Nhà Cung Cấp],TENNCC as [Tên Nhà Cung Cấp],DIACHI as [Địa Chỉ],TEL as [Số Điện Thoại],FAX as [Số FAX] from tblNCC", sqlConn)

        Dim sqlCmdBuilder As SqlClient.SqlCommandBuilder

        sqlCmdBuilder = New SqlClient.SqlCommandBuilder(sqlDataAdapter2)
        Me.dsDataSet.Clear()
        sqlDataAdapter2.Fill(dsDataSet, "tblNCC")

        With dgView
            .AllowSorting = True
            .AlternatingBackColor = System.Drawing.Color.Bisque
            .SetDataBinding(dsDataSet, "tblNCC")
        End With
    End Sub

    Private Sub txtMANCC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMANCC.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtMANCC.Text = "" Then
                MessageBox.Show(" Bạn Hãy Nhập Mã Của Nhà Cung Cấp.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMANCC.Focus()
                Exit Sub
            Else
                If checkcode("tblNCC", "MANCC", Me.txtMANCC.Text) = False Then
                    MessageBox.Show("Mã Nhà Cung Cấp Bạn Nhập Đã Tồn Tại. Hãy Sửa Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtMANCC.Focus()
                    Exit Sub
                End If
            End If
            Me.txtTENNCC.Focus()
        End If
    End Sub

    Private Sub txtTENNCC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTENNCC.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtDIACHI.Focus()
        End If
    End Sub

    Private Sub txtDIACHI_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDIACHI.KeyPress
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

    Private Sub cmdSave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmdSave.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtMANCC.Focus()
        End If
    End Sub

    Private Sub frmNCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetData()
        If power = "BAN" Then
            Me.cmdNew1.Enabled = False
            Me.cmdUpdate.Enabled = False
            Me.cmdDelete.Enabled = False
        End If

        iRsCount = Me.BindingContext(dsDataSet, "tblNCC").Count
    End Sub

    Private Sub dgView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgView.Click
        icurrPos = Me.dgView.CurrentRowIndex
        iRsCount = Me.BindingContext(dsDataSet, "tblNCC").Count
        Me.dgView.Select(Me.dgView.CurrentRowIndex)
    End Sub

    Private Sub btnDong_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDong.Click
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class


