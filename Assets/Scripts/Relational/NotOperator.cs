using UnityEngine;

// Not Operator(���� ������) : ! ���̸� �����̰�, �����̸� ������ ��ȯ
public class NotOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] ���� ��
        Debug.Log(!true); // => false

        // [2] ������ ��
        Debug.Log(!false); // => true

        // [3]
        bool bln = false;

        Debug.Log(!bln); // => true
        Debug.Log(!!bln); // => true (x) false
        Debug.Log(!(!(!bln))); // => true
    }
}
