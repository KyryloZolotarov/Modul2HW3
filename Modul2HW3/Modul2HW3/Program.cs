namespace Modul2HW3
{
    internal class Program
    {
        public static void Main()
        {
            var salad = new SaladBuilder().CreateSomeSalat();
            foreach (var item in salad.GetSalad())
            {
                Console.WriteLine($"{item.Name.ToString()}: weight {item.Weight.ToString()} calories {item.KkallInWeight.ToString("F2")}");
            }

            Console.WriteLine();

            Array.Sort(salad.GetSalad());
            Console.WriteLine("Salad ingridients sorted by calories");
            foreach (var item in salad.GetSalad())
            {
                Console.WriteLine($"{item.Name.ToString()}: weight {item.Weight.ToString()} calories {item.KkallInWeight.ToString("F2")}");
            }

            Console.WriteLine();
            Console.WriteLine("To find product enter product name:");
            var saladname = Console.ReadLine();
            var foundedproduct = salad.FindByName(saladname);
            if (foundedproduct != null)
            {
                Console.WriteLine("product Lettuce founded");
            }
            else
            {
                Console.WriteLine("coudn't find product Lettuce");
            }
        }
    }
}