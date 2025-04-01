namespace TextRPG.Scenes
{
    public class Henesis : Scene
    {
        public override void Render()
        {
            Console.WriteLine("헤네시스"); // 맵 텍스트 디자인은 나중에
            Console.WriteLine("이곳은 평화로운 마을입니다.");
            Console.WriteLine("둘러볼곳이 너무 많습니다.");
        }
        public override void Choice()
        {
            Console.WriteLine("1. 맛있는 냄새가 나는곳으로 간다");
            Console.WriteLine("2. 큰 소리가 나는곳으로 간다");
            Console.WriteLine("3. 조용한곳을 찾아본다");
            Console.WriteLine("4. 높은곳을 찾아본다");
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("맛있는 냄새를 따라가 식당을 발견했습니다.");
                    Console.WriteLine("체력이 채워집니다.");
                    Game.Player.Hp = 40; // 캐릭터마다 다른 최대체력만큼 회복시키고싶음
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("큰 소리가 나는곳으로 따라가니, 훈련장이 보입니다.");
                    Console.WriteLine("의지가 불타오르며 힘이 강해졌습니다.");
                    Game.Player.Str += 4;
                    Game.Player.Dex += 4;
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("조용한곳을 찾아보니 마음이 편안해졌습니다.");
                    Game.Player.Intelligence += 4;
                    Game.Player.Luck += 4;
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("높은곳을 찾아 마을에서 가장 높은 탑으로 올라갔습니다.");
                    Console.WriteLine("탑 꼭대기에는 작은 낙서가 보입니다.");
                    Console.WriteLine("나를 찾아와");
                    Game.Player.Gold += 500;
                    break;
            }
        }
        public override void Wait()
        {

        }

        public override void Next()
        {

        }
    }
}
