using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFireMovement : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rb;
    private PlayerController player;
    private GameManager gamemanager;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player").GetComponent<PlayerController>();
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.down * speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.AddHealth(-20);
            gamemanager.AddLives(-1);
        }
    }
}
