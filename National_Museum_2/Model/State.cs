using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class State
    {
        public int stateId { get; set; }

        public required string state { get; set; }

        public List<ArtObject> artObjects { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
