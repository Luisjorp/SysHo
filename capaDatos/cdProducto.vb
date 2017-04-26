Imports capaEntidad
Imports System.Data.SqlClient
Public Class cdProducto
    Public Function BD_listarProductos() As DataTable
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            Dim da As New SqlDataAdapter("sp_ListarProductos", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim datos As New DataTable
            da.Fill(datos)
            da = Nothing
            Return datos
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
            Return Nothing
        End Try
    End Function
    Public Function BD_nextID_Habitacion() As String
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            Dim da As New SqlDataAdapter("sp_NextID_Producto", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            cn.Open()
            Dim idHabitacion$ = da.SelectCommand.ExecuteScalar() 'Obtiene solo el primer elemento de la primera columna y fila
            cn.Close()
            'Retorna los 4 digitos de derecha a izquierda (suma 0 porque ya viene auto incremental y toma formato)
            'Return "H-" + (Right(idHabitacion, 4) + 0).ToString("0000")
            Return idHabitacion
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
            Return Nothing
        End Try
    End Function
    Public Sub BD_ingresarProducto(ByVal prod As ceProducto)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_I_Producto", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_nombre", prod.nombre)
            cmd.Parameters.AddWithValue("@i_descripcion", prod.descripcion)
            cmd.Parameters.AddWithValue("@i_unidadMedida", prod.unidadMedida)
            cmd.Parameters.AddWithValue("@i_precioVenta", prod.precioVenta)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Producto registrado con éxito.", MsgBoxStyle.Information, "Registro exitoso")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Sub BD_actualizarProducto(ByVal prod As ceProducto)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_U_Producto", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_idProducto", prod.idProducto)
            cmd.Parameters.AddWithValue("@i_nombre", prod.nombre)
            cmd.Parameters.AddWithValue("@i_descripcion", prod.descripcion)
            cmd.Parameters.AddWithValue("@i_unidadMedida", prod.unidadMedida)
            cmd.Parameters.AddWithValue("@i_precioVenta", prod.precioVenta)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Producto actualizado con éxito.", MsgBoxStyle.Information, "Actualización exitosa")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Sub BD_eliminarProducto(ByVal prod As ceProducto)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_D_Producto", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_idProducto", prod.idProducto)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Producto eliminado con éxito.", MsgBoxStyle.Critical, "Eliminación exitosa")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub

End Class
