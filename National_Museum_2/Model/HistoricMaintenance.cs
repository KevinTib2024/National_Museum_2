using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class HistoricMaintenance
    {
        public int historicMaintenanceId { get; set; }
        public required int maintenance_Id { get; set; }
        public required int artObject_Id { get; set; }
        public required DateTime starDate { get; set; }
        public required DateTime endDate { get; set; }
        public required string description { get; set; }
        public required int cost { get; set; }
        public required DateTime ModificationDate { get; set; }
        public required int ModicationBy { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
