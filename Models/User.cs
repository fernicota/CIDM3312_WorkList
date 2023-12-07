using System;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312_WorkList.Models
{
    public class User
    {
        public int UserId {get; set;}
        [Required] 
        [StringLength(35, MinimumLength = 3)]
        public string Name {get; set;} = string.Empty;
        [Required]
        public int Age {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;} = string.Empty;
        [Required]
        public string SkillLevel {get; set;} = string.Empty;
        public List<Work> Works {get; set;} = new List<Work>();
    }
}