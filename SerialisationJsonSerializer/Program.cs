
namespace SerialisationJsonSerializer;

internal class Program
{
     private static void Main(string[] args)
     {
          // Local variabless -----------------------------------------------------------------------------------------------------------------------
          LaunchSerialisation ls        = new LaunchSerialisation();



          // Routing --------------------------------------------------------------------------------------------------------------------------------
          //ls.m_Serialisation();
          LaunchDeserialization.m_DeSerialisation("TP_03.txt");
     }
}

