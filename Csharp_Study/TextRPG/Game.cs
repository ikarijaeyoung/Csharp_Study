using TextRPG.Scenes;
using TextRPG.Scenes.FightScenes;

namespace TextRPG
{
    public static class Game
    {
        private static bool gameOver = false;

        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;

        private static Player player;
        public static Player Player { get { return player; } }


        public static void Start()
        {
            sceneDic = new();
            sceneDic.Add("Title", new Title());
            sceneDic.Add("CharacterChoice", new CharacterChoice());
            sceneDic.Add("Director", new Director());
            sceneDic.Add("SnailsHill", new SnailsHill());
            sceneDic.Add("FightSnail", new FightSnail());
            sceneDic.Add("Henesis", new Henesis());

            curScene = sceneDic["Title"];

            Player player = new(); // 기본 캐릭터 스탯 초기 설정

            Game.Player.Str = 4; // 왜 오류나지..
            Game.Player.Dex = 4;
            Game.Player.Intelligence = 4;
            Game.Player.Luck = 4;
            Game.Player.Hp = 100;
            Game.Player.Gold = 0;
        }
        public static void End()
        {

        }

        public static void Run()
        {
            while (gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                curScene.Next();
            }
        }
        public static void ChangeScene(string sceneName)
        {
            curScene = sceneDic[sceneName];
        }

        public static void GameOver(string reason)
        {
            Console.Clear();
            Console.WriteLine("사망했습니다..");
            Console.WriteLine("사유 : ");
            Console.Write(reason);

            gameOver = true;
        }
    }
}
