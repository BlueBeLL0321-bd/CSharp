using UnityEngine;

// break�� ���� ���� ����������
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //���� ���� - ���� �ݺ�
        /*for (; ; )
        {
        }*/
        /*while (true)
        {
        }*/

        int number = 0;

        // number�� 5 �̻��̸�
        while (true) // ���� ����
        {
            // �ݺ� ���๮

            number++;
            if(number >= 5)
            {
                break;
            }
        }
    }
}
