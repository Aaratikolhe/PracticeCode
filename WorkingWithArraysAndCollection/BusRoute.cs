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
		//public string origin;
		//public string Origin
		//{
		//	get
		//	{
		//		return origin;
		//	}
		//	set
		//	{

		//		origin = value
		//	}
		//}
		//public string destination;
		public string Destination => PlacesServed[PlacesServed.Length-1];

		//public string Destination
		//{
		//	get
		//	{
		//		return origin;
		//	}
		//	set
		//	{

		//		origin =value;
		//	}
		//}
		public string[] PlacesServed { get; }
		//public BusRoute(int number, string origin,string destination )
		//{
		//	this.RouteNumber = number;
		//	this.origin = origin;
		//	this.destination = destination;
		//}
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
