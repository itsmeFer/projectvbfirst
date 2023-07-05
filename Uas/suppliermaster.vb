Imports System.ComponentModel
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class suppliermaster
    Public ds As DataSet
    Public rd As SqlDataReader
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Dim conn As New SqlConnection
    Dim query As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Sub kondisiawal()
        Call koneksi()
        da = New SqlDataAdapter("SELECT * FROM supplier ", conn)
        ds = New DataSet
        da.Fill(ds, "supplier")
        DataGridView1.DataSource = (ds.Tables("supplier"))

    End Sub
    Sub munculidsupplier()
        Call koneksi()
        cbsupplier.Items.Clear()
        cmd = New SqlCommand("SELECT * FROM supplier ", conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            cbsupplier.Items.Add(rd.Item(0))
        Loop
        Call kondisiawal()
    End Sub
    Public Sub koneksi()
        query = "Data Source = LAPTOP-0HATQUNE; Initial Catalog = Gramedia; Integrated Security = True"
        conn = New SqlConnection(query)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Sub clear()
        cbsupplier.Text = ""

        txtnama.Text = ""
        txtalamat.Text = ""
        txttelepon.Text = ""
        txtemail.Text = ""
        cbsupplier.Text = ""
        txtnamaauto.Text = ""
        txtalamatauto.Text = ""
        txtteleponauto.Text = ""
        txtemailauto.Text = ""
        DateTimePicker1.Value = Now.Date
        DateTimePicker2.Value = Now.Date
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

    Private Sub suppliermaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbltgl.Text = Today
        txtid.Text = Autocode("supplier", Now.Date)
        Call munculidsupplier()
        Call petugas()
        Call kondisiawal()
        Call petugas()
    End Sub
    Sub petugas()
        lblid.Text = menuutama.lblP.Text
        lbluser.Text = menuutama.lbluser.Text
        lblstatus.Text = menuutama.lbljabatan.Text
    End Sub
    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Me.Hide()
        menuutama.Show()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtid.Text = "" Then
            MessageBox.Show("Masukkan ID Supplier yang Benar!")
        Else
            Dim email As Boolean
            If email = Regex.IsMatch(txtemail.Text, "@gmail.com", RegexOptions.IgnoreCase) Then
                MsgBox("Masukkan Email Yang Benar")
            Else
                If Not (IsNumeric(txttelepon.Text)) Then
                MsgBox("Masukkan No HP Yang Benar")
            Else

                Dim cmdOpen As New SqlCommand
                    If conn.State = ConnectionState.Open Then conn.Close()
                    conn.Open()
                    cmdOpen.Connection = conn
                    query = "Select * From supplier Where id_supplier = '" & Trim(txtid.Text) & "'"
                    cmdOpen.CommandText = query
                    cmdOpen.ExecuteNonQuery()

                    Dim drOpen As SqlDataReader = cmdOpen.ExecuteReader
                    If drOpen.HasRows Then
                        query = "update customer set " &
                        "nama_supplier = '" & Trim(txtnama.Text) & "'," &
                        "alamat_customer = '" & Trim(txtalamat.Text) & "'," &
                        "telepon_customer = '" & Trim(txttelepon.Text) & "," &
                        "email_customer = '" & Trim(txtemail.Text) & "'," &
                        "tanggal_pembuatan = '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "'," &
                        "where id_supplier = '" & Trim(txtid.Text) & "'"
                    Else
                        query = "INSERT INTO supplier VALUES('" & Trim(txtid.Text) & "', 
                    '" & Trim(txtnama.Text) & "',
                    '" & Trim(txtalamat.Text) & "', 
                    " & Trim(txttelepon.Text) & ", 
                    '" & Trim(txtemail.Text) & "', 
                    '" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"
                    End If

                    drOpen.Close()
                    cmdOpen.CommandText = query
                    cmdOpen.ExecuteNonQuery()

                    conn.Close()
                    MessageBox.Show("Data Has Been Saved")
                    Call kondisiawal()
                    clear()
                    txtid.Select()
                End If
            End If
        End If
    End Sub

    Private Sub txtid_Click(sender As Object, e As EventArgs) Handles txtid.Click
        btnsimpan.Enabled = True
        btnedit.Enabled = False
        btnhapus.Enabled = False
    End Sub
    Private Sub cbsupplier_Click(sender As Object, e As EventArgs) Handles cbsupplier.Click
        clear()
        btnsimpan.Enabled = False
        btnedit.Enabled = True
        btnhapus.Enabled = True
    End Sub

    Private Sub cbsupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsupplier.SelectedIndexChanged
        cmd = New SqlCommand(" SELECT * FROM supplier WHERE id_supplier = '" & cbsupplier.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            txtnamaauto.Text = rd!nama_supplier
            txtalamatauto.Text = rd!alamat_supplier
            txtteleponauto.Text = rd!telepon_supplier
            txtemailauto.Text = rd!email_supplier
            DateTimePicker2.Text = rd!tanggal_pembuatan
            rd.Close()
            Call kondisiawal()
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If cbsupplier.Text = "" Then
            MessageBox.Show("Masukkan ID Supplier yang Benar!")
        Else
            Dim email As Boolean
            If email = Regex.IsMatch(txtemailauto.Text, "@gmail.com", RegexOptions.IgnoreCase) Then
                MsgBox("Masukkan Email Yang Benar")
            Else

                If Not (IsNumeric(txtteleponauto.Text)) Then
                    MsgBox("Masukkan No HP Yang Benar")
                Else
                    Call koneksi()
                    Dim editdata As String = "UPDATE supplier SET nama_supplier= '" & txtnamaauto.Text & "',alamat_supplier ='" & txtalamatauto.Text & "',telepon_supplier = '" & txtteleponauto.Text & "', email_supplier = '" & txtemailauto.Text & " ', tanggal_pembuatan = '" & Format(DateTimePicker2.Value, "yyyy-MM-dd") & "' WHERE id_supplier = '" & cbsupplier.Text & "'"
                    cmd = New SqlCommand(editdata, conn)
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Edit!")
                    Call kondisiawal()
                End If
            End If
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If txtemailauto.Text = "" Then
            MessageBox.Show("Masukkan ID Supplier yang Benar!")
        Else
            If txtnamaauto.Text = "" Then
            Else

                Call koneksi()
                Dim editdata As String = "delete supplier WHERE id_supplier = '" & cbsupplier.Text & "'"
                cmd = New SqlCommand(editdata, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Hapus!")
                clear()
                Call kondisiawal()
            End If
        End If
    End Sub



    Private Sub txtnama_Click(sender As Object, e As EventArgs) Handles txtnama.Click
        clear()
        btnsimpan.Enabled = True
        btnedit.Enabled = False
        btnhapus.Enabled = False
    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub txtid_QueryAccessibilityHelp(sender As Object, e As QueryAccessibilityHelpEventArgs) Handles txtid.QueryAccessibilityHelp

    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged

    End Sub
End Class
