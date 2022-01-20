
using UnityEngine;

public class MyBall : MonoBehaviour
{

    Rigidbody rigid;

    void Start()
    {
        // GetComponent<T> : �ڽ��� TŸ�� ������Ʈ�� ������.
        rigid = GetComponent<Rigidbody>();
    }

    // Rigidbody ���� �ڵ�� FixedUpdate�� �ۼ�!
    void FixedUpdate()
    {
        // 1. �ӷ� �ٲٱ�
        #region
        // velocity : ���� �̵� �ӵ�
        //rigid.velocity = Vector3.forward;
        //rigid.velocity = new Vector3(2, 4, -1);
        #endregion



        // 2. ���� ���ϱ�
        #region
        
        // AddForce(Vec) : Vec�� ����� ũ��� ���� ��.
        // ForceMode : ���� �ִ� ��� (����, ���� �ݿ�)
        // Mass ���� ���� Ŭ���� �����̴µ� �� ���� ���� �ʿ�.
        //rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);

        // Jump
        // AddForce�� �� �������� ��� �ӵ� velocity�� ����
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical")
            );

        rigid.AddForce(vec, ForceMode.Impulse);
        
        #endregion



        // 3. ȸ����
        #region
        // AddTorque(Vec) : Vec ������ ������ ȸ������ ����
        // Vec�� ������ ��� ������ �̵� ���⿡ ����!
        //rigid.AddTorque(Vector3.up);
        #endregion
    }



    // TriggerStay : �ݶ��̴��� ��� �浹�ϰ� ���� �� ȣ��.
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }





    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}

// ��ó : https://www.youtube.com/watch?v=kYmYCMAiOUk&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=10
// ��ó : https://www.youtube.com/watch?v=salZ7t98xi8&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=12
// ��ó : https://www.youtube.com/watch?v=k4YUJy-otDs&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=13