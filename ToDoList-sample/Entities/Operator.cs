using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.Enums;

namespace ToDoList_sample.Entities
{
    public class Operator
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public RoleEnum Role { get; set; }

        public List<Duty> TaskAddedBy { get; set; }




    }
}
