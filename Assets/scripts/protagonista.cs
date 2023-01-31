using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class protagonista : MonoBehaviour {

    Rigidbody2D body;

    float horizontal;
    float vertical;

    [Range(0, 10.0f)][SerializeField] private float velocidade = 3.0f;

    void Start() {
        body = GetComponent<Rigidbody2D>(); 
    }

    private void FixedUpdate() {  
        body.velocity = new Vector2(horizontal * velocidade, vertical * velocidade);
    }

    void Update() {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical"); 
    }
}
