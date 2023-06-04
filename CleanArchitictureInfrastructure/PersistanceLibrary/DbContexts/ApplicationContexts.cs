using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceLibrary.DbContexts
{
    public class ApplicationContexts:DbContext
    {
        public ApplicationContexts(DbContextOptions options) : base(options)
        {
        }
    }
}
