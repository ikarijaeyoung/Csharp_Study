namespace _0330
{
    internal class Program
    {
        public class Lottery
        {
            // 필드
            // 당첨 번호
            // 입력 번호
            // 당첨 번호를 뽑을 랜덤 객채?

            private int winNum;
            public int userInput;
            private Random ranNum = new Random();

            // public void SetWinNum()
            // {
            //     winNum = ranNum.Next(1, 12);
            // }

            public void TryLottery()
            {

                while (true)
                {
                    Console.Write("1 ~ 12 숫자를 입력해 주세요 : ");
                    userInput = int.Parse(Console.ReadLine());
                    winNum = ranNum.Next(1, 12);

                    if (userInput == winNum)
                    {
                        Console.WriteLine(" 당첨! ");
                        break;
                    }
                    else { Console.WriteLine($"다시 입력해주세요. 당첨 번호는 {winNum}이였습니다."); }
                }
            }

            // 매서드
            // 당첨 번호를 랜덤으로 설정
            // 그 번호와 입력된 번호가 일치하는지 판별
        }

        static void Main(string[] args)
        {
            Console.WriteLine("랜덤한 숫자와 내가 입력한 숫자가 일치하는지 테스트");

            Lottery lottery = new();

            // lottery.SetWinNum();
            lottery.TryLottery(); // 당첨 번호를 매번 재설정

        }
    }
}
