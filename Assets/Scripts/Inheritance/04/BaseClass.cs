using UnityEngine;

namespace Inheritance04
{
    public class BaseClass : System.Object // 모든 클래스는 Object 클래스로부터 상속
    {
        protected void PrintLog()
        {
            Debug.Log("부모 클래스에서 호출");
        }
    }
}
