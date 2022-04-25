using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game3
{
    class tank : Ime, Ienemy
    {// поля класса
        public int HelPoint { get; set; }
        public int Armour { get; set; }
        public int Damaged { get; set; }
        public int Patron { get; set; }
        public string Name { get; set; }
        public int Life { get; set; }
        

        void Ime.Shot(Ienemy enemy)
        {
            Random Shan = new Random(); //рандом
            int Shos;

            if (Patron <= 0)
            {
                Console.WriteLine("\nНеобходимо купить патроны\n");
            }
            else
            {
                Shos = Shan.Next(1, 11);
                if (Shos <= 2)//добавление вероятности
                {

                    Console.WriteLine($"\n {Name} Промазал\n");
                    Patron--;
                }
                else if (Shos == 3)
                {
                    double Crit = 1.2;
                    enemy.HelPoint -= (int)(Damaged * Crit - enemy.Armour);
                    Patron--;
                    Console.WriteLine($"\n {Name} Наносит критическое попадание\n");
                }
                else
                {
                    enemy.HelPoint -= Damaged - enemy.Armour;
                    Console.WriteLine($"{Name} Выстрелил");
                    Patron--;
                }
            }
        }

        void Ime.Heal()
        {
            if (HelPoint == Life)
            {
                Console.WriteLine("\nПочинка не нужна");
            }
            else
            {
                HelPoint += 20;
                Console.WriteLine("\nПроизошла починка");

                if (HelPoint >= Life)
                {
                    HelPoint = Life;
                }


            }
        }

        void Ime.Buy()
        {
            Patron = 3;
        }

        

        //конструктор класса
        public tank(int a, int b, int c, int d, string f)
        {
            HelPoint = a; Armour = b; Damaged = c; Patron = d; Name = f; Life = a;
        }



        void Ienemy.Shot(Ime enemy)
        {
            Random Shan = new Random(); //рандом
            int Shos;

            if (Patron <= 0)
            {
                Console.WriteLine("\nНеобходимо купить патроны\n");
            }
            else
            {
                Shos = Shan.Next(1, 11);
                if (Shos <= 2)//добавление вероятности
                {

                    Console.WriteLine($"\n {Name} Промазал\n");
                    Patron--;
                }
                else if (Shos == 3)
                {
                    double Crit = 1.2;
                    enemy.HelPoint -= (int)(Damaged * Crit - enemy.Armour);
                    Patron--;
                    Console.WriteLine($"\n {Name} Наносит критическое попадание\n");
                }
                else
                {
                    enemy.HelPoint -= Damaged - enemy.Armour;
                    Console.WriteLine($"{Name} Выстрелил");
                    Patron--;
                }
            }
        }

        void Ienemy.Heal()
        {
            if (HelPoint == Life)
            {
                Console.WriteLine("\nПочинка не нужна");
            }
            else
            {
                HelPoint += 20;
                Console.WriteLine("\nПроизошла починка");

                if (HelPoint >= Life)
                {
                    HelPoint = Life;
                }


            }
        }

        void Ienemy.Buy()
        {
            Patron = 3;
        }
        
    }
}
