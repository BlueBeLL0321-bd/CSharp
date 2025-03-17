using UnityEngine;

namespace PrivatePublic
{
    public class PublicField : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // Category 클래스의 인스턴스 생성
            Category book = new Category();

            // 필드에 데이터 저장 - 객체 이름.멤버 이름
            book.CategoryName = "책";

            // (다른 클래스의) 필드 사용
            Debug.Log(book.CategoryName);
        }
    }
}

