namespace SocialMedia.Post.Domain.Aggregates
{
    public struct Post
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}