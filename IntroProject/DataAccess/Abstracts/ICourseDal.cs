using IntroProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroProject.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Add(Course course);
    }
}
