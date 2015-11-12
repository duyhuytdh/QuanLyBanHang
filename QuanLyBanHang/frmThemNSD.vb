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
    Friend WithEvents btnGhi As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmThemNSD))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnGhi = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(106, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(508, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nhập Tài Khoản Cho Người Dùng Mới"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Mật Khẩu"
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.Location = New System.Drawing.Point(240, 111)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(259, 27)
        Me.txtUser.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(240, 157)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(259, 27)
        Me.txtPass.TabIndex = 4
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        '
        'btnGhi
        '
        Me.btnGhi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGhi.ImageList = Me.ImageList1
        Me.btnGhi.Location = New System.Drawing.Point(240, 209)
        Me.btnGhi.Name = "btnGhi"
        Me.btnGhi.Size = New System.Drawing.Size(115, 37)
        Me.btnGhi.TabIndex = 8
        Me.btnGhi.Text = "Lưu lại"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(38, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 58)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Người Dùng"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageList = Me.ImageList1
        Me.Button1.Location = New System.Drawing.Point(383, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 37)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Đóng"
        '
        'frmThemNSD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(652, 273)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnGhi)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmThemNSD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm Người Sử Dụng Mới"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub blank()
        Me.txtUser.Text = ""
        Me.txtPass.Text = ""
    End Sub
    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        Dim sql, str As String
        sql = "insert into tblPassword(username,password) values('" & Encript(Me.txtUser.Text, 1994) & "','" & Encript(Me.txtPass.Text, 1994) & "')"
        str = strconn
        Dim conn As New SqlConnection(str)
        Dim sqlcmd As New SqlCommand(sql, conn)
        Try
            conn.Open()
            sqlcmd.ExecuteNonQuery()
            MsgBox("Bạn đã thêm tài khoản thành công !", MsgBoxStyle.Information, "Thông báo !")
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
            End If
        End If
    End Sub

    Private Sub Rnhap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.btnGhi.Focus()
        End If
    End Sub

    Private Sub Rban_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Me.btnGhi.Focus()
        End If
    End Sub

    Private Sub Rfull_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
