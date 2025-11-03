<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDashboardAdmin
    Inherits System.Windows.Forms.Form

    Private pnlContent As Panel ' Déclaré ici pour être accessible partout



    ' === MÉTHODE POUR AJOUTER UNE CARTE ===
    Private Sub AjouterCarte(titre As String, valeur As String, couleur As Color, x As Integer, y As Integer)
        Dim card As New Panel()
        card.Size = New Size(260, 130)
        card.Location = New Point(x, y)
        card.BackColor = Color.White
        card.BorderStyle = BorderStyle.None

        ' === OMBRE DOUCE (CORRIGÉ) ===
        AddHandler card.Paint, Sub(s, e)
                                   Using p As New Pen(Color.FromArgb(200, 200, 200), 1)
                                       e.Graphics.DrawRectangle(p, 0, 0, card.Width - 1, card.Height - 1)
                                   End Using
                               End Sub

        ' Titre
        Dim lblT As New Label()
        lblT.Text = titre
        lblT.Font = New Font("Segoe UI", 10)
        lblT.ForeColor = Color.FromArgb(120, 120, 120)
        lblT.Location = New Point(20, 20)
        card.Controls.Add(lblT)

        ' Valeur
        Dim lblV As New Label()
        lblV.Text = valeur
        lblV.Font = New Font("Segoe UI", 18, FontStyle.Bold)
        lblV.ForeColor = couleur
        lblV.AutoSize = True
        lblV.Location = New Point(20, 50)
        card.Controls.Add(lblV)

        pnlContent.Controls.Add(card)
    End Sub



    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents lblTitre As Label
    Friend WithEvents pbLogo As PictureBox

End Class
