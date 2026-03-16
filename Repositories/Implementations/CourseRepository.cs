using System;
using System.Collections.Generic;
using System.Text;
using UniversityAcademicManagementSystem.Data;
using UniversityAcademicManagementSystem.Models;
using UniversityAcademicManagementSystem.Repositories.Interfaces;

namespace UniversityAcademicManagementSystem.Repositories.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public void AddCourse(Course course)
        {
            if (string.IsNullOrWhiteSpace(course.CourseName))
                throw new ArgumentException("Invalid Input");
            if (course.Credits <= 0)
                throw new ArgumentException("Credits must be greater than zero.");

            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void UpdateCourse(Course course)
        {
            var existing = _context.Courses.Find(course.CourseId);
            if (existing == null)
                throw new KeyNotFoundException($"Course with ID {course.CourseId} not found.");

            existing.CourseName = course.CourseName;
            existing.Credits = course.Credits;
            existing.Department = course.Department;
            existing.SemesterOffered = course.SemesterOffered;

            _context.SaveChanges();
        }

        public Course GetCourseDetails(int id)
        {
            var course = _context.Courses.Find(id);
            if (course == null)
                throw new KeyNotFoundException($"Course with ID {id} not found.");
            return course;
        }

        public IEnumerable<Course> ListCoursesBySemester(string semester)
        {
            if (string.IsNullOrWhiteSpace(semester))
                throw new ArgumentException("Semester cannot be empty.");

            return _context.Courses.Where(c => c.SemesterOffered == semester).ToList();
        }
    }
}
