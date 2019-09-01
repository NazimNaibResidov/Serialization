using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System;
using System.Windows.Forms;
using Seralize.Helpers;
using System.Security;

namespace Seralize.Core
{
    public class BinarSerazible
    {
        private string path;
        BinaryFormatter Formatter = default;
        FileStream stream = default;
        public BinarSerazible(string path)
        {
            this.path = path;
            Formatter = new BinaryFormatter();
           
        }
        public T DeSerialization<T>()
        {
            try
            {
                stream = Tools.Stream(path + ".dat");
                stream.Flush();
                return (T)Formatter.Deserialize(stream);
            }
            catch (ArgumentNullException ex)
            {

                MessageBox.Show(ex.Message);
                return default(T);
            }
            catch (SerializationException ex)
            {

                MessageBox.Show(ex.Message);
                return default(T);
            }


        }
        public void Serialization<T>(T entity)
        {

            try
            {
              stream = stream = Tools.Stream(path + ".dat");
              stream.Flush();
              Formatter.Serialize(stream, entity);
            }
            catch (SecurityException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SerializationException ex)
            {

               MessageBox.Show(ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
