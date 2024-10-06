namespace National_Museum_2.Model
{
    public class WorkShedule
    {
        public required int workSheduleId { get; set; }
        public required string workShedule { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
