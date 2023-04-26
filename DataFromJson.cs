using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace veriproje
{
    class DataFromJson
    {
        public static void FromJson()
        {
            StreamReader reader = new StreamReader(Environment.CurrentDirectory + @"\data.json");
            string json = reader.ReadToEnd();

            List<Poetrist> poetrist = JsonConvert.DeserializeObject<List<Poetrist>>(json);

            string x = "___________________________________________________________________________________";

            for (int i = 0; i < poetrist.Count; i++)
            {
                Console.WriteLine(x + "\n");
                Console.WriteLine("Yazar => " + poetrist[i].Name + " " + poetrist[i].Surname);
                Console.WriteLine("Yazarın milleti => " + poetrist[i].Nationality);

                for (int j = 0; j < poetrist[i].Poetry.Count; j++)
                { 
                    Console.WriteLine("Şiirinin ismi => " + poetrist[i].Poetry[j].Name);
                    Console.WriteLine("Şiirin kıta ve satır sayısı => " + poetrist[i].Poetry[j].NumberOfStanza + ", " + poetrist[i].Poetry[j].NumberOfVerse);
                }
            }

            Console.WriteLine(x + "\n");  

            reader.Close();

            Console.ReadKey();
        }
    }
}
