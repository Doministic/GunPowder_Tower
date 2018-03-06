using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveBehaviour : MonoBehaviour {

	public Transform objectToMoveTo;
 	public float maxMovementSpeed = 7.5f;
    public float minMovementSpeed = 3.5f;

	private float step = 0.0f;

	private int health;
    private int maxHealth = 100;
    private int minHealth = 0;

	void Start()
	{
		health = maxHealth;
		step = Random.Range(minMovementSpeed, maxMovementSpeed);
	//	StartCoroutine(MoveTo(step)); 
	}

	/*IEnumerator MoveTo(float step){
		while (true){
			
			yield return null;
		}
	}*/

	void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, objectToMoveTo.position, step * Time.deltaTime);
		if(Input.GetKeyDown(KeyCode.P)){
			Time.timeScale = 0;
		} else if (Input.GetKeyDown(KeyCode.L)){
			Time.timeScale = 1;
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "HomeBase" || other .gameObject.tag == "Base"){
			Die();
		}
		else if(other.gameObject.tag == "regBullet"){
			health -= 25;
			if (health <= 0)
			{
				Die();
			}
				
		}
	}

	void Die(){
		Destroy(gameObject);
	}
}
