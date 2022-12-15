namespace InterfaceSegregation
{

    public class Program
    {
        static void Main(string[] args)
        {
            var rentals = new List<IRental>();

            rentals.Add(new Truck() {CurrentRenter = "Truck Renter"});
            rentals.Add(new SailBoat() {CurrentRenter = "Sailboat Renter"});
            rentals.Add(new Car() {CurrentRenter = "Car Renter"});

            foreach (var rental in rentals)
            {
                Console.WriteLine(rental);
            }
        }
    }

}