using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveBehaviour : MonoBehaviour
{

    public Transform objectToMoveTo;
    public float maxMovementSpeed = 7.5f;
    public float minMovementSpeed = 3.5f;
    public float stoppingDistance = 5.0f;
    public float shootingDistance = 8.0f;
    public float timeTillDestroy = 5;

    private float step = 0.0f;
    private int health;
    private int maxHealth = 100;
    private int minHealth = 0;

    void Start()
    {
        health = maxHealth;
        step = Random.Range(minMovementSpeed, maxMovementSpeed);
        StartCoroutine(MoveTo(step));
    }

    IEnumerator MoveTo(float step)
    {
        while (true)
        {
            transform.position = Vector2.MoveTowards(transform.position, ClosestEnemy().transform.position, step * Time.deltaTime);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, ClosestEnemy().transform.rotation, step * Time.deltaTime);
            yield return null;	
        }
    }

    void Update()
    {
		float distanceToTarget = Vector2.Distance(transform.position, ClosestEnemy().transform.position);
        if (distanceToTarget <= stoppingDistance)
		{
			//Debug.Log("Coroutine Stopped, Movement stopped");
			StopAllCoroutines();
			Destroy(gameObject, timeTillDestroy);
		}
        if (distanceToTarget <= shootingDistance){
            GetComponentInChildren<EnemyBulletBehavior>().enabled = true;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Base")
        {
            Debug.LogWarning("Entered Base");
            Die();
        }
        else if (other.gameObject.tag == "regFriendlyBullet")
        {
            health -= 25;
            if (health <= minHealth)
            {
                Die();
            }

        }
    }

	public GameObject ClosestEnemy(){
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Base");
        GameObject closestEnemy =  gos[0];
        Vector3 position = gos[0].transform.position;
        foreach(GameObject go in gos){
            Vector2 diff = go.transform.position - position;
            if(Vector2.Distance(diff, transform.position) > Vector2.Distance(closestEnemy.transform.position, transform.position)){
                closestEnemy = gos[0];
            }
        }
        return closestEnemy;

	}
    void Die()
    {
        Destroy(gameObject);
    }
}
