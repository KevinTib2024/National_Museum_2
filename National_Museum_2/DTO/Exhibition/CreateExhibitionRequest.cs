namespace National_Museum_2.DTO.Exhibition
{
    public class ICreateExhibitionRequest
    {
        string name { get; set; }
        string description { get; set; }    
        int artRoom_Id { get; set; }    
    }
    public class CreateExhibitionRequest : ICreateExhibitionRequest
    {
        public string name { get; set; }
        public string description { get; set; }
        public int artRoom_Id { get; set; }
    }
}
