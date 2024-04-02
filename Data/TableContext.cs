using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Note_Taking_App.Models;

namespace Note_Taking_App.Data
{
    public class TableContext: DbContext
    {
        public TableContext(DbContextOptions<TableContext>options): base(options) { }

        public DbSet<TableModel> Notes { get; set; }
    }
}
