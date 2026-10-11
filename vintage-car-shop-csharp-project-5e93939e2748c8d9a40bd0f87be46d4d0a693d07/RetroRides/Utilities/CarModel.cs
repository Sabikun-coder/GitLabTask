namespace RetroRides.Utilities
{
    public class CarModel
    {
        public int CarId { get; set; }
        public string ModelName { get; set; }
        public int YearOfManufacture { get; set; }

        // Override ToString for display in ComboBox
        public override string ToString()
        {
            return $"{ModelName} ({YearOfManufacture})";
        }
    }
}
