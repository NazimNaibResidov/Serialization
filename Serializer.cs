using Seralize.Core;


namespace Seralize
{
   public static class Serializer
    {
/// <summary>
        /// This is for Xml Seralization only need file name
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="path"></param>

public static void XmlSerialization(this object obj,string path)
        {
            XmlSerialization xml = new XmlSerialization(path);
            xml.Serialization(obj);
        }

/// <summary>
        /// This is Xml DeSerialization only need fileName
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>
public static T XmlDeSerialization<T>(string path)
        {
            XmlSerialization xml = new XmlSerialization(path);
          return (T)  xml.DeSerialization<T>();
        }
        /// <summary>
        /// This is Soap Serialization for File seralize only need object and name
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="path"></param>
public static void SoapSerialization(this object obj, string path)
        {
            SoapFormatters formatters=new SoapFormatters(path);
            formatters.Serialization(obj);

        }

 /// <summary>
        /// this is Soap DeSerialization only need name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>

public static T SoapDeSerialization<T>(string path)
        {
            SoapFormatters formatters = new SoapFormatters(path);
           return (T) formatters.DeSerialization<T>();
        }
        /// <summary>
        /// This is Binary Formatter Seralize need object and file name
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="path"></param>

public static void BinarySerialization(this object obj, string path)
        {
            BinarSerazible serazible = new BinarSerazible(path);
            serazible.Serialization(obj);
           
        }
        /// <summary>
        /// this is Binary Formatter DeSerialization only need file Name
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path"></param>
        /// <returns></returns>

public static T BinarySerialization<T>(string path)
        {
            BinarSerazible serazible = new BinarSerazible(path);
           return (T)serazible.DeSerialization<T>();
        }

    }
}
