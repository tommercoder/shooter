using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;

	public GameObject deathEffect;
	public GameObject player;
	public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			
			Die();
			//Destroy(gameObject);
		}
	}

	void Die ()
	{
		//Instantiate(deathEffect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.CompareTag("Player"))
		{
			Debug.Log("enemy collide with player");
			playerHealth.instance.currentHealth -= 50;
			player.GetComponent<Rigidbody2D>().AddForce(transform.forward * 2);

			
		}
	}
    
}
