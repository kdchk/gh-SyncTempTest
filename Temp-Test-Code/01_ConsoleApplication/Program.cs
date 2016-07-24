using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            Console.WriteLine(worker.ConcatenatePublicStrings());

            worker.FieldPublicText = "All your base are belong to us!";
            Console.WriteLine($"worker.FieldPublicText = {worker.FieldPublicText}");
            Console.WriteLine(worker.ConcatenatePublicStrings());

            Console.WriteLine("--------");

            Console.WriteLine(worker.ConcatenatePrivateStrings());

            
            Console.WriteLine($"worker.FieldPrivateText is {worker.FieldPrivateText}");



            //---------------
            Console.ReadKey();
        }
    }

    class Worker
    {
        public string FieldPublicText = "class _Worker, field _public string _FieldPublicText";
        private string fieldPrivateText = "class _Worker, field _PRIVATE string _fieldPrivateText";

        public string FieldPrivateText { get { return fieldPrivateText; } }

        public string ConcatenatePublicStrings()
        {
            string concatString = " +++ method _ConcatenatePublicStrings";
            string answer = FieldPublicText + concatString;
            return answer;
        }

        public string ConcatenatePrivateStrings()
        {
            string concatString = " +++ method _ConcatenatePrivateStrings";
            string answer = fieldPrivateText + concatString;
            return answer;
        }
    }
}
