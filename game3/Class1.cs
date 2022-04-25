using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game3
{
    class tank
    {// поля класса
        public int HelPoint;
        public int Armour;
        public int Damaged;
        public int Patron;
        public string Name;
        public int Life;
        //конструктор класса
        public tank(int a, int b, int c, int d, string f)
        {
            HelPoint = a; Armour = b; Damaged = c; Patron = d; Name = f; Life = 100;
        }
        public void Shot(tank enemy) //создаем метод выстрел
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
        public void Heal()//метод починки
        {
            
            if (HelPoint <= Life)
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

        public void Buy()// метод покупки патронов
        {
            Patron = 3;
        }
       
      
    }
}
