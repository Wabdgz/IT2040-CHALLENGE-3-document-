using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Documentproject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Document\n");
            Console.WriteLine("What is the name of the document?");
            string name = Console.ReadLine();
            Console.WriteLine("What is the context of your document?");
            string context = Console.ReadLine();


            try
            {
                StreamWriter sw = new StreamWriter("name.txt");
                sw.WriteLine(name + "" + context);
                sw.Close();

            }

            catch (Exception e)
            {
                Console.WriteLine("Exception" + e.Message);
            }
            finally
            {
                Console.WriteLine("Execeuting the final block of coding");
            }
            Console.ReadKey();
        }
    }
}
