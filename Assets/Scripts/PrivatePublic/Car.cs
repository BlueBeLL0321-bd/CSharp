using UnityEngine;

namespace PrivatePublic
{
    public class Car
    {
        // 필드(전역 변수, 멤버 변수) - public, private
        public string name; // 이름
        private int age; // 나이
        string address; // 접근 제한자가 생략되면 기본값인 private으로 설정

        // 멤버 메서드 - public, private
        public void Hi()
        {
            Debug.Log("안녕하세요");
        }

        private void Bye()
        {
            Debug.Log("안녕히 계세요");
        }
    }

}