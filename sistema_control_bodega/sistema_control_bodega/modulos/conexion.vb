Imports System.Data
Imports MySql.Data.MySqlClient

Module conexion
    'Variables a Ocupar
    Public lector As MySqlDataReader
    Dim conexion As MySqlConnection
    Dim comando As New MySqlCommand
    Public lector2 As MySqlDataReader
    Dim conexion2 As MySqlConnection
    Dim comando2 As New MySqlCommand

    Public Sub SQLQuery(ByVal Query As String, ByVal retornadatos As Boolean)


        Try

            conexion = New MySqlConnection



            Dim string_conexion As String = "server=localhost; user id=root; password=6414; database=control_bodega"
            conexion.ConnectionString = string_conexion

            conexion.Open()
            comando.Connection = conexion
            comando.CommandText = Query

            If retornadatos Then
                lector = comando.ExecuteReader
            Else
                comando.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox("Error en Base de Datos, contacte a Administrador" & vbCrLf & "Informe del Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error en Base de Datos")
        End Try


    End Sub

    Public Sub SQLQuery2(ByVal Query As String, ByVal retornadatos As Boolean)


        Try
            conexion2 = New MySqlConnection


            Dim string_conexion As String = "server=localhost; user id=root; password=6414; database=control_bodega"
            conexion2.ConnectionString = string_conexion
            conexion2.Open()
            comando2.Connection = conexion2
            comando2.CommandText = Query

            If retornadatos Then
                lector2 = comando2.ExecuteReader
            Else
                comando2.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox("Error en Base de Datos, contacte a Administrador" & vbCrLf & "Informe del Error: " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error en Base de Datos")
        End Try


    End Sub

    Public Sub CerrarConexion()
        conexion.Close()
    End Sub

    Public Sub CerrarConexion2()
        conexion2.Close()
    End Sub

End Module
