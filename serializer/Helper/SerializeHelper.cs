using Newtonsoft.Json;
using serializer.Model;

namespace serializer.Helper;

public class SerializeHelper
{
    private string currentPath;
    public SerializeHelper()
    {
        currentPath = Directory.GetCurrentDirectory();
    }

    public List<designItem> getStoredData()
    {
        try
        {
            string fileData = File.ReadAllText(this.currentPath + "/database/data.json");
            List<designItem> storedInfo = JsonConvert.DeserializeObject<List<designItem>>(fileData);
            return storedInfo;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception occrredd", ex);
            return new List<designItem>();
        }
    }

    public bool StoreData(List<designItem> data)
    {
        try
        {
            string serializedData = JsonConvert.SerializeObject(data);
            File.WriteAllText(currentPath + "/database/data.json", serializedData);
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception occrredd", ex);
            return true;
        }
    }
    
    
}