using System;

namespace TamagochiOnSharp
{
    class Program
    {
        static void PrintInformation(Tamagochi pet)
        {
            Console.Clear();

            Console.Write("\nЗдоровье:  ");

            for (int i = 0; i < 10; i++)
                if (i < pet.health) Console.Write("☼");
                else Console.Write("_");

            Console.Write("\nГолод:     ");

            for (int i = 0; i < 10; i++)
                if (i < pet.hunger) Console.Write("*");
                else Console.Write("_");

            Console.Write("\nУсталость: ");

            for (int i = 0; i < 10; i++)
                if (i < pet.fatigue) Console.Write("¤");
                else Console.Write("_");

            Console.WriteLine();

            if (pet.health <= 0) Console.WriteLine("\nУвы! Ваш питомец заболел.\n");
            else
            {
                Console.WriteLine("\nДоступные действия:");
                Console.Write("\t1) Покормить питомца;\n" +
                              "\t2) Поиграть с питомцем;\n" +
                              "\t3) Уложить питомца спать.\n");
                Console.Write("\nВыберите действие: ");
            
            }
        }
        static void Main(string[] args)
        {
            Tamagochi pet = new();

            char c;

            do
            {
                PrintInformation(pet);
                if (pet.health <= 0) break;
                do
                {
                    c = Console.ReadKey().KeyChar;
                } while (c - 48 > 3 || c - 48 < 1);

                switch (c-48)
                {
                    case 1:
                        pet.Feed();
                        break;
                    case 2:
                        pet.Play();
                        break;
                    case 3:
                        pet.Sleep();
                        break;
                }

            } while (true);
            
        }
    }
}
