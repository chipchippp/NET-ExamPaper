using System.ComponentModel.DataAnnotations;

namespace ExamPaper1.Models
{
    public class Account
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
