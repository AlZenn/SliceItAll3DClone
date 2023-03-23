using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ileri : MonoBehaviour
{
    //public int speed;
    public float lifeTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().velocity = transform.forward * speed;

        // Destroy the bullet after the specified lifetime
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
