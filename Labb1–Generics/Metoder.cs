using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Generics
{
    public class Metoder
    {
        public static void ProgramStart()
        {
            //1. Skapa ett objekt av LådaCollection och lägga till 5 objekt i Collection
            ColourWriteLine("------------\r\nCreate an object of LådaCollection and add 5 objects to Collection------------");
            LådaCollection boxCollection = CreateBoxes();



            //2. Lägga till ett objekt med samma höjd, längd, bredd (exempel : 10,10,10) för att testa om vi kan lägga till två lådar med samma dimension.
            ColourWriteLine("\n------------Adding an object with the same height, length, width------------");
            boxCollection.Add(new Låda(10, 10, 10));



            //3. Testa Remove metod och sen visa listan efter du tagit bort ett objekt
            ColourWriteLine("\n------------\r\nTest the Remove method and then display the list after you have removed an item------------");
            Display(boxCollection);
            Console.WriteLine();
            boxCollection.Remove(new Låda(10, 10, 10));

            Display(boxCollection);



            //4. Kolla om vår Collection contains en specifikt objekt
            ColourWriteLine("\n------------Check if our Collection contains a specific object------------");
            Console.WriteLine("");

            Låda lådaCheck = new Låda(50, 50, 50);
            Console.WriteLine($"There is a box with the demension: Height: {lådaCheck.höjd} Length: {lådaCheck.längd} Width: {lådaCheck.bredd} = {boxCollection.Contains(lådaCheck)}");


            //5. Dispaly metod ska loopa genom alla objekt som finns i Collection och skriva ut dem
            // Dimisionerna 10 har tagits bort så det finns inte med när vi loopar igenom listan denna gången.
            ColourWriteLine("\n------------Dispaly method to loop through all objects in the collection------------");
            Display(boxCollection);


            Console.ReadLine();
        }
        public static LådaCollection CreateBoxes()
        {
            LådaCollection Boxes = new LådaCollection()
            {
              new Låda(10, 10, 10),
              new Låda(20, 20, 20),
              new Låda(30, 30, 30),
              new Låda(40, 40, 40),
              new Låda(50, 50, 50)
              
            };
            return Boxes;
        }
        public static void Display(LådaCollection lådaLista)
        {

            Console.WriteLine("\nHeight\tLength\tWidth\tHash Code");
            foreach (var item in lådaLista)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
               item.höjd.ToString(), item.längd.ToString(),
               item.bredd.ToString(), item.GetHashCode().ToString());
            }
        }
        public static void ColourWriteLine(string text = "")
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

    }
}

