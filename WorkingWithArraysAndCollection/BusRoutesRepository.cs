using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArraysAndCollection
{
    public class BusRoutesRepository
    {
		public static Dictionary<int, BusRoute> InitializeRoutes()
		{

			BusRoute route1 = new BusRoute(1, new string[] { "Nigdi", "Bhosari", "Chakan", "Pune Station" });
			BusRoute route2 = new BusRoute(2, new string[] {"Pashan","Baner","Chakan","Pune"});
			BusRoute route3 = new BusRoute(3, new string[] { "Ravet", "Wakad", "Aundh", "Pune" });

			var routes = new Dictionary<int, BusRoute>
			{
				{ 1, route1 },
				{ 2, route2 },
				{ 3, route3 },
			};
			return routes;
		}


	}
}
