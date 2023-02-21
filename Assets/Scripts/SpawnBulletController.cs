using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{

    public GameObject bullet;
    public float interval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ShootBullet", interval, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShootBullet()
    {
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
