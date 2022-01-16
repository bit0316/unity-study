
using UnityEngine;

// Vector3 Ŭ�������� �����ϴ� �̵� �Լ�
public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);

    void Update()
    {
        // 1. MoveTowards (�ܼ� ��� �̵�)
        // �Ű������� (������ġ, ��ǥ��ġ, �ӵ�)�� ����
        // ������ �Ű������� ����Ͽ� �ӵ� ����
        transform.position = Vector3.MoveTowards(transform.position, target, 1f);



        // 2. SmoothDamp (�̲��������� ���� �̵�)
        // �ε巯�� ���� �̵�
        // �Ű������� (������ġ, ��ǥ��ġ, ���� �ӵ�, �ӵ�)
        // ������ �Ű������� �ݺ���Ͽ� �ӵ� ����
        // ref : ���� ���� -> �ǽð����� �ٲ�� �� ���� ����

        //Vector3 velo = Vector3.up * 50;
        Vector3 velo = Vector3.zero;

        transform.position = Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);



        // 3. Lerp (���� ���� �̵�)
        // Lerp : ���� ����, SmoothDamp���� ���ӽð��� ��
        // ������ �Ű������� ����Ͽ� �ӵ� ���� (�ִ밪 1)
        transform.position = Vector3.Lerp(transform.position, target, 0.005f);



        // 4. Slerp (���� ���� ���� �̵�)
        // Slerp : ���� ���� ����, ȣ�� �׸��� �̵�
        transform.position = Vector3.Slerp(transform.position, target, 0.005f);


    }
}