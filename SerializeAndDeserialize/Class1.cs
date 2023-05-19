using Newtonsoft.Json;

namespace SerializeAndDeserialize
{
    public class Class1
    {
        public static void SerializeData<T>(T data, string filePath)
        {
            string jsonString = JsonConvert.SerializeObject(data);
            File.WriteAllText(filePath, jsonString);
        }

        public static T DeserializeData<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}