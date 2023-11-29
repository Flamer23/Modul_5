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
            for (int i = 0; i < User.Dishes.Length; i++)
            {
                User.Dishes[i] = Console.ReadLine();
            }


            //Задание 5.1.5
            string[] favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }
            Console.ForegroundColor = ConsoleColor.White;

            //Задание 5.1.6
            int[] result = new int[5];
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
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor2(name);
            }

            //Задание 5.2.7
            Console.Write("Введите имя: ");
            anketa.name = Console.ReadLine();
            Console.Write("Введите возраст с цифрами: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ваше имя: {0}", name);
            Console.WriteLine("Ваш возраст: {0}", age);
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor3(name, age);
            }

            //Задание 5.2.8
            result = GetArrayFromConsole();
            result = SortArray(result);
            foreach (var element in result)
            {
                Console.Write($"{element} ");
            }

            //Задание 5.2.14
            int num = 5;
            result = GetArrayFromConsole2(ref num);
            result = SortArray(result);
            foreach (var element in result)
            {
                Console.Write($"{element} ");
            }

            //Задание 5.2.15
            result = GetArrayFromConsole2(ref num);
            result = SortArray(result);
            foreach (var element in result)
            {
                Console.Write($"{element} ");
            }

            //Задание 5.2.17
            result = GetArrayFromConsole();
            ShowArray(result);

            //Задание 5.2.18
            result = GetArrayFromConsole2(ref num);
            ShowArray(result);

            //Задание 5.3.1
            var someAge = 21;
            Console.WriteLine(someAge.ToString());
            ChangeAge(ref someAge);
            Console.WriteLine(someAge);

            //Задание 5.3.8
            num = 6;
            result = GetArrayFromConsole2(ref num);
            result = SortArray(result);
            foreach (var element in result)
            {
                Console.Write($"{element} ");
            }

            //Задание 5.3.13
            int[] inputArray = { 5, 2, 8, 1, 7 };
            int[] sortedDesc;
            int[] sortedAsc;

            SortArray2(inputArray, out sortedDesc, out sortedAsc);

            Console.WriteLine("Sorted Descending: " + string.Join(", ", sortedDesc));
            Console.WriteLine("Sorted Ascending: " + string.Join(", ", sortedAsc));

            //Задание 5.5.3
            Console.WriteLine("Введите любую фразу");
            var frase = Console.ReadLine();
            Console.WriteLine("Укажите глубину эха");
            var deep = Convert.ToInt32(Console.ReadLine());
            Echo(frase, deep);
        }
        static void Echo (string frase, int deep)
        {
            string modif = frase;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }
            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);
            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }
        static void SortArray2(in int[] array, out int[] sortedDesc, out int[] sortedAsc)
        {
            sortedAsc = SortArrayAsc(array);
            sortedDesc = SortArrayDesc(array);

        }
        static int[] SortArrayDesc(int[] array)
        {
            int[] sorted = new int[array.Length];
            Array.Copy(array, 0, sorted, 0, sorted.Length);
            int temp;
            for (var i = 1; i < sorted.Length; i++)
            {
                for (var j = 0; j < sorted.Length - i; j++)
                {
                    if (sorted[j] > sorted[j + 1])
                    {
                        temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }
            return sorted;
        }
        static int[] SortArrayAsc(int[] array)
        {

            int[] sorted = new int[array.Length];
            Array.Copy(array, 0, sorted, 0, sorted.Length);
            int temp;
            for (var i = 1; i < sorted.Length; i++)
            {
                for (var j = 0; j < sorted.Length - i; j++)
                {
                    if (sorted[j] < sorted[j + 1])
                    {
                        temp = sorted[j];
                        sorted[j] = sorted[j + 1];
                        sorted[j + 1] = temp;
                    }
                }
            }
            return sorted;
        }
        static void ChangeAge(ref int age)
        {
            Console.WriteLine("Введите возраст");
            age = Convert.ToInt32(Console.ReadLine());

        }
        static void ShowArray(int[] array, bool isSort = false)
        {
            var temp = array;
            if (isSort)
            {
                temp = SortArray(array);
            }
            foreach (var element in temp)
            {
                Console.WriteLine(element);
            }
        }
        static string ShowColor3(string name, int age)
        {
            Console.WriteLine($"{name}, {age} год, напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            return color;
        }
        static string ShowColor2(string name)
        {
            Console.WriteLine($"{name}, Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            return color;
        }
        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }

            return color;
        }
        static int[] GetArrayFromConsole2(ref int num)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }
        static int[] SortArray(int[] result)
        {
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
