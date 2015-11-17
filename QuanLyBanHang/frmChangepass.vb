Imports System.Data
Imports System.Data.SqlClient

Public Class frmChangepass
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDoi As System.Windows.Forms.Button
    Friend WithEvents txtNewuser As System.Windows.Forms.TextBox
    Friend WithEvents txtNewpass As System.Windows.Forms.TextBox
    Friend WithEvents txtRenewpass As System.Windows.Forms.TextBox
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents txtOldpass As System.Windows.Forms.TextBox
    Friend WithEvents txtOlduser As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangepass))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRenewpass = New System.Windows.Forms.TextBox()
        Me.txtNewpass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNewuser = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDoi = New System.Windows.Forms.Button()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtOldpass = New System.Windows.Forms.TextBox()
        Me.txtOlduser = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(190, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Thay Đổi Mật Khẩu"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOldpass)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtOlduser)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 126)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mật Khẩu Cũ"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mật Khẩu"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Người Sử Dụng"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtRenewpass)
        Me.GroupBox2.Controls.Add(Me.txtNewpass)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNewuser)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(31, 204)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(521, 161)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mật Khẩu Mới"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 27)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Đánh Lại Mật Khẩu"
        '
        'txtRenewpass
        '
        Me.txtRenewpass.Location = New System.Drawing.Point(195, 126)
        Me.txtRenewpass.Name = "txtRenewpass"
        Me.txtRenewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRenewpass.Size = New System.Drawing.Size(308, 30)
        Me.txtRenewpass.TabIndex = 4
        '
        'txtNewpass
        '
        Me.txtNewpass.Location = New System.Drawing.Point(196, 83)
        Me.txtNewpass.Name = "txtNewpass"
        Me.txtNewpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewpass.Size = New System.Drawing.Size(307, 30)
        Me.txtNewpass.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(25, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 27)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Mật Khẩu"
        '
        'txtNewuser
        '
        Me.txtNewuser.Location = New System.Drawing.Point(196, 38)
        Me.txtNewuser.Name = "txtNewuser"
        Me.txtNewuser.Size = New System.Drawing.Size(307, 30)
        Me.txtNewuser.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tên Người Sử Dụng"
        '
        'btnDoi
        '
        Me.btnDoi.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoi.Location = New System.Drawing.Point(150, 378)
        Me.btnDoi.Name = "btnDoi"
        Me.btnDoi.Size = New System.Drawing.Size(96, 28)
        Me.btnDoi.TabIndex = 3
        Me.btnDoi.Text = "Đổi"
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.Location = New System.Drawing.Point(340, 378)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(96, 28)
        Me.btnDong.TabIndex = 4
        Me.btnDong.Text = "Đóng"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(150, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 36)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'txtOldpass
        '
        Me.txtOldpass.Location = New System.Drawing.Point(195, 70)
        Me.txtOldpass.Name = "txtOldpass"
        Me.txtOldpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldpass.Size = New System.Drawing.Size(307, 30)
        Me.txtOldpass.TabIndex = 2
        '
        'txtOlduser
        '
        Me.txtOlduser.Location = New System.Drawing.Point(196, 29)
        Me.txtOlduser.Name = "txtOlduser"
        Me.txtOlduser.Size = New System.Drawing.Size(307, 30)
        Me.txtOlduser.TabIndex = 0
        '
        'frmChangepass
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(584, 424)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnDoi)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmChangepass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Thay Đổi Mật Khẩu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub blank()
        Me.txtNewpass.Text = ""
        Me.txtNewuser.Text = ""
        Me.txtOldpass.Text = ""
        Me.txtOlduser.Text = ""
        Me.txtRenewpass.Text = ""

    End Sub
    'ham kiem tra xem username va password cu co ton tai hay khong neu co thi cho phep doi
    Function checkpass() As Boolean
        Dim xuser1, xpass1 As String
        xuser1 = ""
        xpass1 = ""
        Dim string2 = strconn
        Dim sqlconn As SqlConnection = New SqlConnection(string2)
        Dim strsql As String = "select * from tblPassword where username='" & Encript(Me.txtOlduser.Text, 1994) & "' and password='" & Encript(Me.txtOldpass.Text, 1994) & "'"
        Dim sqlcmd As SqlCommand = New SqlCommand(strsql, sqlconn)
        sqlconn.Open()
        Dim sqlreader As SqlDataReader = sqlcmd.ExecuteReader()
        Do While sqlreader.Read()
            xuser1 = sqlreader.GetString(0)
            xpass1 = sqlreader.GetString(1)
        Loop
        sqlreader.Close()
        sqlconn.Close()
        If (xuser1 = "") Or (xpass1 = "") Then
            checkpass = False
            Exit Function
        End If
        checkpass = True
    End Function

    Private Sub txtOlduser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOlduser.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtOldpass.Focus()
        End If
    End Sub

    Private Sub txtOldpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOldpass.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtNewuser.Focus()
        End If
    End Sub

    Private Sub txtNewuser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewuser.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtNewpass.Focus()
        End If
    End Sub

    Private Sub txtNewpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewpass.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.txtRenewpass.Focus()
        End If
    End Sub

    Private Sub txtRenewpass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRenewpass.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnDoi.Focus()
        End If
    End Sub

    Private Sub btnDoi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btnDoi.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.btnDong.Focus()
        End If
    End Sub

    Private Sub frmChangepass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        blank()
        Me.txtOlduser.Focus()
    End Sub

    Private Function checkpass(ByVal pass As String, ByVal repass As String) As Boolean
        Dim xpass As String = Trim(UCase(pass))
        Dim xrepass As String = Trim(UCase(repass))
        If xpass = xrepass Then
            checkpass = True
        Else
            checkpass = False
        End If
    End Function

    Private Sub updatepass()
        If checkpass() = False Then
            MsgBox("Không Tồn Tại Tài Khoản Người Dùng Này. Hãy Thử Lại !", MsgBoxStyle.Information, "Thông Báo !")
            Me.txtOlduser.Focus()
            Exit Sub
        End If
        Dim xuser As String = ""
        Dim xpass As String = ""
        xuser = Encript(Trim(Me.txtNewuser.Text), 1994)
        xpass = Encript(Trim(Me.txtNewpass.Text), 1994)

        Dim ok As Boolean = True
        Dim myconn As New SqlConnection(strconn)
        Dim strupdate = "update tblpassword set username='" & xuser & "',password='" & xpass & "' where username='" & Encript(Trim(Me.txtOlduser.Text), 1994) & "' and password='" & Encript(Trim(Me.txtOldpass.Text), 1994) & "'"

        Dim mysqlcmd As New SqlCommand(strupdate, myconn)
        Try
            myconn.Open()
            mysqlcmd.ExecuteNonQuery()
        Catch
            MessageBox.Show("Không Thể Đổi Được Mật Khẩu Mới.Bạn Hãy Thử Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ok = False
        Finally
            If (myconn.State = ConnectionState.Open) Then
                myconn.Close()
            End If
        End Try
        If ok = True Then
            MessageBox.Show("Bạn Đã Thay Đổi Mật Khẩu Thành Công !.", "Chào Bạn !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            blank()
        End If
    End Sub

    Private Sub btnDoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoi.Click
        If Me.txtOlduser.Text = "" Then
            If MessageBox.Show("Bạn Hãy Nhập Tên Người Dùng Cũ .", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information) = MsgBoxResult.Ok Then
                Me.txtOlduser.Focus()
                Exit Sub
            End If
        End If
        If Me.txtOldpass.Text = "" Then
            MessageBox.Show("Bạn Hãy Nhập Mật Khẩu Cũ .", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtOldpass.Focus()
            Exit Sub
        End If
        If Me.txtNewuser.Text = "" Then
            MessageBox.Show("Bạn Hãy Nhập Tên Người Dùng Mới.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtNewuser.Focus()
            Exit Sub
        End If
        If Me.txtNewpass.Text = "" Then
            MessageBox.Show("Bạn Hãy Nhập Mật Khẩu Mới .", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtNewpass.Focus()
            Exit Sub
        End If
        If Me.txtRenewpass.Text = "" Then
            MessageBox.Show("Bạn Hãy Nhập Thông Tin Vào Ô Đánh Lại Mật Khẩu Mới .", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtRenewpass.Focus()
            Exit Sub
        End If
        If checkpass(Me.txtNewpass.Text, Me.txtRenewpass.Text) = True Then
            'MsgBox("Bạn Nhập Đúng Password Mới.", , "Xin Chào !")
            Call updatepass()
        Else
            MessageBox.Show("Bạn Nhập Mật Khẩu Lần 1 Và Lần 2 Không Trùng Nhau Hãy Sửa Lại.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtRenewpass.Focus()
        End If
    End Sub

    Private Sub btnDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDong.Click
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtOldpass_TextChanged(sender As Object, e As EventArgs) Handles txtOldpass.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
