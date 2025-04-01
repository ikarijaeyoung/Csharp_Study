namespace TextRPG
{
    public class Player
    {
        private int str;
        public int Str { get { return str; } set { str = value; } }

        private int dex;
        public int Dex { get { return dex; } set { dex = value; } }

        private int intelligence;
        public int Intelligence {  get { return intelligence; } set { intelligence = value; } }

        private int luck;
        public int Luck { get { return luck; } set { luck = value; } }
    }
}