using System.IO;
using System.Text;
using YamlDotNet.Serialization;
using System.Threading.Tasks;

namespace YamlToObject
{
    public static class YamlConverter
    {
        public static async Task<T> DeserializeAsync<T>(string fileName)
            where T : class
        {            
            char[] buffer;
            
            using (var sr = new StreamReader(fileName))
            {
                buffer = new char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
            }

            var deserializer = new DeserializerBuilder()
                .Build();

            var yaml = new string(buffer);
            var input = new StringReader(yaml);

            var result = deserializer.Deserialize<T>(input);

            return result;
        }

        public static T  Deserialize<T>(string fileName)
            where T : class
        {
            var sr = new StreamReader(fileName);
            var yaml = sr.ReadToEnd();

            var deserializer = new DeserializerBuilder()
                .Build();

            var input = new StringReader(yaml);
            var result = deserializer.Deserialize<T>(input);


            return result;
        }
    }
}