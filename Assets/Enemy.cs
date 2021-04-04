using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;
	public int damage = 10;
	public int scoreForDeath;
	public GameObject deathEffect;
	public GameObject player;
	public bool kicked = false;
    private void Start()
    {
		damage = 10;
		scoreForDeath = 10;
		player = GameObject.FindGameObjectWithTag("Player");
    }
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
		statistics.instance.scoreInt += scoreForDeath;
		statistics.instance.score.text = "score:" + statistics.instance.scoreInt;
		Destroy(gameObject);
	}
    private void FixedUpdate()
    {
        if (kicked)
        {
			player.GetComponent<Rigidbody2D>().AddForce(transform.right * 20, ForceMode2D.Impulse);
			
		}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
		if (collision.gameObject.CompareTag("Player"))
		{
			Debug.Log("enemy collide with player");
			playerHealth.instance.currentHealth -= damage;
			kicked = true;
			

			
		}
	}
    
}
