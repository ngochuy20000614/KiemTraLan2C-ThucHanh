Imports System.Web.Mvc

Namespace Areas.Admin.Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Admin/Login
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace