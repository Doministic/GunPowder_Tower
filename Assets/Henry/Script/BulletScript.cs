using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject projectile;
    bool TimeToShoot;
    float time = 0.0f;
    float ShotTimer = 1.0f;
    void Start()
    {
        TimeToShoot = true;
    }
    void Update()
    {
        time += Time.deltaTime;

        if (time >= ShotTimer)
        {
            time = time - ShotTimer;
            if (TimeToShoot == true)
            {
                SpawnBullet();
            }
        }
    }
    public void SpawnBullet()
    {
        GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(transform.up * 1000.0f);
    }
    public void CantFire()
    {
        TimeToShoot = false;
        print("I Cant shoot");
    }
    public void CanFire()
    {
        TimeToShoot = true;
        print("I Cant shoot");
    }
}
