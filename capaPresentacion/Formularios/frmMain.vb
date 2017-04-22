Public Class frmMain

    Private Sub llamarFormulario(frm As Form)
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Caption = DateTime.Now.ToString("dd/MMMM/yy  hh:mm:ss tt")
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        llamarFormulario(frmHabitaciones)
    End Sub



    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        llamarFormulario(frmProductos)
    End Sub
End Class