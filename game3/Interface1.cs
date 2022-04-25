using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game3
{
    internal interface Ime
    {
        string Name { get => Name; set => Name = value; }
        int Armour { get => Armour; set => Armour = value; }
        int Damaged { get => Damaged; set => Damaged = value; }
        int Patron { get => Patron; set => Patron = value; }
        int HelPoint { get => HelPoint; set => HelPoint = value; }
        int Life { get => Life; set => Life = value; }
        void Shot(Ienemy enemy);
        void Heal();
        void Buy();

    }

    internal interface Ienemy
    {
        string Name { get => Name; set => Name = value; }
        int Armour { get => Armour; set => Armour = value; }
        int Damaged { get => Damaged; set => Damaged = value; }
        int Patron { get => Patron; set => Patron = value; }
        int HelPoint { get => HelPoint; set => HelPoint = value; }
        int Life { get => Life; set => Life = value; }
        string Hod { get => Hod; set => Hod = value; }

        void Shot(Ime enemy);
        void Heal();
        void Buy();
        void HodPC();

    }
}
