using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Exhibition
    {
        public int exhibitionId { get; set; }

        public required string name { get; set; }
        public required string description{ get; set; }
        public virtual required int artRoom_Id { get; set; }
        public virtual  ArtRoom artRoom { get; set; }

        public List <ArtObject> artObjects { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;

    }
}
