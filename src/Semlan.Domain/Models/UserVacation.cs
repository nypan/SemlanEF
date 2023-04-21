

namespace Semlan.Domain.Models
{
    public class UserVacation
    {
        public int Id { get; set; }
        public User User { get; set; }

        public DateTime HolidayDate { get; set; }
    }
}
