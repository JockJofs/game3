namespace game3
{
    class program

    {
        static void Main()
        {

            tank me = new(100, 15, 40, 3, "Igrok");//характеристики моего танка 
            tank enemy = new(100, 15, 40, 3, "PC");//характеристики танка противника 
            Random r = new Random();
            int rand;
            while (me.HelPoint > 0 && enemy.HelPoint > 0)
            {

                Console.WriteLine($"Количество жизней игрока : {me.HelPoint} Патроны : {me.Patron}");
                Console.WriteLine($"Количество жизней противника : {enemy.HelPoint} Патроны :{enemy.Patron}\n");
                Console.WriteLine("Выберите действие");
                Console.WriteLine("Огонь :Z");
                Console.WriteLine("Починка :X");
                Console.WriteLine("Покупка патронов :C");

                switch (Console.ReadKey().Key)//управление для игрока по клавишам
                {
                    case ConsoleKey.Z:
                        me.Shot(enemy);
                        break;
                    case ConsoleKey.X:
                        me.Heal();
                        break;
                    case ConsoleKey.C:
                        me.Buy();
                        break;
                    default:
                        Console.WriteLine("\nПропуск");
                        break;
                }

                Console.WriteLine();
                rand = r.Next(1, 3);

                switch (rand)//компьютер работающий через рандом

                {
                    case 1:

                        if (enemy.HelPoint > 50 && enemy.Patron > 0)
                        { enemy.Shot(me); }
                        else
                        {
                            if (enemy.HelPoint <= 50)
                            {
                                enemy.Heal();
                            }
                            else
                            {
                                enemy.Buy();
                            }
                        }
                        break;
                    case 2:

                        if (enemy.Patron <= 0)
                        {
                            enemy.Buy();

                        }
                        else
                        {
                            enemy.Shot(me);

                        }
                        break;
                }
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }

            if (me.HelPoint <= 0)//экран победы или поражения
            {
                Console.WriteLine("Поражение");
            }
            else
            {
                Console.WriteLine("Победа");
            }

        }
    }
}