using TextRPG.Scenes;

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

            curScene = sceneDic["Title"];

            Player player = new Player();
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
    }
}
