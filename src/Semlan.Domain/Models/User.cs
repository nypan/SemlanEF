
namespace Semlan.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }
    }
}
