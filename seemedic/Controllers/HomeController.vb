Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function Covid19() As ActionResult
        ViewData("Message") = "Covid-19 Outbreak in India"

        Return View()
    End Function
    Function Fitness() As ActionResult
        ViewData("Message") = "Fitness"

        Return View()
    End Function
End Class
