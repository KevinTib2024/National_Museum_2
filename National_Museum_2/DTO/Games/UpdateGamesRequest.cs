using National_Museum_2.DTO.Games;

namespace National_Museum_2.DTO.Games
{
    public interface IUpdateGamesRequest
    {
        int gameId {  get; set; }
        int? user_Id { get; set; }
        DateTime? gameDate { get; set; }
        int? gameState_Id { get; set; }
        string? gameTime { get; set; }
        string? punctuation { get; set; }
        int? scenary_Id { get; set; }
        int? gameProgress_Id { get; set; }
    }
    public class UpdateGamesRequest : IUpdateGamesRequest
    {
        public int gameId { get; set; }
        public int? user_Id { get; set; }
        public DateTime? gameDate { get; set; }
        public int? gameState_Id { get; set; }
        public string? gameTime { get; set; }
        public string? punctuation { get; set; }
        public int? scenary_Id { get; set; }
        public int? gameProgress_Id { get; set; }
    }

}
