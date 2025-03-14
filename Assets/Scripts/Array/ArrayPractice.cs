using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 3�� 3���� 2���� �迭�� �����
        int[,] arr = new int[3, 3];

        // �� �ʱ�ȭ, ��� ���� �ε��� ������ 1, ��� ���� �ε����� Ʋ���� 0
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if (i == j) // ��� ���� �ε��� ������ 1
                {
                    arr[i, j] = 1;
                }
                else // ��� ���� �ε��� �ٸ��� 0
                {
                    arr[i, j] = 0;
                }
            }
        }

        // ���
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log($"arr[{i}, {j}] : {arr[i, j]}");
            }
        }
    }
}
