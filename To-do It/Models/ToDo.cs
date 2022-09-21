using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_It.Models
{
    public class ToDo
    {
        private int id;
        private string description;
        private bool done;
        private Person assignee;
        public ToDo(int id, string description)
        {
            this.id = id;
            this.description = description;
        } 
    }
}
