using HRP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRP.Data
{
    public class HrpDbContext : DbContext
    {

        public HrpDbContext(DbContextOptions<HrpDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<ComplaintHandle> Complaint_Handlers { get; set; }
        public virtual DbSet<Complaints> Complaints { get; set; }
        public virtual DbSet<ComplaintType> Complaint_Types { get; set; }
        public virtual DbSet<Police> Polices { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Position> Positions { get; set; }
    }
}

