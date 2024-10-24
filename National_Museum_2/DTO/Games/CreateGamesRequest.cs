namespace National_Museum_2.DTO.Games
{
    public class ICreateGamesRequest
    {
        int user_Id { get; set; }
        DateTime gameDate { get; set; }
        int gameState_Id { get; set; }
        string gameTime { get; set; }
        string punctuation { get; set; }
        int scenary_Id { get; set; }
        int gameProgress_Id { get; set;}

    }
    public class CreateGamesRequest : ICreateGamesRequest
    {
        public int user_id { get; set; }
        public DateTime gameDate { get; set; }
        public int gameState_Id { get; set; }
        public string gameTime { get; set; }
        public string punctuation { get; set; }
        public int scenary_Id { get; set; }
        public int gameProgress_Id { get; set; }
    }
}
