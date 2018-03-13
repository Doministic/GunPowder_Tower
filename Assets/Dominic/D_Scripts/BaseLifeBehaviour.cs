using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseLifeBehaviour : MonoBehaviour {

	
	private int health;
	private int minHealth = 0;
	private int maxHealth = 100;


	void Start()
	{
		health = maxHealth;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "regEnemyBullet"){
			health -= 10;
			if(health <= minHealth){
				Die(); 
			}
		}
	}

	void Die(){
		Destroy(gameObject);
	}
}
