using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleChecker
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] input = new double[3];
            for(int i=0;i<3;i++)
            input[i]=double.Parse(args[i]);

            Triangle t = new Triangle(input);

            if(t.isScalene()) Console.WriteLine("Triangeln har inga lika sidor"); 
            if(t.isEquilateral()) Console.WriteLine("Triangeln är liksidig"); 
            if(t.isIsosceles()) Console.WriteLine("Triangeln är likbent"); 
           
        }
    }
}
