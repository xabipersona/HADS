Imports Lab2.accesodatosSQL
Imports System.Data.SqlClient

Public Class Inicio
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String
        Dim register As SqlDataReader
        Dim pass As String
        email = TextBox1.Text
        pass = TextBox2.Text
        Session("correo") = email
        accesodatosSQL.conectar()
        register = accesodatosSQL.Login(email, pass)
        If register.HasRows Then
            accesodatosSQL.cerrarConexion()
            Response.Redirect("iniciadosesion.aspx")
        Else
            MsgBox("El usuario no esta registrado")
        End If

    End Sub
End Class