namespace ShipServicesApp.Models
{
    public class ShipRepair
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public string RepairType { get; set; }
        public string Description { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Status { get; set; }
    }
}