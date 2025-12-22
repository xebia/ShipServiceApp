using System;
using System.Collections.Generic;
using ShipServicesApp.Models;

namespace ShipServicesApp.Services
{
    public class DemoDataService
    {
        public List<ShipAgency> ShipAgencies { get; set; } = new()
        {
            new ShipAgency { Id = 1, AgencyName = "Blue Ocean Maritime", ContactPerson = "Alice Dsouza", ContactEmail = "alice@blueocean.com" },
            new ShipAgency { Id = 2, AgencyName = "Global Ports", ContactPerson = "John Lee", ContactEmail = "john@globalports.com" }
        };

        public List<PortCaptain> PortCaptains { get; set; } = new()
        {
            new PortCaptain { Id = 1, Name = "Captain Sharma", AssignedPort = "Chennai", ContactNumber = "9998887771" },
            new PortCaptain { Id = 2, Name = "Captain Mehra", AssignedPort = "Mumbai", ContactNumber = "8887776665" }
        };
        public List<CrewRequest> CrewRequests { get; set; } = new()
        {
            new CrewRequest { Id = 1, ShipName = "MV Seastar", RequestType = "Emergency Repair", RequestedDate = DateTime.Today.AddDays(-2), Status = "Completed" },
            new CrewRequest { Id = 2, ShipName = "SS Marine", RequestType = "Replacement Crew", RequestedDate = DateTime.Today.AddDays(-1), Status = "Pending" }
        };

        public List<SupplyRequest> SupplyRequests { get; set; } = new()
        {
            new SupplyRequest { Id = 1, ShipName = "MV Seastar", SupplyType = "Fresh Water", Quantity = 20, RequestedDate = DateTime.Today.AddDays(-3), Status = "Delivered" },
            new SupplyRequest { Id = 2, ShipName = "SS Marine", SupplyType = "Bunkers", Quantity = 50, RequestedDate = DateTime.Today, Status = "In Progress" },
            new SupplyRequest { Id = 3, ShipName = "MV Horizon", SupplyType = "Lubes", Quantity = 10, RequestedDate = DateTime.Today.AddDays(-1), Status = "Pending" }
        };

        public List<ShipRepair> ShipRepairs { get; set; } = new()
        {
            new ShipRepair { Id = 1, ShipName = "Marine Star", RepairType = "Hull Repair", Description = "Minor cracks at port side", RequestedDate = DateTime.Today.AddDays(-4), Status = "Completed" },
            new ShipRepair { Id = 2, ShipName = "Blue Whale", RepairType = "Engine Overhaul", Description = "Routine maintenance", RequestedDate = DateTime.Today.AddDays(-2), Status = "Scheduled" }
        };

        public List<CustomStore> CustomStores { get; set; } = new()
        {
            new CustomStore { Id = 1, ShipName = "SS Marine", StoreItem = "Engine Parts", ClearanceStatus = "Cleared", ClearanceDate = DateTime.Today.AddDays(-2) },
            new CustomStore { Id = 2, ShipName = "MV Horizon", StoreItem = "Food Supplies", ClearanceStatus = "Waiting", ClearanceDate = DateTime.Today }
        };

        public List<UnderwaterService> UnderwaterServices { get; set; } = new()
        {
            new UnderwaterService { Id = 1, ShipName = "Marine Star", ServiceType = "Diving Inspection", ServiceDate = DateTime.Today.AddDays(-3), Status = "Completed" },
            new UnderwaterService { Id = 2, ShipName = "Blue Whale", ServiceType = "Cleaning", ServiceDate = DateTime.Today, Status = "Scheduled" }
        };

        public List<HusbandingRequest> HusbandingRequests { get; set; } = new()
        {
            new HusbandingRequest { Id = 1, ShipName = "MV Seastar", RequestDetails = "Medical Supplies", RequestedDate = DateTime.Today.AddDays(-1), Status = "Delivered" },
            new HusbandingRequest { Id = 2, ShipName = "SS Marine", RequestDetails = "Trash Removal", RequestedDate = DateTime.Today.AddDays(-2), Status = "Pending" }
        };

        public List<TankCleaningRequest> TankCleaningRequests { get; set; } = new()
        {
            new TankCleaningRequest { Id = 1, ShipName = "Horizon Chem", ChemicalUsed = "EcoClean X1", CleaningDate = DateTime.Today.AddDays(-5), Status = "Completed" },
            new TankCleaningRequest { Id = 2, ShipName = "Blue Whale", ChemicalUsed = "AquaSafe", CleaningDate = DateTime.Today.AddDays(-1), Status = "Scheduled" }
        };
    }
}