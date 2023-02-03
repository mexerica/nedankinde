using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageBall : MonoBehaviour
{
    [SerializeField] private float life;
    // Update is called once per frame
    void Update()
    {
        if (life <= 0) Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            life -= 1;
        }
    }
}
