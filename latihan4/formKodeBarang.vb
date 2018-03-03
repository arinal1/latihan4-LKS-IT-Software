Public Class formKodeBarang
    'window
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    'tabel
    Dim kode As String
    Dim nama As String
    Dim kategori As String
    Dim harga As Decimal
    Dim diskon As Integer
    Dim stok As Integer

    Private Sub cariKodeBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TokoRotiDataSet.lihatBuku' table. You can move, or remove it, as needed.
        Me.LihatBarangTableAdapter.Fill(Me.TokoRotiDataSet.lihatBarang)
        kode = ""
        txCari.Clear()
        txCari.Focus()
        txCari.Select()
    End Sub
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
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub tabelDataBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabelDataBarang.CellClick
        pilihSel(e.RowIndex)
    End Sub

    Sub pilihSel(ByVal e As String)
        If e >= 0 Then
            kode = tabelDataBarang.Rows(e).Cells(0).Value
            nama = tabelDataBarang.Rows(e).Cells(1).Value
            kategori = tabelDataBarang.Rows(e).Cells(6).Value
            harga = Decimal.ToInt32(tabelDataBarang.Rows(e).Cells(3).Value)
            diskon = tabelDataBarang.Rows(e).Cells(4).Value
            stok = tabelDataBarang.Rows(e).Cells(5).Value
        End If
    End Sub

    Private Sub btnPilih_Click(sender As Object, e As EventArgs) Handles btnPilih.Click
        If String.IsNullOrEmpty(kode) Then
            MsgBox("Mohon Pilih Data")
        Else
            MainMenu.txKodeBarang.Text = kode
            MainMenu.txNamaBarang.Text = nama
            MainMenu.txkategori.text = kategori
            MainMenu.txHargaBarang.Text = harga
            MainMenu.txStokBarang.Text = stok
            MainMenu.txDiskon.Text = diskon
            Me.Close()
            MainMenu.txQty.Focus()
        End If
    End Sub

    Private Sub txCari_TextChanged(sender As Object, e As EventArgs) Handles txCari.TextChanged
        If txCari.Text = "" Then
            Me.LihatBarangTableAdapter.Fill(Me.TokoRotiDataSet.lihatBarang)
        Else
            Dim kataKunci As String = "%" & txCari.Text & "%"
            LihatBarangTableAdapter.FillByCari(TokoRotiDataSet.lihatBarang, kataKunci, kataKunci)
        End If
    End Sub
End Class