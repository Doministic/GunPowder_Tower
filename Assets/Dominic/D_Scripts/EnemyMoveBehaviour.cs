using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveBehaviour : MonoBehaviour
{

    public Transform objectToMoveTo;
    public float maxMovementSpeed = 7.5f;
    public float minMovementSpeed = 3.5f;

    private float step = 0.0f;
    public int health;
    private int maxHealth = 100;
    private int minHealth = 0;
	private float distanceToTarget;

    void Start()
    {
		
		Debug.Log(distanceToTarget);
        health = maxHealth;
        step = Random.Range(minMovementSpeed, maxMovementSpeed);
        StartCoroutine(MoveTo(step));
    }

    IEnumerator MoveTo(float step)
    {
        while (true)
        {
            transform.position = Vector3.MoveTowards(transform.position, objectToMoveTo.position, step * Time.deltaTime);
            yield return null;
			
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            Time.timeScale = 1;
        }
		distanceToTarget = Vector2.Distance(transform.position, objectToMoveTo.position);
        if (distanceToTarget < 5.0f)
		{
			Debug.Log("Coroutine Stopped, Movement stopped");
			StopAllCoroutines();
		}

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Base")
        {
            Debug.LogWarning("Entered Base");
            Die();
        }
        else if (other.gameObject.tag == "regBullet")
        {
            health -= 25;
            if (health <= minHealth)
            {
                Die();
            }

        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
