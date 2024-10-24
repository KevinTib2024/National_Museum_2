namespace National_Museum_2.DTO.Collection
{
    public class ICreateCollectionRequest
    {
        string name {  get; set; }
        string descriptiom { get; set; }
    }
    public class CreateCollectionRequest :ICreateCollectionRequest
    {
        public string name { get; set; }
        public string descriptiom { get; set; }
    }
}
