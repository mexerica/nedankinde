using UnityEngine;

/// <summary>
/// Só desce só, msm...
/// </summary>
public class DesceSimples : inimigo {

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
