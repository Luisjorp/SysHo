Imports capaEntidad
Imports capaNegocios
Imports capaDatos.modLogin
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraReports.UI
Public Class frmReserva
    '**************************************VARIABLES INICIALES********************************
    Private accion As String = "guardar"
    Private seconds As Integer = 2
    Private grid_index = -1

    '**************************************BASE DE DATOS**************************************
    Public Sub cargar_Reservas()
        Dim objeto As New cnReserva
        Dim datos As New DataTable
        datos = objeto.RN_listarReservas
        GridControl1.DataSource = datos
        GridView1.Columns("idReserva").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        GridView1.Focus()

        If GridView1.RowCount <> 0 Then
            lblTotalRegistros.Text = ((GridView1.RowCount).ToString + " reservas registradas en el sistema.")
        Else
            MsgBox("No se han registrado reservaciones aún.", MsgBoxStyle.Critical, "Sin registros")
            lblTotalRegistros.Text = "No se han registrado reservaciones aún."
        End If
    End Sub
    Public Sub cargar_IDReserva()
        Dim objeto As New cnReserva
        txtIdReserva.Text = objeto.RN_nextID_Reserva
    End Sub
    Public Sub ingresar_Reserva()
        Dim obj As New cnReserva
        Dim enRev As New ceReservacion

        enRev.idHabitacion = txtIDHabitacion.Text
        enRev.idCliente = txtIdCliente.Text
        enRev.idTrabajador = txtIDTrabajador.Text
        enRev.tipoReserva = cboxTipoReserva.Text
        enRev.fechaReserva = dateFechaReserva.EditValue
        enRev.fechaIngreso = dateFechaIngreso.EditValue
        enRev.fechaSalida = dateFechaSalida.EditValue
        enRev.costoAlojamiento = txtCosto.Text
        enRev.estado = cboxEstadoReserva.Text

        obj.RN_ingresarReserva(enRev)
    End Sub
    Public Sub actualizar_Reserva()
        Dim obj As New cnReserva
        Dim enRev As New ceReservacion

        enRev.idHabitacion = txtIDHabitacion.Text
        enRev.idCliente = txtIdCliente.Text
        enRev.idTrabajador = txtIDTrabajador.Text
        enRev.tipoReserva = cboxTipoReserva.Text
        enRev.fechaReserva = dateFechaReserva.EditValue
        enRev.fechaIngreso = dateFechaIngreso.EditValue
        enRev.fechaSalida = dateFechaSalida.EditValue
        enRev.costoAlojamiento = txtCosto.Text
        enRev.estado = cboxEstadoReserva.Text


    End Sub

    '*************************************FUNCIONES Y METODOS DEL FORMULARIO******************
    Private Sub inhabilitarCampos()

        txtIdReserva.Enabled = False
        txtIDHabitacion.Enabled = False
        txtNoHabitacion.Enabled = False
        txtIdCliente.Enabled = False
        txtCliente.Enabled = False
        cboxTipoReserva.Enabled = False
        dateFechaReserva.Enabled = False
        dateFechaIngreso.Enabled = False
        dateFechaSalida.Enabled = False
        txtCosto.Enabled = False
        cboxEstadoReserva.Enabled = False

        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        txtIdReserva.Text = ""
        txtIDHabitacion.Text = ""
        txtNoHabitacion.Text = ""
        txtIdCliente.Text = ""
        txtCliente.Text = ""
        txtIDTrabajador.Text = ""
        txtTrabajador.Text = ""
        cboxTipoReserva.Text = ""
        dateFechaReserva.Text = ""
        dateFechaIngreso.Text = ""
        dateFechaSalida.Text = ""
        txtCosto.Text = ""
        cboxEstadoReserva.Text = ""




    End Sub
    Private Sub habilitarCampos()
        txtIdReserva.Enabled = True
        txtIDHabitacion.Enabled = True
        txtNoHabitacion.Enabled = True
        txtIdCliente.Enabled = True
        txtCliente.Enabled = True
        cboxTipoReserva.Enabled = True
        dateFechaReserva.Enabled = True
        dateFechaIngreso.Enabled = True
        dateFechaSalida.Enabled = True
        txtCosto.Enabled = True
        cboxEstadoReserva.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        txtIdReserva.Text = ""
        txtIDHabitacion.Text = ""
        txtNoHabitacion.Text = ""
        txtIdCliente.Text = ""
        txtCliente.Text = ""
        txtIDTrabajador.Text = ""
        txtTrabajador.Text = ""
        cboxTipoReserva.Text = ""
        dateFechaReserva.Text = ""
        dateFechaIngreso.Text = ""
        dateFechaSalida.Text = ""
        txtCosto.Text = ""
        cboxEstadoReserva.Text = ""
    End Sub
    Private Sub habilitarCamposEdicion()
        'txtIdProducto.Enabled = True
        'txtNombreProducto.Enabled = True
        'txtDescripcionProducto.Enabled = True
        'cboxUnidadMedida.Enabled = True
        'txtPrecioVenta.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
    End Sub
    Private Sub pasarCamposEdicion()
        'txtIdProducto.Text = GridView1.GetRowCellValue(grid_index, "idProducto").ToString
        'txtNombreProducto.Text = GridView1.GetRowCellValue(grid_index, "nombre").ToString
        'txtDescripcionProducto.Text = GridView1.GetRowCellValue(grid_index, "descripcion").ToString
        'cboxUnidadMedida.Text = GridView1.GetRowCellValue(grid_index, "unidadMedida").ToString
        'txtPrecioVenta.Text = GridView1.GetRowCellValue(grid_index, "precioVenta").ToString
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
                    puMenu_gridReservas.ShowPopup(e.Location, GridView1)
                    puMenu_gridReservas.ShowPopup(Cursor.Position)
                    pu_btn_Editar.Caption = "Editar información de la reservación "
                    pu_btn_Eliminar.Caption = "Eliminar registro de la reservación "
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    '*************************************EVENTOS DE CONTROLES******************************
    'Grupo Registro
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        habilitarCampos()
        cargar_IDReserva()
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        accion = "guardar"
        txtIDTrabajador.Text = xIdPersona
        txtTrabajador.Text = String.Format("{0} {1}", xNombre, xApellido)
        txtNoHabitacion.Focus()

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtIDHabitacion.Text = "" Or txtNoHabitacion.Text = "" Then
            MsgBox("Debes seleccionar una habitación", MsgBoxStyle.Exclamation, "¡Falta la habitación!")
            txtNoHabitacion.Focus()
        Else
            If txtIdCliente.Text = "" Or txtCliente.Text = "" Then
                MsgBox("Debes seleccionar un cliente", MsgBoxStyle.Exclamation, "¡Falta el cliente!")
                txtCliente.Focus()
            Else
                If txtCosto.Text = "" Or txtCosto.Text = "0.00" Then
                    MsgBox("Debes ingresar ", MsgBoxStyle.Exclamation, "¡Falta la unidad de medida del producto!")
                    txtCosto.Focus()
                Else
                    If cboxTipoReserva.Text = "" Then
                        MsgBox("Establece el tipo de reserva.", MsgBoxStyle.Exclamation, "¡Falta el tipo de reserva!")
                        cboxTipoReserva.Focus()
                    Else
                        If dateFechaReserva.Text = "" Or dateFechaReserva.EditValue < DateTime.Today Then
                            MsgBox("Establece una fecha valida para la reserva.", MsgBoxStyle.Exclamation, "¡Falta la fecha de reserva!")
                            dateFechaReserva.Focus()
                        Else
                            If dateFechaIngreso.EditValue < DateTime.Today Or dateFechaIngreso.Text = "" Then
                                MsgBox("Establece una fecha valida de ingreso.", MsgBoxStyle.Exclamation, "¡Falta la fecha de ingreso!")
                                dateFechaIngreso.Focus()
                            Else
                                If dateFechaSalida.EditValue < DateTime.Today Or dateFechaSalida.Text = "" Then
                                    MsgBox("Establece una fecha valida de salida.", MsgBoxStyle.Exclamation, "¡Falta la fecha de salida!")
                                    dateFechaSalida.Focus()
                                Else
                                    If cboxEstadoReserva.Text = "" Then
                                        MsgBox("Debes seleccionar un estado de reservación", MsgBoxStyle.Exclamation, "¡Falta el estado!")
                                        cboxEstadoReserva.Focus()
                                    Else
                                        'CUANDO TODOS LOS CAMPOS ESTAN COMPLETOS
                                        If accion = "guardar" Then
                                            Call ingresar_Reserva()
                                        ElseIf accion = "actualizar" Then
                                            'Call actualizar_Producto()
                                        End If

                                        Call cargar_Reservas()
                                        Dim idSeleccionFila As String = txtIdReserva.Text
                                        Call inhabilitarCampos()
                                        btnNuevo.Enabled = True

                                        'En este apartado se selecciona la nueva fila, o bien ya sea la editada, para no perder el foco de la misma.
                                        For i As Integer = 0 To GridView1.RowCount - 1
                                            If GridView1.GetRowCellValue(i, "idReserva") = idSeleccionFila Then
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
        End If

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        inhabilitarCampos()
        btnNuevo.Enabled = True
    End Sub
    Private Sub txtNoHabitacion_Properties_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtNoHabitacion.Properties.ButtonClick
        Dim SelectorDialog As New frmEmerHabitación
        SelectorDialog.ShowDialog()
        txtIDHabitacion.Text = SelectorDialog.RetornoIDHabitacion
        txtNoHabitacion.Text = SelectorDialog.RetornoNoHabitacion
        SelectorDialog = Nothing
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
            Case "Nombre"
                GridView1.ActiveFilterString = String.Format("[nombre] Like '%{0}%'", txtBuscar.Text)
            Case "Descripción"
                GridView1.ActiveFilterString = String.Format("[descripcion] Like '%{0}%'", txtBuscar.Text)
            Case Else
                GridView1.ActiveFilterString = String.Format("[nombre] Like '%{0}%'", txtBuscar.Text)
        End Select

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        seconds = seconds - 1
        If seconds = 0 Then
            SplashScreenManager.CloseForm()
            cargar_Reservas()

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
        Dim result As Integer = MessageBox.Show(Me, "¿Realmente desea anular esta reserva?", "ESTÁ A PUNTO DE ELIMINAR UN REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then

            Dim idSeleccionFila As String = (GridView1.GetRowCellValue(grid_index, "idReserva") + 1).ToString
            'Eliminar_Producto(GridView1.GetRowCellValue(grid_index, "idProducto").ToString)

            'Call cargar_Productos()
            Call inhabilitarCampos()
            btnNuevo.Enabled = True

            'En este apartado se selecciona la nueva fila, o bien ya sea la editada, para no perder el foco de la misma.
            For i As Integer = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(i, "idProducto") = idSeleccionFila Then
                    GridView1.FocusedRowHandle = i
                End If
            Next
        End If
    End Sub

    'Pop Up Filtro Busqueda
    Private Sub pu_btn_Nom_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Nom.ItemClick
        btnDD_Filtro.Text = "Nombre"
        GridView1.ActiveFilterString = String.Format("[nombre] Like '%{0}%'", txtBuscar.Text)
    End Sub
    Private Sub pu_btn_Desc_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Desc.ItemClick
        btnDD_Filtro.Text = "Descripción"
        GridView1.ActiveFilterString = String.Format("[descripcion] Like '%{0}%'", txtBuscar.Text)
    End Sub

    Private Sub btnDD_Filtro_TextChanged(sender As Object, e As EventArgs) Handles btnDD_Filtro.TextChanged
        txtBuscar.Focus()
    End Sub

End Class