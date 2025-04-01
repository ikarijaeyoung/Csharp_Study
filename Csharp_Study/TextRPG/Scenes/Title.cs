namespace TextRPG.Scenes
{
    public class Title : Scene
    {
        public override void Render()
        {
            Console.WriteLine("게임 시작화면");
        }
        public override void Choice()
        {
            Console.WriteLine("1. 시작하기");
            Console.WriteLine("2. 개발진");
            Console.WriteLine("Esc : 종료하기");
        }
        public override void Result()
        {

        }
        public override void Wait()
        {

        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Game.ChangeScene("CharacterChoice");
                    break;
                case ConsoleKey.D2:
                    Game.ChangeScene("Director");
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }

        }
    }
}
