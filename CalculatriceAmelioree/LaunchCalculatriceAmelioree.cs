
using CalculatriceAmelioree.DTOs;

namespace CalculatriceAmelioree
{
    internal static class LaunchCalculatriceAmelioree
     {
          // Fields ---------------------------------------------------------------------------------------------------------------------------------
          static string?      operand1      = "";
          static string?      operand2      = "";
          static string?      operateur     = "";

          static int?         result;





          // Properties -----------------------------------------------------------------------------------------------------------------------------



          // Constructors ---------------------------------------------------------------------------------------------------------------------------
          //internal void LaunchCalculatriceAmelioree();



          // Methods --------------------------------------------------------------------------------------------------------------------------------
          internal static void m_CalculatriceAmelioree()
          {

               // Locals ----------------------------------------------------------------------------------------------------------------------------
               Calculatrice calc = new Calculatrice();





               // Treatment -------------------------------------------------------------------------------------------------------------------------
               // Obtention des deux opérandes et de l'opérateur
               while (true)
               {
                    if (operand1 is not null)
                    {
                         Console.Write("Veuillez sasir le premier opérande ou appuyer sur 'M' pour utiliser le résultat de l'opération précédente : ");
                    }
                    else
                    {
                         Console.Write("Veuillez sasir le premier opérande : ");
                    }
                    operand1 = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(operand1) && operand1.Equals( "M", StringComparison.OrdinalIgnoreCase))
                    {
                         operand1 = result.ToString();
                    }


                    Console.Write("Veuillez sasir le second opérande : ");
                    operand2 = Console.ReadLine();


                    Console.Write("Veuillez sasir l'opérateur : ");
                    operateur = Console.ReadLine();



                    calc.FirstOperand = int.Parse(operand1);
                    calc.SecondOperand = int.Parse(operand2);



                    // Mémorisation du résultat
                    switch (operateur)
                    {
                         case "+":
                              result = calc.FirstOperand + calc.SecondOperand;
                              break;
                         case "-":
                              result = calc.FirstOperand - calc.SecondOperand;
                              break;
                         case "*":
                              result = calc.FirstOperand * calc.SecondOperand;
                              break;
                         case "/":
                              result = calc.FirstOperand / calc.SecondOperand;
                              break;
                         case "%":
                              result = calc.FirstOperand % calc.SecondOperand;
                              break;


                         default:
                              Console.WriteLine("L'opérateur est invalide.");
                              break;
                    }





                    // Affichage du résultat
                    Console.WriteLine($"{calc.FirstOperand} {operateur} {calc.SecondOperand} = {result}");





                    // Ecriture de l'ensemble de l'opération dans le fichier
                    System.IO.File.WriteAllText("MonFichier.txt", $"{calc.FirstOperand} {operateur} {calc.SecondOperand} = {result}");

                    if (File.Exists("MonFichier.txt"))
                    {
                         // Lire le contenu
                         var contenu = System.IO.File.ReadAllText("MonFichier.txt");
                         Console.WriteLine(contenu);
                    }


               }
          }
     }

}
