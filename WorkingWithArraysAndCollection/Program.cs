namespace WorkingWithArraysAndCollection
{
	class Program
	{
		public static void Main(string[] args)
		{
			BusRoutesRepository repository = new BusRoutesRepository();

			Console.WriteLine("Where are you?");
			string startingLocation = Console.ReadLine();

			Console.WriteLine("Where do you want to go to?");
			string goingTo = Console.ReadLine();

			BusRoute[] originRoutes = repository.FindAllBusToRoute(startingLocation);
			BusRoute[] destinationRoutes = repository.FindAllBusToRoute(goingTo);

			HashSet<BusRoute> routes = new HashSet<BusRoute>(originRoutes);
			routes.IntersectWith(destinationRoutes);

			if (routes.Count > 0)
				foreach (BusRoute route in routes)
					Console.WriteLine($"You can use route {route}");
			else
				Console.WriteLine($"No routes go between {startingLocation} and {goingTo}");
		}		
		
	}	
}