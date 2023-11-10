using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concretes
{
    public class CourseInstructorManager
    {
        public void Add(CourseInstructor courseInstructor)
        {
            AdoNetCourseInstructorDal adoNetCourseInstructorDal = new AdoNetCourseInstructorDal();
            adoNetCourseInstructorDal.Add(courseInstructor);
        }
    }
}
