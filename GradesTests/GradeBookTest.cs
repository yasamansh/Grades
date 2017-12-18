﻿using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradesTests
{
    [TestClass]
    public class GradeBookTest
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeSatistics();
            Assert.AreEqual(90, result.HighetGrade);
        }
        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeSatistics();
            Assert.AreEqual(10, result.LowestGrade);
        }
        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeSatistics();
            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
        }
    }
}
