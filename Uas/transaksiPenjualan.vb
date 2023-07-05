Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions


Public Class transaksiPenjualan
    Public ds As DataSet
    Public rd As SqlDataReader
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Dim conn As New SqlConnection
    Dim query As String
    Sub clear()
        txtidt.Text = Autocode4("transaksipenjualan", Now.Date)
        cdib.Text = ""
        txtnb.Text = ""
        txthb.Text = ""
        txtQtypenjualan.Text = ""
        txtHASILQTYpenjualan.Text = ""
        txtDIBAYARKANpenjualan.Text = ""
        txtkembalian.Text = ""
        tglTRANSAKSIpenjualan.Value = Now.Date

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbljam.Text = TimeOfDay
    End Sub
    Public Sub koneksi()
        query = "Data Source = LAPTOP-0HATQUNE; Initial Catalog = Gramedia; Integrated Security = True; MultipleActiveResultSets=True"
        conn = New SqlConnection(query)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Private Sub transaksiPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltgl.Text = Today

        clear()
        Call petugas()
        Call munculidbarang()

    End Sub
    Private Sub txtHASILQTYpenjualan_LostFocus(sender As Object, e As EventArgs) Handles txtHASILQTYpenjualan.LostFocus
        If Not IsNumeric(Trim(txtHASILQTYpenjualan.Text)) Then
            txtHASILQTYpenjualan.Text = 0
            txtHASILQTYpenjualan.Text = Format(CDbl(txtHASILQTYpenjualan.Text), "###,##0.00")
        End If

    End Sub
    Sub munculidbarang()
        Call koneksi()
        cdib.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM stock_barang ", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cdib.Items.Add(rd.Item(0))
        Loop




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

    Private Sub cbIDBARANGpenjualan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cdib.SelectedIndexChanged

        cmd = New SqlCommand(" SELECT * FROM stock_barang WHERE id_barang = '" & cdib.Text & "'", conn)

        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnb.Text = rd!nama_barang
            txthb.Text = rd!harga_barang

        End If
    End Sub

    Private Sub lblid_TextChanged(sender As Object, e As EventArgs) Handles lblid.TextChanged

    End Sub

    Private Sub txtidt_TextChanged(sender As Object, e As EventArgs) Handles txtidt.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If txtQtypenjualan.Text = "" Then
            MessageBox.Show("Penjumlahhan Barang Harus Terisi!")
        Else
            dgvpenjualan.Rows.Add(cdib.Text, txtnb.Text, txthb.Text, txtQtypenjualan.Text, lblSUBTOTALpenjualan.Text)


            For Each row As DataGridViewRow In dgvpenjualan.Rows
                row.Cells("subh").Value = Convert.ToDouble(row.Cells("hb").Value) * Convert.ToDouble(row.Cells("qty").Value)

            Next
            Dim colsum As Decimal
            For Each R As DataGridViewRow In dgvpenjualan.Rows
                colsum += R.Cells(4).Value

            Next
            lblSUBTOTALpenjualan.Text = colsum
        End If
        clear()


    End Sub

    Private Sub dgvpenjualan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpenjualan.CellContentClick

    End Sub

    Private Sub btnHASILQTYpenjualan_Click(sender As Object, e As EventArgs) Handles btnHASILQTYpenjualan.Click
        Dim cmdOpen As New SqlCommand
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        cmdOpen.Connection = conn

        query = "SELECT * FROM stock_barang WHERE id_barang = '" & Trim(cdib.Text) & "'"
        cmdOpen.CommandText = query
        cmdOpen.ExecuteNonQuery()

        Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
        If drOpen.HasRows Then
            While drOpen.Read

                If txtQtypenjualan.Text = "" Then
                    MessageBox.Show("Isi terlebih dahulu qty yang di inginkan!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf txtQtypenjualan.Text = 0 Then
                    MessageBox.Show("Qty yang di inginkan tidak boleh kosong!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ElseIf CInt(Trim(txtQtypenjualan.Text)) > CInt(drOpen("sisa_stock")) Then
                    MessageBox.Show("Qty tidak mencukupi stok yang ada!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim a = txthb.Text
                    Dim b = txtQtypenjualan.Text
                    txtHASILQTYpenjualan.Text = a * b
                End If
            End While
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_LostFocus(sender As Object, e As EventArgs)
        txtkembalian.Text = Format(CDbl(txtkembalian.Text), "###,##0.00")
    End Sub

    Private Sub txtHASILQTYpenjualan_TextChanged(sender As Object, e As EventArgs) Handles txtHASILQTYpenjualan.TextChanged

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles btnhitung.Click

        Dim a = lblSUBTOTALpenjualan.Text
        Dim b = txtDIBAYARKANpenjualan.Text
        If b < a Then
            MessageBox.Show("Masukkan Nominal yang Benar")
        Else

            txtkembalian.Text = b - a

        End If
    End Sub
    'Sub kondisiawal()
    '    Call koneksi()
    '    da = New SqlDataAdapter("SELECT * FROM transaksipenjualan ", conn)
    '    ds = New DataSet
    '    da.Fill(ds, "transaksipenjualan")
    '    dgvpembelian.DataSource = (ds.Tables("transaksipenjualan"))
    '    End If
    'End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click


        Dim cmdOpen As New SqlCommand
                    If conn.State = ConnectionState.Open Then conn.Close()
                    conn.Open()
                    cmdOpen.Connection = conn
        query = "Select * From transaksipenjualan Where id_transaksi = '" & Trim(txtidt.Text) & "'"
        cmdOpen.CommandText = query
                    cmdOpen.ExecuteNonQuery()

                    Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
                    If drOpen.HasRows Then
            query = "update transaksipenjualan set " &
                 "nama_customer = '" & Trim(txtnc.Text) & "'," &
                        "id_barang = '" & Trim(cdib.Text) & "'," &
                        "nama_barang = '" & Trim(txtnb.Text) & "'," &
                        "harga_barang = '" & Trim(txthb.Text) & "'," &
                         "qty = '" & Trim(txtQtypenjualan.Text) & "'," &
                        "dibayarkan = '" & Trim(txtDIBAYARKANpenjualan.Text) & "'," &
                        "kembalian = '" & Trim(txtkembalian.Text) & "'," &
                        "tanggal_transaksi = '" & Format(tglTRANSAKSIpenjualan.Value, "yyyy-MM-dd") & "'," &
                        "id_pengguna = '" & Trim(lblid.Text) & "'," &
                        "where id_transaksi = '" & Trim(txtidt.Text) & "'"
        Else
            query = "INSERT INTO transaksipenjualan VALUES('" & Trim(txtidt.Text) & "', 
                    '" & Trim(txtnc.Text) & "',
                     '" & Trim(cdib.Text) & "',
                    '" & Trim(txtnb.Text) & "', 
                    '" & Trim(txthb.Text) & "',
                    '" & Trim(txtQtypenjualan.Text) & "', 
                    '" & Trim(txtDIBAYARKANpenjualan.Text) & "',
                    '" & Trim(txtkembalian.Text) & "',
                    '" & Format(tglTRANSAKSIpenjualan.Value, "yyyy-MM-dd") & "',
                     '" & Trim(lblid.Text) & " ')"
        End If

                    drOpen.Close()
                    cmdOpen.CommandText = query
                    cmdOpen.ExecuteNonQuery()
        'UPDATE STOK DI FORM MENU
        Using cnn = New SqlConnection
            cnn.ConnectionString = "Data Source = LAPTOP-0HATQUNE; Initial Catalog = Gramedia; Integrated Security = True"
            Using cmdX As New SqlCommand
                cnn.Open()
                cmdX.Connection = cnn
                query = "SELECT * FROM transaksipenjualan WHERE id_transaksi = '" & Trim(txtidt.Text) & "'"
                cmdX.CommandText = query
                cmdX.ExecuteNonQuery()

                Using drX As SqlDataReader = cmdX.ExecuteReader
                    If drX.HasRows Then
                        While drX.Read
                            cmdOpen.CommandText = "UPDATE transaksi_pembeliann SET sisa_stock = sisa_stock - " & drX("qty") &
                                                  "WHERE id_barang = '" & drX("id_barang") & "'"
                            cmdOpen.ExecuteNonQuery()
                        End While
                    End If
                    drX.Close()
                End Using
            End Using
        End Using
        conn.Close()
                    MessageBox.Show("Data Has Been Saved")

        clear()
        txtidt.Select()

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Hide()
        menuutama.Show()
    End Sub
End Class