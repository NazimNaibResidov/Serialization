using Seralize.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Seralize.Core
{
   public class XmlSerialization
    {
        private FileStream stream = default;
        private XmlSerializer serializer = default;
        private string path;
        public XmlSerialization(string path)
        {
            this.path = path;

        }
        public T DeSerialization<T>()
        {
            try
            {
               
                stream=  Tools.Stream(path + ".xml");
                TextReader reader = new StreamReader(stream);
                serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
            catch (InvalidOperationException ex)
            {
                
               MessageBox.Show(ex.Message);
                return default(T);
            }
           
        }
        public void Serialization<T>(T entity)
        {
            try
            {
                stream = Tools.Stream(path + ".xml");
                serializer = new XmlSerializer(entity.GetType());
                stream.Flush();
                serializer.Serialize(stream, entity);
            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
