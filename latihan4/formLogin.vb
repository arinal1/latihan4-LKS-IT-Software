Public Class formLogin
    'window
    Dim drag As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txID.Focus()
    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
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

    Private Sub txID_KeyDown(sender As Object, e As KeyEventArgs) Handles txID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txID.Text IsNot "" Then
                txPassword.Focus()
            End If
        End If
    End Sub

    Private Sub txPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txPassword.Text IsNot "" Then
                btnLogin_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txID.Text = "" Or txPassword.Text = "" Then
            MsgBox("Mohon Data Dilengkapi")
        Else
            Dim dt As TokoRotiDataSet.karyawanDataTable
            dt = KaryawanTableAdapter.GetDataByLogin(txID.Text, txPassword.Text)
            If dt.Count = 0 Then
                MsgBox("Login Gagal!")
                txPassword.Clear()
                txID.Focus()
            Else
                MainMenu.idAdmin = dt.Rows(0).Item(0)
                MainMenu.admin = dt.Rows(0).Item(1)
                MainMenu.lvlAdmin = dt.Rows(0).Item(2)
                Me.Hide()
                MainMenu.ShowDialog()
                If MainMenu.logOff = False Then
                    Me.Close()
                Else
                    txID.Clear()
                    txPassword.Clear()
                    txID.Focus()
                End If
            End If
        End If
    End Sub
End Class