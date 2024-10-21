using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Games
    {
        public int gameId { get; set; }

        public virtual required int user_Id { get; set; }
        public virtual User user { get; set; }

        public required DateTime gameDate { get; set; }

        public virtual required int gameState_Id { get; set; }
        public virtual GameState gameState { get; set; }

        public required string gameTime { get; set; }

        public required string punctuation { get; set; }

        public virtual required int scenary_Id { get; set; }
        public virtual Scenary scenary{ get; set; }

        public virtual required int gameProgress_Id { get; set; }
        public virtual GameProgress gameProgress { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}
