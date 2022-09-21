using System.Reflection.Metadata.Ecma335;

namespace Einkaufsliste
{
    internal class Program
    {
        static void Main()
        {
            /*
            Console.WriteLine("Bitte gebe eine Sache ein, die du auf deine Einkaufsliste schreiben möchtest.");
            string item = Console.ReadLine();
            Console.WriteLine($"Zur Liste hinzugefügt wird: {item} \n");
            */

            // Suche nach einem Item auf der Liste
            Console.WriteLine("Nach welchem Item möchtest du suchen?");
            string search = Console.ReadLine();

            Shoppinglist searchItem = (Shoppinglist)System.Enum.Parse(typeof(Shoppinglist), search);
            Console.WriteLine($"{searchItem} befindet sich auf deiner Einkaufsliste.");

            /*
            for (int i = 0; i < 11; i++)
            {
                if ((Shoppinglist)i == search)
                {

                }
            }*/

            
            // Ausgabe des Warenkorbs
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine((Shoppinglist)i);
            }
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