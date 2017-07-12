Imports capaEntidad
Imports System.Data.SqlClient
Public Class cdHabitacion
    Public Function BD_listarHabitaciones() As DataTable
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            Dim da As New SqlDataAdapter("sp_ListarHabitaciones", cn)
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
    Public Function BD_listarHabitacionesDisponibles() As DataTable
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            Dim da As New SqlDataAdapter("sp_Listar_ReservacionesDisponibles", cn)
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
            Dim da As New SqlDataAdapter("sp_NextID_Habitacion", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            cn.Open()
            Dim idHabitacion$ = da.SelectCommand.ExecuteScalar()
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
    Public Sub BD_ingresarHabitacion(ByVal hab As ceHabitacion)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_I_Habitacion", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_numero", hab.numero)
            cmd.Parameters.AddWithValue("@i_piso", hab.Piso)
            cmd.Parameters.AddWithValue("@i_descripcion", hab.Descripcion)
            cmd.Parameters.AddWithValue("@i_caracteristica", hab.Caracteristicas)
            cmd.Parameters.AddWithValue("@i_precioDiario", hab.precioDiario)
            cmd.Parameters.AddWithValue("@i_estado", hab.estado)
            cmd.Parameters.AddWithValue("@i_tipoHabitacion", hab.tipoHabitacion)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Habitación registrada con éxito.", MsgBoxStyle.Information, "Registro exitoso")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Sub BD_actualizarHabitacion(ByVal hab As ceHabitacion)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_U_Habitacion", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_idHab", hab.idHabitacion)
            cmd.Parameters.AddWithValue("@i_numero", hab.numero)
            cmd.Parameters.AddWithValue("@i_piso", hab.Piso)
            cmd.Parameters.AddWithValue("@i_descripcion", hab.Descripcion)
            cmd.Parameters.AddWithValue("@i_caracteristica", hab.Caracteristicas)
            cmd.Parameters.AddWithValue("@i_precioDiario", hab.precioDiario)
            cmd.Parameters.AddWithValue("@i_estado", hab.estado)
            cmd.Parameters.AddWithValue("@i_tipoHabitacion", hab.tipoHabitacion)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Información actualizada con éxito.", MsgBoxStyle.Information, "Actualización exitosa")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Sub BD_eliminarHabitacion(ByVal hab As ceHabitacion)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_D_Habitacion", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_idHab", hab.idHabitacion)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Registro eliminado con éxito.", MsgBoxStyle.Critical, "Eliminación exitosa")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub

End Class
