Public Class FrmDashboardAdmin
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'FrmDashboardAdmin
        '
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ResumeLayout(False)
    End Sub
    Private Sub FrmDashboardAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        AjouterCarte("Total médicaments", "248", Color.FromArgb(52, 152, 219), 300, 100)
        AjouterCarte("Proche péremption", "12", Color.FromArgb(231, 76, 60), 580, 100)
        AjouterCarte("Rupture de stock", "5", Color.FromArgb(241, 196, 15), 860, 100)
        AjouterCarte("Ventes du jour", "85 000 FCFA", Color.FromArgb(46, 204, 113), 1140, 100)
        InitialiserInterface()
    End Sub

    Private Sub InitialiserInterface()

        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashboardAdmin))
        pnlSidebar = New Panel()
        lblTitre = New Label()
        pbLogo = New PictureBox()
        pnlSidebar.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(40), CByte(60), CByte(80))
        pnlSidebar.Controls.Add(lblTitre)
        pnlSidebar.Controls.Add(pbLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(250, 635)
        pnlSidebar.TabIndex = 0
        ' 
        ' lblTitre
        ' 
        lblTitre.AutoSize = True
        lblTitre.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
        lblTitre.ForeColor = Color.White
        lblTitre.Location = New Point(20, 30)
        lblTitre.Name = "lblTitre"
        lblTitre.Size = New Size(147, 32)
        lblTitre.TabIndex = 0
        lblTitre.Text = "PharmaSoft"
        ' 
        ' pbLogo
        ' 
        pbLogo.Image = CType(resources.GetObject("pbLogo.Image"), Image)
        pbLogo.Location = New Point(190, 25)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(40, 40)
        pbLogo.SizeMode = PictureBoxSizeMode.Zoom
        pbLogo.TabIndex = 1
        pbLogo.TabStop = False
        ' 
        ' FrmDashboardAdmin
        ' 
        BackColor = Color.FromArgb(CByte(248), CByte(249), CByte(250))
        ClientSize = New Size(1155, 635)
        Controls.Add(pnlSidebar)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FrmDashboardAdmin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pharmacie - Administrateur"
        WindowState = FormWindowState.Maximized
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

        Dim menuItems As String() = {"Tableau de bord", "Médicaments", "Stock", "Utilisateurs", "Ventes"}
        Dim y As Integer = 120

        For Each item In menuItems
            Dim btn As New Button()
            btn.Text = "  " & item
            btn.Size = New Size(230, 50)
            btn.Location = New Point(10, y)
            btn.BackColor = Color.Transparent
            btn.ForeColor = Color.White
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.Font = New Font("Segoe UI", 10, FontStyle.Regular)
            btn.TextAlign = ContentAlignment.MiddleLeft
            btn.Tag = item ' Pour identifier plus tard

            ' Hover effet
            AddHandler btn.MouseEnter, Sub(s, e)
                                           btn.BackColor = Color.FromArgb(52, 73, 94)
                                       End Sub
            AddHandler btn.MouseLeave, Sub(s, e)
                                           btn.BackColor = Color.Transparent
                                       End Sub

            pnlSidebar.Controls.Add(btn)
            y += 55
        Next

        ' === BOUTON DÉCONNEXION EN BAS (ROUGE) ===
        Dim btnLogout As New Button()
        btnLogout.Text = "  Déconnexion"
        btnLogout.Size = New Size(230, 50)
        btnLogout.Location = New Point(10, pnlSidebar.Height - 70)
        btnLogout.BackColor = Color.FromArgb(220, 53, 69)
        btnLogout.ForeColor = Color.White
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnLogout.TextAlign = ContentAlignment.MiddleLeft


        AddHandler pnlSidebar.SizeChanged, Sub()
                                               btnLogout.Location = New Point(10, pnlSidebar.Height - 70)
                                           End Sub

        pnlSidebar.Controls.Add(btnLogout)


        ' === PANEL HEADER ===
        Dim pnlHeader As New Panel()
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Height = 70
        pnlHeader.BackColor = Color.White
        pnlHeader.BorderStyle = BorderStyle.None

        ' Ombre douce
        Dim shadow As New Panel()
        shadow.Dock = DockStyle.Bottom
        shadow.Height = 1
        shadow.BackColor = Color.FromArgb(220, 220, 220)
        pnlHeader.Controls.Add(shadow)

        Me.Controls.Add(pnlHeader)

        ' === TITRE DU MODULE ===
        Dim lblModule As New Label()
        lblModule.Name = "lblModuleTitle"
        lblModule.Text = "Tableau de bord"
        lblModule.Font = New Font("Segoe UI", 16, FontStyle.Regular)
        lblModule.ForeColor = Color.FromArgb(44, 62, 80)
        lblModule.AutoSize = True
        lblModule.Location = New Point(25, 22)
        pnlHeader.Controls.Add(lblModule)

        ' Utilisateur
        Dim lblUser As New Label()
        lblUser.Text = "Admin"
        lblUser.Font = New Font("Segoe UI", 10)
        lblUser.ForeColor = Color.FromArgb(100, 100, 100)
        lblUser.AutoSize = True
        lblUser.Location = New Point(Me.Width - 180, 25)
        pnlHeader.Controls.Add(lblUser)

        ' === CONTENU ===
        pnlContent = New Panel()
        pnlContent.Dock = DockStyle.Fill
        pnlContent.BackColor = Color.FromArgb(248, 249, 250)
        pnlContent.AutoScroll = True
        Me.Controls.Add(pnlContent)

    End Sub
End Class
