Imports capaEntidad
Imports System.Data.SqlClient
Public Class cdCliente

    Public Function BD_listarClientes() As DataTable
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            Dim da As New SqlDataAdapter("sp_Listar_Clientes", cn)
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
    Public Function BD_nextID_Persona() As String
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            Dim da As New SqlDataAdapter("sp_NextID_Persona", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            cn.Open()
            Dim codCliente$ = da.SelectCommand.ExecuteScalar() 'Obtiene solo el primer elemento de la primera columna y fila
            cn.Close()
            'Retorna los 4 digitos de derecha a izquierda (suma 0 porque ya viene auto incremental y toma formato)
            'Return "H-" + (Right(idHabitacion, 4) + 0).ToString("0000")
            Return codCliente
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
            Return Nothing
        End Try
    End Function
    Public Function BD_nextID_Cliente() As String
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            Dim da As New SqlDataAdapter("sp_NextID_Cliente", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            cn.Open()
            Dim codCliente$ = da.SelectCommand.ExecuteScalar() 'Obtiene solo el primer elemento de la primera columna y fila
            cn.Close()
            'Retorna los 4 digitos de derecha a izquierda (suma 0 porque ya viene auto incremental y toma formato)
            'Return "H-" + (Right(idHabitacion, 4) + 0).ToString("0000")
            Return codCliente
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
            Return Nothing
        End Try
    End Function
    Public Sub BD_isertarCliente(ByVal cli As ceCliente)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_I_Cliente", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_nombre", cli.nombre)
            cmd.Parameters.AddWithValue("@i_apellido", cli.apellido)
            cmd.Parameters.AddWithValue("@i_tipoDocumento", cli.tipoDocumento)
            cmd.Parameters.AddWithValue("@i_noDocumento", cli.noDocumento)
            cmd.Parameters.AddWithValue("@i_direccion", cli.direccion)
            cmd.Parameters.AddWithValue("@i_telefono", cli.telefono)
            cmd.Parameters.AddWithValue("@i_email", cli.email)
            cmd.Parameters.AddWithValue("@i_codigoCliente", cli.codigoCliente)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Cliente registrado con éxito.", MsgBoxStyle.Information, "Registro exitoso")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Sub BD_actualizarCliente(ByVal cli As ceCliente)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_U_Cliente", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_idPersona", cli.idPersona)
            cmd.Parameters.AddWithValue("@i_nombre", cli.nombre)
            cmd.Parameters.AddWithValue("@i_apellido", cli.apellido)
            cmd.Parameters.AddWithValue("@i_tipoDocumento", cli.tipoDocumento)
            cmd.Parameters.AddWithValue("@i_noDocumento", cli.noDocumento)
            cmd.Parameters.AddWithValue("@i_direccion", cli.direccion)
            cmd.Parameters.AddWithValue("@i_telefono", cli.telefono)
            cmd.Parameters.AddWithValue("@i_email", cli.email)
            cmd.Parameters.AddWithValue("@i_codigoCliente", cli.codigoCliente)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Cliente actualizado con éxito.", MsgBoxStyle.Information, "Actualización exitosa")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Sub BD_eliminarCliente(ByVal cli As ceCliente)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_D_Cliente", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_idPersona", cli.idPersona)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Cliente eliminado con éxito.", MsgBoxStyle.Critical, "Eliminación exitosa")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub

End Class
