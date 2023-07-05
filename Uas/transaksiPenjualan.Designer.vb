<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class transaksiPenjualan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksiPenjualan))
        Me.dgvpenjualan = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtnc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtidt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHASILQTYpenjualan = New System.Windows.Forms.Button()
        Me.txtHASILQTYpenjualan = New System.Windows.Forms.TextBox()
        Me.txtQtypenjualan = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblSUBTOTALpenjualan = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblid = New System.Windows.Forms.TextBox()
        Me.txthb = New System.Windows.Forms.TextBox()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnb = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cdib = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbljam = New System.Windows.Forms.Label()
        Me.lbltgl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.txtkembalian = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tglTRANSAKSIpenjualan = New System.Windows.Forms.DateTimePicker()
        Me.txtDIBAYARKANpenjualan = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hb = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.dgvpenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvpenjualan
        '
        Me.dgvpenjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvpenjualan.BackgroundColor = System.Drawing.Color.Indigo
        Me.dgvpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpenjualan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.hb, Me.qty, Me.subh})
        Me.dgvpenjualan.Location = New System.Drawing.Point(39, 272)
        Me.dgvpenjualan.Name = "dgvpenjualan"
        Me.dgvpenjualan.RowHeadersWidth = 51
        Me.dgvpenjualan.RowTemplate.Height = 24
        Me.dgvpenjualan.Size = New System.Drawing.Size(1234, 546)
        Me.dgvpenjualan.TabIndex = 61
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.txtnc)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtidt)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnHASILQTYpenjualan)
        Me.Panel2.Controls.Add(Me.txtHASILQTYpenjualan)
        Me.Panel2.Controls.Add(Me.txtQtypenjualan)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Location = New System.Drawing.Point(1279, 362)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(494, 334)
        Me.Panel2.TabIndex = 60
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(28, 186)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(444, 112)
        Me.Button4.TabIndex = 108
        Me.Button4.Text = "Input"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtnc
        '
        Me.txtnc.Location = New System.Drawing.Point(195, 58)
        Me.txtnc.Name = "txtnc"
        Me.txtnc.Size = New System.Drawing.Size(193, 22)
        Me.txtnc.TabIndex = 107
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(18, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 25)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "Nama Customer"
        '
        'txtidt
        '
        Me.txtidt.Enabled = False
        Me.txtidt.Location = New System.Drawing.Point(195, 18)
        Me.txtidt.Name = "txtidt"
        Me.txtidt.Size = New System.Drawing.Size(193, 22)
        Me.txtidt.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(56, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "ID Transaksi"
        '
        'btnHASILQTYpenjualan
        '
        Me.btnHASILQTYpenjualan.Location = New System.Drawing.Point(405, 92)
        Me.btnHASILQTYpenjualan.Name = "btnHASILQTYpenjualan"
        Me.btnHASILQTYpenjualan.Size = New System.Drawing.Size(75, 32)
        Me.btnHASILQTYpenjualan.TabIndex = 39
        Me.btnHASILQTYpenjualan.Text = "Hitung"
        Me.btnHASILQTYpenjualan.UseVisualStyleBackColor = True
        '
        'txtHASILQTYpenjualan
        '
        Me.txtHASILQTYpenjualan.Enabled = False
        Me.txtHASILQTYpenjualan.Location = New System.Drawing.Point(274, 98)
        Me.txtHASILQTYpenjualan.Name = "txtHASILQTYpenjualan"
        Me.txtHASILQTYpenjualan.Size = New System.Drawing.Size(114, 22)
        Me.txtHASILQTYpenjualan.TabIndex = 38
        '
        'txtQtypenjualan
        '
        Me.txtQtypenjualan.Location = New System.Drawing.Point(195, 97)
        Me.txtQtypenjualan.Name = "txtQtypenjualan"
        Me.txtQtypenjualan.Size = New System.Drawing.Size(67, 22)
        Me.txtQtypenjualan.TabIndex = 31
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label25.Location = New System.Drawing.Point(121, 94)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 25)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Qty"
        '
        'lblSUBTOTALpenjualan
        '
        Me.lblSUBTOTALpenjualan.AutoSize = True
        Me.lblSUBTOTALpenjualan.Font = New System.Drawing.Font("OCR-B 10 BT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSUBTOTALpenjualan.ForeColor = System.Drawing.Color.Black
        Me.lblSUBTOTALpenjualan.Location = New System.Drawing.Point(1470, 304)
        Me.lblSUBTOTALpenjualan.Name = "lblSUBTOTALpenjualan"
        Me.lblSUBTOTALpenjualan.Size = New System.Drawing.Size(166, 29)
        Me.lblSUBTOTALpenjualan.TabIndex = 35
        Me.lblSUBTOTALpenjualan.Text = "Sub Total"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(1300, 295)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(168, 39)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "Sub Total :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel1.Controls.Add(Me.lblid)
        Me.Panel1.Controls.Add(Me.txthb)
        Me.Panel1.Controls.Add(Me.lbluser)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtnb)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.cdib)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Location = New System.Drawing.Point(39, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1734, 68)
        Me.Panel1.TabIndex = 59
        '
        'lblid
        '
        Me.lblid.Enabled = False
        Me.lblid.Location = New System.Drawing.Point(160, 28)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(100, 22)
        Me.lblid.TabIndex = 103
        '
        'txthb
        '
        Me.txthb.Enabled = False
        Me.txthb.Location = New System.Drawing.Point(1471, 29)
        Me.txthb.Name = "txthb"
        Me.txthb.Size = New System.Drawing.Size(157, 22)
        Me.txthb.TabIndex = 29
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.GhostWhite
        Me.lbluser.Location = New System.Drawing.Point(392, 25)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(61, 25)
        Me.lbluser.TabIndex = 102
        Me.lbluser.Text = "usern"
        Me.lbluser.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Enabled = False
        Me.Label24.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label24.Location = New System.Drawing.Point(1328, 27)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 25)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Harga Barang"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label12.Location = New System.Drawing.Point(17, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 25)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "ID Pengguna :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtnb
        '
        Me.txtnb.Enabled = False
        Me.txtnb.Location = New System.Drawing.Point(1182, 28)
        Me.txtnb.Name = "txtnb"
        Me.txtnb.Size = New System.Drawing.Size(125, 22)
        Me.txtnb.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Enabled = False
        Me.Label23.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label23.Location = New System.Drawing.Point(1039, 26)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(130, 25)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "Nama Barang"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label11.Location = New System.Drawing.Point(268, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 25)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Username : "
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cdib
        '
        Me.cdib.FormattingEnabled = True
        Me.cdib.Location = New System.Drawing.Point(895, 26)
        Me.cdib.Name = "cdib"
        Me.cdib.Size = New System.Drawing.Size(121, 24)
        Me.cdib.TabIndex = 25
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Enabled = False
        Me.Label22.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label22.Location = New System.Drawing.Point(779, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(97, 25)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "ID Barang"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Indigo
        Me.Label21.Location = New System.Drawing.Point(797, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(202, 46)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "Gramedia"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Indigo
        Me.Label19.Location = New System.Drawing.Point(802, 102)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(190, 25)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Transaksi Penjualan"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Tai Le", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(92, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(1611, 35)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "_________________________________________________________________________________" &
    "____________________________________________________"
        '
        'lbljam
        '
        Me.lbljam.AutoSize = True
        Me.lbljam.Font = New System.Drawing.Font("OCR-B 10 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbljam.ForeColor = System.Drawing.Color.Indigo
        Me.lbljam.Location = New System.Drawing.Point(403, 124)
        Me.lbljam.Name = "lbljam"
        Me.lbljam.Size = New System.Drawing.Size(46, 21)
        Me.lbljam.TabIndex = 64
        Me.lbljam.Text = "jam"
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.Font = New System.Drawing.Font("OCR-A BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltgl.ForeColor = System.Drawing.Color.Indigo
        Me.lbltgl.Location = New System.Drawing.Point(1395, 124)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(94, 22)
        Me.lbltgl.TabIndex = 63
        Me.lbltgl.Text = "tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(282, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 25)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Jam : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Indigo
        Me.Label2.Location = New System.Drawing.Point(1258, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 25)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Tanggal : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(1475, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 45)
        Me.Button3.TabIndex = 69
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(1554, 53)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 27)
        Me.Button2.TabIndex = 68
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1612, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 36)
        Me.Button1.TabIndex = 67
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(405, 50)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(75, 32)
        Me.btnhitung.TabIndex = 118
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'txtkembalian
        '
        Me.txtkembalian.Enabled = False
        Me.txtkembalian.Location = New System.Drawing.Point(195, 56)
        Me.txtkembalian.Name = "txtkembalian"
        Me.txtkembalian.Size = New System.Drawing.Size(193, 22)
        Me.txtkembalian.TabIndex = 117
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(67, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 25)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "Kembalian"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label28.Location = New System.Drawing.Point(3, 109)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(166, 25)
        Me.Label28.TabIndex = 115
        Me.Label28.Text = "Tanggal Transaksi"
        '
        'tglTRANSAKSIpenjualan
        '
        Me.tglTRANSAKSIpenjualan.Font = New System.Drawing.Font("OCR-B 10 BT", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglTRANSAKSIpenjualan.Location = New System.Drawing.Point(195, 109)
        Me.tglTRANSAKSIpenjualan.Name = "tglTRANSAKSIpenjualan"
        Me.tglTRANSAKSIpenjualan.Size = New System.Drawing.Size(207, 23)
        Me.tglTRANSAKSIpenjualan.TabIndex = 114
        '
        'txtDIBAYARKANpenjualan
        '
        Me.txtDIBAYARKANpenjualan.Location = New System.Drawing.Point(195, 16)
        Me.txtDIBAYARKANpenjualan.Name = "txtDIBAYARKANpenjualan"
        Me.txtDIBAYARKANpenjualan.Size = New System.Drawing.Size(193, 22)
        Me.txtDIBAYARKANpenjualan.TabIndex = 113
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label26.Location = New System.Drawing.Point(60, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(111, 25)
        Me.Label26.TabIndex = 112
        Me.Label26.Text = "Dibayarkan"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumPurple
        Me.Panel3.Controls.Add(Me.btnback)
        Me.Panel3.Controls.Add(Me.btnclear)
        Me.Panel3.Controls.Add(Me.btnsimpan)
        Me.Panel3.Controls.Add(Me.tglTRANSAKSIpenjualan)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.btnhitung)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.txtkembalian)
        Me.Panel3.Controls.Add(Me.txtDIBAYARKANpenjualan)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(1279, 702)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(494, 334)
        Me.Panel3.TabIndex = 109
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(28, 186)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(108, 126)
        Me.btnsimpan.TabIndex = 108
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Barang"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'hb
        '
        Me.hb.HeaderText = "Harga Barang"
        Me.hb.MinimumWidth = 6
        Me.hb.Name = "hb"
        '
        'qty
        '
        Me.qty.HeaderText = "Qty"
        Me.qty.MinimumWidth = 6
        Me.qty.Name = "qty"
        '
        'subh
        '
        Me.subh.HeaderText = "Sub Harga"
        Me.subh.MinimumWidth = 6
        Me.subh.Name = "subh"
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(364, 186)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(108, 126)
        Me.btnclear.TabIndex = 119
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(196, 186)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(108, 126)
        Me.btnback.TabIndex = 120
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'transaksiPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1909, 1102)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbljam)
        Me.Controls.Add(Me.lbltgl)
        Me.Controls.Add(Me.dgvpenjualan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblSUBTOTALpenjualan)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "transaksiPenjualan"
        Me.Text = "masterstock"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvpenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvpenjualan As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnHASILQTYpenjualan As Button
    Friend WithEvents txtHASILQTYpenjualan As TextBox
    Friend WithEvents lblSUBTOTALpenjualan As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtQtypenjualan As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txthb As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txtnb As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents cdib As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbljam As Label
    Friend WithEvents lbltgl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblid As TextBox
    Friend WithEvents lbluser As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtidt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents txtnc As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnhitung As Button
    Friend WithEvents txtkembalian As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents tglTRANSAKSIpenjualan As DateTimePicker
    Friend WithEvents txtDIBAYARKANpenjualan As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnsimpan As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents hb As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents subh As DataGridViewTextBoxColumn
    Friend WithEvents btnclear As Button
    Friend WithEvents btnback As Button
End Class
