namespace National_Museum_2.DTO.GameProgress
{
    public class IUpdateGameProgressRequest
    {
        string gameProgress { get; set; }
        string description { get; set; }
    }
    public class UpdateGameProgressRequest : IUpdateGameProgressRequest
    {
        public string gameProgress { get; set; }
        public string description { get; set; }
        public int gameProgressId { get; internal set; }
    }
}
