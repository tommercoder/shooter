using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{

    public Transform firePoint1;
    public Animator anim;
    public GameObject bullet = null;
    public GameObject[] all_bullets;
    public float force1 = 20f;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            shoot();
            
        }
    }


    void shoot()
    {
        GameObject bulletG = Instantiate(bullet, firePoint1.position, firePoint1.rotation);
        if (tempController.instance.firstWave)
        {
            anim.SetTrigger("Shoot");
            bullet = all_bullets[0];
        }
        else if(tempController.instance.secondWave)
        {
            anim.SetTrigger("shotgunShoot");
            bullet = all_bullets[1];
        }
        else if(tempController.instance.thirdWave)
        {
            anim.SetTrigger("rifleShoot");
        }

        Rigidbody2D rb = bulletG.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint1.right*force1,ForceMode2D.Impulse);
    }
}
