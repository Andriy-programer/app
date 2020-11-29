using System;

namespace app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть вагу");
            string veigh = Console.ReadLine();
            int veight = Convert.ToInt32(veigh);
           
            Console.WriteLine("Введiть зріст");
            string heigh = Console.ReadLine();
            double height = Convert.ToInt32(heigh);
            if (height > 3) {
                height = height / 100;
            }
            double height_kv = height * height;
            double IMT = veight /height_kv;
                  

            Console.WriteLine("Ваш ІМТ:"+IMT);
        }
    }
}
