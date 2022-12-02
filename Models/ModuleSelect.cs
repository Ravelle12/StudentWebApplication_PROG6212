using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentWebApplication.Models
{
    public class ModuleSelect
    {
        [Key]
        public int ModuleSelectId { get; set; }

        [Column(TypeName ="nvarchar(50")]
        public string ModuleCode { get; set;}

        [Column(TypeName = "nvarchar(5")]
        public string Icon { get; set;}

        [Column(TypeName = "nvarchar(20")]
        public string Description { get; set; } = "TimeSpent";
    }
}
