using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project0.Abstracts;
using System.IO;
using System.Xml.Serialization;

namespace Project0.Models
{
    class RestaurantDeserializer : IDeserializable
    {
        public void DeserializeMethod()
        {
            Restaurant restaurant = new Restaurant();

            TextReader txtReader = new StreamReader(@"");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Restaurant));

            restaurant = (Restaurant)xmlSerializer.Deserialize(txtReader);

            txtReader.Close();


            
        }
    }
}
