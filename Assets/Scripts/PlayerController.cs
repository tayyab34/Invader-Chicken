using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D PlayerRb;
    private float speed = 15f;
    public GameObject bulletPrefab;
    private int health=100;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * speed * Time.deltaTime * horizontalInput);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
        }
    }
    private void FireBullet()
    {
        Instantiate(bulletPrefab,new Vector3(transform.position.x-0.34f, -2.77f, 0), bulletPrefab.transform.rotation);
        Instantiate(bulletPrefab,new Vector3(transform.position.x+0.34f, -2.77f, 0), bulletPrefab.transform.rotation);

    }
    public void AddHealth(int healthtoadd)
    {
        health += healthtoadd;
        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
}
