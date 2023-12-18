using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class RoleEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        // Navigation Properties
        public List<UserEntity>? Users { get; set; }
    }
}
