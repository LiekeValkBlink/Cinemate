using System.ComponentModel;

namespace Cinemate.Models.Enum;

public enum Kijkwijzer
{
    [Description("Alle leeftijden")]
    AlleLeeftijden,
    
    [Description("6 jaar")]
    ZesJaar,
    
    [Description("9 jaar")]
    NegenJaar,
    
    [Description("12 jaar")]
    TwaalfJaar,
    
    [Description("14 jaar")]
    VeertienJaar,
    
    [Description("16 jaar")]
    ZestienJaar,
    
    [Description("18 jaar")]
    AchttienJaar,
    
    [Description("Geweld")]
    Geweld,
    
    [Description("Angst")]
    Angst,
    
    [Description("Grof taalgebruik")]
    GrofTaalgebruik,
    
    [Description("Discriminatie")]
    Discriminatie,
    
    [Description("Drugs- en/of alcoholgebruik")]
    DrugsEnAlcoholgebruik,
    
    [Description("Gokken")]
    Gokken,
    
    [Description("Seks")]
    Seks,
    
    [Description("Geweld Seks")]
    GeweldSeks,
    
    [Description("Grof Geweld")]
    GrofGeweld,
    
    [Description("Dood")]
    Dood,
    
    [Description("Zelfdoding")]
    Zelfdoding,
    
    [Description("Verslaving")]
    Verslaving
}

public static class KijkwijzerHelper
{
    public static List<string> GetAllDescriptions()
    {
        var values = System.Enum.GetValues(typeof(Kijkwijzer)).Cast<Kijkwijzer>();
        var descriptions = new List<string>();

        foreach (var value in values)
        {
            descriptions.Add(GetDescription(value));
        }

        return descriptions;
    }

    public static string GetDescription(Kijkwijzer value)
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
        return attributes.Length > 0 ? attributes[0].Description : value.ToString();
    }
}