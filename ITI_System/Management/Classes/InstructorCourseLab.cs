﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_System
{
    public class InstructorCourseLab
    {
        [ForeignKey("Instructor")]
        public int InstID { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }
        [ForeignKey("Lab")]
        public int LabID { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        [ForeignKey("Lab")]
        public Lab Lab { get; set; }
        [ForeignKey("Course")]
        public Course Course { get; set; }

    }
}
