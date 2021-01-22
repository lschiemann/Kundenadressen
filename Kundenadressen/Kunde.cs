using System.Collections.Generic;
using System.ComponentModel;

namespace Kundenadressen
{
  public class Kunde
  {
    public Kunde()
    {
      Name = string.Empty;
      Festnetz = string.Empty;
      Mobil = string.Empty;
      Email = string.Empty;
      KundenNr = string.Empty;
      Adressen = new List<Adresse>();
    }

    public string KundenNr { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Mobil { get; set; }
    public string Festnetz { get; set; }
    [Browsable(false)]
    public IList<Adresse> Adressen { get; set; }
  }
}
