using FlintsToolkit.Modules.Tasks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlintsToolkit.Contracts
{
    public interface IDataService
    {
        Task<List<TaskItem>> LoadTasksFromDb();
    }
}
