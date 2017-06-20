Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm.ProgressPanel
Imports capaDatos

Public Class frmMain

    Private inicial As Boolean = True
    Private seconds As Integer = 2
    Private wFrm As New WaitForm1

    '*************************************************Funciones************************************************************
    Private Sub llamarFormulario(frm As Form)
        If inicial = True Then SplashScreenManager.ShowForm(GetType(WaitForm1)) : timerSplash.Start()

        inicial = False
        With frm
            .MdiParent = Me
            .Show()
        End With
    End Sub
    Private Sub GestionUsuario()

        lblUsuario.Caption = String.Format("{0} / {1} {2}", xAcceso, xNombre, xApellido)
        'Controlar los accesos
        If xAcceso = "Administrador" Then

        End If
    End Sub

    '*************************************************Timer's************************************************************
    Private Sub timerSplash_Tick(sender As Object, e As EventArgs) Handles timerSplash.Tick
        seconds = seconds - 1
        If seconds = 0 Then
            SplashScreenManager.CloseForm()
            timerSplash.Stop()
            timerSplash.Dispose()
        End If

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Caption = DateTime.Now.ToString("dd/MMMM/yy  hh:mm:ss tt")
    End Sub


    '*************************************************Botones de llamada a formularios***********************************
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        llamarFormulario(frmHabitaciones)
    End Sub
    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        llamarFormulario(frmProductos)
    End Sub
    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        llamarFormulario(frmClientes)
    End Sub
    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        llamarFormulario(frmTrabajadores)
    End Sub
    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        llamarFormulario(frmReserva)
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GestionUsuario()
    End Sub

End Class