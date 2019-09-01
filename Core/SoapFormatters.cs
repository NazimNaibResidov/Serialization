using System;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;
using Seralize.Helpers;

namespace Seralize.Core
{
    public class SoapFormatters
    {
        private FileStream stream = default;
        private SoapFormatter formatter = default;
        private string path;
        public SoapFormatters(string path)
        {
            this.path = path;
        }
        public T DeSerialization<T>()
        {
            try
            {
                stream = Tools.Stream(path + ".soap");
                formatter = new SoapFormatter();
                stream.Flush();
                return (T)formatter.Deserialize(stream);
            }
            catch (ArgumentNullException ex)
            {

                MessageBox.Show(ex.Message);
                return default(T);
            }
          
        }
        public void Serialization<T>(T entity)
        {
            try
            {
                stream = Tools.Stream(path + ".soap");
                formatter = new SoapFormatter();
                stream.Flush();
                formatter.Serialize(stream, entity);
            }
            catch (ArgumentNullException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (SerializationException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
