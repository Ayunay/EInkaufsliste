using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace Einkaufsliste
{
    internal class Program
    {
        static void Main()
        {
            bool validUserSelection = false;

            Console.WriteLine("Was möchtest du tun?\n" +
                                  "1. Item zur Einkaufsliste hinzufügen \n" +
                                  "2. Nach einem Item auf der Einkaufsliste suchen \n" +
                                  "3. Meine Einkaufsliste ausgeben lassen \n" +
                                  "4. Lass den Gesamtpreis des Einkaufes ausgeben");

            do
            {
                char userSelection = Console.ReadKey().KeyChar; // Eingabe des Benutzers
                Console.WriteLine();

                switch (userSelection)
                {
                    case '1':                                   // Auswahl: 1
                        AddItem();
                        validUserSelection = true;
                        break;

                    case '2':                                   // Auswahl: 2
                        SearchForItem();
                        validUserSelection = true;
                        break;

                    case '3':                                   // Auswahl: 3
                        PrintList();
                        validUserSelection = true;
                        break;

                    case '4':                                   // Auswahl: 4
                        TotalPrice();
                        validUserSelection = true;
                        break;

                    default:                                    // Ungültige Angabe
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Deine Eingabe ist ungültig, bitte wähle zwischen den oben genannten Möglichkeiten.");
                        Console.ResetColor();
                        validUserSelection = false;
                        break;
                }
            }
            while (validUserSelection == false);

            /*
            Console.WriteLine("Bitte gebe eine Sache ein, die du auf deine Einkaufsliste schreiben möchtest.");
            string item = Console.ReadLine();
            Console.WriteLine($"Zur Liste hinzugefügt wird: {item} \n");
            */

            Console.ReadKey();
            Console.Clear();
            Main();
        }

        public enum Shoppinglist
        {
            Wasser,
            Tee,
            Apfel,
            Honig,
            Cola,
            Käse,
            Pudding,
            Joghurt,
            Salat,
            Tomaten,
        }

        // Suche nach einem Item auf der Liste
        static void SearchForItem()
        {

            Console.WriteLine("Nach welchem Item möchtest du suchen?");
            string search = Console.ReadLine();

            string itemOnList = "";

            for (int i = 0; i < 10; i++)
            {
                itemOnList = Enum.GetName(typeof(Shoppinglist), i);

                if (itemOnList == search)   // Item ist auf der Liste
                {
                    Console.WriteLine($"{search} befindet sich auf deiner Einkaufsliste.");
                    break;
                }
            }

            if (itemOnList != search)
            {
                Console.WriteLine($"{search} ist nicht auf deiner Einkaufsliste.");
            }

        }

        static void AddItem()
        {
            // Shoppinglist.Add("Wasser");
        }

        // Ausgabe des Warenkorbs
        static void PrintList()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((Shoppinglist)i);
            }
        }

        // Der Gesamtpreis des Einkaufs wird ausgegeben
        static void TotalPrice()
        {
            Random random = new Random();
            double[] prices = new double[10];
            double gesPrice = 0;

            for (int i = 0; i < 10; i++)
            {
                double singlePrice = random.NextDouble();   // DOuble nur zwischen 0.0 und 1.0
                //round(singlePrice, 2);

                prices[i] = singlePrice;
                Console.WriteLine(prices[i]);

                gesPrice += singlePrice;
            }

            Console.WriteLine($"Der Gesamtpreis beträgt {gesPrice}");
        }

    }
}