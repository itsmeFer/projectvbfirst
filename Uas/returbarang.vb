Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class returbarang
    Public ds As DataSet
    Public rd As SqlDataReader
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Dim conn As New SqlConnection
    Dim query As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbljam.Text = TimeOfDay

    End Sub
    Sub clear()
        txtnb.Text = ""
        txthb.Text = ""
        txtalasan.Text = ""
        txtidb.Text = ""
        txtjk.Text = ""
    End Sub
    Public Sub koneksi()
        query = "Data Source = LAPTOP-0HATQUNE; Initial Catalog = Gramedia; Integrated Security = True"
        conn = New SqlConnection(query)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub returbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltgl.Text = Today
        Call petugas()
        Call munculidjual()
        Call kondisiawal()
        Call munculidreturn()
    End Sub
    Sub munculidjual()
        Call koneksi()
        cbidt.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM transaksipenjualan  ", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbidt.Items.Add(rd.Item(0))
        Loop
        Call kondisiawal()
    End Sub
    Sub munculidreturn()
        Call koneksi()
        cditedit.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM return_jual  ", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cditedit.Items.Add(rd.Item(0))
        Loop
        Call kondisiawal()
    End Sub
    Sub kondisiawal()
        Call koneksi()
        da = New SqlDataAdapter("SELECT * FROM return_jual ", conn)
        ds = New DataSet
        da.Fill(ds, "return_jual")
        DataGridView1.DataSource = (ds.Tables("return_jual"))
    End Sub
    Private Sub cbsupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbidt.SelectedIndexChanged
        cmd = New SqlCommand(" SELECT * FROM transaksipenjualan WHERE id_transaksi = '" & cbidt.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtidb.Text = rd!id_barang
            txtnb.Text = rd!nama_barang
            txthb.Text = rd!harga_barang
            rd.Close()
            Call kondisiawal()
        End If

    End Sub
    Sub petugas()
        lblid.Text = menuutama.lblP.Text
        lbluser.Text = menuutama.lbluser.Text
        lblstatus.Text = menuutama.lbljabatan.Text
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

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        menuutama.Show()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If cbidt.Text = "" Then
            MessageBox.Show(" Masukkan ID Transaksi!")
        Else
            Dim cmdOpen As New SqlCommand
                    If conn.State = ConnectionState.Open Then conn.Close()
                    conn.Open()
                    cmdOpen.Connection = conn
            query = "Select * From return_jual Where id_transaksi = '" & Trim(cbidt.Text) & "'"
            cmdOpen.CommandText = query
                    cmdOpen.ExecuteNonQuery()

                    Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
                    If drOpen.HasRows Then
                query = "update return_jual set " &
                        "id_barang = '" & Trim(txtidb.Text) & "'," &
                        "nama_barang = '" & Trim(txtnb.Text) & "'," &
                        "harga_barang = '" & Trim(txthb.Text) & "'," &
                        "alasan = '" & Trim(txtalasan.Text) & "'," &
                        "jumlah_dikembalikan = '" & Trim(txtjk.Text) & "'," &
                        "tanggal_sekarang = '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "'," &
                         "id_pengguna = '" & Trim(lblid.Text) & "'," &
                        "where id_transaksi = '" & Trim(cbidt.Text) & "'"
            Else
                query = "INSERT INTO return_jual VALUES('" & Trim(cbidt.Text) & "', 
                    '" & Trim(txtidb.Text) & "',
                    '" & Trim(txtnb.Text) & "',
                    '" & Trim(txthb.Text) & "',
                    '" & Trim(txtalasan.Text) & "',
                    '" & Trim(txtjk.Text) & "',
                    '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "',
                    '" & Trim(lblid.Text) & "')"
            End If

                    drOpen.Close()
                    cmdOpen.CommandText = query
                    cmdOpen.ExecuteNonQuery()

                    conn.Close()
                    MessageBox.Show("Data Has Been Saved")
                    Call kondisiawal()
                    clear()
            cbidt.Select()
        End If

    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If cditedit.Text = "" Then
            MessageBox.Show("Masukkan ID Supplier yang Benar!")
        Else
            Call koneksi()
            Dim editdata As String = "UPDATE return_jual SET id_barang= '" & txtidb.Text & "',nama_barang ='" & txtnb.Text & "',harga_barang = '" & txthb.Text & "', alasan = '" & txtalasan.Text & "', jumlah_dikembalikan = '" & txtjk.Text & " ', tanggal_sekarang = '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "', id_pengguna = '" & lblid.Text & "' WHERE id_transaksi = '" & cditedit.Text & "'"
            cmd = New SqlCommand(editdata, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Edit!")
                    Call kondisiawal()
                End If
        txtnb.Enabled = True
        txthb.Enabled = True
        txtidb.Enabled = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cditedit.SelectedIndexChanged
        cmd = New SqlCommand(" SELECT * FROM return_jual WHERE id_transaksi = '" & cditedit.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtidb.Text = rd!id_barang
            txtnb.Text = rd!nama_barang
            txthb.Text = rd!harga_barang
            rd.Close()
            Call kondisiawal()
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If cditedit.Text = "" Then
            MessageBox.Show("Masukkan ID Taransaksi  yang Benar!")
        Else

            Call koneksi()
            Dim editdata As String = "delete return_jual WHERE id_transaksi = '" & cditedit.Text & "'"
            cmd = New SqlCommand(editdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Hapus!")
                clear()
                Call kondisiawal()
            End If

    End Sub

    Private Sub cbidt_Click(sender As Object, e As EventArgs) Handles cbidt.Click
        txtnb.Enabled = False
        txthb.Enabled = False
        txtidb.Enabled = False
    End Sub
End Class