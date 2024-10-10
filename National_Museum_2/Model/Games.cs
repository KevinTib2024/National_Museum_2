﻿using System.ComponentModel;

namespace National_Museum_2.Model
{
    public class Games
    {
        public int gameId { get; set; }

        public virtual required User user_Id { get; set; }

        public required DateTime gameDate { get; set; }

        public virtual required GameState gameState_Id { get; set; }

        public required string gameTime { get; set; }

        public required string punctuation { get; set; }

        public virtual required Scenary scenary_Id { get; set; }

        public virtual required GameProgress gameProgress_Id { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; } = false;
    }
}