Imports System.Data
Imports System.Data.SqlClient

Public Class frmLogin
    Inherits System.Windows.Forms.Form


    Dim sqlconn As SqlConnection = New SqlConnection(strconn)
    
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btnThoat As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Rfull As System.Windows.Forms.RadioButton
    Friend WithEvents Rnhap As System.Windows.Forms.RadioButton
    Friend WithEvents Rban As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnThoat = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Rfull = New System.Windows.Forms.RadioButton()
        Me.Rnhap = New System.Windows.Forms.RadioButton()
        Me.Rban = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(88, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Đăng Nhập Hệ Thống"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Người Sử Dụng"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(144, 55)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(200, 22)
        Me.txtUser.TabIndex = 6
        Me.txtUser.Text = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mật Khẩu"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(144, 88)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(200, 22)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Text = ""
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(88, 208)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(88, 24)
        Me.btnlogin.TabIndex = 11
        Me.btnlogin.Text = "Đăng Nhập"
        '
        'btnThoat
        '
        Me.btnThoat.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThoat.Location = New System.Drawing.Point(200, 209)
        Me.btnThoat.Name = "btnThoat"
        Me.btnThoat.Size = New System.Drawing.Size(80, 24)
        Me.btnThoat.TabIndex = 12
        Me.btnThoat.Text = "Thoát"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3
        '
        'Rfull
        '
        Me.Rfull.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rfull.Location = New System.Drawing.Point(144, 168)
        Me.Rfull.Name = "Rfull"
        Me.Rfull.TabIndex = 10
        Me.Rfull.Text = "Toàn Quyền"
        '
        'Rnhap
        '
        Me.Rnhap.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnhap.Location = New System.Drawing.Point(144, 120)
        Me.Rnhap.Name = "Rnhap"
        Me.Rnhap.Size = New System.Drawing.Size(208, 24)
        Me.Rnhap.TabIndex = 8
        Me.Rnhap.Text = "Nhân Viên Nhập Chứng Từ"
        '
        'Rban
        '
        Me.Rban.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rban.Location = New System.Drawing.Point(144, 144)
        Me.Rban.Name = "Rban"
        Me.Rban.Size = New System.Drawing.Size(176, 24)
        Me.Rban.TabIndex = 9
        Me.Rban.Text = "Nhân Viên Bán Hàng"
        '
        'frmLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(360, 257)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Rban, Me.Rnhap, Me.Rfull, Me.btnThoat, Me.btnlogin, Me.txtPassword, Me.Label3, Me.txtUser, Me.Label2, Me.Label1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập Hệ Thống"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        End
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If Me.txtUser.Text = "" Then
            MessageBox.Show("Bạn Hãy Nhập Tên Người Dùng.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Me.txtUser.Focus()
            Exit Sub
        End If
        If Me.txtPassword.Text = "" Then
            MessageBox.Show("Bạn Hãy Nhập Mật Khẩu.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtPassword.Focus()
            Exit Sub
        End If

        If Me.Rnhap.Checked = True Then
            power = "NHAP"
        End If
        If Me.Rban.Checked = True Then
            power = "BAN"
        End If
        If Me.Rfull.Checked = True Then
            power = "FULL"
        End If
        Dim str1 As String
        str1 = "select * from tblpassword where username='" & Encript(Me.txtUser.Text, 1981) & "' and power='" & power & "'"
        Dim cmdsqlcommand As SqlCommand = New SqlCommand(str1, sqlconn)
        Dim struser As String
        Dim strpassword As String
        sqlconn.Open()
        Dim drsqlreader As SqlDataReade
        r = cmdsqlcommand.ExecuteReader
        Do While drsqlreader.Read()
            struser = drsqlreader.GetString(0)
            strpassword = drsqlreader.GetString(1)
        Loop
        drsqlreader.Close()
        sqlconn.Close()
        If struser = "" Then
            MessageBox.Show("Không Tồn Tại Người Dùng Trong Bảng Hãy Thử Lại!", "Xin Chào!", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            txtUser.Focus()
        ElseIf strpassword <> Encript(Me.txtPassword.Text, 1981) Then
            MessageBox.Show("Mật Khẩu Không Hợp Lệ , Hãy Thử Lại!", "Xin Chào!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Focus()
        Else
            xLogin = True
            Me.Hide()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtUser.Focus()
    End Sub

    Private Sub txtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.Rnhap.Focus()
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Enabled = True
    End Sub

    Private Sub Rnhap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Rnhap.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnlogin.Focus()
        End If
        If e.KeyChar = Chr(40) Then
            Me.Rban.Focus()
        End If
    End Sub

    Private Sub Rban_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Rban.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnlogin.Focus()
        End If
        If e.KeyChar = Chr(40) Then
            Me.Rfull.Focus()
        End If
    End Sub

    Private Sub Rfull_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Rfull.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnlogin.Focus()
        End If
        If e.KeyChar = Chr(40) Then
            Me.btnlogin.Focus()
        End If
        If e.KeyChar = Chr(38) Then
            Me.btnlogin.Focus()
        End If
    End Sub


End Class
