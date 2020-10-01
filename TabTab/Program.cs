using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabTab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creation d'un tableau multi-dimentionel
            string[] tabEtudiants = new string[3];
            tabEtudiants[0] = "Maximo";
            tabEtudiants[1] = "Jonathan";
            tabEtudiants[2] = "Boby";


            string[][] TabTabArray = new string[3][];

            TabTabArray[0] = new string[3];
            TabTabArray[1] = new string[1];
            TabTabArray[2] = new string[2];

            TabTabArray[0][0] = "Technique Cegep";
            TabTabArray[0][1] = "Baccalaureat";
            TabTabArray[0][2] = "Maitrise";

            TabTabArray[1][0] = "Technique Cegep";

            TabTabArray[2][0] = "Technique Cegep";
            TabTabArray[2][1] = "Baccalaureat";

            for (int i=0; i<TabTabArray.Length; i++)
            {
                string[] tabinternArray = TabTabArray[i];
                Console.WriteLine(tabEtudiants[i]);
                Console.WriteLine("---------------");
                for (int j = 0; j < tabinternArray.Length; j++)
                {
                    Console.WriteLine(tabinternArray[j]);
                }
                Console.WriteLine("****");
            }
            Console.ReadKey();

        }
    }
}
