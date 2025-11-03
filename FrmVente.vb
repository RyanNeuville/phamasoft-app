Public Class FrmVente
    Private Sub FrmVente_Load(sender As Object, e As EventArgs) Handles Me.Load
        AjouterCarte("Total médicaments", "248", Color.FromArgb(52, 152, 219), 300, 100)
        AjouterCarte("Proche péremption", "12", Color.FromArgb(231, 76, 60), 580, 100)
        AjouterCarte("Rupture de stock", "5", Color.FromArgb(241, 196, 15), 860, 100)
        AjouterCarte("Ventes du jour", "85 000 FCFA", Color.FromArgb(46, 204, 113), 1140, 100)
    End Sub
End Class
