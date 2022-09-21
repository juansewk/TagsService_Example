using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [MaxLength(1)]
        public bool? IsActive { get; set; }
    }
}
