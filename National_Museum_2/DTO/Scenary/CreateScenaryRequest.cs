namespace National_Museum_2.DTO.Scenary
{
    public class ICreateScenaryRequest
    {
        string scenaryName { get; set; }
        string description { get; set; }
        int order { get; set; }
        int achievementsobtained { get; set; }
    }
    public class CreateScenaryRequest : ICreateScenaryRequest
    {
        public string scenaryName { get; set; }
        public string description { get; set; }
        public int order { get; set; }
        public int achievementsobtained { get; set; }
    }
}
