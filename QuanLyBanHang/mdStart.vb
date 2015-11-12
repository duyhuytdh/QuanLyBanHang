Imports System.Data
Imports System.Data.SqlClient

Module mdStart
    Public xLogin As Boolean = False
    Public xtxtMALOAI As String
    Public strconn As String
    ' bien cho biet pham vi truy cap chuong trinh
    Public power As String = ""

    Public Sub Main()
        strconn = "Data Source=HUONGHILL-PC\SQLEXPRESS2012;Initial Catalog=QuanLyBanHang;Persist Security Info=True;User ID=sa;Password=sa"
    End Sub

    'ham kiem tra xem ma nhap vao da ton tai chua , neu ton tai roi thi bao loi
    Function checkcode(ByVal tbl_name As String, ByVal name_field As String, ByVal key As String) As Boolean
        Dim string2 = strconn
        Dim sqlconn As SqlConnection = New SqlConnection(string2)
        Dim strsql As String = "select * from " & tbl_name & " where " & name_field & "='" & key & "'"
        Dim sqlcmd As SqlCommand = New SqlCommand(strsql, sqlconn)
        sqlconn.Open()
        Dim sqlreader As SqlDataReader = sqlcmd.ExecuteReader()
        Dim xMA As String
        Do While sqlreader.Read()
            xMA = sqlreader.GetString(0)
        Loop
        sqlreader.Close()
        sqlconn.Close()
        If xMA = "" Then
            checkcode = True
        Else
            checkcode = False
        End If
    End Function
    'kiem tra xem ma da ton tai chua neu chua ton tai thi bao loi
    Function existcode(ByVal tbl_name As String, ByVal field_name As String, ByVal check As String) As Boolean
        Dim str = strconn
        Dim sqlconn1 As SqlConnection = New SqlConnection(str)
        Dim sqlstr As String = "select * from " & tbl_name & " where " & field_name & "='" & check & "'"

        Dim sqlcmd As SqlCommand = New SqlCommand(sqlstr, sqlconn1)
        sqlconn1.Open()
        Dim mydatareader As SqlDataReader = sqlcmd.ExecuteReader
        Dim xMA As String = ""
        Do While mydatareader.Read
            xMA = mydatareader.GetString(0)
        Loop
        mydatareader.Close()
        sqlconn1.Close()
        If xMA <> "" Then
            existcode = True
        Else
            existcode = False
        End If
    End Function

    Public Sub delItem2(ByVal tblname As String, ByVal codekey As String, ByVal strno As String, ByVal description As String)
        Dim strconn2 = strconn
        Dim mySQLConnection As New SqlConnection(strconn2)
        Dim sqlcmd As New SqlCommand("delete from " & tblname & " where " & codekey & " ='" & strno & "'", mySQLConnection)
        Try
            mySQLConnection.Open()
            sqlcmd.ExecuteNonQuery()
        Catch
            MessageBox.Show("Không Thể Xoá " & description & " Có Mã: " & strno, "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If (mySQLConnection.State = ConnectionState.Open) Then
                mySQLConnection.Close()
            End If
        End Try
    End Sub
    'Ham sinh ma
    Function incNum(ByVal str As String, ByVal i As Byte) As Integer
        Dim leng As Byte
        Dim number As Integer
        number = 0
        leng = 0
        leng = Len(str)
        number = CInt(Right(Trim(str), leng - i))
        incNum = number
    End Function

    Function Tao_MA(ByVal tbl As String, ByVal head As String, ByVal ii As Integer) As String
        Dim sqlconn As SqlConnection = New SqlConnection(strconn)
        Dim sqlstr = "select * from " & tbl
        Dim mysqlcmd As SqlCommand = New SqlCommand(sqlstr, sqlconn)
        sqlconn.Open()
        Dim mydatareader As SqlDataReader = mysqlcmd.ExecuteReader
        Dim xMA As String
        Dim max, num As Integer
        max = 0
        Do While mydatareader.Read()
            xMA = ""
            xMA = mydatareader.GetString(0)
            num = incNum(xMA, ii)
            If num > max Then
                max = num
            End If
        Loop
        mydatareader.Close()
        sqlconn.Close()
        Return head & CStr(max + 1)
    End Function

    Public Sub dosql(ByVal strquery As String)
        Dim mysqlconnection As New SqlConnection(strconn)
        Dim mysqlcmd As New SqlCommand(strquery, mysqlconnection)
        Try
            mysqlconnection.Open()
            mysqlcmd.ExecuteNonQuery()
        Catch
            MessageBox.Show("Không Thể Thực Thi Câu Lệnh Này.", "Xin Chào !", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            If mysqlconnection.State = ConnectionState.Open Then
                mysqlconnection.Close()
            End If
        End Try
    End Sub
    Public Function Encript(ByVal str As String, ByVal num As Integer) As String
        Dim i As Integer
        Dim letter, EncriptCode As String
        EncriptCode = ""
        For i = 1 To Len(str)
            letter = ""
            letter = Mid(str, i, 1)
            EncriptCode = EncriptCode & Chr(Asc(letter) +1)
        Next
        Encript = EncriptCode
    End Function

    Public Function checkDate(ByVal st As String) As Byte
        Dim l As Int16
        Dim i, dem As Int16
        st = Trim(st)
        l = Microsoft.VisualBasic.Len(st)
        dem = 0
        For i = 1 To l
            If CStr(Microsoft.VisualBasic.Mid(st, i, 1)) = "/" Then
                dem = dem + 1
            End If
        Next
        checkDate = dem
    End Function

End Module
