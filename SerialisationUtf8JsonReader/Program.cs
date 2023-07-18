
using System.Text.Json;
using System.Xml;

using SerialisationUtf8Json;


internal class Program
{
     private static void Main(string[] args)
     {
          // Locals -------------------------------------------------------------------------------------------------------------------------------------------
          SerialisationUtf8JsonReader is_Utf8JsonReader = new SerialisationUtf8JsonReader();
          SerialisationUtf8JsonWriter is_Utf8JsonWriter = new SerialisationUtf8JsonWriter();



          // Routing ------------------------------------------------------------------------------------------------------------------------------------------
          is_Utf8JsonReader.m_Utf8JsonReader();
          Console.WriteLine();
          Console.WriteLine();
          is_Utf8JsonWriter.m_Utf8JsonWritter();
     }
}