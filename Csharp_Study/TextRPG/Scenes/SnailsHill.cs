namespace TextRPG.Scenes
{
    public class SnailsHill : Scene
    {
        public override void Render()
        {
            Console.WriteLine("달팽이 동산");
        }
        public override void Choice()
        {
            Console.WriteLine("1. 달팽이에게 다가간다. 2. 마을로 간다.");
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("달팽이가 화를내며 덤벼듭니다.");
                    Console.WriteLine("달팽이 : 쒸익 쒸익!!!");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("마을로 이동합니다 ...");
                    break;
                default:
                    { Console.WriteLine("잘못 입력하셨습니다. 다시 입력해 주세요. "); }
                    return;
            }
        }

        public override void Wait()
        {
            Console.ReadKey();
        }

        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("FightSnail");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Henesis");
                    break;
            }
        }


    }
}
