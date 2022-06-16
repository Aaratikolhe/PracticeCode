using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArraysAndCollection
{
    public class BusRoute
    {

		public int RouteNumber { get; }
		public string? Origin=> PlacesServed[0];
	
		public string Destination => PlacesServed[PlacesServed.Length-1];

		public string[] PlacesServed { get; }
		
		public BusRoute(int number, string[] placesServed)
		{
			this.RouteNumber = number;
			this.PlacesServed = placesServed;
		}

		public override string ToString()
        {
			return $"Route Number {RouteNumber}: {Origin} -> {Destination}";
		}
		public bool Serves(string destination)
		{
			return Array.Exists(PlacesServed, place => place == destination);
			
		}
	}
}
