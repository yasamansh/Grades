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
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello Yasaman This is the grade book program");

            GradeBook book = new GradeBook();
            book.NameChanged += new NameChangedDelegate(OnNameChanged);
            book.NameChanged += new NameChangedDelegate(OnNameChanged2);

            book.Name = "Yasaman's Grade Book";
            book.Name = "Yasi's book";

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stat = book.ComputeSatistics();

            Console.WriteLine(book.Name);

            WriteResult("Average" , stat.AverageGrade);
            WriteResult("Highest Grade" , (int)stat.HighetGrade);
            WriteResult("Lowest Grade" , stat.LowestGrade);

            Console.ReadLine();
        }
        
        static void WriteResult(string description, int result)
        {
            Console.WriteLine($"{description}: {result}");
        }

        static void WriteResult(string description, params float[] result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result[0]);
        }

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Grade book changing name from {existingName} to {newName}");
        }

        static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine($"***");
        }
    }
}
