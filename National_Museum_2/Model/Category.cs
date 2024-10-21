using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Category
    {
        public int categoryId { get; set; }

        public required string  category { get; set; }

        public List<ArtObject> artObjects { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }

}
