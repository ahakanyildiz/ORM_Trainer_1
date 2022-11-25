using System.ComponentModel.DataAnnotations;

namespace ORM_Trainer_1.Models
{
    public class Owner
    {
        [Key]
        public int OwnerID { get; set; }
        public string OwnerName { get; set; }  
        public List<Project> Projects { get; set; }
    }
}
