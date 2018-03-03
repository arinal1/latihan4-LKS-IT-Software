<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.LblMenu = New System.Windows.Forms.Label()
        Me.PanelWindowBar = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.marginTop = New System.Windows.Forms.Label()
        Me.marginBottom = New System.Windows.Forms.Label()
        Me.marginLeft = New System.Windows.Forms.Label()
        Me.marginRight = New System.Windows.Forms.Label()
        Me.txPassword = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txID = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.KaryawanTableAdapter = New latihan4.TokoRotiDataSetTableAdapters.karyawanTableAdapter()
        Me.PanelHeader.SuspendLayout()
        Me.PanelWindowBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.LblMenu.Text = "Masuk"
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
        Me.marginBottom.Location = New System.Drawing.Point(25, 338)
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
        Me.marginLeft.Size = New System.Drawing.Size(25, 248)
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
        Me.marginRight.Size = New System.Drawing.Size(25, 248)
        Me.marginRight.TabIndex = 11
        Me.marginRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txPassword
        '
        Me.txPassword.Location = New System.Drawing.Point(25, 236)
        Me.txPassword.Name = "txPassword"
        Me.txPassword.Size = New System.Drawing.Size(348, 20)
        Me.txPassword.TabIndex = 1
        Me.txPassword.UseSystemPasswordChar = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(22, 137)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "ID Karyawan"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(22, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Password"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txID
        '
        Me.txID.Location = New System.Drawing.Point(25, 159)
        Me.txID.Name = "txID"
        Me.txID.Size = New System.Drawing.Size(348, 20)
        Me.txID.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.btnLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(25, 298)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(348, 40)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Masuk"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txPassword)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.marginTop)
        Me.Panel1.Controls.Add(Me.marginBottom)
        Me.Panel1.Controls.Add(Me.marginLeft)
        Me.Panel1.Controls.Add(Me.marginRight)
        Me.Panel1.Controls.Add(Me.PanelHeader)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 350)
        Me.Panel1.TabIndex = 15
        '
        'KaryawanTableAdapter
        '
        Me.KaryawanTableAdapter.ClearBeforeFill = True
        '
        'formLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 350)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formLogin"
        Me.PanelHeader.ResumeLayout(False)
        Me.PanelWindowBar.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents LblMenu As Label
    Friend WithEvents PanelWindowBar As Panel
    Friend WithEvents btnKeluar As Button
    Friend WithEvents marginTop As Label
    Friend WithEvents marginBottom As Label
    Friend WithEvents marginLeft As Label
    Friend WithEvents marginRight As Label
    Friend WithEvents txPassword As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txID As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents KaryawanTableAdapter As TokoRotiDataSetTableAdapters.karyawanTableAdapter
End Class
