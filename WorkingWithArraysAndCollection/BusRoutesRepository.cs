using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArraysAndCollection
{
    public class BusRoutesRepository
    {
		public static BusRoute[] InitializeRoutes()
		{
			return new BusRoute[] {
            new BusRoute(11, new string[]{"Nigdi","Bhosari","Chakan","Pune Station"}),
            new BusRoute(12, new string[]{"Pashan","Baner","Chakan","Pune"}),
            new BusRoute(13, new string[]{"Ravet","Wakad","Aundh","Pune"}),

			//new BusRoute(11, "Nigdi","Bhosari"),
			//new BusRoute(12, "Pashan","Baner"),
			//new BusRoute(13, "Ravet","Baner"),
			};
		}
		

	
	}
}
