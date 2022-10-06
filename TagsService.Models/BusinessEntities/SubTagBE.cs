using System.ComponentModel.DataAnnotations;

namespace TagsService.Models.BusinessEntities
{
    public class SubTagBE
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }

        public int? TagId { get; set; }

        public bool? IsActive { get; set; }
    }
}
