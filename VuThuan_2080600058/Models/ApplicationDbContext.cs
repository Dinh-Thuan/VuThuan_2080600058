using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VuThuan_2080600058.Models
{
    public class ApplicationDbContext : indentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Course { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
            : base ("DefaultConnection, false")
    }

    public static ApplicationDbContext Create ()
    {
        return new ApplicationDbContext()
    }

}