using UnityEngine;

// + : ���ϱ� ������ �߰� ���
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello" + " World!!!"); // ���ڿ� ���ϱ�
        Debug.Log("Hi" + " " + "Everyone");

        Debug.Log("123" + "456"); // => 123456(o) ���ڿ� + ���ڿ� => ���ڿ�
        Debug.Log("123" + 456); // => 123456(o) ���ڿ� + ���� => ���ڿ�

        Debug.Log(123 + "456" + 789 + 890); // => 1234561679(x) 123456789890 ���� + ���ڿ� => ���ڿ�
        Debug.Log(123 + 456); // => 579(o) ���� + ���� => ����

        Debug.Log("123" + true); // => 123(x) 123True ���ڿ� + bool�� => ���ڿ�

        // Debug.Log("123" - 456); // ���ڿ����� ������ ������ ���� ����

        // ���ڿ��� �ϳ��� ���� ���ڿ��� ���
    }

}
