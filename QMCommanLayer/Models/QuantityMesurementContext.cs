using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QMCommanLayer.Models
{
    public class QuantityMesurementContext : DbContext
    {
        public QuantityMesurementContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<QuantityMesurement> QuantityMesurementTable { get; set; }
        public DbSet<QuantityMesurementCompare> QuantityMesurementCompareTable { get; set; }

    }
}
