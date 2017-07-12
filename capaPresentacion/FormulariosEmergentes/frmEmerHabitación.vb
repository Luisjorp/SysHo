Imports capaEntidad
Imports capaNegocios
Imports DevExpress.XtraBars
Imports DevExpress.XtraBarss

Public Class frmEmerHabitación
    '**************************************VARIABLES INICIALES**************************************
    Private accion As String = "guardar"
    Private seconds As Integer = 2
    Private grid_index = -1
    Private var_idHabitacion As String
    Private var_NoHabitacion As String



    '**************************************BASE DE DATOS**************************************
    Public Sub cargar_Habitaciones()
        Dim objeto As New cnHabitacion
        Dim datos As New DataTable
        datos = objeto.RN_listarHabitacionesDisponibles
        GridControl1.DataSource = datos
        GridView1.Columns("numero").SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        GridView1.Focus()

        If GridView1.RowCount <> 0 Then
            lblTotalRegistros.Text = ((GridView1.RowCount).ToString + " habitaciones registradas en el sistema.")
        Else
            lblTotalRegistros.Text = "No se han registrado habitaciones aún."
        End If
    End Sub


    '*************************************FUNCIONES Y METODOS DEL FORMULARIO******************
    Public Function RetornoIDHabitacion() As String
        Return var_idHabitacion
    End Function
    Public Function RetornoNoHabitacion() As String
        Return var_NoHabitacion
    End Function


    '*************************************EVENTOS DEL FORMULARIO******************************
    Private Sub frmHabitaciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargar_Habitaciones()
    End Sub


    '*************************************EVENTOS DE GRID***********************************
    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Dim FilaSeleccionada As DataRow = GridView1.GetFocusedDataRow()
        var_idHabitacion = FilaSeleccionada("idHabitacion").ToString
        var_NoHabitacion = FilaSeleccionada("numero").ToString
        Me.Hide()


    End Sub


    '*************************************EVENTOS DE CONTROLES******************************
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