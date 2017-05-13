Imports capaEntidad
Imports System.Data.SqlClient

Public Class cdTrabajador

    Public Function BD_listarTrabajadores() As DataTable
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            Dim da As New SqlDataAdapter("sp_Listar_Trabajadores", cn)
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

    Public Sub BD_isertarTrabajador(ByVal tra As ceTrabajador)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_I_Trabajador", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_nombre", tra.nombre)
            cmd.Parameters.AddWithValue("@i_apellido", tra.apellido)
            cmd.Parameters.AddWithValue("@i_tipoDocumento", tra.tipoDocumento)
            cmd.Parameters.AddWithValue("@i_noDocumento", tra.noDocumento)
            cmd.Parameters.AddWithValue("@i_direccion", tra.direccion)
            cmd.Parameters.AddWithValue("@i_telefono", tra.telefono)
            cmd.Parameters.AddWithValue("@i_email", tra.email)
            cmd.Parameters.AddWithValue("@i_sueldo", tra.sueldo)
            cmd.Parameters.AddWithValue("@i_acceso", tra.acceso)
            cmd.Parameters.AddWithValue("@i_login", tra.login)
            cmd.Parameters.AddWithValue("@i_password", tra.password)
            cmd.Parameters.AddWithValue("@i_estado", tra.estado)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Trabajador registrado con éxito.", MsgBoxStyle.Information, "Registro exitoso")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Sub BD_actualizarTrabajador(ByVal tra As ceTrabajador)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_U_Trabajador", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_nombre", tra.nombre)
            cmd.Parameters.AddWithValue("@i_apellido", tra.apellido)
            cmd.Parameters.AddWithValue("@i_tipoDocumento", tra.tipoDocumento)
            cmd.Parameters.AddWithValue("@i_noDocumento", tra.noDocumento)
            cmd.Parameters.AddWithValue("@i_direccion", tra.direccion)
            cmd.Parameters.AddWithValue("@i_telefono", tra.telefono)
            cmd.Parameters.AddWithValue("@i_email", tra.email)
            cmd.Parameters.AddWithValue("@i_sueldo", tra.sueldo)
            cmd.Parameters.AddWithValue("@i_acceso", tra.acceso)
            cmd.Parameters.AddWithValue("@i_login", tra.login)
            cmd.Parameters.AddWithValue("@i_password", tra.password)
            cmd.Parameters.AddWithValue("@i_estado", tra.estado)

            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Registro actualizado con éxito.", MsgBoxStyle.Information, "Registro exitoso")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Sub BD_eliminarTrabajador(ByVal tra As ceTrabajador)
        Dim cn As New SqlConnection(cadenaConexion)
        Dim cmd As New SqlCommand("sp_D_Trabajador", cn)

        Try
            cmd.CommandTimeout = 20
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@i_idPersona", tra.idPersona)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Baja confirmada.", MsgBoxStyle.Critical, "Eliminación exitosa")
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
        End Try
    End Sub
    Public Function BD_Login(ByVal tra As ceTrabajador) As DataTable
        Dim cn As New SqlConnection
        Try
            cn.ConnectionString = cadenaConexion()
            cn.Open()
            Dim da As New SqlDataAdapter("sp_Login", cn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            With da.SelectCommand.Parameters
                .Add("@i_login", SqlDbType.VarChar).Value = tra.login
                .Add("@i_password", SqlDbType.VarChar).Value = tra.password
            End With
            da.SelectCommand.ExecuteNonQuery()
            Dim datos As New DataTable
            da.Fill(datos)
            da = Nothing
            Return datos
        Catch ex As Exception
            MsgBox("Error>>> " + ex.Message, MsgBoxStyle.Critical, "Informe de Error")
            If cn.State = ConnectionState.Open Then cn.Close()
            cn.Dispose()
            Return Nothing
        Finally
            cn.Close()
            cn.Dispose()
        End Try
    End Function
End Class
