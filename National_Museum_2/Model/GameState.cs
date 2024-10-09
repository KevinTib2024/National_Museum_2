using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class GameState
    {
        public int gameStateId { get; set; }
        public required string gameState { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
