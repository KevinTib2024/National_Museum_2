namespace National_Museum_2.DTO.GameState
{
    public class ICreateGameStateRequest
    {
        string gameState {  get; set; }
    }
    public class CreateGameStateRequest : ICreateGameStateRequest
    {
       public  string gameState { get; set; }
    }
}
