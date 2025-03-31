namespace _0331_Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    // 그래프를 코드로 옮겨적는 작업
    // A : 출제자, B : 풀이자
    // A : 사이트에서 그래프를 보고 코드로 옮겨 적기
    // B : 코드를 보고 그래프를 그리기!!
    // A의 그래프 원본과 B가 그린 그래프가 일치하면 성공

    public class Graph
    {
        List<int>[] listGraph;

        public void CreatGraph()
        {
            List<int>[] listGraph = new List<int>[8];
            listGraph[0] = new List<int>() { 1, 2, 3, 4 };
            listGraph[1] = new List<int>() { 0, 2, 3, 5, 6 };
            listGraph[2] = new List<int>() { };
            listGraph[3] = new List<int>() { 7 };
            listGraph[4] = new List<int>() { 6 };
            listGraph[5] = new List<int>() { };
            listGraph[6] = new List<int>() { 2, 4 };
            listGraph[7] = new List<int>() { 5 };

        }
    }

}
