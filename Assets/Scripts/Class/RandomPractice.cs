using UnityEngine;

// 로또 번호 생성기
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Random 클래스 객체(개체,인스턴스) 생성
        System.Random rand = new System.Random();

        // 배열 변수 선언 및 요소수 생성
        int[] numbers = new int[6];

        //
        int number = 0; // 랜덤 값을 저장하는 변수
        bool flag = false; // 중복 검사해서 중복이면 true, 아니면 false

        for (int i = 0; i < 6; i++)
        {
            // 1~45 랜덤 값을 받아온다
            number = rand.Next(1, 46);

            // 중복 체크 - number와 먼저 뽑힌 로또 번호와 비교해서 검사
            flag = false;
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }
            }

            //
            if (flag == false) // 중복이 아니면
            {
                numbers[i] = number;
            }
            else // 중복이면 다시 계산하기 위해 인덱스를 조정한다
            {
                i--;
            }
        }

        // 로또 번호 출력
        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i]);
        }

    }
}

/*
numbers[0] x
numbers[1] : [0]
numbers[2] : [0], [1]
numbers[3] : [0], [1], [2]
numbers[4] : [0], [1], [2], [3]
numbers[5] : [0], [1], [2], [3], [4]
*/
