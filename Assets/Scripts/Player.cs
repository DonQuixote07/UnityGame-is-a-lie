using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce = 5.0f; // 점프 힘 조절
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // 새의 Rigidbody2D 컴포넌트 가져오기
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump")) // "Jump" 버튼(예: 스페이스바 또는 마우스 왼쪽 버튼)을 누를 때 점프
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce; // 점프할 때 속도를 설정하여 새가 위로 올라가도록 함
    }
}