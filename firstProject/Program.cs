using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> autok = new List<string>();
            StreamReader olvas = new StreamReader("auto.csv");
            while (!olvas.EndOfStream)
            {
                autok.Add(olvas.ReadLine());
            }
            for (int i = 0; i < autok.Count; i++)
            {
                Console.WriteLine(autok[i]);
            }

            Console.ReadLine();
        }
    }
}
