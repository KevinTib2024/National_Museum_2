using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Scenary
    {
        public int scenaryId { get; set; }
        public required string  scenaryName { get; set; }
        public required string description { get; set; }  
        public required int order { get; set; }
        public required int achievementsobtained { get; set; }

        public List<Games> games { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
