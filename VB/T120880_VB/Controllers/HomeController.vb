Imports System.Web.Mvc

Public Class HomeController
    Inherits Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function ItemContentPartial() As ActionResult
        Return PartialView("ItemContentPartial")
    End Function
End Class