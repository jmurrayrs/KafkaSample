using MediatR;

namespace SocialMedia.Post.Domain.Events
{
    public class PostCreatedEvent
        : INotification
    {
        public Guid PostId { get; }

        public PostCreatedEvent(Guid postId)
        {
            PostId = postId;
        }

    }
}