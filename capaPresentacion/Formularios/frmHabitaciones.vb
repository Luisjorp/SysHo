Imports System.Threading
Imports capaEntidad
Imports capaNegocios
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraReports.UI

Public Class frmHabitaciones
    '**************************************VARIABLES INICIALES********************************
    Private accion As String = "guardar"
    Private seconds As Integer = 2
    Private grid_index = -1

    '**************************************BASE DE DATOS**************************************
    Public Sub cargar_Habitaciones()
        Dim objeto As New cnHabitacion
        Dim datos As New DataTable
        datos = objeto.RN_listarHabitaciones
        GridControl1.DataSource = datos
        GridView1.Columns("numero").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        GridView1.Focus()

        If GridView1.RowCount <> 0 Then
            lblTotalRegistros.Text = ((GridView1.RowCount).ToString + " habitaciones registradas en el sistema.")
        Else
            lblTotalRegistros.Text = "No se han registrado habitaciones aún."
        End If
    End Sub
    Public Sub cargar_IDHabitacion()
        Dim objeto As New cnHabitacion
        txtidHabitacion.Text = objeto.RN_nextID_Habitacion
    End Sub
    Public Sub ingresar_Habitacion()
        Dim obj As New cnHabitacion
        Dim enHab As New ceHabitacion

        enHab.numero = txtNoHabitacion.Text
        enHab.Piso = cboxPiso.Text
        enHab.Descripcion = txtDescripcion.Text
        enHab.Caracteristicas = txtCaracteristicas.Text
        enHab.precioDiario = txtPrecioDiario.Text
        enHab.estado = cboxEstado.Text
        enHab.tipoHabitacion = cboxTipoHabitacion.Text

        obj.RN_ingresarHabitacion(enHab)
    End Sub
    Public Sub Actualizar_Habitacion()
        Dim obj As New cnHabitacion
        Dim enHab As New ceHabitacion
        enHab.idHabitacion = txtidHabitacion.Text
        enHab.numero = txtNoHabitacion.Text
        enHab.Piso = cboxPiso.Text
        enHab.Descripcion = txtDescripcion.Text
        enHab.Caracteristicas = txtCaracteristicas.Text
        enHab.precioDiario = txtPrecioDiario.Text
        enHab.estado = cboxEstado.Text
        enHab.tipoHabitacion = cboxTipoHabitacion.Text

        obj.RN_actualizarHabitacion(enHab)
    End Sub
    Public Sub Eliminar_Habitacion(valorID As String)
        Dim obj As New cnHabitacion
        Dim enHab As New ceHabitacion
        enHab.idHabitacion = valorID

        obj.RN_eliminarHabitacion(enHab)
    End Sub

    '*************************************FUNCIONES Y METODOS DEL FORMULARIO******************
    Private Sub inhabilitarCampos()
        txtidHabitacion.Enabled = False
        txtNoHabitacion.Enabled = False
        cboxPiso.Enabled = False
        txtCaracteristicas.Enabled = False
        txtDescripcion.Enabled = False
        txtPrecioDiario.Enabled = False
        cboxEstado.Enabled = False
        cboxTipoHabitacion.Enabled = False

        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        txtidHabitacion.Text = ""
        txtNoHabitacion.Text = ""
        txtPrecioDiario.Text = ""
        txtCaracteristicas.Text = ""
        txtDescripcion.Text = ""
        cboxEstado.SelectedItem = Nothing
        cboxTipoHabitacion.SelectedItem = Nothing
    End Sub
    Private Sub habilitarCampos()
        txtidHabitacion.Enabled = True
        txtNoHabitacion.Enabled = True
        cboxPiso.Enabled = True
        txtCaracteristicas.Enabled = True
        txtDescripcion.Enabled = True
        txtPrecioDiario.Enabled = True
        cboxEstado.Enabled = True
        cboxTipoHabitacion.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        txtidHabitacion.Text = ""
        txtPrecioDiario.Text = ""
        txtCaracteristicas.Text = ""
        txtDescripcion.Text = ""
    End Sub
    Private Sub habilitarCamposEdicion()
        txtidHabitacion.Enabled = True
        txtNoHabitacion.Enabled = True
        cboxPiso.Enabled = True
        txtCaracteristicas.Enabled = True
        txtDescripcion.Enabled = True
        txtPrecioDiario.Enabled = True
        cboxEstado.Enabled = True
        cboxTipoHabitacion.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
    End Sub
    Private Sub pasarCamposEdicion()
        txtidHabitacion.Text = GridView1.GetRowCellValue(grid_index, "idHabitacion").ToString
        txtNoHabitacion.Text = GridView1.GetRowCellValue(grid_index, "numero").ToString
        cboxPiso.Text = GridView1.GetRowCellValue(grid_index, "piso").ToString
        txtDescripcion.Text = GridView1.GetRowCellValue(grid_index, "descripcion").ToString
        txtCaracteristicas.Text = GridView1.GetRowCellValue(grid_index, "caracteristicas").ToString
        txtPrecioDiario.Text = GridView1.GetRowCellValue(grid_index, "precioDiario").ToString
        cboxEstado.Text = GridView1.GetRowCellValue(grid_index, "estado").ToString
        cboxTipoHabitacion.Text = GridView1.GetRowCellValue(grid_index, "tipoHabitacion").ToString
    End Sub
    '*************************************EVENTOS DEL FORMULARIO******************************
    Private Sub frmHabitaciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        inhabilitarCampos()
    End Sub

    '*************************************EVENTOS DE GRID***********************************
    Private Sub GridView1_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles GridView1.RowCellClick
        If e.Button = MouseButtons.Right Then
            Try
                GridView1.SelectRow(e.RowHandle)
                grid_index = e.RowHandle
                If grid_index >= 0 Then
                    puMenu_gridHabitaciones.ShowPopup(e.Location, GridView1)
                    puMenu_gridHabitaciones.ShowPopup(Cursor.Position)
                    pu_btn_Editar.Caption = "Editar información de la habitación " + GridView1.GetRowCellValue(grid_index, "numero").ToString
                    pu_btn_Eliminar.Caption = "Eliminar registro de la habitación " + GridView1.GetRowCellValue(grid_index, "numero").ToString
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    '*************************************EVENTOS DE CONTROLES******************************
    'Formulario Registro
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        habilitarCampos()
        cargar_IDHabitacion()
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        accion = "guardar"
        txtNoHabitacion.Focus()

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNoHabitacion.Text = "" Then
            MsgBox("Ingresa el número de habitación a registrar.", MsgBoxStyle.Exclamation, "¡Falta el número de habitación!")
            txtNoHabitacion.Focus()
        Else
            If cboxPiso.SelectedItem = Nothing Then
                MsgBox("Selecciona el piso de la habitación", MsgBoxStyle.Exclamation, "¡Falta el piso donde se ubica la habitación!")
                cboxPiso.Focus()
            Else
                If txtDescripcion.Text = "" Then
                    MsgBox("Ingresa una descripción para la habitación", MsgBoxStyle.Exclamation, "¡Falta la descripción de la habitación!")
                    txtDescripcion.Focus()
                Else
                    If txtCaracteristicas.Text = "" Then
                        MsgBox("Ingresa las características y servicios de la habitación", MsgBoxStyle.Exclamation, "¡Faltan las características de la habitación!")
                        txtCaracteristicas.Focus()
                    Else
                        If txtPrecioDiario.Text = "" Then
                            MsgBox("Establece el precio diario (costo) de la habitación", MsgBoxStyle.Exclamation, "¡Falta el precio diario de la habitación!")
                            txtPrecioDiario.Focus()
                        Else
                            If cboxEstado.SelectedItem = Nothing Then
                                MsgBox("Establece el estado de la habitación", MsgBoxStyle.Exclamation, "¡Falta el estado actual de la habitación!")
                                cboxEstado.Focus()
                            Else
                                If cboxTipoHabitacion.SelectedItem = Nothing Then
                                    MsgBox("Falta establecer el tipo de habitación", MsgBoxStyle.Exclamation, "¡Falta el tipo de habitación!")
                                    cboxTipoHabitacion.Focus()
                                Else
                                    'CUANDO TODOS LOS CAMPOS ESTAN COMPLETOS
                                    If accion = "guardar" Then
                                        Call ingresar_Habitacion()
                                    ElseIf accion = "actualizar" Then
                                        Call Actualizar_Habitacion()
                                    End If

                                    Call cargar_Habitaciones()
                                    Dim idSeleccionFila As String = txtidHabitacion.Text
                                    Call inhabilitarCampos()
                                    btnNuevo.Enabled = True

                                    'En este apartado se selecciona la nueva fila, o bien ya sea la editada, para no perder el foco de la misma.
                                    For i As Integer = 0 To GridView1.RowCount - 1
                                        If GridView1.GetRowCellValue(i, "idHabitacion") = idSeleccionFila Then
                                            GridView1.FocusedRowHandle = i
                                        End If
                                    Next
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        inhabilitarCampos()
        btnNuevo.Enabled = True
    End Sub

    'Grupo Lista
    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        Dim report As New reporteHabitaciones()
        Dim cnhab As New cnHabitacion
        report.BindingSource1.DataSource = cnhab.RN_listarHabitaciones

        Using printool As New ReportPrintTool(report)
            printool.ShowPreviewDialog()
        End Using
    End Sub
    Private Sub btnCargarLista_Click(sender As Object, e As EventArgs) Handles btnCargarLista.Click
        SplashScreenManager.ShowForm(GetType(WaitForm1))
        With btnCargarLista
            .Enabled = False
        End With
        Timer1.Start()
    End Sub
    Private Sub txtBuscar_EditValueChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        Select Case btnDD_Filtro.Text
            Case "Características"
                GridView1.ActiveFilterString = String.Format("[caracteristicas] Like '%{0}%'", txtBuscar.Text)
            Case "Descripción"
                GridView1.ActiveFilterString = String.Format("[descripcion] Like '%{0}%'", txtBuscar.Text)
            Case "Estado"
                GridView1.ActiveFilterString = String.Format("[estado] Like '%{0}%'", txtBuscar.Text)
            Case "Precio"
                GridView1.ActiveFilterString = String.Format("[precioDiario] Like '%{0}%'", txtBuscar.Text)
            Case "Piso"
                GridView1.ActiveFilterString = String.Format("[piso] Like '%{0}%'", txtBuscar.Text)
            Case "Tipo de Habitación"
                GridView1.ActiveFilterString = String.Format("[tipoHabitacion] Like '%{0}%'", txtBuscar.Text)
            Case "No. de Habitación"
                GridView1.ActiveFilterString = String.Format("[numero] Like '%{0}%'", txtBuscar.Text)
            Case Else
                GridView1.ActiveFilterString = String.Format("[caracteristicas] Like '%{0}%'", txtBuscar.Text)
        End Select

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        seconds = seconds - 1
        If seconds = 0 Then
            SplashScreenManager.CloseForm()
            cargar_Habitaciones()

        End If
    End Sub

    'Pop Up Menu's
    'Pop Up GridView
    Private Sub pu_btn_Editar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Editar.ItemClick
        pasarCamposEdicion()
        habilitarCamposEdicion()
        btnNuevo.Enabled = False
        btnGuardar.Text = "Actualizar"
        accion = "actualizar"
    End Sub
    Private Sub pu_btn_Eliminar_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Eliminar.ItemClick
        Dim result As Integer = MessageBox.Show(Me, "¿Realmente desea eliminar esta habitación del sistema?", "ESTÁ A PUNTO DE ELIMINAR UN REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then

            Dim idSeleccionFila As String = (GridView1.GetRowCellValue(grid_index, "numero") + 1).ToString
            Eliminar_Habitacion(GridView1.GetRowCellValue(grid_index, "idHabitacion").ToString)

            Call cargar_Habitaciones()
            Call inhabilitarCampos()
            btnNuevo.Enabled = True

            'En este apartado se selecciona la nueva fila, o bien ya sea la editada, para no perder el foco de la misma.
            For i As Integer = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(i, "numero") = idSeleccionFila Then
                    GridView1.FocusedRowHandle = i
                End If
            Next
        End If
    End Sub

    'Pop Up Filtro Busqueda

    Private Sub pu_btn_Car_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Car.ItemClick
        btnDD_Filtro.Text = "Características"
        GridView1.ActiveFilterString = String.Format("[caracteristicas] Like '%{0}%'", txtBuscar.Text)

    End Sub
    Private Sub pu_btn_Desc_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Desc.ItemClick
        btnDD_Filtro.Text = "Descripción"
        GridView1.ActiveFilterString = String.Format("[descripcion] Like '%{0}%'", txtBuscar.Text)
    End Sub
    Private Sub pu_btn_Estado_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Estado.ItemClick
        btnDD_Filtro.Text = "Estado"
        GridView1.ActiveFilterString = String.Format("[estado] Like '%{0}%'", txtBuscar.Text)
    End Sub
    Private Sub pu_btn_Piso_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Piso.ItemClick
        btnDD_Filtro.Text = "Piso"
        GridView1.ActiveFilterString = String.Format("[piso] Like '%{0}%'", txtBuscar.Text)
    End Sub
    Private Sub pu_btn_Precio_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Precio.ItemClick
        btnDD_Filtro.Text = "Precio"
        GridView1.ActiveFilterString = String.Format("[precioDiario] Like '%{0}%'", txtBuscar.Text)

    End Sub
    Private Sub pu_btn_Tipo_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Tipo.ItemClick
        btnDD_Filtro.Text = "Tipo de Habitación"
        GridView1.ActiveFilterString = String.Format("[tipoHabitacion] Like '%{0}%'", txtBuscar.Text)

    End Sub
    Private Sub pu_btn_Numero_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Numero.ItemClick
        btnDD_Filtro.Text = "No. de Habitación"
        GridView1.ActiveFilterString = String.Format("[numero] Like '%{0}%'", txtBuscar.Text)

    End Sub

    Private Sub btnDD_Filtro_TextChanged(sender As Object, e As EventArgs) Handles btnDD_Filtro.TextChanged
        txtBuscar.Focus()
    End Sub


End Class