namespace game3
{
    class program

    {

        static void Main()
        {

            Ime me = new tank(100, 15, 40, 3, "Igrok");//характеристики моего танка 
            Ienemy enemy = new tank(100, 15, 40, 3, "PC");//характеристики танка противника 


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

                        EnemyPC();

                        break;
                    case ConsoleKey.X:
                        me.Heal();
                        EnemyPC();
                        break;
                    case ConsoleKey.C:
                        me.Buy();
                        EnemyPC();
                        break;

                    default:
                        Console.WriteLine("\nНажмите одну из перечисленых клавиш сверху\n");
                        break;
                }

                Console.WriteLine("Нажмите любую клавишу чтобы продолжить");
                Console.ReadKey();
                Console.Clear();
            }


            void EnemyPC()
            {
                Random r = new Random();
                int rand;
                rand = r.Next(1, 3);
                enemy.HodPC();
                switch (rand)//компьютер работающий через рандом

                {
                    case 1:

                        if (enemy.HelPoint == enemy.Life && enemy.Patron > 0)
                        { enemy.Shot(me); }
                        else
                        {
                            if (enemy.HelPoint <= enemy.Life)
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

            }

            if (me.HelPoint <= 0)//экран победы или поражения.
            {
                Console.WriteLine("Поражение");
            }
            else
            {
                Console.WriteLine("Победа");
            }
        }
               enum Move
        {
            Shot,
            Heal,
            Buy

        }

    }
    }
