using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 65;
        string medal = "";

        // [1] 90�� �̻��̸� �ݸ޴�
        if(score >= 90)
        {
            medal = "�ݸ޴�";
        }
        else
        {
            // [2] 80�� �̻��̸� ���޴�
            if(score >= 80)
            {
                medal = "���޴�";
            }
            else
            {
                // [3] 70�� �̻��̸� ���޴�
                if(score >= 70)
                {
                    medal = "���޴�";
                }
                else
                {
                    medal = "��޴�";
                }
            }
        }

        Debug.Log($"{medal}�� �����Ͽ����ϴ�");
    }
}
