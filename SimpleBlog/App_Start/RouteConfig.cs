﻿using System.Web.Mvc;
using System.Web.Routing;

namespace SimpleBlog
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute("Home", "", new { controller = "Posts", action = "Index" });
		}
	}
}
