Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function Movies() As ActionResult
        ViewData("Message") = "Your movies page."

        Return View()
    End Function

    Function Customers() As ActionResult
        ViewData("Message") = "Your customers page."

        Return View()
    End Function

    Function Cus_Details_id1() As ActionResult

        Return RedirectToAction("JhonSmith")
    End Function
    Function Cus_Details_id2() As ActionResult

        Return RedirectToAction("MaryWilliams")
    End Function
    Function Cus_Details_404() As ActionResult

        Return HttpNotFound()
    End Function

    Function JhonSmith() As ActionResult

        Return View()
    End Function
    Function MaryWilliams() As ActionResult

        Return View()
    End Function



End Class
