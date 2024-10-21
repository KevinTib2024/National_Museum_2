using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class GameProgress
    {
        public int gameProgressId { get; set; }
        public required string gameProgress { get; set; }
        public required string description { get; set; }

        public List<Games> games { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
