using UnityEngine;

// �ζ� ��ȣ ������
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Random Ŭ���� ��ü(��ü,�ν��Ͻ�) ����
        System.Random rand = new System.Random();

        // �迭 ���� ���� �� ��Ҽ� ����
        int[] numbers = new int[6];

        //
        int number = 0; // ���� ���� �����ϴ� ����
        bool flag = false; // �ߺ� �˻��ؼ� �ߺ��̸� true, �ƴϸ� false

        for (int i = 0; i < 6; i++)
        {
            // 1~45 ���� ���� �޾ƿ´�
            number = rand.Next(1, 46);

            // �ߺ� üũ - number�� ���� ���� �ζ� ��ȣ�� ���ؼ� �˻�
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
            if (flag == false) // �ߺ��� �ƴϸ�
            {
                numbers[i] = number;
            }
            else // �ߺ��̸� �ٽ� ����ϱ� ���� �ε����� �����Ѵ�
            {
                i--;
            }
        }

        // �ζ� ��ȣ ���
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
