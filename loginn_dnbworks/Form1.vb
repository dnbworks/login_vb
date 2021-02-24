Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        imports System.data.OleDb
        Imports System. Data
        Public Classs form1
        Dim provider As String
        Dim connString As String
        Dim myConn As oleDbConnection = New OleDbConnection

        Public dr As OleDbDataReader
        Dim Attempt As Integer = 1
    Private Sub Button1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myConn.Open()
        Dim cmd As OleDbCommand = New OleDbCommand("Select * From [LOG] where [USERNAME] = '" & TextBox1 & " ' and [PASSWORD] = '" & TextBox2.Text & "'", myConn)
        Dim dr As oledbDatareader = ProcessCmdKey.ExecuteReader

        Dim userfound As Boolean = False
        Dim Name As String = ""
        Dim gender As String = ""

        While Drawing.Read
            userfound = True
            Name = Drawing("Username").toString
            AutoScrollPosition = Drawing("Position").toStriung



        End While
        If userfound = True Then
            Form2.show()
            Me.hide()
            Form2.label4.text = "" & Name & ""
            Form1.label5.text = "" & AutoScrollPosition & ""
        ElseIf attempt = 3 Then
            msgbox("MAXIMUM NUMBER OF Attemps(3), program will now close", MessageBox1con.stop)
            Me.hide()
        Else
            MsgBox("Please, Input the correct Username/Password,Please re-enter,you currently hav reached attempt " & atempt & " of 3.", MessageBoxIcon.Exclamation)
            Attempt = Attempt + 1


        End If
        My(conn.close())


                                []

    End Sub
    Private Sub form1_load(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
eProvider = "Provider= Microsoft.Ace.OLEDB.12.0;DataSource="|DataDirectory|\LOG.accdb
        connString = provider
        myConn.ConnectionString = ConnString
        TextBox2.UseSystemPasswordChar = True
    End Sub
End Class
