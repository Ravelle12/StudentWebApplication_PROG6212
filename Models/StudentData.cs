using MessagePack;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentWebApplication.Models
{
    public class StudentData
    {
        [Key]
        public int StudentDataId { get; set; }

        public int StudentId { get; set; }
        public Student category { get; set; }

        public int AmountStudied { get; set; }

        [Column(TypeName = "nvarchar(75")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } =DateTime.Now;
    }
}
