using System;
using System.ComponentModel.DataAnnotations;

namespace CIDM3312_WorkList.Models
{
    public class User
    {
        public int UserId {get; set;}
        public string Name {get; set;} = string.Empty;
        public int Age {get; set;}
        public string Email {get; set;} = string.Empty;
        public string SkillLevel {get; set;} = string.Empty;
    }
}