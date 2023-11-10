﻿using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concretes
{
    public class InstructorManager
    {
        public void Add(Instructor instructor)
        {
            AdoNetInstructorDal adoNetInstructorDal = new AdoNetInstructorDal();
            adoNetInstructorDal.Add(instructor);
        }
    }
}
