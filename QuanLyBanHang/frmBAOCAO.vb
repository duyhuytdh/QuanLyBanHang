Imports System.Data
Imports System.Data.SqlClient

Public Class frmBAOCAO
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnDong As System.Windows.Forms.Button
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbQuater As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents lstReport As System.Windows.Forms.ListBox
    Friend WithEvents optMonth As System.Windows.Forms.RadioButton
    Friend WithEvents optQuater As System.Windows.Forms.RadioButton
    Friend WithEvents optYear As System.Windows.Forms.RadioButton
    Friend WithEvents csVIEW As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TtipBC As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBAOCAO))
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbQuater = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.optMonth = New System.Windows.Forms.RadioButton()
        Me.optQuater = New System.Windows.Forms.RadioButton()
        Me.optYear = New System.Windows.Forms.RadioButton()
        Me.lstReport = New System.Windows.Forms.ListBox()
        Me.btnDong = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.csVIEW = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TtipBC = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.Location = New System.Drawing.Point(64, 48)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(112, 21)
        Me.cmbMonth.TabIndex = 1
        '
        'cmbQuater
        '
        Me.cmbQuater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuater.Location = New System.Drawing.Point(64, 80)
        Me.cmbQuater.Name = "cmbQuater"
        Me.cmbQuater.Size = New System.Drawing.Size(112, 21)
        Me.cmbQuater.TabIndex = 2
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.Location = New System.Drawing.Point(64, 112)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(112, 21)
        Me.cmbYear.TabIndex = 3
        '
        'optMonth
        '
        Me.optMonth.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMonth.Location = New System.Drawing.Point(64, 136)
        Me.optMonth.Name = "optMonth"
        Me.optMonth.Size = New System.Drawing.Size(72, 24)
        Me.optMonth.TabIndex = 4
        Me.optMonth.Text = "Tháng"
        '
        'optQuater
        '
        Me.optQuater.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optQuater.Location = New System.Drawing.Point(64, 160)
        Me.optQuater.Name = "optQuater"
        Me.optQuater.Size = New System.Drawing.Size(56, 24)
        Me.optQuater.TabIndex = 5
        Me.optQuater.Text = "Quý"
        '
        'optYear
        '
        Me.optYear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optYear.Location = New System.Drawing.Point(64, 184)
        Me.optYear.Name = "optYear"
        Me.optYear.Size = New System.Drawing.Size(56, 24)
        Me.optYear.TabIndex = 6
        Me.optYear.Text = "Năm"
        '
        'lstReport
        '
        Me.lstReport.HorizontalScrollbar = True
        Me.lstReport.Location = New System.Drawing.Point(7, 232)
        Me.lstReport.Name = "lstReport"
        Me.lstReport.ScrollAlwaysVisible = True
        Me.lstReport.Size = New System.Drawing.Size(194, 199)
        Me.lstReport.TabIndex = 7
        Me.TtipBC.SetToolTip(Me.lstReport, "Bạn Hãy Chọn Một Mẫu Báo Cáo Trong Danh Sách Các Loại Báo Cáo")
        '
        'btnDong
        '
        Me.btnDong.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDong.Location = New System.Drawing.Point(112, 440)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.TabIndex = 8
        Me.btnDong.Text = "Đóng"
        '
        'btnOK
        '
        Me.btnOK.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Image = CType(resources.GetObject("btnOK.Image"), System.Drawing.Bitmap)
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.ImageIndex = 1
        Me.btnOK.ImageList = Me.ImageList1
        Me.btnOK.Location = New System.Drawing.Point(16, 440)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.TtipBC.SetToolTip(Me.btnOK, "Nhấn OK Sau Khi Chọn Một Mẫu Báo Cáo")
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tháng"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Năm"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Quý"
        '
        'csVIEW
        '
        Me.csVIEW.ActiveViewIndex = -1
        Me.csVIEW.AutoScroll = True
        Me.csVIEW.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csVIEW.Location = New System.Drawing.Point(208, 8)
        Me.csVIEW.Name = "csVIEW"
        Me.csVIEW.ReportSource = Nothing
        Me.csVIEW.Size = New System.Drawing.Size(568, 456)
        Me.csVIEW.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 32)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Các Báo Cáo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Bitmap)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 32)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Danh Sách Các Báo Cáo"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBAOCAO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(784, 479)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.PictureBox1, Me.Label1, Me.csVIEW, Me.Label4, Me.Label3, Me.Label2, Me.btnOK, Me.btnDong, Me.lstReport, Me.optYear, Me.optQuater, Me.optMonth, Me.cmbYear, Me.cmbQuater, Me.cmbMonth})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBAOCAO"
        Me.Text = "Báo Cáo "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim xDK As String = ""
    Dim mysqlconn As New SqlConnection(strconn)

    Private Sub fillBC()
        Dim sqlconn As New SqlConnection(strconn)
        Dim sqlcmd As New SqlCommand("select * from tblBAOCAO", sqlconn)
        sqlconn.Open()
        Dim drsqlreader As SqlDataReader = sqlcmd.ExecuteReader
        Do While drsqlreader.Read()
            Me.lstReport.Items.Add(drsqlreader.GetString(1) & "......." & drsqlreader.GetString(2))
        Loop
        drsqlreader.Close()
        sqlconn.Close()
    End Sub


    Function TenBC() As String
        Dim st As String = ""
        st = Microsoft.VisualBasic.Right(Me.lstReport.SelectedItem, Len(Me.lstReport.SelectedItem) - InStr(Me.lstReport.SelectedItem, ".......") - 6)
        TenBC = st
    End Function

    Private Sub getperiod(ByVal strGP As String)
        Dim i As Integer
        Select Case strGP
            Case "M"
                Me.cmbMonth.Items.Clear()
                For i = 1 To 12
                    Me.cmbMonth.Items.Add(Microsoft.VisualBasic.Right("0" & i, 2))
                Next
            Case "Q"
                Me.cmbQuater.Items.Clear()
                For i = 1 To 4
                    Me.cmbQuater.Items.Add(i)
                Next
            Case "Y"
                Me.cmbYear.Items.Clear()
                For i = 2004 To 2010
                    Me.cmbYear.Items.Add(i)
                Next
        End Select
    End Sub

    Private Sub btnDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDong.Click
        Me.Hide()
    End Sub

    Private Sub frmBAOCAO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call fillBC()
    End Sub

    Private Sub optMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMonth.CheckedChanged
        If Me.optMonth.Checked = True Then
            getperiod("M")
            getperiod("Y")
            Me.cmbMonth.Enabled = True
            Me.cmbQuater.Enabled = False
            Me.cmbYear.Enabled = True

        End If
    End Sub

    Private Sub optQuater_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optQuater.CheckedChanged
        If Me.optQuater.Checked = True Then
            getperiod("Q")
            getperiod("Y")
            Me.cmbMonth.Enabled = False
            Me.cmbQuater.Enabled = True
            Me.cmbYear.Enabled = True

        End If
    End Sub

    Private Sub optYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optYear.CheckedChanged
        If Me.optYear.Checked = True Then
            getperiod("Y")
            Me.cmbMonth.Enabled = False
            Me.cmbQuater.Enabled = False
            Me.cmbYear.Enabled = True
        End If
    End Sub


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim xTen As String = ""
        If Me.lstReport.SelectedItem = "" Then
            MessageBox.Show("Bạn hãy chọn một mẫu báo cáo trong danh sách các loại báo cáo. Sau đó kích vào nút OK .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.lstReport.Focus()
            Exit Sub
        Else
            xTen = TenBC()
        End If

        If xTen <> "rptThongKeHang.rpt" AndAlso xTen <> "rptNoNCC.rpt" AndAlso xTen <> "rptSLHBan0.rpt" AndAlso xTen <> "rptMATHANG.rpt" _
        AndAlso xTen <> "rptNUOC.rpt" AndAlso xTen <> "rptNCC.rpt" AndAlso xTen <> "rptKHACH.rpt" AndAlso xTen <> "rptNHOMMH.rpt" Then
            If Me.optMonth.Checked = False And Me.optQuater.Checked = False And Me.optYear.Checked = False Then
                MessageBox.Show("Bạn hãy cho biết khoảng thời gian để đưa ra một báo cáo. Bạn có thể chọn Tháng hoặc Quý hoặc Năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        End If
        If Me.optMonth.Checked = True Then
            If Me.cmbMonth.Text = "" Or Me.cmbYear.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết Tháng và Năm của mẫu báo cáo. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmbMonth.Focus()
                Exit Sub
            End If
        End If
        If Me.optQuater.Checked = True Then
            If Me.cmbQuater.Text = "" Or Me.cmbYear.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết Quý và Năm của mẫu báo cáo. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmbQuater.Focus()
                Exit Sub
            End If
        End If
        If Me.optYear.Checked = True Then
            If Me.cmbYear.Text = "" Then
                MessageBox.Show("Bạn hãy cho biết Năm của mẫu báo cáo. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmbYear.Focus()
                Exit Sub
            End If
        End If

        Dim path As String = ""
        path = "\DoAn_Hoang_VBNET\Rpt\"
        Dim strProc As String = ""
        Dim bool As Boolean = True

        Select Case xTen
            Case "rptMATHANG.rpt"
                Me.csVIEW.ReportSource = path & xTen
                Me.csVIEW.RefreshReport()
            Case "rptNHOMMH.rpt"
                Me.csVIEW.ReportSource = path & xTen
                Me.csVIEW.RefreshReport()
            Case "rptNCC.rpt"
                Me.csVIEW.ReportSource = path & xTen
                Me.csVIEW.RefreshReport()
            Case "rptKHACH.rpt"
                Me.csVIEW.ReportSource = path & xTen
                Me.csVIEW.RefreshReport()
            Case "rptSLHBan0.rpt"
                Dim sql As String = ""
                sql = "SLHBan0"
                Dim cmd As New SqlCommand(sql, mysqlconn)
                Try
                    mysqlconn.Open()
                    cmd.ExecuteNonQuery()
                Catch
                    MessageBox.Show("Lỗi, có thể do bạn chọn khoảng thời gian không thích hợp với mẫu báo cáo, hoặc có thể do lỗi tải báo cáo. Bạn hãy kiểm tra lại tên của báo cáo xem khoảng thời gian tương ứng với nó có chính xác không. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    bool = False
                Finally
                    If mysqlconn.State = ConnectionState.Open Then
                        mysqlconn.Close()
                    End If
                End Try
                If bool = True Then
                    Me.csVIEW.ReportSource = path & xTen
                    Me.csVIEW.RefreshReport()
                End If
            Case "rptThongKeHang.rpt"
                Dim AppPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location

                Me.csVIEW.ReportSource = path & xTen
                Me.csVIEW.RefreshReport()
            Case "rptNoNCC.rpt"
                Me.csVIEW.ReportSource = path & xTen
                Me.csVIEW.RefreshReport()

            Case "rptSLBThang.rpt"
                Dim ookk As Boolean = True
                Dim str As String = ""
                strProc = "HangBanThang " & Me.cmbYear.Text & "," & Me.cmbMonth.Text

            Case "rptSLBQuy.rpt"
                Dim ookk As Boolean = True
                Dim str As String = ""
                strProc = "HangBanQuy " & Me.cmbYear.Text & "," & Me.cmbQuater.Text

            Case "rptSLBNam.rpt"
                Dim ookk As Boolean = True
                Dim str As String = ""
                strProc = "HangBanNam " & Me.cmbYear.Text

            Case "rptMHTop20_Thang.rpt"
                strProc = "MHTop20_Thang " & Me.cmbYear.Text & "," & Me.cmbMonth.Text
            Case "rptMHTop20_Quy.rpt"
                strProc = "MHTop20_Quy " & Me.cmbYear.Text & "," & Me.cmbQuater.Text
            Case "rptMHTop20_Nam.rpt"
                strProc = "MHTop20_Nam " & Me.cmbYear.Text
            Case "rptMHBottom20_Thang.rpt"
                strProc = "MHBottom20_Thang " & Me.cmbYear.Text & "," & Me.cmbMonth.Text
            Case "rptMHBottom20_Quy.rpt"
                strProc = "MHBottom20_Quy " & Me.cmbYear.Text & "," & Me.cmbQuater.Text
            Case "rptMHBottom20_Nam.rpt"
                strProc = "MHBottom20_Nam " & Me.cmbYear.Text
        End Select
        If xTen <> "rptThongKeHang.rpt" AndAlso xTen <> "rptNoNCC.rpt" AndAlso xTen <> "rptSLHBan0.rpt" AndAlso xTen <> "rptMATHANG.rpt" _
        AndAlso xTen <> "rptNUOC.rpt" AndAlso xTen <> "rptNCC.rpt" AndAlso xTen <> "rptKHACH.rpt" AndAlso xTen <> "rptNHOMMH.rpt" Then
            Dim cmdThu As New SqlCommand(strProc, mysqlconn)
            Try
                mysqlconn.Open()
                cmdThu.ExecuteNonQuery()

            Catch
                MessageBox.Show("Lỗi, có thể do bạn chọn khoảng thời gian không thích hợp với mẫu báo cáo, hoặc có thể do lỗi tải báo cáo. Bạn hãy kiểm tra lại tên của báo cáo xem khoảng thời gian tương ứng với nó có chính xác không. ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                bool = False
            Finally
                If mysqlconn.State = ConnectionState.Open Then
                    mysqlconn.Close()
                End If
            End Try
            If bool = True Then
                Me.csVIEW.ReportSource = path & xTen
                Me.csVIEW.RefreshReport()
            End If
        End If
    End Sub

    Private Sub clock()
        Me.optMonth.Enabled = False
        Me.optQuater.Enabled = False
        Me.optYear.Enabled = False
        Me.cmbMonth.Enabled = False
        Me.cmbQuater.Enabled = False
        Me.cmbYear.Enabled = False
    End Sub
    Private Sub Unclock()

        Me.optMonth.Enabled = True
        Me.optQuater.Enabled = True
        Me.optYear.Enabled = True

        Me.cmbMonth.Enabled = True
        Me.cmbQuater.Enabled = True
        Me.cmbYear.Enabled = True

        Me.cmbMonth.Text = ""
        Me.cmbQuater.Text = ""
        Me.cmbYear.Text = ""

        Me.optMonth.Checked = False
        Me.optQuater.Checked = False
        Me.optYear.Checked = False

    End Sub

    Private Sub lstReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReport.SelectedIndexChanged
        Dim xName As String = ""
        xName = TenBC()
        If (xName <> "rptThongKeHang.rpt") And (xName <> "rptNoNCC.rpt") And (xName <> "rptSLHBan0.rpt") Then
            Unclock()
        Else
            If xName = "rptThongKeHang.rpt" Or xName = "rptSLHBan0.rpt" Or xName = "rptNoNCC.rpt" Then
                Me.optMonth.Checked = False
                Me.optQuater.Checked = False
                Me.optYear.Checked = False
                clock()
            End If
        End If

    End Sub
End Class
