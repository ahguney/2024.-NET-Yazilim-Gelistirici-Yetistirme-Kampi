using IntroProject.DataAccess.Abstracts;
using IntroProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProject.Business
{
    public class CourseManager
    {
        //Dependency Injection
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> GetAll()
        {


            return _courseDal.GetAll();
        }


    }
}
