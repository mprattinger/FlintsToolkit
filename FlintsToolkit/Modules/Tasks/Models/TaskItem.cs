using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FlintsToolkit.Modules.Tasks.Models
{
    public class TaskItem
    {
        public Guid TaskId { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "varchar(MAX)")]
        public string Description { get; set; }

        public string State { get; set; }
    }
}
