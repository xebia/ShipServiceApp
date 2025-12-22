namespace ShipServicesApp.Models
{
    public class CustomStore
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public string StoreItem { get; set; }
        public string ClearanceStatus { get; set; }
        public DateTime ClearanceDate { get; set; }
    }
}