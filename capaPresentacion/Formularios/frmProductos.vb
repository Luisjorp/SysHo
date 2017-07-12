Imports capaEntidad
Imports capaNegocios
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraReports.UI
Public Class frmProductos
    '**************************************VARIABLES INICIALES********************************
    Private accion As String = "guardar"
    Private seconds As Integer = 2
    Private grid_index = -1

    '**************************************BASE DE DATOS**************************************
    Public Sub cargar_Productos()
        Dim objeto As New cnProducto
        Dim datos As New DataTable
        datos = objeto.RN_listarProductos
        GridControl1.DataSource = datos
        GridView1.Columns("nombre").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        GridView1.Focus()

        If GridView1.RowCount <> 0 Then
            lblTotalRegistros.Text = ((GridView1.RowCount).ToString + " productos registrados en el sistema.")
        Else
            MsgBox("No se han registrado productos aún.", MsgBoxStyle.Critical, "Sin registros")
            lblTotalRegistros.Text = "No se han registrado productos aún."
        End If
    End Sub
    Public Sub cargar_IDProducto()
        Dim objeto As New cnProducto
        txtIdProducto.Text = objeto.RN_nextID_Producto
    End Sub
    Public Sub ingresar_Producto()
        Dim obj As New cnProducto
        Dim enProd As New ceProducto

        enProd.nombre = txtNombreProducto.Text
        enProd.descripcion = txtDescripcionProducto.Text
        enProd.unidadMedida = cboxUnidadMedida.Text
        enProd.precioVenta = txtPrecioVenta.Text

        obj.RN_ingresarProducto(enProd)
    End Sub
    Public Sub actualizar_Producto()
        Dim obj As New cnProducto
        Dim enProd As New ceProducto

        enProd.idProducto = txtIdProducto.Text
        enProd.nombre = txtNombreProducto.Text
        enProd.descripcion = txtDescripcionProducto.Text
        enProd.unidadMedida = cboxUnidadMedida.Text
        enProd.precioVenta = txtPrecioVenta.Text

        obj.RN_actualizarProducto(enProd)
    End Sub
    Public Sub Eliminar_Producto(valorID As String)
        Dim obj As New cnProducto
        Dim enProd As New ceProducto
        enProd.idProducto = valorID

        obj.RN_eliminarProducto(enProd)
    End Sub
    '*************************************FUNCIONES Y METODOS DEL FORMULARIO******************
    Private Sub inhabilitarCampos()
        txtIdProducto.Enabled = False
        txtNombreProducto.Enabled = False
        txtDescripcionProducto.Enabled = False
        cboxUnidadMedida.Enabled = False
        txtPrecioVenta.Enabled = False

        btnGuardar.Enabled = False
        btnCancelar.Enabled = False

        txtIdProducto.Text = ""
        txtNombreProducto.Text = ""
        txtDescripcionProducto.Text = ""
        cboxUnidadMedida.Text = ""
        txtPrecioVenta.Text = ""
    End Sub
    Private Sub habilitarCampos()
        txtIdProducto.Enabled = True
        txtNombreProducto.Enabled = True
        txtDescripcionProducto.Enabled = True
        cboxUnidadMedida.Enabled = True
        txtPrecioVenta.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True

        txtIdProducto.Text = ""
        txtNombreProducto.Text = ""
        txtDescripcionProducto.Text = ""
        cboxUnidadMedida.Text = ""
        txtPrecioVenta.Text = ""
    End Sub
    Private Sub habilitarCamposEdicion()
        txtIdProducto.Enabled = True
        txtNombreProducto.Enabled = True
        txtDescripcionProducto.Enabled = True
        cboxUnidadMedida.Enabled = True
        txtPrecioVenta.Enabled = True

        btnGuardar.Enabled = True
        btnCancelar.Enabled = True
    End Sub
    Private Sub pasarCamposEdicion()
        txtIdProducto.Text = GridView1.GetRowCellValue(grid_index, "idProducto").ToString
        txtNombreProducto.Text = GridView1.GetRowCellValue(grid_index, "nombre").ToString
        txtDescripcionProducto.Text = GridView1.GetRowCellValue(grid_index, "descripcion").ToString
        cboxUnidadMedida.Text = GridView1.GetRowCellValue(grid_index, "unidadMedida").ToString
        txtPrecioVenta.Text = GridView1.GetRowCellValue(grid_index, "precioVenta").ToString
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
                    puMenu_gridProductos.ShowPopup(e.Location, GridView1)
                    puMenu_gridProductos.ShowPopup(Cursor.Position)
                    pu_btn_Editar.Caption = "Editar información del producto: " + GridView1.GetRowCellValue(grid_index, "nombre").ToString
                    pu_btn_Eliminar.Caption = "Eliminar registro del producto: " + GridView1.GetRowCellValue(grid_index, "nombre").ToString
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    '*************************************EVENTOS DE CONTROLES******************************
    'Grupo Registro
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        habilitarCampos()
        cargar_IDProducto()
        btnNuevo.Enabled = False
        btnGuardar.Text = "Guardar"
        accion = "guardar"
        txtNombreProducto.Focus()

    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtNombreProducto.Text = "" Then
            MsgBox("Ingresa el nombre del producto", MsgBoxStyle.Exclamation, "¡Falta el nombre del producto!")
            txtNombreProducto.Focus()
        Else
            If txtDescripcionProducto.Text = "" Then
                MsgBox("Ingresa una descripción para el producto", MsgBoxStyle.Exclamation, "¡Falta la descripción del producto!")
                txtDescripcionProducto.Focus()
            Else
                If cboxUnidadMedida.SelectedItem = Nothing Then
                    MsgBox("Establece la unidad de medida para el producto", MsgBoxStyle.Exclamation, "¡Falta la unidad de medida del producto!")
                    cboxUnidadMedida.Focus()
                Else
                    If txtPrecioVenta.Text = "0.00" Then
                        MsgBox("Establece el precio de venta del producto.", MsgBoxStyle.Exclamation, "¡Falta el precio de venta del producto!")
                        txtPrecioVenta.Focus()
                    Else
                        'CUANDO TODOS LOS CAMPOS ESTAN COMPLETOS
                        If accion = "guardar" Then
                            Call ingresar_Producto()
                        ElseIf accion = "actualizar" Then
                            Call actualizar_Producto()
                        End If

                        Call cargar_Productos()
                        Dim idSeleccionFila As String = txtIdProducto.Text
                        Call inhabilitarCampos()
                        btnNuevo.Enabled = True

                        'En este apartado se selecciona la nueva fila, o bien ya sea la editada, para no perder el foco de la misma.
                        For i As Integer = 0 To GridView1.RowCount - 1
                            If GridView1.GetRowCellValue(i, "idProducto") = idSeleccionFila Then
                                GridView1.FocusedRowHandle = i
                            End If
                        Next
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
        Dim report As New reporteClientes()
        Dim cnprod As New cnProducto

        report.ObjectDataSource1.DataSource = cnprod.RN_listarProductos

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
            cargar_Productos()

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
        Dim result As Integer = MessageBox.Show(Me, "¿Realmente desea eliminar este producto del sistema?", "ESTÁ A PUNTO DE ELIMINAR UN REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then

            Dim idSeleccionFila As String = (GridView1.GetRowCellValue(grid_index, "idProducto") + 1).ToString
            Eliminar_Producto(GridView1.GetRowCellValue(grid_index, "idProducto").ToString)

            Call cargar_Productos()
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