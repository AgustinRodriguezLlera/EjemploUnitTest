Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaFisica


<TestClass()> Public Class TestModeloPersona

    <TestMethod()> Public Sub TestAltaUsuario()
        Dim p As New PersonaModelo
        p.Nombre = "Jose"
        p.Apellido = "Perez"
        p.Mail = "un@mail.com"

        Dim resultado As Boolean

        Try
            p.Guardar()
            resultado = True

        Catch ex As Odbc.OdbcException

            resultado = False
        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestAltaUsuarioConId()
        Dim p As New PersonaModelo With {
            .Id = 9999,
            .Nombre = "Jose",
            .Apellido = "Perez",
            .Mail = "un@mail.com"
        }

        Dim resultado As Boolean

        Try
            p.Guardar()
            resultado = True

        Catch ex As Odbc.OdbcException

            resultado = False
        End Try

        Assert.IsTrue(resultado)

    End Sub

    <TestMethod()> Public Sub TestBajaUsuario()
        Dim p As New PersonaModelo With {
            .Id = 9999
        }
        Dim resultado As Boolean
        Try
            p.Eliminar()
            resultado = True
        Catch ex As Exception
            resultado = False

        End Try

        Assert.IsTrue(resultado)

    End Sub


End Class