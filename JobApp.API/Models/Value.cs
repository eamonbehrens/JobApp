using System;
using System.ComponentModel.DataAnnotations;

namespace JobApp.API.Models
{
    public class Value
    {
        [Key]
        public int Id {get; set;}
        public string Name {get; set;}
        
    }
}