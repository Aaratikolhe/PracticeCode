namespace WorkingWithArraysAndCollection
{
	class Program
	{
		public static void Main(string[] args)
		{
			BusRoute[] allRoutes = BusRoutesRepository.InitializeRoutes();

			Console.WriteLine("Where do you want to go to?");
			string location = Console.ReadLine();

			//BusRoute? route = FindBusTo(allRoutes, location);
			BusRoute[] routes = FindAllBusToRoute(allRoutes, location);

			//if (route != null)
			//	Console.WriteLine($"You can use route {route}");
			//else
			//	Console.WriteLine($"No routes go to {location}");
			if (routes.Length >0 )
				foreach (BusRoute route in routes)
				Console.WriteLine($"You can use route {route}");
			else
				Console.WriteLine($"No routes go to {location}");
		
		}

		//public static BusRoute? FindBusTo(BusRoute[] routes, string location)
		//{
		//	//foreach (BusRoute route in routes)
		//	//{
		//	//	if (route.Origin == location || route.Destination == location)
		//	//		return route;
		//	//}

		//	return Array.Find(routes, route => route.Origin == location || route.Destination == location);
		//}

		public static BusRoute[] FindAllBusToRoute(BusRoute[] routes, string location)
		{
			return Array.FindAll(routes,route=> route.Serves(location));
			
			//return Array.FindAll(routes, route => route.Origin == location || route.Destination == location);
		}
		
	}	
}