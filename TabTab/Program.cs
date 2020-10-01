using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;


namespace TabTab
{
    struct Client
    {
        public int clientId;
        public string clientNom;
        public Client(int id, string nom)
        {
            clientId = id;
            clientNom = nom;
        }
    }
    class Program
    {
        static Hashtable ma_HashTable;
        static List<Client> ma_ListClient;
        static Stopwatch sw;

        static void Main(string[] args)
        {
            ma_HashTable = new Hashtable();
            ma_ListClient = new List<Client>();
            sw = new Stopwatch();

            // Ajout d'elements
            for (int i = 0; i < 5000000; i++)
            {
                //Console.WriteLine("Ajout d un element " + i);
                ma_HashTable.Add(i, "client" + i);
                ma_ListClient.Add(new Client(i, "Client" + i));
            }

            // supprimer un element de ma_Hashtable
            if (ma_HashTable.ContainsKey(0))
            {
                ma_HashTable.Remove(0);
            }

            // remplacer un element de la hashtable
            if (ma_HashTable.ContainsKey(1))
            {
                ma_HashTable[1] = "Une nouvelle valeur de remplacement";
            }

            Random randomClientGen = new Random();
            int randomClient = -1;
            sw.Start();
            float startTime = 0;
            float endTime = 0;
            float deltaTime = 0;

            int cycles = 5;
            int cycle = 0;
            string clientNom = string.Empty;

            while (cycle < cycles)
            {
                randomClient = randomClientGen.Next(3000000, 4000000);
                startTime = sw.ElapsedMilliseconds;
                // Access au contenu de la liste -- 
                // on a besoin d'une méthode externe pour acceder au element de la liste

                clientNom = GetClientFromList(randomClient);

                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;

                Console.WriteLine("le temps pour trouver l'element :" + clientNom + " dans la Liste prend : " + string.Format("{0:0.##}", deltaTime) + "ms");

                startTime = sw.ElapsedMilliseconds;
                // Access au contenu de la ma_HashTable
                clientNom = (string)ma_HashTable[randomClient];
                endTime = sw.ElapsedMilliseconds;
                deltaTime = endTime - startTime;
                Console.WriteLine("Le temps pour trouver un element : " + clientNom + "de ma_HashTable prend : " + string.Format("{0:0.##}", deltaTime) + "ms");

                cycle++;
            }
            Console.ReadKey();
        }
        static string GetClientFromList(int clientId)
        {
            for (int i = 0; i < ma_ListClient.Count; i++)
            {
                if (ma_ListClient[i].clientId == clientId)
                {
                    return ma_ListClient[i].clientNom;
                }
            }
            return string.Empty;
        }

    }
}
