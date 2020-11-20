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
    Function Howitspreads() As ActionResult
        ViewData("Message") = "How it spreads?"

        Return View()
    End Function
    Function Fitness() As ActionResult
        ViewData("Message") = "Fitness"

        Return View()
    End Function
    Function Symptoms() As ActionResult
        ViewData("Message") = "Symptoms"

        Return View()
    End Function
    Function FAQ() As ActionResult
        ViewData("Message") = "FAQ"

        Return View()
    End Function
    Function CancerOverview() As ActionResult
        ViewData("Message") = "Cancer"

        Return View()
    End Function
    Function CancerPrevention() As ActionResult
        ViewData("Message") = "Prevention"

        Return View()
    End Function
    Function CancerManagement() As ActionResult
        ViewData("Message") = "Management"

        Return View()
    End Function
End Class
