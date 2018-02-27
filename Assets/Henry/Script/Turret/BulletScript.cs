using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public GameObject projectile;
    bool CanShoot;
    float time = 0.0f;
    float ShotTimer = 1.0f;
    void Start()
    {
        CanShoot = true;
    }
    void Update()
    {
        time += Time.deltaTime;

        if (time >= ShotTimer)
        {
            time = time - ShotTimer;
            if (CanShoot == true)
            {
                SpawnBullet();
            }
        }
    }
    public void SpawnBullet()
    {
        GameObject bullet = Instantiate(projectile, transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000.0f);
    }
    public void CantFire()
    {
        CanShoot = false;
        print("I Cant shoot");
    }
    public void CanFire()
    {
        CanShoot = true;
        print("I Cant shoot");
    }
}
