﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        //ctor
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeSatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighetGrade = Math.Max(grade, stats.HighetGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (_name != value)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExeistingName = _name;
                    args.newName = value;
                    
                    NameChanged(this, args);
                }
                if (!string.IsNullOrEmpty(value))
                    _name = value;
            }
        }

        public event NameChangedDelegate NameChanged;

        private string _name;
        private List<float> grades;
    }
}
