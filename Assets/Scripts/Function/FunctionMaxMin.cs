using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 3, 5�� �Է� �޾� ū ���� ����ϱ�
        int max = GetMax(3, 5);
        Debug.Log($"3�� 5 �� ū ���� {max}�̴�.");

        int min = GetMin(-3, -5);
        Debug.Log($"-3�� -5 �� ���� ���� {min}�̴�.");
    }

    int GetMax(int x, int y)
    {
        /* int MaxValue;
         if(x > y)
         {
             MaxValue = x;
         }
         else
         {
             MaxValue = y;
         }*/

        // 3�� ������
        /*int MaxValue = (x > y) ? x : y;
        return MaxValue;*/

        // return (x > y) ? x : y;

        if(x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    // [2] �Ű� ������ �Է� ���� �� ���� ���� �� ���� ���� ��ȯ�ϴ� �Լ�
    int GetMin(int x, int y)
    {
        if(x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }


}
/*
[1]
1. �Ű� ������ �Է� ���� �� ���� ���� �� ū ���� ��ȯ�ϴ� �Լ�
2. �Ű� ������ �Է� ���� �� ���� ���� �� ���� ���� ��ȯ�ϴ� �Լ�
3. 3, 5�� �Է� �޾� ū �� ����ϱ�
4. -3, -5�� �Է� �޾� ���� �� ����ϱ�
*/