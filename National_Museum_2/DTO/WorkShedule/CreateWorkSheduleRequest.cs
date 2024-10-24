namespace National_Museum_2.DTO.WorkShedule
{
    public class ICreateWorkSheduleRequest
    {
        string workShedule { get; set; }
    }
    public class CreateWorkSheduleRequest : ICreateWorkSheduleRequest
    {
        public string workShedule { get; set; }
    }

}
