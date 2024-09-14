using System.ComponentModel.DataAnnotations;

namespace National_Museum_2.Model
{
    public class User
    {
        [Key]
        public required int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }
    }
}
