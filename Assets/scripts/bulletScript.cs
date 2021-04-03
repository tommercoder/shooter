using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public GameObject gitEffect;
    public int damage = 30;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(gitEffect, transform.position, Quaternion.identity);
        Destroy(effect, 1f);
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if(enemy != null){
            enemy.TakeDamage(damage);
        }
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
