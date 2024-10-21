
using Microsoft.Identity.Client;
using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Maintenance
    {
        public int maintenanceId { get; set; }
        public virtual required int  artObject_Id { get; set; }
        public virtual  ArtObject artObject { get; set; }
        public required DateTime starDate { get; set; }
        public required DateTime endDate { get; set; }
        public required string description { get; set; }
        public required int cost { get; set; }

        public List<MaintenanceXEmployee> maintenanceXEmployees { get; set; }

        

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
