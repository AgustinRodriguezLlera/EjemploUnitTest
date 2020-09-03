Imports System.Data.Odbc

Public MustInherit Class Modelo
    Public DbDriver As String = "MySQL ODBC 8.0 ANSI Driver"
    Public DbUser As String = "user"
    Public DbPassword As String = "123"
    Public DbPort As String = "3306"
    Public DbName As String = "unitTests"
    Public DbHost As String = "192.168.1.5"




    Public Conexion As New OdbcConnection()


    Public Comando As New OdbcCommand
    Public Reader As OdbcDataReader


    Public Sub New()
        Me.Conexion.ConnectionString = "DRIVER=" + Me.DbDriver +
                                          ";UID=" + Me.DbUser +
                                          ";PWD=" + Me.DbPassword +
                                          ";PORT=" + Me.DbPort +
                                          ";DATABASE=" + Me.DbName +
                                          ";SERVER=" + Me.DbHost


        Me.Conexion.Open()
        Me.Comando.Connection = Me.Conexion
    End Sub




End Class