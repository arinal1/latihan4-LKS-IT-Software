<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formBarang
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LblMenu = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.txKode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txNama = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.marginTop = New System.Windows.Forms.Label()
        Me.marginBottom = New System.Windows.Forms.Label()
        Me.marginLeft = New System.Windows.Forms.Label()
        Me.marginRight = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbKategori = New System.Windows.Forms.ComboBox()
        Me.TokoRotiDataSet = New latihan4.TokoRotiDataSet()
        Me.btnUlang = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txStok = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txDiskon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txHarga = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BarangTableAdapter = New latihan4.TokoRotiDataSetTableAdapters.barangTableAdapter()
        Me.LihatBarangTableAdapter = New latihan4.TokoRotiDataSetTableAdapters.lihatBarangTableAdapter()
        Me.LihatBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LihatBarangBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TokoRotiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LihatBarangBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.LblMenu)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(398, 100)
        Me.PanelHeader.TabIndex = 1
        '
        'LblMenu
        '
        Me.LblMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMenu.ForeColor = System.Drawing.Color.White
        Me.LblMenu.Location = New System.Drawing.Point(0, 30)
        Me.LblMenu.Name = "LblMenu"
        Me.LblMenu.Size = New System.Drawing.Size(398, 70)
        Me.LblMenu.TabIndex = 2
        Me.LblMenu.Text = "Form Barang"
        Me.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(398, 30)
        Me.PanelWindowBar.TabIndex = 1
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(368, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnSimpan.FlatAppearance.BorderSize = 0
        Me.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSimpan.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.ForeColor = System.Drawing.Color.White
        Me.btnSimpan.Location = New System.Drawing.Point(295, 412)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(80, 40)
        Me.btnSimpan.TabIndex = 6
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = False
        '
        'txKode
        '
        Me.txKode.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txKode.Location = New System.Drawing.Point(107, 122)
        Me.txKode.Name = "txKode"
        Me.txKode.Size = New System.Drawing.Size(268, 22)
        Me.txKode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nama Barang"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txNama
        '
        Me.txNama.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txNama.Location = New System.Drawing.Point(107, 170)
        Me.txNama.Name = "txNama"
        Me.txNama.Size = New System.Drawing.Size(268, 22)
        Me.txNama.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(22, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Kode Barang"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marginTop
        '
        Me.marginTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.marginTop.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginTop.ForeColor = System.Drawing.Color.White
        Me.marginTop.Location = New System.Drawing.Point(25, 100)
        Me.marginTop.Name = "marginTop"
        Me.marginTop.Size = New System.Drawing.Size(348, 10)
        Me.marginTop.TabIndex = 8
        Me.marginTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marginBottom
        '
        Me.marginBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.marginBottom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginBottom.ForeColor = System.Drawing.Color.White
        Me.marginBottom.Location = New System.Drawing.Point(25, 453)
        Me.marginBottom.Name = "marginBottom"
        Me.marginBottom.Size = New System.Drawing.Size(348, 10)
        Me.marginBottom.TabIndex = 9
        Me.marginBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marginLeft
        '
        Me.marginLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.marginLeft.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginLeft.ForeColor = System.Drawing.Color.White
        Me.marginLeft.Location = New System.Drawing.Point(0, 100)
        Me.marginLeft.Name = "marginLeft"
        Me.marginLeft.Size = New System.Drawing.Size(25, 363)
        Me.marginLeft.TabIndex = 10
        Me.marginLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marginRight
        '
        Me.marginRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.marginRight.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginRight.ForeColor = System.Drawing.Color.White
        Me.marginRight.Location = New System.Drawing.Point(373, 100)
        Me.marginRight.Name = "marginRight"
        Me.marginRight.Size = New System.Drawing.Size(25, 363)
        Me.marginRight.TabIndex = 11
        Me.marginRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbKategori)
        Me.Panel1.Controls.Add(Me.btnUlang)
        Me.Panel1.Controls.Add(Me.btnSimpan)
        Me.Panel1.Controls.Add(Me.txKode)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txStok)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txDiskon)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txHarga)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txNama)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.marginTop)
        Me.Panel1.Controls.Add(Me.marginBottom)
        Me.Panel1.Controls.Add(Me.marginLeft)
        Me.Panel1.Controls.Add(Me.marginRight)
        Me.Panel1.Controls.Add(Me.PanelHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 465)
        Me.Panel1.TabIndex = 16
        '
        'cbKategori
        '
        Me.cbKategori.DataSource = Me.LihatBarangBindingSource1
        Me.cbKategori.DisplayMember = "nama_kategori"
        Me.cbKategori.FormattingEnabled = True
        Me.cbKategori.Location = New System.Drawing.Point(107, 218)
        Me.cbKategori.Name = "cbKategori"
        Me.cbKategori.Size = New System.Drawing.Size(266, 21)
        Me.cbKategori.TabIndex = 2
        Me.cbKategori.ValueMember = "kode_kategori"
        '
        'TokoRotiDataSet
        '
        Me.TokoRotiDataSet.DataSetName = "TokoRotiDataSet"
        Me.TokoRotiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnUlang
        '
        Me.btnUlang.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnUlang.FlatAppearance.BorderSize = 0
        Me.btnUlang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUlang.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUlang.ForeColor = System.Drawing.Color.White
        Me.btnUlang.Location = New System.Drawing.Point(209, 412)
        Me.btnUlang.Name = "btnUlang"
        Me.btnUlang.Size = New System.Drawing.Size(80, 40)
        Me.btnUlang.TabIndex = 2
        Me.btnUlang.Text = "Ulang"
        Me.btnUlang.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(22, 365)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Stok"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txStok
        '
        Me.txStok.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txStok.Location = New System.Drawing.Point(107, 365)
        Me.txStok.Name = "txStok"
        Me.txStok.Size = New System.Drawing.Size(268, 22)
        Me.txStok.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(22, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Diskon"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txDiskon
        '
        Me.txDiskon.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txDiskon.Location = New System.Drawing.Point(107, 316)
        Me.txDiskon.Name = "txDiskon"
        Me.txDiskon.Size = New System.Drawing.Size(268, 22)
        Me.txDiskon.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(22, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Harga"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txHarga
        '
        Me.txHarga.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txHarga.Location = New System.Drawing.Point(107, 267)
        Me.txHarga.Name = "txHarga"
        Me.txHarga.Size = New System.Drawing.Size(268, 22)
        Me.txHarga.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Kategori"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BarangTableAdapter
        '
        Me.BarangTableAdapter.ClearBeforeFill = True
        '
        'LihatBarangTableAdapter
        '
        Me.LihatBarangTableAdapter.ClearBeforeFill = True
        '
        'LihatBarangBindingSource
        '
        Me.LihatBarangBindingSource.DataMember = "lihatBarang"
        Me.LihatBarangBindingSource.DataSource = Me.TokoRotiDataSet
        '
        'LihatBarangBindingSource1
        '
        Me.LihatBarangBindingSource1.DataMember = "lihatBarang"
        Me.LihatBarangBindingSource1.DataSource = Me.TokoRotiDataSet
        '
        'formBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 465)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formBarang"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TokoRotiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LihatBarangBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LblMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txKode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txNama As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents marginTop As Label
    Friend WithEvents marginBottom As Label
    Friend WithEvents marginLeft As Label
    Friend WithEvents marginRight As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUlang As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txStok As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txDiskon As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txHarga As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbKategori As ComboBox
    Friend WithEvents BarangTableAdapter As TokoRotiDataSetTableAdapters.barangTableAdapter
    Friend WithEvents TokoRotiDataSet As TokoRotiDataSet
    Friend WithEvents LihatBarangTableAdapter As TokoRotiDataSetTableAdapters.lihatBarangTableAdapter
    Friend WithEvents LihatBarangBindingSource As BindingSource
    Friend WithEvents LihatBarangBindingSource1 As BindingSource
End Class
