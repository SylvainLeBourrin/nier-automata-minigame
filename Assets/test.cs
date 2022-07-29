using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float speed = 6f;
    public float jump = 8f;
    public float gravity = 20f;
    private Vector3 moveD = Vector3.zero;
    Rigidbody Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void Update()
    {
         /* if (Player.isGrounded)
        {
            moveD = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveD = transform.TransformDirection(moveD);
            moveD *= speed;
            if (Input.GetButton("Jump"))
            {
                moveD.y = jump;

            }
        }*/
        
        moveD.y -= gravity * Time.deltaTime;
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * speed * 10);
        transform.Rotate(Vector3.right * Input.GetAxis("Vertical") * Time.deltaTime * speed * 10);
        // transform.position(Vector3.up * Input.GetAxis("Horizontal") * Time.deltaTime * speed * 10);
        //transform.position(Vector3.right * Input.GetAxis("Vertical") * Time.deltaTime * speed * 10);
       // Player.Move(moveD * Time.deltaTime);

    }

}