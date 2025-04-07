namespace _0404_Pattern_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeaponFactory weaponfactory0 = new();
            weaponfactory0.rate = 1;
            Weapon weapon00 = weaponfactory0.Create("철 검");
            Weapon weapon01 = weaponfactory0.Create("나무 창");
            Weapon weapon02 = weaponfactory0.Create("쇠 도끼");
            Weapon weapon03 = WeaponFactory.Gotcha();

            Console.WriteLine($"희귀도 : 일반 \t공격력 {weaponfactory0.rate}배 증가");
            Console.WriteLine($"무기 이름 : {weapon00.weaponName} \t공격력 : {weapon00.weaponDamage} \t공격 범위 : {weapon00.weaponArange}");
            Console.WriteLine($"무기 이름 : {weapon01.weaponName} \t공격력 : {weapon01.weaponDamage} \t공격 범위 : {weapon01.weaponArange}");
            Console.WriteLine($"무기 이름 : {weapon02.weaponName} \t공격력 : {weapon02.weaponDamage} \t공격 범위 : {weapon02.weaponArange}");
            Console.WriteLine($"무기 이름 : {weapon03.weaponName} \t공격력 : {weapon03.weaponDamage} \t공격 범위 : {weapon03.weaponArange}");
            Console.WriteLine("");

            WeaponFactory weaponfactory1 = new();
            weaponfactory1.rate = 1.1f;
            Weapon weapon10 = weaponfactory1.Create("철 검");
            Weapon weapon11 = weaponfactory1.Create("나무 창");
            Weapon weapon12 = weaponfactory1.Create("쇠 도끼");

            Console.WriteLine($"희귀도 : 에픽 \t공격력 {weaponfactory1.rate}배 증가");
            Console.WriteLine($"무기 이름 : {weapon10.weaponName} \t공격력 : {weapon10.weaponDamage} \t공격 범위 : {weapon10.weaponArange}");
            Console.WriteLine($"무기 이름 : {weapon11.weaponName} \t공격력 : {weapon11.weaponDamage} \t공격 범위 : {weapon11.weaponArange}");
            Console.WriteLine($"무기 이름 : {weapon12.weaponName} \t공격력 : {weapon12.weaponDamage} \t공격 범위 : {weapon12.weaponArange}");
            Console.WriteLine("");

            WeaponFactory weaponfactory2 = new();
            weaponfactory2.rate = 1.2f;
            Weapon weapon20 = weaponfactory2.Create("철 검");
            Weapon weapon21 = weaponfactory2.Create("나무 창");
            Weapon weapon22 = weaponfactory2.Create("쇠 도끼");

            Console.WriteLine($"희귀도 : 전설 \t공격력 {weaponfactory2.rate}배 증가");
            Console.WriteLine($"무기 이름 : {weapon20.weaponName} \t공격력 : {weapon20.weaponDamage} \t공격 범위 : {weapon20.weaponArange}");
            Console.WriteLine($"무기 이름 : {weapon21.weaponName} \t공격력 : {weapon21.weaponDamage} \t공격 범위 : {weapon21.weaponArange}");
            Console.WriteLine($"무기 이름 : {weapon22.weaponName} \t공격력 : {weapon22.weaponDamage} \t공격 범위 : {weapon22.weaponArange}");
            Console.WriteLine("");





            AnimalBuilder chickenBuilder = new();
            chickenBuilder.SetName("닭").SetSound("꼬끼오").SetMake("달걀", "황금 알").SetFeed("연한 상추");
            AnimalBuilder sheepBuilder = new();
            sheepBuilder.SetName("양").SetSound("메에-").SetMake("양고기", "슈퍼 양털").SetFeed("알팔파");
            AnimalBuilder cowBuilder = new();
            cowBuilder.SetName("소").SetSound("음머-").SetMake("우유", "소 뿔").SetFeed("옥수수");

            // 만들어진걸 어떻게 출력해서 확인해보지?
            Animal chicken = chickenBuilder.Build();
            Console.WriteLine($"동물 이름 : ");
        }
    }

    public class WeaponFactory
    {
        public float rate;

        public Weapon Create(string weaponName)
        {
            Weapon weapon;

            switch (weaponName)
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
                default: return null;
            }

            weapon.weaponDamage = (int)(weapon.weaponDamage * rate);
            return weapon;
        }

        public static Weapon Gotcha() // 확률적으로 좋은 무기가 나오는 확률 시스템을 만들어보고싶음.
        {
            Weapon weapon;
            Random random = new();
            int ranNum = random.Next(0, 100);

            if (ranNum < 70)
            {
                weapon = new Weapon("나무 창", 5, 5f);
            }
            else if (ranNum < 90)
            {
                weapon = new Weapon("철 검", 12, 2.7f);
            }
            else
            {
                weapon = new Weapon("쇠 도끼", 20, 2.4f);
            }

            return weapon;
        }
    }

    public class Weapon
    {
        public string weaponName;
        public int weaponDamage;
        public float weaponArange;

        public Weapon(string weaponName, int weaponDamage, float weaponArange)
        {
            this.weaponName = weaponName;
            this.weaponDamage = weaponDamage;
            this.weaponArange = weaponArange;
        }
    }

    public class AnimalBuilder
    {
        public string animalName;
        public string animalMake;
        public string animalSound;
        public string animalFeed;

        public Animal Build() // 여기서 막힘
        {
            Animal animal = new();
            animal._animalName = animalName;
            animal._animalMake = animalMake;
            animal._animalSound = animalSound;
            animal._animalFeed = animalFeed;

            return animal;
        }

        public AnimalBuilder() // 이거 왜 있지?
        {
            animalName = "동물이름";
            animalMake = "생산품";
            animalSound = "울음소리";
            animalFeed = "사료종류";
        }

        public AnimalBuilder SetName(string animalName)
        {
            this.animalName = animalName;
            return this;
        }
        public AnimalBuilder SetMake(string animalMake, string special)
        {
            Random random = new();
            int ranNum = random.Next(0, 2); // 확인용으로 일단 반반으로 만듦
            if (ranNum < 1)
            {
                this.animalMake = animalMake;
            }
            else if (ranNum >= 1)
            {
                this.animalMake = special;
            }
            return this;
        }
        public AnimalBuilder SetSound(string animalSound)
        {
            this.animalSound = animalSound;
            return this;
        }
        public AnimalBuilder SetFeed(string animalFeed)
        {
            this.animalFeed = animalFeed;
            return this;
        }
    }

    public class Animal
    {
        public string _animalName;
        public string _animalMake;
        public string _animalSound;
        public string _animalFeed;
    }


}
