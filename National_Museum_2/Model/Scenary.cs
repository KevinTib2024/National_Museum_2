namespace National_Museum_2.Model
{
    public class Scenary
    {
        public  virtual int scenaryId { get; set; }
        public required string  scenaryName { get; set; }
        public required string Description { get; set; }  

        public required int order { get; set; }

        public required int achievementsobtained { get; set; }
}
}
