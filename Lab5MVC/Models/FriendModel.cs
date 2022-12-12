using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab5MVC.Models
{
    public class FriendModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Range(0, 200, ErrorMessage = "FriendID must be between 0-200")]
        [Display(Name = "Friend ID")]
        public int FriendID { get; set; }

        [Required] 
        public string Name { get; set; }
        [Required] 
        public string Hometown { get; set; }
    }
}