using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        const string FILENAME = @"e:\test1.xml";
        Current current = null;
        public Form1()
        {
            InitializeComponent();

            current = new Current()
            {
                city = new City()
                {
                    name = "London",
                    id = 2643743,
                    coord = new Coord() { lat = 51.51, lon = -0.13 },
                    country = "GB",
                    sun = new Sun() { set = DateTime.Parse("2015-02-09T17:04:38"), rise = DateTime.Parse("2015-02-09T07:24:47") }
                },
                temperature = new Temperature() { value = 275.75, unit = "kelvin", max = 275.75, min = 275.75 }

            };

            XmlSerializer serializer = new XmlSerializer(typeof(Current));

            StreamWriter writer = new StreamWriter(FILENAME);
            serializer.Serialize(writer, current);
            writer.Flush();
            writer.Close();
            writer.Dispose();

            XmlSerializer xs = new XmlSerializer(typeof(Current));
            XmlTextReader reader = new XmlTextReader(FILENAME);
            Current readCurrent = (Current)xs.Deserialize(reader);

        }
    }
    [Serializable, XmlRoot("Current")]
    public class Current
    {
        public City city { get; set; }
        public Temperature temperature { get; set; }

    }
    [XmlRoot(ElementName = "city")]
    public class City
    {
        [XmlAttribute("name")]
        public string name { get; set; }
        [XmlAttribute("id")]
        public int id { get; set; }
        public Coord coord { get; set; }
        public string country { get; set; }
        public Sun sun { get; set; }
    }
    [XmlRoot(ElementName = "coor")]
    public class Coord
    {
        [XmlAttribute("lat")]
        public double lat { get; set; }
        [XmlAttribute("lon")]
        public double lon { get; set; }
    }
    [XmlRoot(ElementName = "sun")]
    public class Sun
    {
        [XmlAttribute("set")]
        public DateTime set { get; set; }
        [XmlAttribute("rise")]
        public DateTime rise { get; set; }
    }
    [XmlRoot(ElementName = "temperature")]
    public class Temperature
    {
        [XmlAttribute("value")]
        public double value { get; set; }
        [XmlAttribute("unit")]
        public string unit { get; set; }
        [XmlAttribute("max")]
        public double max { get; set; }
        [XmlAttribute("min")]
        public double min { get; set; }
    }
}