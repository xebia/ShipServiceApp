namespace ShipServicesApp.Models
{
    public class CrewRequest
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public string RequestType { get; set; }
        public DateTime RequestedDate { get; set; }
        public string Status { get; set; }
    }
}