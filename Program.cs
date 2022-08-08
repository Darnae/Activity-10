//use for IC08
//Lydia's code
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Corrected By Darnae Simmons

namespace CST117_IC08_console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set A and B cannot be Found by the class. There is no data or proper reference.

           //Set A = new Set();
           //Set B = new Set();

            Program A = new Program();  
            Program B = new Program();


            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                // No definition is given and an accessible extention method is not provided
                // A.addElement(r.Next(4));
                // B.addElement(r.Next(12));

                A.addElement(r.Next(4));
                B.addElement(r.Next(12));

                // changes made to lines 60-63
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);

               // union does not have a definition

              //Console.WriteLine("A union B: " + A.union(B));

            Console.WriteLine("A union B: " + A.union(B));

            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);


        }

        private string union(Program b)
        {
            throw new NotImplementedException();
        }

        private void addElement(int v)
        {
            throw new NotImplementedException();
        }
    }
}
