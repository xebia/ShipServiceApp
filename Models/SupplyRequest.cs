namespace ShipServicesApp.Models
{
    public class SupplyRequest
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public string SupplyType { get; set; }
        public int Quantity { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Status { get; set; }
    }
}