namespace BlazorStudy.Models.Buffets
{
    public class Broth
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsVegan { get; set; }
        public List<Noodle> Noodles { get; set; } = new();
    }
}
