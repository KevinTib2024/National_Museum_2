using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class HistoricMaintenance
    {
        public int historicMaintenanceId { get; set; }
        public virtual required Maintenance maintenance_Id { get; set; }
        public virtual required ArtObject artObject_Id { get; set; }
        public required DateTime starDate { get; set; }
        public required DateTime endDate { get; set; }
        public required string description { get; set; }
        public required int cost { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
