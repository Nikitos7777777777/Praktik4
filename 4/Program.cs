namespace _4
{
    class Date07
    {
        public void DATE07()
        {
            Console.WriteLine("07.11.22");
            Console.WriteLine("  1.Успеть зделать все дела");
            Console.WriteLine("  2.Отдaхнуть");
        }
    }

    class Date08
    {
        public void DATE08()
        {
            Console.WriteLine("08.11.22");
            Console.WriteLine("  Здать практические");
            Console.WriteLine("  Отдахнуть");
        }
    }
    

    class Date09
    {
        public void DATE09()
        {
            Console.WriteLine("09.11.22");
            Console.WriteLine("  Поиграть");
            Console.WriteLine("  Отдaхнуть");
        }
    }




    class MainClass
    {

        public static void Main(string[] ages)
        {


            int position = 1;
            string[] Day8 = new string[] { "Успеть сделать дела \n ------------------------------------------\n Описание: Успеть сделать куууууууууууууча дел.\n Дата:08.11.22" };
            string[] Day08 = new string[] { "Хорошо отдахнуть \n ------------------------------------------\n Описание : паспать не меньше 10 часов. \n Дата :08.11.22" };

            Date08 date08 = new Date08();
            date08.DATE08();

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }

                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(0, position);

                }
                Console.Clear();
                date08.DATE08();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                if (key.Key == ConsoleKey.Enter && position == 1)
                {
                    Console.Clear();
                    Console.WriteLine(Day8[0]);
                }

                if (key.Key == ConsoleKey.Enter && position == 2)
                {
                    Console.Clear();
                    Console.WriteLine(Day08[0]);
                }

                //////////////////////////////////////////////////////////////////Леснуть на 07.11.22///////////////////////////////////////////////
                string[] Day7 = new string[] { "Здать учителю ысе работы \n ------------------------------------------\n Описание: Здать 4 и 5. \n Дата: 07.11.22 " };
                string[] Day07 = new string[] { "Хорошо отдахнуть \n ------------------------------------------\n Описание : паспать не меньше 10 часов. \n Дата : 07.11.22" };

                Date07 date07 = new Date07();
               

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    int positi = 1;
                    date07.DATE07();
                    while (true)
                    {
                        ConsoleKeyInfo k = Console.ReadKey();
                        if (k.Key == ConsoleKey.UpArrow)
                        {
                            positi--;
                        }

                        else if (k.Key == ConsoleKey.DownArrow)
                        {
                            positi++;
                        }
                        else if (k.Key == ConsoleKey.Enter)
                        {
                            Console.SetCursorPosition(0, positi);

                        }
                        Console.Clear();
                        date07.DATE07();
                        Console.SetCursorPosition(0, positi);
                        Console.WriteLine("->");

                        if (k.Key == ConsoleKey.Enter && position == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(Day7[0]);
                        }

                        if (k.Key == ConsoleKey.Enter && position == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(Day07[0]);
                        }
                    }



                }

                /////////////////////////////////////////////////////Леснуть на 09.11.22//////////////////////////////////////////////////////
                string[] Day9 = new string[] { "Поиграть игры с друзьями  \n ------------------------------------------\n Описание: Отдахнуть. \n Дата:09.11.22" };
                string[] Day09 = new string[] { "Хорошо отдахнуть  \n ------------------------------------------\n Описание : паспать не меньше 10 часов. \n Дата :09.11.22" };
                Date09 date09 = new Date09();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    int positio = 1;
                    date09.DATE09();
                    while (true)
                    {
                        ConsoleKeyInfo ke = Console.ReadKey();
                        if (ke.Key == ConsoleKey.UpArrow)
                        {
                            positio--;
                        }

                        else if (ke.Key == ConsoleKey.DownArrow)
                        {
                            positio++;
                        }
                        else if (ke.Key == ConsoleKey.Enter)
                        {
                            Console.SetCursorPosition(0, positio);

                        }
                        Console.Clear();
                        date09.DATE09();
                        Console.SetCursorPosition(0, positio);
                        Console.WriteLine("->");

                        if (ke.Key == ConsoleKey.Enter && position == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(Day9[0]);
                        }

                        if (ke.Key == ConsoleKey.Enter && position == 2)
                        {
                            Console.Clear();
                            Console.WriteLine(Day09[0]);
                        }


                    }

                }

            }

        }

    }  

}

