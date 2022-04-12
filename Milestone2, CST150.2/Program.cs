//Roberto GonzalezRamirez
//Class CST-150

namespace Milestone2
{
    internal class InventoryClass
    {
        //Defined properties
        public string VehicleYear { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public string VehicleColor { get; set; }
        public double VehiclePrice { get; set; }
        public string VehicelDescription { get; set; }

        //Driver
        public InventoryClass(string year, string make, string model, string color, double price, string description)
        {
            this.VehicleYear = year;
            this.VehicleMake = make;
            this.VehicleModel = model;
            this.VehicleColor = color;
            this.VehiclePrice = price;
            this.VehicelDescription = description;
        }


    }
}