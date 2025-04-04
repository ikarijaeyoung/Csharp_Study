namespace _0404_Pattern_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeaponFactory weaponfactory1 = new();
            Weapon weapon0 = weaponfactory1.Create("철 검");
            Weapon weapon1 = weaponfactory1.Create("나무 창");
            Weapon weapon2 = weaponfactory1.Create("쇠 도끼");


        }
    }

    public class WeaponFactory
    {
        public Weapon Create(string weaponname)
        {
            Weapon weapon;

            switch(weaponname)
            {
                case "철 검": 
                    weapon = new Weapon("철 검", 12, 2.7f);
                    break;
                case "나무 창": 
                    weapon = new Weapon("나무 창", 5, 5f);
                    break;
                case "쇠 도끼": 
                    weapon = new Weapon("쇠 도끼", 20, 2.4f);
                    break;
                default : return null;
            }

            return weapon;  
        }
    }

    public class Weapon
    {
        string weaponname;
        int weapondamage;
        float weaponarange;

        public Weapon(string weaponname, int weapondamage, float weaponarange)
        {
            this.weaponname = weaponname;
            this.weapondamage = weapondamage;
            this.weaponarange = weaponarange;
        }
    }

    public class AnimalBuilder
    {

    }

    public class Animal
    {
        string animalname;
        string animalmake;
        string animalsound;
        string animalfeed;

    }


}
