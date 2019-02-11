public static Upload Run(Stream myBlob, string name, ILogger log)
{
    log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");

    return new Upload() {
        PartitionKey = "Uploads", 
        RowKey = Guid.NewGuid().ToString(), 
        Name = name,
        Length = myBlob.Length 
    };
}

public class Upload
{
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public string Name { get; set; }
    public long Length { get; set; }
}