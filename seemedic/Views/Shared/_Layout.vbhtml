<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<style>
    body {
        font-family: Arial, Helvetica, sans-serif;
    }

    .mynav_navbar {
        overflow: hidden;
        background-color: #333;
    }

        .mynav_navbar a {
            float: left;
            font-size: 14px;
            color: lightgrey;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
        }

    .mynav_dropdown {
        float: left;
        overflow: hidden;
    }

        .mynav_dropdown .mynav_dropbtn {
            font-size: 14px;
            border: none;
            outline: none;
            color: lightgrey;
            padding: 14px 16px;
            background-color: inherit;
            font-family: inherit;
            margin: 0;
        }

        .mynav_navbar a:hover, .mynav_dropdown:hover .mynav_dropbtn {
            background-color: red;
        }

    .mynav_dropdown-content {
        display: none;
        position: absolute;
        background-color: #f9f9f9;
        min-width: 160px;
        box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
        z-index: 1;
    }

        .mynav_dropdown-content a {
            float: none;
            color: black;
            padding: 12px 16px;
            text-decoration: none;
            display: block;
            text-align: left;
        }

            .mynav_dropdown-content a:hover {
                background-color: #ddd;
            }

    .mynav_dropdown:hover .mynav_dropdown-content {
        display: block;
    }
</style>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("SeeMedic", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>
            
            <div class="mynav_navbar">
                <a @Html.ActionLink("Home", "Index", "Home") </a>
                <a @Html.ActionLink("About", "About", "Home") </a>
                <a @Html.ActionLink("Contact", "Contact", "Home") </a>
                <a @Html.ActionLink("Covid19", "Covid19", "Home") </a>
                <a @Html.ActionLink("Fitness", "Fitness", "Home") </a>
                <div class="mynav_dropdown">
                    <button class="mynav_dropbtn">
                        Covid19
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="mynav_dropdown-content">
                        <a href="#">Link 1</a>
                        <a href="#">Link 2</a>
                        <a href="#">Link 3</a>
                    </div>
                </div>
                <div class="mynav_dropdown">
                    <button class="mynav_dropbtn">
                        Fitness
                        <i class="fa fa-caret-down"></i>
                    </button>
                    <div class="mynav_dropdown-content">
                        <a @Html.ActionLink("Fitness", "Fitness", "Home") </a>
                        <a href="#">Link 2</a>
                        <a href="#">Link 3</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
