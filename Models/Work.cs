using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using NuGet.Protocol.Plugins;

namespace CIDM3312_WorkList.Models
{
    public class Work
    {
        public int WorkId {get; set;}
        [Required]
        [StringLength(35, MinimumLength = 3)]
        public string Name {get; set;} = string.Empty;
         [Required]
        [StringLength(200, MinimumLength = 20)]
        public string Description {get; set;} = string.Empty;
        [Required]
        public DateTime DateCreated {get; set;} 
        [Required]
        public string Duration {get; set;} = string.Empty;
        public int UserId {get; set;}
        public User? User {get; set;}
    }
}