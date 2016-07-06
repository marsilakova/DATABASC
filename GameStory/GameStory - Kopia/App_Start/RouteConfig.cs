﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace GameStory
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "list/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list/{category}/{page}",
                                        "~/Pages/Listing.aspx");//sista
                                                                ///----Согласно этим добавлениям, URL
            /////вида /admin/orders приведет к обработке файла веб-формы \Pages\Admin\Orders.aspx, 
            //a URL вида /admin/products — к обработке файла веб-формы \Pages\Admin\Products.aspx.
            // Новые маршруты для административных страниц
            routes.MapPageRoute("admin_orders", "admin/orders", "~/Pages/Admin/Orders.aspx");
            routes.MapPageRoute("admin_games", "admin/games", "~/Pages/Admin/Games.aspx");

            // Обратите внимание что это именованный маршрут
            routes.MapPageRoute("cart", "cart", "~/Pages/CartView.aspx");
            routes.MapPageRoute("checkout", "checkout", "~/Pages/Checkout.aspx");
        }

    }
}