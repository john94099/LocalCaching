using LocalCaching;
class Program
{
    static void Main(string[] args)
    {
        var program = new Program();

        Console.WriteLine("Saving random data in cache");
        program.SaveBigData();
        Console.WriteLine("Reading data from cache");
        program.ReadData();

        //Console.WriteLine("remove data from cache");
        //program.RemoveAllData();
        Console.ReadLine();
    }

    private void RemoveAllData()
    {
        var cache = RedisConnectorHelper.Connection.GetDatabase(15);
        var devicesCount = 10;
        for (int i = 0; i < devicesCount; i++)
        {
            var value = cache.KeyDelete($"Device_Status:{i}");
            Console.WriteLine($"Valor={value}");
        }
    }

    public void ReadData()
    {
        var cache = RedisConnectorHelper.Connection.GetDatabase(15);
        var devicesCount = 10;
        for (int i = 0; i < devicesCount; i++)
        {
            var value = cache.StringGet($"Device_Status:{i}");
            Console.WriteLine($"Valor={value}");
        }
    }

    public void SaveBigData()
    {
        var devicesCount = 10;
        var rnd = new Random();
        var cache = RedisConnectorHelper.Connection.GetDatabase(15);
        for (int i = 1; i < devicesCount; i++)
        {
            var value = rnd.Next(0, 10);
            cache.StringSet($"Device_Status:{i}", value);
        }
    }
}