namespace Kundenadressen
{
  public class Adresse
  {
    public Adresse()
    {
      Typ = string.Empty;
      Strasse = string.Empty;
      PLZ = string.Empty;
      Ort = string.Empty;
    }

    public string Typ { get; set; }
    public string Strasse { get; set; }
    public string PLZ { get; set; }
    public string Ort { get; set; }
  }
}