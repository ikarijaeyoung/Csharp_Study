namespace _0331_make_stack_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        // 다음의 조건을 충족하는 MyStack<T> 클래스를 구현하시오
        // 
        // Stack<T> 클래스의 사용을 금지하며, 배열을 사용해 구현한다.
        // 클래스의 인스턴스 생성 시 최초 10의 크기를 가진다.
        // 배열의 크기를 넘어서 데이터를 추가할 경우, 현재 배열의 크기의 2배만큼 재할당해야 한다.
        // 아래 필수 구현 메서드 외 내부 동작을 위한 필드 및 메서드 추가는 허용한다.
        // 구현 메서드
        // Push(T element) : 배열의 맨 뒤에 데이터를 추가한다.
        // Pop() : 가장 마지막에 추가한 데이터를 반환하고, 내부 배열에서 삭제한다.
        // Peek() : 가장 마지막에 추가한 데이터를 반환한다.
        // Clear() : 배열 내의 모든 데이터를 삭제한다.

        public class MyStack
        {
            public MyStack()
            {
                Array array = new Array[10];
            }

            public void Push<T>(T element)
            {
                for ( int i = 0; i > array[].Length; i++)
                {
                    if (array[i] != null)
                    {
                        array[i] = element;
                    }
                }
            }
        }

    }
}
