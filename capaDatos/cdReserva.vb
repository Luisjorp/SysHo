Imports capaEntidad
Imports System.Data.SqlClient

Public Class cdReserva

    Public Function BD_listarReservaciones() As DataTable
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            Dim da As New SqlDataAdapter("sp_Listar_Reservaciones", cn)
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
    Public Function BD_nextID_Reservacion() As String
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            Dim da As New SqlDataAdapter("sp_NextID_Reservacion", cn)
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
    Public Sub BD_ingresarReserva(ByVal res As ceReservacion)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_I_Reservacion", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_idHabitacion", res.idHabitacion)
            cmd.Parameters.AddWithValue("@i_idCliente", res.idCliente)
            cmd.Parameters.AddWithValue("@i_idTrabajador", res.idTrabajador)
            cmd.Parameters.AddWithValue("@i_tipoReserva", res.tipoReserva)
            cmd.Parameters.AddWithValue("@i_fechaReserva", res.fechaReserva)
            cmd.Parameters.AddWithValue("@i_fechaIngreso", res.fechaIngreso)
            cmd.Parameters.AddWithValue("@i_fechaSalida", res.fechaSalida)
            cmd.Parameters.AddWithValue("@i_costoAlojamiento", res.costoAlojamiento)
            cmd.Parameters.AddWithValue("@i_observacion", res.observacion)
            cmd.Parameters.AddWithValue("@i_estado", res.estado)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Reservación realizada con éxito.", MsgBoxStyle.Information, "Reservación Exitosa")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Sub BD_actualizarReserva(ByVal res As ceReservacion)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_U_Reservacion", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_idReserva", res.idReserva)
            cmd.Parameters.AddWithValue("@i_idHabitacion", res.idHabitacion)
            cmd.Parameters.AddWithValue("@i_idCliente", res.idCliente)
            cmd.Parameters.AddWithValue("@i_idTrabajador", res.idTrabajador)
            cmd.Parameters.AddWithValue("@i_tipoReserva", res.tipoReserva)
            cmd.Parameters.AddWithValue("@i_fechaReserva", res.fechaReserva)
            cmd.Parameters.AddWithValue("@i_fechaIngreso", res.fechaIngreso)
            cmd.Parameters.AddWithValue("@i_fechaSalida", res.fechaSalida)
            cmd.Parameters.AddWithValue("@i_costoAlojamiento", res.costoAlojamiento)
            cmd.Parameters.AddWithValue("@i_observacion", res.observacion)
            cmd.Parameters.AddWithValue("@i_estado", res.estado)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Información actualizada con éxito.", MsgBoxStyle.Information, "Actualización Exitosa")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
End Class
