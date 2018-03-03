Public Class MainMenu
    'window
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    'login
    Public idAdmin As String
    Public admin As String
    Public lvlAdmin As String
    Public logOff As Boolean
    'kasir
    Dim pilihSelKasir As Integer = -1
    'barang
    Public editBarang As Boolean
    Public kodeBarang As String
    Public namaBarang As String
    Public kategoriBarang As String
    Public hargaBarang As Integer
    Public diskonBarang As Integer
    Public stokBarang As Integer
    Public kodeKategori As String
    'karyawan
    Dim lihatFoto As Boolean = False
    Public editKaryawan As Boolean
    Public idKaryawan As String
    Public namaKaryawan As String
    Public levelKaryawan As Integer
    Public passwordKaryawan As String
    Public fotoKaryawan As Byte()

    'dragWindow
    Private Sub PanelWindowBar_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseDown
        drag = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PanelWindowBar_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseMove
        If drag Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub PanelWindowBar_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelWindowBar.MouseUp
        drag = False
    End Sub

    'windowBar
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        logOff = False
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'MainMenu
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        refreshData()
        lblAdmin.Text = admin
        ulangForm()
        btnDashboard_Click(sender, e)
        Me.KeyPreview = True
        If lvlAdmin = 1 Then
            btnTambahKaryawan.Enabled = False
            btnEditKaryawan.Enabled = False
            btnHapusKaryawan.Enabled = False
        Else
            btnTambahKaryawan.Enabled = True
            btnEditKaryawan.Enabled = True
            btnHapusKaryawan.Enabled = True
        End If
    End Sub

    Sub refreshData()
        'TODO: This line of code loads data into the 'TokoRotiDataSet.lihatBarang' table. You can move, or remove it, as needed.
        Me.LihatBarangTableAdapter.Fill(Me.TokoRotiDataSet.lihatBarang)
        'TODO: This line of code loads data into the 'TokoRotiDataSet.penjualan' table. You can move, or remove it, as needed.
        Me.PenjualanTableAdapter.Fill(Me.TokoRotiDataSet.penjualan)
        'TODO: This line of code loads data into the 'TokoRotiDataSet.header_penjualan' table. You can move, or remove it, as needed.
        Me.Header_penjualanTableAdapter.Fill(Me.TokoRotiDataSet.header_penjualan)
        'TODO: This line of code loads data into the 'TokoRotiDataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.TokoRotiDataSet.barang)
        'TODO: This line of code loads data into the 'TokoRotiDataSet1.karyawan' table. You can move, or remove it, as needed.
        Me.KaryawanTableAdapter.Fill(Me.TokoRotiDataSet1.karyawan)
        lblDataBarang.Text = TokoRotiDataSet.barang.Count
        lblDataKaryawan.Text = TokoRotiDataSet1.karyawan.Count
        lblPenjualan.Text = Header_penjualanTableAdapter.GetDataByDashboard(Now()).Count
        lblStokBarang.Text = LihatBarangTableAdapter.stokBarang
        lblStokRoti.Text = LihatBarangTableAdapter.stok("akoi1")
        lblStokMinuman.Text = LihatBarangTableAdapter.stok("drunk")
    End Sub

    Sub ulangForm()
        PanelKontenDashboard.Visible = False
        PanelKontenKasir.Visible = False
        PanelKontenBarang.Visible = False
        PanelKontenKaryawan.Visible = False
        btnDashboard.BackColor = Color.FromArgb(52, 73, 94)
        btnKasir.BackColor = Color.FromArgb(52, 73, 94)
        btnBarang.BackColor = Color.FromArgb(52, 73, 94)
        btnKaryawan.BackColor = Color.FromArgb(52, 73, 94)
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ulangForm()
        PanelKontenDashboard.Visible = True
        btnDashboard.BackColor = Color.FromArgb(46, 136, 197)
        btnDashboard.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        LblMenu.Text = "Halaman Awal"
        LblKeteranganMenu.Text = ""
    End Sub

    Private Sub btnKasir_Click(sender As Object, e As EventArgs) Handles btnKasir.Click
        ulangForm()
        PanelKontenKasir.Visible = True
        btnKasir.BackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKasir.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        LblMenu.Text = "Menu Penjualan"
        LblKeteranganMenu.Text = "Tekan Enter Untuk Lanjut|  Tekan F1 Untuk Mencari Barang  |  Tekan F2 Untuk Membatalkan Belanja  |  Tekan F3 Untuk Membayar  |  Tekan F4 Untuk Mengulang Belanjaan"
    End Sub

    Private Sub btnBarang_Click(sender As Object, e As EventArgs) Handles btnBarang.Click
        ulangForm()
        PanelKontenBarang.Visible = True
        btnBarang.BackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnBarang.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        LblMenu.Text = "Menu Data Barang"
        LblKeteranganMenu.Text = "Tekan F1 Untuk Mencari Barang  |  Tekan F2 Untuk Menambah Data  |  Tekan F3 Untuk Mengedit Data  |  Tekan F4 Untuk Menghapus Data"
    End Sub
    Private Sub btnKaryawan_Click(sender As Object, e As EventArgs) Handles btnKaryawan.Click
        ulangForm()
        PanelKontenKaryawan.Visible = True
        btnKaryawan.BackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 136, 197)
        btnKaryawan.FlatAppearance.MouseOverBackColor = Color.FromArgb(46, 136, 197)
        LblMenu.Text = "Menu Data Karyawan"
        LblKeteranganMenu.Text = "Tekan F1 Untuk Mencari Karyawan  |  Tekan F2 Untuk Menambah Data  |  Tekan F3 Untuk Mengedit Data  |  Tekan F4 Untuk Menghapus Data  |  Tekan F5 Untuk Menampilkan / Menutup Foto"
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        logOff = True
        Me.Close()
        formLogin.Show()
    End Sub
    'Kasir
    Private Sub PanelKontenKasir_VisibleChanged(sender As Object, e As EventArgs) Handles PanelKontenKasir.VisibleChanged
        If PanelKontenKasir.Visible Then
            ulangFormKasir()
            cariKodeBarang()
            tglKasir.Value = Now()
        End If
    End Sub

    Sub ulangFormKasir()
        refreshData()
        cariKodeBarang()
        txKodeBarang.Clear()
        txNamaBarang.Clear()
        txQty.Clear()
        txDiskon.Clear()
        txHargaBarang.Clear()
        txStokBarang.Clear()
        txKategori.Clear()
        txTotal.Text = 0
        txDiskonBelanja.Text = 0
        txBayar.Text = 0
        txKembalian.Text = 0
        txTotalBelanja.Text = 0
        tabelDataKasir.Rows.Clear()
        txKodeBarang.Focus()
    End Sub

    Sub cariKodeBarang()
        Dim dt As New TokoRotiDataSet.header_penjualanDataTable
        dt = Header_penjualanTableAdapter.GetData()
        If dt.Count = 0 Then
            txNoStruk.Text = "Struk 1"
        Else
            txNoStruk.Text = "Struk " & dt.Count + 1
        End If
    End Sub

    Private Sub btnCariKodeBarang_Click(sender As Object, e As EventArgs) Handles btnCariKodeBarang.Click
        formKodeBarang.ShowDialog()
        If txKodeBarang.Text IsNot "" Then
            txQty.Focus()
        End If
    End Sub

    Private Sub txKodeBarang_KeyDown(sender As Object, e As KeyEventArgs) Handles txKodeBarang.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txKodeBarang.Text IsNot "" Then
                Dim dt As New TokoRotiDataSet.lihatBarangDataTable
                dt = LihatBarangTableAdapter.GetDataByCari(txKodeBarang.Text & "%", "")
                If dt.Count > 0 Then
                    txKodeBarang.Text = dt.Rows(0).Item(0)
                    txNamaBarang.Text = dt.Rows(0).Item(1)
                    txKategori.Text = dt.Rows(0).Item(6)
                    txHargaBarang.Text = Decimal.ToInt32(dt.Rows(0).Item(3))
                    txDiskon.Text = dt.Rows(0).Item(4)
                    txStokBarang.Text = dt.Rows(0).Item(5)
                    txQty.Focus()
                Else
                    txNamaBarang.Clear()
                    txKategori.Clear()
                    txHargaBarang.Clear()
                    txStokBarang.Clear()
                    txQty.Clear()
                    txDiskon.Clear()
                    txKodeBarang.Focus()
                End If
            Else
                txNamaBarang.Clear()
                txKategori.Clear()
                txHargaBarang.Clear()
                txStokBarang.Clear()
                txQty.Clear()
                txDiskon.Clear()
            End If
        End If
    End Sub

    Private Sub txQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txQty.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txQty.Text IsNot "" Then
                If Integer.Parse(txQty.Text) > Integer.Parse(txStokBarang.Text) Then
                    MsgBox("Stok Tinggal " & txStokBarang.Text)
                Else
                    txDiskon.Focus()
                End If
            End If
        End If
    End Sub

    Function tambahQty() As Integer
        Dim indexSel As Integer = -1
        If tabelDataKasir.RowCount > 0 Then
            For i = 0 To tabelDataKasir.RowCount - 1
                If indexSel = -1 Then
                    If txKodeBarang.Text = tabelDataKasir.Rows(i).Cells(1).Value Then
                        indexSel = i
                    Else
                        indexSel = -1
                    End If
                End If
            Next
        End If
        Return indexSel
    End Function

    Private Sub txDiskon_KeyDown(sender As Object, e As KeyEventArgs) Handles txDiskon.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txNamaBarang.Text IsNot "" And txKategori.Text IsNot "" And txHargaBarang.Text IsNot "" And txStokBarang.Text IsNot "" And txDiskon.Text IsNot "" Then
                Dim jumlah As Integer = Integer.Parse(txQty.Text) * Integer.Parse(txHargaBarang.Text)
                Dim subTotal As Integer
                Dim stok As Integer = Integer.Parse(txStokBarang.Text) - Integer.Parse(txQty.Text)
                Dim qty As Integer = Integer.Parse(txQty.Text)
                If txDiskon.Text = 0 Then
                    subTotal = jumlah
                Else
                    subTotal = jumlah - (jumlah * Integer.Parse(txDiskon.Text) / 100)
                End If
                Dim indexSel As Integer
                If tabelDataKasir.RowCount = 0 Then
                    indexSel = -1
                Else
                    indexSel = tambahQty()
                End If
                If indexSel < 0 Then
                    tabelDataKasir.Rows.Add(tabelDataKasir.RowCount + 1, txKodeBarang.Text, txNamaBarang.Text, txKategori.Text, txHargaBarang.Text, qty, txDiskon.Text, subTotal, stok)
                Else
                    subTotal = subTotal + (tabelDataKasir.Rows(indexSel).Cells(5).Value * Integer.Parse(txHargaBarang.Text))
                    stok = tabelDataKasir.Rows(indexSel).Cells(8).Value - txQty.Text
                    qty = qty + tabelDataKasir.Rows(indexSel).Cells(5).Value
                    tabelDataKasir.Rows.RemoveAt(indexSel)
                    tabelDataKasir.Rows.Add(tabelDataKasir.RowCount + 1, txKodeBarang.Text, txNamaBarang.Text, txKategori.Text, txHargaBarang.Text, qty, txDiskon.Text, subTotal, stok)
                    For i = 0 To tabelDataKasir.RowCount - 1
                        tabelDataKasir.Rows(i).Cells(0).Value = i + 1
                    Next
                End If
                tambahTotal(subTotal, 1)
                txKodeBarang.Clear()
                txNamaBarang.Clear()
                txKategori.Clear()
                txHargaBarang.Clear()
                txStokBarang.Clear()
                txDiskon.Clear()
                txQty.Clear()
                txKodeBarang.Focus()
            End If
        End If
    End Sub

    Private Sub tabelDataKasir_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataKasir.CellClick
        If e.RowIndex >= 0 Then
            pilihSelKasir = e.RowIndex
        Else
            pilihSelKasir = Nothing
        End If
    End Sub

    Sub tambahTotal(jml As Integer, status As Integer)
        Dim total As Integer
        Dim diskon As Integer
        Dim bayar As Integer
        If txTotal.Text = "" Then
            total = 0
        Else
            If status = 1 Then
                total = 0
                For i = 0 To tabelDataKasir.RowCount - 1
                    total = total + tabelDataKasir.Rows(i).Cells(7).Value
                Next
            Else
                total = Integer.Parse(txTotal.Text) - jml
            End If
        End If
        If txDiskonBelanja.Text = "" Then
            diskon = 0
        Else
            diskon = Integer.Parse(txDiskonBelanja.Text)
        End If
        If txBayar.Text = "" Then
            bayar = 0
        Else
            bayar = Integer.Parse(txBayar.Text)
        End If
        txTotal.Text = total
        If diskon = 0 And diskon <= 100 Then
            txTotalBelanja.Text = total
        Else
            txTotalBelanja.Text = total - (total * diskon / 100)
        End If

        If bayar = 0 Or bayar < Integer.Parse(txTotalBelanja.Text) Then
            txKembalian.Text = 0
        Else
            txKembalian.Text = bayar - total
        End If
    End Sub

    Private Sub txBayar_TextChanged(sender As Object, e As EventArgs) Handles txBayar.TextChanged
        Dim bayar As Integer
        Dim total As Integer
        If txBayar.Text = "" Then
            bayar = 0
        Else
            bayar = Integer.Parse(txBayar.Text)
        End If
        If txTotalBelanja.Text = "" Then
            total = 0
        Else
            total = Decimal.Parse(txTotalBelanja.Text)
        End If
        If bayar >= total Then
            txKembalian.Text = bayar - total
        Else
            txKembalian.Text = 0
        End If
    End Sub

    Private Sub txBayar_KeyDown(sender As Object, e As KeyEventArgs) Handles txBayar.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txBayar.Text >= txTotalBelanja.Text Then
                btnBayarKasir_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub txDiskonBelanja_TextChanged(sender As Object, e As EventArgs) Handles txDiskonBelanja.TextChanged
        Dim total As Integer
        Dim diskon As Integer
        If txDiskonBelanja.Text = "" Then
            diskon = 0
        Else
            diskon = Integer.Parse(txDiskonBelanja.Text)
        End If
        If txTotal.Text = "" Then
            total = 0
        Else
            total = Integer.Parse(txTotal.Text)
        End If
        If diskon = 0 Or diskon > 100 Then
            txTotalBelanja.Text = total
            txBayar_TextChanged(sender, e)
        Else
            txTotalBelanja.Text = total - (total * diskon / 100)
            txBayar_TextChanged(sender, e)
        End If
    End Sub

    Private Sub btnBayarKasir_Click(sender As Object, e As EventArgs) Handles btnBayarKasir.Click
        If Integer.Parse(txBayar.Text) < Integer.Parse(txTotalBelanja.Text) - 1 Then
            MsgBox("Uang Pembeli Tidak Cukup")
        Else
            If MsgBox("Yakin Untuk Membeli?", vbYesNo, "Konfirmasi") = vbYes Then
                Header_penjualanTableAdapter.Insert(txNoStruk.Text, idAdmin, tglKasir.Value, txDiskonBelanja.Text, txTotalBelanja.Text)
                For i = 0 To tabelDataKasir.RowCount - 1
                    Dim kode As String = tabelDataKasir.Rows(i).Cells(1).Value
                    Dim qty As Integer = Integer.Parse(tabelDataKasir.Rows(i).Cells(5).Value)
                    Dim diskon As Integer = tabelDataKasir.Rows(i).Cells(6).Value
                    PenjualanTableAdapter.Insert(txNoStruk.Text, kode, qty, diskon)
                    BarangTableAdapter.terjual(tabelDataKasir.Rows(i).Cells(8).Value, tabelDataKasir.Rows(i).Cells(1).Value)
                Next
                ulangFormKasir()
            End If
        End If
    End Sub

    'Textbox Integer
    Private Sub txBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txBayar.KeyPress
        textInt(e)
    End Sub

    Private Sub txDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskon.KeyPress
        textInt(e)
    End Sub

    Private Sub txDiskonBelanja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskonBelanja.KeyPress
        textInt(e)
    End Sub

    Private Sub txQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txQty.KeyPress
        textInt(e)
    End Sub

    'hotkey
    Private Sub MainMenu_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'kasir
        Dim hk As Keys = e.KeyCode
        If PanelKontenKasir.Visible Then
            If hk = Keys.F1 Then
                btnCariKodeBarang_Click(sender, e)
            ElseIf hk = Keys.F2 Then
                If pilihSelKasir < 0 Then
                    MsgBox("Mohon Pilih Data!")
                Else
                    If MsgBox("Yakin membatalkan belanja " & tabelDataKasir.Rows(pilihSelKasir).Cells(1).Value & "?", vbYesNo, "Konfirmasi") = vbYes Then
                        tambahTotal(tabelDataKasir.Rows(pilihSelKasir).Cells(7).Value, 2)
                        tabelDataKasir.Rows.RemoveAt(pilihSelKasir)
                        For i = 0 To tabelDataKasir.RowCount - 1
                            tabelDataKasir.Rows(i).Cells(0).Value = i + 1
                        Next
                        pilihSelKasir = -1
                    End If
                End If
            ElseIf hk = Keys.F3 Then
                If txBayar.Text = 0 Then
                    txBayar.Focus()
                Else
                    btnBayarKasir_Click(sender, e)
                End If
            ElseIf hk = Keys.F4 Then
                If MsgBox("Apakah anda yakin mengulang belanja?", vbYesNo, "Konfirmasi") = vbYes Then
                    ulangFormKasir()
                End If
            End If
        End If
        'barang
        If PanelKontenBarang.Visible Then
            If hk = Keys.F1 Then
                txCariBarang.Focus()
                txCariBarang.Select()
            ElseIf hk = Keys.F2 Then
                btnTambahBarang_Click(sender, e)
            ElseIf hk = Keys.F3 Then
                btnEditBarang_Click(sender, e)
            ElseIf hk = Keys.F4 Then
                btnHapusBarang_Click(sender, e)
            End If
        End If
        'karyawan
        If PanelKontenKaryawan.Visible Then
            If hk = Keys.F1 Then
                txCariKaryawan.Focus()
                txCariKaryawan.Select()
            ElseIf hk = Keys.F2 Then
                btnTambahKaryawan_Click(sender, e)
            ElseIf hk = Keys.F3 Then
                btnEditKaryawan_Click(sender, e)
            ElseIf hk = Keys.F4 Then
                btnHapusKaryawan_Click(sender, e)
            ElseIf hk = Keys.F5 Then
                btnLihatFoto_Click(sender, e)
            End If
        End If
    End Sub

    'lain-lain
    Sub textInt(e As KeyPressEventArgs)
        Dim key As Integer = Asc(e.KeyChar)
        If key <> 8 Then
            If key < 48 Or key > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'barang
    Private Sub PanelKontenBarang_VisibleChanged(sender As Object, e As EventArgs) Handles PanelKontenBarang.VisibleChanged
        If PanelKontenBarang.Visible Then
            Me.LihatBarangTableAdapter.Fill(Me.TokoRotiDataSet.lihatBarang)
            txCariBarang.Focus()
        End If
    End Sub

    Private Sub btnTambahBarang_Click(sender As Object, e As EventArgs) Handles btnTambahBarang.Click
        editBarang = False
        formBarang.ShowDialog()
        refreshData()
    End Sub

    Private Sub txCariBarang_TextChanged(sender As Object, e As EventArgs) Handles txCariBarang.TextChanged
        If txCariBarang.Text = "" Then
            Me.LihatBarangTableAdapter.Fill(Me.TokoRotiDataSet.lihatBarang)
        Else
            Dim kataKunci As String = "%" & txCariBarang.Text & "%"
            LihatBarangTableAdapter.FillByCari(TokoRotiDataSet.lihatBarang, kataKunci, kataKunci)
        End If
    End Sub

    Private Sub tabelDataBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataBarang.CellClick
        pilihSelBarang(e.RowIndex)
    End Sub

    Sub pilihSelBarang(ByVal e As String)
        If e >= 0 Then
            kodeBarang = tabelDataBarang.Rows(e).Cells(0).Value
            namaBarang = tabelDataBarang.Rows(e).Cells(1).Value
            kategoriBarang = tabelDataBarang.Rows(e).Cells(6).Value
            hargaBarang = Decimal.ToInt32(tabelDataBarang.Rows(e).Cells(3).Value)
            diskonBarang = tabelDataBarang.Rows(e).Cells(4).Value
            stokBarang = tabelDataBarang.Rows(e).Cells(5).Value
            kodeKategori = tabelDataBarang.Rows(e).Cells(6).Value
        End If
    End Sub

    Private Sub btnEditBarang_Click(sender As Object, e As EventArgs) Handles btnEditBarang.Click
        If kodeBarang = "" Then
            MsgBox("Mohon Pilih Data!")
        Else
            editBarang = True
            formBarang.ShowDialog()
            refreshData()
        End If
    End Sub

    Private Sub btnHapusBarang_Click(sender As Object, e As EventArgs) Handles btnHapusBarang.Click
        If kodeBarang = "" Then
            MsgBox("Mohon Pilih Data!")
        Else
            If MsgBox("Apakah Anda Yakin Menghapus " & kodeBarang & "?", vbYesNo) = vbYes Then
                BarangTableAdapter.hapus(kodeBarang)
                refreshData()
            End If
        End If
    End Sub

    'karyawan
    Private Sub btnLihatFoto_Click(sender As Object, e As EventArgs) Handles btnLihatFoto.Click
        lihatFoto = Not lihatFoto
        If lihatFoto Then
            PanelFotoKaryawan.Visible = True
            btnLihatFoto.Text = "v"
        Else
            PanelFotoKaryawan.Visible = False
            btnLihatFoto.Text = "^"
        End If
    End Sub

    Private Sub PanelKontenKaryawan_VisibleChanged(sender As Object, e As EventArgs) Handles PanelKontenKaryawan.VisibleChanged
        If PanelKontenKaryawan.Visible Then
            refreshData()
            fotoBox.BackgroundImage = Nothing
            PanelFotoKaryawan.Visible = False
            btnLihatFoto.Text = "^"
            lihatFoto = False
            txCariKaryawan.Focus()
        End If
    End Sub

    Private Sub tabelDataKaryawan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataKaryawan.CellClick
        Dim row As String = e.RowIndex
        If row >= 0 Then
            idKaryawan = tabelDataKaryawan.Rows(row).Cells(0).Value
            namaKaryawan = tabelDataKaryawan.Rows(row).Cells(1).Value
            levelKaryawan = tabelDataKaryawan.Rows(row).Cells(2).Value
            passwordKaryawan = tabelDataKaryawan.Rows(row).Cells(4).Value
            If IsDBNull(tabelDataKaryawan.Rows(row).Cells(3).Value) = False Then
                fotoKaryawan = tabelDataKaryawan.Rows(row).Cells(3).Value
                Dim ms As New IO.MemoryStream(fotoKaryawan)
                fotoBox.BackgroundImage = Image.FromStream(ms)
            Else
                fotoBox.BackgroundImage = Nothing
                fotoKaryawan = Nothing
            End If
        End If
    End Sub

    Private Sub txCariKaryawan_TextChanged(sender As Object, e As EventArgs) Handles txCariKaryawan.TextChanged
        If txCariKaryawan.Text = "" Then
            Me.KaryawanTableAdapter.Fill(Me.TokoRotiDataSet1.karyawan)
        Else
            Dim kataKunci As String = "%" & txCariKaryawan.Text & "%"
            Me.KaryawanTableAdapter.FillByCari(Me.TokoRotiDataSet1.karyawan, kataKunci, kataKunci)
        End If
    End Sub

    Private Sub btnTambahKaryawan_Click(sender As Object, e As EventArgs) Handles btnTambahKaryawan.Click
        editKaryawan = False
        formKaryawan.ShowDialog()
        refreshData()
    End Sub

    Private Sub btnEditKaryawan_Click(sender As Object, e As EventArgs) Handles btnEditKaryawan.Click
        If idKaryawan Is Nothing Then
            MsgBox("Mohon Pilih Data!")
        Else
            editKaryawan = True
            formKaryawan.ShowDialog()
            refreshData()
        End If
    End Sub

    Private Sub btnHapusKaryawan_Click(sender As Object, e As EventArgs) Handles btnHapusKaryawan.Click
        If idKaryawan = "" Then
            MsgBox("Mohon Pilih Data!")
        Else
            If MsgBox("Apakah Anda Yakin Menghapus Data " & idKaryawan & "?", vbYesNo, "Konfirmasi") = vbYes Then
                KaryawanTableAdapter.hapus(idKaryawan)
            End If
            refreshData()
        End If
    End Sub
End Class