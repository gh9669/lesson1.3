using System;

namespace lesson1._3
{
    class Program
    {
        static void Main(string[] args)
        {

            RPG r = new RPG();
            r.Name = "меч и магия";
            r.Year = 2010;
            r.Hero = "Лучница";
            r.Armor = "Кожа";
            r.Weapon = "Лук";
            r.Message();
            Console.WriteLine();

            Shooter s = new Shooter();
            s.Name = "Контра";
            s.Year = 2015;
            s.Team = "Террористы";
            s.Grenade = "Осколочная";
            s.Weapon = "Пистолет";
            s.Message();
            Console.WriteLine();

            MOBA m = new MOBA();
            m.Name = "Контра";
            m.Year = 2010;
            m.Team = "Верхние";
            m.Creeps = "Первая волна";
            m.Difficulty = "Легко";
            m.Message();
            Console.WriteLine();

            Puzzle p = new Puzzle();
            p.Name = "Шарики";
            p.Year = 1999;
            p.Difficulty = "Hard";
            p.Message();
            Console.WriteLine();

            Strategy st = new Strategy();
            st.Name = "Супримка";
            st.Year = 2003;
            st.Team = "Синие";
            st.army = "Воздушные";
            st.Difficulty = "Адаптивные";
            st.Message();
        }
    }
    class RPG
    {
        public string Name;
        public int Year;
        public string Hero;
        public string Weapon;
        public string Armor;

        public void Message()
        {
            Console.WriteLine("Ролевая игра");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Герой: " + Hero);
            Console.WriteLine("Оружие: " + Weapon);
            Console.WriteLine("Броня: " + Armor);
        }
    }
    class Shooter
    {
        public string Name;
        public int Year;
        public string Team;
        public string Weapon;
        public string Grenade;

        public void Message()
        {
            Console.WriteLine("Шутер");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Команда: " + Team);
            Console.WriteLine("Оружие: " + Weapon);
            Console.WriteLine("Граната: " + Grenade);
        }

    }
    class MOBA
    {
        public string Name;
        public int Year;
        public string Difficulty;
        public string Team;
        public string Creeps;

        public void Message()
        {
            Console.WriteLine("Дохта");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Сложность: " + Difficulty);
            Console.WriteLine("Команда: " + Team);
            Console.WriteLine("Сложность крипов: " + Creeps);

        }

    }
    class Puzzle
    {
        public string Name;
        public int Year;
        public string Difficulty;

        public void Message()
        {
            Console.WriteLine("Пазлы");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Сложность: " + Difficulty);
        }

    }
    class Strategy
    {
        public string Name;
        public int Year;
        public string Difficulty;
        public string Team;
        public string army;

        public void Message()
        {
            Console.WriteLine("Супра");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Сложность: " + Difficulty);
            Console.WriteLine("Команда: " + Team);
            Console.WriteLine("Вид войск: " + army);

        }

    }
}
