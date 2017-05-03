Imports capaDatos
Imports capaEntidad
Public Class cnCliente

    Public Function RN_listarClientes() As DataTable
        Dim obj As New cdCliente
        Return obj.BD_listarClientes
    End Function
    Public Function RN_nextID_Cliente() As String
        Dim obj As New cdCliente
        Return obj.BD_nextID_Cliente
    End Function
    Public Function RN_nextID_Persona() As String
        Dim obj As New cdCliente
        Return obj.BD_nextID_Persona
    End Function
    Public Sub RN_insertarCliente(ByVal cli As ceCliente)
        Dim obj As New cdCliente
        Call obj.BD_isertarCliente(cli)
    End Sub
    Public Sub RN_actualizarCliente(ByVal cli As ceCliente)
        Dim obj As New cdCliente
        Call obj.BD_actualizarCliente(cli)
    End Sub
    Public Sub RN_eliminarCliente(ByVal cli As ceCliente)
        Dim obj As New cdCliente
        Call obj.BD_eliminarCliente(cli)
    End Sub
End Class
