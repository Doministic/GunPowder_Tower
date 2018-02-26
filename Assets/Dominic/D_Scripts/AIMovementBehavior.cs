using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovementBehavior : MonoBehaviour {

	public Transform targetMoveToObject;
	public Transform currentSpawnLocation;
	public float maxMovementSpeed = 7.5f;
	public float minMovementSpeed = 3.5f;


	private int health;
	private int maxHealth = 100;
	private int minHealth = 0;
	private float step;

	void Start () {	
		step = Random.Range(minMovementSpeed, maxMovementSpeed);
		health = maxHealth;
		StartCoroutine(MoveEnemy());

	}
	IEnumerator MoveEnemy(){
		while(transform.position != targetMoveToObject.position){
			transform.position = Vector3.MoveTowards(transform.position, targetMoveToObject.position, step);
			yield return null;
		}
	}
	public void OnCollisionEnter(Collision otherCollider){
		if(otherCollider.gameObject.tag == "HomeBase"){
			Die();
		}
		else if ( otherCollider.gameObject.tag == "regBullet") {
			TakeDamage(50);
			Debug.Log(health);
		}
	}
	public void TakeDamage(int damage){
		health -= damage;
		if(health <= minHealth){
			Die();
		}

	}
	private void Die(){
		DestroyObject(gameObject);
	}
}
 