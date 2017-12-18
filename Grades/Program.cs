using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Hello Yasaman This is the grade book program");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stat = book.ComputeSatistics();

            Console.WriteLine("The Average is: "+ stat.AverageGrade);
            Console.WriteLine("The Highest value is: "+ stat.HighetGrade);
            Console.WriteLine("The Lowest value is: "+ stat.LowestGrade);

            Console.ReadLine();
        }
    }
}
