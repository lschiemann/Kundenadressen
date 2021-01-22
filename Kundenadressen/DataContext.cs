using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Kundenadressen
{
  public class DataContext
  {
    public void Save(IEnumerable<Kunde> kunden)
    {
      using (StreamWriter file = File.CreateText(Path.Combine(Directory.GetCurrentDirectory(), "db.json")))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(file, kunden);
      }
    }

    public IList<Kunde> Load()
    {
      var filePath = Path.Combine(Directory.GetCurrentDirectory(), "db.json");
      if (!File.Exists(filePath))
      {
        return new List<Kunde>();
      }

      using (StreamReader file = File.OpenText(filePath))
      {
        List<Kunde> kunden = JsonConvert.DeserializeObject<List<Kunde>>(file.ReadToEnd());
        return kunden;
      }
    }
  }
}
