namespace Modul_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            (string Name, string[] Dishes) User;
            Console.WriteLine("Как вас зовут?");
            User.Name = Console.ReadLine();

            User.Dishes = new string[5];
            Console.WriteLine("Назови 5 своих любимых блюда");
            for(int i = 0; i < User.Dishes.Length; i++)
            {
                User.Dishes[i] = Console.ReadLine();
            }


            //Задание 5.1.5
            string[] favcolors = new string[3];
            Console.WriteLine("Введи три своих любимых цвета");
            for (int i = 0;i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }

            Console.WriteLine("Твои любимые цвета: ");
            int j = 0;
            foreach(var color in favcolors)
            {
                j++;
                switch(color)
                {
                    case "red":
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{j}) {color}");
                            break;

                        }
                    case "green":
                        {
                            Console.ForegroundColor= ConsoleColor.Green;
                            Console.WriteLine($"{j}) {color}");
                            break;
                        }
                    case "yellow":
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{j}) {color}");
                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine($"{j}) Неизвестный цвет"); break;
                        }


                }
            }
            Console.ForegroundColor = ConsoleColor.White;

            //Задание 5.1.6
            int [] result = new int[5];
            result = GetArrayFromConsole();
            foreach (var element in result)
            {
                Console.Write($"{element} ");
            }


            //Задание 5.2.2
            (string name, int age) anketa;

            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}", anketa.name);
            Console.WriteLine("Ваш возраст: {0}", anketa.age);
            Console.WriteLine("Введи три своих любимых цвета");
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor2(anketa.name);
            }

            //Задание 5.2.3
            (string name, int age) = ("Илья", 21);
            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
            Console.WriteLine($"{name}, Введи три своих любимых цвета");
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor2(name);
            }
        }

        static string ShowColor2(string name)
        {
            string color = Console.ReadLine();
            return color;
            //я до конца не понял, нужно ли было создать свой метод или использовать метод из курса
            //решил сделать свой
        }

        static string ShowColor()
        {
            string color = Console.ReadLine();
            return color;
            //я до конца не понял, нужно ли было создать свой метод или использовать метод из курса
            //решил сделать свой
        }

        
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            int temp;
            for (var i = 1; i < result.Length; i++)
            {
                for (var j = 0; j < result.Length - i; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            return result;


        }
    }
}
