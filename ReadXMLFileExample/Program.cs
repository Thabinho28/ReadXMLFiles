using System;
using System.Xml;
using System.Text;

namespace ReadXMLFileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\WorkSpace\\Programming\\SOV\\AirfcraftBasicFlight_v2\\2020429_181747.xml";
            XmlReader xmlReader = XmlReader.Create(fileName);
            while(xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "GeoLocation"))
                {
                    Console.WriteLine($"{Convert.ToDouble(xmlReader.GetAttribute("Latitude"))} | " +
                        $"{Convert.ToDouble(xmlReader.GetAttribute("Longitude"))}  | " +
                        $"{Convert.ToDateTime(xmlReader.GetAttribute("Time"))}");
                }
                
            }
        }
    }
}
