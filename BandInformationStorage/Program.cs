namespace BandInformationStorage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band");
            //string name = Console.ReadLine();
            //AnnounceBand(name)


            Band band = new Band();
            band.Name = Console.ReadLine();
            band.Announce();
        }
        //public static void AnnounceBand(string bandName)
        //{
        //    Console.WriteLine("Welcome " + bandName + "to the stage");
        //}
    }

}
