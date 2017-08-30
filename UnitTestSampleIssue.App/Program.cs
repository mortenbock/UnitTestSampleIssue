using System;
using UnitTestSampleIssue.NewDependency;
using UnitTestSampleIssue.OldDependency;

namespace UnitTestSampleIssue.App
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Old dependency: " + Old.NewtonVersion().Major);
            Console.WriteLine("New dependency: " + New.NewtonVersion().Major);

            Console.ReadLine();
        }
    }
}
