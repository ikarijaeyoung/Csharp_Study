namespace _0401_LevelTeset02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int iLeft = 10;
            // int iRight = 20;
            // Util.Swap(ref iLeft, ref iRight);
            // Console.WriteLine($"{iLeft}, {iRight}");

            Monster[] monsters = new Monster[5];
            monsters[0] = new Pikachu();
            monsters[1] = new Charmander();
            monsters[2] = new Squirtle();
            monsters[3] = new Bulbarsaur();
            monsters[4] = new Pikachu("털뭉치");

            foreach ( Monster monster in monsters)
            {
                Console.WriteLine($"{monster.Name} 공격해!");
                monster.Attack();
                Console.WriteLine();
            }
        }
    }
}
