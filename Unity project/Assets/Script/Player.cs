using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed;
    public float TurnSpeed;
    public Rigidbody rigid;
    public int JumpPower;


    public bool IsJumping;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        IsJumping = false;
        TurnSpeed = 1f;
}
    void Update()
    {
        
        Jump();
        Move();
        Turn();
    }

    void Jump()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //바닥에 있냐?!
            if (!IsJumping) //바닥이다!
            {
                IsJumping = true;
                rigid.AddForce(Vector3.up * JumpPower, ForceMode.Impulse); //즉발적인 힘
            }

            else
            {
                return;
            }
        }
    }

    void OnCollisionEnter(Collision collision) // 이벤트 함수 
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            IsJumping = false;
        }
    }
    void Move()
    {
        transform.position += new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical"))
             * Speed * Time.deltaTime;
    }

    void Turn()
    {
        if (Input.GetKey("e"))
        {
            transform.Rotate(Vector3.up * TurnSpeed);
        }
        else if (Input.GetKey("q"))
        {
            transform.Rotate(Vector3.down * TurnSpeed);
        }
    }
}
