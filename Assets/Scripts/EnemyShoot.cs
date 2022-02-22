using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public float fireRate = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Fire", fireRate, fireRate);
    }

    void Fire()
    {
        Instantiate(bullet,new Vector3(transform.position.x,transform.position.y-1.34f,0), bullet.transform.rotation);
    }
}
