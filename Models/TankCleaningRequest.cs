namespace ShipServicesApp.Models
{
    public class TankCleaningRequest
    {
        public int Id { get; set; }
        public string ShipName { get; set; }
        public string ChemicalUsed { get; set; }
        public DateTime CleaningDate { get; set; }
        public string Status { get; set; }
    }
}