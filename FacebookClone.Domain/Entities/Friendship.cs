using FacebookClone.Domain.Enums;

namespace FacebookClone.Domain.Entities
{
    public class Friendship
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string RequesterId { get; set; }
        public User Requester { get; set; }
        public string AddresseeId { get; set; }
        public User Addressee { get; set; }
        public RequestStatus Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
