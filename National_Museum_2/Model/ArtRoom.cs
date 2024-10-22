using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class ArtRoom
    {
        public int artRoomId { get; set; } 

        public required string name { get ; set; }
        public required string description { get; set; }
        public required string numberExhibitions { get; set; }

        public virtual required int location_Id{ get; set; }
        public virtual  Location location{ get; set; }

        public virtual required int  collection_Id { get; set; }
        public virtual  Collection collection { get; set; }

        public List<EmployeesXArtRoom> employeesXArtRoom { get; set; }

        public List<Exhibition> exhibition { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;

    }
}
