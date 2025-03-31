namespace _0331_Graph_Practice
{
    internal class Program
    {
        // 과제 1. 가중치 그래프 구현하기

        // 다음의 조건에 부합하는 가중치 그래프를 구현하시오.
        // 노드와 노드를 잇는 간선 생성 시, 간선은 반드시 가중치를 지녀야 한다.
        // 가중치는 음수를 제외한 실수여야 한다.
        // 그래프의 내용 출력 시 각 노드는 다음와 같은 내용으로 인접한 노드들을 출력해야 한다.
        //     출력 예시
        // OOO노드 : - OOO노드, 가중치 O - OOO노드, 가중치 O - OOO노드, 가중치 O

        static void Main(string[] args)
        {
            Graph graph = new();
            graph.CreatGraph();
            graph.PrintNodes();
        }
    }

    public class Graph
    {
        public void CreatGraph()
        {
            // 가중치 9999는 단절
            int[,] graph = new int[8, 8]
            {
                { 0, 9999, 9999, 9999, 9999, 9999, 9999, 9999 },
                { 9999, 0, 5, 2, 9999, 9999, 3, 9999 },
                { 9999, 5, 0, 9999, 5, 9999, 9999, 9999 },
                { 9999, 2, 9999, 0, 9999, 9999, 9999, 9999 },
                { 9999, 9999, 5, 9999, 0, 9999, 3, 9999 },
                { 9999, 9999, 9999, 9999, 9999, 0, 9999, 3 },
                { 9999, 3, 9999, 9999, 3, 9999, 0, 9 },
                { 9999, 9999, 9999, 9999, 9999, 3, 9, 0 },
            };
        }

        public void PrintNodes() // 여기를 어떻게 해야하지...
        {
            for (int i = 0; i > graph[i,8]; i++)
            {
                for ( int j = 0; j > graph[i,j]; j++)
                {
                    if (i > 0 && i < 9999 && j > 0 && j < 9999)
                    {
                        Console.WriteLine($"{i}노드 : {j + 1}, 가중치 {graph[i, j]}");
                    }
                }
            }
        }
    }

}
