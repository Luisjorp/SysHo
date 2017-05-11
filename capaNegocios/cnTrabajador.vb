Imports capaEntidad
Imports capaDatos

Public Class cnTrabajador
    Public Function RN_listarTrabajadores() As DataTable
        Dim obj As New cdTrabajador
        Return obj.BD_listarTrabajadores
    End Function
    Public Function RN_nextID_Persona() As String
        Dim obj As New cdTrabajador
        Return obj.BD_nextID_Persona
    End Function
    Public Sub RN_insertarTrabajador(ByVal tra As ceTrabajador)
        Dim obj As New cdTrabajador
        Call obj.BD_isertarTrabajador(tra)
    End Sub
    Public Sub RN_actualizarTrabajador(ByVal tra As ceTrabajador)
        Dim obj As New cdTrabajador
        Call obj.BD_actualizarTrabajador(tra)
    End Sub
    Public Sub RN_eliminarTrabajador(ByVal tra As ceTrabajador)
        Dim obj As New cdTrabajador
        Call obj.BD_eliminarTrabajador(tra)
    End Sub
End Class
