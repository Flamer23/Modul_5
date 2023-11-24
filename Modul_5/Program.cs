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

        }
        static string ShowColor()
        {
            string color = Console.ReadLine();
            return color;
            //я до конца не понял, нужно ли было создать свой метод или использовать метод из курса
            //решил сделать свой
        }
    }
}
