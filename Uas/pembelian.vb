Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Microsoft


Public Class pembelian
    Public ds As DataSet
    Public rd As SqlDataReader
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Dim conn As New SqlConnection
    Dim query As String
    Dim pilihan As String
    Sub clear()
        txtnb.Text = ""
        txthb.Text = ""
        txtjumlahmasuk.Text = ""
        txtketerangan.Text = ""
        txtsisastock.Text = ""
        txtjumlahbayar.Text = ""
        tglmasuk.Value = Now.Date
        tgltransaksi.Value = Now.Date
        totalhutang.Text = ""
        dibayarhutang.Text = ""
        sisahutang.Text = ""
        bungahutang.Text = ""
        jumlahbunga.Text = ""
        jumlahhutang.Text = ""
        rd1.Checked = False
        rd2.Checked = False
    End Sub
    Public Sub koneksi()
        query = "Data Source = LAPTOP-0HATQUNE; Initial Catalog = Gramedia; Integrated Security = True"
        conn = New SqlConnection(query)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub kondisiawal()
        Call koneksi()
        da = New SqlDataAdapter("SELECT * FROM transaksi_pembeliann ", conn)
        ds = New DataSet
        da.Fill(ds, "transaksi_pembeliann")
        dgvpembelian.DataSource = (ds.Tables("transaksi_pembeliann"))
        If txtsisastock.Text = "" Then
            txtsisastock.Text = 0
        Else
        End If

    End Sub

    Sub munculidsupplier()
        Call koneksi()
        cbidsup.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM supplier ", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbidsup.Items.Add(rd.Item(0))
        Loop
        Call kondisiawal()
    End Sub
    Sub munculidpembelian()
        Call koneksi()
        cbidpembelian.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM transaksi_pembeliann ", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbidpembelian.Items.Add(rd.Item(0))
        Loop
        Call kondisiawal()
    End Sub
    Private Sub pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltgl.Text = Today
        txtidpembelian.Text = Autocode1("id_pembeliann", Now.Date)
        txtidb.Text = Autocode2("id_barang", Now.Date)
        hutang.Visible = False
        txtjumlahbayar.Text = totalhutang.Text
        Call petugas()
        Call kondisiawal()
        Call munculidsupplier()
        Call munculidpembelian()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbljam.Text = TimeOfDay
    End Sub
    Sub petugas()
        lblid.Text = menuutama.lblP.Text
        lbluser.Text = menuutama.lbluser.Text
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
    Private Sub cbidsup_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbidsup.SelectedIndexChanged

        cmd = New SqlCommand(" SELECT * FROM supplier WHERE id_supplier = '" & cbidsup.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnama.Text = rd!nama_supplier
            Call kondisiawal()
            rd.Close()
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles lblid.TextChanged

    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtidpembelian.Text = "" Then
            MessageBox.Show("Masukkan ID Pembelian yang Benar!")
        Else
            If Not (IsNumeric(txtjumlahmasuk.Text)) Then
                MsgBox("Masukkan Jumlah Yang Benar")
            Else
                If rd1.Checked = True Then
                    pilihan = rd1.Text
                ElseIf rd2.Checked = True Then
                    pilihan = rd2.Text
                End If
                If cbidsup.Text = "" Then
                    MessageBox.Show("Masukkan ID Supplier yang Benar!")
                Else
                    Dim cmdOpen As New SqlCommand
                    If conn.State = ConnectionState.Open Then conn.Close()
                    conn.Open()
                    cmdOpen.Connection = conn
                    query = "Select * From transaksi_pembeliann Where id_pembelian = '" & Trim(txtidpembelian.Text) & "'"
                    cmdOpen.CommandText = query
                    cmdOpen.ExecuteNonQuery()

                    Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
                    If drOpen.HasRows Then
                        query = "update transaksi_pembeliann set " &
                        "id_supplier = '" & Trim(cbidsup.Text) & "'," &
                        "id_barang = '" & Trim(txtidb.Text) & "'," &
                        "id_pengguna = '" & Trim(lblid.Text) & "," &
                        "nama_barang = '" & Trim(txtnb.Text) & "'," &
                        "harga_barang = '" & Trim(txthb.Text) & "'," &
                        "jumlah_masuk = '" & Trim(txtjumlahmasuk.Text) & "," &
                        "harga_bayar = '" & Trim(txtjumlahbayar.Text) & "'," &
                        "tanggal_masuk = '" & Format(tglmasuk.Value, "yyyy-MM-dd") & "'," &
                        "sisa_stock = '" & Trim(txtsisastock.Text) & "'," &
                        "keterangan = '" & Trim(txtketerangan.Text) & "'," &
                        "tanggal_transaksi = '" & Format(tgltransaksi.Value, "yyyy-MM-dd") & "'," &
                        "sistem_pembayaran = '" & Trim(pilihan) & "'," &
                        "total_hutang = '" & Trim(totalhutang.Text) & "'," &
                        "bayar_hutang = '" & Trim(dibayarhutang.Text) & "'," &
                        "sisa_hutang = '" & Trim(sisahutang.Text) & "'," &
                        "bunga = '" & Trim(bungahutang.Text) & "'," &
                        "jumlah_bunga = '" & Trim(jumlahbunga.Text) & "'," &
                        "tgl_bayar = '" & Format(tglbayar.Value, "yyyy-MM-dd") & "'," &
                        "tgl_tempo = '" & Format(tgltempo.Value, "yyyy-MM-dd") & "'," &
                        "jumlah_hutang = '" & Trim(jumlahhutang.Text) & "'" &
                        "where id_pembelian = '" & Trim(txtidpembelian.Text) & "'"
                    Else
                        query = "INSERT INTO transaksi_pembeliann VALUES('" & Trim(txtidpembelian.Text) & "', 
                     '" & Trim(cbidsup.Text) & "',
                    '" & Trim(txtidb.Text) & "',
                    '" & Trim(lblid.Text) & "',
                    '" & Trim(txtnb.Text) & "',
                    '" & Trim(txthb.Text) & "',                    
                    '" & Trim(txtjumlahmasuk.Text) & "', 
                    '" & Trim(txtjumlahbayar.Text) & "',
                    '" & Format(tglmasuk.Value, "yyyy-MM-dd") & "',
                    '" & Trim(txtsisastock.Text) & "',
                    '" & Trim(txtketerangan.Text) & "',
                    '" & Format(tgltransaksi.Value, "yyyy-MM-dd") & "',
                    '" & Trim(pilihan) & "', 
                    '" & Trim(totalhutang.Text) & "', 
                    '" & Trim(dibayarhutang.Text) & "', 
                    '" & Trim(sisahutang.Text) & "', 
                    '" & Trim(bungahutang.Text) & "', 
                    '" & Trim(jumlahbunga.Text) & "', 
                    '" & Format(tglbayar.Value, "yyyy-MM-dd") & "', 
                    '" & Format(tgltempo.Value, "yyyy-MM-dd") & "', 
                    '" & Trim(jumlahhutang.Text) & "')"
                    End If

                    drOpen.Close()
                    cmdOpen.CommandText = query
                    cmdOpen.ExecuteNonQuery()
                    conn.Close()
                    MessageBox.Show("Data Has Been Saved")
                    Call kondisiawal()
                    clear()
                    txtidpembelian.Select()
                    Call kondisiawal()
                End If
            End If
        End If

    End Sub
    Private Sub txthb_LostFocus(sender As Object, e As EventArgs) Handles txthb.LostFocus
        If Not IsNumeric(Trim(txthb.Text)) Then
            txthb.Text = 0
        End If
        txthb.Text = Format(CDbl(txthb.Text), "###,##0.00")
    End Sub


    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        Dim editdata As String = "UPDATE transaksi_pembeliann SET 
        id_supplier= '" & cbidsup.Text &
        " id_barang ='" & txtidb.Text &
        " id_pengguna = '" & lblid.Text &
        " nama_barang = '" & txtnb.Text &
        " harga_barang = '" & txthb.Text &
        " jumlah_masuk = '" & CInt(Trim(txtjumlahmasuk.Text)) &
        " jumlah_bayar = '" & txtjumlahbayar.Text &
        " tanggal_masuk = '" & Format(tglmasuk.Value, "yyyy-MM-dd") &
        " sisa_stock = '" & txtsisastock.Text &
        " keterangan = '" & txtketerangan.Text &
        " tanggal_transaksi = '" & Format(tgltransaksi.Value, "yyyy-MM-dd") &
        " sistem_pembayaran = '" & Trim(pilihan) & "'," &
        " total_hutang = '" & Trim(totalhutang.Text) & "'," &
        " bayar_hutang = '" & Trim(dibayarhutang.Text) & "'," &
        " sisa_hutang = '" & Trim(sisahutang.Text) & "'," &
        " bunga = '" & Trim(bungahutang.Text) & "'," &
        " jumlah_bunga = '" & Trim(jumlahbunga.Text) & "'," &
        " tgl_bayar = '" & Format(tglbayar.Value, "yyyy-MM-dd") & "'," &
        " tgl_tempo = '" & Format(tgltempo.Value, "yyyy-MM-dd") & "'," &
        " jumlah_hutang = '" & Trim(jumlahhutang.Text) & "'" &
        " where id_pembelian = '" & Trim(txtidpembelian.Text) & "'"
        cmd = New SqlCommand(editdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Edit!")
        Call kondisiawal()
        clear()
    End Sub

    Private Sub cbidpembelian_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbidpembelian.SelectedIndexChanged

        cmd = New SqlCommand(" SELECT * FROM transaksi_pembeliann WHERE id_pembelian = '" & cbidpembelian.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnama.Text = rd!id_supplier
            txtidb.Text = rd!id_barang
            lblid.Text = rd!id_pengguna
            txtnb.Text = rd!nama_barang
            txthb.Text = rd!harga_barang
            txtjumlahmasuk.Text = rd!jumlah_masuk
            tglmasuk.Value = rd!tanggal_masuk
            txtsisastock.Text = rd!sisa_stock
            txtketerangan.Text = rd!keterangan
            tgltransaksi.Value = rd!tanggal_transaksi
            pilihan = rd!sistem_pembayaran
            totalhutang.Text = rd!total_hutang
            dibayarhutang.Text = rd!bayar_hutang
            sisahutang.Text = rd!sisa_hutang
            bungahutang.Text = rd!bunga
            jumlahbunga.Text = rd!jumlah_bunga
            jumlahhutang.Text = rd!jumlah_hutang
            Call kondisiawal()
            rd.Close()
        End If
    End Sub

    Private Sub cbidpembelian_Click(sender As Object, e As EventArgs) Handles cbidpembelian.Click

    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Call koneksi()
        Dim editdata As String = "delete transaksi_pembeliann WHERE id_pembelian = '" & cbidpembelian.Text & "'"
        cmd = New SqlCommand(editdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Hapus!")
        Call kondisiawal()
        clear()
        cbidpembelian.Text = ""
        cbidsup.Text = ""
        txtnama.Text = ""
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        menuutama.Show()
    End Sub

    Private Sub txtjumlahbayar_TextChanged(sender As Object, e As EventArgs) Handles txtjumlahbayar.TextChanged

    End Sub

    Private Sub btnbayar_Click(sender As Object, e As EventArgs) Handles btnbayar.Click

        txtsisastock.Text = Val(txtjumlahmasuk.Text) + Val(txtsisastock.Text)
        Dim bil3 = txthb.Text
        Dim bil4 = txtjumlahmasuk.Text

        txtjumlahbayar.Text = bil3 * bil4
        txtjumlahbayar.Text = Format(CDec(txtjumlahbayar.Text), "###,##0.00")

    End Sub

    Private Sub rd2_CheckedChanged(sender As Object, e As EventArgs) Handles rd2.CheckedChanged
        totalhutang.Text = txtjumlahbayar.Text
        hutang.Show()
    End Sub

    Private Sub rd1_CheckedChanged(sender As Object, e As EventArgs) Handles rd1.CheckedChanged
        hutang.Hide()
    End Sub

    Private Sub btnhitung_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        jumlahbunga.Text = Val(bungahutang.Text / 100) * Val(sisahutang.Text)
    End Sub

    Private Sub tglbayar_ValueChanged(sender As Object, e As EventArgs) Handles tglbayar.ValueChanged
        If Format(tglbayar.Value, "yyyy-MM-dd") > Format(tgltempo.Value, "yyyy-MM-dd") Then
            MessageBox.Show("Anda telah membayar hutang melewati jatuh tempo !!!")
            jumlahhutang.Text = Val(jumlahbunga.Text) + Val(sisahutang.Text)
        Else
            MessageBox.Show("Anda telah membayar hutang tepat waktu !!!")
            jumlahhutang.Text = sisahutang.Text
        End If
    End Sub
End Class