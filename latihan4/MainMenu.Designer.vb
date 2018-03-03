<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelFormMenu = New System.Windows.Forms.Panel()
        Me.PanelKonten = New System.Windows.Forms.Panel()
        Me.PanelKontenDashboard = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lblStokMinuman = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.lblStokRoti = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblStokBarang = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblPenjualan = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblDataKaryawan = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDataBarang = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelKontenKaryawan = New System.Windows.Forms.Panel()
        Me.tabelDataKaryawan = New System.Windows.Forms.DataGridView()
        Me.IdkaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelkaryawanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KaryawanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TokoRotiDataSet1 = New latihan4.TokoRotiDataSet()
        Me.PanelLihatFoto = New System.Windows.Forms.Panel()
        Me.btnLihatFoto = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.PanelFotoKaryawan = New System.Windows.Forms.Panel()
        Me.fotoBox = New System.Windows.Forms.PictureBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.PanelHeaderKaryawan = New System.Windows.Forms.Panel()
        Me.btnTambahKaryawan = New System.Windows.Forms.Button()
        Me.btnEditKaryawan = New System.Windows.Forms.Button()
        Me.btnHapusKaryawan = New System.Windows.Forms.Button()
        Me.txCariKaryawan = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.PanelKontenKasir = New System.Windows.Forms.Panel()
        Me.tabelDataKasir = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kode_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PanelFooterKasir = New System.Windows.Forms.Panel()
        Me.btnBayarKasir = New System.Windows.Forms.Button()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txDiskonBelanja = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txKembalian = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txBayar = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txTotal = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PanelHeaderKasir = New System.Windows.Forms.Panel()
        Me.btnCariKodeBarang = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txDiskon = New System.Windows.Forms.TextBox()
        Me.txTotalBelanja = New System.Windows.Forms.TextBox()
        Me.txQty = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txNamaBarang = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txKodeBarang = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tglKasir = New System.Windows.Forms.DateTimePicker()
        Me.txNoStruk = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txStokBarang = New System.Windows.Forms.TextBox()
        Me.txHargaBarang = New System.Windows.Forms.TextBox()
        Me.txKategori = New System.Windows.Forms.TextBox()
        Me.PanelKontenBarang = New System.Windows.Forms.Panel()
        Me.tabelDataBarang = New System.Windows.Forms.DataGridView()
        Me.KodebarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodekategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LihatBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TokoRotiDataSet = New latihan4.TokoRotiDataSet()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.PanelHeaderBarang = New System.Windows.Forms.Panel()
        Me.btnTambahBarang = New System.Windows.Forms.Button()
        Me.btnEditBarang = New System.Windows.Forms.Button()
        Me.btnHapusBarang = New System.Windows.Forms.Button()
        Me.txCariBarang = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.marginTop = New System.Windows.Forms.Label()
        Me.marginBottom = New System.Windows.Forms.Label()
        Me.marginLeft = New System.Windows.Forms.Label()
        Me.marginRight = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LblKeteranganMenu = New System.Windows.Forms.Label()
        Me.LblMenu = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.PanelSideBar = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnKaryawan = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBarang = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnKasir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblJudulApp = New System.Windows.Forms.Label()
        Me.BarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BarangTableAdapter = New latihan4.TokoRotiDataSetTableAdapters.barangTableAdapter()
        Me.HeaderpenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Header_penjualanTableAdapter = New latihan4.TokoRotiDataSetTableAdapters.header_penjualanTableAdapter()
        Me.PenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PenjualanTableAdapter = New latihan4.TokoRotiDataSetTableAdapters.penjualanTableAdapter()
        Me.LihatBarangTableAdapter = New latihan4.TokoRotiDataSetTableAdapters.lihatBarangTableAdapter()
        Me.TableAdapterManager = New latihan4.TokoRotiDataSetTableAdapters.TableAdapterManager()
        Me.KaryawanTableAdapter = New latihan4.TokoRotiDataSetTableAdapters.karyawanTableAdapter()
        Me.PanelFormMenu.SuspendLayout()
        Me.PanelKonten.SuspendLayout()
        Me.PanelKontenDashboard.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PanelKontenKaryawan.SuspendLayout()
        CType(Me.tabelDataKaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokoRotiDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelLihatFoto.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.PanelFotoKaryawan.SuspendLayout()
        CType(Me.fotoBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderKaryawan.SuspendLayout()
        Me.PanelKontenKasir.SuspendLayout()
        CType(Me.tabelDataKasir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelFooterKasir.SuspendLayout()
        Me.PanelHeaderKasir.SuspendLayout()
        Me.PanelKontenBarang.SuspendLayout()
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokoRotiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHeaderBarang.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.PanelSideBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaderpenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelFormMenu
        '
        Me.PanelFormMenu.Controls.Add(Me.PanelKonten)
        Me.PanelFormMenu.Controls.Add(Me.PanelHeader)
        Me.PanelFormMenu.Controls.Add(Me.PanelSideBar)
        Me.PanelFormMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelFormMenu.Name = "PanelFormMenu"
        Me.PanelFormMenu.Size = New System.Drawing.Size(870, 670)
        Me.PanelFormMenu.TabIndex = 0
        '
        'PanelKonten
        '
        Me.PanelKonten.Controls.Add(Me.PanelKontenDashboard)
        Me.PanelKonten.Controls.Add(Me.PanelKontenKaryawan)
        Me.PanelKonten.Controls.Add(Me.PanelKontenKasir)
        Me.PanelKonten.Controls.Add(Me.PanelKontenBarang)
        Me.PanelKonten.Controls.Add(Me.marginTop)
        Me.PanelKonten.Controls.Add(Me.marginBottom)
        Me.PanelKonten.Controls.Add(Me.marginLeft)
        Me.PanelKonten.Controls.Add(Me.marginRight)
        Me.PanelKonten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKonten.Location = New System.Drawing.Point(200, 100)
        Me.PanelKonten.Name = "PanelKonten"
        Me.PanelKonten.Size = New System.Drawing.Size(670, 570)
        Me.PanelKonten.TabIndex = 0
        '
        'PanelKontenDashboard
        '
        Me.PanelKontenDashboard.Controls.Add(Me.Panel3)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel8)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel7)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel6)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel5)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel4)
        Me.PanelKontenDashboard.Controls.Add(Me.Panel2)
        Me.PanelKontenDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenDashboard.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenDashboard.Name = "PanelKontenDashboard"
        Me.PanelKontenDashboard.Size = New System.Drawing.Size(650, 550)
        Me.PanelKontenDashboard.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label38)
        Me.Panel3.Controls.Add(Me.Label39)
        Me.Panel3.Location = New System.Drawing.Point(40, 478)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(560, 60)
        Me.Panel3.TabIndex = 1
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.SystemColors.Control
        Me.Label38.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(0, 30)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(560, 30)
        Me.Label38.TabIndex = 5
        Me.Label38.Text = "√ Lezat  √ Sehat  √ Terjangkau"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.Control
        Me.Label39.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label39.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(0, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(560, 30)
        Me.Label39.TabIndex = 4
        Me.Label39.Text = "Toko Roti Terbaik Di Indonesia"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.White
        Me.Panel8.Controls.Add(Me.Label44)
        Me.Panel8.Controls.Add(Me.lblStokMinuman)
        Me.Panel8.Controls.Add(Me.Label46)
        Me.Panel8.Location = New System.Drawing.Point(40, 127)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(179, 100)
        Me.Panel8.TabIndex = 3
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.White
        Me.Label44.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label44.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(30, 64)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(149, 36)
        Me.Label44.TabIndex = 5
        Me.Label44.Text = "Stok Minuman"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStokMinuman
        '
        Me.lblStokMinuman.BackColor = System.Drawing.Color.White
        Me.lblStokMinuman.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStokMinuman.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokMinuman.ForeColor = System.Drawing.Color.Black
        Me.lblStokMinuman.Location = New System.Drawing.Point(30, 0)
        Me.lblStokMinuman.Name = "lblStokMinuman"
        Me.lblStokMinuman.Size = New System.Drawing.Size(149, 64)
        Me.lblStokMinuman.TabIndex = 4
        Me.lblStokMinuman.Text = "100"
        Me.lblStokMinuman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label46.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(0, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(30, 100)
        Me.Label46.TabIndex = 7
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.Label41)
        Me.Panel7.Controls.Add(Me.lblStokRoti)
        Me.Panel7.Controls.Add(Me.Label43)
        Me.Panel7.Location = New System.Drawing.Point(225, 127)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(146, 100)
        Me.Panel7.TabIndex = 2
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.White
        Me.Label41.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(30, 64)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(116, 36)
        Me.Label41.TabIndex = 5
        Me.Label41.Text = "Stok Roti"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStokRoti
        '
        Me.lblStokRoti.BackColor = System.Drawing.Color.White
        Me.lblStokRoti.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStokRoti.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokRoti.ForeColor = System.Drawing.Color.Black
        Me.lblStokRoti.Location = New System.Drawing.Point(30, 0)
        Me.lblStokRoti.Name = "lblStokRoti"
        Me.lblStokRoti.Size = New System.Drawing.Size(116, 64)
        Me.lblStokRoti.TabIndex = 4
        Me.lblStokRoti.Text = "100"
        Me.lblStokRoti.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label43
        '
        Me.Label43.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label43.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.White
        Me.Label43.Location = New System.Drawing.Point(0, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(30, 100)
        Me.Label43.TabIndex = 7
        Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Controls.Add(Me.Label35)
        Me.Panel6.Controls.Add(Me.lblStokBarang)
        Me.Panel6.Controls.Add(Me.Label37)
        Me.Panel6.Location = New System.Drawing.Point(377, 127)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(223, 100)
        Me.Panel6.TabIndex = 0
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label35.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(30, 64)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(193, 36)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Stok Barang"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStokBarang
        '
        Me.lblStokBarang.BackColor = System.Drawing.Color.White
        Me.lblStokBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblStokBarang.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStokBarang.ForeColor = System.Drawing.Color.Black
        Me.lblStokBarang.Location = New System.Drawing.Point(30, 0)
        Me.lblStokBarang.Name = "lblStokBarang"
        Me.lblStokBarang.Size = New System.Drawing.Size(193, 64)
        Me.lblStokBarang.TabIndex = 4
        Me.lblStokBarang.Text = "100"
        Me.lblStokBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label37
        '
        Me.Label37.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(0, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(30, 100)
        Me.Label37.TabIndex = 7
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.Label32)
        Me.Panel5.Controls.Add(Me.lblPenjualan)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Location = New System.Drawing.Point(468, 21)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(132, 100)
        Me.Panel5.TabIndex = 0
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label32.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(30, 64)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(102, 36)
        Me.Label32.TabIndex = 5
        Me.Label32.Text = "Penjualan Hari Ini"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPenjualan
        '
        Me.lblPenjualan.BackColor = System.Drawing.Color.White
        Me.lblPenjualan.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPenjualan.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPenjualan.ForeColor = System.Drawing.Color.Black
        Me.lblPenjualan.Location = New System.Drawing.Point(30, 0)
        Me.lblPenjualan.Name = "lblPenjualan"
        Me.lblPenjualan.Size = New System.Drawing.Size(102, 64)
        Me.lblPenjualan.TabIndex = 4
        Me.lblPenjualan.Text = "100"
        Me.lblPenjualan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label34.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(0, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(30, 100)
        Me.Label34.TabIndex = 7
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.lblDataKaryawan)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Location = New System.Drawing.Point(296, 21)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(166, 100)
        Me.Panel4.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(30, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 36)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Data Karyawan"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDataKaryawan
        '
        Me.lblDataKaryawan.BackColor = System.Drawing.Color.White
        Me.lblDataKaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDataKaryawan.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataKaryawan.ForeColor = System.Drawing.Color.Black
        Me.lblDataKaryawan.Location = New System.Drawing.Point(30, 0)
        Me.lblDataKaryawan.Name = "lblDataKaryawan"
        Me.lblDataKaryawan.Size = New System.Drawing.Size(136, 64)
        Me.lblDataKaryawan.TabIndex = 4
        Me.lblDataKaryawan.Text = "100"
        Me.lblDataKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label31.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(0, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(30, 100)
        Me.Label31.TabIndex = 7
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lblDataBarang)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(40, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(250, 100)
        Me.Panel2.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(30, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(220, 36)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Data Barang"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDataBarang
        '
        Me.lblDataBarang.BackColor = System.Drawing.Color.White
        Me.lblDataBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDataBarang.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataBarang.ForeColor = System.Drawing.Color.Black
        Me.lblDataBarang.Location = New System.Drawing.Point(30, 0)
        Me.lblDataBarang.Name = "lblDataBarang"
        Me.lblDataBarang.Size = New System.Drawing.Size(220, 64)
        Me.lblDataBarang.TabIndex = 4
        Me.lblDataBarang.Text = "100"
        Me.lblDataBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 100)
        Me.Label9.TabIndex = 7
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelKontenKaryawan
        '
        Me.PanelKontenKaryawan.Controls.Add(Me.tabelDataKaryawan)
        Me.PanelKontenKaryawan.Controls.Add(Me.PanelLihatFoto)
        Me.PanelKontenKaryawan.Controls.Add(Me.PanelFotoKaryawan)
        Me.PanelKontenKaryawan.Controls.Add(Me.Label40)
        Me.PanelKontenKaryawan.Controls.Add(Me.PanelHeaderKaryawan)
        Me.PanelKontenKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenKaryawan.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenKaryawan.Name = "PanelKontenKaryawan"
        Me.PanelKontenKaryawan.Size = New System.Drawing.Size(650, 550)
        Me.PanelKontenKaryawan.TabIndex = 15
        '
        'tabelDataKaryawan
        '
        Me.tabelDataKaryawan.AllowUserToAddRows = False
        Me.tabelDataKaryawan.AllowUserToDeleteRows = False
        Me.tabelDataKaryawan.AllowUserToOrderColumns = True
        Me.tabelDataKaryawan.AutoGenerateColumns = False
        Me.tabelDataKaryawan.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataKaryawan.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdkaryawanDataGridViewTextBoxColumn, Me.NamakaryawanDataGridViewTextBoxColumn, Me.LevelkaryawanDataGridViewTextBoxColumn, Me.FotoDataGridViewImageColumn, Me.PasswordDataGridViewTextBoxColumn})
        Me.tabelDataKaryawan.DataSource = Me.KaryawanBindingSource
        Me.tabelDataKaryawan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataKaryawan.Location = New System.Drawing.Point(0, 70)
        Me.tabelDataKaryawan.MultiSelect = False
        Me.tabelDataKaryawan.Name = "tabelDataKaryawan"
        Me.tabelDataKaryawan.ReadOnly = True
        Me.tabelDataKaryawan.RowHeadersVisible = False
        Me.tabelDataKaryawan.Size = New System.Drawing.Size(650, 255)
        Me.tabelDataKaryawan.TabIndex = 8
        '
        'IdkaryawanDataGridViewTextBoxColumn
        '
        Me.IdkaryawanDataGridViewTextBoxColumn.DataPropertyName = "id_karyawan"
        Me.IdkaryawanDataGridViewTextBoxColumn.HeaderText = "ID Karyawan"
        Me.IdkaryawanDataGridViewTextBoxColumn.Name = "IdkaryawanDataGridViewTextBoxColumn"
        Me.IdkaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamakaryawanDataGridViewTextBoxColumn
        '
        Me.NamakaryawanDataGridViewTextBoxColumn.DataPropertyName = "nama_karyawan"
        Me.NamakaryawanDataGridViewTextBoxColumn.HeaderText = "Nama"
        Me.NamakaryawanDataGridViewTextBoxColumn.Name = "NamakaryawanDataGridViewTextBoxColumn"
        Me.NamakaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LevelkaryawanDataGridViewTextBoxColumn
        '
        Me.LevelkaryawanDataGridViewTextBoxColumn.DataPropertyName = "level_karyawan"
        Me.LevelkaryawanDataGridViewTextBoxColumn.HeaderText = "Level"
        Me.LevelkaryawanDataGridViewTextBoxColumn.Name = "LevelkaryawanDataGridViewTextBoxColumn"
        Me.LevelkaryawanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FotoDataGridViewImageColumn
        '
        Me.FotoDataGridViewImageColumn.DataPropertyName = "foto"
        Me.FotoDataGridViewImageColumn.HeaderText = "foto"
        Me.FotoDataGridViewImageColumn.Name = "FotoDataGridViewImageColumn"
        Me.FotoDataGridViewImageColumn.ReadOnly = True
        Me.FotoDataGridViewImageColumn.Visible = False
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        Me.PasswordDataGridViewTextBoxColumn.Visible = False
        '
        'KaryawanBindingSource
        '
        Me.KaryawanBindingSource.DataMember = "karyawan"
        Me.KaryawanBindingSource.DataSource = Me.TokoRotiDataSet1
        '
        'TokoRotiDataSet1
        '
        Me.TokoRotiDataSet1.DataSetName = "TokoRotiDataSet"
        Me.TokoRotiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PanelLihatFoto
        '
        Me.PanelLihatFoto.Controls.Add(Me.btnLihatFoto)
        Me.PanelLihatFoto.Controls.Add(Me.Panel10)
        Me.PanelLihatFoto.Controls.Add(Me.Panel9)
        Me.PanelLihatFoto.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelLihatFoto.Location = New System.Drawing.Point(0, 325)
        Me.PanelLihatFoto.Name = "PanelLihatFoto"
        Me.PanelLihatFoto.Size = New System.Drawing.Size(650, 15)
        Me.PanelLihatFoto.TabIndex = 10
        '
        'btnLihatFoto
        '
        Me.btnLihatFoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLihatFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLihatFoto.FlatAppearance.BorderSize = 0
        Me.btnLihatFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLihatFoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihatFoto.ForeColor = System.Drawing.Color.White
        Me.btnLihatFoto.Location = New System.Drawing.Point(315, 0)
        Me.btnLihatFoto.Name = "btnLihatFoto"
        Me.btnLihatFoto.Size = New System.Drawing.Size(20, 15)
        Me.btnLihatFoto.TabIndex = 11
        Me.btnLihatFoto.Text = "^"
        Me.btnLihatFoto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnLihatFoto.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label52)
        Me.Panel10.Controls.Add(Me.Label53)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(335, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(315, 15)
        Me.Panel10.TabIndex = 18
        '
        'Label52
        '
        Me.Label52.BackColor = System.Drawing.Color.White
        Me.Label52.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label52.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.White
        Me.Label52.Location = New System.Drawing.Point(0, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(315, 8)
        Me.Label52.TabIndex = 15
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label53
        '
        Me.Label53.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label53.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(0, 8)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(315, 7)
        Me.Label53.TabIndex = 16
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label55)
        Me.Panel9.Controls.Add(Me.Label56)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(315, 15)
        Me.Panel9.TabIndex = 17
        '
        'Label55
        '
        Me.Label55.BackColor = System.Drawing.Color.White
        Me.Label55.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label55.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.White
        Me.Label55.Location = New System.Drawing.Point(0, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(315, 8)
        Me.Label55.TabIndex = 15
        Me.Label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label56
        '
        Me.Label56.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label56.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.White
        Me.Label56.Location = New System.Drawing.Point(0, 8)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(315, 7)
        Me.Label56.TabIndex = 16
        Me.Label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelFotoKaryawan
        '
        Me.PanelFotoKaryawan.Controls.Add(Me.fotoBox)
        Me.PanelFotoKaryawan.Controls.Add(Me.Label50)
        Me.PanelFotoKaryawan.Controls.Add(Me.Label51)
        Me.PanelFotoKaryawan.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFotoKaryawan.Location = New System.Drawing.Point(0, 340)
        Me.PanelFotoKaryawan.Name = "PanelFotoKaryawan"
        Me.PanelFotoKaryawan.Size = New System.Drawing.Size(650, 210)
        Me.PanelFotoKaryawan.TabIndex = 12
        '
        'fotoBox
        '
        Me.fotoBox.BackColor = System.Drawing.Color.White
        Me.fotoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.fotoBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.fotoBox.Location = New System.Drawing.Point(100, 0)
        Me.fotoBox.Name = "fotoBox"
        Me.fotoBox.Size = New System.Drawing.Size(450, 210)
        Me.fotoBox.TabIndex = 12
        Me.fotoBox.TabStop = False
        '
        'Label50
        '
        Me.Label50.BackColor = System.Drawing.Color.White
        Me.Label50.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label50.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.White
        Me.Label50.Location = New System.Drawing.Point(0, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(100, 210)
        Me.Label50.TabIndex = 13
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label51
        '
        Me.Label51.BackColor = System.Drawing.Color.White
        Me.Label51.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label51.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.White
        Me.Label51.Location = New System.Drawing.Point(550, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(100, 210)
        Me.Label51.TabIndex = 14
        Me.Label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label40
        '
        Me.Label40.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label40.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(0, 60)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(650, 10)
        Me.Label40.TabIndex = 9
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeaderKaryawan
        '
        Me.PanelHeaderKaryawan.Controls.Add(Me.btnTambahKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.btnEditKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.btnHapusKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.txCariKaryawan)
        Me.PanelHeaderKaryawan.Controls.Add(Me.Label47)
        Me.PanelHeaderKaryawan.Controls.Add(Me.Label48)
        Me.PanelHeaderKaryawan.Controls.Add(Me.Label49)
        Me.PanelHeaderKaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderKaryawan.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderKaryawan.Name = "PanelHeaderKaryawan"
        Me.PanelHeaderKaryawan.Size = New System.Drawing.Size(650, 60)
        Me.PanelHeaderKaryawan.TabIndex = 2
        '
        'btnTambahKaryawan
        '
        Me.btnTambahKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnTambahKaryawan.FlatAppearance.BorderSize = 0
        Me.btnTambahKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnTambahKaryawan.Location = New System.Drawing.Point(377, 10)
        Me.btnTambahKaryawan.Name = "btnTambahKaryawan"
        Me.btnTambahKaryawan.Size = New System.Drawing.Size(85, 40)
        Me.btnTambahKaryawan.TabIndex = 11
        Me.btnTambahKaryawan.Text = "Tambah"
        Me.btnTambahKaryawan.UseVisualStyleBackColor = False
        '
        'btnEditKaryawan
        '
        Me.btnEditKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnEditKaryawan.FlatAppearance.BorderSize = 0
        Me.btnEditKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnEditKaryawan.Location = New System.Drawing.Point(468, 10)
        Me.btnEditKaryawan.Name = "btnEditKaryawan"
        Me.btnEditKaryawan.Size = New System.Drawing.Size(85, 40)
        Me.btnEditKaryawan.TabIndex = 11
        Me.btnEditKaryawan.Text = "Edit"
        Me.btnEditKaryawan.UseVisualStyleBackColor = False
        '
        'btnHapusKaryawan
        '
        Me.btnHapusKaryawan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnHapusKaryawan.FlatAppearance.BorderSize = 0
        Me.btnHapusKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusKaryawan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnHapusKaryawan.Location = New System.Drawing.Point(559, 10)
        Me.btnHapusKaryawan.Name = "btnHapusKaryawan"
        Me.btnHapusKaryawan.Size = New System.Drawing.Size(85, 40)
        Me.btnHapusKaryawan.TabIndex = 11
        Me.btnHapusKaryawan.Text = "Hapus"
        Me.btnHapusKaryawan.UseVisualStyleBackColor = False
        '
        'txCariKaryawan
        '
        Me.txCariKaryawan.Location = New System.Drawing.Point(46, 20)
        Me.txCariKaryawan.Name = "txCariKaryawan"
        Me.txCariKaryawan.Size = New System.Drawing.Size(225, 20)
        Me.txCariKaryawan.TabIndex = 6
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.White
        Me.Label47.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(9, 21)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(31, 17)
        Me.Label47.TabIndex = 5
        Me.Label47.Text = "Cari"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.SystemColors.Control
        Me.Label48.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label48.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(0, 60)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(650, 1)
        Me.Label48.TabIndex = 10
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label49
        '
        Me.Label49.BackColor = System.Drawing.Color.White
        Me.Label49.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label49.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(0, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(650, 60)
        Me.Label49.TabIndex = 4
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelKontenKasir
        '
        Me.PanelKontenKasir.Controls.Add(Me.tabelDataKasir)
        Me.PanelKontenKasir.Controls.Add(Me.Label23)
        Me.PanelKontenKasir.Controls.Add(Me.PanelFooterKasir)
        Me.PanelKontenKasir.Controls.Add(Me.Label22)
        Me.PanelKontenKasir.Controls.Add(Me.PanelHeaderKasir)
        Me.PanelKontenKasir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenKasir.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenKasir.Name = "PanelKontenKasir"
        Me.PanelKontenKasir.Size = New System.Drawing.Size(650, 550)
        Me.PanelKontenKasir.TabIndex = 1
        '
        'tabelDataKasir
        '
        Me.tabelDataKasir.AllowUserToAddRows = False
        Me.tabelDataKasir.AllowUserToDeleteRows = False
        Me.tabelDataKasir.AllowUserToOrderColumns = True
        Me.tabelDataKasir.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataKasir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataKasir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataKasir.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.kode_barang, Me.nama_barang, Me.kategori, Me.harga, Me.qty, Me.diskon, Me.sub_total, Me.stok})
        Me.tabelDataKasir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataKasir.Location = New System.Drawing.Point(0, 181)
        Me.tabelDataKasir.MultiSelect = False
        Me.tabelDataKasir.Name = "tabelDataKasir"
        Me.tabelDataKasir.ReadOnly = True
        Me.tabelDataKasir.RowHeadersVisible = False
        Me.tabelDataKasir.Size = New System.Drawing.Size(650, 228)
        Me.tabelDataKasir.TabIndex = 8
        '
        'no
        '
        Me.no.HeaderText = "No"
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 40
        '
        'kode_barang
        '
        Me.kode_barang.HeaderText = "Kode Barang"
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.ReadOnly = True
        '
        'nama_barang
        '
        Me.nama_barang.HeaderText = "Nama Barang"
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.ReadOnly = True
        '
        'kategori
        '
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.Name = "kategori"
        Me.kategori.ReadOnly = True
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.ReadOnly = True
        '
        'qty
        '
        Me.qty.HeaderText = "QTY"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        Me.qty.Width = 40
        '
        'diskon
        '
        Me.diskon.HeaderText = "Diskon(%)"
        Me.diskon.Name = "diskon"
        Me.diskon.ReadOnly = True
        '
        'sub_total
        '
        Me.sub_total.HeaderText = "Sub Total"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        '
        'stok
        '
        Me.stok.HeaderText = "stok"
        Me.stok.Name = "stok"
        Me.stok.ReadOnly = True
        Me.stok.Visible = False
        '
        'Label23
        '
        Me.Label23.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(0, 409)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(650, 10)
        Me.Label23.TabIndex = 11
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelFooterKasir
        '
        Me.PanelFooterKasir.Controls.Add(Me.btnBayarKasir)
        Me.PanelFooterKasir.Controls.Add(Me.Label30)
        Me.PanelFooterKasir.Controls.Add(Me.Label29)
        Me.PanelFooterKasir.Controls.Add(Me.Label26)
        Me.PanelFooterKasir.Controls.Add(Me.txDiskonBelanja)
        Me.PanelFooterKasir.Controls.Add(Me.Label28)
        Me.PanelFooterKasir.Controls.Add(Me.txKembalian)
        Me.PanelFooterKasir.Controls.Add(Me.Label27)
        Me.PanelFooterKasir.Controls.Add(Me.txBayar)
        Me.PanelFooterKasir.Controls.Add(Me.Label25)
        Me.PanelFooterKasir.Controls.Add(Me.txTotal)
        Me.PanelFooterKasir.Controls.Add(Me.Label24)
        Me.PanelFooterKasir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelFooterKasir.Location = New System.Drawing.Point(0, 419)
        Me.PanelFooterKasir.Name = "PanelFooterKasir"
        Me.PanelFooterKasir.Size = New System.Drawing.Size(650, 131)
        Me.PanelFooterKasir.TabIndex = 10
        '
        'btnBayarKasir
        '
        Me.btnBayarKasir.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnBayarKasir.FlatAppearance.BorderSize = 0
        Me.btnBayarKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBayarKasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBayarKasir.ForeColor = System.Drawing.Color.White
        Me.btnBayarKasir.Location = New System.Drawing.Point(559, 81)
        Me.btnBayarKasir.Name = "btnBayarKasir"
        Me.btnBayarKasir.Size = New System.Drawing.Size(85, 40)
        Me.btnBayarKasir.TabIndex = 13
        Me.btnBayarKasir.Text = "Bayar"
        Me.btnBayarKasir.UseVisualStyleBackColor = False
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(0, 71)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(650, 60)
        Me.Label30.TabIndex = 12
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.SystemColors.Control
        Me.Label29.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label29.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(0, 70)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(650, 1)
        Me.Label29.TabIndex = 11
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.White
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(9, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(61, 13)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "Diskon (%)"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txDiskonBelanja
        '
        Me.txDiskonBelanja.Location = New System.Drawing.Point(85, 40)
        Me.txDiskonBelanja.Name = "txDiskonBelanja"
        Me.txDiskonBelanja.Size = New System.Drawing.Size(225, 20)
        Me.txDiskonBelanja.TabIndex = 6
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(343, 48)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(60, 13)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Kembalian"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txKembalian
        '
        Me.txKembalian.Enabled = False
        Me.txKembalian.Location = New System.Drawing.Point(419, 43)
        Me.txKembalian.Name = "txKembalian"
        Me.txKembalian.Size = New System.Drawing.Size(225, 20)
        Me.txKembalian.TabIndex = 6
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(343, 13)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(46, 13)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "Dibayar"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txBayar
        '
        Me.txBayar.Location = New System.Drawing.Point(419, 10)
        Me.txBayar.Name = "txBayar"
        Me.txBayar.Size = New System.Drawing.Size(225, 20)
        Me.txBayar.TabIndex = 6
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(9, 13)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(31, 13)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Total"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txTotal
        '
        Me.txTotal.Enabled = False
        Me.txTotal.Location = New System.Drawing.Point(85, 10)
        Me.txTotal.Name = "txTotal"
        Me.txTotal.Size = New System.Drawing.Size(225, 20)
        Me.txTotal.TabIndex = 6
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(0, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(650, 70)
        Me.Label24.TabIndex = 5
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(0, 171)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(650, 10)
        Me.Label22.TabIndex = 9
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeaderKasir
        '
        Me.PanelHeaderKasir.Controls.Add(Me.btnCariKodeBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.Label21)
        Me.PanelHeaderKasir.Controls.Add(Me.Label20)
        Me.PanelHeaderKasir.Controls.Add(Me.txDiskon)
        Me.PanelHeaderKasir.Controls.Add(Me.txTotalBelanja)
        Me.PanelHeaderKasir.Controls.Add(Me.txQty)
        Me.PanelHeaderKasir.Controls.Add(Me.Label19)
        Me.PanelHeaderKasir.Controls.Add(Me.txNamaBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.Label18)
        Me.PanelHeaderKasir.Controls.Add(Me.txKodeBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.Label17)
        Me.PanelHeaderKasir.Controls.Add(Me.Label16)
        Me.PanelHeaderKasir.Controls.Add(Me.Label15)
        Me.PanelHeaderKasir.Controls.Add(Me.tglKasir)
        Me.PanelHeaderKasir.Controls.Add(Me.txNoStruk)
        Me.PanelHeaderKasir.Controls.Add(Me.Label13)
        Me.PanelHeaderKasir.Controls.Add(Me.Label7)
        Me.PanelHeaderKasir.Controls.Add(Me.Label14)
        Me.PanelHeaderKasir.Controls.Add(Me.Label12)
        Me.PanelHeaderKasir.Controls.Add(Me.txStokBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.txHargaBarang)
        Me.PanelHeaderKasir.Controls.Add(Me.txKategori)
        Me.PanelHeaderKasir.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderKasir.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderKasir.Name = "PanelHeaderKasir"
        Me.PanelHeaderKasir.Size = New System.Drawing.Size(650, 171)
        Me.PanelHeaderKasir.TabIndex = 2
        '
        'btnCariKodeBarang
        '
        Me.btnCariKodeBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnCariKodeBarang.FlatAppearance.BorderSize = 0
        Me.btnCariKodeBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCariKodeBarang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCariKodeBarang.ForeColor = System.Drawing.Color.White
        Me.btnCariKodeBarang.Location = New System.Drawing.Point(280, 51)
        Me.btnCariKodeBarang.Name = "btnCariKodeBarang"
        Me.btnCariKodeBarang.Size = New System.Drawing.Size(30, 20)
        Me.btnCariKodeBarang.TabIndex = 13
        Me.btnCariKodeBarang.Text = "..."
        Me.btnCariKodeBarang.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(332, 41)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(318, 41)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Total Belanja"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(325, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(1, 130)
        Me.Label20.TabIndex = 12
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txDiskon
        '
        Me.txDiskon.Location = New System.Drawing.Point(85, 141)
        Me.txDiskon.Name = "txDiskon"
        Me.txDiskon.Size = New System.Drawing.Size(225, 20)
        Me.txDiskon.TabIndex = 6
        '
        'txTotalBelanja
        '
        Me.txTotalBelanja.Enabled = False
        Me.txTotalBelanja.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txTotalBelanja.Location = New System.Drawing.Point(332, 85)
        Me.txTotalBelanja.Name = "txTotalBelanja"
        Me.txTotalBelanja.Size = New System.Drawing.Size(312, 80)
        Me.txTotalBelanja.TabIndex = 6
        Me.txTotalBelanja.Text = "1000000"
        '
        'txQty
        '
        Me.txQty.Location = New System.Drawing.Point(85, 111)
        Me.txQty.Name = "txQty"
        Me.txQty.Size = New System.Drawing.Size(225, 20)
        Me.txQty.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(6, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 13)
        Me.Label19.TabIndex = 5
        Me.Label19.Text = "Diskon (%)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txNamaBarang
        '
        Me.txNamaBarang.Enabled = False
        Me.txNamaBarang.Location = New System.Drawing.Point(85, 81)
        Me.txNamaBarang.Name = "txNamaBarang"
        Me.txNamaBarang.Size = New System.Drawing.Size(225, 20)
        Me.txNamaBarang.TabIndex = 6
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(6, 114)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(25, 13)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "QTY"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txKodeBarang
        '
        Me.txKodeBarang.Location = New System.Drawing.Point(85, 51)
        Me.txKodeBarang.Name = "txKodeBarang"
        Me.txKodeBarang.Size = New System.Drawing.Size(189, 20)
        Me.txKodeBarang.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(6, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "Nama Barang"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(6, 54)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Kode Barang"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(0, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(650, 130)
        Me.Label15.TabIndex = 11
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tglKasir
        '
        Me.tglKasir.Location = New System.Drawing.Point(440, 10)
        Me.tglKasir.Name = "tglKasir"
        Me.tglKasir.Size = New System.Drawing.Size(204, 20)
        Me.tglKasir.TabIndex = 7
        '
        'txNoStruk
        '
        Me.txNoStruk.Enabled = False
        Me.txNoStruk.Location = New System.Drawing.Point(85, 10)
        Me.txNoStruk.Name = "txNoStruk"
        Me.txNoStruk.Size = New System.Drawing.Size(225, 20)
        Me.txNoStruk.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(380, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 17)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Tanggal"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "No Struk"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(0, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(650, 1)
        Me.Label14.TabIndex = 10
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(650, 40)
        Me.Label12.TabIndex = 4
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txStokBarang
        '
        Me.txStokBarang.Enabled = False
        Me.txStokBarang.Location = New System.Drawing.Point(213, 111)
        Me.txStokBarang.Name = "txStokBarang"
        Me.txStokBarang.Size = New System.Drawing.Size(46, 20)
        Me.txStokBarang.TabIndex = 14
        Me.txStokBarang.Visible = False
        '
        'txHargaBarang
        '
        Me.txHargaBarang.Enabled = False
        Me.txHargaBarang.Location = New System.Drawing.Point(213, 81)
        Me.txHargaBarang.Name = "txHargaBarang"
        Me.txHargaBarang.Size = New System.Drawing.Size(46, 20)
        Me.txHargaBarang.TabIndex = 14
        Me.txHargaBarang.Visible = False
        '
        'txKategori
        '
        Me.txKategori.Enabled = False
        Me.txKategori.Location = New System.Drawing.Point(213, 140)
        Me.txKategori.Name = "txKategori"
        Me.txKategori.Size = New System.Drawing.Size(46, 20)
        Me.txKategori.TabIndex = 15
        Me.txKategori.Visible = False
        '
        'PanelKontenBarang
        '
        Me.PanelKontenBarang.Controls.Add(Me.tabelDataBarang)
        Me.PanelKontenBarang.Controls.Add(Me.Label54)
        Me.PanelKontenBarang.Controls.Add(Me.PanelHeaderBarang)
        Me.PanelKontenBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelKontenBarang.Location = New System.Drawing.Point(10, 10)
        Me.PanelKontenBarang.Name = "PanelKontenBarang"
        Me.PanelKontenBarang.Size = New System.Drawing.Size(650, 550)
        Me.PanelKontenBarang.TabIndex = 14
        '
        'tabelDataBarang
        '
        Me.tabelDataBarang.AllowUserToAddRows = False
        Me.tabelDataBarang.AllowUserToDeleteRows = False
        Me.tabelDataBarang.AllowUserToOrderColumns = True
        Me.tabelDataBarang.AutoGenerateColumns = False
        Me.tabelDataBarang.BackgroundColor = System.Drawing.Color.White
        Me.tabelDataBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabelDataBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabelDataBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodebarangDataGridViewTextBoxColumn, Me.NamabarangDataGridViewTextBoxColumn, Me.NamakategoriDataGridViewTextBoxColumn, Me.HargaDataGridViewTextBoxColumn, Me.DiskonDataGridViewTextBoxColumn, Me.StokDataGridViewTextBoxColumn, Me.KodekategoriDataGridViewTextBoxColumn})
        Me.tabelDataBarang.DataSource = Me.LihatBarangBindingSource
        Me.tabelDataBarang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabelDataBarang.Location = New System.Drawing.Point(0, 70)
        Me.tabelDataBarang.MultiSelect = False
        Me.tabelDataBarang.Name = "tabelDataBarang"
        Me.tabelDataBarang.ReadOnly = True
        Me.tabelDataBarang.RowHeadersVisible = False
        Me.tabelDataBarang.Size = New System.Drawing.Size(650, 480)
        Me.tabelDataBarang.TabIndex = 8
        '
        'KodebarangDataGridViewTextBoxColumn
        '
        Me.KodebarangDataGridViewTextBoxColumn.DataPropertyName = "kode_barang"
        Me.KodebarangDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.KodebarangDataGridViewTextBoxColumn.Name = "KodebarangDataGridViewTextBoxColumn"
        Me.KodebarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamabarangDataGridViewTextBoxColumn
        '
        Me.NamabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang"
        Me.NamabarangDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.NamabarangDataGridViewTextBoxColumn.Name = "NamabarangDataGridViewTextBoxColumn"
        Me.NamabarangDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NamakategoriDataGridViewTextBoxColumn
        '
        Me.NamakategoriDataGridViewTextBoxColumn.DataPropertyName = "nama_kategori"
        Me.NamakategoriDataGridViewTextBoxColumn.HeaderText = "Kategori"
        Me.NamakategoriDataGridViewTextBoxColumn.Name = "NamakategoriDataGridViewTextBoxColumn"
        Me.NamakategoriDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HargaDataGridViewTextBoxColumn
        '
        Me.HargaDataGridViewTextBoxColumn.DataPropertyName = "harga"
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "harga"
        Me.HargaDataGridViewTextBoxColumn.Name = "HargaDataGridViewTextBoxColumn"
        Me.HargaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DiskonDataGridViewTextBoxColumn
        '
        Me.DiskonDataGridViewTextBoxColumn.DataPropertyName = "diskon"
        Me.DiskonDataGridViewTextBoxColumn.HeaderText = "Diskon"
        Me.DiskonDataGridViewTextBoxColumn.Name = "DiskonDataGridViewTextBoxColumn"
        Me.DiskonDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StokDataGridViewTextBoxColumn
        '
        Me.StokDataGridViewTextBoxColumn.DataPropertyName = "stok"
        Me.StokDataGridViewTextBoxColumn.HeaderText = "Stok"
        Me.StokDataGridViewTextBoxColumn.Name = "StokDataGridViewTextBoxColumn"
        Me.StokDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KodekategoriDataGridViewTextBoxColumn
        '
        Me.KodekategoriDataGridViewTextBoxColumn.DataPropertyName = "kode_kategori"
        Me.KodekategoriDataGridViewTextBoxColumn.HeaderText = "kode_kategori"
        Me.KodekategoriDataGridViewTextBoxColumn.Name = "KodekategoriDataGridViewTextBoxColumn"
        Me.KodekategoriDataGridViewTextBoxColumn.ReadOnly = True
        Me.KodekategoriDataGridViewTextBoxColumn.Visible = False
        '
        'LihatBarangBindingSource
        '
        Me.LihatBarangBindingSource.DataMember = "lihatBarang"
        Me.LihatBarangBindingSource.DataSource = Me.TokoRotiDataSet
        '
        'TokoRotiDataSet
        '
        Me.TokoRotiDataSet.DataSetName = "TokoRotiDataSet"
        Me.TokoRotiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label54
        '
        Me.Label54.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label54.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(0, 60)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(650, 10)
        Me.Label54.TabIndex = 9
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeaderBarang
        '
        Me.PanelHeaderBarang.Controls.Add(Me.btnTambahBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.btnEditBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.btnHapusBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.txCariBarang)
        Me.PanelHeaderBarang.Controls.Add(Me.Label63)
        Me.PanelHeaderBarang.Controls.Add(Me.Label64)
        Me.PanelHeaderBarang.Controls.Add(Me.Label65)
        Me.PanelHeaderBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeaderBarang.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeaderBarang.Name = "PanelHeaderBarang"
        Me.PanelHeaderBarang.Size = New System.Drawing.Size(650, 60)
        Me.PanelHeaderBarang.TabIndex = 2
        '
        'btnTambahBarang
        '
        Me.btnTambahBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnTambahBarang.FlatAppearance.BorderSize = 0
        Me.btnTambahBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTambahBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahBarang.ForeColor = System.Drawing.Color.White
        Me.btnTambahBarang.Location = New System.Drawing.Point(377, 10)
        Me.btnTambahBarang.Name = "btnTambahBarang"
        Me.btnTambahBarang.Size = New System.Drawing.Size(85, 40)
        Me.btnTambahBarang.TabIndex = 11
        Me.btnTambahBarang.Text = "Tambah"
        Me.btnTambahBarang.UseVisualStyleBackColor = False
        '
        'btnEditBarang
        '
        Me.btnEditBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnEditBarang.FlatAppearance.BorderSize = 0
        Me.btnEditBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditBarang.ForeColor = System.Drawing.Color.White
        Me.btnEditBarang.Location = New System.Drawing.Point(468, 10)
        Me.btnEditBarang.Name = "btnEditBarang"
        Me.btnEditBarang.Size = New System.Drawing.Size(85, 40)
        Me.btnEditBarang.TabIndex = 11
        Me.btnEditBarang.Text = "Edit"
        Me.btnEditBarang.UseVisualStyleBackColor = False
        '
        'btnHapusBarang
        '
        Me.btnHapusBarang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnHapusBarang.FlatAppearance.BorderSize = 0
        Me.btnHapusBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHapusBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusBarang.ForeColor = System.Drawing.Color.White
        Me.btnHapusBarang.Location = New System.Drawing.Point(559, 10)
        Me.btnHapusBarang.Name = "btnHapusBarang"
        Me.btnHapusBarang.Size = New System.Drawing.Size(85, 40)
        Me.btnHapusBarang.TabIndex = 11
        Me.btnHapusBarang.Text = "Hapus"
        Me.btnHapusBarang.UseVisualStyleBackColor = False
        '
        'txCariBarang
        '
        Me.txCariBarang.Location = New System.Drawing.Point(46, 20)
        Me.txCariBarang.Name = "txCariBarang"
        Me.txCariBarang.Size = New System.Drawing.Size(225, 20)
        Me.txCariBarang.TabIndex = 6
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.White
        Me.Label63.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(9, 21)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(31, 17)
        Me.Label63.TabIndex = 5
        Me.Label63.Text = "Cari"
        Me.Label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label64
        '
        Me.Label64.BackColor = System.Drawing.SystemColors.Control
        Me.Label64.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label64.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.White
        Me.Label64.Location = New System.Drawing.Point(0, 60)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(650, 1)
        Me.Label64.TabIndex = 10
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label65
        '
        Me.Label65.BackColor = System.Drawing.Color.White
        Me.Label65.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label65.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.Location = New System.Drawing.Point(0, 0)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(650, 60)
        Me.Label65.TabIndex = 4
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marginTop
        '
        Me.marginTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.marginTop.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginTop.ForeColor = System.Drawing.Color.White
        Me.marginTop.Location = New System.Drawing.Point(10, 0)
        Me.marginTop.Name = "marginTop"
        Me.marginTop.Size = New System.Drawing.Size(650, 10)
        Me.marginTop.TabIndex = 4
        Me.marginTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marginBottom
        '
        Me.marginBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.marginBottom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginBottom.ForeColor = System.Drawing.Color.White
        Me.marginBottom.Location = New System.Drawing.Point(10, 560)
        Me.marginBottom.Name = "marginBottom"
        Me.marginBottom.Size = New System.Drawing.Size(650, 10)
        Me.marginBottom.TabIndex = 5
        Me.marginBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marginLeft
        '
        Me.marginLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.marginLeft.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginLeft.ForeColor = System.Drawing.Color.White
        Me.marginLeft.Location = New System.Drawing.Point(0, 0)
        Me.marginLeft.Name = "marginLeft"
        Me.marginLeft.Size = New System.Drawing.Size(10, 570)
        Me.marginLeft.TabIndex = 6
        Me.marginLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marginRight
        '
        Me.marginRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.marginRight.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginRight.ForeColor = System.Drawing.Color.White
        Me.marginRight.Location = New System.Drawing.Point(660, 0)
        Me.marginRight.Name = "marginRight"
        Me.marginRight.Size = New System.Drawing.Size(10, 570)
        Me.marginRight.TabIndex = 7
        Me.marginRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.LblKeteranganMenu)
        Me.PanelHeader.Controls.Add(Me.LblMenu)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(200, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(670, 100)
        Me.PanelHeader.TabIndex = 0
        '
        'LblKeteranganMenu
        '
        Me.LblKeteranganMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblKeteranganMenu.Font = New System.Drawing.Font("Segoe UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKeteranganMenu.ForeColor = System.Drawing.Color.White
        Me.LblKeteranganMenu.Location = New System.Drawing.Point(0, 70)
        Me.LblKeteranganMenu.Name = "LblKeteranganMenu"
        Me.LblKeteranganMenu.Size = New System.Drawing.Size(670, 30)
        Me.LblKeteranganMenu.TabIndex = 3
        Me.LblKeteranganMenu.Text = "alt + F4 Untuk Keluar"
        Me.LblKeteranganMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMenu
        '
        Me.LblMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMenu.ForeColor = System.Drawing.Color.White
        Me.LblMenu.Location = New System.Drawing.Point(0, 30)
        Me.LblMenu.Name = "LblMenu"
        Me.LblMenu.Size = New System.Drawing.Size(670, 40)
        Me.LblMenu.TabIndex = 2
        Me.LblMenu.Text = "Halaman Awal "
        Me.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnMinimize)
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(670, 30)
        Me.PanelWindowBar.TabIndex = 1
        '
        'btnMinimize
        '
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Location = New System.Drawing.Point(610, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimize.TabIndex = 3
        Me.btnMinimize.Text = "-"
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(640, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'PanelSideBar
        '
        Me.PanelSideBar.AutoScroll = True
        Me.PanelSideBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelSideBar.Controls.Add(Me.btnLogOut)
        Me.PanelSideBar.Controls.Add(Me.Label6)
        Me.PanelSideBar.Controls.Add(Me.btnKaryawan)
        Me.PanelSideBar.Controls.Add(Me.Label5)
        Me.PanelSideBar.Controls.Add(Me.btnBarang)
        Me.PanelSideBar.Controls.Add(Me.Label4)
        Me.PanelSideBar.Controls.Add(Me.btnKasir)
        Me.PanelSideBar.Controls.Add(Me.Label3)
        Me.PanelSideBar.Controls.Add(Me.btnDashboard)
        Me.PanelSideBar.Controls.Add(Me.Label2)
        Me.PanelSideBar.Controls.Add(Me.Panel1)
        Me.PanelSideBar.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelSideBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelSideBar.Name = "PanelSideBar"
        Me.PanelSideBar.Size = New System.Drawing.Size(200, 670)
        Me.PanelSideBar.TabIndex = 0
        '
        'btnLogOut
        '
        Me.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.ForeColor = System.Drawing.Color.White
        Me.btnLogOut.Location = New System.Drawing.Point(0, 610)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(200, 60)
        Me.btnLogOut.TabIndex = 7
        Me.btnLogOut.Text = "Keluar Sesi"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 343)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 1)
        Me.Label6.TabIndex = 12
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKaryawan
        '
        Me.btnKaryawan.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKaryawan.FlatAppearance.BorderSize = 0
        Me.btnKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKaryawan.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKaryawan.ForeColor = System.Drawing.Color.White
        Me.btnKaryawan.Location = New System.Drawing.Point(0, 283)
        Me.btnKaryawan.Name = "btnKaryawan"
        Me.btnKaryawan.Size = New System.Drawing.Size(200, 60)
        Me.btnKaryawan.TabIndex = 6
        Me.btnKaryawan.Text = "     Data Karyawan"
        Me.btnKaryawan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKaryawan.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 282)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 1)
        Me.Label5.TabIndex = 11
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBarang
        '
        Me.btnBarang.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBarang.FlatAppearance.BorderSize = 0
        Me.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBarang.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBarang.ForeColor = System.Drawing.Color.White
        Me.btnBarang.Location = New System.Drawing.Point(0, 222)
        Me.btnBarang.Name = "btnBarang"
        Me.btnBarang.Size = New System.Drawing.Size(200, 60)
        Me.btnBarang.TabIndex = 5
        Me.btnBarang.Text = "     Data Barang"
        Me.btnBarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBarang.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 1)
        Me.Label4.TabIndex = 10
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnKasir
        '
        Me.btnKasir.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnKasir.FlatAppearance.BorderSize = 0
        Me.btnKasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKasir.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKasir.ForeColor = System.Drawing.Color.White
        Me.btnKasir.Location = New System.Drawing.Point(0, 161)
        Me.btnKasir.Name = "btnKasir"
        Me.btnKasir.Size = New System.Drawing.Size(200, 60)
        Me.btnKasir.TabIndex = 4
        Me.btnKasir.Text = "     Kasir"
        Me.btnKasir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnKasir.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 1)
        Me.Label3.TabIndex = 9
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Location = New System.Drawing.Point(0, 100)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(200, 60)
        Me.btnDashboard.TabIndex = 2
        Me.btnDashboard.Text = "     Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 1)
        Me.Label2.TabIndex = 8
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblAdmin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblJudulApp)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 99)
        Me.Panel1.TabIndex = 3
        '
        'lblAdmin
        '
        Me.lblAdmin.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAdmin.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdmin.ForeColor = System.Drawing.Color.White
        Me.lblAdmin.Location = New System.Drawing.Point(100, 70)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(100, 29)
        Me.lblAdmin.TabIndex = 6
        Me.lblAdmin.Text = "Arinal"
        Me.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "۞ Admin :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblJudulApp
        '
        Me.lblJudulApp.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblJudulApp.Font = New System.Drawing.Font("Century", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulApp.ForeColor = System.Drawing.Color.White
        Me.lblJudulApp.Location = New System.Drawing.Point(0, 0)
        Me.lblJudulApp.Name = "lblJudulApp"
        Me.lblJudulApp.Size = New System.Drawing.Size(200, 70)
        Me.lblJudulApp.TabIndex = 4
        Me.lblJudulApp.Text = "The" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bread" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shop"
        Me.lblJudulApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BarangBindingSource
        '
        Me.BarangBindingSource.DataMember = "barang"
        Me.BarangBindingSource.DataSource = Me.TokoRotiDataSet
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'HeaderpenjualanBindingSource
        '
        Me.HeaderpenjualanBindingSource.DataMember = "header_penjualan"
        Me.HeaderpenjualanBindingSource.DataSource = Me.TokoRotiDataSet
        '
        'Header_penjualanTableAdapter
        '
        Me.Header_penjualanTableAdapter.ClearBeforeFill = True
        '
        'PenjualanBindingSource
        '
        Me.PenjualanBindingSource.DataMember = "penjualan"
        Me.PenjualanBindingSource.DataSource = Me.TokoRotiDataSet
        '
        'PenjualanTableAdapter
        '
        Me.PenjualanTableAdapter.ClearBeforeFill = True
        '
        'LihatBarangTableAdapter
        '
        Me.LihatBarangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.barangTableAdapter = Me.BarangTableAdapter
        Me.TableAdapterManager.header_penjualanTableAdapter = Me.Header_penjualanTableAdapter
        Me.TableAdapterManager.karyawanTableAdapter = Nothing
        Me.TableAdapterManager.kategoriTableAdapter = Nothing
        Me.TableAdapterManager.penjualanTableAdapter = Me.PenjualanTableAdapter
        Me.TableAdapterManager.UpdateOrder = latihan4.TokoRotiDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 670)
        Me.Controls.Add(Me.PanelFormMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelFormMenu.ResumeLayout(False)
        Me.PanelKonten.ResumeLayout(False)
        Me.PanelKontenDashboard.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.PanelKontenKaryawan.ResumeLayout(False)
        CType(Me.tabelDataKaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KaryawanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TokoRotiDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelLihatFoto.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.PanelFotoKaryawan.ResumeLayout(False)
        CType(Me.fotoBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderKaryawan.ResumeLayout(False)
        Me.PanelHeaderKaryawan.PerformLayout()
        Me.PanelKontenKasir.ResumeLayout(False)
        CType(Me.tabelDataKasir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelFooterKasir.ResumeLayout(False)
        Me.PanelFooterKasir.PerformLayout()
        Me.PanelHeaderKasir.ResumeLayout(False)
        Me.PanelHeaderKasir.PerformLayout()
        Me.PanelKontenBarang.ResumeLayout(False)
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TokoRotiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHeaderBarang.ResumeLayout(False)
        Me.PanelHeaderBarang.PerformLayout()
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.PanelSideBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.BarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaderpenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelFormMenu As Panel
    Friend WithEvents PanelKonten As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LblKeteranganMenu As Label
    Friend WithEvents LblMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents PanelSideBar As Panel
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAdmin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblJudulApp As Label
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnKaryawan As Button
    Friend WithEvents btnBarang As Button
    Friend WithEvents btnKasir As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelKontenKasir As Panel
    Friend WithEvents PanelHeaderKasir As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents marginRight As Label
    Friend WithEvents marginLeft As Label
    Friend WithEvents marginBottom As Label
    Friend WithEvents marginTop As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txDiskon As TextBox
    Friend WithEvents txQty As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txNamaBarang As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txKodeBarang As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents tglKasir As DateTimePicker
    Friend WithEvents txNoStruk As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents tabelDataKasir As DataGridView
    Friend WithEvents Label23 As Label
    Friend WithEvents PanelFooterKasir As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txTotalBelanja As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents btnCariKodeBarang As Button
    Friend WithEvents Label26 As Label
    Friend WithEvents txDiskonBelanja As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txTotal As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txKembalian As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txBayar As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents btnBayarKasir As Button
    Friend WithEvents PanelKontenDashboard As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label44 As Label
    Friend WithEvents lblStokMinuman As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label41 As Label
    Friend WithEvents lblStokRoti As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label35 As Label
    Friend WithEvents lblStokBarang As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label32 As Label
    Friend WithEvents lblPenjualan As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents lblDataKaryawan As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDataBarang As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txStokBarang As TextBox
    Friend WithEvents txHargaBarang As TextBox
    Friend WithEvents TokoRotiDataSet As TokoRotiDataSet
    Friend WithEvents BarangBindingSource As BindingSource
    Friend WithEvents BarangTableAdapter As TokoRotiDataSetTableAdapters.barangTableAdapter
    Friend WithEvents HeaderpenjualanBindingSource As BindingSource
    Friend WithEvents Header_penjualanTableAdapter As TokoRotiDataSetTableAdapters.header_penjualanTableAdapter
    Friend WithEvents PenjualanBindingSource As BindingSource
    Friend WithEvents PenjualanTableAdapter As TokoRotiDataSetTableAdapters.penjualanTableAdapter
    Friend WithEvents txKategori As TextBox
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents diskon As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
    Friend WithEvents stok As DataGridViewTextBoxColumn
    Friend WithEvents PanelKontenBarang As Panel
    Friend WithEvents Label54 As Label
    Friend WithEvents PanelHeaderBarang As Panel
    Friend WithEvents txCariBarang As TextBox
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents btnTambahBarang As Button
    Friend WithEvents btnEditBarang As Button
    Friend WithEvents btnHapusBarang As Button
    Friend WithEvents tabelDataBarang As DataGridView
    Friend WithEvents LihatBarangBindingSource As BindingSource
    Friend WithEvents LihatBarangTableAdapter As TokoRotiDataSetTableAdapters.lihatBarangTableAdapter
    Friend WithEvents TableAdapterManager As TokoRotiDataSetTableAdapters.TableAdapterManager
    Friend WithEvents KodebarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamabarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamakategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodekategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PanelKontenKaryawan As Panel
    Friend WithEvents tabelDataKaryawan As DataGridView
    Friend WithEvents Label40 As Label
    Friend WithEvents PanelHeaderKaryawan As Panel
    Friend WithEvents btnTambahKaryawan As Button
    Friend WithEvents btnEditKaryawan As Button
    Friend WithEvents btnHapusKaryawan As Button
    Friend WithEvents txCariKaryawan As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents KaryawanBindingSource As BindingSource
    Friend WithEvents KaryawanTableAdapter As TokoRotiDataSetTableAdapters.karyawanTableAdapter
    Friend WithEvents PanelLihatFoto As Panel
    Friend WithEvents btnLihatFoto As Button
    Friend WithEvents PanelFotoKaryawan As Panel
    Friend WithEvents fotoBox As PictureBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents TokoRotiDataSet1 As TokoRotiDataSet
    Friend WithEvents IdkaryawanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamakaryawanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LevelkaryawanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
