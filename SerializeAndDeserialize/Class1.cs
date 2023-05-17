using System.Text.Json;

namespace SerializeAndDeserialize
{
    public class Class1
    {
        public static void SerializeData<T>(T data, string filePath)
        {
            string jsonString = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, jsonString);
        }

        public static T DeserializeData<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}