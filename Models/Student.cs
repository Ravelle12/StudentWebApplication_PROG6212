using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentWebApplication.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Column(TypeName ="nvarchar(14)")]
        [DisplayName("Student Number")]
        [Required(ErrorMessage ="This Field is required")]
        [MaxLength(14,ErrorMessage ="Maximum 14 characters only.")]
        public string StudentNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Student Name")]
        [Required(ErrorMessage = "This Field is required")]
        public string StudentName { get; set;}

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Student Email")]
        [Required(ErrorMessage = "This Field is required")]
        public string StudentEmail { get; set;}

        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Student Code")]
        [Required(ErrorMessage = "This Field is required")]
        [MaxLength(10, ErrorMessage = "Maximum 14 characters only.")]
        public string StudentCode { get; set;}

        [Required(ErrorMessage = "This Field is required")]
        public string StudentStudyTime { get; set;}

        [DisplayFormat(DataFormatString ="{0:MMM-DD-YY")]
        public DateTime Date { get; set;}

       
    }
}
