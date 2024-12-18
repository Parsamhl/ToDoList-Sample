using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.Enums;

namespace ToDoList_sample.Entities
{
    public class Duty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeToDone { get; set; }
        public StatusEnum Status { get; set; }

        public int UserID { get; set; }
        public int OperatorId { get; set; }

        public User User { get; set; }
        public Operator Operator { get; set; }
        
    }
}
