namespace TagsService.Models
{
    public class TagModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? HexColor { get; set; }
        public string? Image { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreatedAt  { get; set; }
        public DateTime UpdatedAt  { get; set; }

    }
}
