﻿namespace _0402_sort
{
    internal class Program
    {
        public static void Swap(int left, int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }

        static void Main(string[] args)
        {

        }

        선택정렬
            작은수를 찾아서
            기준을 설정
            기준보다 더 낮은 값을 계속 탐색
            최종적으로 낮은 값을 앞으로 배치하고
                다음에 배치할 위치 + 1
                
                

            삽입정렬
            두번째값과 그 이전 값을 비교후 작은것을 앞으로
            그 다음 숫자를 기준으로 작은 숫자가 나올때까지 배열 앞쪽을 탐색
            탐색후 그 숫자 다음 위치에 배치
            배열 끝까지 반복
            

            버블정렬
            맨 앞부터 그 다음번째 숫자랑 크기를 비교
            크기를 비교하고 크면 SWAP
            아니면 그대로
            다시 큰 숫자를 기준으로 그 다음차례 숫자랑 크기 비교
            배열의 끝까지 반복

            병합정렬
            배열을 반토막냄 
            배열의 크기가 2까지 토막냄
            두 배열의 앞 숫자끼리 비교한 후 
            작은 숫자를 선정해서 배치
            다시 배열의 크기만큼 반복



            퀵정렬
            맨 앞 숫자를 기준
            그 다음번째 숫자를 LEFT, 배열의 맨 끝 숫자를 RIGHT로 지정
            LEFT가 기준보다 큰 숫자를 만날때까지 위치증가
            RIGHT는 기준보다 작은 숫자를 만날때까지 위치감소
            LEFT와 RIGHT모두 적합한 값을 찾았을 때 SWAP
            RIGHT가 LEFT위치를 넘어갈 때 

    }
}
