Public Class PersonaModelo
    Inherits Modelo

    Public Id As String
    Public Nombre As String
    Public Apellido As String
    Public Mail As String

    Public Sub Guardar()
        If Me.Id <> "" Then
            Me.Comando.CommandText = "INSERT INTO persona VALUES(" + Me.Id + ",'" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "')"
        Else
            Me.Comando.CommandText = "INSERT INTO persona(nombre,apellido,mail) VALUES('" + Me.Nombre + "','" + Me.Apellido + "','" + Me.Mail + "')"
        End If

        Me.Comando.ExecuteNonQuery()
    End Sub



    Public Sub Eliminar()
        Me.Comando.CommandText = "DELETE FROM persona WHERE id = " + Me.Id
        Me.Comando.ExecuteNonQuery()

    End Sub

    Public Function ObtenerUltimoId()
        Me.Comando.CommandText = "SELECT MAX(id) FROM persona"
        Return Me.Comando.ExecuteScalar.ToString()
    End Function

End Class
