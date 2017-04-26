Imports capaDatos
Imports capaEntidad
Public Class cnProducto

    Public Function RN_listarProductos() As DataTable
        Dim obj As New cdProducto
        Return obj.BD_listarProductos
    End Function
    Public Function RN_nextID_Producto() As String
        Dim obj As New cdProducto
        Return obj.BD_nextID_Habitacion
    End Function
    Public Sub RN_ingresarProducto(ByVal prod As ceProducto)
        Dim obj As New cdProducto
        Call obj.BD_ingresarProducto(prod)
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
