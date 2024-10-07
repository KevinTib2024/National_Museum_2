using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Gender
    {
        public int genderId { get; set; }

        public required string gender { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
