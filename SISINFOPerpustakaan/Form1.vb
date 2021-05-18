Public Class MenuUtama
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Select Case MsgBox("Yakin ingin keluar?", MsgBoxStyle.YesNo, "Keluar")
            Case MsgBoxResult.Yes
                Me.Close()
        End Select
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If (Me.WindowState = FormWindowState.Normal) Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnDataMaster_Click(sender As Object, e As EventArgs) Handles btnDataMaster.Click
        lblHover1.Visible = True
        lblHover2.Visible = False
        lblHover3.Visible = False
        lblHover4.Visible = False
        lblHover5.Visible = False
        lblHover6.Visible = False

        pnlDataMaster.Visible = True
        pnlLaporan.Visible = False
        pnlTransaksi.Visible = False
    End Sub

    Private Sub btnTransaksi_Click(sender As Object, e As EventArgs) Handles btnTransaksi.Click
        lblHover1.Visible = False
        lblHover2.Visible = True
        lblHover3.Visible = False
        lblHover4.Visible = False
        lblHover5.Visible = False
        lblHover6.Visible = False

        pnlDataMaster.Visible = False
        pnlLaporan.Visible = False
        pnlTransaksi.Visible = True
    End Sub

    Private Sub btnLaporan_Click(sender As Object, e As EventArgs) Handles btnLaporan.Click
        lblHover1.Visible = False
        lblHover2.Visible = False
        lblHover3.Visible = True
        lblHover4.Visible = False
        lblHover5.Visible = False
        lblHover6.Visible = False

        pnlDataMaster.Visible = False
        pnlLaporan.Visible = True
        pnlTransaksi.Visible = False
    End Sub

    Private Sub btnLainnya_Click(sender As Object, e As EventArgs) Handles btnLainnya.Click
        lblHover1.Visible = False
        lblHover2.Visible = False
        lblHover3.Visible = False
        lblHover4.Visible = True
        lblHover5.Visible = False
        lblHover6.Visible = False
    End Sub

    Private Sub btnTentangAplikasi_Click(sender As Object, e As EventArgs) Handles btnTentangAplikasi.Click
        lblHover1.Visible = False
        lblHover2.Visible = False
        lblHover3.Visible = False
        lblHover4.Visible = False
        lblHover5.Visible = True
        lblHover6.Visible = False
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        lblHover1.Visible = False
        lblHover2.Visible = False
        lblHover3.Visible = False
        lblHover4.Visible = False
        lblHover5.Visible = False
        lblHover6.Visible = True
    End Sub

End Class
