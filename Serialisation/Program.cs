
using Serialisation;
using System.Xml;

namespace Serialisation;

internal class Program
{
     private static void Main(string[] args)
     {
          // Locals ---------------------------------------------------------------------------------------------------------------------------------
          XmlRead  i_XmlRead   = new XmlRead();
          XmlWrite i_XmlWrite  = new XmlWrite();
          XmlReadWrite i_XmlReadWrite = new XmlReadWrite();



          // Routing --------------------------------------------------------------------------------------------------------------------------------
          i_XmlRead.m_XmlRead("TP_01.xml");
          i_XmlWrite.m_XmlWrite("TP_01_WrittenByJCP.xml");
          i_XmlReadWrite.m_XmlReadWrite("TP_01.xml", "TP_01_ReadWrittenByJCP.xml");
          //i_XmlReadWrite.m_XmlReadWrite("TP_01.xml");

     }
}