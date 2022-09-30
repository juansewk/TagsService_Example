using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TagsService.Models.DataModels
{
    public class TagModel
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }

        [MaxLength(10)]
        public string? HexColor { get; set; }

        public string? Image { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
