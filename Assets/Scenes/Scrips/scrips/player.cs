using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("プレイヤーのスピード")] public float speed = 2.0f;
    private CharacterController controller;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        //if(controller.isGrounded)
        //{
        //    if(Input.GetMouseButtonDown(0))
        //    {
        //        moveDirection.y = 20;
        //    }
        //}
        //moveDirection.y -= 10 * Time.deltaTime;
        //controller.Move(moveDirection * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //ゲームオーバー
        Destroy(gameObject);
    }
}
