using UnityEngine;

public class inimigo : MonoBehaviour {

    [Range(0, 5f)][SerializeField] protected float velocidade = 1f;

    protected Rigidbody2D body;

    protected bool isForaDaTela() {
        return transform.position.x > 5.0f
            || transform.position.x < -7.0f
            || transform.position.y > 6.0f
            || transform.position.y < -6.0f;
    }
}
