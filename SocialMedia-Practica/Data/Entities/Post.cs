namespace Practica.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string Content { get; set; }

        public string PictureURL { get; set; }

        public User User { get; set; }
    }
}