using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5.0f; // ���� �� ����
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // ���� Rigidbody2D ������Ʈ ��������
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump")) // "Jump" ��ư(��: �����̽��� �Ǵ� ���콺 ���� ��ư)�� ���� �� ����
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce; // ������ �� �ӵ��� �����Ͽ� ���� ���� �ö󰡵��� ��
    }
}