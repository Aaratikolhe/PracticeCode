using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArraysAndCollection
{
    public class BusRoutesRepository
    {
		private readonly BusRoute[] allRoutes;
		public  BusRoutesRepository()
		{
			allRoutes= new BusRoute[] {
            new BusRoute(11, new string[]{"Nigdi","Bhosari","Chakan","Pune Station"}),
            new BusRoute(12, new string[]{"Pashan","Baner","Chakan","Pune"}),
            new BusRoute(13, new string[]{"Ravet","Wakad","Aundh","Pune"}),

			};
		}
		public BusRoute[] FindAllBusToRoute(string location)
		{
			return Array.FindAll(allRoutes, route => route.Serves(location));

			//return Array.FindAll(allRoutes, route => route.Origin == location || route.Destination == location);
		}
		public BusRoute[] FindBusesBetween(string location1, string location2)
		{
			return Array.FindAll(allRoutes,
				route => route.Serves(location1) && route.Serves(location2));
		}


	}
}
