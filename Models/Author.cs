namespace Dragut_Elisa_Lab2.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorFullName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
