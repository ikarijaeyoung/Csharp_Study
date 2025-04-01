namespace TextRPG.Scenes
{
    public class CharacterChoice : Scene
    {
        private static bool thiefCharacterOpen = false;
        public override void Render()
        {
            Console.WriteLine("캐릭터를 선택하세요");
        }
        public override void Choice()
        {
            // thief라는 캐릭터 해금 조건을 달성하면 그 다음부터는 thief 캐릭터 플레이 가능
            if (thiefCharacterOpen == true)
            {
                Console.WriteLine("1. 검사 2. 궁수 3. 마법사 4. 도둑");
            }
            else { Console.WriteLine("1. 검사 2. 궁수 3. 마법사"); }
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("검사를 선택하셨습니다.");
                    Game.Player.Str = 10; // 선택에 따라 부가 스텟 재조정
                    Game.Player.Hp = 150;
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("궁수를 선택하셨습니다.");
                    Game.Player.Str = 4;
                    Game.Player.Hp = 90;
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    Game.Player.Intelligence = 10;
                    Game.Player.Hp = 80;
                    break;
                case ConsoleKey.D4:
                    if (thiefCharacterOpen == true)
                    {
                        Console.WriteLine("도둑을 선택하셨습니다.");
                        Game.Player.Luck = 11;
                        Game.Player.Hp = 100;
                        Game.Player.Gold = 200;
                    }
                    else { Console.WriteLine("잘못된 입력입니다. 다시 입력해 주세요."); }
                    return;
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해 주세요.");
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
                default:
                    {
                        Game.ChangeScene("SnailsHill");
                    }
                    break;
            }
        }
    }
}
