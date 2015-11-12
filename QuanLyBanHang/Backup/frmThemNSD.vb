Imports System.Data
Imports System.Data.SqlClient
Public Class frmThemNSD
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Rfull As System.Windows.Forms.RadioButton
    Friend WithEvents Rban As System.Windows.Forms.RadioButton
    Friend WithEvents Rnhap As System.Windows.Forms.RadioButton
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmThemNSD))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Rfull = New System.Windows.Forms.RadioButton()
        Me.Rban = New System.Windows.Forms.RadioButton()
        Me.Rnhap = New System.Windows.Forms.RadioButton()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnGhi = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập Tài Khoản Cho Người Dùng Mới"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mật Khẩu"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(200, 96)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(216, 23)
        Me.txtUser.TabIndex = 3
        Me.txtUser.Text = ""
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(200, 136)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(216, 23)
        Me.txtPass.TabIndex = 4
        Me.txtPass.Text = ""
        '
        'Rfull
        '
        Me.Rfull.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rfull.Location = New System.Drawing.Point(200, 236)
        Me.Rfull.Name = "Rfull"
        Me.Rfull.Size = New System.Drawing.Size(152, 24)
        Me.Rfull.TabIndex = 7
        Me.Rfull.Text = "Toàn Quyền"
        '
        'Rban
        '
        Me.Rban.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rban.Location = New System.Drawing.Point(200, 204)
        Me.Rban.Name = "Rban"
        Me.Rban.Size = New System.Drawing.Size(192, 24)
        Me.Rban.TabIndex = 6
        Me.Rban.Text = "Nhân Viên Bán Hàng"
        '
        'Rnhap
        '
        Me.Rnhap.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnhap.Location = New System.Drawing.Point(200, 172)
        Me.Rnhap.Name = "Rnhap"
        Me.Rnhap.Size = New System.Drawing.Size(208, 24)
        Me.Rnhap.TabIndex = 5
        Me.Rnhap.Text = "Nhân Viên Nhập Chứng Từ"
        '
        'btnthem
        '
        Me.btnthem.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthem.ImageList = Me.ImageList1
        Me.btnthem.Location = New System.Drawing.Point(98, 280)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(88, 32)
        Me.btnthem.TabIndex = 9
        Me.btnthem.Text = "Thêm"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnGhi
        '
        Me.btnGhi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGhi.ImageList = Me.ImageList1
        Me.btnGhi.Location = New System.Drawing.Point(226, 280)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(88, 32)
        Me.btnGhi.TabIndex = 8
        Me.btnGhi.Text = "Ghi Lại"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 50)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Người Dùng"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(352, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 32)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Đóng"
        '
        'frmThemNSD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(544, 345)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Button1, Me.PictureBox1, Me.btnGhi, Me.btnthem, Me.Rban, Me.Rfull, Me.Rnhap, Me.txtPass, Me.txtUser, Me.Label3, Me.Label2, Me.Label1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmThemNSD"
        Me.Text = "Thêm Người Sử Dụng Mới"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub blank()
        Me.txtUser.Text = ""
        Me.txtPass.Text = ""
        Me.Rban.Checked = False
        Me.Rnhap.Checked = False
        Me.Rfull.Checked = False
    End Sub
    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        blank()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub btnGhi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGhi.Click
        If Me.txtUser.Text = "" Then
            MsgBox("Bạn hãy nhập tên của người dùng !", MsgBoxStyle.Information, "Chào Bạn !")
            Me.txtUser.Focus()
            Exit Sub
        End If
        If Me.txtPass.Text = "" Then
            MsgBox("Bạn hãy nhập mật khẩu của người dùng !", MsgBoxStyle.Information, "Chào Bạn !")
            Me.txtPass.Focus()
            Exit Sub
        End If
        If Me.Rban.Checked = False AndAlso Me.Rnhap.Checked = False AndAlso Me.Rfull.Checked = False Then
            MsgBox("Bạn hãy chọn một kiểu truy cập cho người dùng mới !", MsgBoxStyle.Information, "Chào Bạn !")
            Exit Sub
        End If
        Dim pow As String = ""
        If Me.Rban.Checked = True Then
            pow = "BAN"
        End If
        If Me.Rnhap.Checked = True Then
            pow = "NHAP"
        End If
        If Me.Rfull.Checked = True Then
            pow = "FULL"
        End If

        Dim sql, str As String
        sql = "insert into tblPassword(username,password,power) values('" & Encript(Me.txtUser.Text, 1981) & "','" & Encript(Me.txtPass.Text, 1981) & "','" & pow & "')"
        str = strconn
        Dim conn As New SqlConnection(str)
        Dim sqlcmd As New SqlCommand(sql, conn)
        Try
            conn.Open()
            sqlcmd.ExecuteNonQuery()
        Catch

            MsgBox("Không thể thêm được người dùng mới . Bạn hãy thử lại !", MsgBoxStyle.Information, "Chào Bạn !")
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        blank()
        Me.txtUser.Focus()
    End Sub

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtUser.Text = "" Then
                MsgBox("Bạn hãy nhập tên của người dùng mới !", MsgBoxStyle.Information, "Chào Bạn !")
                Me.txtUser.Focus()
                Exit Sub
            Else
                Me.txtPass.Focus()
            End If
        End If
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = Chr(13) Then
            If Me.txtUser.Text = "" Then
                MsgBox("Bạn hãy nhập mật khẩu của người dùng mới !", MsgBoxStyle.Information, "Chào Bạn !")
                Me.txtPass.Focus()
                Exit Sub
            Else
                Me.Rnhap.Focus()
            End If
        End If
    End Sub

    Private Sub Rnhap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Rnhap.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnGhi.Focus()
        End If
    End Sub

    Private Sub Rban_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Rban.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnGhi.Focus()
        End If
    End Sub

    Private Sub Rfull_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Rfull.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnGhi.Focus()
        End If
    End Sub

    Private Sub btnGhi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnGhi.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtUser.Focus()
        End If
    End Sub

    Private Sub frmThemNSD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtUser.Focus()
    End Sub
End Class
