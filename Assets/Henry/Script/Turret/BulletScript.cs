using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject projectile;
    bool canShoot;
    float time = 0.0f;
    float ShotTimer = .25f;
    void Start()
    {
        canShoot = true;
    }
    void Update()
    {
        time += Time.deltaTime;

        if (time >= ShotTimer)
        {
            time = time - ShotTimer;
            if (canShoot == true)
            {
                transform.localEulerAngles = new Vector3(Random.Range(-15,15), 0, transform.localEulerAngles.z);
                SpawnBullet();
            }
        }
    }
    public void SpawnBullet()
    {
        GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * 1000.0f);
    }
  public bool CanFire()
    {
        return canShoot;
    }
}
