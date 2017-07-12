Imports capaDatos
Imports capaEntidad
Public Class cnHabitacion

    Public Function RN_listarHabitaciones() As DataTable
        Dim obj As New cdHabitacion
        Return obj.BD_listarHabitaciones
    End Function
    Public Function RN_listarHabitacionesDisponibles() As DataTable
        Dim obj As New cdHabitacion
        Return obj.BD_listarHabitacionesDisponibles
    End Function
    Public Function RN_nextID_Habitacion() As String
        Dim obj As New cdHabitacion
        Return obj.BD_nextID_Habitacion
    End Function
    Public Sub RN_ingresarHabitacion(ByVal hab As ceHabitacion)
        Dim obj As New cdHabitacion
        Call obj.BD_ingresarHabitacion(hab)
    End Sub
    Public Sub RN_actualizarHabitacion(ByVal hab As ceHabitacion)
        Dim obj As New cdHabitacion
        Call obj.BD_actualizarHabitacion(hab)
    End Sub
    Public Sub RN_eliminarHabitacion(ByVal hab As ceHabitacion)
        Dim obj As New cdHabitacion
        Call obj.BD_eliminarHabitacion(hab)
    End Sub
End Class
