namespace InterfaceSegregation
{

    public class SailBoat : IRental
    {
        public int RentalId { get; set; }
        public string CurrentRenter { get; set; }
        public decimal PricePerDay { get; set; }
    }

}