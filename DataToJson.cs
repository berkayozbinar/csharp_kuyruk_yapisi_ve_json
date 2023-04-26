using System;
using System.IO;
using Newtonsoft.Json;

namespace veriproje
{
    class DataToJson
    {
        public static void ToJson(Queue obj)
        {
            string json =  "[\n";
            int counter = 0;

            foreach(var item in obj.arr)
            {
                if(counter < obj.arr.Length - 1)
                json += JsonConvert.SerializeObject(item, Formatting.Indented) + ",";
                else
                json += JsonConvert.SerializeObject(item, Formatting.Indented) + "\n]";

                counter++;
            }

            File.WriteAllText(Environment.CurrentDirectory + @"\data.json", json);
        }
    }
}
