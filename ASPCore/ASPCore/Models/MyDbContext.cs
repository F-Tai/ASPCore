using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore.Models
{
    /// <summary>
    /// Chuoi ket noi
    /// </summary>
    // https://www.connectionstrings.com/sql-server
    //
    public class MyDbContext : DbContext
    {
        //Dinh nghia cac thuoc tinh table
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa>HangHoas { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
