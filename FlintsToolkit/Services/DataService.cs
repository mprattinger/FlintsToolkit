using FlintsToolkit.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlintsToolkit.Modules.Tasks.Models;

namespace FlintsToolkit.Services
{
    public class DataService : IDataService
    {
        public async Task<List<TaskItem>> LoadTasksFromDb()
        {
            var ret = new List<TaskItem>();

            var t = new TaskItem { TaskId = new Guid(), Title = "My First", Description = "Das ist mein erster Task" };
            ret.Add(t);
            t = new TaskItem { TaskId = new Guid(), Title = "My Second", Description = "Das ist mein erster Task" };
            ret.Add(t);
            t = new TaskItem { TaskId = new Guid(), Title = "Another", Description = "Das ist mein erster Task" };
            ret.Add(t);
            t = new TaskItem { TaskId = new Guid(), Title = "Also one from Me", Description = "Das ist mein erster Task" };
            ret.Add(t);
            t = new TaskItem { TaskId = new Guid(), Title = "One with a very long title and some other stuff", Description = "Das ist mein erster Task" };
            ret.Add(t);

            await Task.Delay(500);

            return ret;
        }
    }
}
