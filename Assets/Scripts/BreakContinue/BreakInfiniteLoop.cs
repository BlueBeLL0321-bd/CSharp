using UnityEngine;

// break로 무한 루프 빠져나오기
public class BreakInfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //무한 루프 - 무한 반복
        /*for (; ; )
        {
        }*/
        /*while (true)
        {
        }*/

        int number = 0;

        // number가 5 이상이면
        while (true) // 무한 루프
        {
            // 반복 실행문

            number++;
            if(number >= 5)
            {
                break;
            }
        }
    }
}
