namespace TextRPG.Scenes
{
    public class Director : Scene
    {
        public override void Render()
        {
            Console.WriteLine("Director : 정재영");
            Console.WriteLine("김정택 강사님의 도움으로 만들어졌습니다.");
        }
        public override void Choice()
        {
            Console.WriteLine("아무키나 입력하세요...");
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
                default:
                    Game.ChangeScene("Title");
                    break;
                    
            }
        }
    }
}
