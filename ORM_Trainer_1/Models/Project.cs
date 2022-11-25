using System.ComponentModel.DataAnnotations;

namespace ORM_Trainer_1.Models
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; } 
        public string ProjectContent { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastTime { get; set; }
        public int OwnerID { get; set; }
        public Owner Owner { get; set; }
        public int StatusID { get; set; } 

    }
}
