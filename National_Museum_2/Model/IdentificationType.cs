using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class IdentificationType
    {
        public int identificationTypeId { get; set; }

        public required string Identification_Type { get; set; }


        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
        public List<User> users { get; set; }

    }
}
