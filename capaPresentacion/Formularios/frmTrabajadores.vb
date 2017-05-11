Imports capaEntidad
Imports capaNegocios
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraReports.UI
Public Class frmTrabajadores
    '**************************************VARIABLES INICIALES********************************
    Private accion As String = "guardar"
    Private seconds As Integer = 2
    Private grid_index = -1

    '**************************************BASE DE DATOS**************************************
    Public Sub cargar_Trabajadores()
        Dim objeto As New cnTrabajador
        Dim datos As New DataTable
        datos = objeto.RN_listarTrabajadores
        GridControl1.DataSource = datos
        GridView1.Columns("nombre").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        GridView1.Focus()

        If GridView1.RowCount <> 0 Then
            lblTotalRegistros.Text = ((GridView1.RowCount).ToString + " trabajadores registrados en el sistema.")
        Else
            MsgBox("No se han registrado trabajadores aún.", MsgBoxStyle.Critical, "Sin registros")
            lblTotalRegistros.Text = "No se han registrado trabajadores aún."
        End If
    End Sub
    Public Sub cargar_IDPersona()
        Dim objeto As New cnTrabajador
        txtIdPersona.Text = objeto.RN_nextID_Persona
    End Sub
    Public Sub ingresar_Trbajador()
        Dim obj As New cnTrabajador
        Dim enTra As New ceTrabajador

        enTra.nombre = txtNombre.Text
        enTra.apellido = txtApellido.Text
        enTra.tipoDocumento = cboxTipoDocumento.Text
        enTra.noDocumento = txtNoDocumento.Text
        enTra.direccion = txtDireccion.Text
        enTra.telefono = txtTelefono.Text
        enTra.email = txtEmail.Text
        enTra.sueldo = txtSueldo.Text
        enTra.acceso = cboxAcceso.Text
        enTra.login = txtLogin.Text
        enTra.password = txtPassword.Text
        enTra.estado = cboxEstado.Text

        obj.RN_insertarTrabajador(enTra)
    End Sub
    Public Sub actualizar_Trabajador()
        Dim obj As New cnTrabajador
        Dim enTra As New ceTrabajador

        enTra.nombre = txtNombre.Text
        enTra.apellido = txtApellido.Text
        enTra.tipoDocumento = cboxTipoDocumento.Text
        enTra.noDocumento = txtNoDocumento.Text
        enTra.direccion = txtDireccion.Text
        enTra.telefono = txtTelefono.Text
        enTra.email = txtEmail.Text
        enTra.sueldo = txtSueldo.Text
        enTra.acceso = cboxAcceso.Text
        enTra.login = txtLogin.Text
        enTra.password = txtPassword.Text
        enTra.estado = cboxEstado.Text

        obj.RN_actualizarTrabajador(enTra)

    End Sub
    Public Sub Eliminar_Trabajador(valorID As String)
        Dim obj As New cnTrabajador
        Dim enTra As New ceTrabajador
        enTra.idPersona = valorID

        obj.RN_eliminarTrabajador(enTra)
    End Sub
    '*************************************FUNCIONES Y METODOS DEL FORMULARIO******************
    Private Sub inhabilitarCampos()
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        cboxTipoDocumento.Enabled = False
        txtNoDocumento.Enabled = False
        txtDireccion.Enabled = False
        txtTelefono.Enabled = False
        txtEmail.Enabled = False
        txtSueldo.Enabled = False
        cboxAcceso.Enabled = False
        txtLogin.Enabled = False
        txtPassword.Enabled = False
        cboxEstado.Enabled = False

        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        txtIdPersona.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        cboxTipoDocumento.Text = ""
        txtNoDocumento.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtSueldo.Text = ""
        cboxAcceso.Text = ""
        txtLogin.Text = ""
        txtPassword.Text = ""
        cboxEstado.Text = ""

    End Sub
    Private Sub habilitarCampos()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        cboxTipoDocumento.Enabled = True
        txtNoDocumento.Enabled = True
        txtDireccion.Enabled = True
        txtTelefono.Enabled = True
        txtEmail.Enabled = True
        txtSueldo.Enabled = True
        cboxAcceso.Enabled = True
        txtLogin.Enabled = True
        txtPassword.Enabled = True
        cboxEstado.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        txtIdPersona.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        cboxTipoDocumento.Text = ""
        txtNoDocumento.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtEmail.Text = ""
        txtSueldo.Text = ""
        cboxAcceso.Text = ""
        txtLogin.Text = ""
        txtPassword.Text = ""
        cboxEstado.Text = ""
    End Sub
    Private Sub habilitarCamposEdicion()
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        cboxTipoDocumento.Enabled = True
        txtNoDocumento.Enabled = True
        txtDireccion.Enabled = True
        txtTelefono.Enabled = True
        txtEmail.Enabled = True
        txtSueldo.Enabled = True
        cboxAcceso.Enabled = True
        txtLogin.Enabled = True
        txtPassword.Enabled = True
        cboxEstado.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
    End Sub
    Private Sub pasarCamposEdicion()
        txtIdPersona.Text = GridView1.GetRowCellValue(grid_index, "idPersona").ToString
        txtNombre.Text = GridView1.GetRowCellValue(grid_index, "nombre").ToString
        txtApellido.Text = GridView1.GetRowCellValue(grid_index, "apellido").ToString
        cboxTipoDocumento.Text = GridView1.GetRowCellValue(grid_index, "tipoDocumento").ToString
        txtNoDocumento.Text = GridView1.GetRowCellValue(grid_index, "noDocumento").ToString
        txtDireccion.Text = GridView1.GetRowCellValue(grid_index, "direccion").ToString
        txtTelefono.Text = GridView1.GetRowCellValue(grid_index, "telefono").ToString
        txtEmail.Text = GridView1.GetRowCellValue(grid_index, "email").ToString
        txtSueldo.Text = GridView1.GetRowCellValue(grid_index, "sueldo").ToString
        cboxAcceso.Text = GridView1.GetRowCellValue(grid_index, "acceso").ToString
        txtLogin.Text = GridView1.GetRowCellValue(grid_index, "login").ToString
        txtPassword.Text = GridView1.GetRowCellValue(grid_index, "password").ToString
        cboxEstado.Text = GridView1.GetRowCellValue(grid_index, "estado").ToString

        txtNombre.Focus()
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
                    puMenu_gridClientes.ShowPopup(e.Location, GridView1)
                    puMenu_gridClientes.ShowPopup(Cursor.Position)
                    pu_btn_Editar.Caption = String.Format("Editar información del trabajador: {0} {1}.", GridView1.GetRowCellValue(grid_index, "nombre").ToString, GridView1.GetRowCellValue(grid_index, "apellido").ToString)
                    pu_btn_Eliminar.Caption = String.Format("Eliminar registro del trabajador: {0} {1}.", GridView1.GetRowCellValue(grid_index, "nombre").ToString, GridView1.GetRowCellValue(grid_index, "apellido").ToString)
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    '*************************************EVENTOS DE CONTROLES******************************
    'Grupo Registro
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        habilitarCampos()
        cargar_IDPersona()
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        accion = "guardar"
        txtNombre.Focus()

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Then
            MsgBox("Ingresa el nombre del cliente", MsgBoxStyle.Exclamation, "¡Falta el nombre del cliente!")
            txtNombre.Focus()
        Else
            If txtApellido.Text = "" Then
                MsgBox("Ingresa el apellido del cliente", MsgBoxStyle.Exclamation, "¡Falta el apellido del cliente!")
                txtApellido.Focus()
            Else
                If cboxTipoDocumento.Text = "" Then
                    MsgBox("Selecciona el documento de identificación", MsgBoxStyle.Exclamation, "¡Falta el tipo de documento!")
                    cboxTipoDocumento.Focus()
                Else
                    If txtNoDocumento.Text = "" Then
                        MsgBox("Ingresa el número de documento del cliente", MsgBoxStyle.Exclamation, "¡Falta el número de documento!")
                        txtNoDocumento.Focus()
                    Else
                        If txtDireccion.Text = "" Then
                            MsgBox("Ingresa una dirección válida", MsgBoxStyle.Exclamation, "¡Falta la dirección del cliente!")
                            txtDireccion.Focus()
                        Else
                            If txtTelefono.Text = "" Then
                                MsgBox("Ingresa un número de teléfono válido.", MsgBoxStyle.Exclamation, "¡Falta el teléfono del cliente!")
                                txtTelefono.Focus()
                            Else
                                If txtEmail.Text = "" Then
                                    MsgBox("Ingresa el correo electrónico del cliente.", MsgBoxStyle.Exclamation, "¡Falta el e-mail del cliente!")
                                    txtEmail.Focus()
                                Else
                                    If txtSueldo.Text = "" Then
                                    Else
                                        'CUANDO TODOS LOS CAMPOS ESTAN COMPLETOS
                                        If accion = "guardar" Then
                                            Call ingresar_Trbajador()
                                        ElseIf accion = "actualizar" Then
                                            Call actualizar_Trabajador()
                                        End If

                                        Call cargar_Trabajadores()
                                        Dim idSeleccionFila As String = txtIdPersona.Text
                                        Call inhabilitarCampos()
                                        btnNuevo.Enabled = True

                                        'En este apartado se selecciona la nueva fila, o bien ya sea la editada, para no perder el foco de la misma.
                                        For i As Integer = 0 To GridView1.RowCount - 1
                                            If GridView1.GetRowCellValue(i, "idPersona") = idSeleccionFila Then
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
            Case "Apellido"
                GridView1.ActiveFilterString = String.Format("[apellido] Like '%{0}%'", txtBuscar.Text)
            Case Else
                GridView1.ActiveFilterString = String.Format("[noDocumento] Like '%{0}%'", txtBuscar.Text)
        End Select

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        seconds = seconds - 1
        If seconds = 0 Then
            SplashScreenManager.CloseForm()
            cargar_Trabajadores()
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
        Dim result As Integer = MessageBox.Show(Me, "¿Realmente desea eliminar este cliente del sistema?", "ESTÁ A PUNTO DE ELIMINAR UN REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then

            Dim idSeleccionFila As String = (GridView1.GetRowCellValue(grid_index, "idPersona") + 1).ToString
            Eliminar_Trabajador(GridView1.GetRowCellValue(grid_index, "idPersona").ToString)

            Call cargar_Trabajadores()
            Call inhabilitarCampos()
            btnNuevo.Enabled = True

            'En este apartado se selecciona la nueva fila, o bien ya sea la editada, para no perder el foco de la misma.
            For i As Integer = 0 To GridView1.RowCount - 1
                If GridView1.GetRowCellValue(i, "idPersona") = idSeleccionFila Then
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
    Private Sub pu_btn_Ape_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Ape.ItemClick
        btnDD_Filtro.Text = "Apellido"
        GridView1.ActiveFilterString = String.Format("[apellido] Like '%{0}%'", txtBuscar.Text)
    End Sub
    Private Sub pu_btn_Doc_ItemClick(sender As Object, e As ItemClickEventArgs) Handles pu_btn_Doc.ItemClick
        btnDD_Filtro.Text = "No. Documento"
        GridView1.ActiveFilterString = String.Format("[noDocumento] Like '%{0}%'", txtBuscar.Text)
    End Sub

    Private Sub btnDD_Filtro_TextChanged(sender As Object, e As EventArgs) Handles btnDD_Filtro.TextChanged
        txtBuscar.Focus()
    End Sub

End Class