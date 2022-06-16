namespace WorkingWithArraysAndCollection
{
	class Program
	{
		public static void Main(string[] args)
		{
			var allRoutes = BusRoutesRepository.InitializeRoutes();

			Console.WriteLine("Which number of bus you want to take?");
			int busNumber = Convert.ToInt32(Console.ReadLine());

			//BusRoute busRoute= allRoutes[busNumber];
			//if (busRoute != null)
				//Console.WriteLine($"The route of the bus number {busNumber} is  {busRoute}");
			//else
				//Console.WriteLine($"There is no route with number {busNumber}");

			bool success = allRoutes.TryGetValue(busNumber, out BusRoute busRoute1);
			if (success)
				Console.WriteLine($"The route of the bus number {busNumber} is  {busRoute1}");
			else
				Console.WriteLine($"There is no route with number {busNumber}");

			bool success2 = allRoutes.ContainsKey(busNumber);
			if (success2)
				Console.WriteLine($"The route of the bus number {busNumber} is  {allRoutes[busNumber]}");
			else
				Console.WriteLine($"There is no route with number {busNumber}");

		}		
		
	}	
}