namespace VideoSharingPlatform.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Length { get; set; }
        public int Views { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }   
        public User? Creator { get; set; }
    }
}
