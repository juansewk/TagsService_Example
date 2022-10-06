using System.ComponentModel.DataAnnotations;

namespace TagsService.Models.BusinessEntities
{
    public class TagBE
    {
        [Key]
        [Required]
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

        public ICollection<SubTagBE>? subTags { get; set; }

    }
}
