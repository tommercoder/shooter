using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public Transform firePoint1;
    public GameObject bullet = null;

    public float force1 = 20f; 



    void Update()
    {
        if(Input.GetButtonDown("Fire1") && statistics.instance.bulletsCount > 0)
        {
            shoot();
        }
    }


    void shoot()
    {
        GameObject bulletG = Instantiate(bullet, firePoint1.position, firePoint1.rotation);
        statistics.instance.bulletsCount -= 1;
        Rigidbody2D rb = bulletG.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint1.right*force1,ForceMode2D.Impulse);
    }
}
