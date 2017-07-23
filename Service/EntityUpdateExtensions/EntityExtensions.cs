﻿using Model;
using Service.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.EntityUpdateExtensions
{
    public static class EntityExtensions
    {
        public static void UpdateStudent(this Student student, StudentViewModel studentVM)
        {
            student.Id = studentVM.Id;
            student.Name = studentVM.Name;
            student.EnrollmentDate = studentVM.EnrollmentDate;
        }
    }
}
