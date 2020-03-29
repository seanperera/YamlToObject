using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YamlToObject.Entities;

namespace YamlToObject
{
    public static class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Starting to DeserializeAsync YAML!");

            Console.WriteLine("DeserializeAsync AadUsers!");
            Console.WriteLine();

            Console.WriteLine();
            var aadUsers = await YamlConverter.DeserializeAsync<IList<AadUser>>(@"./Data/AadUser.yaml");
            var aadOutput = JsonConvert.SerializeObject(aadUsers, Formatting.Indented);

            Console.WriteLine(aadOutput);
            Console.WriteLine();

            Console.WriteLine("DeserializeAsync Physicians!");
            Console.WriteLine();
            var physicians = YamlConverter.Deserialize<IList<Physician>>(@"./Data/Referrer.yaml");
            var physicianOutput = JsonConvert.SerializeObject(physicians, Formatting.Indented);
            
            Console.WriteLine(physicianOutput);

        }
    }
}
