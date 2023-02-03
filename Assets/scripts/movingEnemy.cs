using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    private float direction = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(direction * 1, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Ball")
        {
            direction *= -1;
        }
    }
}
