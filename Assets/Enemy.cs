using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public int health = 100;

	public GameObject deathEffect;

	public void TakeDamage (int damage)
	{
		health -= damage;

		if (health <= 0)
		{
			
			StartCoroutine(vey());
		}
	}

	IEnumerator vey(){
		yield return new WaitForSeconds(2f);
		Destroy(gameObject);
	}


}
