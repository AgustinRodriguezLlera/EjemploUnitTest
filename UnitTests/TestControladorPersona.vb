Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CapaLogica


<TestClass()> Public Class TestControladorPersona

    <TestMethod()> Public Sub TestAltaPersona()
        Assert.IsTrue(ControladorPersona.AltaPersona("Jose", "Perez", "un@mail.com"))


    End Sub


End Class