Imports capaDatos
Imports capaEntidad
Public Class cnReserva

    Public Function RN_listarReservas() As DataTable
        Dim obj As New cdReserva
        Return obj.BD_listarReservaciones
    End Function
    Public Function RN_nextID_Reserva() As String
        Dim obj As New cdReserva
        Return obj.BD_nextID_Reservacion
    End Function
    Public Sub RN_ingresarReserva(ByVal res As ceReservacion)
        Dim obj As New cdReserva
        Call obj.BD_ingresarReserva(res)
    End Sub
    Public Sub RN_actualizarProducto(ByVal prod As ceProducto)
        Dim obj As New cdProducto
        Call obj.BD_actualizarProducto(prod)
    End Sub
    Public Sub RN_eliminarProducto(ByVal prod As ceProducto)
        Dim obj As New cdProducto
        Call obj.BD_eliminarProducto(prod)
    End Sub
End Class
