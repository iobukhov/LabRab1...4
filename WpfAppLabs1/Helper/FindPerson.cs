﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppLabs1.Model;

namespace WpfAppLabs1.Helper
{
    class FindPerson
    {
        int id;
        public FindPerson(int id)
        {
            this.id = id;
        }
        public bool PersonPredicate(Person person)
        {
            return person.Id == id;
        }
    }
}
