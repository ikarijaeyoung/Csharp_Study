namespace TextRPG.Scenes.FightScenes
{
    public class FightSnail : Scene
    {
        public override void Render()
        {
            Console.WriteLine("달팽이 싸움 장면");
        }
        public override void Choice()
        {
            Console.WriteLine("1. 때린다 2. 쓰다듬는다 3. 도망간다");
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("힘껏 때려봅니다.");
                        Console.WriteLine("잉..차");
                        if ( Game.Player.Str > 7)
                        {
                            Console.WriteLine("달팽이가 싹싹빌면서 50원을 건넵니다.");
                        }
                        else
                        {
                            Console.WriteLine("당신은 지금 달팽이보다 약합니다..");
                            Game.GameOver("너무 약함");
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    {
                        Console.WriteLine("달팽이가 좋아합니다.");
                    }
                    break;
                case ConsoleKey.D3:
                    {
                        Console.WriteLine("도망칩니다...");
                    }
                    break;
                default:
                    { Console.WriteLine("잘못 입력하셨습니다. 다시 입력해 주세요."); }
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
                case ConsoleKey.D3:
                    {
                        Game.ChangeScene("SnailsHill");
                    }
                    break;
            }
        }
    }
}
