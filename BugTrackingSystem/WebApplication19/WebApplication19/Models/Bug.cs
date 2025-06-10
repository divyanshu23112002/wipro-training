using System.ComponentModel.DataAnnotations;

namespace WebApplication19.Models
{
    public class Bug
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }
        public string Severity { get; set; }  
        public string Status { get; set; }    
        public string Assignee { get; set; }
        public DateTime ReportedDate { get; set; }=DateTime.Now;
    }
}
