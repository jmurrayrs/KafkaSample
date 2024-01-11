namespace SocialMedia.Post.Domain.Events
{
    public class PostDeletedEvent
    {
        public Guid PostId { get; }
        public PostDeletedEvent(Guid postId)
        {
            PostId = postId;
        }
    }
}