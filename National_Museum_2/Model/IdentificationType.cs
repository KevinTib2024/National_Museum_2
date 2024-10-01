namespace National_Museum_2.Model
{
    public class IdentificationType
    {
        public int identificationTypeId { get; set; }

        public required string Identification_Type { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
