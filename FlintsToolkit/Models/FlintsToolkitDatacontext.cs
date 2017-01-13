using FlintsToolkit.Modules.Tasks.Models;
using System.Data.Entity;

namespace FlintsToolkit.Models
{
    public class FlintsToolkitDatacontext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
