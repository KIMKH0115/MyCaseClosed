using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApp4.Models;

namespace WebApp4.Context
{
    public class fDatabase : DbContext
    {
        public fDatabase() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\KOSTA\source\repos\WebApp4\mydatabase.mdf"";Integrated Security=True;Connect Timeout=30")
        {

        }
        public DbSet<Facility> facilities { get; set; }
    }
}