namespace ShipServicesApp.Models
{
    public class HusbandingRequest
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public string RequestDetails { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Status { get; set; }
    }
}