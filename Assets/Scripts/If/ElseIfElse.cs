using UnityEngine;

public class ElseIfElse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // number1, number2 ���� �Է¹޾Ƽ�
        // [1] number1 ũ�� number1�� Ů�ϴ� ���
        // [2] number2 ũ�� number2�� Ů�ϴ� ���
        // [3] �������� �� ���� ũ�Ⱑ �����ϴ� ���

        // ����
        int number1 = 10;
        int number2 = 10;

        if(number1 > number2) // ���ǽ�1
        {
            Debug.Log("number1�� Ů�ϴ�"); // ���๮1
        }
        else if(number1 < number2) // ���ǽ�2
        {
            Debug.Log("number2�� Ů�ϴ�"); // ���๮2
        }
        else
        {
            // ���๮3
            Debug.Log("�� ���� ũ�Ⱑ �����ϴ�");
        }

        // ����4
    }
}

/*
Else if��

[1] ���ǽ�1 ���̸�
���� -> ���๮1 -> ���๮4

[2] ���ǽ�1 �����̰� ���ǽ�2�� ���̸�
���� -> ���๮2 -> ���๮4

[3] ���ǽ�1 �����̰� ���ǽ�2 �����̸�
���� -> ���๮3 -> ���๮4

[4] ���ǽ�1 ���̰� ���ǽ�2 ���̸�
���� -> ���๮1 -> ���๮4

*/
