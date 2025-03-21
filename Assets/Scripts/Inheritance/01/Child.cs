using UnityEngine;

namespace Inheritance
{
    // 부모 클래스의 자식 클래스라고 선언
    // class 자식 클래스 이름 : 부모
    public class Child : Parent
    {
        public void Bar()
        {
            Debug.Log("자식 클래스 멤버 호출");
        }
    }
}