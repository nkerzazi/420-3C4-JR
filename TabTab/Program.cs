using System;
using System.Collections.Generic;
using System.Collections;


namespace TabTab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> ma_Dictionary = new Dictionary<string, string>();

            //Ajout d'elements dans ma_dictionary
            ma_Dictionary.Add("1", "Un");
            ma_Dictionary.Add("2", "Deux");
            ma_Dictionary.Add("3", "Trois");

            Hashtable ma_HashTable = new Hashtable();

            //Ajout d'elements dans ma_Hashatable
            ma_HashTable.Add("A1", "A Un");
            ma_HashTable.Add("A2", "A Deux");
            ma_HashTable.Add("A3", "A Trois");

            //for (int i = 0; i < 10; i++)
            //{
            //   Console.WriteLine("--Ajout d un element " + i);
            //  ma_Dictionary.Add("ok" + i, "client" + i);
            // }


            // afficher les elements de ma_Hashtable
            foreach (KeyValuePair<string, string> entry in ma_Dictionary)
            {
                Console.WriteLine("la clé: - {0} et la valeur : - {1}",
                                entry.Key, entry.Value);
            }

            foreach (DictionaryEntry entry in ma_HashTable)
            {
                Console.WriteLine("la clé: - {0} et la valeur : - {1}",
                                entry.Key, entry.Value);
            }

            Console.ReadKey();

        }
    }
}
