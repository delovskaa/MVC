using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab5MVC.Models
{
    public class FriendContext : DbContext
    {
        public DbSet<FriendModel> friends { get; set; }
        public FriendContext() : base("DefaultConnection") { }
        public static FriendContext Create()
        {
            return new FriendContext();
        }
    }
}