using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Collection
    {
        public int collectionId { get; set; }
        public required string name { get; set; }
        public required string description { get; set; }

        public List<TicketXCollection> ticketXCollections { get; set; }
        public List <ArtRoom> artRooms { get; set; }
        
        

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
