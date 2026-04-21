using FacebookClone.Domain.Enums;

namespace FacebookClone.Domain.Entities
{
    public class User
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public Sex Gender { get; set; }
        public RelationshipStatus RelStatus { get; set; }
        public DateTime JoinedDate { get; set; } = DateTime.UtcNow;

        public ICollection<Friendship> FriendRequestSent { get; set; }
        public ICollection<Friendship> FriendRequestReceived { get; set; }
    }
}
