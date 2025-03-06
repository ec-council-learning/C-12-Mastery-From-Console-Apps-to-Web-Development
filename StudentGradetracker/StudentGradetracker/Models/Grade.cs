﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentGradetracker;

namespace StudentGradetracker.Models
{
    public class Grade
    {
        public string Subject { get; set; }
        public double Score { get; set; }

        public Grade(string subject, double score)
        {
            Subject = subject;
            Score = score;
        }

        public override string ToString()
        {
            return $"{Subject}: {Score:F2}";
        }
    }
}
