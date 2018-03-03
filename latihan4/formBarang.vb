Public Class formBarang
    'window
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer


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

    Private Sub formBarang_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'TokoRotiDataSet.lihatBarang' table. You can move, or remove it, as needed.
        Me.LihatBarangTableAdapter.Fill(Me.TokoRotiDataSet.lihatBarang)
        'TODO: This line of code loads data into the 'TokoRotiDataSet.barang' table. You can move, or remove it, as needed.
        Me.BarangTableAdapter.Fill(Me.TokoRotiDataSet.barang)
        btnUlang_Click(sender, e)
        If MainMenu.editBarang Then
            txKode.Text = MainMenu.kodeBarang
            txNama.Text = MainMenu.namaBarang
            txHarga.Text = MainMenu.hargaBarang
            txDiskon.Text = MainMenu.diskonBarang
            txStok.Text = MainMenu.stokBarang
            cbKategori.Text = MainMenu.kategoriBarang
            txNama.Focus()
            txNama.Select()
        End If
    End Sub
    Private Sub btnUlang_Click(sender As Object, e As EventArgs) Handles btnUlang.Click
        txNama.Clear()
        txHarga.Clear()
        txDiskon.Clear()
        txStok.Clear()
        If MainMenu.editBarang Then
            txKode.Enabled = False
            txNama.Focus()
            txNama.Select()
        Else
            txKode.Enabled = True
            txKode.Clear()
            txKode.Focus()
            txKode.Select()
        End If
    End Sub

    Sub textInt(e As KeyPressEventArgs)
        Dim key As Integer = Asc(e.KeyChar)
        If key <> 8 Then
            If key < 48 Or key > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txHarga.KeyPress
        textInt(e)
    End Sub

    Private Sub txDiskon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txDiskon.KeyPress
        textInt(e)
    End Sub

    Private Sub txStok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txStok.KeyPress
        textInt(e)
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txKode.Text = "" Or txNama.Text = "" Or txHarga.Text = "" Or txDiskon.Text = "" Or txStok.Text = "" Then
            MsgBox("Mohon Data Dilengkapi")
        Else
            If MainMenu.editBarang Then
                BarangTableAdapter.edit(txNama.Text, cbKategori.SelectedValue, txHarga.Text, txDiskon.Text, txStok.Text, txKode.Text)
            Else
                BarangTableAdapter.Insert(txKode.Text, txNama.Text, cbKategori.SelectedValue, txHarga.Text, txDiskon.Text, txStok.Text)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class