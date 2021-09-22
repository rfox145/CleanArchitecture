﻿using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext context;

        public CourseRepository(UniversityDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }
    }
}
