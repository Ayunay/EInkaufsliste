using System.Reflection.Metadata.Ecma335;

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
                                  "3. Meine Einkaufsliste ausgeben lassen");

            do
            {
                char userSelection = Console.ReadKey().KeyChar; // Eingabe des Benutzers

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

                    default:                                    // Ungültige Angabe
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Deine EInkabe ist ungültig, bitte wähle zwischen den oben genannten Möglichkeiten.");
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


            Shoppinglist searchItem = (Shoppinglist)System.Enum.Parse(typeof(Shoppinglist), search);
            Console.WriteLine($"{searchItem} befindet sich auf deiner Einkaufsliste.");

        }

        static void AddItem()
        {

        }

        // Ausgabe des Warenkorbs
        static void PrintList()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((Shoppinglist)i);
            }
        }

        /*
        public Shoppinglist GetItems(string item)
        {
            string[] items = Enum.GetNames(typeof(Shoppinglist));
            int[] values   = Enum.GetValues(typeof(Shoppinglist));
            int i;
            for (i = 0; i < items.Length; i++)
            {
                if (item.Equals(items[i], StringComparison.Ordinal)) break;
            }
            int value = values[i];
            return ;
        }*/
    }
}