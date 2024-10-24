
namespace National_Museum_2.DTO.GameState
{
    public interface IUpdateGameStateRequest
    {
        int gameStateId { get; set; }
        string? gameState {  get; set; }
    }
    public class UpdateGameStateRequest : IUpdateGameStateRequest
    {
        public int gameStateId { get; set; }
        public string? gameState { get; set; }
    }

}
