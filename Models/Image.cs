namespace AlbiBlogu.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Length { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
    }

}
