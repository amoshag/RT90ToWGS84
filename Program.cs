using MightyLittleGeodesy.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace RT90ToWGS84
{
    class Program
    {
        static void Main(string[] args)
        {
            var coordinates = new List<string>();

            foreach (string line in File.ReadAllLines("input.csv"))
            {
                string[] tokens = line.Split(',');
                double x = double.Parse(tokens[0]);
                double y = double.Parse(tokens[1]);
                RT90Position position = new RT90Position(x, y);
                WGS84Position wgsPos = position.ToWGS84();
                coordinates.Add(string.Format("{0},{1}", wgsPos.Longitude, wgsPos.Latitude));
            }

            File.WriteAllLines("output.csv", coordinates);
        }
    }
}
