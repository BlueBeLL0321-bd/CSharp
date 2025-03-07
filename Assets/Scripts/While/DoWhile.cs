using UnityEngine;

// �ȳ��ϼ��� 3�� ���
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // while
        // [1] �ʱ��
        /*int i = 0;

        while (i < 3) // [2] ���ǽ�
        {
            // �ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");

            // ������
            i++;
        }*/

        //dowhile
        // [1] �ʱ��
        int i = 0;

        do
        {
            // �ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");

            // [2] ������
            i++;
        } while (i < 3); // [3] ���ǽ�

        // i : 0; => ��� => i : 1 => 1 < 3 (��) => ��� => i : 2 => i < 3 (��) => ���
        // i : 3 => i < 3 (����) => dowhile�� ����
    }
}

/*
dowhile�� - �ݺ���
���� �ݺ� ���๮ 1�� �����Ѵ�
���ǽ��� true�̸� �ݺ��� ����
���ǽ��� false�̸� while�� ����

do
{
    // �ݺ� ���๮
} while(���ǽ�)


*/
