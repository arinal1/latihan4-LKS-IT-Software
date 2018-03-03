Public Class formKaryawan
    Dim pasFoto As Byte()
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

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub

    Private Sub formKaryawan_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnUlang_Click(sender, e)
        If MainMenu.editKaryawan Then
            txId.Text = MainMenu.idKaryawan
            txNama.Text = MainMenu.namaKaryawan
            txPassword.Text = MainMenu.passwordKaryawan
            cbLevel.SelectedIndex = MainMenu.levelKaryawan - 1
            If MainMenu.fotoKaryawan Is Nothing Then
                fotoBox.BackgroundImage = Nothing
                pasFoto = Nothing
            Else
                pasFoto = MainMenu.fotoKaryawan
                Dim ms As New IO.MemoryStream(pasFoto)
                fotoBox.BackgroundImage = Image.FromStream(ms)
            End If
            txNama.Focus()
            txNama.Select()
        End If
    End Sub

    Private Sub btnUlang_Click(sender As Object, e As EventArgs) Handles btnUlang.Click
        txNama.Clear()
        txPassword.Clear()
        cbLevel.SelectedIndex = 0
        fotoBox.BackgroundImage = Nothing
        pasFoto = Nothing
        If MainMenu.editKaryawan Then
            txId.Enabled = False
            txNama.Focus()
            txNama.Select()
        Else
            txId.Enabled = True
            txId.Clear()
            txId.Focus()
            txId.Select()
        End If
    End Sub

    Private Sub btnFoto_Click(sender As Object, e As EventArgs) Handles btnFoto.Click
        OpenFileDialog1.Filter = "Image Files (*.jpg , *.png) | *.jpg; *.png"
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            fotoBox.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
            Dim ms As New IO.MemoryStream()
            fotoBox.BackgroundImage.Save(ms, fotoBox.BackgroundImage.RawFormat)
            pasFoto = ms.GetBuffer
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txId.Text = "" Or txNama.Text = "" Or txPassword.Text = "" Then
            MsgBox("Mohon Data Dilengkapi")
        Else
            If MainMenu.editKaryawan Then
                KaryawanTableAdapter.edit(txNama.Text, cbLevel.SelectedIndex + 1, pasFoto, txPassword.Text, txId.Text)
            Else
                KaryawanTableAdapter.Insert(txId.Text, txNama.Text, cbLevel.SelectedIndex + 1, pasFoto, txPassword.Text)
            End If
            Me.Close()
        End If
    End Sub
End Class