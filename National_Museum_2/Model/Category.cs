namespace National_Museum_2.Model
{
    public class Category
    {
        public int categoryId { get; set; }

        public required string  category { get; set; }

        public bool IsDeleted { get; set; } = false;
    }

}
