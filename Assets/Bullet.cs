using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    /* [SerializeField] private GameObject food;
    private void ThrowFood()
    {
        // get key bas�l� tutmada sonsuz �al��ma , GetKeyUp basmay� b�rak�nca �al���r, GetKeyDown bas�nca �al���r

        if (Input.GetMouseButtonDown(0))
        {
            //olu�turma kodu instantiate
            //1. item 2. yer(oldugum yerde olu�tursun, 3. rotasyon
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
