namespace AlbumList.Models
{
    public class Album
    {
        public int AlbumId { get; set; }

        public int? Year { get; set; }

        public string Name { get; set; }

        public string Slug =>
            Name?.Replace(' ', '-').ToLower() + '-' + Year?.ToString();
    }
}