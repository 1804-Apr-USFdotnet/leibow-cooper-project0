using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Project0.Abstracts;
using Project0.Models;
using System.Xml.Serialization;

namespace Project0.Project0.Library.Models
{
    class ReviewDeserializer : IDeserializable
    {
        public void DeserializeMethod()
        {
            Review review = new Review();

            TextReader txtReader = new StreamReader(@"");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Review));

            review = (Review)xmlSerializer.Deserialize(txtReader);

            txtReader.Close();



        }
    }
}
