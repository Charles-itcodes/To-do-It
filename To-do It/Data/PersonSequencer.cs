﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_do_It.Models;

namespace To_do_It.Data
{
    public class PersonSequencer
    {
        private static int personId;

        public static int PersonId {
            get 
            {
              return personId;
            }
            set
            {
                personId = value;
            }
        }
    
    public static int NextPersonId()
        {
            personId++;

            return personId; 
        }
    public static int Reset()
        {
        personId = 0;
        return personId;
        }
    }
}