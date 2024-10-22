using System;

namespace National_Museum_2.DTO.Maintenance
{
    public class ICreateMaintenanceRequest
    {
        int artObject_Id{ get; set; }
        DateTime starDate { get; set; }
        DateTime endDate { get; set; }
        string description { get; set; }
        int cost { get; set; }
    }
    public class CreateMaintenanceRequest : ICreateMaintenanceRequest
    {
        public int artObject_Id { get; set; }
        public DateTime starDate { get; set; }
        public DateTime endDate { get; set; }
        public string description { get; set; }
        public int cost { get; set; }
    }
}
