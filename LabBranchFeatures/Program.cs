using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBranchFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            IDMLManager manager = new IDMLManager();
            Console.WriteLine("'feature 1' implemented, phase A");
            Console.WriteLine("'feature 1' implemented, phase B");
            Console.WriteLine("Added in 'develop' branch");
            Console.WriteLine("LabBranchFeatures");
            Console.ReadKey();
        }
    }
}