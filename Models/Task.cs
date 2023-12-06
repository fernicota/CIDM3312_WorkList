using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using NuGet.Protocol.Plugins;

namespace CIDM3312_WorkList.Models
{
    public class Task
    {
        public int TaskId {get; set;}
        public string Name {get; set;} = string.Empty;
        public string Description {get; set;} = string.Empty;
        public DateTime DateCreated {get; set;} 
        public string Duration {get; set;} = string.Empty;
    }
}