Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class masterstock
    Public ds As DataSet
    Public rd As SqlDataReader
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Dim conn As New SqlConnection
    Dim query As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Sub munculidpembelian()
        Call koneksi()
        cbidb.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM transaksi_pembeliann ", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbidb.Items.Add(rd.Item(0))
        Loop
        Call kondisiawal()

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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbljam.Text = TimeOfDay
    End Sub
    Sub petugas()
        lblid.Text = menuutama.lblP.Text
        lbluser.Text = menuutama.lbluser.Text
        lblstatus.Text = menuutama.lbljabatan.Text
    End Sub
    Private Sub masterstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltgl.Text = Today

        Call munculidbaranghps()
        Call kondisiawal()
        Call munculidpembelian()
        Call petugas()
    End Sub

    Public Sub koneksi()
        query = "Data Source = LAPTOP-0HATQUNE; Initial Catalog = Gramedia; Integrated Security = True;  MultipleActiveResultSets=True"
        conn = New SqlConnection(query)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub kondisiawal()
        Call koneksi()
        da = New SqlDataAdapter("SELECT * FROM stock_barang ", conn)
        ds = New DataSet
        da.Fill(ds, "stock_barang")
        DataGridView1.DataSource = (ds.Tables("stock_barang"))

    End Sub
    Private Sub cbsupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbidb.SelectedIndexChanged
        cmd = New SqlCommand(" SELECT * FROM transaksi_pembeliann WHERE id_pembelian = '" & cbidb.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnb.Text = rd!nama_barang
            txtst.Text = rd!sisa_stock


        End If
    End Sub
    Sub munculidbaranghps()
        Call koneksi()
        cbidb.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM stock_barang ", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cdibhps.Items.Add(rd.Item(0))
        Loop
        Call kondisiawal()



    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If cbidb.Text = "" Then
            MessageBox.Show("Masukkan ID Pembelian yang Benar!")

        Else
            If txtnb.Text = "" Then
                MsgBox("Masukkan Sistem Pembayaran")
            Else
                If Not (IsNumeric(txthb.Text)) Then
                    MsgBox("Masukkan Jumlah Yang Benar")
                Else
                    Dim cmdOpen As New SqlCommand
                    If conn.State = ConnectionState.Open Then conn.Close()
                    conn.Open()
                    cmdOpen.Connection = conn
                    query = "Select * From stock_barang Where id_barang = '" & Trim(cbidb.Text) & "'"
                    cmdOpen.CommandText = query
                    cmdOpen.ExecuteNonQuery()

                    Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
                    If drOpen.HasRows Then
                        query = "update stock_barang set " &
                        "id_pengguna = '" & Trim(lblid.Text) & "'," &
                        "nama_barang = '" & Trim(txtnb.Text) & "'," &
                        "harga_barang = '" & Trim(txthb.Text) & "'," &
                        "sisa_stock = '" & Trim(txtst.Text) & "'," &
                        "tanggal_sekarang = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'," &
                        "where id_barang = '" & Trim(cbidb.Text) & "'"
                    Else
                        query = "INSERT INTO stock_barang VALUES('" & Trim(cbidb.Text) & "', 
                        '" & Trim(lblid.Text) & "',
                        '" & Trim(txtnb.Text) & "',
                        '" & Trim(txthb.Text) & "',
                        '" & Trim(txtst.Text) & "',
                        '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
                    End If

                    drOpen.Close()
                    cmdOpen.CommandText = query
                    cmdOpen.ExecuteNonQuery()

                    conn.Close()
                    MessageBox.Show("Data Has Been Saved")
                    Call kondisiawal()
                    clear()
                    cbidb.Select()
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
    Sub clear()
        cbidb.Text = ""
        txtnb.Text = ""
        txthb.Text = ""
        txtst.Text = ""
        DateTimePicker1.Value = Now.Date
        cdibhps.Text = ""
        txtnbhps.Text = ""
        txthbhps.Text = ""
        txtsthps.Text = ""
        DateTimePicker2.Value = Now.Date
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If cdibhps.Text = "" Then
            MessageBox.Show("Masukkan ID Barang!")
        Else
            Call koneksi()
            Dim editdata As String = "delete stock_barang WHERE id_barang = '" & cdibhps.Text & "'"
            cmd = New SqlCommand(editdata, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di Hapus!")
            Call kondisiawal()
            clear()
            cbidb.Text = ""
            txtnb.Text = ""
            txthb.Text = ""
            txtst.Text = ""
            DateTimePicker2.Value = Now.Date
        End If
        Call kondisiawal()

    End Sub

    Private Sub cdibhps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cdibhps.SelectedIndexChanged
        cmd = New SqlCommand(" SELECT * FROM stock_barang WHERE id_barang = '" & cdibhps.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnbhps.Text = rd!nama_barang
            txthbhps.Text = rd!harga_barang
            txtsthps.Text = rd!sisa_stock
            DateTimePicker2.Value = rd!tanggal_sekarang

        End If
    End Sub

    Private Sub cdibhps_Click(sender As Object, e As EventArgs) Handles cdibhps.Click
        clear()
        btnedit.Enabled = True
        btnsimpan.Enabled = False
        btnhapus.Enabled = True
    End Sub

    Private Sub cbidb_Click(sender As Object, e As EventArgs) Handles cbidb.Click
        clear()
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnsimpan.Enabled = True
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        menuutama.Show()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        Call koneksi()
        Dim editdata As String = "UPDATE stock_barang SET 
        nama_barang = '" & txtnb.Text &
        "', harga_barang = '" & txthb.Text &
        "', sisa_stock = '" & txtst.Text &
        "', tanggal_sekarang = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") &
        "' WHERE id_barang = '" & cbidb.Text & "'"
        cmd = New SqlCommand(editdata, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Edit!")
        Call kondisiawal()
        clear()

    End Sub

    Private Sub txtnbhps_TextChanged(sender As Object, e As EventArgs) Handles txtnbhps.TextChanged

    End Sub

    Private Sub txtnbhps_Click(sender As Object, e As EventArgs) Handles txtnbhps.Click

    End Sub
End Class