<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKodeBarang
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
        Me.LblMenu = New System.Windows.Forms.Label()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnPilih = New System.Windows.Forms.Button()
        Me.marginTop = New System.Windows.Forms.Label()
        Me.marginBottom = New System.Windows.Forms.Label()
        Me.marginLeft = New System.Windows.Forms.Label()
        Me.marginRight = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tabelDataBarang = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txCari = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TokoRotiDataSet = New latihan4.TokoRotiDataSet()
        Me.LihatBarangTableAdapter = New latihan4.TokoRotiDataSetTableAdapters.lihatBarangTableAdapter()
        Me.LihatBarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KodebarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamabarangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamakategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HargaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DiskonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StokDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodekategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TokoRotiDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblMenu
        '
        Me.LblMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.LblMenu.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMenu.ForeColor = System.Drawing.Color.White
        Me.LblMenu.Location = New System.Drawing.Point(0, 30)
        Me.LblMenu.Name = "LblMenu"
        Me.LblMenu.Size = New System.Drawing.Size(623, 70)
        Me.LblMenu.TabIndex = 2
        Me.LblMenu.Text = "Cari Kode Barang"
        Me.LblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.PanelHeader.Controls.Add(Me.LblMenu)
        Me.PanelHeader.Controls.Add(Me.PanelWindowBar)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(623, 100)
        Me.PanelHeader.TabIndex = 1
        '
        'PanelWindowBar
        '
        Me.PanelWindowBar.Controls.Add(Me.btnKeluar)
        Me.PanelWindowBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelWindowBar.Location = New System.Drawing.Point(0, 0)
        Me.PanelWindowBar.Name = "PanelWindowBar"
        Me.PanelWindowBar.Size = New System.Drawing.Size(623, 30)
        Me.PanelWindowBar.TabIndex = 1
        '
        'btnKeluar
        '
        Me.btnKeluar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKeluar.FlatAppearance.BorderSize = 0
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.ForeColor = System.Drawing.Color.White
        Me.btnKeluar.Location = New System.Drawing.Point(593, 0)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(30, 30)
        Me.btnKeluar.TabIndex = 2
        Me.btnKeluar.Text = "x"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnPilih
        '
        Me.btnPilih.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnPilih.FlatAppearance.BorderSize = 0
        Me.btnPilih.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPilih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPilih.ForeColor = System.Drawing.Color.White
        Me.btnPilih.Location = New System.Drawing.Point(516, 120)
        Me.btnPilih.Name = "btnPilih"
        Me.btnPilih.Size = New System.Drawing.Size(85, 40)
        Me.btnPilih.TabIndex = 2
        Me.btnPilih.Text = "Pilih"
        Me.btnPilih.UseVisualStyleBackColor = False
        '
        'marginTop
        '
        Me.marginTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.marginTop.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginTop.ForeColor = System.Drawing.Color.White
        Me.marginTop.Location = New System.Drawing.Point(10, 100)
        Me.marginTop.Name = "marginTop"
        Me.marginTop.Size = New System.Drawing.Size(603, 10)
        Me.marginTop.TabIndex = 8
        Me.marginTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marginBottom
        '
        Me.marginBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.marginBottom.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginBottom.ForeColor = System.Drawing.Color.White
        Me.marginBottom.Location = New System.Drawing.Point(10, 478)
        Me.marginBottom.Name = "marginBottom"
        Me.marginBottom.Size = New System.Drawing.Size(603, 10)
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
        Me.marginLeft.Size = New System.Drawing.Size(10, 388)
        Me.marginLeft.TabIndex = 10
        Me.marginLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'marginRight
        '
        Me.marginRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.marginRight.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marginRight.ForeColor = System.Drawing.Color.White
        Me.marginRight.Location = New System.Drawing.Point(613, 100)
        Me.marginRight.Name = "marginRight"
        Me.marginRight.Size = New System.Drawing.Size(10, 388)
        Me.marginRight.TabIndex = 11
        Me.marginRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.tabelDataBarang)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnPilih)
        Me.Panel1.Controls.Add(Me.txCari)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.marginTop)
        Me.Panel1.Controls.Add(Me.marginBottom)
        Me.Panel1.Controls.Add(Me.marginLeft)
        Me.Panel1.Controls.Add(Me.marginRight)
        Me.Panel1.Controls.Add(Me.PanelHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 490)
        Me.Panel1.TabIndex = 16
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
        Me.tabelDataBarang.Location = New System.Drawing.Point(10, 180)
        Me.tabelDataBarang.MultiSelect = False
        Me.tabelDataBarang.Name = "tabelDataBarang"
        Me.tabelDataBarang.ReadOnly = True
        Me.tabelDataBarang.RowHeadersVisible = False
        Me.tabelDataBarang.Size = New System.Drawing.Size(603, 298)
        Me.tabelDataBarang.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(603, 10)
        Me.Label1.TabIndex = 15
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txCari
        '
        Me.txCari.Location = New System.Drawing.Point(53, 130)
        Me.txCari.Name = "txCari"
        Me.txCari.Size = New System.Drawing.Size(225, 20)
        Me.txCari.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Cari"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(10, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(603, 60)
        Me.Label12.TabIndex = 12
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TokoRotiDataSet
        '
        Me.TokoRotiDataSet.DataSetName = "TokoRotiDataSet"
        Me.TokoRotiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.HargaDataGridViewTextBoxColumn.HeaderText = "Harga"
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
        'formKodeBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 490)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formKodeBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "cariKodeBarang"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tabelDataBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TokoRotiDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LihatBarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblMenu As Label
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnPilih As Button
    Friend WithEvents marginTop As Label
    Friend WithEvents marginBottom As Label
    Friend WithEvents marginLeft As Label
    Friend WithEvents marginRight As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tabelDataBarang As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents txCari As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TokoRotiDataSet As TokoRotiDataSet
    Friend WithEvents LihatBarangTableAdapter As TokoRotiDataSetTableAdapters.lihatBarangTableAdapter
    Friend WithEvents LihatBarangBindingSource As BindingSource
    Friend WithEvents KodebarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamabarangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamakategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HargaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DiskonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StokDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KodekategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
