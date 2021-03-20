Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Public Module RouteConfig
    Public Sub RegisterRoutes(ByVal routes As RouteCollection)
        routes.IgnoreRoute("{resource}.axd/{*pathInfo}")



        routes.MapRoute(
            name:="CustomersDetails_id1",
            url:="{Customers}/{Details}/1",
            defaults:=New With {.controller = "Home", .action = "Cus_Details_id1"}
        )

        routes.MapRoute(
            name:="CustomersDetails_id2",
            url:="{Customers}/{Details}/2",
            defaults:=New With {.controller = "Home", .action = "Cus_Details_id2"}
        )

        routes.MapRoute(
            name:="CustomersDetails_404",
            url:="{Customers}/{Details}/{id}",
            defaults:=New With {.controller = "Home", .action = "Cus_Details_404"}
        )

        routes.MapRoute(
            name:="Default",
            url:="{controller}/{action}/{id}",
            defaults:=New With {.controller = "Home", .action = "Index", .id = UrlParameter.Optional}
        )
    End Sub
End Module