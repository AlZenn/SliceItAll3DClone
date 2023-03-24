using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForce = 5f;    // ziplama deðeri
    public float gravity = 5f;      // yercekimi
    private Rigidbody rb;         
    public float egilmehiz = 0.2f;
    public float maksegil = 0.0f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Vector3 move = new Vector3(0, 0, Input.GetAxis("Vertical"));
        transform.position += new Vector3(speed*Time.deltaTime,0f,0f);

        //zýplama kodu
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jumpForce;
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 60.0f);

        }
        else
        {
            if (transform.eulerAngles.z > maksegil)
            {
                transform.eulerAngles -= new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, egilmehiz);
            }
        }
        //yerçekimi
        rb.velocity += Vector3.down * gravity * Time.deltaTime;
    }
}
