using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    /* [SerializeField] private GameObject food;
    private void ThrowFood()
    {
        // get key basýlý tutmada sonsuz çalýþma , GetKeyUp basmayý býrakýnca çalýþýr, GetKeyDown basýnca çalýþýr

        if (Input.GetMouseButtonDown(0))
        {
            //oluþturma kodu instantiate
            //1. item 2. yer(oldugum yerde oluþtursun, 3. rotasyon
            Instantiate(food, transform.position, food.transform.rotation);
        }

    }
    void Update()
    {
        ThrowFood();
    }
    */

    public float moveForce;
    public GameObject bullet;
    public Transform gun;
    public float shootRate;
    public float shootForce;
    private float m_shootRateTimeStamp;
    Animator m_Animator;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > m_shootRateTimeStamp)
            {
                GameObject go = (GameObject)Instantiate(
                bullet, gun.position, gun.rotation);

                go.GetComponent<Rigidbody>().AddForce(gun.forward * shootForce);
                m_shootRateTimeStamp = Time.time + shootRate;
            }

        }

    }

}
