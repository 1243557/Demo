namespace VideoSharingPlatform.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public int Subscribers { get; set; }
        public List<User>? Users { get; set; }
        public List<Video>? LikedVideos { get; set; }
    }
}
