using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Models
{
    public class HrpDbContextold:DbContext
    {
        
        public HrpDbContextold  (DbContextOptions<HrpDbContextold> options)  
            : base(options)  
        {  
        }
    public virtual DbSet<Admin> Admin { get; set; }

    }
}
