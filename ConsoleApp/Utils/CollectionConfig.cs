using System.Text;
using ConsoleApp.Models;

namespace ConsoleApp.Utils;

public class CollectionConfig
{
    public static string ToStringCollection(ICollection<Corporation> corporations){
        var itemList = new HashSet<Corporation>();
        var builder = new StringBuilder();

        foreach (var item in corporations!)
            itemList.Add(item);
        
        foreach(var item in itemList)
            builder.AppendLine(item.ToString());
        
        return builder
            .ToString();
    }
}