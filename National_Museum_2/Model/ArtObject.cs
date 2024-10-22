using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class ArtObject
    {
        public int artObjectId { get; set; }

        public required string name { get; set; }
        public required string description { get; set; }
        public required string artist { get; set; }
        public required string creationDate { get; set; }
        public required string origin { get; set; }
        public required string cost { get; set; }

        public virtual required int category_Id { get; set; }
        public virtual Category category { get; set; }

        public virtual required int state_Id { get; set; }
        public virtual  State state { get; set; }

        public virtual required int exhibition_Id { get; set; }
        public virtual  Exhibition exhibition { get; set; }

        public List<Maintenance> maintenance { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;

    }
}
