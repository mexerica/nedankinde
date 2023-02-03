using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingBall : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    private float initialSpd = 400;
    Vector3 newSpd;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(20 * Time.deltaTime * initialSpd, 20 * Time.deltaTime * initialSpd));
    }

    // Update is called once per frame
    void Update()
    {
        newSpd = rb.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var spd = newSpd.magnitude;
        var direction = Vector3.Reflect(newSpd.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(spd, 0f);
    }
}
