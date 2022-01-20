
using UnityEngine;

public class OtherBall : MonoBehaviour
{

    // ������Ʈ�� ���� ������ MeshRenderer�� ���ؼ�.
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }


    // Collision : �浹 ���� Ŭ����
    // CollisionEnter : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            // Color : �⺻ ���� Ŭ����, Color32 : 255 ���� Ŭ����
            mat.color = new Color(0, 0, 0);
    }



    // CollisionStay : ������ �浹�� �Ͼ�� ���� �� ȣ��Ǵ� �Լ�.
    private void OnCollisionStay(Collision collision)
    {

    }



    // CollisionExit : ������ �浹�� ������ �� ȣ��Ǵ� �Լ�.
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color(1, 1, 1);
    }
}

// ��ó : https://www.youtube.com/watch?v=salZ7t98xi8&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=12