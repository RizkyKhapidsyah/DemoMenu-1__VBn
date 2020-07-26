Public Class Form1

    Private Sub mnuFileKeluar_Click(sender As Object, e As EventArgs) Handles mnuFileKeluar.Click
        'Menutup form
        Me.Close()
    End Sub

    Private Sub mnuWarnaMerah_Click(sender As Object, e As EventArgs) Handles mnuWarnaMerah.Click
        'Menetapkan warna label menjadi merah
        labelPesan.ForeColor = Color.Red
    End Sub

    Private Sub mnuWarnaHijau_Click(sender As Object, e As EventArgs) Handles mnuWarnaHijau.Click
        'Menetapkan warna label menjadi hijau
        labelPesan.ForeColor = Color.Green
    End Sub

    Private Sub mnuWarnaBiru_Click(sender As Object, e As EventArgs) Handles mnuWarnaBiru.Click
        'Menetapkan warna label menjadi biru
        labelPesan.ForeColor = Color.Blue
    End Sub

    Private Sub mnuWarnaHitam_Click(sender As Object, e As EventArgs) Handles mnuWarnaHitam.Click
        'Menetapkan warna label menjadi hitam
        labelPesan.ForeColor = Color.Black
    End Sub

    Private Sub mnuWarnaVisibel_Click(sender As Object, e As EventArgs) Handles mnuWarnaVisibel.Click
        'Membuat label terlihat atau hilang
        If mnuWarnaVisibel.Checked = True Then
            labelPesan.Visible = True
        Else
            labelPesan.Visible = False
        End If
    End Sub

    Private Sub mnuHelpTentang_Click(sender As Object, e As EventArgs) Handles mnuHelpTentang.Click
        'Menampilkan sebuah kotak Tentang sederhana
        MessageBox.Show("Sebuah Demo Sistem Menu Sederhana")
    End Sub
End Class
