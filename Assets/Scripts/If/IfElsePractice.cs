using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 65;
        string medal = "";

        // [1] 90점 이상이면 금메달
        if(score >= 90)
        {
            medal = "금메달";
        }
        else
        {
            // [2] 80점 이상이면 은메달
            if(score >= 80)
            {
                medal = "은메달";
            }
            else
            {
                // [3] 70점 이상이면 동메달
                if(score >= 70)
                {
                    medal = "동메달";
                }
                else
                {
                    medal = "노메달";
                }
            }
        }

        Debug.Log($"{medal}을 수상하였습니다");
    }
}
