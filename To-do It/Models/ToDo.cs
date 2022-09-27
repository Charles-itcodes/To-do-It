using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_It.Models
{
    public class ToDo
    {
        private readonly int id;
        private string description;
        private bool done;
        private Person Assignee;
        public ToDo(int Id, string Description)
        {
            this.id = Id;
            this.description = Description;
        } 
       public int Id
        {
            get { return id; }
            
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public bool Done 
        { 
            get { return done; }
            set { done = value; }
        }
        public Person Assignee
        {
            get { return Assignee; }
            set { Assignee = value; }
        }
    }
}
