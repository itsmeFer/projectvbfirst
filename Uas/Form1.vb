Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection.Emit
Imports System.Windows

Public Class login

    Public rd As SqlDataReader
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Dim conn As New SqlConnection
    Dim query As String
    Public ds As DataSet
    Sub clear()
        txtpw.Text = ""
        txtuser.Text = ""
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        txtpw.UseSystemPasswordChar = True
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnshow.Click
        If txtpw.UseSystemPasswordChar = True Then
            txtpw.UseSystemPasswordChar = False
            btnshow.Text = "Hide"
        Else
            txtpw.UseSystemPasswordChar = True
            btnshow.Text = "Show"
        End If
    End Sub
    Public Sub koneksi()
        query = "Data Source = LAPTOP-0HATQUNE; Initial Catalog = Gramedia; Integrated Security = True"
        conn = New SqlConnection(query)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub btnlogin_Click_1(sender As Object, e As EventArgs) Handles btnlogin.Click
        Call koneksi()
        If txtuser.Text = "" Or txtpw.Text = "" Then
            MessageBox.Show("Masukkan Data Dengan Benar")
        Else

            cmd = New SqlCommand("Select * From pengguna WHERE username = '" & txtuser.Text & "' and password='" & txtpw.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                menuutama.lblP.Text = rd!id_pengguna
                menuutama.lbluser.Text = rd!username
                menuutama.lbljabatan.Text = rd!jabatan
                menuutama.lbltgl.Text = Today
                Me.Hide()
                menuutama.ShowDialog()


            End If
        End If
    End Sub


End Class
