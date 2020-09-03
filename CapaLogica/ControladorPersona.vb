Imports CapaFisica
Public Module ControladorPersona

    Public Function AltaPersona(nombre As String, apellido As String, mail As String)
        Dim p As New PersonaModelo
        p.Nombre = nombre
        p.Apellido = apellido
        p.Mail = mail

        Try
            p.Guardar()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Module
