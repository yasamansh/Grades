namespace Grades
{
    internal class GradeStatistics
    {
        public GradeStatistics()
        {
            HighetGrade = 0;
            LowestGrade = float.MaxValue;
        }
        internal float AverageGrade;
        internal float HighetGrade;
        internal float LowestGrade;
    }
}