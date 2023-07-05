Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows

Public Class menuutama
    Public rd As SqlDataReader
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Dim conn As New SqlConnection
    Dim query As String
    Public ds As DataSet
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub
    Sub kondisiawal()
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False

        Label6.Visible = False
    End Sub
    Private Sub menuutama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call kondisiawal()
        lbltgl.Text = Today
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)
        Me.Hide()
        login.Show()
    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        suppliermaster.Show()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbljam.Text = TimeOfDay
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles pnlLeft.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Visible = True
        Label2.Visible = False
        Label3.Visible = False

        Label6.Visible = False


        'MASTER
        pnlmaster.Visible = True

        'transaksi
        pnlTransaksi.Visible = False

        'laporan
        pnlLaporan.Visible = False

    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        pembelian.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label1.Visible = False
        Label2.Visible = True
        Label3.Visible = False

        Label6.Visible = False

        pnlmaster.Visible = False
        pnlTransaksi.Visible = True
        pnlLaporan.Visible = False



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = True

        Label6.Visible = False
        'MASTER
        pnlmaster.Visible = False

        'transaksi
        pnlTransaksi.Visible = False

        'laporan
        pnlLaporan.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) 
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False

        Label6.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) 
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False

        Label6.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False

        Label6.Visible = True
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Hide()
        transaksiPenjualan.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Me.Hide()
        suppliermaster.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        masterstock.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)
        Me.Hide()
        laporansupplier.Show()

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)
        Me.Hide()
        laporanstock.Show()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        laporansupplier.Show()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        laporanstock.Show()
    End Sub

    Private Sub Label4_Click_1(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button12_Click_1(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Hide()
        suppliermaster.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Me.Hide()
        laporanpenjualan.Show()

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Hide()
        laporanpembelian.Show()
    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Hide()
        returbarang.Show()
    End Sub
End Class