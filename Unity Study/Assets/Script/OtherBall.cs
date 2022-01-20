
using UnityEngine;

public class OtherBall : MonoBehaviour
{

    // 오브젝트의 재질 접근은 MeshRenderer를 통해서.
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }


    // Collision : 충돌 정보 클래스
    // CollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            // Color : 기본 색상 클래스, Color32 : 255 색상 클래스
            mat.color = new Color(0, 0, 0);
    }



    // CollisionStay : 물리적 충돌이 일어나고 있을 때 호출되는 함수.
    private void OnCollisionStay(Collision collision)
    {

    }



    // CollisionExit : 물리적 충돌이 끝났을 때 호출되는 함수.
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }
}

// 출처 : https://www.youtube.com/watch?v=salZ7t98xi8&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=12