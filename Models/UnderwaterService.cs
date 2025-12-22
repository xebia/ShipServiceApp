namespace ShipServicesApp.Models
{
    public class UnderwaterService
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public string ServiceType { get; set; }
        public DateTime ServiceDate { get; set; }
        public string Status { get; set; }
    }
}