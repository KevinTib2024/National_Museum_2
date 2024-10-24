namespace National_Museum_2.DTO.Category
{
    public class ICreateCategoryRequest
    { 
     string category { get; set; }
    }
    public class CreateCategoryRequest : ICreateCategoryRequest
    {
        public string category { get; set; }
    }
}
