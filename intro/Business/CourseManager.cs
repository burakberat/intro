using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business;

public class CourseManager
{
    Course[] courses = new Course[3];
    public CourseManager()
    {
        Course course1 = new();
        course1.Id = 1;
        course1.Name = "C# Kursu";
        course1.Description = ".Net 8 vs...";
        course1.Price = 0;

        Course course2 = new();
        course2.Id = 1;
        course2.Name = "JAVA Kursu";
        course2.Description = "JAVA 17 vs...";
        course2.Price = 10;

        Course course3 = new();
        course3.Id = 1;
        course3.Name = "Python Kursu";
        course3.Description = "Python 3.12 vs...";
        course3.Price = 20;

        courses[0] = course1;
        courses[1] = course2;
        courses[2] = course3;
    }
    public Course[] GetAll()
    {
        return courses;
    }
}
