using UnityEngine;

public class DesceSimples : inimigo {

    private Rigidbody2D body;

    [Range(0, 5f)][SerializeField] protected float velocidade = 1f;

    void Start() {
        body = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        body.velocity = new Vector2(0, -(velocidade));
    }

    void Update() {
        if (isForaDaTela())
            Destroy(gameObject);
    }
}
