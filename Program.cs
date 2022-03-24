using System;
using System.IO;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace DefeatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            DocInput document = new DocInput();
            Console.WriteLine(document.GetDocument());

            Console.WriteLine("end");
        }
    }
}
