namespace National_Museum_2.DTO.Category
{
    public interface IGetCategoryRequest
    {
        int categoryId { get; set; }
        string category {  get; set; }
    }
    public class GetCategoryRequest : IGetCategoryRequest
    {
        public int categoryId { get; set; }
        public string category { get; set; }
    }

}
